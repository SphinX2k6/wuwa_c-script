using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000789 RID: 1929
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EditorScriptingUtilities.EScriptingCollisionShapeType")]
	public enum EScriptingCollisionShapeType : byte
	{
		// Token: 0x040030A5 RID: 12453
		Box,
		// Token: 0x040030A6 RID: 12454
		Sphere,
		// Token: 0x040030A7 RID: 12455
		Capsule,
		// Token: 0x040030A8 RID: 12456
		NDOP10_X,
		// Token: 0x040030A9 RID: 12457
		NDOP10_Y,
		// Token: 0x040030AA RID: 12458
		NDOP10_Z,
		// Token: 0x040030AB RID: 12459
		NDOP18,
		// Token: 0x040030AC RID: 12460
		NDOP26,
		// Token: 0x040030AD RID: 12461
		EScriptingCollisionShapeType_MAX
	}
}
