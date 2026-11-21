using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000122 RID: 290
	internal sealed class FSharpMapConverter<TMap, TKey, TValue> : DictionaryDefaultConverter<TMap, TKey, TValue> where TMap : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00034A4F File Offset: 0x00032C4F
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpMapConverter()
		{
			this._mapConstructor = FSharpCoreReflectionProxy.Instance.CreateFSharpMapConstructor<TMap, TKey, TValue>();
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00034A67 File Offset: 0x00032C67
		protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state)
		{
			((List<Tuple<TKey, TValue>>)state.Current.ReturnValue).Add(new Tuple<TKey, TValue>(key, value));
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00034A8B File Offset: 0x00032C8B
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			state.Current.ReturnValue = new List<Tuple<TKey, TValue>>();
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00034A9D File Offset: 0x00032C9D
		protected override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = this._mapConstructor((List<Tuple<TKey, TValue>>)state.Current.ReturnValue);
		}

		// Token: 0x04000441 RID: 1089
		private readonly Func<IEnumerable<Tuple<TKey, TValue>>, TMap> _mapConstructor;
	}
}
