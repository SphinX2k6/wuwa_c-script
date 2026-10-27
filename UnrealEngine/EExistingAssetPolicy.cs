using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A4C RID: 10828
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDImporter.EExistingAssetPolicy")]
	public enum EExistingAssetPolicy : byte
	{
		// Token: 0x04015F01 RID: 89857
		Reimport,
		// Token: 0x04015F02 RID: 89858
		Ignore,
		// Token: 0x04015F03 RID: 89859
		EExistingAssetPolicy_MAX
	}
}
