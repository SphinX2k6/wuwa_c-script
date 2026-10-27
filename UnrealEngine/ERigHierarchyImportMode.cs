using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FD RID: 1277
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigHierarchyImportMode")]
	public enum ERigHierarchyImportMode : byte
	{
		// Token: 0x04002092 RID: 8338
		Append,
		// Token: 0x04002093 RID: 8339
		Replace,
		// Token: 0x04002094 RID: 8340
		ReplaceLocalTransform,
		// Token: 0x04002095 RID: 8341
		ReplaceGlobalTransform,
		// Token: 0x04002096 RID: 8342
		Max,
		// Token: 0x04002097 RID: 8343
		ERigHierarchyImportMode_MAX
	}
}
