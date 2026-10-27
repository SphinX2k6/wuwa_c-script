using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A7C RID: 10876
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.EWwiseEventDestroyOptions")]
	public enum EWwiseEventDestroyOptions : byte
	{
		// Token: 0x04016014 RID: 90132
		StopEventOnDestroy,
		// Token: 0x04016015 RID: 90133
		WaitForEventEnd,
		// Token: 0x04016016 RID: 90134
		EWwiseEventDestroyOptions_MAX
	}
}
