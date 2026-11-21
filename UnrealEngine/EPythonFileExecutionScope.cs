using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007BB RID: 1979
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PythonScriptPlugin.EPythonFileExecutionScope")]
	public enum EPythonFileExecutionScope : byte
	{
		// Token: 0x040049C4 RID: 18884
		Private,
		// Token: 0x040049C5 RID: 18885
		Public,
		// Token: 0x040049C6 RID: 18886
		EPythonFileExecutionScope_MAX
	}
}
