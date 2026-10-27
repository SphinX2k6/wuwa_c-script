using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002239 RID: 8761
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Localization.EPortableObjectFormat")]
	public enum EPortableObjectFormat : byte
	{
		// Token: 0x04011C6A RID: 72810
		Unreal,
		// Token: 0x04011C6B RID: 72811
		Crowdin,
		// Token: 0x04011C6C RID: 72812
		EPortableObjectFormat_MAX
	}
}
