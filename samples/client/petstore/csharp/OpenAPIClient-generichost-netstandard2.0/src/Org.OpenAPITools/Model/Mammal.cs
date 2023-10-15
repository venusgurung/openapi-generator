// <auto-generated>
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
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Mammal
    /// </summary>
    public partial class Mammal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="whale"></param>
        /// <param name="className">className</param>
        public Mammal(Whale whale, string className)
        {
            Whale = whale;
            ClassName = className;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="zebra"></param>
        /// <param name="className">className</param>
        public Mammal(Zebra zebra, string className)
        {
            Zebra = zebra;
            ClassName = className;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="pig"></param>
        /// <param name="className">className</param>
        public Mammal(Pig pig, string className)
        {
            Pig = pig;
            ClassName = className;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Whale
        /// </summary>
        public Whale Whale { get; set; }

        /// <summary>
        /// Gets or Sets Zebra
        /// </summary>
        public Zebra Zebra { get; set; }

        /// <summary>
        /// Gets or Sets Pig
        /// </summary>
        public Pig Pig { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Mammal {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Mammal" />
    /// </summary>
    public class MammalJsonConverter : JsonConverter<Mammal>
    {
        /// <summary>
        /// Deserializes json to <see cref="Mammal" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Mammal Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> className = default;

            Pig pig = null;
            Whale whale = null;
            Zebra zebra = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName.Equals("className"))
                    {
                        string discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator.Equals("Pig"))
                        {
                            Utf8JsonReader utf8JsonReaderPig = utf8JsonReader;
                            pig = JsonSerializer.Deserialize<Pig>(ref utf8JsonReaderPig, jsonSerializerOptions);
                        }
                        if (discriminator.Equals("whale"))
                        {
                            Utf8JsonReader utf8JsonReaderWhale = utf8JsonReader;
                            whale = JsonSerializer.Deserialize<Whale>(ref utf8JsonReaderWhale, jsonSerializerOptions);
                        }
                        if (discriminator.Equals("zebra"))
                        {
                            Utf8JsonReader utf8JsonReaderZebra = utf8JsonReader;
                            zebra = JsonSerializer.Deserialize<Zebra>(ref utf8JsonReaderZebra, jsonSerializerOptions);
                        }
                    }
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "className":
                            className = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!className.IsSet)
                throw new ArgumentNullException(nameof(className), "Property is required for class Mammal.");

            if (className.Value == null)
                throw new ArgumentNullException(nameof(className), "Property is not nullable for class Mammal.");

            string classNameParsedValue = className.Value;

            if (pig != null)
                return new Mammal(pig, classNameParsedValue);

            if (whale != null)
                return new Mammal(whale, classNameParsedValue);

            if (zebra != null)
                return new Mammal(zebra, classNameParsedValue);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Mammal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mammal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Mammal mammal, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (mammal.Pig != null) {
                PigJsonConverter pigJsonConverter = (PigJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mammal.Pig.GetType()));
                pigJsonConverter.WriteProperties(ref writer, mammal.Pig, jsonSerializerOptions);
            }

            if (mammal.Whale != null) {
                WhaleJsonConverter whaleJsonConverter = (WhaleJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mammal.Whale.GetType()));
                whaleJsonConverter.WriteProperties(ref writer, mammal.Whale, jsonSerializerOptions);
            }

            if (mammal.Zebra != null) {
                ZebraJsonConverter zebraJsonConverter = (ZebraJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mammal.Zebra.GetType()));
                zebraJsonConverter.WriteProperties(ref writer, mammal.Zebra, jsonSerializerOptions);
            }

            WriteProperties(ref writer, mammal, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Mammal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mammal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Mammal mammal, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("className", mammal.ClassName);
        }
    }
}
