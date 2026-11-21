using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000060 RID: 96
	public struct FCSharpStringView
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00010AD3 File Offset: 0x0000ECD3
		public unsafe FCSharpStringView(char* ptr, int strLength)
		{
			this.str = ptr;
			this.Length = strLength;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00010AE3 File Offset: 0x0000ECE3
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return new string(this.str, 0, this.Length);
		}

		// Token: 0x04000176 RID: 374
		public unsafe char* str;

		// Token: 0x04000177 RID: 375
		public int Length;
	}
}
