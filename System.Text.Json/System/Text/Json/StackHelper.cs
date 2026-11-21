using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x0200003E RID: 62
	internal static class StackHelper
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00014AE5 File Offset: 0x00012CE5
		public static bool TryEnsureSufficientExecutionStack()
		{
			return RuntimeHelpers.TryEnsureSufficientExecutionStack();
		}
	}
}
