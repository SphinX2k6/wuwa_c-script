using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CC RID: 1740
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetRelativeTransformForItem")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_SetRelativeTransformForItem : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D09 RID: 23817 RVA: 0x000857D0 File Offset: 0x000839D0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetRelativeTransformForItem._ScriptStructPtr != 0) ? FRigUnit_SetRelativeTransformForItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetRelativeTransformForItem", ref FRigUnit_SetRelativeTransformForItem._ScriptStructPtr);
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06005D0A RID: 23818 RVA: 0x000857F4 File Offset: 0x000839F4
		// (set) Token: 0x06005D0B RID: 23819 RVA: 0x00085837 File Offset: 0x00083A37
		public FRigElementKey Child
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Child) == null)
				{
					result = (this._Child = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Child, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Child, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x00085858 File Offset: 0x00083A58
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x0008589B File Offset: 0x00083A9B
		public FRigElementKey Parent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Parent) == null)
				{
					result = (this._Parent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Parent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Parent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x000858BC File Offset: 0x00083ABC
		// (set) Token: 0x06005D0F RID: 23823 RVA: 0x000858CC File Offset: 0x00083ACC
		public unsafe bool bParentInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_bParentInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_bParentInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x000858DD File Offset: 0x00083ADD
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x000858F1 File Offset: 0x00083AF1
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x00085906 File Offset: 0x00083B06
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x00085916 File Offset: 0x00083B16
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x00085927 File Offset: 0x00083B27
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x00085937 File Offset: 0x00083B37
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x00085948 File Offset: 0x00083B48
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x0008598B File Offset: 0x00083B8B
		public FCachedRigElement CachedChild
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedChild) == null)
				{
					result = (this._CachedChild = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_CachedChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_CachedChild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06005D18 RID: 23832 RVA: 0x000859AC File Offset: 0x00083BAC
		// (set) Token: 0x06005D19 RID: 23833 RVA: 0x000859EF File Offset: 0x00083BEF
		public FCachedRigElement CachedParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedParent) == null)
				{
					result = (this._CachedParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_CachedParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeTransformForItem.__PropertyOffset_CachedParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x00085A10 File Offset: 0x00083C10
		public FRigUnit_SetRelativeTransformForItem()
		{
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x00085A18 File Offset: 0x00083C18
		public FRigUnit_SetRelativeTransformForItem(FRigElementKey Child, FRigElementKey Parent, bool bParentInitial, FTransform RelativeTransform, float Weight, bool bPropagateToChildren, FCachedRigElement CachedChild, FCachedRigElement CachedParent, FControlRigExecuteContext ExecuteContext)
		{
			this.Child = Child;
			this.Parent = Parent;
			this.bParentInitial = bParentInitial;
			this.RelativeTransform = RelativeTransform;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedChild = CachedChild;
			this.CachedParent = CachedParent;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x00085A70 File Offset: 0x00083C70
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetRelativeTransformForItem.StaticStruct();
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00085A7C File Offset: 0x00083C7C
		[NullableContext(2)]
		public FRigUnit_SetRelativeTransformForItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x00085A86 File Offset: 0x00083C86
		public FRigUnit_SetRelativeTransformForItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x00085A91 File Offset: 0x00083C91
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetRelativeTransformForItem(Pointer, false, true);
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x00085A9B File Offset: 0x00083C9B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetRelativeTransformForItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002B86 RID: 11142
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetRelativeTransformForItem";

		// Token: 0x04002B87 RID: 11143
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B88 RID: 11144
		internal static int __PropertyOffset_Child;

		// Token: 0x04002B89 RID: 11145
		[Nullable(2)]
		private FRigElementKey _Child;

		// Token: 0x04002B8A RID: 11146
		internal static int __PropertyOffset_Parent;

		// Token: 0x04002B8B RID: 11147
		[Nullable(2)]
		private FRigElementKey _Parent;

		// Token: 0x04002B8C RID: 11148
		internal static int __PropertyOffset_bParentInitial;

		// Token: 0x04002B8D RID: 11149
		internal static int __PropertyOffset_RelativeTransform;

		// Token: 0x04002B8E RID: 11150
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B8F RID: 11151
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002B90 RID: 11152
		internal static int __PropertyOffset_CachedChild;

		// Token: 0x04002B91 RID: 11153
		[Nullable(2)]
		private FCachedRigElement _CachedChild;

		// Token: 0x04002B92 RID: 11154
		internal static int __PropertyOffset_CachedParent;

		// Token: 0x04002B93 RID: 11155
		[Nullable(2)]
		private FCachedRigElement _CachedParent;
	}
}
