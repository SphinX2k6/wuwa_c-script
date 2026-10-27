using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A68 RID: 2664
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFastArraySerializerDeltaFlags")]
	public enum EFastArraySerializerDeltaFlags : byte
	{
		// Token: 0x0400477F RID: 18303
		None,
		// Token: 0x04004780 RID: 18304
		HasBeenSerialized,
		// Token: 0x04004781 RID: 18305
		HasDeltaBeenRequested,
		// Token: 0x04004782 RID: 18306
		IsUsingDeltaSerialization = 4,
		// Token: 0x04004783 RID: 18307
		EFastArraySerializerDeltaFlags_MAX
	}
}
