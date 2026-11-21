using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000102 RID: 258
	internal sealed class ArrayConverter<TCollection, TElement> : IEnumerableDefaultConverter<TElement[], TElement>
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00032E4D File Offset: 0x0003104D
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((List<TElement>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00032E6A File Offset: 0x0003106A
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<TElement>();
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00032E7C File Offset: 0x0003107C
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			List<TElement> list = (List<TElement>)state.Current.ReturnValue;
			state.Current.ReturnValue = list.ToArray();
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00032EAC File Offset: 0x000310AC
		protected override bool OnWriteResume(Utf8JsonWriter writer, TElement[] array, JsonSerializerOptions options, ref WriteStack state)
		{
			int i = state.Current.EnumeratorIndex;
			JsonConverter<TElement> elementConverter = JsonCollectionConverter<TElement[], TElement>.GetElementConverter(ref state);
			if (elementConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				while (i < array.Length)
				{
					elementConverter.Write(writer, array[i], options);
					i++;
				}
			}
			else
			{
				while (i < array.Length)
				{
					TElement telement = array[i];
					if (!elementConverter.TryWrite(writer, telement, options, ref state))
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
