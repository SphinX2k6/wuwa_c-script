using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000070 RID: 112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Array, PropertiesSize = 16)]
	public sealed class TArray<[Nullable(2)] T> : UnrealProxyObject, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00013E35 File Offset: 0x00012035
		[Nullable(0)]
		public unsafe FScriptArray* ScriptArray
		{
			[NullableContext(0)]
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00013E3D File Offset: 0x0001203D
		public TArray()
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00013E45 File Offset: 0x00012045
		[NullableContext(2)]
		public TArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			if (base.IsNativePtrAllocated)
			{
				NativeArrayProcessorFactory.AddRef(TArray<T>.Processor);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00013E61 File Offset: 0x00012061
		public TArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00013E6C File Offset: 0x0001206C
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TArray<T>.Processor);
			return FScriptArray.AllocNativeMemory();
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00013E7D File Offset: 0x0001207D
		protected override void DeallocNativePtr()
		{
			TArray<T>._Empty(this.ScriptArray, true);
			FScriptArray.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TArray<T>.Processor);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00013EA1 File Offset: 0x000120A1
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00013EA4 File Offset: 0x000120A4
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			TArray<T>._MoveTo(this.ScriptArray, FromNativePtr);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00013EB2 File Offset: 0x000120B2
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00013EB5 File Offset: 0x000120B5
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			TArray<T>._CopyTo(this.ScriptArray, FromNativePtr);
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00013EC3 File Offset: 0x000120C3
		public unsafe int Count
		{
			get
			{
				return this.ScriptArray->ArrayNum;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00013ED0 File Offset: 0x000120D0
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004A0 RID: 1184
		public unsafe T this[int Index]
		{
			get
			{
				this.CheckValidIndex(Index);
				return TArray<T>.Processor.Get(this.ScriptArray->Data, Index);
			}
			set
			{
				this.CheckValidIndex(Index);
				TArray<T>.Processor.Set(this.ScriptArray->Data, Index, value);
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00013F12 File Offset: 0x00012112
		[NullableContext(2)]
		public unsafe T Get(int Index)
		{
			this.CheckValidIndex(Index);
			return TArray<T>.Processor.Get(this.ScriptArray->Data, Index);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00013F31 File Offset: 0x00012131
		public unsafe void Set(int Index, in T Value)
		{
			this.CheckValidIndex(Index);
			TArray<T>.Processor.Set(this.ScriptArray->Data, Index, Value);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00013F58 File Offset: 0x00012158
		public unsafe void Add(T Value)
		{
			int index = FScriptArray.AddUninitialized(this._NativePtr, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, index, 1);
			}
			this.Set(index, Value);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00013FB2 File Offset: 0x000121B2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int AddZeroed(int Count)
		{
			return FScriptArray.AddZeroed(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00013FD4 File Offset: 0x000121D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int AddUninitialized(int Count)
		{
			return FScriptArray.AddUninitialized(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00013FF8 File Offset: 0x000121F8
		public unsafe int AddDefaulted(int Count)
		{
			int num = FScriptArray.AddUninitialized(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, num, Count);
			return num;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0001403E File Offset: 0x0001223E
		public unsafe bool Contains(T Value)
		{
			return TArray<T>.Processor.FindIndex(this.ScriptArray->Data, this.ScriptArray->ArrayNum, Value) != -1;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00014068 File Offset: 0x00012268
		public unsafe bool Remove(T Value)
		{
			int num = TArray<T>.Processor.FindIndex(this.ScriptArray->Data, this.ScriptArray->ArrayNum, Value);
			if (num != -1)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000140A8 File Offset: 0x000122A8
		public unsafe void RemoveAt(int Index)
		{
			this.CheckValidIndex(Index);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.DestructValues(this.ScriptArray->Data, Index, 1);
			}
			FScriptArray.RemoveAt(this._NativePtr, Index, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00014100 File Offset: 0x00012300
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe int FindIndex(in T Value)
		{
			return TArray<T>.Processor.FindIndex(this.ScriptArray->Data, this.ScriptArray->ArrayNum, Value);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00014128 File Offset: 0x00012328
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe bool IsValidIndex(int Index)
		{
			return Index >= 0 && Index < this.ScriptArray->ArrayNum;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0001413E File Offset: 0x0001233E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe int Num()
		{
			return this.ScriptArray->ArrayNum;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0001414B File Offset: 0x0001234B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetNum(int Num)
		{
			TArray<T>._SetNum(this.ScriptArray, Num);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00014159 File Offset: 0x00012359
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			TArray<T>._Empty(this.ScriptArray, true);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00014167 File Offset: 0x00012367
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Empty(bool Shrinking = true)
		{
			TArray<T>._Empty(this.ScriptArray, Shrinking);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00014175 File Offset: 0x00012375
		public int IndexOf(T Item)
		{
			return this.FindIndex(Item);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00014180 File Offset: 0x00012380
		public unsafe void Insert(int Index, T Value)
		{
			FScriptArray.Insert(this.ScriptArray, Index, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, Index, 1);
			}
			TArray<T>.Processor.Set(this.ScriptArray->Data, Index, Value);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000141EC File Offset: 0x000123EC
		public unsafe void Insert(int Index, IEnumerable<T> Values)
		{
			IReadOnlyCollection<T> readOnlyCollection = Values as IReadOnlyCollection<T>;
			if (readOnlyCollection != null)
			{
				FScriptArray.Insert(this.ScriptArray, Index, readOnlyCollection.Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
				if (TArray<T>.Processor.RequireConstructAndDestruct)
				{
					TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, Index, readOnlyCollection.Count);
				}
				int num = Index;
				using (IEnumerator<T> enumerator = Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T value = enumerator.Current;
						TArray<T>.Processor.Set(this.ScriptArray->Data, num++, value);
					}
					return;
				}
			}
			T[] array = Values.ToArray<T>();
			this.Insert(Index, array.AsSpan<T>());
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000142C4 File Offset: 0x000124C4
		public unsafe void Insert(int Index, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> Values)
		{
			FScriptArray.Insert(this.ScriptArray, Index, Values.Length, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, Index, Values.Length);
			}
			int num = Index;
			ReadOnlySpan<T> readOnlySpan = Values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				T value = *readOnlySpan[i];
				TArray<T>.Processor.Set(this.ScriptArray->Data, num++, value);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00014361 File Offset: 0x00012561
		public void InsertZero(int Index, int Count)
		{
			FScriptArray.InsertZeroed(this.ScriptArray, Index, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00014388 File Offset: 0x00012588
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void CheckValidIndex(int Index)
		{
			if (!this.IsValidIndex(Index))
			{
				string paramName = "Index";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Argument out of range. Index: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Index);
				defaultInterpolatedStringHandler.AppendLiteral(", ArrayNum: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ScriptArray->ArrayNum);
				throw new ArgumentOutOfRangeException(paramName, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000143EC File Offset: 0x000125EC
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			this.CopyTo(DestPtr);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000143F8 File Offset: 0x000125F8
		public unsafe void CopyTo(T[] Array, int ArrayIndex)
		{
			int num = Math.Min(this.ScriptArray->ArrayNum, Array.Length - ArrayIndex);
			if (TArray<T>.Processor.CanAsSpan)
			{
				this.ScriptArray->AsSpan<T>().CopyTo(Array.AsSpan(ArrayIndex));
				return;
			}
			for (int i = 0; i < num; i++)
			{
				Array[ArrayIndex + i] = this[i];
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0001445E File Offset: 0x0001265E
		public IEnumerator<T> GetEnumerator()
		{
			return new TArray<T>.Enumerator(this);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0001446B File Offset: 0x0001266B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TArray<T>.Enumerator(this);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00014478 File Offset: 0x00012678
		[NullableContext(0)]
		private unsafe static void _Empty(FScriptArray* Array, bool Shrinking = true)
		{
			if (Array->ArrayNum == 0)
			{
				return;
			}
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.DestructValues(Array->Data, 0, Array->ArrayNum);
			}
			FScriptArray.Empty(Array, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment, Shrinking ? 0 : Array->ArrayMax);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000144D8 File Offset: 0x000126D8
		[NullableContext(0)]
		private unsafe static void _SetNum(FScriptArray* Array, int Num)
		{
			if (Num < 0)
			{
				throw new ArgumentOutOfRangeException("Num", "Num must be greater than or equal to 0");
			}
			if (Num > 0)
			{
				int arrayNum = Array->ArrayNum;
				if (arrayNum != Num)
				{
					if (arrayNum > 0 && Num < arrayNum && TArray<T>.Processor.RequireConstructAndDestruct)
					{
						TArray<T>.Processor.DestructValues(Array->Data, Num, arrayNum - Num);
					}
					FScriptArray.SetNum(Array, Num, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment, false);
					if (Num > arrayNum && TArray<T>.Processor.RequireConstructAndDestruct)
					{
						TArray<T>.Processor.ConstructValues(Array->Data, arrayNum, Num - arrayNum);
						return;
					}
				}
			}
			else
			{
				TArray<T>._Empty(Array, true);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00014578 File Offset: 0x00012778
		[NullableContext(0)]
		internal unsafe static void _CopyTo(FScriptArray* Dest, FScriptArray* Src)
		{
			if (Dest == null || Dest == Src)
			{
				return;
			}
			if (Src == null)
			{
				TArray<T>._Empty(Dest, true);
				return;
			}
			int arrayNum = Src->ArrayNum;
			TArray<T>._SetNum(Dest, arrayNum);
			if (arrayNum > 0)
			{
				TArray<T>.Processor.CopyTo(Src->Data, Dest->Data, arrayNum);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000145C5 File Offset: 0x000127C5
		[NullableContext(0)]
		internal unsafe static void _MoveTo(FScriptArray* Dest, FScriptArray* Src)
		{
			if (Dest == null || Src == Dest)
			{
				return;
			}
			if (Src == null)
			{
				TArray<T>._Empty(Dest, true);
				return;
			}
			TArray<T>._Empty(Dest, false);
			FScriptArray.MoveAssign(Dest, Src, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x04000186 RID: 390
		internal static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.Processor;

		// Token: 0x02002B1F RID: 11039
		[Nullable(0)]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x060284EF RID: 165103 RVA: 0x003D5364 File Offset: 0x003D3564
			public Enumerator(TArray<T> Array)
			{
				this.<Array>P = Array;
				this._Index = 0;
				this._Current = default(T);
				this._MaxIndex = this.<Array>P.Num();
			}

			// Token: 0x060284F0 RID: 165104 RVA: 0x003D5394 File Offset: 0x003D3594
			public bool MoveNext()
			{
				if (this._Index < this._MaxIndex)
				{
					TArray<T> tarray = this.<Array>P;
					int index = this._Index;
					this._Index = index + 1;
					this._Current = tarray[index];
					return true;
				}
				return false;
			}

			// Token: 0x060284F1 RID: 165105 RVA: 0x003D53D4 File Offset: 0x003D35D4
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(T);
			}

			// Token: 0x170099AA RID: 39338
			// (get) Token: 0x060284F2 RID: 165106 RVA: 0x003D53E9 File Offset: 0x003D35E9
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x170099AB RID: 39339
			// (get) Token: 0x060284F3 RID: 165107 RVA: 0x003D53F1 File Offset: 0x003D35F1
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x060284F4 RID: 165108 RVA: 0x003D53FE File Offset: 0x003D35FE
			public void Dispose()
			{
			}

			// Token: 0x04016367 RID: 90983
			[CompilerGenerated]
			private TArray<T> <Array>P;

			// Token: 0x04016368 RID: 90984
			private int _Index;

			// Token: 0x04016369 RID: 90985
			private int _MaxIndex;

			// Token: 0x0401636A RID: 90986
			private T _Current;
		}
	}
}
