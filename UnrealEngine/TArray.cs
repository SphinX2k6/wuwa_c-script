using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000055 RID: 85
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Array, PropertiesSize = 16)]
	public sealed class TArray<[Nullable(2)] T> : UnrealProxyObject, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0000EADD File Offset: 0x0000CCDD
		[Nullable(0)]
		public unsafe FScriptArray* ScriptArray
		{
			[NullableContext(0)]
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0000EAE5 File Offset: 0x0000CCE5
		public TArray()
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000EAED File Offset: 0x0000CCED
		[NullableContext(2)]
		public TArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			if (base.IsNativePtrAllocated)
			{
				NativeArrayProcessorFactory.AddRef(TArray<T>.Processor);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000EB09 File Offset: 0x0000CD09
		public TArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000EB14 File Offset: 0x0000CD14
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TArray<T>.Processor);
			return FScriptArray.AllocNativeMemory();
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0000EB25 File Offset: 0x0000CD25
		protected override void DeallocNativePtr()
		{
			TArray<T>._Empty(this.ScriptArray, true);
			FScriptArray.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TArray<T>.Processor);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0000EB49 File Offset: 0x0000CD49
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			TArray<T>._MoveTo(this.ScriptArray, FromNativePtr);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0000EB5A File Offset: 0x0000CD5A
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0000EB5D File Offset: 0x0000CD5D
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			TArray<T>._CopyTo(this.ScriptArray, FromNativePtr);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0000EB6B File Offset: 0x0000CD6B
		public unsafe int Count
		{
			get
			{
				return this.ScriptArray->ArrayNum;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0000EB78 File Offset: 0x0000CD78
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A8 RID: 168
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

		// Token: 0x0600095D RID: 2397 RVA: 0x0000EBBA File Offset: 0x0000CDBA
		[NullableContext(2)]
		public unsafe T Get(int Index)
		{
			this.CheckValidIndex(Index);
			return TArray<T>.Processor.Get(this.ScriptArray->Data, Index);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
		public unsafe void Set(int Index, in T Value)
		{
			this.CheckValidIndex(Index);
			TArray<T>.Processor.Set(this.ScriptArray->Data, Index, Value);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0000EC00 File Offset: 0x0000CE00
		public unsafe void Add(T Value)
		{
			int index = FScriptArray.AddUninitialized(this._NativePtr, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, index, 1);
			}
			this.Set(index, Value);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000EC5A File Offset: 0x0000CE5A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int AddZeroed(int Count)
		{
			return FScriptArray.AddZeroed(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int AddUninitialized(int Count)
		{
			return FScriptArray.AddUninitialized(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		public unsafe int AddDefaulted(int Count)
		{
			int num = FScriptArray.AddUninitialized(this._NativePtr, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, num, Count);
			return num;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0000ECE6 File Offset: 0x0000CEE6
		public unsafe bool Contains(T Value)
		{
			return TArray<T>.Processor.FindIndex(this.ScriptArray->Data, this.ScriptArray->ArrayNum, Value) != -1;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0000ED10 File Offset: 0x0000CF10
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

		// Token: 0x06000965 RID: 2405 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public unsafe void RemoveAt(int Index)
		{
			this.CheckValidIndex(Index);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.DestructValues(this.ScriptArray->Data, Index, 1);
			}
			FScriptArray.RemoveAt(this._NativePtr, Index, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe int FindIndex(in T Value)
		{
			return TArray<T>.Processor.FindIndex(this.ScriptArray->Data, this.ScriptArray->ArrayNum, Value);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe bool IsValidIndex(int Index)
		{
			return Index >= 0 && Index < this.ScriptArray->ArrayNum;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0000EDE6 File Offset: 0x0000CFE6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe int Num()
		{
			return this.ScriptArray->ArrayNum;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0000EDF3 File Offset: 0x0000CFF3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetNum(int Num)
		{
			TArray<T>._SetNum(this.ScriptArray, Num);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0000EE01 File Offset: 0x0000D001
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			TArray<T>._Empty(this.ScriptArray, true);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0000EE0F File Offset: 0x0000D00F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Empty(bool Shrinking = true)
		{
			TArray<T>._Empty(this.ScriptArray, Shrinking);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0000EE1D File Offset: 0x0000D01D
		public int IndexOf(T Item)
		{
			return this.FindIndex(Item);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0000EE28 File Offset: 0x0000D028
		public unsafe void Insert(int Index, T Value)
		{
			FScriptArray.Insert(this.ScriptArray, Index, 1, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
			if (TArray<T>.Processor.RequireConstructAndDestruct)
			{
				TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, Index, 1);
			}
			TArray<T>.Processor.Set(this.ScriptArray->Data, Index, Value);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0000EE94 File Offset: 0x0000D094
		[NullableContext(2)]
		private bool IsSame(object Obj)
		{
			if (this != Obj)
			{
				TArray<T> tarray = Obj as TArray<T>;
				return tarray != null && this._NativePtr == tarray._NativePtr;
			}
			return true;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		public unsafe void Insert(int Index, IEnumerable<T> Values)
		{
			if (!this.IsSame(Values))
			{
				ICollection<T> collection = Values as ICollection<!0>;
				if (collection != null)
				{
					int count = collection.Count;
					if (count <= 0)
					{
						return;
					}
					FScriptArray.Insert(this.ScriptArray, Index, count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
					if (TArray<T>.Processor.RequireConstructAndDestruct)
					{
						TArray<T>.Processor.ConstructValues(this.ScriptArray->Data, Index, count);
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
			}
			T[] array = Values.ToArray<T>();
			this.Insert(Index, array.AsSpan<T>());
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		public unsafe void Insert(int Index, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> Values)
		{
			if (Values.IsEmpty)
			{
				return;
			}
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

		// Token: 0x06000971 RID: 2417 RVA: 0x0000F053 File Offset: 0x0000D253
		public void InsertZero(int Index, int Count)
		{
			FScriptArray.InsertZeroed(this.ScriptArray, Index, Count, TArray<T>.Processor.Size, TArray<T>.Processor.MinAlignment);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000F078 File Offset: 0x0000D278
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

		// Token: 0x06000973 RID: 2419 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			this.CopyTo(DestPtr);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
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

		// Token: 0x06000975 RID: 2421 RVA: 0x0000F14E File Offset: 0x0000D34E
		[NullableContext(0)]
		public TArray<T>.Enumerator GetEnumerator()
		{
			return new TArray<T>.Enumerator(this);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0000F156 File Offset: 0x0000D356
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new TArray<T>.Enumerator(this);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0000F163 File Offset: 0x0000D363
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TArray<T>.Enumerator(this);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0000F170 File Offset: 0x0000D370
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

		// Token: 0x06000979 RID: 2425 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
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

		// Token: 0x0600097A RID: 2426 RVA: 0x0000F270 File Offset: 0x0000D470
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

		// Token: 0x0600097B RID: 2427 RVA: 0x0000F2BD File Offset: 0x0000D4BD
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

		// Token: 0x0400013F RID: 319
		internal static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.Processor;

		// Token: 0x020008CD RID: 2253
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x0600BEA8 RID: 48808 RVA: 0x001306B2 File Offset: 0x0012E8B2
			public Enumerator(TArray<T> Array)
			{
				this.<Array>P = Array;
				this._Index = 0;
				this._Current = default(T);
				this._MaxIndex = this.<Array>P.Num();
			}

			// Token: 0x0600BEA9 RID: 48809 RVA: 0x001306E0 File Offset: 0x0012E8E0
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

			// Token: 0x0600BEAA RID: 48810 RVA: 0x00130720 File Offset: 0x0012E920
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(T);
			}

			// Token: 0x17002333 RID: 9011
			// (get) Token: 0x0600BEAB RID: 48811 RVA: 0x00130735 File Offset: 0x0012E935
			public T Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002334 RID: 9012
			// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x0013073D File Offset: 0x0012E93D
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002335 RID: 9013
			// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x00130745 File Offset: 0x0012E945
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x0600BEAE RID: 48814 RVA: 0x00130752 File Offset: 0x0012E952
			public void Dispose()
			{
			}

			// Token: 0x0400577D RID: 22397
			[CompilerGenerated]
			private TArray<T> <Array>P;

			// Token: 0x0400577E RID: 22398
			private int _Index;

			// Token: 0x0400577F RID: 22399
			private int _MaxIndex;

			// Token: 0x04005780 RID: 22400
			private T _Current;
		}
	}
}
