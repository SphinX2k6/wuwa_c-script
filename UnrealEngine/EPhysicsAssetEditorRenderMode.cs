using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A31 RID: 10801
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPhysicsAssetEditorRenderMode")]
	public enum EPhysicsAssetEditorRenderMode : byte
	{
		// Token: 0x04015E63 RID: 89699
		Solid,
		// Token: 0x04015E64 RID: 89700
		Wireframe,
		// Token: 0x04015E65 RID: 89701
		None,
		// Token: 0x04015E66 RID: 89702
		EPhysicsAssetEditorRenderMode_MAX
	}
}
