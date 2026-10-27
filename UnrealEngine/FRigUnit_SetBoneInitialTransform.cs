using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B2 RID: 1714
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetBoneInitialTransform")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_SetBoneInitialTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B6F RID: 23407 RVA: 0x000834C5 File Offset: 0x000816C5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetBoneInitialTransform._ScriptStructPtr != 0) ? FRigUnit_SetBoneInitialTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetBoneInitialTransform", ref FRigUnit_SetBoneInitialTransform._ScriptStructPtr);
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x000834E9 File Offset: 0x000816E9
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x000834FD File Offset: 0x000816FD
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x00083512 File Offset: 0x00081712
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x00083526 File Offset: 0x00081726
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x0008353B File Offset: 0x0008173B
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x0008354F File Offset: 0x0008174F
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x00083564 File Offset: 0x00081764
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x00083574 File Offset: 0x00081774
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x00083585 File Offset: 0x00081785
		// (set) Token: 0x06005B79 RID: 23417 RVA: 0x00083595 File Offset: 0x00081795
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x000835A8 File Offset: 0x000817A8
		// (set) Token: 0x06005B7B RID: 23419 RVA: 0x000835EB File Offset: 0x000817EB
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetBoneInitialTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x0008360C File Offset: 0x0008180C
		public FRigUnit_SetBoneInitialTransform()
		{
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00083614 File Offset: 0x00081814
		public FRigUnit_SetBoneInitialTransform(FName Bone, FTransform Transform, FTransform Result, EBoneGetterSetterMode Space, bool bPropagateToChildren, FCachedRigElement CachedBone, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Transform = Transform;
			this.Result = Result;
			this.Space = Space;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00083651 File Offset: 0x00081851
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetBoneInitialTransform.StaticStruct();
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x0008365D File Offset: 0x0008185D
		[NullableContext(2)]
		public FRigUnit_SetBoneInitialTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00083667 File Offset: 0x00081867
		public FRigUnit_SetBoneInitialTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00083672 File Offset: 0x00081872
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetBoneInitialTransform(Pointer, false, true);
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x0008367C File Offset: 0x0008187C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetBoneInitialTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002AD1 RID: 10961
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetBoneInitialTransform";

		// Token: 0x04002AD2 RID: 10962
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AD3 RID: 10963
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002AD4 RID: 10964
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002AD5 RID: 10965
		internal static int __PropertyOffset_Result;

		// Token: 0x04002AD6 RID: 10966
		internal static int __PropertyOffset_Space;

		// Token: 0x04002AD7 RID: 10967
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002AD8 RID: 10968
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002AD9 RID: 10969
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
