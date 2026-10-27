using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021C8 RID: 8648
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIStaticMeshVertexColorType")]
	public enum UIStaticMeshVertexColorType : byte
	{
		// Token: 0x04011929 RID: 71977
		MultiplyWithUIColor,
		// Token: 0x0401192A RID: 71978
		ReplaceByUIColor,
		// Token: 0x0401192B RID: 71979
		NotAffectByUIColor,
		// Token: 0x0401192C RID: 71980
		UIStaticMeshVertexColorType_MAX
	}
}
