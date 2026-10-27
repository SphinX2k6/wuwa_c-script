using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A7 RID: 10151
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ETangentCalculatorType")]
	public enum ETangentCalculatorType : byte
	{
		// Token: 0x04014A6C RID: 84588
		OrthonormalRightHanded,
		// Token: 0x04014A6D RID: 84589
		Autodesk3dsMax,
		// Token: 0x04014A6E RID: 84590
		OrthonormalLeftHanded,
		// Token: 0x04014A6F RID: 84591
		MikkTSpace,
		// Token: 0x04014A70 RID: 84592
		ImplicitOrthonormalRightHandedCompatible,
		// Token: 0x04014A71 RID: 84593
		ETangentCalculatorType_MAX
	}
}
