using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000552 RID: 1362
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_HeadHpContextType")]
	public enum EKSC_HeadHpContextType : byte
	{
		// Token: 0x04003659 RID: 13913
		Add,
		// Token: 0x0400365A RID: 13914
		Update,
		// Token: 0x0400365B RID: 13915
		Remove,
		// Token: 0x0400365C RID: 13916
		EKSC_MAX
	}
}
