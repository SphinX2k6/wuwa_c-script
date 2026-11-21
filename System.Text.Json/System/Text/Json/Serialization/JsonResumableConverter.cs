using System;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A7 RID: 167
	internal abstract class JsonResumableConverter<T> : JsonConverter<T>
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x000249D0 File Offset: 0x00022BD0
		public override bool HandleNull
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002A304 File Offset: 0x00028504
		public sealed override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			ReadStack readStack = default(ReadStack);
			JsonTypeInfo typeInfoInternal = options.GetTypeInfoInternal(typeToConvert, true, new bool?(true), false, false);
			readStack.Initialize(typeInfoInternal, false);
			T result;
			bool flag;
			base.TryRead(ref reader, typeToConvert, options, ref readStack, out result, out flag);
			return result;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002A354 File Offset: 0x00028554
		public sealed override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			WriteStack writeStack = default(WriteStack);
			JsonTypeInfo typeInfoInternal = options.GetTypeInfoInternal(typeof(T), true, new bool?(true), false, false);
			writeStack.Initialize(typeInfoInternal, null, false, false);
			try
			{
				base.TryWrite(writer, value, options, ref writeStack);
			}
			catch
			{
				writeStack.DisposePendingDisposablesOnException();
				throw;
			}
		}
	}
}
