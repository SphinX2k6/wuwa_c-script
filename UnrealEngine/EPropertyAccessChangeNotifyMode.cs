using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200071D RID: 1821
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EPropertyAccessChangeNotifyMode")]
	public enum EPropertyAccessChangeNotifyMode : byte
	{
		// Token: 0x04002E5D RID: 11869
		Default,
		// Token: 0x04002E5E RID: 11870
		Never,
		// Token: 0x04002E5F RID: 11871
		Always,
		// Token: 0x04002E60 RID: 11872
		EPropertyAccessChangeNotifyMode_MAX
	}
}
