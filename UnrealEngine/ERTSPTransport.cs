using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200129F RID: 4767
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FFMPEGMediaFactory.ERTSPTransport")]
	public enum ERTSPTransport : byte
	{
		// Token: 0x040095B6 RID: 38326
		Default,
		// Token: 0x040095B7 RID: 38327
		Udp,
		// Token: 0x040095B8 RID: 38328
		UdpMulticast,
		// Token: 0x040095B9 RID: 38329
		Tcp,
		// Token: 0x040095BA RID: 38330
		Http,
		// Token: 0x040095BB RID: 38331
		Https,
		// Token: 0x040095BC RID: 38332
		ERTSPTransport_MAX
	}
}
