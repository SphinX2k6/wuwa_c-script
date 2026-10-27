using System;

namespace UnrealEngine.Service
{
	// Token: 0x02002B03 RID: 11011
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public class UnrealStructLayoutAttribute : Attribute
	{
		// Token: 0x060284A1 RID: 165025 RVA: 0x003D4BAE File Offset: 0x003D2DAE
		public UnrealStructLayoutAttribute(int size, int pack, UnrealReflectionPropertyTypeCode unrealTypeCode = UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy)
		{
		}

		// Token: 0x040162C3 RID: 90819
		public int Size = size;

		// Token: 0x040162C4 RID: 90820
		public int Pack = pack;

		// Token: 0x040162C5 RID: 90821
		public UnrealReflectionPropertyTypeCode UnrealTypeCode = unrealTypeCode;

		// Token: 0x040162C6 RID: 90822
		public int PropertiesSize;
	}
}
