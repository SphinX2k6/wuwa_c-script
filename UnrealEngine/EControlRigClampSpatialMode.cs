using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E5 RID: 1253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigClampSpatialMode")]
	public enum EControlRigClampSpatialMode
	{
		// Token: 0x04002009 RID: 8201
		Plane,
		// Token: 0x0400200A RID: 8202
		Cylinder,
		// Token: 0x0400200B RID: 8203
		Sphere,
		// Token: 0x0400200C RID: 8204
		EControlRigClampSpatialMode_MAX
	}
}
