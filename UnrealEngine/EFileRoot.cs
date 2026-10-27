using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001816 RID: 6166
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EFileRoot")]
	public enum EFileRoot : byte
	{
		// Token: 0x0400C5F5 RID: 50677
		Absolute,
		// Token: 0x0400C5F6 RID: 50678
		Content,
		// Token: 0x0400C5F7 RID: 50679
		Save,
		// Token: 0x0400C5F8 RID: 50680
		Project,
		// Token: 0x0400C5F9 RID: 50681
		EFileRoot_MAX
	}
}
