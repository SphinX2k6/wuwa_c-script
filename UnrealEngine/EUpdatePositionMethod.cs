using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023D1 RID: 9169
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EUpdatePositionMethod")]
	public enum EUpdatePositionMethod : byte
	{
		// Token: 0x0401268A RID: 75402
		Play,
		// Token: 0x0401268B RID: 75403
		Jump,
		// Token: 0x0401268C RID: 75404
		Scrub,
		// Token: 0x0401268D RID: 75405
		EUpdatePositionMethod_MAX
	}
}
