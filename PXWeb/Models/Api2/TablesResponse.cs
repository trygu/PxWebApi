/*
 * PxApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PxWeb.Models.Api2
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class TablesResponse : IEquatable<TablesResponse>
    { 
        /// <summary>
        /// Gets or Sets Page
        /// </summary>

        [DataMember(Name="page")]
        public PagePage Page { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>

        [DataMember(Name="links")]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TablesResponse {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((TablesResponse)obj);
        }

        /// <summary>
        /// Returns true if TablesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TablesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TablesResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Page == other.Page ||
                    Page != null &&
                    Page.Equals(other.Page)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.SequenceEqual(other.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Page != null)
                    hashCode = hashCode * 59 + Page.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TablesResponse left, TablesResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TablesResponse left, TablesResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
