using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000110 RID: 272
	internal sealed class IEnumerableConverter<TCollection> : JsonCollectionConverter<TCollection, object> where TCollection : IEnumerable
	{
		// Token: 0x06000D53 RID: 3411 RVA: 0x00033B7C File Offset: 0x00031D7C
		protected override void Add(in object value, ref ReadStack state)
		{
			((List<object>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00033B95 File Offset: 0x00031D95
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			if (!this._isDeserializable)
			{
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
			state.Current.ReturnValue = new List<object>();
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00033BBC File Offset: 0x00031DBC
		protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
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

		// Token: 0x04000434 RID: 1076
		private readonly bool _isDeserializable = typeof(TCollection).IsAssignableFrom(typeof(List<object>));
	}
}
