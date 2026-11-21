using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000FA RID: 250
	internal sealed class RootLevelListConverter<T> : JsonResumableConverter<List<T>>
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x00028767 File Offset: 0x00026967
		private protected sealed override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Enumerable;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0003298C File Offset: 0x00030B8C
		internal override Type ElementType
		{
			get
			{
				return typeof(T);
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00032998 File Offset: 0x00030B98
		public RootLevelListConverter(JsonTypeInfo<T> elementTypeInfo)
		{
			base.IsRootLevelMultiContentStreamingConverter = true;
			this._elementTypeInfo = elementTypeInfo;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000329B0 File Offset: 0x00030BB0
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out List<T> value)
		{
			JsonConverter<T> effectiveConverter = this._elementTypeInfo.EffectiveConverter;
			state.Current.JsonPropertyInfo = this._elementTypeInfo.PropertyInfoForTypeInfo;
			List<T> list = (List<T>)state.Current.ReturnValue;
			bool flag;
			for (;;)
			{
				if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
				{
					if (!ref reader.TryAdvanceToNextRootLevelValueWithOptionalReadAhead(effectiveConverter.RequiresReadAhead, out flag))
					{
						break;
					}
					state.Current.PropertyState = StackFramePropertyState.ReadValue;
				}
				T item;
				bool flag2;
				if (!effectiveConverter.TryRead(ref reader, typeof(T), options, ref state, out item, out flag2))
				{
					goto Block_4;
				}
				if (list == null)
				{
					list = (state.Current.ReturnValue = new List<T>());
				}
				list.Add(item);
				state.Current.EndElement();
			}
			if (flag)
			{
				value = list;
				return true;
			}
			value = null;
			return false;
			Block_4:
			value = null;
			return false;
		}

		// Token: 0x04000423 RID: 1059
		private readonly JsonTypeInfo<T> _elementTypeInfo;
	}
}
