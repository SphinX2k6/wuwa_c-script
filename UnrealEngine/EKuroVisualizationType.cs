using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A4D RID: 6733
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroVisualizationType")]
	public enum EKuroVisualizationType : byte
	{
		// Token: 0x0400D769 RID: 55145
		Box,
		// Token: 0x0400D76A RID: 55146
		Sphere,
		// Token: 0x0400D76B RID: 55147
		EKuroVisualizationType_MAX
	}
}
