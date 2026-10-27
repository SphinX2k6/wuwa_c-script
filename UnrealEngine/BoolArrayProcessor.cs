using System;

namespace UnrealEngine
{
	// Token: 0x02000059 RID: 89
	public sealed class BoolArrayProcessor : PodBaseArrayProcessor<bool>
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x00010D0E File Offset: 0x0000EF0E
		public BoolArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = 1;
			this.MinAlignment = 1;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00010D2C File Offset: 0x0000EF2C
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
