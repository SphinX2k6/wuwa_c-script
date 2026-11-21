using System;

namespace UnrealEngine
{
	// Token: 0x0200003E RID: 62
	public sealed class BoolArrayProcessor : PodBaseArrayProcessor<bool>
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x0000D57A File Offset: 0x0000B77A
		public BoolArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = 1;
			this.MinAlignment = 1;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000D598 File Offset: 0x0000B798
		public override int FindIndex(IntPtr Data, int Num, bool Value)
		{
			for (int i = 0; i < Num; i++)
			{
				if (this.Get(Data, i) == Value)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
