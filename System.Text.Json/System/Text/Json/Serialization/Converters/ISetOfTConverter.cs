using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200011C RID: 284
	internal sealed class ISetOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : ISet<TElement>
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0003469C File Offset: 0x0003289C
		protected override void Add(in TElement value, ref ReadStack state)
		{
			TCollection tcollection = (TCollection)((object)state.Current.ReturnValue);
			tcollection.Add(value);
			if (base.IsValueType)
			{
				state.Current.ReturnValue = tcollection;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000346E8 File Offset: 0x000328E8
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

		// Token: 0x06000D8E RID: 3470 RVA: 0x00034738 File Offset: 0x00032938
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			if (jsonTypeInfo.CreateObject == null && this.Type.IsAssignableFrom(typeof(HashSet<TElement>)))
			{
				jsonTypeInfo.CreateObject = (() => new HashSet<TElement>());
			}
		}
	}
}
