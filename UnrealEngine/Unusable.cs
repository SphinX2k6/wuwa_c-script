using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A4 RID: 164
	public class Unusable
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x00019171 File Offset: 0x00017371
		public static void DoNothing()
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00019174 File Offset: 0x00017374
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
