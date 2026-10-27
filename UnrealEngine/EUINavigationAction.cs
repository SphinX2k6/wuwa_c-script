using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200280F RID: 10255
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EUINavigationAction")]
	public enum EUINavigationAction : byte
	{
		// Token: 0x04014DFB RID: 85499
		Accept,
		// Token: 0x04014DFC RID: 85500
		Back,
		// Token: 0x04014DFD RID: 85501
		Num,
		// Token: 0x04014DFE RID: 85502
		Invalid,
		// Token: 0x04014DFF RID: 85503
		EUINavigationAction_MAX
	}
}
