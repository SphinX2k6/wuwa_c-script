using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C4 RID: 1476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HierarchyGetChildren")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_HierarchyGetChildren : FRigUnit_HierarchyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FC0 RID: 20416 RVA: 0x00075B17 File Offset: 0x00073D17
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HierarchyGetChildren._ScriptStructPtr != 0) ? FRigUnit_HierarchyGetChildren._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HierarchyGetChildren", ref FRigUnit_HierarchyGetChildren._ScriptStructPtr);
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x00075B3C File Offset: 0x00073D3C
		// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x00075B7F File Offset: 0x00073D7F
		public FRigElementKey Parent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Parent) == null)
				{
					result = (this._Parent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_Parent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_Parent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x00075BA0 File Offset: 0x00073DA0
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x00075BB0 File Offset: 0x00073DB0
		public unsafe bool bIncludeParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_bIncludeParent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_bIncludeParent) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x00075BC1 File Offset: 0x00073DC1
		// (set) Token: 0x06004FC6 RID: 20422 RVA: 0x00075BD1 File Offset: 0x00073DD1
		public unsafe bool bRecursive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_bRecursive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_bRecursive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x00075BE4 File Offset: 0x00073DE4
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x00075C27 File Offset: 0x00073E27
		public FRigElementKeyCollection Children
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_Children, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_Children, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x00075C48 File Offset: 0x00073E48
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x00075C8B File Offset: 0x00073E8B
		public FCachedRigElement CachedParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedParent) == null)
				{
					result = (this._CachedParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_CachedParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_CachedParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x00075CAC File Offset: 0x00073EAC
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x00075CEF File Offset: 0x00073EEF
		public FRigElementKeyCollection CachedChildren
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedChildren) == null)
				{
					result = (this._CachedChildren = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_CachedChildren, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetChildren.__PropertyOffset_CachedChildren, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00075D10 File Offset: 0x00073F10
		public FRigUnit_HierarchyGetChildren()
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00075D18 File Offset: 0x00073F18
		public FRigUnit_HierarchyGetChildren(FRigElementKey Parent, bool bIncludeParent, bool bRecursive, FRigElementKeyCollection Children, FCachedRigElement CachedParent, FRigElementKeyCollection CachedChildren)
		{
			this.Parent = Parent;
			this.bIncludeParent = bIncludeParent;
			this.bRecursive = bRecursive;
			this.Children = Children;
			this.CachedParent = CachedParent;
			this.CachedChildren = CachedChildren;
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00075D4D File Offset: 0x00073F4D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HierarchyGetChildren.StaticStruct();
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00075D59 File Offset: 0x00073F59
		[NullableContext(2)]
		public FRigUnit_HierarchyGetChildren(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00075D63 File Offset: 0x00073F63
		public FRigUnit_HierarchyGetChildren(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00075D6E File Offset: 0x00073F6E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HierarchyGetChildren(Pointer, false, true);
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00075D78 File Offset: 0x00073F78
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HierarchyGetChildren(Pointer, MemoryOwner);
		}

		// Token: 0x0400267B RID: 9851
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HierarchyGetChildren";

		// Token: 0x0400267C RID: 9852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400267D RID: 9853
		internal static int __PropertyOffset_Parent;

		// Token: 0x0400267E RID: 9854
		[Nullable(2)]
		private FRigElementKey _Parent;

		// Token: 0x0400267F RID: 9855
		internal static int __PropertyOffset_bIncludeParent;

		// Token: 0x04002680 RID: 9856
		internal static int __PropertyOffset_bRecursive;

		// Token: 0x04002681 RID: 9857
		internal static int __PropertyOffset_Children;

		// Token: 0x04002682 RID: 9858
		[Nullable(2)]
		private FRigElementKeyCollection _Children;

		// Token: 0x04002683 RID: 9859
		internal static int __PropertyOffset_CachedParent;

		// Token: 0x04002684 RID: 9860
		[Nullable(2)]
		private FCachedRigElement _CachedParent;

		// Token: 0x04002685 RID: 9861
		internal static int __PropertyOffset_CachedChildren;

		// Token: 0x04002686 RID: 9862
		[Nullable(2)]
		private FRigElementKeyCollection _CachedChildren;
	}
}
