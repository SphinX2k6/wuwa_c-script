using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F4D RID: 8013
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeConvertMode")]
	public enum ELandscapeConvertMode : sbyte
	{
		// Token: 0x04010706 RID: 67334
		Invalid = -1,
		// Token: 0x04010707 RID: 67335
		Expand,
		// Token: 0x04010708 RID: 67336
		Clip,
		// Token: 0x04010709 RID: 67337
		Resample,
		// Token: 0x0401070A RID: 67338
		ResampleAndKeepStreamingProxyArea,
		// Token: 0x0401070B RID: 67339
		StreamingProxyNumToFourTimes,
		// Token: 0x0401070C RID: 67340
		SplitWpFirst,
		// Token: 0x0401070D RID: 67341
		SplitWpAfterFirst,
		// Token: 0x0401070E RID: 67342
		SplitWpRemoveDuplicateOld,
		// Token: 0x0401070F RID: 67343
		SplitWpRemoveDuplicateNew,
		// Token: 0x04010710 RID: 67344
		CheckAndRemoveSpline,
		// Token: 0x04010711 RID: 67345
		RepairMissingProperty,
		// Token: 0x04010712 RID: 67346
		OnlyUpdateCustomLayerPhysicalMaterialData,
		// Token: 0x04010713 RID: 67347
		ConvertLandscapeToStreamingProxy_Quads127x2_Bias2,
		// Token: 0x04010714 RID: 67348
		ELandscapeConvertMode_MAX
	}
}
