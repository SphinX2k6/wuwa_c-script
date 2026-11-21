using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000088 RID: 136
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	public class JsonDerivedTypeAttribute : JsonAttribute
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00028063 File Offset: 0x00026263
		public JsonDerivedTypeAttribute(Type derivedType)
		{
			this.DerivedType = derivedType;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00028072 File Offset: 0x00026272
		public JsonDerivedTypeAttribute(Type derivedType, string typeDiscriminator)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = typeDiscriminator;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00028088 File Offset: 0x00026288
		public JsonDerivedTypeAttribute(Type derivedType, int typeDiscriminator)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = typeDiscriminator;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000280A3 File Offset: 0x000262A3
		public Type DerivedType { get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000280AB File Offset: 0x000262AB
		[Nullable(2)]
		public object TypeDiscriminator { [NullableContext(2)] get; }
	}
}
