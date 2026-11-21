using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200010E RID: 270
	internal sealed class IDictionaryOfTKeyTValueConverter<TDictionary, TKey, TValue> : DictionaryDefaultConverter<TDictionary, TKey, TValue> where TDictionary : IDictionary<TKey, TValue>
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00033A78 File Offset: 0x00031C78
		protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state)
		{
			TDictionary tdictionary = (TDictionary)((object)state.Current.ReturnValue);
			tdictionary[key] = value;
			if (base.IsValueType)
			{
				state.Current.ReturnValue = tdictionary;
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00033AC8 File Offset: 0x00031CC8
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			base.CreateCollection(ref reader, ref state);
			TDictionary tdictionary = (TDictionary)((object)state.Current.ReturnValue);
			if (tdictionary.IsReadOnly)
			{
				state.Current.ReturnValue = null;
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00033B18 File Offset: 0x00031D18
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			if (jsonTypeInfo.CreateObject == null && this.Type.IsAssignableFrom(typeof(Dictionary<TKey, TValue>)))
			{
				jsonTypeInfo.CreateObject = (() => new Dictionary<TKey, TValue>());
			}
		}
	}
}
