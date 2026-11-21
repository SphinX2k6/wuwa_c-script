using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200005B RID: 91
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TSet<T> : UnrealProxyObject, ISet<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IReadOnlySet<T>, IReadOnlyCollection<T>
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000100BA File Offset: 0x0000E2BA
		public IntPtr NativeSetPtr
		{
			get
			{
				return base.NativePtr.Set;
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000100C7 File Offset: 0x0000E2C7
		public TSet()
		{
			FCScriptSetHelperWrapper.AllocNativeScriptSet(base.NativePtr);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000100DC File Offset: 0x0000E2DC
		[NullableContext(2)]
		public TSet(IntPtr NativeScriptSetPtr, UnrealObject MemoryOwner)
		{
			SharpherealAssert.Assert(NativeScriptSetPtr != IntPtr.Zero);
			bool condition;
			if (MemoryOwner != null && !(MemoryOwner is UnrealUObject))
			{
				UnrealProxyObject unrealProxyObject = MemoryOwner as UnrealProxyObject;
				if (unrealProxyObject == null || !unrealProxyObject.IsNativePtrAllocated)
				{
					condition = false;
					goto IL_39;
				}
			}
			condition = true;
			IL_39:
			SharpherealAssert.Assert(condition);
			this._MemoryOwner = MemoryOwner;
			FCScriptSetHelperWrapper.SetNativeScriptSet(base.NativePtr, NativeScriptSetPtr, base.IsNativePtrAllocated);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00010141 File Offset: 0x0000E341
		public TSet(IntPtr NativeScriptSetPtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativeScriptSetPtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001014C File Offset: 0x0000E34C
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TSet<T>.Processor);
			IntPtr innerUStructPtr = TSet<T>.Processor.IsStructProxyProcessor ? ((IScriptStructProcessor)TSet<T>.Processor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			return FCScriptSetHelperWrapper.AllocNativeMemory(TSet<T>.InnerPropertyTypeCode, innerUStructPtr, TSet<T>.Processor.Size, TSet<T>.Processor.MinAlignment);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000101AA File Offset: 0x0000E3AA
		protected override void DeallocNativePtr()
		{
			this.Empty(0);
			FCScriptSetHelperWrapper.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TSet<T>.Processor);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000101C8 File Offset: 0x0000E3C8
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000101CB File Offset: 0x0000E3CB
		public override void MoveAssign(IntPtr Src)
		{
			FCScriptSetHelperWrapper.MoveAssign(this._NativePtr, Src);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000101D9 File Offset: 0x0000E3D9
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000101DC File Offset: 0x0000E3DC
		public override void CopyAssign(IntPtr Src)
		{
			FCScriptSetHelperWrapper.CopyAssign(this._NativePtr, Src);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000101EC File Offset: 0x0000E3EC
		public unsafe bool Add(T Value)
		{
			bool flag = false;
			void* ptr = TSet<T>.Processor.GetElementPtr(ref Value, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Value);
			}
			int num = this.Num();
			FCScriptSetHelperWrapper.Add(this._NativePtr, ptr);
			if (flag)
			{
				TSet<T>.Processor.DeleteElementPtr(ptr);
			}
			return num != this.Num();
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00010240 File Offset: 0x0000E440
		public unsafe bool Remove(T Value)
		{
			bool flag = false;
			void* ptr = TSet<T>.Processor.GetElementPtr(ref Value, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Value);
			}
			bool result = FCScriptSetHelperWrapper.Remove(this._NativePtr, ptr);
			if (flag)
			{
				TSet<T>.Processor.DeleteElementPtr(ptr);
			}
			return result;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00010284 File Offset: 0x0000E484
		public unsafe bool Contains(T Value)
		{
			bool flag = false;
			void* ptr = TSet<T>.Processor.GetElementPtr(ref Value, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Value);
			}
			bool result = FCScriptSetHelperWrapper.FindIndex(this._NativePtr, ptr) != -1;
			if (flag)
			{
				TSet<T>.Processor.DeleteElementPtr(ptr);
			}
			return result;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000102CB File Offset: 0x0000E4CB
		public int Num()
		{
			return FCScriptSetHelperWrapper.Num(this._NativePtr);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000102D8 File Offset: 0x0000E4D8
		public void Empty(int Slack = 0)
		{
			FCScriptSetHelperWrapper.Empty(this._NativePtr, Slack);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000102E7 File Offset: 0x0000E4E7
		public bool IsValidIndex(int Index)
		{
			return FCScriptSetHelperWrapper.IsValidIndex(this._NativePtr, Index);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000102F5 File Offset: 0x0000E4F5
		public int GetMaxIndex()
		{
			return FCScriptSetHelperWrapper.GetMaxIndex(this._NativePtr);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00010304 File Offset: 0x0000E504
		[NullableContext(2)]
		public unsafe T GetElement(int Index)
		{
			void* elementPtr = FCScriptSetHelperWrapper.GetElementPtr(this._NativePtr, Index);
			if (elementPtr == null)
			{
				return default(T);
			}
			return TSet<T>.Processor.Get(elementPtr, 0);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00010339 File Offset: 0x0000E539
		public override void CopyTo(IntPtr DestScriptSetPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FCScriptSetHelperWrapper.CopyTo(DestScriptSetPtr, base.NativePtr);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00010347 File Offset: 0x0000E547
		[NullableContext(0)]
		public TSet<T>.Enumerator GetEnumerator()
		{
			return new TSet<T>.Enumerator(this);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0001034F File Offset: 0x0000E54F
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new TSet<T>.Enumerator(this);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001035C File Offset: 0x0000E55C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TSet<T>.Enumerator(this);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001036C File Offset: 0x0000E56C
		public void ExceptWith(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Count == 0)
			{
				return;
			}
			if (Other == this)
			{
				this.Clear();
				return;
			}
			foreach (T value in Other)
			{
				this.Remove(value);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000103D4 File Offset: 0x0000E5D4
		public void IntersectWith(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Num() == 0 || Other == this)
			{
				return;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null && collection.Count == 0)
			{
				this.Empty(0);
				return;
			}
			List<T> list = new List<T>();
			foreach (T t in Other)
			{
				if (this.Contains(t))
				{
					list.Add(t);
				}
			}
			this.Empty(0);
			foreach (T value in list)
			{
				this.Add(value);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000104A8 File Offset: 0x0000E6A8
		public bool IsProperSubsetOf(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (Other == this)
			{
				return false;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count <= this.Num())
				{
					return false;
				}
				if (this.Num() == 0)
				{
					return true;
				}
			}
			ISet<T> set = (Other as ISet<T>) ?? Other.ToHashSet<T>();
			foreach (T item in this)
			{
				if (!set.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00010548 File Offset: 0x0000E748
		public bool IsProperSupersetOf(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Num() == 0 || this == Other)
			{
				return false;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null && collection.Count == 0)
			{
				return true;
			}
			ISet<T> set = (Other as ISet<T>) ?? Other.ToHashSet<T>();
			if (set.Count >= this.Num())
			{
				return false;
			}
			foreach (T value in set)
			{
				if (!this.Contains(value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000105EC File Offset: 0x0000E7EC
		public bool IsSubsetOf(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Num() == 0 || Other == this)
			{
				return true;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null && this.Num() > collection.Count)
			{
				return false;
			}
			ISet<T> set = (Other as ISet<T>) ?? Other.ToHashSet<T>();
			foreach (T item in this)
			{
				if (!set.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001068C File Offset: 0x0000E88C
		public bool IsSupersetOf(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (Other == this)
			{
				return true;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count == 0)
				{
					return true;
				}
				ISet<T> set = Other as ISet<T>;
				if (set != null && set.Count > this.Num())
				{
					return false;
				}
			}
			foreach (T value in Other)
			{
				if (!this.Contains(value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00010720 File Offset: 0x0000E920
		public bool Overlaps(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Num() == 0)
			{
				return false;
			}
			if (Other == this)
			{
				return true;
			}
			foreach (T value in Other)
			{
				if (this.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001078C File Offset: 0x0000E98C
		public bool SetEquals(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (Other == this)
			{
				return true;
			}
			ICollection<T> collection = Other as ICollection<!0>;
			if (collection != null)
			{
				if (this.Num() == 0)
				{
					return collection.Count == 0;
				}
				ISet<T> set = Other as ISet<T>;
				if (set != null && this.Num() != set.Count)
				{
					return false;
				}
				if (this.Num() > collection.Count)
				{
					return false;
				}
			}
			foreach (T value in Other)
			{
				if (!this.Contains(value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00010838 File Offset: 0x0000EA38
		public void SymmetricExceptWith(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			if (this.Num() == 0)
			{
				this.UnionWith(Other);
				return;
			}
			if (Other == this)
			{
				this.Empty(0);
				return;
			}
			HashSet<T> hashSet = new HashSet<T>();
			HashSet<T> hashSet2 = new HashSet<T>();
			foreach (T t in Other)
			{
				if (this.Contains(t))
				{
					hashSet.Add(t);
				}
				else
				{
					hashSet2.Add(t);
				}
			}
			foreach (T value in hashSet)
			{
				this.Remove(value);
			}
			foreach (T value2 in hashSet2)
			{
				this.Add(value2);
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001094C File Offset: 0x0000EB4C
		public void UnionWith(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			foreach (T value in Other)
			{
				this.Add(value);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000109A0 File Offset: 0x0000EBA0
		void ICollection<!0>.Add(T Item)
		{
			this.Add(Item);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000109AA File Offset: 0x0000EBAA
		public void Clear()
		{
			this.Empty(0);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000109B4 File Offset: 0x0000EBB4
		public void CopyTo(T[] Array, int ArrayIndex)
		{
			ArgumentNullException.ThrowIfNull(Array, "Array");
			if (ArrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("ArrayIndex", "arrayIndex cannot be negative");
			}
			if (Array.Length - ArrayIndex < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough. Check array index and length.");
			}
			int num = ArrayIndex;
			foreach (T t in this)
			{
				Array[num++] = t;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00010A40 File Offset: 0x0000EC40
		public int Count
		{
			get
			{
				return this.Num();
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00010A48 File Offset: 0x0000EC48
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000146 RID: 326
		private static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.HashProcessor;

		// Token: 0x04000147 RID: 327
		private static readonly UnrealReflectionPropertyTypeCode InnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(T));

		// Token: 0x020008D2 RID: 2258
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x0600BED3 RID: 48851 RVA: 0x00130B75 File Offset: 0x0012ED75
			public Enumerator(TSet<T> Set)
			{
				this.<Set>P = Set;
				this._Index = 0;
				this._Current = default(T);
				this._MaxIndex = this.<Set>P.GetMaxIndex();
			}

			// Token: 0x0600BED4 RID: 48852 RVA: 0x00130BA4 File Offset: 0x0012EDA4
			public unsafe bool MoveNext()
			{
				while (this._Index < this._MaxIndex && !this.<Set>P.IsValidIndex(this._Index))
				{
					this._Index++;
				}
				int index = this._Index;
				this._Index = index + 1;
				int num = index;
				if (num < this._MaxIndex)
				{
					void* elementPtr = FCScriptSetHelperWrapper.GetElementPtr(this.<Set>P._NativePtr, num);
					this._Current = ((elementPtr != null) ? TSet<T>.Processor.Get(elementPtr, 0) : default(T));
					return true;
				}
				return false;
			}

			// Token: 0x0600BED5 RID: 48853 RVA: 0x00130C34 File Offset: 0x0012EE34
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(T);
			}

			// Token: 0x17002340 RID: 9024
			// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x00130C49 File Offset: 0x0012EE49
			public T Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002341 RID: 9025
			// (get) Token: 0x0600BED7 RID: 48855 RVA: 0x00130C51 File Offset: 0x0012EE51
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x17002342 RID: 9026
			// (get) Token: 0x0600BED8 RID: 48856 RVA: 0x00130C59 File Offset: 0x0012EE59
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x0600BED9 RID: 48857 RVA: 0x00130C66 File Offset: 0x0012EE66
			public void Dispose()
			{
			}

			// Token: 0x0400578A RID: 22410
			[CompilerGenerated]
			private TSet<T> <Set>P;

			// Token: 0x0400578B RID: 22411
			private int _Index;

			// Token: 0x0400578C RID: 22412
			private T _Current;

			// Token: 0x0400578D RID: 22413
			private int _MaxIndex;
		}
	}
}
