using System;

namespace UnrealEngine.Service
{
	// Token: 0x020008B1 RID: 2225
	[AttributeUsage(AttributeTargets.Struct, Inherited = false)]
	public class UnrealBlittableStructAttribute : Attribute
	{
		// Token: 0x0600BE59 RID: 48729 RVA: 0x0012FEEC File Offset: 0x0012E0EC
		public UnrealBlittableStructAttribute(UnrealReflectionPropertyTypeCode unrealTypeCode = UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
		{
		}

		// Token: 0x040056D9 RID: 22233
		public UnrealReflectionPropertyTypeCode UnrealTypeCode = unrealTypeCode;
	}
}
