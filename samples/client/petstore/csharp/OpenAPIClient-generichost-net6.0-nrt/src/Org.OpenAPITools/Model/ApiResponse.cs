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
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ApiResponse
    /// </summary>
    public partial class ApiResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse" /> class.
        /// </summary>
        /// <param name="code">code</param>
        /// <param name="message">message</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public ApiResponse(Option<int> code = default, Option<string> message = default, Option<string> type = default)
        {
            Code = code;
            Message = message;
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [JsonPropertyName("code")]
        public Option<int> Code { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public Option<string> Message { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public Option<string> Type { get; set; }

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
            sb.Append("class ApiResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="ApiResponse" />
    /// </summary>
    public class ApiResponseJsonConverter : JsonConverter<ApiResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApiResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApiResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> code = default;
            Option<string?> message = default;
            Option<string?> type = default;

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
                        case "code":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                code = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class ApiResponse.");

            if (message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class ApiResponse.");

            if (type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class ApiResponse.");

            Option<int> codeParsedValue = new Option<int>(code.Value.Value);
            Option<string> messageParsedValue = new Option<string>(message.Value);
            Option<string> typeParsedValue = new Option<string>(type.Value);

            return new ApiResponse(codeParsedValue, messageParsedValue, typeParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="ApiResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApiResponse apiResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, apiResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApiResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ApiResponse apiResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (apiResponse.Code.IsSet)
                writer.WriteNumber("code", apiResponse.Code.Value);
            if (apiResponse.Message.IsSet)
                writer.WriteString("message", apiResponse.Message.Value);
            if (apiResponse.Type.IsSet)
                writer.WriteString("type", apiResponse.Type.Value);
        }
    }
}
