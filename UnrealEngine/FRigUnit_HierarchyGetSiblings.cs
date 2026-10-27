using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C7 RID: 1479
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HierarchyGetSiblings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_HierarchyGetSiblings : FRigUnit_HierarchyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FF8 RID: 20472 RVA: 0x00076205 File Offset: 0x00074405
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HierarchyGetSiblings._ScriptStructPtr != 0) ? FRigUnit_HierarchyGetSiblings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HierarchyGetSiblings", ref FRigUnit_HierarchyGetSiblings._ScriptStructPtr);
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x0007622C File Offset: 0x0007442C
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x0007626F File Offset: 0x0007446F
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x00076290 File Offset: 0x00074490
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x000762A0 File Offset: 0x000744A0
		public unsafe bool bIncludeItem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_bIncludeItem) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_bIncludeItem) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x000762B4 File Offset: 0x000744B4
		// (set) Token: 0x06004FFE RID: 20478 RVA: 0x000762F7 File Offset: 0x000744F7
		public FRigElementKeyCollection Siblings
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Siblings) == null)
				{
					result = (this._Siblings = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_Siblings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_Siblings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x00076318 File Offset: 0x00074518
		// (set) Token: 0x06005000 RID: 20480 RVA: 0x0007635B File Offset: 0x0007455B
		public FCachedRigElement CachedItem
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedItem) == null)
				{
					result = (this._CachedItem = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_CachedItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_CachedItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x0007637C File Offset: 0x0007457C
		// (set) Token: 0x06005002 RID: 20482 RVA: 0x000763BF File Offset: 0x000745BF
		public FRigElementKeyCollection CachedSiblings
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedSiblings) == null)
				{
					result = (this._CachedSiblings = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_CachedSiblings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetSiblings.__PropertyOffset_CachedSiblings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x000763E0 File Offset: 0x000745E0
		public FRigUnit_HierarchyGetSiblings()
		{
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x000763E8 File Offset: 0x000745E8
		public FRigUnit_HierarchyGetSiblings(FRigElementKey Item, bool bIncludeItem, FRigElementKeyCollection Siblings, FCachedRigElement CachedItem, FRigElementKeyCollection CachedSiblings)
		{
			this.Item = Item;
			this.bIncludeItem = bIncludeItem;
			this.Siblings = Siblings;
			this.CachedItem = CachedItem;
			this.CachedSiblings = CachedSiblings;
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00076415 File Offset: 0x00074615
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HierarchyGetSiblings.StaticStruct();
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00076421 File Offset: 0x00074621
		[NullableContext(2)]
		public FRigUnit_HierarchyGetSiblings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x0007642B File Offset: 0x0007462B
		public FRigUnit_HierarchyGetSiblings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x00076436 File Offset: 0x00074636
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HierarchyGetSiblings(Pointer, false, true);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x00076440 File Offset: 0x00074640
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HierarchyGetSiblings(Pointer, MemoryOwner);
		}

		// Token: 0x0400269D RID: 9885
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HierarchyGetSiblings";

		// Token: 0x0400269E RID: 9886
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400269F RID: 9887
		internal static int __PropertyOffset_Item;

		// Token: 0x040026A0 RID: 9888
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x040026A1 RID: 9889
		internal static int __PropertyOffset_bIncludeItem;

		// Token: 0x040026A2 RID: 9890
		internal static int __PropertyOffset_Siblings;

		// Token: 0x040026A3 RID: 9891
		[Nullable(2)]
		private FRigElementKeyCollection _Siblings;

		// Token: 0x040026A4 RID: 9892
		internal static int __PropertyOffset_CachedItem;

		// Token: 0x040026A5 RID: 9893
		[Nullable(2)]
		private FCachedRigElement _CachedItem;

		// Token: 0x040026A6 RID: 9894
		internal static int __PropertyOffset_CachedSiblings;

		// Token: 0x040026A7 RID: 9895
		[Nullable(2)]
		private FRigElementKeyCollection _CachedSiblings;
	}
}
