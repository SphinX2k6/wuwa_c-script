using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE0 RID: 10976
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct PoolArray<[Nullable(2)] T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IDisposable
	{
		// Token: 0x060283E3 RID: 164835 RVA: 0x003D34FC File Offset: 0x003D16FC
		public PoolArray()
		{
			this._length = 0;
			this._array = Array.Empty<T>();
		}

		// Token: 0x060283E4 RID: 164836 RVA: 0x003D3510 File Offset: 0x003D1710
		public PoolArray(int inLength, bool clear)
		{
			this._length = inLength;
			this._array = ArrayPool<T>.Shared.Rent(inLength);
			if (clear)
			{
				Array.Clear(this._array, 0, this._length);
			}
		}

		// Token: 0x060283E5 RID: 164837 RVA: 0x003D353F File Offset: 0x003D173F
		internal PoolArray(T[] inSharedArray, int inLength)
		{
			this._length = inLength;
			this._array = inSharedArray;
		}

		// Token: 0x060283E6 RID: 164838 RVA: 0x003D354F File Offset: 0x003D174F
		public void Dispose()
		{
			if (this._array.Length != 0)
			{
				ArrayPool<T>.Shared.Return(this._array, RuntimeHelpers.IsReferenceOrContainsReferences<T>());
			}
		}

		// Token: 0x060283E7 RID: 164839 RVA: 0x003D356F File Offset: 0x003D176F
		public IEnumerator<T> GetEnumerator()
		{
			return new PoolArrayEnumerator<T>(this._array, this._length);
		}

		// Token: 0x060283E8 RID: 164840 RVA: 0x003D3587 File Offset: 0x003D1787
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060283E9 RID: 164841 RVA: 0x003D358F File Offset: 0x003D178F
		public void Add(T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060283EA RID: 164842 RVA: 0x003D3596 File Offset: 0x003D1796
		public bool Remove(T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060283EB RID: 164843 RVA: 0x003D359D File Offset: 0x003D179D
		public void Insert(int index, T item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060283EC RID: 164844 RVA: 0x003D35A4 File Offset: 0x003D17A4
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060283ED RID: 164845 RVA: 0x003D35AB File Offset: 0x003D17AB
		public void Clear()
		{
			Array.Clear(this._array, 0, this._length);
		}

		// Token: 0x060283EE RID: 164846 RVA: 0x003D35BF File Offset: 0x003D17BF
		public bool Contains(T item)
		{
			return Array.IndexOf<T>(this._array, item, 0, this._length) != -1;
		}

		// Token: 0x060283EF RID: 164847 RVA: 0x003D35DC File Offset: 0x003D17DC
		public void CopyTo(T[] array, int arrayIndex)
		{
			this._array.AsSpan(0, this._length).CopyTo(array.AsSpan(arrayIndex));
		}

		// Token: 0x1700999A RID: 39322
		// (get) Token: 0x060283F0 RID: 164848 RVA: 0x003D360A File Offset: 0x003D180A
		public int Count
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700999B RID: 39323
		// (get) Token: 0x060283F1 RID: 164849 RVA: 0x003D3612 File Offset: 0x003D1812
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060283F2 RID: 164850 RVA: 0x003D3615 File Offset: 0x003D1815
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._array, item, 0, this._length);
		}

		// Token: 0x1700999C RID: 39324
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

		// Token: 0x060283F5 RID: 164853 RVA: 0x003D3665 File Offset: 0x003D1865
		public ref T Ref(int index)
		{
			if (index >= this._length)
			{
				throw new IndexOutOfRangeException();
			}
			return ref this._array[index];
		}

		// Token: 0x060283F6 RID: 164854 RVA: 0x003D3682 File Offset: 0x003D1882
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> AsSpan()
		{
			return this._array.AsSpan(0, this._length);
		}

		// Token: 0x060283F7 RID: 164855 RVA: 0x003D3696 File Offset: 0x003D1896
		public T[] UnsafeAsArray()
		{
			return this._array;
		}

		// Token: 0x04016286 RID: 90758
		private readonly int _length;

		// Token: 0x04016287 RID: 90759
		private readonly T[] _array;
	}
}
