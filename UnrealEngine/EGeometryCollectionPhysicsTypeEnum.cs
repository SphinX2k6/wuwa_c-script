using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000463 RID: 1123
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EGeometryCollectionPhysicsTypeEnum")]
	public enum EGeometryCollectionPhysicsTypeEnum : byte
	{
		// Token: 0x04001C08 RID: 7176
		Chaos_AngularVelocity,
		// Token: 0x04001C09 RID: 7177
		Chaos_DynamicState,
		// Token: 0x04001C0A RID: 7178
		Chaos_LinearVelocity,
		// Token: 0x04001C0B RID: 7179
		Chaos_InitialAngularVelocity,
		// Token: 0x04001C0C RID: 7180
		Chaos_InitialLinearVelocity,
		// Token: 0x04001C0D RID: 7181
		Chaos_CollisionGroup,
		// Token: 0x04001C0E RID: 7182
		Chaos_LinearForce,
		// Token: 0x04001C0F RID: 7183
		Chaos_AngularTorque,
		// Token: 0x04001C10 RID: 7184
		Chaos_Max,
		// Token: 0x04001C11 RID: 7185
		Chaos_MAX
	}
}
