using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284F RID: 10319
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.ESelectionMode")]
	public enum ESelectionMode
	{
		// Token: 0x04014FD9 RID: 85977
		None,
		// Token: 0x04014FDA RID: 85978
		Single,
		// Token: 0x04014FDB RID: 85979
		SingleToggle,
		// Token: 0x04014FDC RID: 85980
		Multi,
		// Token: 0x04014FDD RID: 85981
		ESelectionMode_MAX
	}
}
