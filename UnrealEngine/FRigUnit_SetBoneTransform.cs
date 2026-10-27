using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B4 RID: 1716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetBoneTransform")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_SetBoneTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B97 RID: 23447 RVA: 0x0008383D File Offset: 0x00081A3D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetBoneTransform._ScriptStructPtr != 0) ? FRigUnit_SetBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetBoneTransform", ref FRigUnit_SetBoneTransform._ScriptStructPtr);
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x00083861 File Offset: 0x00081A61
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x00083875 File Offset: 0x00081A75
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x0008388A File Offset: 0x00081A8A
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x0008389E File Offset: 0x00081A9E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x000838B3 File Offset: 0x00081AB3
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x000838C7 File Offset: 0x00081AC7
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x000838DC File Offset: 0x00081ADC
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x000838EC File Offset: 0x00081AEC
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x000838FD File Offset: 0x00081AFD
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0008390D File Offset: 0x00081B0D
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x0008391E File Offset: 0x00081B1E
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x0008392E File Offset: 0x00081B2E
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x00083940 File Offset: 0x00081B40
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x00083983 File Offset: 0x00081B83
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x000839A4 File Offset: 0x00081BA4
		public FRigUnit_SetBoneTransform()
		{
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x000839AC File Offset: 0x00081BAC
		public FRigUnit_SetBoneTransform(FName Bone, FTransform Transform, FTransform Result, EBoneGetterSetterMode Space, float Weight, bool bPropagateToChildren, FCachedRigElement CachedBone, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Transform = Transform;
			this.Result = Result;
			this.Space = Space;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x000839FC File Offset: 0x00081BFC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetBoneTransform.StaticStruct();
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00083A08 File Offset: 0x00081C08
		[NullableContext(2)]
		public FRigUnit_SetBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00083A12 File Offset: 0x00081C12
		public FRigUnit_SetBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00083A1D File Offset: 0x00081C1D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetBoneTransform(Pointer, false, true);
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00083A27 File Offset: 0x00081C27
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002AE3 RID: 10979
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetBoneTransform";

		// Token: 0x04002AE4 RID: 10980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AE5 RID: 10981
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002AE6 RID: 10982
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002AE7 RID: 10983
		internal static int __PropertyOffset_Result;

		// Token: 0x04002AE8 RID: 10984
		internal static int __PropertyOffset_Space;

		// Token: 0x04002AE9 RID: 10985
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002AEA RID: 10986
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002AEB RID: 10987
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002AEC RID: 10988
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
