using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A65 RID: 10853
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WindowsDeviceProfileSelector.EDataCompareType")]
	public enum EDataCompareType
	{
		// Token: 0x04015F90 RID: 90000
		WDCT_Equal,
		// Token: 0x04015F91 RID: 90001
		WDCT_Less,
		// Token: 0x04015F92 RID: 90002
		WDCT_LessEqual,
		// Token: 0x04015F93 RID: 90003
		WDCT_Greater,
		// Token: 0x04015F94 RID: 90004
		WDCT_GreaterEqual,
		// Token: 0x04015F95 RID: 90005
		WDCT_NotEqual,
		// Token: 0x04015F96 RID: 90006
		WDCT_Regex,
		// Token: 0x04015F97 RID: 90007
		WDCT_EqualIgnore,
		// Token: 0x04015F98 RID: 90008
		WDCT_LessIgnore,
		// Token: 0x04015F99 RID: 90009
		WDCT_LessEqualIgnore,
		// Token: 0x04015F9A RID: 90010
		WDCT_GreaterIgnore,
		// Token: 0x04015F9B RID: 90011
		WDCT_GreaterEqualIgnore,
		// Token: 0x04015F9C RID: 90012
		WDCT_NotEqualIgnore,
		// Token: 0x04015F9D RID: 90013
		WDCT_Hash,
		// Token: 0x04015F9E RID: 90014
		WDCT_MAX
	}
}
