using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001462 RID: 5218
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EOrientPositionSelector")]
	public enum EOrientPositionSelector
	{
		// Token: 0x0400A352 RID: 41810
		Orientation,
		// Token: 0x0400A353 RID: 41811
		Position,
		// Token: 0x0400A354 RID: 41812
		OrientationAndPosition,
		// Token: 0x0400A355 RID: 41813
		EOrientPositionSelector_MAX
	}
}
