using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F5C RID: 8028
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeImportAlphamapType")]
	public enum ELandscapeImportAlphamapType : byte
	{
		// Token: 0x04010766 RID: 67430
		Additive,
		// Token: 0x04010767 RID: 67431
		Layered,
		// Token: 0x04010768 RID: 67432
		ELandscapeImportAlphamapType_MAX
	}
}
