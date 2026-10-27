using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001827 RID: 6183
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEffectMakerEditor.EKuroEffectMakerMeshBuilderAttributeDomain")]
	public enum EKuroEffectMakerMeshBuilderAttributeDomain : byte
	{
		// Token: 0x0400C668 RID: 50792
		Invalid,
		// Token: 0x0400C669 RID: 50793
		Point,
		// Token: 0x0400C66A RID: 50794
		Corner,
		// Token: 0x0400C66B RID: 50795
		Primitive,
		// Token: 0x0400C66C RID: 50796
		EKuroEffectMakerMeshBuilderAttributeDomain_MAX
	}
}
