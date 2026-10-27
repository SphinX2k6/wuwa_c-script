using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A4 RID: 5540
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/IntroTutorials.ETutorialAnchorIdentifier")]
	public enum ETutorialAnchorIdentifier
	{
		// Token: 0x0400AD50 RID: 44368
		None,
		// Token: 0x0400AD51 RID: 44369
		NamedWidget,
		// Token: 0x0400AD52 RID: 44370
		Asset,
		// Token: 0x0400AD53 RID: 44371
		ETutorialAnchorIdentifier_MAX
	}
}
