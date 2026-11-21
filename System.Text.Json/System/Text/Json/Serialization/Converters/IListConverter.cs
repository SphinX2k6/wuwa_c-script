using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000115 RID: 277
	internal sealed class IListConverter<TCollection> : JsonCollectionConverter<TCollection, object> where TCollection : IList
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000342CC File Offset: 0x000324CC
		protected override void Add(in object value, ref ReadStack state)
		{
			TCollection tcollection = (TCollection)((object)state.Current.ReturnValue);
			tcollection.Add(value);
			if (base.IsValueType)
			{
				state.Current.ReturnValue = tcollection;
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00034314 File Offset: 0x00032514
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			base.CreateCollection(ref reader, ref state, options);
			TCollection tcollection = (TCollection)((object)state.Current.ReturnValue);
			if (tcollection.IsReadOnly)
			{
				state.Current.ReturnValue = null;
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00034364 File Offset: 0x00032564
		protected override bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
		{
			IList list = value;
			int i = state.Current.EnumeratorIndex;
			JsonConverter<object> elementConverter = JsonCollectionConverter<TCollection, object>.GetElementConverter(ref state);
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
					object obj = list[i];
					if (!elementConverter.TryWrite(writer, obj, options, ref state))
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

		// Token: 0x06000D6C RID: 3436 RVA: 0x00034428 File Offset: 0x00032628
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			if (jsonTypeInfo.CreateObject == null && this.Type.IsAssignableFrom(typeof(List<object>)))
			{
				jsonTypeInfo.CreateObject = (() => new List<object>());
			}
		}
	}
}
