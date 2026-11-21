using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000089 RID: 137
	public class Unusable
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00013E95 File Offset: 0x00012095
		public static void DoNothing()
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00013E98 File Offset: 0x00012098
		[NullableContext(1)]
		public static void DoNothingButError(string msg)
		{
			StringBuilder stringBuilder = new StringBuilder().Append("Unusable.DoNothingButError() called.");
			stringBuilder.AppendLine();
			stringBuilder.Append("Msg=").Append(msg);
			stringBuilder.AppendLine();
			stringBuilder.Append("C# StackTrace=").Append(new StackTrace(1, true));
			UnrealLogger.Error(stringBuilder.ToString());
		}
	}
}
