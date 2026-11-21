using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000F8 RID: 248
	internal sealed class ReadOnlyMemoryConverter<T> : JsonCollectionConverter<ReadOnlyMemory<T>, T>
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003277D File Offset: 0x0003097D
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out ReadOnlyMemory<T> value)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				value = default(ReadOnlyMemory<T>);
				return true;
			}
			return base.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000327A0 File Offset: 0x000309A0
		protected override void Add(in T value, ref ReadStack state)
		{
			((List<T>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000327BD File Offset: 0x000309BD
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<T>();
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000327D0 File Offset: 0x000309D0
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			ReadOnlyMemory<T> readOnlyMemory = ((List<T>)state.Current.ReturnValue).ToArray().AsMemory<T>();
			state.Current.ReturnValue = readOnlyMemory;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0003280E File Offset: 0x00030A0E
		protected override bool OnWriteResume(Utf8JsonWriter writer, ReadOnlyMemory<T> value, JsonSerializerOptions options, ref WriteStack state)
		{
			return ReadOnlyMemoryConverter<T>.OnWriteResume(writer, value.Span, options, ref state);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00032820 File Offset: 0x00030A20
		internal unsafe static bool OnWriteResume(Utf8JsonWriter writer, ReadOnlySpan<T> value, JsonSerializerOptions options, ref WriteStack state)
		{
			int i = state.Current.EnumeratorIndex;
			JsonConverter<T> elementConverter = JsonCollectionConverter<ReadOnlyMemory<T>, T>.GetElementConverter(ref state);
			if (elementConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				while (i < value.Length)
				{
					elementConverter.Write(writer, *value[i], options);
					i++;
				}
			}
			else
			{
				while (i < value.Length)
				{
					if (!elementConverter.TryWrite(writer, value[i], options, ref state))
					{
						state.Current.EnumeratorIndex = i;
						return false;
					}
					state.Current.EndCollectionElement();
					if (JsonConverter.ShouldFlush(ref state, writer))
					{
						state.Current.EnumeratorIndex = i + 1;
						return false;
					}
					i++;
				}
			}
			return true;
		}
	}
}
