﻿//-----------------------------------------------------------------------
// <copyright file="GblogSearcher.cs" company="iron9light">
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

namespace Google.API.Search
{
    using System.Collections.Generic;

    /// <summary>
    /// Utility class for Google Blog Search service.
    /// </summary>
    public static class GblogSearcher
    {
        /// <summary>
        /// Search blogs.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="resultCount">The count of result itmes.</param>
        /// <returns>The result items.</returns>
        /// <remarks>Now, the max count of items Google given is <b>32</b>.</remarks>
        /// <example>
        /// This is the c# code example.
        /// <code>
        /// IList&lt;IBlogResult&gt; results = GblogSearcher.Search("Coldplay", 32);
        /// foreach(IBlogResult result in results)
        /// {
        ///     Console.WriteLine("[{0} - {1:d} by {2}] {3} => {4}", result.Title, result.PublishedDate, result.Author, result.Content, result.BlogUrl);
        /// }
        /// </code>
        /// </example>
        public static IList<IBlogResult> Search(string keyword, int resultCount)
        {
            return Search(keyword, resultCount, new SortType());
        }

        /// <summary>
        /// Search blogs.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="resultCount">The count of result itmes.</param>
        /// <param name="sortBy">The way to order results.</param>
        /// <returns>The result items.</returns>
        /// <remarks>Now, the max count of items Google given is <b>32</b>.</remarks>
        /// <example>
        /// This is the c# code example.
        /// <code>
        /// IList&lt;IBlogResult&gt; results = GblogSearcher.Search("Coldplay", 32, SortType.relevance);
        /// foreach(IBlogResult result in results)
        /// {
        ///     Console.WriteLine("[{0} - {1:d} by {2}] {3} => {4}", result.Title, result.PublishedDate, result.Author, result.Content, result.BlogUrl);
        /// }
        /// </code>
        /// </example>
        public static IList<IBlogResult> Search(string keyword, int resultCount, SortType sortBy)
        {
            var client = new GblogSearchClient();
            return client.Search(keyword, resultCount, sortBy);
        }

        internal static SearchData<GblogResult> GSearch(
            string keyword, int start, ResultSize resultSize, SortType sortBy)
        {
            var client = new GblogSearchClient();
            return client.GSearch(keyword, start, resultSize, sortBy);
        }
    }
}