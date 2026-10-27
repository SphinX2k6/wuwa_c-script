using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024D7 RID: 9431
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EKuroBlurRadialMode")]
	public enum EKuroBlurRadialMode : byte
	{
		// Token: 0x04012D6D RID: 77165
		ZoomBlur,
		// Token: 0x04012D6E RID: 77166
		SpinBlur,
		// Token: 0x04012D6F RID: 77167
		DirectionalBlur,
		// Token: 0x04012D70 RID: 77168
		JitterRadial,
		// Token: 0x04012D71 RID: 77169
		EKuroBlurRadialMode_MAX
	}
}
