using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EC RID: 1772
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TransformConstraint")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FRigUnit_TransformConstraint : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F24 RID: 24356 RVA: 0x00088581 File Offset: 0x00086781
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TransformConstraint._ScriptStructPtr != 0) ? FRigUnit_TransformConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TransformConstraint", ref FRigUnit_TransformConstraint._ScriptStructPtr);
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x000885A5 File Offset: 0x000867A5
		// (set) Token: 0x06005F26 RID: 24358 RVA: 0x000885B9 File Offset: 0x000867B9
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x000885CE File Offset: 0x000867CE
		// (set) Token: 0x06005F28 RID: 24360 RVA: 0x000885DE File Offset: 0x000867DE
		public unsafe ETransformSpaceMode BaseTransformSpace
		{
			get
			{
				return (ETransformSpaceMode)(*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseTransformSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseTransformSpace) = (byte)value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x000885EF File Offset: 0x000867EF
		// (set) Token: 0x06005F2A RID: 24362 RVA: 0x00088603 File Offset: 0x00086803
		public unsafe FTransform BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseTransform) = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x00088618 File Offset: 0x00086818
		// (set) Token: 0x06005F2C RID: 24364 RVA: 0x0008862C File Offset: 0x0008682C
		public unsafe FName BaseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_BaseBone) = value;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06005F2D RID: 24365 RVA: 0x00088644 File Offset: 0x00086844
		// (set) Token: 0x06005F2E RID: 24366 RVA: 0x00088687 File Offset: 0x00086887
		public TArray<FConstraintTarget> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraintTarget> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FConstraintTarget>(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x00088695 File Offset: 0x00086895
		// (set) Token: 0x06005F30 RID: 24368 RVA: 0x000886A5 File Offset: 0x000868A5
		public unsafe bool bUseInitialTransforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_bUseInitialTransforms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_bUseInitialTransforms) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x000886B8 File Offset: 0x000868B8
		// (set) Token: 0x06005F32 RID: 24370 RVA: 0x000886FB File Offset: 0x000868FB
		public FRigUnit_TransformConstraint_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TransformConstraint_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_TransformConstraint_WorkData(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TransformConstraint_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TransformConstraint.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x0008871C File Offset: 0x0008691C
		public FRigUnit_TransformConstraint()
		{
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00088724 File Offset: 0x00086924
		public FRigUnit_TransformConstraint(FName Bone, ETransformSpaceMode BaseTransformSpace, FTransform BaseTransform, FName BaseBone, TArray<FConstraintTarget> Targets, bool bUseInitialTransforms, FRigUnit_TransformConstraint_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.BaseTransformSpace = BaseTransformSpace;
			this.BaseTransform = BaseTransform;
			this.BaseBone = BaseBone;
			this.Targets = Targets;
			this.bUseInitialTransforms = bUseInitialTransforms;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x00088774 File Offset: 0x00086974
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TransformConstraint.StaticStruct();
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00088780 File Offset: 0x00086980
		[NullableContext(2)]
		public FRigUnit_TransformConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0008878A File Offset: 0x0008698A
		public FRigUnit_TransformConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00088795 File Offset: 0x00086995
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TransformConstraint(Pointer, false, true);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x0008879F File Offset: 0x0008699F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TransformConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04002C75 RID: 11381
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TransformConstraint";

		// Token: 0x04002C76 RID: 11382
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C77 RID: 11383
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002C78 RID: 11384
		internal static int __PropertyOffset_BaseTransformSpace;

		// Token: 0x04002C79 RID: 11385
		internal static int __PropertyOffset_BaseTransform;

		// Token: 0x04002C7A RID: 11386
		internal static int __PropertyOffset_BaseBone;

		// Token: 0x04002C7B RID: 11387
		internal static int __PropertyOffset_Targets;

		// Token: 0x04002C7C RID: 11388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraintTarget> _Targets;

		// Token: 0x04002C7D RID: 11389
		internal static int __PropertyOffset_bUseInitialTransforms;

		// Token: 0x04002C7E RID: 11390
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002C7F RID: 11391
		[Nullable(2)]
		private FRigUnit_TransformConstraint_WorkData _WorkData;
	}
}
