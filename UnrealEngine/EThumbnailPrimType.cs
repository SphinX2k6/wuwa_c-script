using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A41 RID: 10817
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EThumbnailPrimType")]
	public enum EThumbnailPrimType
	{
		// Token: 0x04015EC5 RID: 89797
		TPT_None,
		// Token: 0x04015EC6 RID: 89798
		TPT_Sphere,
		// Token: 0x04015EC7 RID: 89799
		TPT_Cube,
		// Token: 0x04015EC8 RID: 89800
		TPT_Plane,
		// Token: 0x04015EC9 RID: 89801
		TPT_Cylinder,
		// Token: 0x04015ECA RID: 89802
		TPT_MAX
	}
}
