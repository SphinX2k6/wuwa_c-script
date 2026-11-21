using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200008D RID: 141
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class JsonPolymorphicAttribute : JsonAttribute
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000280FD File Offset: 0x000262FD
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00028105 File Offset: 0x00026305
		public string TypeDiscriminatorPropertyName { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002810E File Offset: 0x0002630E
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00028116 File Offset: 0x00026316
		public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0002811F File Offset: 0x0002631F
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00028127 File Offset: 0x00026327
		public bool IgnoreUnrecognizedTypeDiscriminators { get; set; }
	}
}
