using System;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200012D RID: 301
	internal abstract class ObjectConverter : JsonConverter<object>
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00003363 File Offset: 0x00001563
		private protected override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Object;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00035346 File Offset: 0x00033546
		public ObjectConverter()
		{
			base.CanBePolymorphic = true;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00035355 File Offset: 0x00033555
		public sealed override object ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ThrowHelper.ThrowNotSupportedException_DictionaryKeyTypeNotSupported(this.Type, this);
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00035355 File Offset: 0x00033555
		internal sealed override object ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ThrowHelper.ThrowNotSupportedException_DictionaryKeyTypeNotSupported(this.Type, this);
			return null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00035364 File Offset: 0x00033564
		public sealed override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			writer.WriteStartObject();
			writer.WriteEndObject();
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0003537C File Offset: 0x0003357C
		public sealed override void WriteAsPropertyName(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			this.WriteAsPropertyNameCore(writer, value, options, false);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00035388 File Offset: 0x00033588
		internal sealed override void WriteAsPropertyNameCore(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			Type type = value.GetType();
			if (type == this.Type)
			{
				ThrowHelper.ThrowNotSupportedException_DictionaryKeyTypeNotSupported(type, this);
			}
			options.GetConverterInternal(type).WriteAsPropertyNameCoreAsObject(writer, value, options, isWritingExtensionDataProperty);
		}
	}
}
