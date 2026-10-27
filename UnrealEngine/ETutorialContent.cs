using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A5 RID: 5541
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/IntroTutorials.ETutorialContent")]
	public enum ETutorialContent
	{
		// Token: 0x0400AD55 RID: 44373
		None,
		// Token: 0x0400AD56 RID: 44374
		Text,
		// Token: 0x0400AD57 RID: 44375
		UDNExcerpt,
		// Token: 0x0400AD58 RID: 44376
		RichText,
		// Token: 0x0400AD59 RID: 44377
		ETutorialContent_MAX
	}
}
