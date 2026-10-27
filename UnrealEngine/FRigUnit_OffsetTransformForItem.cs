using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A1 RID: 1697
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_OffsetTransformForItem")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_OffsetTransformForItem : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A29 RID: 23081 RVA: 0x00081614 File Offset: 0x0007F814
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_OffsetTransformForItem._ScriptStructPtr != 0) ? FRigUnit_OffsetTransformForItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_OffsetTransformForItem", ref FRigUnit_OffsetTransformForItem._ScriptStructPtr);
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x00081638 File Offset: 0x0007F838
		// (set) Token: 0x06005A2B RID: 23083 RVA: 0x0008167B File Offset: 0x0007F87B
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x0008169C File Offset: 0x0007F89C
		// (set) Token: 0x06005A2D RID: 23085 RVA: 0x000816B0 File Offset: 0x0007F8B0
		public unsafe FTransform OffsetTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_OffsetTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_OffsetTransform) = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x000816C5 File Offset: 0x0007F8C5
		// (set) Token: 0x06005A2F RID: 23087 RVA: 0x000816D5 File Offset: 0x0007F8D5
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x000816E6 File Offset: 0x0007F8E6
		// (set) Token: 0x06005A31 RID: 23089 RVA: 0x000816F6 File Offset: 0x0007F8F6
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06005A32 RID: 23090 RVA: 0x00081708 File Offset: 0x0007F908
		// (set) Token: 0x06005A33 RID: 23091 RVA: 0x0008174B File Offset: 0x0007F94B
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_OffsetTransformForItem.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x0008176C File Offset: 0x0007F96C
		public FRigUnit_OffsetTransformForItem()
		{
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00081774 File Offset: 0x0007F974
		public FRigUnit_OffsetTransformForItem(FRigElementKey Item, FTransform OffsetTransform, float Weight, bool bPropagateToChildren, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.OffsetTransform = OffsetTransform;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x000817A9 File Offset: 0x0007F9A9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_OffsetTransformForItem.StaticStruct();
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x000817B5 File Offset: 0x0007F9B5
		[NullableContext(2)]
		public FRigUnit_OffsetTransformForItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x000817BF File Offset: 0x0007F9BF
		public FRigUnit_OffsetTransformForItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x000817CA File Offset: 0x0007F9CA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_OffsetTransformForItem(Pointer, false, true);
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x000817D4 File Offset: 0x0007F9D4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_OffsetTransformForItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002A31 RID: 10801
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_OffsetTransformForItem";

		// Token: 0x04002A32 RID: 10802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A33 RID: 10803
		internal static int __PropertyOffset_Item;

		// Token: 0x04002A34 RID: 10804
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002A35 RID: 10805
		internal static int __PropertyOffset_OffsetTransform;

		// Token: 0x04002A36 RID: 10806
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002A37 RID: 10807
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002A38 RID: 10808
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002A39 RID: 10809
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
