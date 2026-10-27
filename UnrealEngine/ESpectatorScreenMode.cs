using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001464 RID: 5220
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.ESpectatorScreenMode")]
	public enum ESpectatorScreenMode : byte
	{
		// Token: 0x0400A35D RID: 41821
		Disabled,
		// Token: 0x0400A35E RID: 41822
		SingleEyeLetterboxed,
		// Token: 0x0400A35F RID: 41823
		Undistorted,
		// Token: 0x0400A360 RID: 41824
		Distorted,
		// Token: 0x0400A361 RID: 41825
		SingleEye,
		// Token: 0x0400A362 RID: 41826
		SingleEyeCroppedToFill,
		// Token: 0x0400A363 RID: 41827
		Texture,
		// Token: 0x0400A364 RID: 41828
		TexturePlusEye,
		// Token: 0x0400A365 RID: 41829
		ESpectatorScreenMode_MAX
	}
}
