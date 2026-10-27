using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200068F RID: 1679
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyBoneTransforms_PerBone")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_ModifyBoneTransforms_PerBone : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005941 RID: 22849 RVA: 0x00080545 File Offset: 0x0007E745
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyBoneTransforms_PerBone._ScriptStructPtr != 0) ? FRigUnit_ModifyBoneTransforms_PerBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyBoneTransforms_PerBone", ref FRigUnit_ModifyBoneTransforms_PerBone._ScriptStructPtr);
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x00080569 File Offset: 0x0007E769
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x0008057D File Offset: 0x0007E77D
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms_PerBone.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms_PerBone.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x00080592 File Offset: 0x0007E792
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x000805A6 File Offset: 0x0007E7A6
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms_PerBone.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms_PerBone.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x000805BB File Offset: 0x0007E7BB
		public FRigUnit_ModifyBoneTransforms_PerBone()
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x000805C3 File Offset: 0x0007E7C3
		public FRigUnit_ModifyBoneTransforms_PerBone(FName Bone, FTransform Transform)
		{
			this.Bone = Bone;
			this.Transform = Transform;
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x000805D9 File Offset: 0x0007E7D9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyBoneTransforms_PerBone.StaticStruct();
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x000805E5 File Offset: 0x0007E7E5
		[NullableContext(2)]
		public FRigUnit_ModifyBoneTransforms_PerBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x000805EF File Offset: 0x0007E7EF
		public FRigUnit_ModifyBoneTransforms_PerBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x000805FA File Offset: 0x0007E7FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyBoneTransforms_PerBone(Pointer, false, true);
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00080604 File Offset: 0x0007E804
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyBoneTransforms_PerBone(Pointer, MemoryOwner);
		}

		// Token: 0x040029DA RID: 10714
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyBoneTransforms_PerBone";

		// Token: 0x040029DB RID: 10715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029DC RID: 10716
		internal static int __PropertyOffset_Bone;

		// Token: 0x040029DD RID: 10717
		internal static int __PropertyOffset_Transform;
	}
}
