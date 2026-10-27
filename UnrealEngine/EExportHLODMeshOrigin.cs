using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A67 RID: 2663
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EExportHLODMeshOrigin")]
	public enum EExportHLODMeshOrigin : byte
	{
		// Token: 0x0400477B RID: 18299
		Actor,
		// Token: 0x0400477C RID: 18300
		World,
		// Token: 0x0400477D RID: 18301
		EExportHLODMeshOrigin_MAX
	}
}
