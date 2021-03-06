//-----------------------------------------------------------------------
// <copyright file="NewsEdition.cs" company="iron9light">
// Copyright (c) 2010 iron9light
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

namespace Google.API.Search
{
    /// <summary>
    /// The edition of news.
    /// </summary>
    public sealed class NewsEdition : Enumeration<NewsEdition>
    {
        /// <summary>
        /// Argentina.
        /// </summary>
        public static readonly NewsEdition Argentina = new NewsEdition("Argentina", "es_ar");

        /// <summary>
        /// Australia.
        /// </summary>
        public static readonly NewsEdition Australia = new NewsEdition("Australia", "au");

        /// <summary>
        /// België.
        /// </summary>
        public static readonly NewsEdition BelgiumDutch = new NewsEdition("België", "nl_be");

        /// <summary>
        /// Belgique.
        /// </summary>
        public static readonly NewsEdition BelgiumFrench = new NewsEdition("Belgique", "fr_be");

        /// <summary>
        /// Botswana.
        /// </summary>
        public static readonly NewsEdition Botswana = new NewsEdition("Botswana", "en_bw");

        /// <summary>
        /// Brasil.
        /// </summary>
        public static readonly NewsEdition Brazil = new NewsEdition("Brasil", "pt-BR_br");

        /// <summary>
        /// Canada English.
        /// </summary>
        public static readonly NewsEdition CanadaEnglish = new NewsEdition("Canada English", "ca");

        /// <summary>
        /// Canada Français.
        /// </summary>
        public static readonly NewsEdition CanadaFrench = new NewsEdition("Canada Français", "fr_ca");

        /// <summary>
        /// Česká republika.
        /// </summary>
        public static readonly NewsEdition CzechRepublic = new NewsEdition("Česká republika", "cs_cz");

        /// <summary>
        /// Chile.
        /// </summary>
        public static readonly NewsEdition Chile = new NewsEdition("Chile", "es_cl");

        /// <summary>
        /// Colombia.
        /// </summary>
        public static readonly NewsEdition Colombia = new NewsEdition("Colombia", "es_co");

        /// <summary>
        /// Cuba.
        /// </summary>
        public static readonly NewsEdition Cuba = new NewsEdition("Cuba", "es_cu");

        /// <summary>
        /// Deutschland.
        /// </summary>
        public static readonly NewsEdition Germany = new NewsEdition("Deutschland", "de");

        /// <summary>
        /// España.
        /// </summary>
        public static readonly NewsEdition Spain = new NewsEdition("España", "es");

        /// <summary>
        /// Estados Unidos.
        /// </summary>
        public static readonly NewsEdition UnitedStatesSpanish = new NewsEdition("Estados Unidos", "es_us");

        /// <summary>
        /// Ethiopia.
        /// </summary>
        public static readonly NewsEdition Ethiopia = new NewsEdition("Ethiopia", "en_et");

        /// <summary>
        /// France.
        /// </summary>
        public static readonly NewsEdition France = new NewsEdition("France", "fr");

        /// <summary>
        /// Ghana.
        /// </summary>
        public static readonly NewsEdition Ghana = new NewsEdition("Ghana", "en_gh");

        /// <summary>
        /// India.
        /// </summary>
        public static readonly NewsEdition India = new NewsEdition("India", "in");

        /// <summary>
        /// Ireland.
        /// </summary>
        public static readonly NewsEdition Ireland = new NewsEdition("Ireland", "en_ie");

        /// <summary>
        /// Israel English.
        /// </summary>
        public static readonly NewsEdition IsraelEnglish = new NewsEdition("Israel English", "en_il");

        /// <summary>
        /// Italia.
        /// </summary>
        public static readonly NewsEdition Italy = new NewsEdition("Italia", "it");

        /// <summary>
        /// Kenya.
        /// </summary>
        public static readonly NewsEdition Kenya = new NewsEdition("Kenya", "en_ke");

        /// <summary>
        /// Magyarország.
        /// </summary>
        public static readonly NewsEdition Hungary = new NewsEdition("Magyarország", "hu_hu");

        /// <summary>
        /// Malaysia.
        /// </summary>
        public static readonly NewsEdition Malaysia = new NewsEdition("Malaysia", "en_my");

        /// <summary>
        /// México.
        /// </summary>
        public static readonly NewsEdition Mexico = new NewsEdition("México", "es_mx");

        /// <summary>
        /// Namibia.
        /// </summary>
        public static readonly NewsEdition Namibia = new NewsEdition("Namibia", "en_na");

        /// <summary>
        /// Nederland.
        /// </summary>
        public static readonly NewsEdition Netherlands = new NewsEdition("Nederland", "nl_nl");

        /// <summary>
        /// New Zealand.
        /// </summary>
        public static readonly NewsEdition NewZealand = new NewsEdition("New Zealand", "nz");

        /// <summary>
        /// Nigeria.
        /// </summary>
        public static readonly NewsEdition Nigeria = new NewsEdition("Nigeria", "en_ng");

        /// <summary>
        /// Norge.
        /// </summary>
        public static readonly NewsEdition Norway = new NewsEdition("Norge", "no_no");

        /// <summary>
        /// Österreich.
        /// </summary>
        public static readonly NewsEdition Austria = new NewsEdition("Österreich", "de_at");

        /// <summary>
        /// Pakistan.
        /// </summary>
        public static readonly NewsEdition Pakistan = new NewsEdition("Pakistan", "en_pk");

        /// <summary>
        /// Perú.
        /// </summary>
        public static readonly NewsEdition Peru = new NewsEdition("Perú", "es_pe");

        /// <summary>
        /// Philippines.
        /// </summary>
        public static readonly NewsEdition Philippines = new NewsEdition("Philippines", "en_ph");

        /// <summary>
        /// Polska.
        /// </summary>
        public static readonly NewsEdition Poland = new NewsEdition("Polska", "pl_pl");

        /// <summary>
        /// Portugal.
        /// </summary>
        public static readonly NewsEdition Portugal = new NewsEdition("Portugal", "pt-PT_pt");

        /// <summary>
        /// Schweiz.
        /// </summary>
        public static readonly NewsEdition SwitzerlandGerman = new NewsEdition("Schweiz", "de_ch");

        /// <summary>
        /// Sénégal.
        /// </summary>
        public static readonly NewsEdition Senegal = new NewsEdition("Sénégal", "fr_sn");

        /// <summary>
        /// Singapore.
        /// </summary>
        public static readonly NewsEdition Singapore = new NewsEdition("Singapore", "en_sg");

        /// <summary>
        /// South Africa.
        /// </summary>
        public static readonly NewsEdition SouthAfrica = new NewsEdition("South Africa", "en_za");

        /// <summary>
        /// Suisse.
        /// </summary>
        public static readonly NewsEdition SwitzerlandFrench = new NewsEdition("Suisse", "fr_ch");

        /// <summary>
        /// Sverige.
        /// </summary>
        public static readonly NewsEdition Sweden = new NewsEdition("Sverige", "sv_se");

        /// <summary>
        /// Tanzania.
        /// </summary>
        public static readonly NewsEdition Tanzania = new NewsEdition("Tanzania", "en_tz");

        /// <summary>
        /// Türkiye.
        /// </summary>
        public static readonly NewsEdition Turkey = new NewsEdition("Türkiye", "tr_tr");

        /// <summary>
        /// U.K..
        /// </summary>
        public static readonly NewsEdition UnitedKingdom = new NewsEdition("U.K.", "uk");

        /// <summary>
        /// U.S..
        /// </summary>
        public static readonly NewsEdition UnitedStates = new NewsEdition("U.S.", "us", true);

        /// <summary>
        /// Uganda.
        /// </summary>
        public static readonly NewsEdition Uganda = new NewsEdition("Uganda", "en_ug");

        /// <summary>
        /// Venezuela.
        /// </summary>
        public static readonly NewsEdition Venezuela = new NewsEdition("Venezuela", "es_ve");

        /// <summary>
        /// Việt Nam (Vietnam).
        /// </summary>
        public static readonly NewsEdition Vietnam = new NewsEdition("Việt Nam (Vietnam)", "vi_vn");

        /// <summary>
        /// Zimbabwe.
        /// </summary>
        public static readonly NewsEdition Zimbabwe = new NewsEdition("Zimbabwe", "en_zw");

        /// <summary>
        /// Ελλάδα (Greece).
        /// </summary>
        public static readonly NewsEdition Greece = new NewsEdition("Ελλάδα (Greece)", "el_gr");

        /// <summary>
        /// Россия (Russia).
        /// </summary>
        public static readonly NewsEdition Russia = new NewsEdition("Россия (Russia)", "ru_ru");

        /// <summary>
        /// Украина (Ukraine).
        /// </summary>
        public static readonly NewsEdition UkraineRussian = new NewsEdition("Украина (Ukraine)", "ru_ua");

        /// <summary>
        /// Україна (Ukraine).
        /// </summary>
        public static readonly NewsEdition UkraineUkrainian = new NewsEdition("Україна (Ukraine)", "uk_ua");

        /// <summary>
        /// ישראל (Israel).
        /// </summary>
        public static readonly NewsEdition Israel = new NewsEdition("ישראל (Israel)", "iw_il");

        /// <summary>
        /// الإمارات (UAE).
        /// </summary>
        public static readonly NewsEdition UAE = new NewsEdition("الإمارات (UAE)", "ar_ae");

        /// <summary>
        /// السعودية (KSA).
        /// </summary>
        public static readonly NewsEdition KSA = new NewsEdition("السعودية (KSA)", "ar_sa");

        /// <summary>
        /// العالم العربي (Arabic).
        /// </summary>
        public static readonly NewsEdition Arabic = new NewsEdition("العالم العربي (Arabic)", "ar_me");

        /// <summary>
        /// لبنان (Lebanon).
        /// </summary>
        public static readonly NewsEdition Lebanon = new NewsEdition("لبنان (Lebanon)", "ar_lb");

        /// <summary>
        /// مصر (Egypt).
        /// </summary>
        public static readonly NewsEdition Egypt = new NewsEdition("مصر (Egypt)", "ar_eg");

        /// <summary>
        /// हिन्दी (India).
        /// </summary>
        public static readonly NewsEdition IndiaHindi = new NewsEdition("हिन्दी (India)", "hi_in");

        /// <summary>
        /// தமிழ்(India).
        /// </summary>
        public static readonly NewsEdition IndiaTamil = new NewsEdition("தமிழ்(India)", "ta_in");

        /// <summary>
        /// తెలుగు (India).
        /// </summary>
        public static readonly NewsEdition IndiaTelugu = new NewsEdition("తెలుగు (India)", "te_in");

        /// <summary>
        /// മലയാളം (India).
        /// </summary>
        public static readonly NewsEdition IndiaMalayalam = new NewsEdition("മലയാളം (India)", "ml_in");

        /// <summary>
        /// 한국 (Korea).
        /// </summary>
        public static readonly NewsEdition Korea = new NewsEdition("한국 (Korea)", "kr");

        /// <summary>
        /// 中国版 (China).
        /// </summary>
        public static readonly NewsEdition China = new NewsEdition("中国版 (China)", "cn");

        /// <summary>
        /// 台灣版 (Taiwan).
        /// </summary>
        public static readonly NewsEdition ChinaTaiwan = new NewsEdition("台灣版 (Taiwan)", "tw");

        /// <summary>
        /// 日本 (Japan).
        /// </summary>
        public static readonly NewsEdition Japan = new NewsEdition("日本 (Japan)", "jp");

        /// <summary>
        /// 香港版 (Hong Kong).
        /// </summary>
        public static readonly NewsEdition ChinaHongKong = new NewsEdition("香港版 (Hong Kong)", "hk");

        private NewsEdition(string value)
            : base(value)
        {
        }

        private NewsEdition(string name, string value)
            : base(name, value)
        {
        }

        private NewsEdition(string name, string value, bool isDefault)
            : base(name, value, isDefault)
        {
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="Google.API.Search.NewsEdition"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator NewsEdition(string value)
        {
            return Convert(value, s => new NewsEdition(s));
        }
    }
}