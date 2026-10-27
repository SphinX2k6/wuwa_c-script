using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022DC RID: 8924
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintMode.EPaintMode")]
	public enum EPaintMode : byte
	{
		// Token: 0x040120F8 RID: 73976
		Vertices,
		// Token: 0x040120F9 RID: 73977
		Textures,
		// Token: 0x040120FA RID: 73978
		EPaintMode_MAX
	}
}
