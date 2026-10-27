using System;

namespace UnrealEngine
{
	// Token: 0x020000BC RID: 188
	public interface IRotator
	{
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060010DD RID: 4317
		// (set) Token: 0x060010DE RID: 4318
		float Pitch { get; set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060010DF RID: 4319
		// (set) Token: 0x060010E0 RID: 4320
		float Yaw { get; set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060010E1 RID: 4321
		// (set) Token: 0x060010E2 RID: 4322
		float Roll { get; set; }
	}
}
