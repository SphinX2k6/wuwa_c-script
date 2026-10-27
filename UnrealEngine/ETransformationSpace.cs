using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A9 RID: 10153
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ETransformationSpace")]
	public enum ETransformationSpace : byte
	{
		// Token: 0x04014A77 RID: 84599
		Global,
		// Token: 0x04014A78 RID: 84600
		Local,
		// Token: 0x04014A79 RID: 84601
		Tangent,
		// Token: 0x04014A7A RID: 84602
		View,
		// Token: 0x04014A7B RID: 84603
		ETransformationSpace_MAX
	}
}
