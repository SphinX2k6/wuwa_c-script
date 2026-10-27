using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200267A RID: 9850
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PythonScriptPlugin.EPythonLogOutputType")]
	public enum EPythonLogOutputType : byte
	{
		// Token: 0x04013A9A RID: 80538
		Info,
		// Token: 0x04013A9B RID: 80539
		Warning,
		// Token: 0x04013A9C RID: 80540
		Error,
		// Token: 0x04013A9D RID: 80541
		EPythonLogOutputType_MAX
	}
}
