using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002679 RID: 9849
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PythonScriptPlugin.EPythonFileExecutionScope")]
	public enum EPythonFileExecutionScope : byte
	{
		// Token: 0x04013A96 RID: 80534
		Private,
		// Token: 0x04013A97 RID: 80535
		Public,
		// Token: 0x04013A98 RID: 80536
		EPythonFileExecutionScope_MAX
	}
}
