using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000121 RID: 289
	internal sealed class FSharpListConverter<TList, TElement> : IEnumerableDefaultConverter<TList, TElement> where TList : IEnumerable<TElement>
	{
		// Token: 0x06000DA0 RID: 3488 RVA: 0x00034A0A File Offset: 0x00032C0A
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpListConverter()
		{
			this._listConstructor = FSharpCoreReflectionProxy.Instance.CreateFSharpListConstructor<TList, TElement>();
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00032E4D File Offset: 0x0003104D
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((List<TElement>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00032E6A File Offset: 0x0003106A
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<TElement>();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00034A22 File Offset: 0x00032C22
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = this._listConstructor((List<TElement>)state.Current.ReturnValue);
		}

		// Token: 0x04000440 RID: 1088
		private readonly Func<IEnumerable<TElement>, TList> _listConstructor;
	}
}
