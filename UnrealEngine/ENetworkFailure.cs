using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AEE RID: 2798
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENetworkFailure")]
	public enum ENetworkFailure
	{
		// Token: 0x04004B68 RID: 19304
		NetDriverAlreadyExists,
		// Token: 0x04004B69 RID: 19305
		NetDriverCreateFailure,
		// Token: 0x04004B6A RID: 19306
		NetDriverListenFailure,
		// Token: 0x04004B6B RID: 19307
		ConnectionLost,
		// Token: 0x04004B6C RID: 19308
		ConnectionTimeout,
		// Token: 0x04004B6D RID: 19309
		FailureReceived,
		// Token: 0x04004B6E RID: 19310
		OutdatedClient,
		// Token: 0x04004B6F RID: 19311
		OutdatedServer,
		// Token: 0x04004B70 RID: 19312
		PendingConnectionFailure,
		// Token: 0x04004B71 RID: 19313
		NetGuidMismatch,
		// Token: 0x04004B72 RID: 19314
		NetChecksumMismatch,
		// Token: 0x04004B73 RID: 19315
		ENetworkFailure_MAX
	}
}
