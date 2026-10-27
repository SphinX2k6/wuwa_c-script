using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200043F RID: 1087
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosNiagara.EDataSourceTypeEnum")]
	public enum EDataSourceTypeEnum : byte
	{
		// Token: 0x04001ADA RID: 6874
		ChaosNiagara_DataSourceType_Collision,
		// Token: 0x04001ADB RID: 6875
		ChaosNiagara_DataSourceType_Breaking,
		// Token: 0x04001ADC RID: 6876
		ChaosNiagara_DataSourceType_Trailing,
		// Token: 0x04001ADD RID: 6877
		ChaosNiagara_Max,
		// Token: 0x04001ADE RID: 6878
		ChaosNiagara_MAX
	}
}
