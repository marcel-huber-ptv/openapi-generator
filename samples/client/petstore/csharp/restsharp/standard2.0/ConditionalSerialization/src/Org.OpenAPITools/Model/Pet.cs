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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Pet
    /// </summary>
    [DataContract(Name = "Pet")]
    public partial class Pet : IEquatable<Pet>, IValidatableObject
    {
        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Sold for value: sold
            /// </summary>
            [EnumMember(Value = "sold")]
            Sold = 3
        }


        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private StatusEnum? _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Pet()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="category">category.</param>
        /// <param name="name">name (required).</param>
        /// <param name="photoUrls">photoUrls (required).</param>
        /// <param name="tags">tags.</param>
        /// <param name="status">pet status in the store.</param>
        public Pet(long? id = default(long?), Category category = default(Category), string name = default(string), List<string> photoUrls = default(List<string>), List<Tag> tags = default(List<Tag>), StatusEnum? status = default(StatusEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Pet and cannot be null");
            }
            this._Name = name;
            // to ensure "photoUrls" is required (not null)
            if (photoUrls == null)
            {
                throw new ArgumentNullException("photoUrls is a required property for Pet and cannot be null");
            }
            this._PhotoUrls = photoUrls;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Category = category;
            if (this.Category != null)
            {
                this._flagCategory = true;
            }
            this._Tags = tags;
            if (this.Tags != null)
            {
                this._flagTags = true;
            }
            this._Status = status;
            if (this.Status != null)
            {
                this._flagStatus = true;
            }
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private long? _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public Category Category
        {
            get{ return _Category;}
            set
            {
                _Category = value;
                _flagCategory = true;
            }
        }
        private Category _Category;
        private bool _flagCategory;

        /// <summary>
        /// Returns false as Category should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategory()
        {
            return _flagCategory;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>doggie</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Gets or Sets PhotoUrls
        /// </summary>
        [DataMember(Name = "photoUrls", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PhotoUrls
        {
            get{ return _PhotoUrls;}
            set
            {
                _PhotoUrls = value;
                _flagPhotoUrls = true;
            }
        }
        private List<string> _PhotoUrls;
        private bool _flagPhotoUrls;

        /// <summary>
        /// Returns false as PhotoUrls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePhotoUrls()
        {
            return _flagPhotoUrls;
        }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<Tag> Tags
        {
            get{ return _Tags;}
            set
            {
                _Tags = value;
                _flagTags = true;
            }
        }
        private List<Tag> _Tags;
        private bool _flagTags;

        /// <summary>
        /// Returns false as Tags should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTags()
        {
            return _flagTags;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Pet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Pet).AreEqual;
        }

        /// <summary>
        /// Returns true if Pet instances are equal
        /// </summary>
        /// <param name="input">Instance of Pet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pet input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PhotoUrls != null)
                {
                    hashCode = (hashCode * 59) + this.PhotoUrls.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
