using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200271A RID: 10010
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sequencer.ESequencerSpawnPosition")]
	public enum ESequencerSpawnPosition
	{
		// Token: 0x04013FB9 RID: 81849
		SSP_Origin,
		// Token: 0x04013FBA RID: 81850
		SSP_PlaceInFrontOfCamera,
		// Token: 0x04013FBB RID: 81851
		SSP_MAX
	}
}
