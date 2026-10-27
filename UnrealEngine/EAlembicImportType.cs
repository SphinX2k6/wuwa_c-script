using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A2 RID: 674
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AlembicLibrary.EAlembicImportType")]
	public enum EAlembicImportType : byte
	{
		// Token: 0x04000E3A RID: 3642
		StaticMesh,
		// Token: 0x04000E3B RID: 3643
		GeometryCache,
		// Token: 0x04000E3C RID: 3644
		Skeletal,
		// Token: 0x04000E3D RID: 3645
		EAlembicImportType_MAX
	}
}
