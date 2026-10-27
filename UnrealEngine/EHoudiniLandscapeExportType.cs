using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148B RID: 5259
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniLandscapeExportType")]
	public enum EHoudiniLandscapeExportType : byte
	{
		// Token: 0x0400A48D RID: 42125
		Heightfield,
		// Token: 0x0400A48E RID: 42126
		Mesh,
		// Token: 0x0400A48F RID: 42127
		Points,
		// Token: 0x0400A490 RID: 42128
		EHoudiniLandscapeExportType_MAX
	}
}
