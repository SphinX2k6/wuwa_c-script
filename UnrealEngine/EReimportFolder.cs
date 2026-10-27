using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026AC RID: 9900
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EReimportFolder")]
	public enum EReimportFolder : byte
	{
		// Token: 0x04013CAD RID: 81069
		DOWNLOAD_FOLDER,
		// Token: 0x04013CAE RID: 81070
		UPDATE_FOLDER,
		// Token: 0x04013CAF RID: 81071
		EReimportFolder_MAX
	}
}
