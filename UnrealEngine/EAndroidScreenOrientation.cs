using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002AF RID: 687
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.EAndroidScreenOrientation")]
	public enum EAndroidScreenOrientation
	{
		// Token: 0x04000F0A RID: 3850
		Portrait,
		// Token: 0x04000F0B RID: 3851
		ReversePortrait,
		// Token: 0x04000F0C RID: 3852
		SensorPortrait,
		// Token: 0x04000F0D RID: 3853
		Landscape,
		// Token: 0x04000F0E RID: 3854
		ReverseLandscape,
		// Token: 0x04000F0F RID: 3855
		SensorLandscape,
		// Token: 0x04000F10 RID: 3856
		Sensor,
		// Token: 0x04000F11 RID: 3857
		FullSensor,
		// Token: 0x04000F12 RID: 3858
		EAndroidScreenOrientation_MAX
	}
}
