using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001478 RID: 5240
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineEditor.EHoudiniPublicAPICurveType")]
	public enum EHoudiniPublicAPICurveType : byte
	{
		// Token: 0x0400A3EC RID: 41964
		Invalid,
		// Token: 0x0400A3ED RID: 41965
		Polygon,
		// Token: 0x0400A3EE RID: 41966
		Nurbs,
		// Token: 0x0400A3EF RID: 41967
		Bezier,
		// Token: 0x0400A3F0 RID: 41968
		Points,
		// Token: 0x0400A3F1 RID: 41969
		EHoudiniPublicAPICurveType_MAX
	}
}
