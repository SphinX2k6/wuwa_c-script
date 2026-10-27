using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F4E RID: 8014
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeImportResult")]
	public enum ELandscapeImportResult : byte
	{
		// Token: 0x04010716 RID: 67350
		Success,
		// Token: 0x04010717 RID: 67351
		Warning,
		// Token: 0x04010718 RID: 67352
		Error,
		// Token: 0x04010719 RID: 67353
		ELandscapeImportResult_MAX
	}
}
