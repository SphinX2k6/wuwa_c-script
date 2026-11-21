using System;

namespace UnrealEngine
{
	// Token: 0x020000A1 RID: 161
	public interface IRotator
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000C70 RID: 3184
		// (set) Token: 0x06000C71 RID: 3185
		float Pitch { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000C72 RID: 3186
		// (set) Token: 0x06000C73 RID: 3187
		float Yaw { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000C74 RID: 3188
		// (set) Token: 0x06000C75 RID: 3189
		float Roll { get; set; }
	}
}
