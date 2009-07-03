//-----------------------------------------------------------------------
// <copyright file="IWebResult.cs" company="iron9light">
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
    /// <summary>
    /// Web search result.
    /// </summary>
    public interface IWebResult
    {
        /// <summary>
        /// Get the url.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Get a shortened version of the URL associated with the result.
        /// </summary>
        string VisibleUrl { get; }

        /// <summary>
        /// Get a url to google's cached version of the page responsible for producting this result. This property may be null indicating that there is no cache, and it might be out of date in cases where the search result has been saved and in the mean time, the cache has gone stale. For best results, this property should not be persisted.
        /// </summary>
        string CacheUrl { get; }

        /// <summary>
        /// Get the title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Get a brief snippet of information from the page associated with the search result.
        /// </summary>
        string Content { get; }
    }
}