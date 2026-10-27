using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200049E RID: 1182
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ColorCorrectRegions.EColorCorrectRegionsType")]
	public enum EColorCorrectRegionsType : byte
	{
		// Token: 0x04001E18 RID: 7704
		Sphere,
		// Token: 0x04001E19 RID: 7705
		Box,
		// Token: 0x04001E1A RID: 7706
		Cylinder,
		// Token: 0x04001E1B RID: 7707
		Cone,
		// Token: 0x04001E1C RID: 7708
		MAX
	}
}
