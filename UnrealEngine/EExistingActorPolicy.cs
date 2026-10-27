using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A4B RID: 10827
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDImporter.EExistingActorPolicy")]
	public enum EExistingActorPolicy : byte
	{
		// Token: 0x04015EFC RID: 89852
		Replace,
		// Token: 0x04015EFD RID: 89853
		UpdateTransform,
		// Token: 0x04015EFE RID: 89854
		Ignore,
		// Token: 0x04015EFF RID: 89855
		EExistingActorPolicy_MAX
	}
}
