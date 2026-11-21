using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000123 RID: 291
	internal sealed class FSharpSetConverter<TSet, TElement> : IEnumerableDefaultConverter<TSet, TElement> where TSet : IEnumerable<TElement>
	{
		// Token: 0x06000DAD RID: 3501 RVA: 0x00034ACA File Offset: 0x00032CCA
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpSetConverter()
		{
			this._setConstructor = FSharpCoreReflectionProxy.Instance.CreateFSharpSetConstructor<TSet, TElement>();
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00032E4D File Offset: 0x0003104D
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((List<TElement>)state.Current.ReturnValue).Add(value);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00032E6A File Offset: 0x0003106A
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new List<TElement>();
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00034AE2 File Offset: 0x00032CE2
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = this._setConstructor((List<TElement>)state.Current.ReturnValue);
		}

		// Token: 0x04000442 RID: 1090
		private readonly Func<IEnumerable<TElement>, TSet> _setConstructor;
	}
}
