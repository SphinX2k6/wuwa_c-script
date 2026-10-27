using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001825 RID: 6181
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorUtility.EIEMeshEditorShapeType")]
	public enum EIEMeshEditorShapeType : byte
	{
		// Token: 0x0400C65B RID: 50779
		Box,
		// Token: 0x0400C65C RID: 50780
		Sphere,
		// Token: 0x0400C65D RID: 50781
		Capsule,
		// Token: 0x0400C65E RID: 50782
		EIEMeshEditorShapeType_MAX
	}
}
