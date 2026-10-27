using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000460 RID: 1120
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EFieldPhysicsType")]
	public enum EFieldPhysicsType
	{
		// Token: 0x04001BE9 RID: 7145
		Field_None,
		// Token: 0x04001BEA RID: 7146
		Field_DynamicState,
		// Token: 0x04001BEB RID: 7147
		Field_LinearForce,
		// Token: 0x04001BEC RID: 7148
		Field_ExternalClusterStrain,
		// Token: 0x04001BED RID: 7149
		Field_Kill,
		// Token: 0x04001BEE RID: 7150
		Field_LinearVelocity,
		// Token: 0x04001BEF RID: 7151
		Field_AngularVelociy,
		// Token: 0x04001BF0 RID: 7152
		Field_AngularTorque,
		// Token: 0x04001BF1 RID: 7153
		Field_InternalClusterStrain,
		// Token: 0x04001BF2 RID: 7154
		Field_DisableThreshold,
		// Token: 0x04001BF3 RID: 7155
		Field_SleepingThreshold,
		// Token: 0x04001BF4 RID: 7156
		Field_PositionStatic,
		// Token: 0x04001BF5 RID: 7157
		Field_PositionAnimated,
		// Token: 0x04001BF6 RID: 7158
		Field_PositionTarget,
		// Token: 0x04001BF7 RID: 7159
		Field_DynamicConstraint,
		// Token: 0x04001BF8 RID: 7160
		Field_CollisionGroup,
		// Token: 0x04001BF9 RID: 7161
		Field_ActivateDisabled,
		// Token: 0x04001BFA RID: 7162
		Field_PhysicsType_Max
	}
}
