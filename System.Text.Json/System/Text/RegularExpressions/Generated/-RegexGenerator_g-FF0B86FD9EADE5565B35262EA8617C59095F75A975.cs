using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Text.RegularExpressions.Generator", "42.42.42.42")]
	[SkipLocalsInit]
	internal sealed class <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0 : Regex
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002ED6 File Offset: 0x000010D6
		private <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0()
		{
			this.pattern = "^\\s*(?:\\+|\\-)?[0-9]+\\s*$";
			this.roptions = RegexOptions.None;
			this.internalMatchTimeout = TimeSpan.FromMilliseconds(200L, 0L);
			this.factory = new <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0.RunnerFactory();
			this.capsize = 1;
		}

		// Token: 0x04000006 RID: 6
		internal static readonly <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0 Instance = new <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0();

		// Token: 0x02000008 RID: 8
		private sealed class RunnerFactory : RegexRunnerFactory
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x00002F21 File Offset: 0x00001121
			protected override RegexRunner CreateInstance()
			{
				return new <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0.RunnerFactory.Runner();
			}

			// Token: 0x02000009 RID: 9
			private sealed class Runner : RegexRunner
			{
				// Token: 0x060000EA RID: 234 RVA: 0x00002F30 File Offset: 0x00001130
				protected override void Scan(ReadOnlySpan<char> inputSpan)
				{
					if (this.TryFindNextPossibleStartingPosition(inputSpan) && !this.TryMatchAtCurrentPosition(inputSpan))
					{
						this.runtextpos = inputSpan.Length;
					}
				}

				// Token: 0x060000EB RID: 235 RVA: 0x00002F54 File Offset: 0x00001154
				private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
				{
					int runtextpos = this.runtextpos;
					if (runtextpos < inputSpan.Length && runtextpos == 0)
					{
						return true;
					}
					this.runtextpos = inputSpan.Length;
					return false;
				}

				// Token: 0x060000EC RID: 236 RVA: 0x00002F88 File Offset: 0x00001188
				private unsafe bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
				{
					int num = this.runtextpos;
					int start = num;
					ReadOnlySpan<char> span = inputSpan.Slice(num);
					if (num != 0)
					{
						return false;
					}
					int num2 = 0;
					while (num2 < span.Length && char.IsWhiteSpace((char)(*span[num2])))
					{
						num2++;
					}
					span = span.Slice(num2);
					num += num2;
					char c;
					if (!span.IsEmpty && ((c = (char)(*span[0])) == '+' | c == '-'))
					{
						span = span.Slice(1);
						num++;
					}
					int num3 = span.IndexOfAnyExceptInRange('0', '9');
					if (num3 < 0)
					{
						num3 = span.Length;
					}
					if (num3 == 0)
					{
						return false;
					}
					span = span.Slice(num3);
					num += num3;
					int num4 = num;
					int num5 = 0;
					while (num5 < span.Length && char.IsWhiteSpace((char)(*span[num5])))
					{
						num5++;
					}
					span = span.Slice(num5);
					num += num5;
					int num6 = num;
					while (num < inputSpan.Length - 1 || (num < inputSpan.Length && *inputSpan[num] != 10))
					{
						base.CheckTimeout();
						if (num4 >= num6)
						{
							return false;
						}
						num6 = (num = num6 - 1);
						span = inputSpan.Slice(num);
					}
					this.runtextpos = num;
					base.Capture(0, start, num);
					return true;
				}
			}
		}
	}
}
