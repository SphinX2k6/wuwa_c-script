using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x0200088F RID: 2191
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct PoolArray<[Nullable(2)] T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IDisposable
	{
		// Token: 0x0600BD97 RID: 48535 RVA: 0x0012E7F4 File Offset: 0x0012C9F4
		public PoolArray()
		{
			this._length = 0;
			this._array = Array.Empty<T>();
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x0012E808 File Offset: 0x0012CA08
		public PoolArray(int inLength, bool clear)
		{
			this._length = inLength;
			this._array = ArrayPool<T>.Shared.Rent(inLength);
			if (clear)
			{
				Array.Clear(this._array, 0, this._length);
			}
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x0012E837 File Offset: 0x0012CA37
		internal PoolArray(T[] inSharedArray, int inLength)
		{
			this._length = inLength;
			this._array = inSharedArray;
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x0012E847 File Offset: 0x0012CA47
		public void Dispose()
		{
			if (this._array.Length != 0)
			{
				ArrayPool<T>.Shared.Return(this._array, RuntimeHelpers.IsReferenceOrContainsReferences<T>());
			}
		}

		// Token: 0x0600BD9B RID: 48539 RVA: 0x0012E867 File Offset: 0x0012CA67
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public PoolArrayEnumerator<T> GetEnumerator()
		{
			return new PoolArrayEnumerator<T>(this._array, this._length);
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x0012E87A File Offset: 0x0012CA7A
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new PoolArrayEnumerator<T>(this._array, this._length);
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x0012E892 File Offset: 0x0012CA92
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x0012E89F File Offset: 0x0012CA9F
		public void Add(T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x0012E8A6 File Offset: 0x0012CAA6
		public bool Remove(T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x0012E8AD File Offset: 0x0012CAAD
		public void Insert(int index, T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x0012E8B4 File Offset: 0x0012CAB4
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x0012E8BB File Offset: 0x0012CABB
		public void Clear()
		{
			Array.Clear(this._array, 0, this._length);
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x0012E8CF File Offset: 0x0012CACF
		public bool Contains(T item)
		{
			return Array.IndexOf<T>(this._array, item, 0, this._length) != -1;
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x0012E8EC File Offset: 0x0012CAEC
		public void CopyTo(T[] array, int arrayIndex)
		{
			this._array.AsSpan(0, this._length).CopyTo(array.AsSpan(arrayIndex));
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x0012E91A File Offset: 0x0012CB1A
		public int Count
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x0012E922 File Offset: 0x0012CB22
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x0012E925 File Offset: 0x0012CB25
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._array, item, 0, this._length);
		}

		// Token: 0x17002325 RID: 8997
		public T this[int index]
		{
			get
			{
				if (index >= this._length)
				{
					throw new IndexOutOfRangeException();
				}
				return this._array[index];
			}
			set
			{
				if (index >= this._length)
				{
					throw new IndexOutOfRangeException();
				}
				this._array[index] = value;
			}
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x0012E975 File Offset: 0x0012CB75
		public ref T Ref(int index)
		{
			if (index >= this._length)
			{
				throw new IndexOutOfRangeException();
			}
			return ref this._array[index];
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x0012E992 File Offset: 0x0012CB92
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> AsSpan()
		{
			return this._array.AsSpan(0, this._length);
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x0012E9A6 File Offset: 0x0012CBA6
		public T[] UnsafeAsArray()
		{
			return this._array;
		}

		// Token: 0x0400569D RID: 22173
		private readonly int _length;

		// Token: 0x0400569E RID: 22174
		private readonly T[] _array;
	}
}
