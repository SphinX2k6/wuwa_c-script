using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B41 RID: 2881
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EReflectionsType")]
	public enum EReflectionsType : byte
	{
		// Token: 0x04004F5F RID: 20319
		ScreenSpace,
		// Token: 0x04004F60 RID: 20320
		RayTracing,
		// Token: 0x04004F61 RID: 20321
		EReflectionsType_MAX
	}
}
