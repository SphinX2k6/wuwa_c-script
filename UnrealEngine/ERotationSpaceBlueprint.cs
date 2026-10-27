using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200181C RID: 6172
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.ERotationSpaceBlueprint")]
	public enum ERotationSpaceBlueprint : byte
	{
		// Token: 0x0400C62D RID: 50733
		RelativeToElement,
		// Token: 0x0400C62E RID: 50734
		RelativeToWorld,
		// Token: 0x0400C62F RID: 50735
		ERotationSpaceBlueprint_MAX
	}
}
