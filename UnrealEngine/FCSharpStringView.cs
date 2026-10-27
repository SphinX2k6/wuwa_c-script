using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200007B RID: 123
	public struct FCSharpStringView
	{
		// Token: 0x06000E7D RID: 3709 RVA: 0x00015DB3 File Offset: 0x00013FB3
		public unsafe FCSharpStringView(char* ptr, int strLength)
		{
			this.str = ptr;
			this.Length = strLength;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00015DC3 File Offset: 0x00013FC3
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return new string(this.str, 0, this.Length);
		}

		// Token: 0x040001BD RID: 445
		public unsafe char* str;

		// Token: 0x040001BE RID: 446
		public int Length;
	}
}
