using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A2 RID: 10146
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ESimplygonMetaTagType")]
	public enum ESimplygonMetaTagType : byte
	{
		// Token: 0x04014A52 RID: 84562
		None,
		// Token: 0x04014A53 RID: 84563
		Process,
		// Token: 0x04014A54 RID: 84564
		Occluder,
		// Token: 0x04014A55 RID: 84565
		ClippingGeometry,
		// Token: 0x04014A56 RID: 84566
		GeometryCameraPath,
		// Token: 0x04014A57 RID: 84567
		ExcludeFromImposterGeneration,
		// Token: 0x04014A58 RID: 84568
		ESimplygonMetaTagType_MAX
	}
}
