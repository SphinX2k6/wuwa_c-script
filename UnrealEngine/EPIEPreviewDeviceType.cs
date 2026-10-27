using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002648 RID: 9800
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PIEPreviewDeviceSpecification.EPIEPreviewDeviceType")]
	public enum EPIEPreviewDeviceType : byte
	{
		// Token: 0x0401390F RID: 80143
		Unset,
		// Token: 0x04013910 RID: 80144
		Android,
		// Token: 0x04013911 RID: 80145
		OpenHarmony,
		// Token: 0x04013912 RID: 80146
		IOS,
		// Token: 0x04013913 RID: 80147
		TVOS,
		// Token: 0x04013914 RID: 80148
		Switch,
		// Token: 0x04013915 RID: 80149
		MAX
	}
}
