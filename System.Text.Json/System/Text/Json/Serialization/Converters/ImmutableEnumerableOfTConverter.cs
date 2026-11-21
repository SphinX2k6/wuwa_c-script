using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200011A RID: 282
	internal class ImmutableEnumerableOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : IEnumerable<TElement>
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x00032E4D File Offset: 0x0003104D
		protected sealed override void Add(in TElement value, ref ReadStack state)
		{
			((List<TElement>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal sealed override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00032E6A File Offset: 0x0003106A
		protected sealed override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<TElement>();
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00034604 File Offset: 0x00032804
		protected sealed override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			Func<IEnumerable<TElement>, TCollection> func = (Func<IEnumerable<TElement>, TCollection>)state.Current.JsonTypeInfo.CreateObjectWithArgs;
			state.Current.ReturnValue = func((List<TElement>)state.Current.ReturnValue);
		}
	}
}
