using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class JsonSerializableAttribute : JsonAttribute
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00027E1C File Offset: 0x0002601C
		[NullableContext(1)]
		public JsonSerializableAttribute(Type type)
		{
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00027E24 File Offset: 0x00026024
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00027E2C File Offset: 0x0002602C
		public string TypeInfoPropertyName { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00027E35 File Offset: 0x00026035
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00027E3D File Offset: 0x0002603D
		public JsonSourceGenerationMode GenerationMode { get; set; }
	}
}
