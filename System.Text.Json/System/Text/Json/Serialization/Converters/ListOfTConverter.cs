using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200011E RID: 286
	internal sealed class ListOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : List<TElement>
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0003479C File Offset: 0x0003299C
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((TCollection)((object)state.Current.ReturnValue)).Add(value);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000347C0 File Offset: 0x000329C0
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			JsonPropertyInfo parentProperty = state.ParentProperty;
			if (parentProperty != null && parentProperty.TryGetPrePopulatedValue(ref state))
			{
				return;
			}
			if (state.Current.JsonTypeInfo.CreateObject == null)
			{
				ThrowHelper.ThrowNotSupportedException_SerializationNotSupported(state.Current.JsonTypeInfo.Type);
			}
			state.Current.ReturnValue = state.Current.JsonTypeInfo.CreateObject();
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0003482C File Offset: 0x00032A2C
		protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
		{
			List<TElement> list = value;
			int i = state.Current.EnumeratorIndex;
			JsonConverter<TElement> elementConverter = JsonCollectionConverter<TCollection, TElement>.GetElementConverter(ref state);
			if (elementConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				while (i < list.Count)
				{
					elementConverter.Write(writer, list[i], options);
					i++;
				}
			}
			else
			{
				while (i < list.Count)
				{
					TElement telement = list[i];
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
