using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x0200088E RID: 2190
	[NullableContext(1)]
	[Nullable(0)]
	public struct PoolArrayEnumerator<[Nullable(2)] T> : IEnumerator<!0>, IEnumerator, IDisposable
	{
		// Token: 0x0600BD90 RID: 48528 RVA: 0x0012E769 File Offset: 0x0012C969
		public PoolArrayEnumerator(T[] array, int length)
		{
			this.<array>P = array;
			this.<length>P = length;
			this.current = default(T);
			this.index = 0;
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x0012E78C File Offset: 0x0012C98C
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

		// Token: 0x0600BD92 RID: 48530 RVA: 0x0012E7CC File Offset: 0x0012C9CC
		public void Reset()
		{
			this.index = 0;
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600BD93 RID: 48531 RVA: 0x0012E7D5 File Offset: 0x0012C9D5
		public T Current
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x0600BD94 RID: 48532 RVA: 0x0012E7DD File Offset: 0x0012C9DD
		T IEnumerator<!0>.Current
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x0012E7E5 File Offset: 0x0012C9E5
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.current;
			}
		}

		// Token: 0x0600BD96 RID: 48534 RVA: 0x0012E7F2 File Offset: 0x0012C9F2
		public void Dispose()
		{
		}

		// Token: 0x04005699 RID: 22169
		[CompilerGenerated]
		private T[] <array>P;

		// Token: 0x0400569A RID: 22170
		[CompilerGenerated]
		private int <length>P;

		// Token: 0x0400569B RID: 22171
		private int index;

		// Token: 0x0400569C RID: 22172
		private T current;
	}
}
