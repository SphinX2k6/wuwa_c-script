using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022DE RID: 8926
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintMode.ETextureWeightTypes")]
	public enum ETextureWeightTypes : byte
	{
		// Token: 0x04012103 RID: 73987
		AlphaLerp = 2,
		// Token: 0x04012104 RID: 73988
		RGB,
		// Token: 0x04012105 RID: 73989
		ARGB,
		// Token: 0x04012106 RID: 73990
		OneMinusARGB,
		// Token: 0x04012107 RID: 73991
		ETextureWeightTypes_MAX
	}
}
