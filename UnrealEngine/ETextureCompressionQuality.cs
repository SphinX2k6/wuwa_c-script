using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B88 RID: 2952
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureCompressionQuality")]
	public enum ETextureCompressionQuality
	{
		// Token: 0x04005133 RID: 20787
		TCQ_Default,
		// Token: 0x04005134 RID: 20788
		TCQ_Lowest,
		// Token: 0x04005135 RID: 20789
		TCQ_Low,
		// Token: 0x04005136 RID: 20790
		TCQ_Medium,
		// Token: 0x04005137 RID: 20791
		TCQ_High,
		// Token: 0x04005138 RID: 20792
		TCQ_Highest,
		// Token: 0x04005139 RID: 20793
		TCQ_MAX
	}
}
