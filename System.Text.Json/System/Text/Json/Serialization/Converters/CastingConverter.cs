using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000F5 RID: 245
	internal sealed class CastingConverter<T> : JsonConverter<T>
	{
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00032599 File Offset: 0x00030799
		internal override Type KeyType
		{
			get
			{
				return this._sourceConverter.KeyType;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000325A6 File Offset: 0x000307A6
		internal override Type ElementType
		{
			get
			{
				return this._sourceConverter.ElementType;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000325B3 File Offset: 0x000307B3
		internal override JsonConverter NullableElementConverter
		{
			get
			{
				return this._sourceConverter.NullableElementConverter;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000325C0 File Offset: 0x000307C0
		public override bool HandleNull { get; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000325C8 File Offset: 0x000307C8
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return this._sourceConverter.SupportsCreateObjectDelegate;
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000325D8 File Offset: 0x000307D8
		internal CastingConverter(JsonConverter sourceConverter)
		{
			this._sourceConverter = sourceConverter;
			base.IsInternalConverter = sourceConverter.IsInternalConverter;
			base.IsInternalConverterForNumberType = sourceConverter.IsInternalConverterForNumberType;
			base.ConverterStrategy = sourceConverter.ConverterStrategy;
			base.CanBePolymorphic = sourceConverter.CanBePolymorphic;
			base.HandleNullOnRead = sourceConverter.HandleNullOnRead;
			base.HandleNullOnWrite = sourceConverter.HandleNullOnWrite;
			this.HandleNull = sourceConverter.HandleNullOnWrite;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00032646 File Offset: 0x00030846
		internal override JsonConverter SourceConverterForCastingConverter
		{
			get
			{
				return this._sourceConverter;
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003264E File Offset: 0x0003084E
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.UnboxOnRead<T>(this._sourceConverter.ReadAsObject(ref reader, typeToConvert, options));
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00032663 File Offset: 0x00030863
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			this._sourceConverter.WriteAsObject(writer, value, options);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00032678 File Offset: 0x00030878
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out T value)
		{
			object value2;
			bool result = this._sourceConverter.OnTryReadAsObject(ref reader, typeToConvert, options, ref state, out value2);
			value = JsonSerializer.UnboxOnRead<T>(value2);
			return result;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000326A4 File Offset: 0x000308A4
		internal override bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state)
		{
			return this._sourceConverter.OnTryWriteAsObject(writer, value, options, ref state);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000326BB File Offset: 0x000308BB
		public override T ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.UnboxOnRead<T>(this._sourceConverter.ReadAsPropertyNameAsObject(ref reader, typeToConvert, options));
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000326D0 File Offset: 0x000308D0
		internal override T ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.UnboxOnRead<T>(this._sourceConverter.ReadAsPropertyNameCoreAsObject(ref reader, typeToConvert, options));
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000326E5 File Offset: 0x000308E5
		public override void WriteAsPropertyName(Utf8JsonWriter writer, [DisallowNull] T value, JsonSerializerOptions options)
		{
			this._sourceConverter.WriteAsPropertyNameAsObject(writer, value, options);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000326FA File Offset: 0x000308FA
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			this._sourceConverter.WriteAsPropertyNameCoreAsObject(writer, value, options, isWritingExtensionDataProperty);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00032711 File Offset: 0x00030911
		internal override T ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			return JsonSerializer.UnboxOnRead<T>(this._sourceConverter.ReadNumberWithCustomHandlingAsObject(ref reader, handling, options));
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00032726 File Offset: 0x00030926
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T value, JsonNumberHandling handling)
		{
			this._sourceConverter.WriteNumberWithCustomHandlingAsObject(writer, value, handling);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003273B File Offset: 0x0003093B
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return this._sourceConverter.GetSchema(numberHandling);
		}

		// Token: 0x04000421 RID: 1057
		private readonly JsonConverter _sourceConverter;
	}
}
