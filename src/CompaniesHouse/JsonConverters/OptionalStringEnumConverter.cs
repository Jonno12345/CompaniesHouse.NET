using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CompaniesHouse.JsonConverters
{
    internal class OptionalStringEnumConverter<T> : StringEnumConverter
	{
		private readonly T _defaultValue;

		public OptionalStringEnumConverter(T defaultValue)
		{
			_defaultValue = defaultValue;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return _defaultValue;
			}

			return base.ReadJson(reader, objectType, existingValue, serializer);
		}
	}
}
