using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200101B RID: 4123
	[UnrealObjectPath("/Script/Engine.PoseableMeshComponent")]
	[UnrealStructLayout(3072, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3072)]
	public class UPoseableMeshComponent : USkinnedMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E18A RID: 57738 RVA: 0x0014B7E4 File Offset: 0x001499E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPoseableMeshComponent._ClassPtr;
		}

		// Token: 0x0600E18B RID: 57739 RVA: 0x0014B7F0 File Offset: 0x001499F0
		public UPoseableMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UPoseableMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x0014B818 File Offset: 0x00149A18
		[NullableContext(1)]
		public UPoseableMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPoseableMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x0014B84C File Offset: 0x00149A4C
		public unsafe void SetBoneTransformByName(FName BoneName, in FTransform InTransform, EBoneSpaces BoneSpace)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			UPoseableMeshComponent.__SetBoneTransformByName_Internal(base.NativePtr, BoneName, ptr, BoneSpace);
		}

		// Token: 0x0600E18E RID: 57742 RVA: 0x0014B888 File Offset: 0x00149A88
		public void SetBoneScaleByName(FName BoneName, FVector InScale3D, EBoneSpaces BoneSpace)
		{
			UPoseableMeshComponent.__SetBoneScaleByName_Internal(base.NativePtr, BoneName, InScale3D, BoneSpace);
		}

		// Token: 0x0600E18F RID: 57743 RVA: 0x0014B89D File Offset: 0x00149A9D
		public void SetBoneRotationByName(FName BoneName, FRotator InRotation, EBoneSpaces BoneSpace)
		{
			UPoseableMeshComponent.__SetBoneRotationByName_Internal(base.NativePtr, BoneName, InRotation, BoneSpace);
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x0014B8B2 File Offset: 0x00149AB2
		public void SetBoneLocationByName(FName BoneName, FVector InLocation, EBoneSpaces BoneSpace)
		{
			UPoseableMeshComponent.__SetBoneLocationByName_Internal(base.NativePtr, BoneName, InLocation, BoneSpace);
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x0014B8C7 File Offset: 0x00149AC7
		public void ResetBoneTransformByName(FName BoneName)
		{
			UPoseableMeshComponent.__ResetBoneTransformByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600E192 RID: 57746 RVA: 0x0014B8D5 File Offset: 0x00149AD5
		public FTransform GetBoneTransformByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			return UPoseableMeshComponent.__GetBoneTransformByName_Internal(base.NativePtr, BoneName, BoneSpace);
		}

		// Token: 0x0600E193 RID: 57747 RVA: 0x0014B8E9 File Offset: 0x00149AE9
		public FVector GetBoneScaleByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			return UPoseableMeshComponent.__GetBoneScaleByName_Internal(base.NativePtr, BoneName, BoneSpace);
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x0014B8FD File Offset: 0x00149AFD
		public FRotator GetBoneRotationByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			return UPoseableMeshComponent.__GetBoneRotationByName_Internal(base.NativePtr, BoneName, BoneSpace);
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x0014B911 File Offset: 0x00149B11
		public FVector GetBoneLocationByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			return UPoseableMeshComponent.__GetBoneLocationByName_Internal(base.NativePtr, BoneName, BoneSpace);
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x0014B925 File Offset: 0x00149B25
		[NullableContext(2)]
		public void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy)
		{
			UPoseableMeshComponent.__CopyPoseFromSkeletalComponent_Internal(base.NativePtr, (InComponentToCopy != null) ? InComponentToCopy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600E197 RID: 57751 RVA: 0x0014B942 File Offset: 0x00149B42
		[NullableContext(2)]
		public void CopyPoseFromOtherPoseableComponent(UPoseableMeshComponent InComponentToCopy)
		{
			UPoseableMeshComponent.__CopyPoseFromOtherPoseableComponent_Internal(base.NativePtr, (InComponentToCopy != null) ? InComponentToCopy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600E198 RID: 57752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneTransformByName_Internal(IntPtr @this, FName BoneName, in FTransform InTransform, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E199 RID: 57753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneScaleByName_Internal(IntPtr @this, FName BoneName, FVector InScale3D, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E19A RID: 57754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotationByName_Internal(IntPtr @this, FName BoneName, FRotator InRotation, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E19B RID: 57755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneLocationByName_Internal(IntPtr @this, FName BoneName, FVector InLocation, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E19C RID: 57756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBoneTransformByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600E19D RID: 57757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneTransformByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E19E RID: 57758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetBoneScaleByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E19F RID: 57759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBoneRotationByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E1A0 RID: 57760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetBoneLocationByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EBoneSpaces> BoneSpace);

		// Token: 0x0600E1A1 RID: 57761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyPoseFromSkeletalComponent_Internal(IntPtr @this, IntPtr InComponentToCopy);

		// Token: 0x0600E1A2 RID: 57762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyPoseFromOtherPoseableComponent_Internal(IntPtr @this, IntPtr InComponentToCopy);

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x0014B95F File Offset: 0x00149B5F
		static UPoseableMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PoseableMeshComponent");
		}

		// Token: 0x0600E1A4 RID: 57764 RVA: 0x0014B96D File Offset: 0x00149B6D
		protected UPoseableMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400791A RID: 31002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PoseableMeshComponent";

		// Token: 0x0400791B RID: 31003
		private static IntPtr _ClassPtr;

		// Token: 0x0400791C RID: 31004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
