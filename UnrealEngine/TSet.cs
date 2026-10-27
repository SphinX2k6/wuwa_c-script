using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000076 RID: 118
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TSet<T> : UnrealProxyObject, ISet<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IReadOnlySet<T>, IReadOnlyCollection<T>
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x000153B2 File Offset: 0x000135B2
		public IntPtr NativeSetPtr
		{
			get
			{
				return base.NativePtr.Set;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000153BF File Offset: 0x000135BF
		public TSet()
		{
			FCScriptSetHelperWrapper.AllocNativeScriptSet(base.NativePtr);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000153D4 File Offset: 0x000135D4
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

		// Token: 0x06000E55 RID: 3669 RVA: 0x00015439 File Offset: 0x00013639
		public TSet(IntPtr NativeScriptSetPtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativeScriptSetPtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00015444 File Offset: 0x00013644
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TSet<T>.Processor);
			IntPtr innerUStructPtr = TSet<T>.Processor.IsStructProxyProcessor ? ((IScriptStructProcessor)TSet<T>.Processor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			return FCScriptSetHelperWrapper.AllocNativeMemory(TSet<T>.InnerPropertyTypeCode, innerUStructPtr, TSet<T>.Processor.Size, TSet<T>.Processor.MinAlignment);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000154A2 File Offset: 0x000136A2
		protected override void DeallocNativePtr()
		{
			this.Empty(0);
			FCScriptSetHelperWrapper.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TSet<T>.Processor);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000154C0 File Offset: 0x000136C0
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000154C3 File Offset: 0x000136C3
		public override void MoveAssign(IntPtr Src)
		{
			FCScriptSetHelperWrapper.MoveAssign(this._NativePtr, Src);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000154D1 File Offset: 0x000136D1
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000154D4 File Offset: 0x000136D4
		public override void CopyAssign(IntPtr Src)
		{
			FCScriptSetHelperWrapper.CopyAssign(this._NativePtr, Src);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000154E4 File Offset: 0x000136E4
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

		// Token: 0x06000E5D RID: 3677 RVA: 0x00015538 File Offset: 0x00013738
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

		// Token: 0x06000E5E RID: 3678 RVA: 0x0001557C File Offset: 0x0001377C
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

		// Token: 0x06000E5F RID: 3679 RVA: 0x000155C3 File Offset: 0x000137C3
		public int Num()
		{
			return FCScriptSetHelperWrapper.Num(this._NativePtr);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000155D0 File Offset: 0x000137D0
		public void Empty(int Slack = 0)
		{
			FCScriptSetHelperWrapper.Empty(this._NativePtr, Slack);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000155DF File Offset: 0x000137DF
		public bool IsValidIndex(int Index)
		{
			return FCScriptSetHelperWrapper.IsValidIndex(this._NativePtr, Index);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000155ED File Offset: 0x000137ED
		public int GetMaxIndex()
		{
			return FCScriptSetHelperWrapper.GetMaxIndex(this._NativePtr);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000155FC File Offset: 0x000137FC
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

		// Token: 0x06000E64 RID: 3684 RVA: 0x00015631 File Offset: 0x00013831
		public override void CopyTo(IntPtr DestScriptSetPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FCScriptSetHelperWrapper.CopyTo(DestScriptSetPtr, base.NativePtr);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0001563F File Offset: 0x0001383F
		public IEnumerator<T> GetEnumerator()
		{
			return new TSet<T>.Enumerator(this);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0001564C File Offset: 0x0001384C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TSet<T>.Enumerator(this);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0001565C File Offset: 0x0001385C
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

		// Token: 0x06000E68 RID: 3688 RVA: 0x000156C4 File Offset: 0x000138C4
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

		// Token: 0x06000E69 RID: 3689 RVA: 0x00015798 File Offset: 0x00013998
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

		// Token: 0x06000E6A RID: 3690 RVA: 0x00015834 File Offset: 0x00013A34
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

		// Token: 0x06000E6B RID: 3691 RVA: 0x000158D8 File Offset: 0x00013AD8
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

		// Token: 0x06000E6C RID: 3692 RVA: 0x00015970 File Offset: 0x00013B70
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

		// Token: 0x06000E6D RID: 3693 RVA: 0x00015A04 File Offset: 0x00013C04
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

		// Token: 0x06000E6E RID: 3694 RVA: 0x00015A70 File Offset: 0x00013C70
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

		// Token: 0x06000E6F RID: 3695 RVA: 0x00015B1C File Offset: 0x00013D1C
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

		// Token: 0x06000E70 RID: 3696 RVA: 0x00015C30 File Offset: 0x00013E30
		public void UnionWith(IEnumerable<T> Other)
		{
			ArgumentNullException.ThrowIfNull(Other, "Other");
			foreach (T value in Other)
			{
				this.Add(value);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00015C84 File Offset: 0x00013E84
		void ICollection<!0>.Add(T Item)
		{
			this.Add(Item);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00015C8E File Offset: 0x00013E8E
		public void Clear()
		{
			this.Empty(0);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00015C98 File Offset: 0x00013E98
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00015D20 File Offset: 0x00013F20
		public int Count
		{
			get
			{
				return this.Num();
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00015D28 File Offset: 0x00013F28
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly NativeArrayProcessorBase<T> Processor = NativeArrayProcessorFactory<T>.HashProcessor;

		// Token: 0x0400018E RID: 398
		private static readonly UnrealReflectionPropertyTypeCode InnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(T));

		// Token: 0x02002B24 RID: 11044
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x06028517 RID: 165143 RVA: 0x003D5811 File Offset: 0x003D3A11
			public Enumerator(TSet<T> Set)
			{
				this.<Set>P = Set;
				this._Index = 0;
				this._Current = default(T);
				this._MaxIndex = this.<Set>P.GetMaxIndex();
			}

			// Token: 0x06028518 RID: 165144 RVA: 0x003D5840 File Offset: 0x003D3A40
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

			// Token: 0x06028519 RID: 165145 RVA: 0x003D58D0 File Offset: 0x003D3AD0
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(T);
			}

			// Token: 0x170099B4 RID: 39348
			// (get) Token: 0x0602851A RID: 165146 RVA: 0x003D58E5 File Offset: 0x003D3AE5
			T IEnumerator<!0>.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x170099B5 RID: 39349
			// (get) Token: 0x0602851B RID: 165147 RVA: 0x003D58ED File Offset: 0x003D3AED
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x0602851C RID: 165148 RVA: 0x003D58FA File Offset: 0x003D3AFA
			public void Dispose()
			{
			}

			// Token: 0x04016374 RID: 90996
			[CompilerGenerated]
			private TSet<T> <Set>P;

			// Token: 0x04016375 RID: 90997
			private int _Index;

			// Token: 0x04016376 RID: 90998
			private T _Current;

			// Token: 0x04016377 RID: 90999
			private int _MaxIndex;
		}
	}
}
