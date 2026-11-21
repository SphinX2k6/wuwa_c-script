using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class JsonConverterFactory : JsonConverter
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x000249D0 File Offset: 0x00022BD0
		private protected override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.None;
		}

		// Token: 0x06000990 RID: 2448
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options);

		// Token: 0x06000991 RID: 2449 RVA: 0x000297F4 File Offset: 0x000279F4
		internal JsonConverter GetConverterInternal(Type typeToConvert, JsonSerializerOptions options)
		{
			JsonConverter jsonConverter = this.CreateConverter(typeToConvert, options);
			if (jsonConverter != null)
			{
				if (jsonConverter is JsonConverterFactory)
				{
					ThrowHelper.ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(base.GetType());
				}
			}
			else
			{
				ThrowHelper.ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(base.GetType());
			}
			return jsonConverter;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override object ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override bool OnTryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override bool TryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override object ReadAsPropertyNameAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override object ReadAsPropertyNameCoreAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override object ReadNumberWithCustomHandlingAsObject(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00028060 File Offset: 0x00026260
		public sealed override Type Type
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000235D5 File Offset: 0x000217D5
		internal sealed override void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling)
		{
			throw new InvalidOperationException();
		}
	}
}
