//-----------------------------------------------------------------------
// <copyright file="SortType.cs" company="iron9light">
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
    /// Sort type enum.
    /// </summary>
    public sealed class SortType : Enumeration<SortType>
    {
        /// <summary>
        /// Sort by relevance. Default value.
        /// </summary>
        public static readonly SortType Relevance = new SortType("Relevance", string.Empty, true);

        /// <summary>
        /// Sort by date.
        /// </summary>
        public static readonly SortType Date = new SortType("Date", "d");

        /// <summary>
        /// Sort by ascending date.
        /// </summary>
        public static readonly SortType AscendingDate = new SortType("AscendingDate", "ad");

        private SortType(string value)
            : base(value)
        {
        }

        private SortType(string name, string value)
            : base(name, value)
        {
        }

        private SortType(string name, string value, bool isDefault)
            : base(name, value, isDefault)
        {
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="SortType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SortType(string value)
        {
            return Convert(value, s => new SortType(s));
        }
    }
}