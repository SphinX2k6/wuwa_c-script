using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024E0 RID: 9440
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENDIStaticMesh_SourceMode")]
	public enum ENDIStaticMesh_SourceMode : byte
	{
		// Token: 0x04012DAE RID: 77230
		Default,
		// Token: 0x04012DAF RID: 77231
		Source,
		// Token: 0x04012DB0 RID: 77232
		AttachParent,
		// Token: 0x04012DB1 RID: 77233
		DefaultMeshOnly,
		// Token: 0x04012DB2 RID: 77234
		ENDIStaticMesh_MAX
	}
}
