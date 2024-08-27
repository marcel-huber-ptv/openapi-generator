/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Banana
    /// </summary>
    [DataContract(Name = "banana")]
    public partial class Banana : IEquatable<Banana>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Banana" /> class.
        /// </summary>
        /// <param name="lengthCm">lengthCm.</param>
        public Banana(decimal? lengthCm = default(decimal?))
        {
            this.LengthCm = lengthCm;
        }

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [DataMember(Name = "lengthCm", EmitDefaultValue = false)]
        public decimal? LengthCm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Banana {\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Banana);
        }

        /// <summary>
        /// Returns true if Banana instances are equal
        /// </summary>
        /// <param name="input">Instance of Banana to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Banana input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LengthCm == input.LengthCm ||
                    (this.LengthCm != null &&
                    this.LengthCm.Equals(input.LengthCm))
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
                int hashCode = 41;
                if (this.LengthCm != null)
                {
                    hashCode = (hashCode * 59) + this.LengthCm.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
