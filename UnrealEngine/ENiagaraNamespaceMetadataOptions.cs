using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024CC RID: 9420
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NiagaraEditor.ENiagaraNamespaceMetadataOptions")]
	public enum ENiagaraNamespaceMetadataOptions
	{
		// Token: 0x04012D28 RID: 77096
		HideInScript,
		// Token: 0x04012D29 RID: 77097
		HideInSystem,
		// Token: 0x04012D2A RID: 77098
		AdvancedInScript,
		// Token: 0x04012D2B RID: 77099
		AdvancedInSystem,
		// Token: 0x04012D2C RID: 77100
		PreventEditingNamespace,
		// Token: 0x04012D2D RID: 77101
		PreventEditingNamespaceModifier,
		// Token: 0x04012D2E RID: 77102
		PreventEditingName,
		// Token: 0x04012D2F RID: 77103
		PreventCreatingInSystemEditor,
		// Token: 0x04012D30 RID: 77104
		ENiagaraNamespaceMetadataOptions_MAX
	}
}
