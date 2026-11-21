using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x020008A0 RID: 2208
	[NullableContext(1)]
	[Nullable(0)]
	public class Benchmark : IDisposable
	{
		// Token: 0x0600BE31 RID: 48689 RVA: 0x0012FB46 File Offset: 0x0012DD46
		public Benchmark(string InName)
		{
			this.Name = InName;
			this.Stopwatch = Stopwatch.StartNew();
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x0012FB60 File Offset: 0x0012DD60
		public void Dispose()
		{
			this.Stopwatch.Stop();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Benchmark ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Name);
			defaultInterpolatedStringHandler.AppendLiteral(" took ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Stopwatch.Elapsed.TotalMilliseconds);
			defaultInterpolatedStringHandler.AppendLiteral(" ms");
			UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x040056B7 RID: 22199
		private readonly string Name;

		// Token: 0x040056B8 RID: 22200
		private readonly Stopwatch Stopwatch;
	}
}
