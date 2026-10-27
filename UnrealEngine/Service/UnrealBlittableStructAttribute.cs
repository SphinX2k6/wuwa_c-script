using System;

namespace UnrealEngine.Service
{
	// Token: 0x02002B01 RID: 11009
	[AttributeUsage(AttributeTargets.Struct, Inherited = false)]
	public class UnrealBlittableStructAttribute : Attribute
	{
		// Token: 0x0602849F RID: 165023 RVA: 0x003D4B90 File Offset: 0x003D2D90
		public UnrealBlittableStructAttribute(UnrealReflectionPropertyTypeCode unrealTypeCode = UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
		{
		}

		// Token: 0x040162C1 RID: 90817
		public UnrealReflectionPropertyTypeCode UnrealTypeCode = unrealTypeCode;
	}
}
