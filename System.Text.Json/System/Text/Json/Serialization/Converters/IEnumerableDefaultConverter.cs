using System;
using System.Collections.Generic;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000112 RID: 274
	internal abstract class IEnumerableDefaultConverter<TCollection, TElement> : JsonCollectionConverter<TCollection, TElement> where TCollection : IEnumerable<TElement>
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanHaveMetadata
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000340C0 File Offset: 0x000322C0
		protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
		{
			IEnumerator<TElement> enumerator;
			if (state.Current.CollectionEnumerator == null)
			{
				enumerator = value.GetEnumerator();
				state.Current.CollectionEnumerator = enumerator;
				if (!enumerator.MoveNext())
				{
					enumerator.Dispose();
					return true;
				}
			}
			else
			{
				enumerator = (IEnumerator<TElement>)state.Current.CollectionEnumerator;
			}
			JsonConverter<TElement> elementConverter = JsonCollectionConverter<TCollection, TElement>.GetElementConverter(ref state);
			while (!JsonConverter.ShouldFlush(ref state, writer))
			{
				TElement telement = enumerator.Current;
				if (!elementConverter.TryWrite(writer, telement, options, ref state))
				{
					return false;
				}
				state.Current.EndCollectionElement();
				if (!enumerator.MoveNext())
				{
					enumerator.Dispose();
					return true;
				}
			}
			return false;
		}
	}
}
