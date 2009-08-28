﻿//-----------------------------------------------------------------------
// <copyright file="TestTranslateClient.cs" company="iron9light">
// Copyright (c) 2009 iron9light
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// </copyright>
// <author>iron9light@gmail.com</author>
//-----------------------------------------------------------------------

namespace Google.API.Translate.Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;

    using NUnit.Framework;

    [TestFixture]
    public class TestTranslateClient
    {
        private static readonly ICollection<Language> undetectable = new[]
            {
                Language.ChineseSimplified,
                Language.Croatian,
                Language.Czech,
                Language.Filipino,
                Language.Greek,
                Language.Hindi,
                Language.Irish,
                Language.Norwegian,
                Language.Portuguese,
                Language.Welsh,
                Language.Yiddish,
            };

        private TranslateClient Client { get; set; }

        [SetUp]
        public void SetUp()
        {
            this.Client = new TranslateClient();
        }

        [Test]
        public void TranslateTest()
        {
            var originalLanguage = Language.English;
            var originalText = "dog";

            Print(originalLanguage, originalText);

            ICollection<Language> skippedLanguages = new[] { Language.Galician, Language.Thai, };

            foreach (var language in LanguageUtility.TranslatableCollection)
            {
                if (language == originalLanguage)
                {
                    continue;
                }

                if (skippedLanguages.Contains(language))
                {
                    continue;
                }

                var translatedText = this.Client.Translate(originalText, originalLanguage, language);
                Assert.AreNotEqual(
                    originalText,
                    translatedText,
                    "[{0} -> {1}] {2} : translate failed! Because the result is same to the original one.",
                    originalLanguage,
                    language,
                    originalText);

                Print(language, translatedText);

                var transbackText = this.Client.Translate(translatedText, language, originalLanguage);
                StringAssert.AreEqualIgnoringCase(
                    originalText,
                    transbackText.Trim(),
                    "[{0} -> {1}] {2} -> {3} != {4}: translate faild!",
                    language,
                    originalLanguage,
                    translatedText,
                    transbackText,
                    originalText);
            }
        }

        [Test]
        public void TranslateTestForHtml()
        {
            // TODO : The test case TranslateTestForHtml is not stable. There may add some space after being translated.
            var from = Language.English;
            var to = Language.ChineseSimplified;

            var textTemplate = "<html><head><title>{0} </title></head><body> <b>{1}</b> </body></html>";

            var sentenceA = "You are my sunshine.";
            var sentenceB = "Show me the money.";

            var text = string.Format(textTemplate, sentenceA, sentenceB);

            var translatedA = this.Client.Translate(sentenceA, from, to);

            var translatedB = this.Client.Translate(sentenceB, from, to);

            var translatedText = this.Client.Translate(text, from, to, TranslateFormat.html);

            var expectedText = string.Format(textTemplate, translatedA.Trim(), translatedB.Trim());

            StringAssert.AreEqualIgnoringCase(
                expectedText,
                translatedText,
                string.Format("expected:\t{1}{0}actual:\t{2}", Environment.NewLine, expectedText, translatedText));
        }

        [Test]
        public void TranslateAndDetectTest()
        {
            var text = "I love this game.";

            Language from;
            var to = Language.English;

            var translated = this.Client.TranslateAndDetect(text, to, out from);

            Assert.AreEqual(Language.English, from);
            StringAssert.AreEqualIgnoringCase(text, translated);
        }

        [Test]
        public void DetectTest()
        {
            var originalLanguage = Language.English;
            var originalText = "This is an apple. I love apple. I eat apple everyday.";

            Print(originalLanguage, originalText);

            foreach (var language in LanguageUtility.TranslatableCollection)
            {
                if (language == originalLanguage)
                {
                    continue;
                }

                if (IsUndetectable(language))
                {
                    continue;
                }

                var translatedText = this.Client.Translate(originalText, originalLanguage, language);
                Assert.AreNotEqual(
                    originalText,
                    translatedText,
                    "[{0} -> {1}] {2} : translate failed! Because the result is same to the original one.",
                    originalLanguage,
                    language,
                    originalText);

                bool isReliable;
                double confidence;
                var detectedLanguage = this.Client.Detect(translatedText, out isReliable, out confidence);

                var more = string.Format("isReliable : {0}, confidence : {1}", isReliable, confidence);
                Print(language, translatedText, more);

                Assert.AreEqual(
                    language,
                    detectedLanguage,
                    "[{0} != {1}] {2} ({3}): detect failed!",
                    detectedLanguage,
                    language,
                    translatedText,
                    more);
            }
        }

        [Test, Ignore]
        public void TranslateLongText()
        {
            var from = Language.English;
            var to = Language.ChineseSimplified;

            var text = this.GetText();

            Console.WriteLine("Text length: {0}", text.Length);
            Console.WriteLine();

            var translated = this.Client.Translate(text, from, to, TranslateFormat.html);

            Console.WriteLine("Translated text length: {0}", translated.Length);
            Console.WriteLine();

            Console.WriteLine(translated);
        }

        private static bool IsUndetectable(Language language)
        {
            return undetectable.Contains(language);
        }

        private static void Print(Language language, string text, string more)
        {
            Console.WriteLine("[{0}]\t{1}\t{2}", language, text, more);
        }

        private static void Print(Language language, string text)
        {
            Console.WriteLine("[{0}]\t{1}", language, text);
        }

        private string GetText()
        {
            var request = WebRequest.Create(@"http://en.wikipedia.org/wiki/Human");
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var text = reader.ReadToEnd();
                        return text;
                    }
                }
            }
        }
    }
}