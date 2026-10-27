using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000711 RID: 1809
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAppReturnType")]
	public enum EAppReturnType
	{
		// Token: 0x04002DB8 RID: 11704
		No,
		// Token: 0x04002DB9 RID: 11705
		Yes,
		// Token: 0x04002DBA RID: 11706
		YesAll,
		// Token: 0x04002DBB RID: 11707
		NoAll,
		// Token: 0x04002DBC RID: 11708
		Cancel,
		// Token: 0x04002DBD RID: 11709
		Ok,
		// Token: 0x04002DBE RID: 11710
		Retry,
		// Token: 0x04002DBF RID: 11711
		Continue,
		// Token: 0x04002DC0 RID: 11712
		EAppReturnType_MAX
	}
}
