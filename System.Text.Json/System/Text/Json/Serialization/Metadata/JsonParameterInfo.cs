using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000CF RID: 207
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonParameterInfo
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002DE7C File Offset: 0x0002C07C
		internal JsonParameterInfo(JsonParameterInfoValues parameterInfoValues, JsonPropertyInfo matchingProperty)
		{
			this.Position = parameterInfoValues.Position;
			this.Name = parameterInfoValues.Name;
			this.HasDefaultValue = parameterInfoValues.HasDefaultValue;
			this.DefaultValue = (parameterInfoValues.HasDefaultValue ? parameterInfoValues.DefaultValue : null);
			this.MatchingProperty = matchingProperty;
			this.IsMemberInitializer = parameterInfoValues.IsMemberInitializer;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0002DEDD File Offset: 0x0002C0DD
		public Type DeclaringType
		{
			get
			{
				return this.MatchingProperty.DeclaringType;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0002DEEA File Offset: 0x0002C0EA
		public int Position { get; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0002DEF2 File Offset: 0x0002C0F2
		public Type ParameterType
		{
			get
			{
				return this.MatchingProperty.PropertyType;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0002DEFF File Offset: 0x0002C0FF
		public string Name { get; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0002DF07 File Offset: 0x0002C107
		public bool HasDefaultValue { get; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0002DF0F File Offset: 0x0002C10F
		[Nullable(2)]
		public object DefaultValue { [NullableContext(2)] get; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0002DF17 File Offset: 0x0002C117
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x0002DF1F File Offset: 0x0002C11F
		[Nullable(2)]
		protected internal object EffectiveDefaultValue { internal get; private protected set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0002DF28 File Offset: 0x0002C128
		public bool IsNullable
		{
			get
			{
				return this.MatchingProperty.IsSetNullable;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002DF35 File Offset: 0x0002C135
		public bool IsMemberInitializer { get; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002DF40 File Offset: 0x0002C140
		[Nullable(2)]
		public ICustomAttributeProvider AttributeProvider
		{
			[NullableContext(2)]
			get
			{
				ICustomAttributeProvider customAttributeProvider = this._attributeProvider;
				if (customAttributeProvider == null)
				{
					MethodBase methodBase = this.MatchingProperty.DeclaringTypeInfo.ConstructorAttributeProvider as MethodBase;
					if (methodBase != null)
					{
						ParameterInfo[] parameters = methodBase.GetParameters();
						if (this.Position < parameters.Length)
						{
							customAttributeProvider = (this._attributeProvider = parameters[this.Position]);
						}
					}
				}
				return customAttributeProvider;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0002DF93 File Offset: 0x0002C193
		internal JsonPropertyInfo MatchingProperty { get; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0002DF9B File Offset: 0x0002C19B
		internal JsonConverter EffectiveConverter
		{
			get
			{
				return this.MatchingProperty.EffectiveConverter;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		internal bool IgnoreNullTokensOnRead
		{
			get
			{
				return this.MatchingProperty.IgnoreNullTokensOnRead;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002DFB5 File Offset: 0x0002C1B5
		internal JsonSerializerOptions Options
		{
			get
			{
				return this.MatchingProperty.Options;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002DFC2 File Offset: 0x0002C1C2
		internal byte[] JsonNameAsUtf8Bytes
		{
			get
			{
				return this.MatchingProperty.NameAsUtf8Bytes;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0002DFCF File Offset: 0x0002C1CF
		internal JsonNumberHandling? NumberHandling
		{
			get
			{
				return this.MatchingProperty.EffectiveNumberHandling;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		internal JsonTypeInfo JsonTypeInfo
		{
			get
			{
				return this.MatchingProperty.JsonTypeInfo;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0002DFE9 File Offset: 0x0002C1E9
		internal bool ShouldDeserialize
		{
			get
			{
				return !this.MatchingProperty.IsIgnored;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0002DFF9 File Offset: 0x0002C1F9
		internal bool IsRequiredParameter
		{
			get
			{
				return !this.HasDefaultValue && !this.IsMemberInitializer;
			}
		}

		// Token: 0x04000371 RID: 881
		private ICustomAttributeProvider _attributeProvider;
	}
}
