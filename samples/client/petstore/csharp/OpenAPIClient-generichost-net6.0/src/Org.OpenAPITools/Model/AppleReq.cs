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
    /// AppleReq
    /// </summary>
    public partial class AppleReq : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleReq" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar</param>
        /// <param name="mealy">mealy</param>
        [JsonConstructor]
        public AppleReq(string cultivar, Option<bool?> mealy = default)
        {
            Cultivar = cultivar;
            MealyOption = mealy;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public string Cultivar { get; set; } // d

        /// <summary>
        /// Used to track the state of Mealy
        /// </summary>
        [JsonIgnore]
        public Option<bool?> MealyOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets Mealy
        /// </summary>
        [JsonPropertyName("mealy")]
        public bool? Mealy { get { return this. MealyOption; } set { this.MealyOption = new(value); } } // d

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppleReq {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Mealy: ").Append(Mealy).Append("\n");
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
    /// A Json converter for type <see cref="AppleReq" />
    /// </summary>
    public class AppleReqJsonConverter : JsonConverter<AppleReq>
    {
        /// <summary>
        /// Deserializes json to <see cref="AppleReq" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AppleReq Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> cultivar = default;
            Option<bool?> mealy = default;

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
                        case "cultivar":
                            cultivar = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "mealy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mealy = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!cultivar.IsSet)
                throw new ArgumentException("Property is required for class AppleReq.", nameof(cultivar));

            if (cultivar.IsSet && cultivar.Value == null)
                throw new ArgumentNullException(nameof(cultivar), "Property is not nullable for class AppleReq.");

            if (mealy.IsSet && mealy.Value == null)
                throw new ArgumentNullException(nameof(mealy), "Property is not nullable for class AppleReq.");

            return new AppleReq(cultivar.Value, mealy); // a
        }

        /// <summary>
        /// Serializes a <see cref="AppleReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appleReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AppleReq appleReq, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, appleReq, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AppleReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appleReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AppleReq appleReq, JsonSerializerOptions jsonSerializerOptions)
        {
            if (appleReq.Cultivar == null)
                throw new ArgumentNullException(nameof(appleReq.Cultivar), "Property is required for class AppleReq.");

            writer.WriteString("cultivar", appleReq.Cultivar); // 1

            if (appleReq.MealyOption.IsSet)
                writer.WriteBoolean("mealy", appleReq.MealyOption.Value.Value); // 2
        }
    }
}
