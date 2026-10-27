using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA1 RID: 2721
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELevelInstanceType")]
	public enum ELevelInstanceType : byte
	{
		// Token: 0x0400491F RID: 18719
		None,
		// Token: 0x04004920 RID: 18720
		LevelInstance,
		// Token: 0x04004921 RID: 18721
		LevelInstanceEdit,
		// Token: 0x04004922 RID: 18722
		LevelInstancePropertyOverride,
		// Token: 0x04004923 RID: 18723
		ELevelInstanceType_MAX
	}
}
