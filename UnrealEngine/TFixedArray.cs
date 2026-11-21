using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000057 RID: 87
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TFixedArray<[Nullable(2)] T> : UnrealProxyObject, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x06000989 RID: 2441 RVA: 0x0000F4B5 File Offset: 0x0000D6B5
		public TFixedArray(int InLength) : base(UnrealProxyObject.ENoInit.NoInit)
		{
			SharpherealAssert.Assert(InLength > 0);
			this._Length = InLength;
			this._NativePtr = this.AllocNativePtr();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		[NullableContext(2)]
		public TFixedArray(IntPtr NativePtr, int InLength, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			SharpherealAssert.Assert(InLength > 0);
			this._Length = InLength;
			if (base.IsNativePtrAllocated)
			{
				NativeArrayProcessorFactory.AddRef(TFixedArray<T>.Processor);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000F506 File Offset: 0x0000D706
		public TFixedArray(IntPtr NativePtr, int InLength, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(UnrealProxyObject.ENoInit.NoInit)
		{
			SharpherealAssert.Assert(InLength > 0);
			this._Length = InLength;
			this._NativePtr = this.AllocNativePtr();
			this.CopyAssign(NativePtr);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0000F534 File Offset: 0x0000D734
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TFixedArray<T>.Processor);
			IntPtr result = BuiltinUtils.Malloc((UIntPtr)((IntPtr)(TFixedArray<T>.Processor.Size * this._Length)), (uint)TFixedArray<T>.Processor.MinAlignment);
			TFixedArray<T>.Processor.ConstructValues(this._NativePtr, 0, this._Length);
			return result;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000F583 File Offset: 0x0000D783
		protected override void DeallocNativePtr()
		{
			TFixedArray<T>.Processor.DestructValues(this._NativePtr, 0, this._Length);
			BuiltinUtils.Free(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TFixedArray<T>.Processor);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0000F5B1 File Offset: 0x0000D7B1
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			if (FromNativePtr == 0)
			{
				this.Clear();
				return;
			}
			TFixedArray<T>.Processor.CopyTo(FromNativePtr, this._NativePtr, this._Length);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0000F5DA File Offset: 0x0000D7DA
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			this.CopyTo(DestPtr);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0000F5E3 File Offset: 0x0000D7E3
		public void CopyTo(IntPtr DestPtr)
		{
			TFixedArray<T>.Processor.CopyTo(this._NativePtr, DestPtr, this._Length);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		public void CopyTo(TFixedArray<T> Dest)
		{
			TFixedArray<T>.Processor.CopyTo(this._NativePtr, Dest.NativePtr, Math.Min(this._Length, Dest._Length));
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000F628 File Offset: 0x0000D828
		public void CopyAssign([Nullable(new byte[]
		{
			2,
			1
		})] TFixedArray<T> Src)
		{
			if (Src == null)
			{
				this.Clear();
				return;
			}
			if (Src._Length != this._Length)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Except length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this._Length);
				defaultInterpolatedStringHandler.AppendLiteral(", argument: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Src._Length);
				throw new RankException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			TFixedArray<T>.Processor.CopyTo(Src.NativePtr, this._NativePtr, Math.Min(this._Length, Src._Length));
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0000F6BD File Offset: 0x0000D8BD
		public int Count
		{
			get
			{
				return this._Length;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0000F6C5 File Offset: 0x0000D8C5
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AD RID: 173
		public T this[int Index]
		{
			get
			{
				this.CheckValidIndex(Index);
				return TFixedArray<T>.Processor.Get(this._NativePtr, Index);
			}
			set
			{
				this.CheckValidIndex(Index);
				TFixedArray<T>.Processor.Set(this._NativePtr, Index, value);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000F6FD File Offset: 0x0000D8FD
		[NullableContext(2)]
		public T Get(int Index)
		{
			this.CheckValidIndex(Index);
			return TFixedArray<T>.Processor.Get(this._NativePtr, Index);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000F717 File Offset: 0x0000D917
		public void Set(int Index, in T Value)
		{
			this.CheckValidIndex(Index);
			TFixedArray<T>.Processor.Set(this._NativePtr, Index, Value);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0000F737 File Offset: 0x0000D937
		[Obsolete("NotSupported")]
		public void Add(T Item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0000F73E File Offset: 0x0000D93E
		[Obsolete("NotSupported")]
		public void Insert(int Index, T Value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0000F745 File Offset: 0x0000D945
		[Obsolete("NotSupported")]
		public bool Remove(T Item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000F74C File Offset: 0x0000D94C
		[Obsolete("NotSupported")]
		public void RemoveAt(int Index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000F753 File Offset: 0x0000D953
		public bool Contains(T Value)
		{
			return TFixedArray<T>.Processor.FindIndex(this._NativePtr, this._Length, Value) != -1;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0000F772 File Offset: 0x0000D972
		public int FindIndex(in T Value)
		{
			return TFixedArray<T>.Processor.FindIndex(this._NativePtr, this._Length, Value);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0000F790 File Offset: 0x0000D990
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValidIndex(int Index)
		{
			return Index >= 0 && Index < this._Length;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0000F7A1 File Offset: 0x0000D9A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Num()
		{
			return this._Length;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0000F7A9 File Offset: 0x0000D9A9
		public void Clear()
		{
			TFixedArray<T>.Processor.DestructValues(this._NativePtr, 0, this._Length);
			TFixedArray<T>.Processor.ConstructValues(this._NativePtr, 0, this._Length);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0000F7D9 File Offset: 0x0000D9D9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Empty()
		{
			this.Clear();
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000F7E1 File Offset: 0x0000D9E1
		public int IndexOf(T Item)
		{
			return this.FindIndex(Item);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CheckValidIndex(int Index)
		{
			if (!this.IsValidIndex(Index))
			{
				string paramName = "Index";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Argument out of range. Index: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Index);
				defaultInterpolatedStringHandler.AppendLiteral(", Length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this._Length);
				throw new ArgumentOutOfRangeException(paramName, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000F84C File Offset: 0x0000DA4C
		public void CopyTo(T[] Array, int ArrayIndex)
		{
			int num = 0;
			while (num < Array.Length && num < this._Length)
			{
				Array[ArrayIndex + num] = this[num];
				num++;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0000F880 File Offset: 0x0000DA80
		[NullableContext(0)]
		public TFixedArray<T>.Enumerator GetEnumerator()
		{
			return new TFixedArray<T>.Enumerator(this);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0000F888 File Offset: 0x0000DA88
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new TFixedArray<T>.Enumerator(this);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0000F895 File Offset: 0x0000DA95
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TFixedArray<T>.Enumerator(this);
		}

		// Token: 0x04000140 RID: 320
		internal static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.Processor;

		// Token: 0x04000141 RID: 321
		private int _Length;

		// Token: 0x020008CE RID: 2254
		[Nullable(0)]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x0600BEAF RID: 48815 RVA: 0x00130754 File Offset: 0x0012E954
			public Enumerator(TFixedArray<T> Array)
			{
				this.<Array>P = Array;
				this._Current = default(T);
				this._Index = 0;
			}

			// Token: 0x0600BEB0 RID: 48816 RVA: 0x00130770 File Offset: 0x0012E970
			public bool MoveNext()
			{
				if (this._Index < this.<Array>P.Num())
				{
					TFixedArray<T> tfixedArray = this.<Array>P;
					int index = this._Index;
					this._Index = index + 1;
					this._Current = tfixedArray[index];
					return true;
				}
				return false;
			}

			// Token: 0x0600BEB1 RID: 48817 RVA: 0x001307B5 File Offset: 0x0012E9B5
			public void Reset()
			{
				this._Index = 0;
			}

			// Token: 0x17002336 RID: 9014
			// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x001307BE File Offset: 0x0012E9BE
			public T Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002337 RID: 9015
			// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x001307C6 File Offset: 0x0012E9C6
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002338 RID: 9016
			// (get) Token: 0x0600BEB4 RID: 48820 RVA: 0x001307CE File Offset: 0x0012E9CE
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x0600BEB5 RID: 48821 RVA: 0x001307DB File Offset: 0x0012E9DB
			public void Dispose()
			{
			}

			// Token: 0x04005781 RID: 22401
			[CompilerGenerated]
			private TFixedArray<T> <Array>P;

			// Token: 0x04005782 RID: 22402
			private int _Index;

			// Token: 0x04005783 RID: 22403
			private T _Current;
		}
	}
}
