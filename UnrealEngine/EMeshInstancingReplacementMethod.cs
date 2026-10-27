using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ACC RID: 2764
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshInstancingReplacementMethod")]
	public enum EMeshInstancingReplacementMethod : byte
	{
		// Token: 0x04004A95 RID: 19093
		RemoveOriginalActors,
		// Token: 0x04004A96 RID: 19094
		KeepOriginalActorsAsEditorOnly,
		// Token: 0x04004A97 RID: 19095
		EMeshInstancingReplacementMethod_MAX
	}
}
