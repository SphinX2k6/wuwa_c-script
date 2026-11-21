using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200003C RID: 60
	public sealed class EnumArrayProcessor<[IsUnmanaged] T> : PodBaseArrayProcessor<T> where T : struct, ValueType, Enum
	{
		// Token: 0x0600086F RID: 2159 RVA: 0x0000D504 File Offset: 0x0000B704
		public EnumArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = sizeof(T);
			this.MinAlignment = sizeof(T);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000D52C File Offset: 0x0000B72C
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			for (int i = 0; i < Num; i++)
			{
				if (EqualityComparer<T>.Default.Equals(this.Get(Data, i), Value))
				{
					return i;
				}
			}
			return -1;
		}
	}
}
