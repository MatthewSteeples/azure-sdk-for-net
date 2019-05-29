// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for LiveEventInputProtocol.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(LiveEventInputProtocolConverter))]
    public struct LiveEventInputProtocol : System.IEquatable<LiveEventInputProtocol>
    {
        private LiveEventInputProtocol(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly LiveEventInputProtocol FragmentedMP4 = "FragmentedMP4";

        public static readonly LiveEventInputProtocol RTMP = "RTMP";


        /// <summary>
        /// Underlying value of enum LiveEventInputProtocol
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for LiveEventInputProtocol
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type LiveEventInputProtocol
        /// </summary>
        public bool Equals(LiveEventInputProtocol e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to LiveEventInputProtocol
        /// </summary>
        public static implicit operator LiveEventInputProtocol(string value)
        {
            return new LiveEventInputProtocol(value);
        }

        /// <summary>
        /// Implicit operator to convert LiveEventInputProtocol to string
        /// </summary>
        public static implicit operator string(LiveEventInputProtocol e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum LiveEventInputProtocol
        /// </summary>
        public static bool operator == (LiveEventInputProtocol e1, LiveEventInputProtocol e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum LiveEventInputProtocol
        /// </summary>
        public static bool operator != (LiveEventInputProtocol e1, LiveEventInputProtocol e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for LiveEventInputProtocol
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is LiveEventInputProtocol && Equals((LiveEventInputProtocol)obj);
        }

        /// <summary>
        /// Returns for hashCode LiveEventInputProtocol
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
