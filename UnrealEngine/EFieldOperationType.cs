using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045F RID: 1119
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EFieldOperationType")]
	public enum EFieldOperationType
	{
		// Token: 0x04001BE3 RID: 7139
		Field_Multiply,
		// Token: 0x04001BE4 RID: 7140
		Field_Divide,
		// Token: 0x04001BE5 RID: 7141
		Field_Add,
		// Token: 0x04001BE6 RID: 7142
		Field_Substract,
		// Token: 0x04001BE7 RID: 7143
		Field_Operation_Max
	}
}
