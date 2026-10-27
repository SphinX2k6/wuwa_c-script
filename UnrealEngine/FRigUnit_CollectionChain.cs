using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000567 RID: 1383
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionChain")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_CollectionChain : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004988 RID: 18824 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionChain._ScriptStructPtr != 0) ? FRigUnit_CollectionChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionChain", ref FRigUnit_CollectionChain._ScriptStructPtr);
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x0006D104 File Offset: 0x0006B304
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x0006D147 File Offset: 0x0006B347
		public FRigElementKey FirstItem
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._FirstItem) == null)
				{
					result = (this._FirstItem = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_FirstItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_FirstItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x0006D168 File Offset: 0x0006B368
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x0006D1AB File Offset: 0x0006B3AB
		public FRigElementKey LastItem
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._LastItem) == null)
				{
					result = (this._LastItem = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_LastItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_LastItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x0006D1CC File Offset: 0x0006B3CC
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x0006D1DC File Offset: 0x0006B3DC
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x0006D233 File Offset: 0x0006B433
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x0006D254 File Offset: 0x0006B454
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x0006D297 File Offset: 0x0006B497
		public FRigElementKeyCollection CachedCollection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedCollection) == null)
				{
					result = (this._CachedCollection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_CachedCollection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_CachedCollection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
		// (set) Token: 0x06004994 RID: 18836 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		public unsafe int CachedHierarchyHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_CachedHierarchyHash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChain.__PropertyOffset_CachedHierarchyHash) = value;
			}
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x0006D2D9 File Offset: 0x0006B4D9
		public FRigUnit_CollectionChain()
		{
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x0006D2E1 File Offset: 0x0006B4E1
		public FRigUnit_CollectionChain(FRigElementKey FirstItem, FRigElementKey LastItem, bool Reverse, FRigElementKeyCollection Collection, FRigElementKeyCollection CachedCollection, int CachedHierarchyHash)
		{
			this.FirstItem = FirstItem;
			this.LastItem = LastItem;
			this.Reverse = Reverse;
			this.Collection = Collection;
			this.CachedCollection = CachedCollection;
			this.CachedHierarchyHash = CachedHierarchyHash;
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0006D316 File Offset: 0x0006B516
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionChain.StaticStruct();
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x0006D322 File Offset: 0x0006B522
		[NullableContext(2)]
		public FRigUnit_CollectionChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x0006D32C File Offset: 0x0006B52C
		public FRigUnit_CollectionChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x0006D337 File Offset: 0x0006B537
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionChain(Pointer, false, true);
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x0006D341 File Offset: 0x0006B541
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionChain(Pointer, MemoryOwner);
		}

		// Token: 0x040023B0 RID: 9136
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionChain";

		// Token: 0x040023B1 RID: 9137
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023B2 RID: 9138
		internal static int __PropertyOffset_FirstItem;

		// Token: 0x040023B3 RID: 9139
		[Nullable(2)]
		private FRigElementKey _FirstItem;

		// Token: 0x040023B4 RID: 9140
		internal static int __PropertyOffset_LastItem;

		// Token: 0x040023B5 RID: 9141
		[Nullable(2)]
		private FRigElementKey _LastItem;

		// Token: 0x040023B6 RID: 9142
		internal static int __PropertyOffset_Reverse;

		// Token: 0x040023B7 RID: 9143
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023B8 RID: 9144
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023B9 RID: 9145
		internal static int __PropertyOffset_CachedCollection;

		// Token: 0x040023BA RID: 9146
		[Nullable(2)]
		private FRigElementKeyCollection _CachedCollection;

		// Token: 0x040023BB RID: 9147
		internal static int __PropertyOffset_CachedHierarchyHash;
	}
}
