using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002ADF RID: 10975
	[NullableContext(1)]
	[Nullable(0)]
	public struct PoolArrayEnumerator<[Nullable(2)] T> : IEnumerator<!0>, IEnumerator, IDisposable
	{
		// Token: 0x060283DD RID: 164829 RVA: 0x003D3479 File Offset: 0x003D1679
		public PoolArrayEnumerator(T[] array, int length)
		{
			this.<array>P = array;
			this.<length>P = length;
			this.current = default(T);
			this.index = 0;
		}

		// Token: 0x060283DE RID: 164830 RVA: 0x003D349C File Offset: 0x003D169C
		public bool MoveNext()
		{
			if (this.index < this.<length>P)
			{
				T[] array = this.<array>P;
				int num = this.index;
				this.index = num + 1;
				this.current = array[num];
				return true;
			}
			return false;
		}

		// Token: 0x060283DF RID: 164831 RVA: 0x003D34DC File Offset: 0x003D16DC
		public void Reset()
		{
			this.index = 0;
		}

		// Token: 0x17009998 RID: 39320
		// (get) Token: 0x060283E0 RID: 164832 RVA: 0x003D34E5 File Offset: 0x003D16E5
		T IEnumerator<!0>.Current
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x17009999 RID: 39321
		// (get) Token: 0x060283E1 RID: 164833 RVA: 0x003D34ED File Offset: 0x003D16ED
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.current;
			}
		}

		// Token: 0x060283E2 RID: 164834 RVA: 0x003D34FA File Offset: 0x003D16FA
		public void Dispose()
		{
		}

		// Token: 0x04016282 RID: 90754
		[CompilerGenerated]
		private T[] <array>P;

		// Token: 0x04016283 RID: 90755
		[CompilerGenerated]
		private int <length>P;

		// Token: 0x04016284 RID: 90756
		private int index;

		// Token: 0x04016285 RID: 90757
		private T current;
	}
}
