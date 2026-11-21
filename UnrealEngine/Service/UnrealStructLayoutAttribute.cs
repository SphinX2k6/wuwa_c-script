using System;

namespace UnrealEngine.Service
{
	// Token: 0x020008B3 RID: 2227
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public class UnrealStructLayoutAttribute : Attribute
	{
		// Token: 0x0600BE5B RID: 48731 RVA: 0x0012FF0A File Offset: 0x0012E10A
		public UnrealStructLayoutAttribute(int size, int pack, UnrealReflectionPropertyTypeCode unrealTypeCode = UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy)
		{
		}

		// Token: 0x040056DB RID: 22235
		public int Size = size;

		// Token: 0x040056DC RID: 22236
		public int Pack = pack;

		// Token: 0x040056DD RID: 22237
		public UnrealReflectionPropertyTypeCode UnrealTypeCode = unrealTypeCode;

		// Token: 0x040056DE RID: 22238
		public int PropertiesSize;
	}
}
