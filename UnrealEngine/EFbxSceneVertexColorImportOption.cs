using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A22 RID: 10786
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFbxSceneVertexColorImportOption")]
	public enum EFbxSceneVertexColorImportOption : byte
	{
		// Token: 0x04015E06 RID: 89606
		Replace,
		// Token: 0x04015E07 RID: 89607
		Ignore,
		// Token: 0x04015E08 RID: 89608
		Override,
		// Token: 0x04015E09 RID: 89609
		EFbxSceneVertexColorImportOption_MAX
	}
}
