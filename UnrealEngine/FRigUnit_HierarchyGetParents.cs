using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C6 RID: 1478
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HierarchyGetParents")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_HierarchyGetParents : FRigUnit_HierarchyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FE4 RID: 20452 RVA: 0x00075F99 File Offset: 0x00074199
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HierarchyGetParents._ScriptStructPtr != 0) ? FRigUnit_HierarchyGetParents._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HierarchyGetParents", ref FRigUnit_HierarchyGetParents._ScriptStructPtr);
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x00075FC0 File Offset: 0x000741C0
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x00076003 File Offset: 0x00074203
		public FRigElementKey Child
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Child) == null)
				{
					result = (this._Child = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_Child, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_Child, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x00076024 File Offset: 0x00074224
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x00076034 File Offset: 0x00074234
		public unsafe bool bIncludeChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_bIncludeChild) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_bIncludeChild) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x00076045 File Offset: 0x00074245
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x00076055 File Offset: 0x00074255
		public unsafe bool bReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_bReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_bReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x00076068 File Offset: 0x00074268
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x000760AB File Offset: 0x000742AB
		public FRigElementKeyCollection Parents
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Parents) == null)
				{
					result = (this._Parents = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_Parents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_Parents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x000760CC File Offset: 0x000742CC
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x0007610F File Offset: 0x0007430F
		public FCachedRigElement CachedChild
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedChild) == null)
				{
					result = (this._CachedChild = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_CachedChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_CachedChild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x00076130 File Offset: 0x00074330
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x00076173 File Offset: 0x00074373
		public FRigElementKeyCollection CachedParents
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedParents) == null)
				{
					result = (this._CachedParents = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_CachedParents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParents.__PropertyOffset_CachedParents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00076194 File Offset: 0x00074394
		public FRigUnit_HierarchyGetParents()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x0007619C File Offset: 0x0007439C
		public FRigUnit_HierarchyGetParents(FRigElementKey Child, bool bIncludeChild, bool bReverse, FRigElementKeyCollection Parents, FCachedRigElement CachedChild, FRigElementKeyCollection CachedParents)
		{
			this.Child = Child;
			this.bIncludeChild = bIncludeChild;
			this.bReverse = bReverse;
			this.Parents = Parents;
			this.CachedChild = CachedChild;
			this.CachedParents = CachedParents;
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x000761D1 File Offset: 0x000743D1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HierarchyGetParents.StaticStruct();
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x000761DD File Offset: 0x000743DD
		[NullableContext(2)]
		public FRigUnit_HierarchyGetParents(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x000761E7 File Offset: 0x000743E7
		public FRigUnit_HierarchyGetParents(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x000761F2 File Offset: 0x000743F2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HierarchyGetParents(Pointer, false, true);
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x000761FC File Offset: 0x000743FC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HierarchyGetParents(Pointer, MemoryOwner);
		}

		// Token: 0x04002691 RID: 9873
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HierarchyGetParents";

		// Token: 0x04002692 RID: 9874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002693 RID: 9875
		internal static int __PropertyOffset_Child;

		// Token: 0x04002694 RID: 9876
		[Nullable(2)]
		private FRigElementKey _Child;

		// Token: 0x04002695 RID: 9877
		internal static int __PropertyOffset_bIncludeChild;

		// Token: 0x04002696 RID: 9878
		internal static int __PropertyOffset_bReverse;

		// Token: 0x04002697 RID: 9879
		internal static int __PropertyOffset_Parents;

		// Token: 0x04002698 RID: 9880
		[Nullable(2)]
		private FRigElementKeyCollection _Parents;

		// Token: 0x04002699 RID: 9881
		internal static int __PropertyOffset_CachedChild;

		// Token: 0x0400269A RID: 9882
		[Nullable(2)]
		private FCachedRigElement _CachedChild;

		// Token: 0x0400269B RID: 9883
		internal static int __PropertyOffset_CachedParents;

		// Token: 0x0400269C RID: 9884
		[Nullable(2)]
		private FRigElementKeyCollection _CachedParents;
	}
}
