using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002513 RID: 9491
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ESetResolutionMethod")]
	public enum ESetResolutionMethod
	{
		// Token: 0x04012ECC RID: 77516
		Independent,
		// Token: 0x04012ECD RID: 77517
		MaxAxis,
		// Token: 0x04012ECE RID: 77518
		CellSize,
		// Token: 0x04012ECF RID: 77519
		ESetResolutionMethod_MAX
	}
}
