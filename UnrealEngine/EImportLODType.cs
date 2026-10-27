using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028A2 RID: 10402
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SpeedTreeImporter.EImportLODType")]
	public enum EImportLODType
	{
		// Token: 0x0401531B RID: 86811
		ILT_PaintedFoliage,
		// Token: 0x0401531C RID: 86812
		ILT_IndividualActors,
		// Token: 0x0401531D RID: 86813
		ILT_MAX
	}
}
