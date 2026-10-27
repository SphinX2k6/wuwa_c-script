using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A1 RID: 673
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AlembicLibrary.EAbcGeometryCacheMotionVectorsImport")]
	public enum EAbcGeometryCacheMotionVectorsImport : byte
	{
		// Token: 0x04000E35 RID: 3637
		NoMotionVectors,
		// Token: 0x04000E36 RID: 3638
		ImportAbcVelocitiesAsMotionVectors,
		// Token: 0x04000E37 RID: 3639
		CalculateMotionVectorsDuringImport,
		// Token: 0x04000E38 RID: 3640
		EAbcGeometryCacheMotionVectorsImport_MAX
	}
}
