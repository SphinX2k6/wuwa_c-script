using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000104 RID: 260
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EPropertyAccessChangeNotifyMode")]
	public enum EPropertyAccessChangeNotifyMode : byte
	{
		// Token: 0x040004C7 RID: 1223
		Default,
		// Token: 0x040004C8 RID: 1224
		Never,
		// Token: 0x040004C9 RID: 1225
		Always,
		// Token: 0x040004CA RID: 1226
		EPropertyAccessChangeNotifyMode_MAX
	}
}
