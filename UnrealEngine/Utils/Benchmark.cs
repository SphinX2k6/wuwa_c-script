using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AF1 RID: 10993
	[NullableContext(1)]
	[Nullable(0)]
	public class Benchmark : IDisposable
	{
		// Token: 0x06028478 RID: 164984 RVA: 0x003D47F6 File Offset: 0x003D29F6
		public Benchmark(string InName)
		{
			this.Name = InName;
			this.Stopwatch = Stopwatch.StartNew();
		}

		// Token: 0x06028479 RID: 164985 RVA: 0x003D4810 File Offset: 0x003D2A10
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

		// Token: 0x040162A0 RID: 90784
		private readonly string Name;

		// Token: 0x040162A1 RID: 90785
		private readonly Stopwatch Stopwatch;
	}
}
