using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278B RID: 10123
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EDitherType")]
	public enum EDitherType : byte
	{
		// Token: 0x040149CF RID: 84431
		NoDither,
		// Token: 0x040149D0 RID: 84432
		FloydSteinberg,
		// Token: 0x040149D1 RID: 84433
		JarvisJudiceNinke,
		// Token: 0x040149D2 RID: 84434
		Sierra,
		// Token: 0x040149D3 RID: 84435
		EDitherType_MAX
	}
}
