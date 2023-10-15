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
    /// User
    /// </summary>
    public partial class User : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="firstName">firstName</param>
        /// <param name="id">id</param>
        /// <param name="lastName">lastName</param>
        /// <param name="objectWithNoDeclaredProps">test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</param>
        /// <param name="password">password</param>
        /// <param name="phone">phone</param>
        /// <param name="userStatus">User Status</param>
        /// <param name="username">username</param>
        /// <param name="anyTypeProp">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</param>
        /// <param name="anyTypePropNullable">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</param>
        /// <param name="objectWithNoDeclaredPropsNullable">test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</param>
        [JsonConstructor]
        public User(Option<string> email = default, Option<string> firstName = default, Option<long> id = default, Option<string> lastName = default, Option<Object> objectWithNoDeclaredProps = default, Option<string> password = default, Option<string> phone = default, Option<int> userStatus = default, Option<string> username = default, Option<Object?> anyTypeProp = default, Option<Object?> anyTypePropNullable = default, Option<Object?> objectWithNoDeclaredPropsNullable = default)
        {
            Email = email;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            ObjectWithNoDeclaredProps = objectWithNoDeclaredProps;
            Password = password;
            Phone = phone;
            UserStatus = userStatus;
            Username = username;
            AnyTypeProp = anyTypeProp;
            AnyTypePropNullable = anyTypePropNullable;
            ObjectWithNoDeclaredPropsNullable = objectWithNoDeclaredPropsNullable;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public Option<string> Email { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public Option<string> FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public Option<long> Id { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public Option<string> LastName { get; set; }

        /// <summary>
        /// test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredProps")]
        public Option<Object> ObjectWithNoDeclaredProps { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public Option<string> Password { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [JsonPropertyName("phone")]
        public Option<string> Phone { get; set; }

        /// <summary>
        /// User Status
        /// </summary>
        /// <value>User Status</value>
        [JsonPropertyName("userStatus")]
        public Option<int> UserStatus { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [JsonPropertyName("username")]
        public Option<string> Username { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</value>
        [JsonPropertyName("anyTypeProp")]
        public Option<Object?> AnyTypeProp { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</value>
        [JsonPropertyName("anyTypePropNullable")]
        public Option<Object?> AnyTypePropNullable { get; set; }

        /// <summary>
        /// test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredPropsNullable")]
        public Option<Object?> ObjectWithNoDeclaredPropsNullable { get; set; }

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
            sb.Append("class User {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ObjectWithNoDeclaredProps: ").Append(ObjectWithNoDeclaredProps).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AnyTypeProp: ").Append(AnyTypeProp).Append("\n");
            sb.Append("  AnyTypePropNullable: ").Append(AnyTypePropNullable).Append("\n");
            sb.Append("  ObjectWithNoDeclaredPropsNullable: ").Append(ObjectWithNoDeclaredPropsNullable).Append("\n");
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
    /// A Json converter for type <see cref="User" />
    /// </summary>
    public class UserJsonConverter : JsonConverter<User>
    {
        /// <summary>
        /// Deserializes json to <see cref="User" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override User Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> email = default;
            Option<string?> firstName = default;
            Option<long?> id = default;
            Option<string?> lastName = default;
            Option<Object?> objectWithNoDeclaredProps = default;
            Option<string?> password = default;
            Option<string?> phone = default;
            Option<int?> userStatus = default;
            Option<string?> username = default;
            Option<Object?> anyTypeProp = default;
            Option<Object?> anyTypePropNullable = default;
            Option<Object?> objectWithNoDeclaredPropsNullable = default;

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
                        case "email":
                            email = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "firstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "lastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "objectWithNoDeclaredProps":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectWithNoDeclaredProps = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "password":
                            password = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "phone":
                            phone = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "userStatus":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userStatus = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "username":
                            username = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "anyTypeProp":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                anyTypeProp = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "anyTypePropNullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                anyTypePropNullable = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "objectWithNoDeclaredPropsNullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectWithNoDeclaredPropsNullable = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class User.");

            if (firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName), "Property is not nullable for class User.");

            if (id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class User.");

            if (lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName), "Property is not nullable for class User.");

            if (objectWithNoDeclaredProps.Value == null)
                throw new ArgumentNullException(nameof(objectWithNoDeclaredProps), "Property is not nullable for class User.");

            if (password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class User.");

            if (phone.Value == null)
                throw new ArgumentNullException(nameof(phone), "Property is not nullable for class User.");

            if (userStatus.Value == null)
                throw new ArgumentNullException(nameof(userStatus), "Property is not nullable for class User.");

            if (username.Value == null)
                throw new ArgumentNullException(nameof(username), "Property is not nullable for class User.");

            Option<string> emailParsedValue = new Option<string>(email.Value);
            Option<string> firstNameParsedValue = new Option<string>(firstName.Value);
            Option<long> idParsedValue = new Option<long>(id.Value.Value);
            Option<string> lastNameParsedValue = new Option<string>(lastName.Value);
            Option<Object> objectWithNoDeclaredPropsParsedValue = new Option<Object>(objectWithNoDeclaredProps.Value);
            Option<string> passwordParsedValue = new Option<string>(password.Value);
            Option<string> phoneParsedValue = new Option<string>(phone.Value);
            Option<int> userStatusParsedValue = new Option<int>(userStatus.Value.Value);
            Option<string> usernameParsedValue = new Option<string>(username.Value);

            return new User(emailParsedValue, firstNameParsedValue, idParsedValue, lastNameParsedValue, objectWithNoDeclaredPropsParsedValue, passwordParsedValue, phoneParsedValue, userStatusParsedValue, usernameParsedValue, anyTypeProp, anyTypePropNullable, objectWithNoDeclaredPropsNullable);
        }

        /// <summary>
        /// Serializes a <see cref="User" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, User user, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, user, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="User" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, User user, JsonSerializerOptions jsonSerializerOptions)
        {
            if (user.Email.IsSet)
                writer.WriteString("email", user.Email.Value);
            if (user.FirstName.IsSet)
                writer.WriteString("firstName", user.FirstName.Value);
            if (user.Id.IsSet)
                writer.WriteNumber("id", user.Id.Value);
            if (user.LastName.IsSet)
                writer.WriteString("lastName", user.LastName.Value);
            if (user.ObjectWithNoDeclaredProps.IsSet)
                writer.WritePropertyName("objectWithNoDeclaredProps");
                JsonSerializer.Serialize(writer, user.ObjectWithNoDeclaredProps, jsonSerializerOptions);
            if (user.Password.IsSet)
                writer.WriteString("password", user.Password.Value);
            if (user.Phone.IsSet)
                writer.WriteString("phone", user.Phone.Value);
            if (user.UserStatus.IsSet)
                writer.WriteNumber("userStatus", user.UserStatus.Value);
            if (user.Username.IsSet)
                writer.WriteString("username", user.Username.Value);
            if (user.AnyTypeProp.IsSet)
                if (user.AnyTypeProp.Value != null)
                {
                    writer.WritePropertyName("anyTypeProp");
                    JsonSerializer.Serialize(writer, user.AnyTypeProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("anyTypeProp");
            if (user.AnyTypePropNullable.IsSet)
                if (user.AnyTypePropNullable.Value != null)
                {
                    writer.WritePropertyName("anyTypePropNullable");
                    JsonSerializer.Serialize(writer, user.AnyTypePropNullable, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("anyTypePropNullable");
            if (user.ObjectWithNoDeclaredPropsNullable.IsSet)
                if (user.ObjectWithNoDeclaredPropsNullable.Value != null)
                {
                    writer.WritePropertyName("objectWithNoDeclaredPropsNullable");
                    JsonSerializer.Serialize(writer, user.ObjectWithNoDeclaredPropsNullable, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("objectWithNoDeclaredPropsNullable");
        }
    }

    /// <summary>
    /// The UserSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(User))]
    public partial class UserSerializationContext : JsonSerializerContext { }
}
