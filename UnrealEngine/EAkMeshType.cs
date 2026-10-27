using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000278 RID: 632
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMeshType")]
	public enum EAkMeshType : byte
	{
		// Token: 0x04000D0C RID: 3340
		StaticMesh,
		// Token: 0x04000D0D RID: 3341
		CollisionMesh,
		// Token: 0x04000D0E RID: 3342
		EAkMeshType_MAX
	}
}
