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
    /// NullableClass
    /// </summary>
    public partial class NullableClass : Dictionary<String, Object>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableClass" /> class.
        /// </summary>
        /// <param name="arrayItemsNullable">arrayItemsNullable</param>
        /// <param name="objectItemsNullable">objectItemsNullable</param>
        /// <param name="arrayAndItemsNullableProp">arrayAndItemsNullableProp</param>
        /// <param name="arrayNullableProp">arrayNullableProp</param>
        /// <param name="booleanProp">booleanProp</param>
        /// <param name="dateProp">dateProp</param>
        /// <param name="datetimeProp">datetimeProp</param>
        /// <param name="integerProp">integerProp</param>
        /// <param name="numberProp">numberProp</param>
        /// <param name="objectAndItemsNullableProp">objectAndItemsNullableProp</param>
        /// <param name="objectNullableProp">objectNullableProp</param>
        /// <param name="stringProp">stringProp</param>
        [JsonConstructor]
        public NullableClass(Option<List<Object>> arrayItemsNullable = default, Option<Dictionary<string, Object>> objectItemsNullable = default, Option<List<Object>> arrayAndItemsNullableProp = default, Option<List<Object>> arrayNullableProp = default, Option<bool?> booleanProp = default, Option<DateTime?> dateProp = default, Option<DateTime?> datetimeProp = default, Option<int?> integerProp = default, Option<decimal?> numberProp = default, Option<Dictionary<string, Object>> objectAndItemsNullableProp = default, Option<Dictionary<string, Object>> objectNullableProp = default, Option<string> stringProp = default) : base()
        {
            ArrayItemsNullableOption = arrayItemsNullable;
            ObjectItemsNullableOption = objectItemsNullable;
            ArrayAndItemsNullablePropOption = arrayAndItemsNullableProp;
            ArrayNullablePropOption = arrayNullableProp;
            BooleanPropOption = booleanProp;
            DatePropOption = dateProp;
            DatetimePropOption = datetimeProp;
            IntegerPropOption = integerProp;
            NumberPropOption = numberProp;
            ObjectAndItemsNullablePropOption = objectAndItemsNullableProp;
            ObjectNullablePropOption = objectNullableProp;
            StringPropOption = stringProp;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ArrayItemsNullable
        /// </summary>
        [JsonIgnore]
        public Option<List<Object>> ArrayItemsNullableOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ArrayItemsNullable
        /// </summary>
        [JsonPropertyName("array_items_nullable")]
        public List<Object> ArrayItemsNullable { get { return this. ArrayItemsNullableOption; } set { this.ArrayItemsNullableOption = new Option<List<Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of ObjectItemsNullable
        /// </summary>
        [JsonIgnore]
        public Option<Dictionary<string, Object>> ObjectItemsNullableOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ObjectItemsNullable
        /// </summary>
        [JsonPropertyName("object_items_nullable")]
        public Dictionary<string, Object> ObjectItemsNullable { get { return this. ObjectItemsNullableOption; } set { this.ObjectItemsNullableOption = new Option<Dictionary<string, Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of ArrayAndItemsNullableProp
        /// </summary>
        [JsonIgnore]
        public Option<List<Object>> ArrayAndItemsNullablePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ArrayAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("array_and_items_nullable_prop")]
        public List<Object> ArrayAndItemsNullableProp { get { return this. ArrayAndItemsNullablePropOption; } set { this.ArrayAndItemsNullablePropOption = new Option<List<Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of ArrayNullableProp
        /// </summary>
        [JsonIgnore]
        public Option<List<Object>> ArrayNullablePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ArrayNullableProp
        /// </summary>
        [JsonPropertyName("array_nullable_prop")]
        public List<Object> ArrayNullableProp { get { return this. ArrayNullablePropOption; } set { this.ArrayNullablePropOption = new Option<List<Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of BooleanProp
        /// </summary>
        [JsonIgnore]
        public Option<bool?> BooleanPropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets BooleanProp
        /// </summary>
        [JsonPropertyName("boolean_prop")]
        public bool? BooleanProp { get { return this. BooleanPropOption; } set { this.BooleanPropOption = new Option<bool?>(value); } } // d

        /// <summary>
        /// Used to track the state of DateProp
        /// </summary>
        [JsonIgnore]
        public Option<DateTime?> DatePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets DateProp
        /// </summary>
        [JsonPropertyName("date_prop")]
        public DateTime? DateProp { get { return this. DatePropOption; } set { this.DatePropOption = new Option<DateTime?>(value); } } // d

        /// <summary>
        /// Used to track the state of DatetimeProp
        /// </summary>
        [JsonIgnore]
        public Option<DateTime?> DatetimePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets DatetimeProp
        /// </summary>
        [JsonPropertyName("datetime_prop")]
        public DateTime? DatetimeProp { get { return this. DatetimePropOption; } set { this.DatetimePropOption = new Option<DateTime?>(value); } } // d

        /// <summary>
        /// Used to track the state of IntegerProp
        /// </summary>
        [JsonIgnore]
        public Option<int?> IntegerPropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets IntegerProp
        /// </summary>
        [JsonPropertyName("integer_prop")]
        public int? IntegerProp { get { return this. IntegerPropOption; } set { this.IntegerPropOption = new Option<int?>(value); } } // d

        /// <summary>
        /// Used to track the state of NumberProp
        /// </summary>
        [JsonIgnore]
        public Option<decimal?> NumberPropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets NumberProp
        /// </summary>
        [JsonPropertyName("number_prop")]
        public decimal? NumberProp { get { return this. NumberPropOption; } set { this.NumberPropOption = new Option<decimal?>(value); } } // d

        /// <summary>
        /// Used to track the state of ObjectAndItemsNullableProp
        /// </summary>
        [JsonIgnore]
        public Option<Dictionary<string, Object>> ObjectAndItemsNullablePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ObjectAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("object_and_items_nullable_prop")]
        public Dictionary<string, Object> ObjectAndItemsNullableProp { get { return this. ObjectAndItemsNullablePropOption; } set { this.ObjectAndItemsNullablePropOption = new Option<Dictionary<string, Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of ObjectNullableProp
        /// </summary>
        [JsonIgnore]
        public Option<Dictionary<string, Object>> ObjectNullablePropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ObjectNullableProp
        /// </summary>
        [JsonPropertyName("object_nullable_prop")]
        public Dictionary<string, Object> ObjectNullableProp { get { return this. ObjectNullablePropOption; } set { this.ObjectNullablePropOption = new Option<Dictionary<string, Object>>(value); } } // d

        /// <summary>
        /// Used to track the state of StringProp
        /// </summary>
        [JsonIgnore]
        public Option<string> StringPropOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets StringProp
        /// </summary>
        [JsonPropertyName("string_prop")]
        public string StringProp { get { return this. StringPropOption; } set { this.StringPropOption = new Option<string>(value); } } // d

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
            sb.Append("class NullableClass {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ArrayItemsNullable: ").Append(ArrayItemsNullable).Append("\n");
            sb.Append("  ObjectItemsNullable: ").Append(ObjectItemsNullable).Append("\n");
            sb.Append("  ArrayAndItemsNullableProp: ").Append(ArrayAndItemsNullableProp).Append("\n");
            sb.Append("  ArrayNullableProp: ").Append(ArrayNullableProp).Append("\n");
            sb.Append("  BooleanProp: ").Append(BooleanProp).Append("\n");
            sb.Append("  DateProp: ").Append(DateProp).Append("\n");
            sb.Append("  DatetimeProp: ").Append(DatetimeProp).Append("\n");
            sb.Append("  IntegerProp: ").Append(IntegerProp).Append("\n");
            sb.Append("  NumberProp: ").Append(NumberProp).Append("\n");
            sb.Append("  ObjectAndItemsNullableProp: ").Append(ObjectAndItemsNullableProp).Append("\n");
            sb.Append("  ObjectNullableProp: ").Append(ObjectNullableProp).Append("\n");
            sb.Append("  StringProp: ").Append(StringProp).Append("\n");
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
    /// A Json converter for type <see cref="NullableClass" />
    /// </summary>
    public class NullableClassJsonConverter : JsonConverter<NullableClass>
    {
        /// <summary>
        /// The format to use to serialize DateProp
        /// </summary>
        public static string DatePropFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DatetimeProp
        /// </summary>
        public static string DatetimePropFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="NullableClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NullableClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Object>> arrayItemsNullable = default;
            Option<Dictionary<string, Object>> objectItemsNullable = default;
            Option<List<Object>> arrayAndItemsNullableProp = default;
            Option<List<Object>> arrayNullableProp = default;
            Option<bool?> booleanProp = default;
            Option<DateTime?> dateProp = default;
            Option<DateTime?> datetimeProp = default;
            Option<int?> integerProp = default;
            Option<decimal?> numberProp = default;
            Option<Dictionary<string, Object>> objectAndItemsNullableProp = default;
            Option<Dictionary<string, Object>> objectNullableProp = default;
            Option<string> stringProp = default;

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
                        case "array_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayItemsNullable = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "object_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectItemsNullable = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayAndItemsNullableProp = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayNullableProp = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "boolean_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                booleanProp = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "date_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateProp = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "datetime_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                datetimeProp = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "integer_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                integerProp = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "number_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                numberProp = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "object_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectAndItemsNullableProp = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "object_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectNullableProp = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "string_prop":
                            stringProp = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (arrayItemsNullable.IsSet && arrayItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(arrayItemsNullable), "Property is not nullable for class NullableClass.");

            if (objectItemsNullable.IsSet && objectItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(objectItemsNullable), "Property is not nullable for class NullableClass.");

            return new NullableClass(arrayItemsNullable, objectItemsNullable, arrayAndItemsNullableProp, arrayNullableProp, booleanProp, dateProp, datetimeProp, integerProp, numberProp, objectAndItemsNullableProp, objectNullableProp, stringProp); // a
        }

        /// <summary>
        /// Serializes a <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, nullableClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (nullableClass.ArrayItemsNullableOption.IsSet && nullableClass.ArrayItemsNullable == null)
                throw new ArgumentNullException(nameof(nullableClass.ArrayItemsNullable), "Property is required for class NullableClass.");

            if (nullableClass.ObjectItemsNullableOption.IsSet && nullableClass.ObjectItemsNullable == null)
                throw new ArgumentNullException(nameof(nullableClass.ObjectItemsNullable), "Property is required for class NullableClass.");

            if (nullableClass.ArrayItemsNullableOption.IsSet) // 14
                writer.WritePropertyName("array_items_nullable");
                JsonSerializer.Serialize(writer, nullableClass.ArrayItemsNullable, jsonSerializerOptions);
            if (nullableClass.ObjectItemsNullableOption.IsSet) // 14
                writer.WritePropertyName("object_items_nullable");
                JsonSerializer.Serialize(writer, nullableClass.ObjectItemsNullable, jsonSerializerOptions);
            if (nullableClass.ArrayAndItemsNullablePropOption.IsSet) // 14
                if (nullableClass.ArrayAndItemsNullablePropOption.Value != null)
                {
                    writer.WritePropertyName("array_and_items_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ArrayAndItemsNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("array_and_items_nullable_prop");
            if (nullableClass.ArrayNullablePropOption.IsSet) // 14
                if (nullableClass.ArrayNullablePropOption.Value != null)
                {
                    writer.WritePropertyName("array_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ArrayNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("array_nullable_prop");
            if (nullableClass.BooleanPropOption.IsSet)
                if (nullableClass.BooleanPropOption.Value != null)
                    writer.WriteBoolean("boolean_prop", nullableClass.BooleanPropOption.Value.Value); // 2
                else
                    writer.WriteNull("boolean_prop");

            if (nullableClass.DatePropOption.IsSet)
                if (nullableClass.DatePropOption.Value != null)
                    writer.WriteString("date_prop", nullableClass.DatePropOption.Value.Value.ToString(DatePropFormat)); // 4
                else
                    writer.WriteNull("date_prop");

            if (nullableClass.DatetimePropOption.IsSet)
                if (nullableClass.DatetimePropOption.Value != null)
                    writer.WriteString("datetime_prop", nullableClass.DatetimePropOption.Value.Value.ToString(DatetimePropFormat)); // 5
                else
                    writer.WriteNull("datetime_prop");

            if (nullableClass.IntegerPropOption.IsSet)
                if (nullableClass.IntegerPropOption.Value != null)
                    writer.WriteNumber("integer_prop", nullableClass.IntegerPropOption.Value.Value); // 3
                else
                    writer.WriteNull("integer_prop");

            if (nullableClass.NumberPropOption.IsSet)
                if (nullableClass.NumberPropOption.Value != null)
                    writer.WriteNumber("number_prop", nullableClass.NumberPropOption.Value.Value); // 3
                else
                    writer.WriteNull("number_prop");

            if (nullableClass.ObjectAndItemsNullablePropOption.IsSet) // 14
                if (nullableClass.ObjectAndItemsNullablePropOption.Value != null)
                {
                    writer.WritePropertyName("object_and_items_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ObjectAndItemsNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("object_and_items_nullable_prop");
            if (nullableClass.ObjectNullablePropOption.IsSet) // 14
                if (nullableClass.ObjectNullablePropOption.Value != null)
                {
                    writer.WritePropertyName("object_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ObjectNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("object_nullable_prop");
            if (nullableClass.StringPropOption.IsSet)
                if (nullableClass.StringPropOption.Value != null)
                    writer.WriteString("string_prop", nullableClass.StringProp); // 1
                else
                    writer.WriteNull("string_prop");
        }
    }
}
