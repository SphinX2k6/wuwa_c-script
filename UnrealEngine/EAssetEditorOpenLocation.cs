using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200078A RID: 1930
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EditorStyle.EAssetEditorOpenLocation")]
	public enum EAssetEditorOpenLocation : byte
	{
		// Token: 0x040030AF RID: 12463
		Default,
		// Token: 0x040030B0 RID: 12464
		NewWindow,
		// Token: 0x040030B1 RID: 12465
		MainWindow,
		// Token: 0x040030B2 RID: 12466
		ContentBrowser,
		// Token: 0x040030B3 RID: 12467
		LastDockedWindowOrNewWindow,
		// Token: 0x040030B4 RID: 12468
		LastDockedWindowOrMainWindow,
		// Token: 0x040030B5 RID: 12469
		LastDockedWindowOrContentBrowser,
		// Token: 0x040030B6 RID: 12470
		EAssetEditorOpenLocation_MAX
	}
}
