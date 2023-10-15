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
    /// Drawing
    /// </summary>
    public partial class Drawing : Dictionary<String, Fruit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawing" /> class.
        /// </summary>
        /// <param name="mainShape">mainShape</param>
        /// <param name="shapes">shapes</param>
        /// <param name="nullableShape">nullableShape</param>
        /// <param name="shapeOrNull">shapeOrNull</param>
        [JsonConstructor]
        public Drawing(Option<Shape> mainShape = default, Option<List<Shape>> shapes = default, Option<NullableShape?> nullableShape = default, Option<ShapeOrNull?> shapeOrNull = default) : base()
        {
            MainShape = mainShape;
            Shapes = shapes;
            NullableShape = nullableShape;
            ShapeOrNull = shapeOrNull;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets MainShape
        /// </summary>
        [JsonPropertyName("mainShape")]
        public Option<Shape> MainShape { get; set; }

        /// <summary>
        /// Gets or Sets Shapes
        /// </summary>
        [JsonPropertyName("shapes")]
        public Option<List<Shape>> Shapes { get; set; }

        /// <summary>
        /// Gets or Sets NullableShape
        /// </summary>
        [JsonPropertyName("nullableShape")]
        public Option<NullableShape?> NullableShape { get; set; }

        /// <summary>
        /// Gets or Sets ShapeOrNull
        /// </summary>
        [JsonPropertyName("shapeOrNull")]
        public Option<ShapeOrNull?> ShapeOrNull { get; set; }

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
            sb.Append("class Drawing {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MainShape: ").Append(MainShape).Append("\n");
            sb.Append("  Shapes: ").Append(Shapes).Append("\n");
            sb.Append("  NullableShape: ").Append(NullableShape).Append("\n");
            sb.Append("  ShapeOrNull: ").Append(ShapeOrNull).Append("\n");
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
    /// A Json converter for type <see cref="Drawing" />
    /// </summary>
    public class DrawingJsonConverter : JsonConverter<Drawing>
    {
        /// <summary>
        /// Deserializes json to <see cref="Drawing" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Drawing Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Shape?> mainShape = default;
            Option<List<Shape>?> shapes = default;
            Option<NullableShape?> nullableShape = default;
            Option<ShapeOrNull?> shapeOrNull = default;

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
                        case "mainShape":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mainShape = new Option<Shape?>(JsonSerializer.Deserialize<Shape>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "shapes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shapes = new Option<List<Shape>?>(JsonSerializer.Deserialize<List<Shape>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "nullableShape":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                nullableShape = new Option<NullableShape?>(JsonSerializer.Deserialize<NullableShape>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "shapeOrNull":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shapeOrNull = new Option<ShapeOrNull?>(JsonSerializer.Deserialize<ShapeOrNull>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (mainShape.Value == null)
                throw new ArgumentNullException(nameof(mainShape), "Property is not nullable for class Drawing.");

            if (shapes.Value == null)
                throw new ArgumentNullException(nameof(shapes), "Property is not nullable for class Drawing.");

            Option<Shape> mainShapeParsedValue = new Option<Shape>(mainShape.Value);
            Option<List<Shape>> shapesParsedValue = new Option<List<Shape>>(shapes.Value);

            return new Drawing(mainShapeParsedValue, shapesParsedValue, nullableShape, shapeOrNull);
        }

        /// <summary>
        /// Serializes a <see cref="Drawing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drawing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Drawing drawing, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, drawing, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Drawing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drawing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Drawing drawing, JsonSerializerOptions jsonSerializerOptions)
        {
            if (drawing.MainShape.IsSet)
                writer.WritePropertyName("mainShape");
                JsonSerializer.Serialize(writer, drawing.MainShape, jsonSerializerOptions);
            if (drawing.Shapes.IsSet)
                writer.WritePropertyName("shapes");
                JsonSerializer.Serialize(writer, drawing.Shapes, jsonSerializerOptions);
            if (drawing.NullableShape.IsSet)
                if (drawing.NullableShape.Value != null)
                {
                    writer.WritePropertyName("nullableShape");
                    JsonSerializer.Serialize(writer, drawing.NullableShape, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("nullableShape");
            if (drawing.ShapeOrNull.IsSet)
                if (drawing.ShapeOrNull.Value != null)
                {
                    writer.WritePropertyName("shapeOrNull");
                    JsonSerializer.Serialize(writer, drawing.ShapeOrNull, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("shapeOrNull");
        }
    }

    /// <summary>
    /// The DrawingSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Drawing))]
    public partial class DrawingSerializationContext : JsonSerializerContext { }
}
