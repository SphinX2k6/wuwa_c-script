using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000113 RID: 275
	internal sealed class IEnumerableOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : IEnumerable<TElement>
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x00032E4D File Offset: 0x0003104D
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((List<TElement>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0003415E File Offset: 0x0003235E
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			if (!this._isDeserializable)
			{
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
			state.Current.ReturnValue = new List<TElement>();
		}

		// Token: 0x04000438 RID: 1080
		private readonly bool _isDeserializable = typeof(TCollection).IsAssignableFrom(typeof(List<TElement>));
	}
}
