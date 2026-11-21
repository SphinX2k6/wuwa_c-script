using System;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000D0 RID: 208
	internal sealed class JsonParameterInfo<T> : JsonParameterInfo
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0002E00E File Offset: 0x0002C20E
		public new JsonConverter<T> EffectiveConverter
		{
			get
			{
				return this.MatchingProperty.EffectiveConverter;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002E01B File Offset: 0x0002C21B
		public new JsonPropertyInfo<T> MatchingProperty { get; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0002E023 File Offset: 0x0002C223
		public new T EffectiveDefaultValue { get; }

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002E02C File Offset: 0x0002C22C
		public JsonParameterInfo(JsonParameterInfoValues parameterInfoValues, JsonPropertyInfo<T> matchingPropertyInfo) : base(parameterInfoValues, matchingPropertyInfo)
		{
			if (parameterInfoValues != null && parameterInfoValues.HasDefaultValue)
			{
				object defaultValue = parameterInfoValues.DefaultValue;
				if (defaultValue != null)
				{
					this.EffectiveDefaultValue = (T)((object)defaultValue);
				}
			}
			this.MatchingProperty = matchingPropertyInfo;
			base.EffectiveDefaultValue = this.EffectiveDefaultValue;
		}
	}
}
