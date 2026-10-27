using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012E6 RID: 4838
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameMatrix.EGameMatrixDeviceType")]
	public enum EGameMatrixDeviceType : byte
	{
		// Token: 0x04009849 RID: 38985
		InValid,
		// Token: 0x0400984A RID: 38986
		Android,
		// Token: 0x0400984B RID: 38987
		Android_TV,
		// Token: 0x0400984C RID: 38988
		Mac,
		// Token: 0x0400984D RID: 38989
		Windows,
		// Token: 0x0400984E RID: 38990
		PC_Win,
		// Token: 0x0400984F RID: 38991
		PC_Mac,
		// Token: 0x04009850 RID: 38992
		H5,
		// Token: 0x04009851 RID: 38993
		EGameMatrixDeviceType_MAX
	}
}
