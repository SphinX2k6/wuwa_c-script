using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022DF RID: 8927
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaint.EMeshPaintColorViewMode")]
	public enum EMeshPaintColorViewMode : byte
	{
		// Token: 0x04012109 RID: 73993
		Normal,
		// Token: 0x0401210A RID: 73994
		RGB,
		// Token: 0x0401210B RID: 73995
		Alpha,
		// Token: 0x0401210C RID: 73996
		Red,
		// Token: 0x0401210D RID: 73997
		Green,
		// Token: 0x0401210E RID: 73998
		Blue,
		// Token: 0x0401210F RID: 73999
		EMeshPaintColorViewMode_MAX
	}
}
