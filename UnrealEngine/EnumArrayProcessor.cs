using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000057 RID: 87
	public sealed class EnumArrayProcessor<[IsUnmanaged] T> : PodBaseArrayProcessor<T> where T : struct, ValueType, Enum
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00010C98 File Offset: 0x0000EE98
		public EnumArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = sizeof(T);
			this.MinAlignment = sizeof(T);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00010CC0 File Offset: 0x0000EEC0
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
