using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A6F RID: 6767
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharacterControllerApplyType")]
	public enum EKuroCharacterControllerApplyType : byte
	{
		// Token: 0x0400D8E4 RID: 55524
		ModifyProperty,
		// Token: 0x0400D8E5 RID: 55525
		ReplaceMaterial,
		// Token: 0x0400D8E6 RID: 55526
		ReplaceBaseMaterials,
		// Token: 0x0400D8E7 RID: 55527
		ECharacterControllerApplyType_Max,
		// Token: 0x0400D8E8 RID: 55528
		EKuroCharacterControllerApplyType_MAX
	}
}
