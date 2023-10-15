// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// SimpleQuadrilateral
    /// </summary>
    public partial class SimpleQuadrilateral : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQuadrilateral" /> class.
        /// </summary>
        /// <param name="quadrilateralType">quadrilateralType</param>
        /// <param name="shapeType">shapeType</param>
        [JsonConstructor]
        public SimpleQuadrilateral(string quadrilateralType, string shapeType)
        {
            QuadrilateralType = quadrilateralType;
            ShapeType = shapeType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets QuadrilateralType
        /// </summary>
        [JsonPropertyName("quadrilateralType")]
        public string QuadrilateralType { get; set; }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }

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
            sb.Append("class SimpleQuadrilateral {\n");
            sb.Append("  QuadrilateralType: ").Append(QuadrilateralType).Append("\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SimpleQuadrilateral" />
    /// </summary>
    public class SimpleQuadrilateralJsonConverter : JsonConverter<SimpleQuadrilateral>
    {
        /// <summary>
        /// Deserializes json to <see cref="SimpleQuadrilateral" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SimpleQuadrilateral Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> quadrilateralType = default;
            Option<string?> shapeType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "quadrilateralType":
                            quadrilateralType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "shapeType":
                            shapeType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!quadrilateralType.IsSet)
                throw new ArgumentNullException(nameof(quadrilateralType), "Property is required for class SimpleQuadrilateral.");

            if (!shapeType.IsSet)
                throw new ArgumentNullException(nameof(shapeType), "Property is required for class SimpleQuadrilateral.");

            if (quadrilateralType.Value == null)
                throw new ArgumentNullException(nameof(quadrilateralType), "Property is not nullable for class SimpleQuadrilateral.");

            if (shapeType.Value == null)
                throw new ArgumentNullException(nameof(shapeType), "Property is not nullable for class SimpleQuadrilateral.");

            string quadrilateralTypeParsedValue = quadrilateralType.Value;
            string shapeTypeParsedValue = shapeType.Value;

            return new SimpleQuadrilateral(quadrilateralTypeParsedValue, shapeTypeParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="SimpleQuadrilateral" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="simpleQuadrilateral"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SimpleQuadrilateral simpleQuadrilateral, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, simpleQuadrilateral, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SimpleQuadrilateral" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="simpleQuadrilateral"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SimpleQuadrilateral simpleQuadrilateral, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("quadrilateralType", simpleQuadrilateral.QuadrilateralType);
            writer.WriteString("shapeType", simpleQuadrilateral.ShapeType);
        }
    }

    /// <summary>
    /// The SimpleQuadrilateralSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(SimpleQuadrilateral))]
    public partial class SimpleQuadrilateralSerializationContext : JsonSerializerContext { }
}
