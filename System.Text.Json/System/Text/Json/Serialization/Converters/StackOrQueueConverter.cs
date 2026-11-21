using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000114 RID: 276
	internal class StackOrQueueConverter<TCollection> : JsonCollectionConverter<TCollection, object> where TCollection : IEnumerable
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000341AC File Offset: 0x000323AC
		protected sealed override void Add(in object value, ref ReadStack state)
		{
			((Action<TCollection, object>)state.Current.JsonTypeInfo.AddMethodDelegate)((TCollection)((object)state.Current.ReturnValue), value);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x000341DC File Offset: 0x000323DC
		protected sealed override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			JsonPropertyInfo parentProperty = state.ParentProperty;
			if (parentProperty != null && parentProperty.TryGetPrePopulatedValue(ref state))
			{
				return;
			}
			Func<object> createObject = state.Current.JsonTypeInfo.CreateObject;
			if (createObject == null)
			{
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
			state.Current.ReturnValue = createObject();
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00034234 File Offset: 0x00032434
		protected sealed override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
		{
			IEnumerator enumerator;
			if (state.Current.CollectionEnumerator == null)
			{
				enumerator = value.GetEnumerator();
				state.Current.CollectionEnumerator = enumerator;
				if (!enumerator.MoveNext())
				{
					return true;
				}
			}
			else
			{
				enumerator = state.Current.CollectionEnumerator;
			}
			JsonConverter<object> elementConverter = JsonCollectionConverter<TCollection, object>.GetElementConverter(ref state);
			while (!JsonConverter.ShouldFlush(ref state, writer))
			{
				object obj = enumerator.Current;
				if (!elementConverter.TryWrite(writer, obj, options, ref state))
				{
					return false;
				}
				state.Current.EndCollectionElement();
				if (!enumerator.MoveNext())
				{
					return true;
				}
			}
			return false;
		}
	}
}
