using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000568 RID: 1384
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionChildren")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_CollectionChildren : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600499C RID: 18844 RVA: 0x0006D34A File Offset: 0x0006B54A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionChildren._ScriptStructPtr != 0) ? FRigUnit_CollectionChildren._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionChildren", ref FRigUnit_CollectionChildren._ScriptStructPtr);
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x0006D370 File Offset: 0x0006B570
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x0006D3B3 File Offset: 0x0006B5B3
		public FRigElementKey Parent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Parent) == null)
				{
					result = (this._Parent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_Parent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_Parent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		// (set) Token: 0x060049A0 RID: 18848 RVA: 0x0006D3E4 File Offset: 0x0006B5E4
		public unsafe bool bIncludeParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_bIncludeParent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_bIncludeParent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x0006D3F5 File Offset: 0x0006B5F5
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x0006D405 File Offset: 0x0006B605
		public unsafe bool bRecursive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_bRecursive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_bRecursive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x0006D416 File Offset: 0x0006B616
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x0006D426 File Offset: 0x0006B626
		public unsafe ERigElementType TypeToSearch
		{
			get
			{
				return (ERigElementType)(*(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_TypeToSearch));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_TypeToSearch) = (byte)value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x0006D438 File Offset: 0x0006B638
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x0006D47B File Offset: 0x0006B67B
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x0006D49C File Offset: 0x0006B69C
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x0006D4DF File Offset: 0x0006B6DF
		public FRigElementKeyCollection CachedCollection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedCollection) == null)
				{
					result = (this._CachedCollection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_CachedCollection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_CachedCollection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x0006D500 File Offset: 0x0006B700
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x0006D510 File Offset: 0x0006B710
		public unsafe int CachedHierarchyHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_CachedHierarchyHash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionChildren.__PropertyOffset_CachedHierarchyHash) = value;
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x0006D521 File Offset: 0x0006B721
		public FRigUnit_CollectionChildren()
		{
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x0006D529 File Offset: 0x0006B729
		public FRigUnit_CollectionChildren(FRigElementKey Parent, bool bIncludeParent, bool bRecursive, ERigElementType TypeToSearch, FRigElementKeyCollection Collection, FRigElementKeyCollection CachedCollection, int CachedHierarchyHash)
		{
			this.Parent = Parent;
			this.bIncludeParent = bIncludeParent;
			this.bRecursive = bRecursive;
			this.TypeToSearch = TypeToSearch;
			this.Collection = Collection;
			this.CachedCollection = CachedCollection;
			this.CachedHierarchyHash = CachedHierarchyHash;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x0006D566 File Offset: 0x0006B766
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionChildren.StaticStruct();
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0006D572 File Offset: 0x0006B772
		[NullableContext(2)]
		public FRigUnit_CollectionChildren(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x0006D57C File Offset: 0x0006B77C
		public FRigUnit_CollectionChildren(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x0006D587 File Offset: 0x0006B787
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionChildren(Pointer, false, true);
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x0006D591 File Offset: 0x0006B791
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionChildren(Pointer, MemoryOwner);
		}

		// Token: 0x040023BC RID: 9148
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionChildren";

		// Token: 0x040023BD RID: 9149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023BE RID: 9150
		internal static int __PropertyOffset_Parent;

		// Token: 0x040023BF RID: 9151
		[Nullable(2)]
		private FRigElementKey _Parent;

		// Token: 0x040023C0 RID: 9152
		internal static int __PropertyOffset_bIncludeParent;

		// Token: 0x040023C1 RID: 9153
		internal static int __PropertyOffset_bRecursive;

		// Token: 0x040023C2 RID: 9154
		internal static int __PropertyOffset_TypeToSearch;

		// Token: 0x040023C3 RID: 9155
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023C4 RID: 9156
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023C5 RID: 9157
		internal static int __PropertyOffset_CachedCollection;

		// Token: 0x040023C6 RID: 9158
		[Nullable(2)]
		private FRigElementKeyCollection _CachedCollection;

		// Token: 0x040023C7 RID: 9159
		internal static int __PropertyOffset_CachedHierarchyHash;
	}
}
