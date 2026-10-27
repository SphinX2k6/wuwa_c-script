using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024DC RID: 9436
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENCPoolMethod")]
	public enum ENCPoolMethod : byte
	{
		// Token: 0x04012D99 RID: 77209
		None,
		// Token: 0x04012D9A RID: 77210
		AutoRelease,
		// Token: 0x04012D9B RID: 77211
		ManualRelease,
		// Token: 0x04012D9C RID: 77212
		ManualRelease_OnComplete,
		// Token: 0x04012D9D RID: 77213
		FreeInPool,
		// Token: 0x04012D9E RID: 77214
		ENCPoolMethod_MAX
	}
}
