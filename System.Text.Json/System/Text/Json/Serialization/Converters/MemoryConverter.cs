using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000FE RID: 254
	internal sealed class MemoryConverter<T> : JsonCollectionConverter<Memory<T>, T>
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00032C2C File Offset: 0x00030E2C
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out Memory<T> value)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				value = default(Memory<T>);
				return true;
			}
			return base.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000327A0 File Offset: 0x000309A0
		protected override void Add(in T value, ref ReadStack state)
		{
			((List<T>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000327BD File Offset: 0x000309BD
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<T>();
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00032C50 File Offset: 0x00030E50
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			Memory<T> memory = ((List<T>)state.Current.ReturnValue).ToArray().AsMemory<T>();
			state.Current.ReturnValue = memory;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00032C89 File Offset: 0x00030E89
		protected override bool OnWriteResume(Utf8JsonWriter writer, Memory<T> value, JsonSerializerOptions options, ref WriteStack state)
		{
			return ReadOnlyMemoryConverter<T>.OnWriteResume(writer, value.Span, options, ref state);
		}
	}
}
