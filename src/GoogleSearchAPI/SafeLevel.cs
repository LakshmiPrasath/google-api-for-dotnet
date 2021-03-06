//-----------------------------------------------------------------------
// <copyright file="SafeLevel.cs" company="iron9light">
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
    /// The search safety level.
    /// </summary>
    public sealed class SafeLevel : Enumeration<SafeLevel>
    {
        /// <summary>
        /// Disables safe search filtering.
        /// </summary>
        public static readonly SafeLevel Off = new SafeLevel("Off", "off");

        /// <summary>
        /// Enables moderate safe search filtering. Default value.
        /// </summary>
        public static readonly SafeLevel Moderate = new SafeLevel("Moderate", "moderate", true);

        /// <summary>
        /// Enables the highest level of safe search filtering.
        /// </summary>
        public static readonly SafeLevel Active = new SafeLevel("Active", "active");

        private SafeLevel(string value)
            : base(value)
        {
        }

        private SafeLevel(string name, string value)
            : base(name, value)
        {
        }

        private SafeLevel(string name, string value, bool isDefault)
            : base(name, value, isDefault)
        {
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="SafeLevel"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SafeLevel(string value)
        {
            return Convert(value, s => new SafeLevel(s));
        }
    }
}