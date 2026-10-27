using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200132E RID: 4910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EAbilityGenericReplicatedEvent")]
	public enum EAbilityGenericReplicatedEvent
	{
		// Token: 0x04009A75 RID: 39541
		GenericConfirm,
		// Token: 0x04009A76 RID: 39542
		GenericCancel,
		// Token: 0x04009A77 RID: 39543
		InputPressed,
		// Token: 0x04009A78 RID: 39544
		InputReleased,
		// Token: 0x04009A79 RID: 39545
		GenericSignalFromClient,
		// Token: 0x04009A7A RID: 39546
		GenericSignalFromServer,
		// Token: 0x04009A7B RID: 39547
		GameCustom1,
		// Token: 0x04009A7C RID: 39548
		GameCustom2,
		// Token: 0x04009A7D RID: 39549
		GameCustom3,
		// Token: 0x04009A7E RID: 39550
		GameCustom4,
		// Token: 0x04009A7F RID: 39551
		GameCustom5,
		// Token: 0x04009A80 RID: 39552
		GameCustom6,
		// Token: 0x04009A81 RID: 39553
		MAX
	}
}
