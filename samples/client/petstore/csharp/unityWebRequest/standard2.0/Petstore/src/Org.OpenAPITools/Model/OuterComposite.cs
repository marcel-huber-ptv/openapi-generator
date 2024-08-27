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
    /// OuterComposite
    /// </summary>
    [DataContract(Name = "OuterComposite")]
    public partial class OuterComposite : IEquatable<OuterComposite>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OuterComposite" /> class.
        /// </summary>
        /// <param name="myNumber">myNumber.</param>
        /// <param name="myString">myString.</param>
        /// <param name="myBoolean">myBoolean.</param>
        public OuterComposite(decimal? myNumber = default(decimal?), string myString = default(string), bool? myBoolean = default(bool?))
        {
            this.MyNumber = myNumber;
            this.MyString = myString;
            this.MyBoolean = myBoolean;
        }

        /// <summary>
        /// Gets or Sets MyNumber
        /// </summary>
        [DataMember(Name = "my_number", EmitDefaultValue = false)]
        public decimal? MyNumber { get; set; }

        /// <summary>
        /// Gets or Sets MyString
        /// </summary>
        [DataMember(Name = "my_string", EmitDefaultValue = false)]
        public string MyString { get; set; }

        /// <summary>
        /// Gets or Sets MyBoolean
        /// </summary>
        [DataMember(Name = "my_boolean", EmitDefaultValue = true)]
        public bool? MyBoolean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OuterComposite {\n");
            sb.Append("  MyNumber: ").Append(MyNumber).Append("\n");
            sb.Append("  MyString: ").Append(MyString).Append("\n");
            sb.Append("  MyBoolean: ").Append(MyBoolean).Append("\n");
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
            return this.Equals(input as OuterComposite);
        }

        /// <summary>
        /// Returns true if OuterComposite instances are equal
        /// </summary>
        /// <param name="input">Instance of OuterComposite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OuterComposite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MyNumber == input.MyNumber ||
                    (this.MyNumber != null &&
                    this.MyNumber.Equals(input.MyNumber))
                ) && 
                (
                    this.MyString == input.MyString ||
                    (this.MyString != null &&
                    this.MyString.Equals(input.MyString))
                ) && 
                (
                    this.MyBoolean == input.MyBoolean ||
                    (this.MyBoolean != null &&
                    this.MyBoolean.Equals(input.MyBoolean))
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
                if (this.MyNumber != null)
                {
                    hashCode = (hashCode * 59) + this.MyNumber.GetHashCode();
                }
                if (this.MyString != null)
                {
                    hashCode = (hashCode * 59) + this.MyString.GetHashCode();
                }
                if (this.MyBoolean != null)
                {
                    hashCode = (hashCode * 59) + this.MyBoolean.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
