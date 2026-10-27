using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A31 RID: 2609
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EComponentType")]
	public enum EComponentType
	{
		// Token: 0x040045D1 RID: 17873
		None,
		// Token: 0x040045D2 RID: 17874
		TranslationX,
		// Token: 0x040045D3 RID: 17875
		TranslationY,
		// Token: 0x040045D4 RID: 17876
		TranslationZ,
		// Token: 0x040045D5 RID: 17877
		RotationX,
		// Token: 0x040045D6 RID: 17878
		RotationY,
		// Token: 0x040045D7 RID: 17879
		RotationZ,
		// Token: 0x040045D8 RID: 17880
		Scale,
		// Token: 0x040045D9 RID: 17881
		ScaleX,
		// Token: 0x040045DA RID: 17882
		ScaleY,
		// Token: 0x040045DB RID: 17883
		ScaleZ,
		// Token: 0x040045DC RID: 17884
		EComponentType_MAX
	}
}
