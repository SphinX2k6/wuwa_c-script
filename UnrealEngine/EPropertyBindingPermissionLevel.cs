using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002933 RID: 10547
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMGEditor.EPropertyBindingPermissionLevel")]
	public enum EPropertyBindingPermissionLevel : byte
	{
		// Token: 0x0401570A RID: 87818
		Allow,
		// Token: 0x0401570B RID: 87819
		Prevent,
		// Token: 0x0401570C RID: 87820
		PreventAndWarn,
		// Token: 0x0401570D RID: 87821
		PreventAndError,
		// Token: 0x0401570E RID: 87822
		EPropertyBindingPermissionLevel_MAX
	}
}
