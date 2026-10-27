using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024E5 RID: 9445
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraDataSetType")]
	public enum ENiagaraDataSetType : byte
	{
		// Token: 0x04012DCA RID: 77258
		ParticleData,
		// Token: 0x04012DCB RID: 77259
		Shared,
		// Token: 0x04012DCC RID: 77260
		Event,
		// Token: 0x04012DCD RID: 77261
		ENiagaraDataSetType_MAX
	}
}
