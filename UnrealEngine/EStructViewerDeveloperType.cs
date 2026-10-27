using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A3F RID: 10815
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EStructViewerDeveloperType")]
	public enum EStructViewerDeveloperType : byte
	{
		// Token: 0x04015EB5 RID: 89781
		SVDT_None,
		// Token: 0x04015EB6 RID: 89782
		SVDT_CurrentUser,
		// Token: 0x04015EB7 RID: 89783
		SVDT_All,
		// Token: 0x04015EB8 RID: 89784
		SVDT_Max,
		// Token: 0x04015EB9 RID: 89785
		SVDT_MAX
	}
}
