using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F4F RID: 8015
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeMirrorOperation")]
	public enum ELandscapeMirrorOperation : byte
	{
		// Token: 0x0401071B RID: 67355
		MinusXToPlusX,
		// Token: 0x0401071C RID: 67356
		PlusXToMinusX,
		// Token: 0x0401071D RID: 67357
		MinusYToPlusY,
		// Token: 0x0401071E RID: 67358
		PlusYToMinusY,
		// Token: 0x0401071F RID: 67359
		RotateMinusXToPlusX,
		// Token: 0x04010720 RID: 67360
		RotatePlusXToMinusX,
		// Token: 0x04010721 RID: 67361
		RotateMinusYToPlusY,
		// Token: 0x04010722 RID: 67362
		RotatePlusYToMinusY,
		// Token: 0x04010723 RID: 67363
		ELandscapeMirrorOperation_MAX
	}
}
