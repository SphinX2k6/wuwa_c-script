using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026AB RID: 9899
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EProxyTaskDataMark")]
	public enum EProxyTaskDataMark : byte
	{
		// Token: 0x04013CA2 RID: 81058
		Task_None,
		// Token: 0x04013CA3 RID: 81059
		Task_Ignored,
		// Token: 0x04013CA4 RID: 81060
		Task_Reimported,
		// Token: 0x04013CA5 RID: 81061
		Task_NeedFetch,
		// Token: 0x04013CA6 RID: 81062
		Task_NeedReimport,
		// Token: 0x04013CA7 RID: 81063
		Task_WaitForFinish,
		// Token: 0x04013CA8 RID: 81064
		Task_TaskNotSucc,
		// Token: 0x04013CA9 RID: 81065
		Task_UploadNotSucc,
		// Token: 0x04013CAA RID: 81066
		Count,
		// Token: 0x04013CAB RID: 81067
		EProxyTaskDataMark_MAX
	}
}
