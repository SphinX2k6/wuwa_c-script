using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A21 RID: 2593
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraShakeDurationType")]
	public enum ECameraShakeDurationType : byte
	{
		// Token: 0x0400455C RID: 17756
		Fixed,
		// Token: 0x0400455D RID: 17757
		Infinite,
		// Token: 0x0400455E RID: 17758
		Custom,
		// Token: 0x0400455F RID: 17759
		ECameraShakeDurationType_MAX
	}
}
