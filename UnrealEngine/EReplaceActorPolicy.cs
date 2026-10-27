using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A4F RID: 10831
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDStageImporter.EReplaceActorPolicy")]
	public enum EReplaceActorPolicy : byte
	{
		// Token: 0x04015F0F RID: 89871
		Append,
		// Token: 0x04015F10 RID: 89872
		Replace,
		// Token: 0x04015F11 RID: 89873
		UpdateTransform,
		// Token: 0x04015F12 RID: 89874
		Ignore,
		// Token: 0x04015F13 RID: 89875
		EReplaceActorPolicy_MAX
	}
}
