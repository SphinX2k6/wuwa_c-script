using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Schema;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000FC RID: 252
	internal sealed class JsonMetadataServicesConverter<T> : JsonResumableConverter<T>
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00032A94 File Offset: 0x00030C94
		internal JsonConverter<T> Converter { get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00032A9C File Offset: 0x00030C9C
		internal override Type KeyType
		{
			get
			{
				return this.Converter.KeyType;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00032AA9 File Offset: 0x00030CA9
		internal override Type ElementType
		{
			get
			{
				return this.Converter.ElementType;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00032AB6 File Offset: 0x00030CB6
		internal override JsonConverter NullableElementConverter
		{
			get
			{
				return this.Converter.NullableElementConverter;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00032AC3 File Offset: 0x00030CC3
		public override bool HandleNull { get; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00032ACB File Offset: 0x00030CCB
		internal override bool ConstructorIsParameterized
		{
			get
			{
				return this.Converter.ConstructorIsParameterized;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00032AD8 File Offset: 0x00030CD8
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return this.Converter.SupportsCreateObjectDelegate;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00032AE5 File Offset: 0x00030CE5
		internal override bool CanHaveMetadata
		{
			get
			{
				return this.Converter.CanHaveMetadata;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00032AF2 File Offset: 0x00030CF2
		internal override bool CanPopulate
		{
			get
			{
				return this.Converter.CanPopulate;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00032B00 File Offset: 0x00030D00
		public JsonMetadataServicesConverter(JsonConverter<T> converter)
		{
			this.Converter = converter;
			base.ConverterStrategy = converter.ConverterStrategy;
			base.IsInternalConverter = converter.IsInternalConverter;
			base.IsInternalConverterForNumberType = converter.IsInternalConverterForNumberType;
			base.CanBePolymorphic = converter.CanBePolymorphic;
			base.HandleNullOnRead = converter.HandleNullOnRead;
			base.HandleNullOnWrite = converter.HandleNullOnWrite;
			this.HandleNull = converter.HandleNullOnWrite;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00032B6E File Offset: 0x00030D6E
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out T value)
		{
			return this.Converter.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00032B84 File Offset: 0x00030D84
		internal override bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (!state.SupportContinuation && jsonTypeInfo.CanUseSerializeHandler && !JsonHelpers.RequiresSpecialNumberHandlingOnWrite(state.Current.NumberHandling) && !state.CurrentContainsMetadata)
			{
				((JsonTypeInfo<T>)jsonTypeInfo).SerializeHandler(writer, value);
				return true;
			}
			return this.Converter.OnTryWrite(writer, value, options, ref state);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00032BEF File Offset: 0x00030DEF
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			this.Converter.ConfigureJsonTypeInfo(jsonTypeInfo, options);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00032BFE File Offset: 0x00030DFE
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return this.Converter.GetSchema(numberHandling);
		}
	}
}
