using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000148 RID: 328
	internal sealed class NullableConverter<T> : JsonConverter<T?> where T : struct
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0003298C File Offset: 0x00030B8C
		internal override Type ElementType
		{
			get
			{
				return typeof(T);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00037E7A File Offset: 0x0003607A
		internal override JsonConverter NullableElementConverter
		{
			get
			{
				return this._elementConverter;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00037E82 File Offset: 0x00036082
		internal override bool CanPopulate
		{
			get
			{
				return this._elementConverter.CanPopulate;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00037E8F File Offset: 0x0003608F
		internal override bool ConstructorIsParameterized
		{
			get
			{
				return this._elementConverter.ConstructorIsParameterized;
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00037E9C File Offset: 0x0003609C
		public NullableConverter(JsonConverter<T> elementConverter)
		{
			this._elementConverter = elementConverter;
			base.IsInternalConverter = elementConverter.IsInternalConverter;
			base.IsInternalConverterForNumberType = elementConverter.IsInternalConverterForNumberType;
			base.ConverterStrategy = elementConverter.ConverterStrategy;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00037ED0 File Offset: 0x000360D0
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out T? value)
		{
			if (!state.IsContinuation && reader.TokenType == JsonTokenType.Null)
			{
				value = null;
				return true;
			}
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			state.Current.JsonTypeInfo = state.Current.JsonTypeInfo.ElementTypeInfo;
			T value2;
			if (this._elementConverter.OnTryRead(ref reader, typeof(T), options, ref state, out value2))
			{
				value = new T?(value2);
				state.Current.JsonTypeInfo = jsonTypeInfo;
				return true;
			}
			state.Current.JsonTypeInfo = jsonTypeInfo;
			value = null;
			return false;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00037F74 File Offset: 0x00036174
		internal override bool OnTryWrite(Utf8JsonWriter writer, T? value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return true;
			}
			state.Current.JsonPropertyInfo = state.Current.JsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			JsonConverter<T> elementConverter = this._elementConverter;
			T value2 = value.Value;
			return elementConverter.TryWrite(writer, value2, options, ref state);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00037FD0 File Offset: 0x000361D0
		public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			return new T?(this._elementConverter.Read(ref reader, typeof(T), options));
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0003800D File Offset: 0x0003620D
		public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			this._elementConverter.Write(writer, value.Value, options);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00038034 File Offset: 0x00036234
		internal override T? ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling numberHandling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			return new T?(this._elementConverter.ReadNumberWithCustomHandling(ref reader, numberHandling, options));
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00038068 File Offset: 0x00036268
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T? value, JsonNumberHandling handling)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			this._elementConverter.WriteNumberWithCustomHandling(writer, value.Value, handling);
		}

		// Token: 0x04000466 RID: 1126
		private readonly JsonConverter<T> _elementConverter;
	}
}
