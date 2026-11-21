using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x020008B4 RID: 2228
	[AttributeUsage(AttributeTargets.Property, Inherited = false)]
	public class UPropertyAttribute : Attribute
	{
		// Token: 0x0600BE5C RID: 48732 RVA: 0x0012FF27 File Offset: 0x0012E127
		public UPropertyAttribute(EPropertyFlags flags = EPropertyFlags.CPF_None)
		{
		}

		// Token: 0x040056DF RID: 22239
		public EPropertyFlags Flags = flags;
	}
}
