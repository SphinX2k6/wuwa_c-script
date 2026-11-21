using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false)]
	public class JsonConverterAttribute : JsonAttribute
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00028049 File Offset: 0x00026249
		public JsonConverterAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type converterType)
		{
			this.ConverterType = converterType;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00027E1C File Offset: 0x0002601C
		protected JsonConverterAttribute()
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00028058 File Offset: 0x00026258
		[Nullable(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
		public Type ConverterType { [NullableContext(2)] get; }

		// Token: 0x060008E0 RID: 2272 RVA: 0x00028060 File Offset: 0x00026260
		[return: Nullable(2)]
		public virtual JsonConverter CreateConverter(Type typeToConvert)
		{
			return null;
		}
	}
}
