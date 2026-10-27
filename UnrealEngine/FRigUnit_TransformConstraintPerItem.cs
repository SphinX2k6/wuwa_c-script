using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006ED RID: 1773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TransformConstraintPerItem")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FRigUnit_TransformConstraintPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F3A RID: 24378 RVA: 0x000887A8 File Offset: 0x000869A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TransformConstraintPerItem._ScriptStructPtr != 0) ? FRigUnit_TransformConstraintPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TransformConstraintPerItem", ref FRigUnit_TransformConstraintPerItem._ScriptStructPtr);
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06005F3B RID: 24379 RVA: 0x000887CC File Offset: 0x000869CC
		// (set) Token: 0x06005F3C RID: 24380 RVA: 0x0008880F File Offset: 0x00086A0F
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x00088830 File Offset: 0x00086A30
		// (set) Token: 0x06005F3E RID: 24382 RVA: 0x00088840 File Offset: 0x00086A40
		public unsafe ETransformSpaceMode BaseTransformSpace
		{
			get
			{
				return (ETransformSpaceMode)(*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseTransformSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseTransformSpace) = (byte)value;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x00088851 File Offset: 0x00086A51
		// (set) Token: 0x06005F40 RID: 24384 RVA: 0x00088865 File Offset: 0x00086A65
		public unsafe FTransform BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseTransform) = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x0008887C File Offset: 0x00086A7C
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x000888BF File Offset: 0x00086ABF
		public FRigElementKey BaseItem
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._BaseItem) == null)
				{
					result = (this._BaseItem = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_BaseItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x000888E0 File Offset: 0x00086AE0
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x00088923 File Offset: 0x00086B23
		public TArray<FConstraintTarget> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraintTarget> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FConstraintTarget>(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06005F45 RID: 24389 RVA: 0x00088931 File Offset: 0x00086B31
		// (set) Token: 0x06005F46 RID: 24390 RVA: 0x00088941 File Offset: 0x00086B41
		public unsafe bool bUseInitialTransforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_bUseInitialTransforms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_bUseInitialTransforms) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x00088954 File Offset: 0x00086B54
		// (set) Token: 0x06005F48 RID: 24392 RVA: 0x00088997 File Offset: 0x00086B97
		public FRigUnit_TransformConstraint_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TransformConstraint_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_TransformConstraint_WorkData(base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TransformConstraint_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TransformConstraintPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x000889B8 File Offset: 0x00086BB8
		public FRigUnit_TransformConstraintPerItem()
		{
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x000889C0 File Offset: 0x00086BC0
		public FRigUnit_TransformConstraintPerItem(FRigElementKey Item, ETransformSpaceMode BaseTransformSpace, FTransform BaseTransform, FRigElementKey BaseItem, TArray<FConstraintTarget> Targets, bool bUseInitialTransforms, FRigUnit_TransformConstraint_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.BaseTransformSpace = BaseTransformSpace;
			this.BaseTransform = BaseTransform;
			this.BaseItem = BaseItem;
			this.Targets = Targets;
			this.bUseInitialTransforms = bUseInitialTransforms;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x00088A10 File Offset: 0x00086C10
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TransformConstraintPerItem.StaticStruct();
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x00088A1C File Offset: 0x00086C1C
		[NullableContext(2)]
		public FRigUnit_TransformConstraintPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x00088A26 File Offset: 0x00086C26
		public FRigUnit_TransformConstraintPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x00088A31 File Offset: 0x00086C31
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TransformConstraintPerItem(Pointer, false, true);
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x00088A3B File Offset: 0x00086C3B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TransformConstraintPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002C80 RID: 11392
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TransformConstraintPerItem";

		// Token: 0x04002C81 RID: 11393
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C82 RID: 11394
		internal static int __PropertyOffset_Item;

		// Token: 0x04002C83 RID: 11395
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002C84 RID: 11396
		internal static int __PropertyOffset_BaseTransformSpace;

		// Token: 0x04002C85 RID: 11397
		internal static int __PropertyOffset_BaseTransform;

		// Token: 0x04002C86 RID: 11398
		internal static int __PropertyOffset_BaseItem;

		// Token: 0x04002C87 RID: 11399
		[Nullable(2)]
		private FRigElementKey _BaseItem;

		// Token: 0x04002C88 RID: 11400
		internal static int __PropertyOffset_Targets;

		// Token: 0x04002C89 RID: 11401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraintTarget> _Targets;

		// Token: 0x04002C8A RID: 11402
		internal static int __PropertyOffset_bUseInitialTransforms;

		// Token: 0x04002C8B RID: 11403
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002C8C RID: 11404
		[Nullable(2)]
		private FRigUnit_TransformConstraint_WorkData _WorkData;
	}
}
