using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B1E RID: 2846
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPostCopyOperation")]
	public enum EPostCopyOperation : byte
	{
		// Token: 0x04004DEB RID: 19947
		None,
		// Token: 0x04004DEC RID: 19948
		LogicalNegateBool,
		// Token: 0x04004DED RID: 19949
		EPostCopyOperation_MAX
	}
}
