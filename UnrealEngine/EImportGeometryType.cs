using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028A1 RID: 10401
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SpeedTreeImporter.EImportGeometryType")]
	public enum EImportGeometryType
	{
		// Token: 0x04015316 RID: 86806
		IGT_3D,
		// Token: 0x04015317 RID: 86807
		IGT_Billboards,
		// Token: 0x04015318 RID: 86808
		IGT_Both,
		// Token: 0x04015319 RID: 86809
		IGT_MAX
	}
}
