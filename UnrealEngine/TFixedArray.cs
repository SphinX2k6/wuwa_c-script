using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000072 RID: 114
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TFixedArray<[Nullable(2)] T> : UnrealProxyObject, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000DF9 RID: 3577 RVA: 0x000147BD File Offset: 0x000129BD
		public TFixedArray(int InLength) : base(UnrealProxyObject.ENoInit.NoInit)
		{
			SharpherealAssert.Assert(InLength > 0);
			this._Length = InLength;
			this._NativePtr = this.AllocNativePtr();
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000147E2 File Offset: 0x000129E2
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

		// Token: 0x06000DFB RID: 3579 RVA: 0x0001480E File Offset: 0x00012A0E
		public TFixedArray(IntPtr NativePtr, int InLength, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(UnrealProxyObject.ENoInit.NoInit)
		{
			SharpherealAssert.Assert(InLength > 0);
			this._Length = InLength;
			this._NativePtr = this.AllocNativePtr();
			this.CopyAssign(NativePtr);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0001483C File Offset: 0x00012A3C
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TFixedArray<T>.Processor);
			IntPtr result = BuiltinUtils.Malloc((UIntPtr)((IntPtr)(TFixedArray<T>.Processor.Size * this._Length)), (uint)TFixedArray<T>.Processor.MinAlignment);
			TFixedArray<T>.Processor.ConstructValues(this._NativePtr, 0, this._Length);
			return result;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0001488B File Offset: 0x00012A8B
		protected override void DeallocNativePtr()
		{
			TFixedArray<T>.Processor.DestructValues(this._NativePtr, 0, this._Length);
			BuiltinUtils.Free(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TFixedArray<T>.Processor);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000148B9 File Offset: 0x00012AB9
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000148BC File Offset: 0x00012ABC
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000148BF File Offset: 0x00012ABF
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			if (FromNativePtr == 0)
			{
				this.Clear();
				return;
			}
			TFixedArray<T>.Processor.CopyTo(FromNativePtr, this._NativePtr, this._Length);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000148E2 File Offset: 0x00012AE2
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			this.CopyTo(DestPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000148EB File Offset: 0x00012AEB
		public void CopyTo(IntPtr DestPtr)
		{
			TFixedArray<T>.Processor.CopyTo(this._NativePtr, DestPtr, this._Length);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00014904 File Offset: 0x00012B04
		public void CopyTo(TFixedArray<T> Dest)
		{
			TFixedArray<T>.Processor.CopyTo(this._NativePtr, Dest.NativePtr, Math.Min(this._Length, Dest._Length));
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00014930 File Offset: 0x00012B30
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

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x000149C5 File Offset: 0x00012BC5
		public int Count
		{
			get
			{
				return this._Length;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000149CD File Offset: 0x00012BCD
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004A5 RID: 1189
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

		// Token: 0x06000E09 RID: 3593 RVA: 0x00014A05 File Offset: 0x00012C05
		[NullableContext(2)]
		public T Get(int Index)
		{
			this.CheckValidIndex(Index);
			return TFixedArray<T>.Processor.Get(this._NativePtr, Index);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00014A1F File Offset: 0x00012C1F
		public void Set(int Index, in T Value)
		{
			this.CheckValidIndex(Index);
			TFixedArray<T>.Processor.Set(this._NativePtr, Index, Value);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00014A3F File Offset: 0x00012C3F
		[Obsolete("NotSupported")]
		public void Add(T Item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00014A46 File Offset: 0x00012C46
		[Obsolete("NotSupported")]
		public void Insert(int Index, T Value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00014A4D File Offset: 0x00012C4D
		[Obsolete("NotSupported")]
		public bool Remove(T Item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00014A54 File Offset: 0x00012C54
		[Obsolete("NotSupported")]
		public void RemoveAt(int Index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00014A5B File Offset: 0x00012C5B
		public bool Contains(T Value)
		{
			return TFixedArray<T>.Processor.FindIndex(this._NativePtr, this._Length, Value) != -1;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00014A7A File Offset: 0x00012C7A
		public int FindIndex(in T Value)
		{
			return TFixedArray<T>.Processor.FindIndex(this._NativePtr, this._Length, Value);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00014A98 File Offset: 0x00012C98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValidIndex(int Index)
		{
			return Index >= 0 && Index < this._Length;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00014AA9 File Offset: 0x00012CA9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Num()
		{
			return this._Length;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00014AB1 File Offset: 0x00012CB1
		public void Clear()
		{
			TFixedArray<T>.Processor.DestructValues(this._NativePtr, 0, this._Length);
			TFixedArray<T>.Processor.ConstructValues(this._NativePtr, 0, this._Length);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00014AE1 File Offset: 0x00012CE1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Empty()
		{
			this.Clear();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00014AE9 File Offset: 0x00012CE9
		public int IndexOf(T Item)
		{
			return this.FindIndex(Item);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00014AF4 File Offset: 0x00012CF4
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

		// Token: 0x06000E17 RID: 3607 RVA: 0x00014B54 File Offset: 0x00012D54
		public void CopyTo(T[] Array, int ArrayIndex)
		{
			int num = 0;
			while (num < Array.Length && num < this._Length)
			{
				Array[ArrayIndex + num] = this[num];
				num++;
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00014B88 File Offset: 0x00012D88
		public IEnumerator<T> GetEnumerator()
		{
			return new TFixedArray<T>.Enumerator(this);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00014B95 File Offset: 0x00012D95
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TFixedArray<T>.Enumerator(this);
		}

		// Token: 0x04000187 RID: 391
		internal static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.Processor;

		// Token: 0x04000188 RID: 392
		private int _Length;

		// Token: 0x02002B20 RID: 11040
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x060284F5 RID: 165109 RVA: 0x003D5400 File Offset: 0x003D3600
			public Enumerator(TFixedArray<T> Array)
			{
				this.<Array>P = Array;
				this._Current = default(T);
				this._Index = 0;
			}

			// Token: 0x060284F6 RID: 165110 RVA: 0x003D541C File Offset: 0x003D361C
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

			// Token: 0x060284F7 RID: 165111 RVA: 0x003D5461 File Offset: 0x003D3661
			public void Reset()
			{
				this._Index = 0;
			}

			// Token: 0x170099AC RID: 39340
			// (get) Token: 0x060284F8 RID: 165112 RVA: 0x003D546A File Offset: 0x003D366A
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x170099AD RID: 39341
			// (get) Token: 0x060284F9 RID: 165113 RVA: 0x003D5472 File Offset: 0x003D3672
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x060284FA RID: 165114 RVA: 0x003D547F File Offset: 0x003D367F
			public void Dispose()
			{
			}

			// Token: 0x0401636B RID: 90987
			[CompilerGenerated]
			private TFixedArray<T> <Array>P;

			// Token: 0x0401636C RID: 90988
			private int _Index;

			// Token: 0x0401636D RID: 90989
			private T _Current;
		}
	}
}
