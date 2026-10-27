using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003DD RID: 989
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARCaptureType")]
	public enum EARCaptureType : byte
	{
		// Token: 0x04001806 RID: 6150
		Camera,
		// Token: 0x04001807 RID: 6151
		QRCode,
		// Token: 0x04001808 RID: 6152
		SpatialMapping,
		// Token: 0x04001809 RID: 6153
		SceneUnderstanding,
		// Token: 0x0400180A RID: 6154
		EARCaptureType_MAX
	}
}
