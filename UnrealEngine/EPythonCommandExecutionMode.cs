using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007BA RID: 1978
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PythonScriptPlugin.EPythonCommandExecutionMode")]
	public enum EPythonCommandExecutionMode : byte
	{
		// Token: 0x040049BF RID: 18879
		ExecuteFile,
		// Token: 0x040049C0 RID: 18880
		ExecuteStatement,
		// Token: 0x040049C1 RID: 18881
		EvaluateStatement,
		// Token: 0x040049C2 RID: 18882
		EPythonCommandExecutionMode_MAX
	}
}
