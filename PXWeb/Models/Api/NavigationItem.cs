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

namespace PxWeb.Models.Api
{ 
    /// <summary>
    /// Navigation item.
    /// </summary>
    [DataContract]
    public partial class NavigationItem : IEquatable<NavigationItem>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// One of heading, table, folder or folder-information
        /// </summary>
        /// <value>One of heading, table, folder or folder-information</value>

        [DataMember(Name="objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Display text
        /// </summary>
        /// <value>Display text</value>

        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Longer text describing node.
        /// </summary>
        /// <value>Longer text describing node.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NavigationItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NavigationItem)obj);
        }

        /// <summary>
        /// Returns true if NavigationItem instances are equal
        /// </summary>
        /// <param name="other">Instance of NavigationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NavigationItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ObjectType == other.ObjectType ||
                    ObjectType != null &&
                    ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ObjectType != null)
                    hashCode = hashCode * 59 + ObjectType.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NavigationItem left, NavigationItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NavigationItem left, NavigationItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
