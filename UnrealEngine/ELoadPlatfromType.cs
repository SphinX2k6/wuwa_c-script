using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA8 RID: 2728
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELoadPlatfromType")]
	public enum ELoadPlatfromType : byte
	{
		// Token: 0x0400494A RID: 18762
		None,
		// Token: 0x0400494B RID: 18763
		Mobile,
		// Token: 0x0400494C RID: 18764
		DeskTop,
		// Token: 0x0400494D RID: 18765
		ELoadPlatfromType_MAX
	}
}
