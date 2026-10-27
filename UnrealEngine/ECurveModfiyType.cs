using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016B0 RID: 5808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBatchModfiyAnimCurves.ECurveModfiyType")]
	public enum ECurveModfiyType : byte
	{
		// Token: 0x0400B774 RID: 46964
		MODFIY_OR_ADD,
		// Token: 0x0400B775 RID: 46965
		DELETE,
		// Token: 0x0400B776 RID: 46966
		ECurveModfiyType_MAX
	}
}
