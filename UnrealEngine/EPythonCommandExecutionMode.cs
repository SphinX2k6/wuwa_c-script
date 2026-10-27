using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002678 RID: 9848
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PythonScriptPlugin.EPythonCommandExecutionMode")]
	public enum EPythonCommandExecutionMode : byte
	{
		// Token: 0x04013A91 RID: 80529
		ExecuteFile,
		// Token: 0x04013A92 RID: 80530
		ExecuteStatement,
		// Token: 0x04013A93 RID: 80531
		EvaluateStatement,
		// Token: 0x04013A94 RID: 80532
		EPythonCommandExecutionMode_MAX
	}
}
