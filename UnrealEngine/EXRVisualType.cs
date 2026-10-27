using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001468 RID: 5224
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EXRVisualType")]
	public enum EXRVisualType : byte
	{
		// Token: 0x0400A37A RID: 41850
		Controller,
		// Token: 0x0400A37B RID: 41851
		Hand,
		// Token: 0x0400A37C RID: 41852
		EXRVisualType_MAX
	}
}
