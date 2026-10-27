using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002009 RID: 8201
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIRenderableType")]
	public enum EUIRenderableType : byte
	{
		// Token: 0x04010C96 RID: 68758
		None,
		// Token: 0x04010C97 RID: 68759
		UIBatchGeometryRenderable,
		// Token: 0x04010C98 RID: 68760
		UIPostProcessRenderable,
		// Token: 0x04010C99 RID: 68761
		UIDirectMeshRenderable,
		// Token: 0x04010C9A RID: 68762
		UINiagaraRenderable,
		// Token: 0x04010C9B RID: 68763
		UISpineRenderable,
		// Token: 0x04010C9C RID: 68764
		UIDynamicBathMesh,
		// Token: 0x04010C9D RID: 68765
		EUIRenderableType_MAX
	}
}
