using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3F RID: 2623
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerType")]
	public enum EDataLayerType : byte
	{
		// Token: 0x04004628 RID: 17960
		Runtime,
		// Token: 0x04004629 RID: 17961
		Editor,
		// Token: 0x0400462A RID: 17962
		Unknown,
		// Token: 0x0400462B RID: 17963
		Size,
		// Token: 0x0400462C RID: 17964
		EDataLayerType_MAX
	}
}
