using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026A9 RID: 9897
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EGeneratedContentType")]
	public enum EGeneratedContentType : byte
	{
		// Token: 0x04013C96 RID: 81046
		ProcGen_None,
		// Token: 0x04013C97 RID: 81047
		ProcGen_GeneratedByDeci,
		// Token: 0x04013C98 RID: 81048
		ProcGen_GeneratedHLOD,
		// Token: 0x04013C99 RID: 81049
		Count,
		// Token: 0x04013C9A RID: 81050
		EGeneratedContentType_MAX
	}
}
