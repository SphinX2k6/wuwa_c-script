using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000266 RID: 614
	[UnrealObjectPath("/Script/Engine.PoseableMeshComponent")]
	[UnrealStructLayout(3072, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3072)]
	public class UPoseableMeshComponent : USkinnedMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060036A9 RID: 13993 RVA: 0x0004D054 File Offset: 0x0004B254
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPoseableMeshComponent._ClassPtr;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0004D060 File Offset: 0x0004B260
		public UPoseableMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UPoseableMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0004D088 File Offset: 0x0004B288
		[NullableContext(1)]
		public UPoseableMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPoseableMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0004D0BB File Offset: 0x0004B2BB
		public void ResetBoneTransformByName(FName BoneName)
		{
			UPoseableMeshComponent.__ResetBoneTransformByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0004D0C9 File Offset: 0x0004B2C9
		[NullableContext(2)]
		public void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy)
		{
			UPoseableMeshComponent.__CopyPoseFromSkeletalComponent_Internal(base.NativePtr, (InComponentToCopy != null) ? InComponentToCopy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0004D0E6 File Offset: 0x0004B2E6
		[NullableContext(2)]
		public void CopyPoseFromOtherPoseableComponent(UPoseableMeshComponent InComponentToCopy)
		{
			UPoseableMeshComponent.__CopyPoseFromOtherPoseableComponent_Internal(base.NativePtr, (InComponentToCopy != null) ? InComponentToCopy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060036AF RID: 13999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBoneTransformByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x060036B0 RID: 14000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyPoseFromSkeletalComponent_Internal(IntPtr @this, IntPtr InComponentToCopy);

		// Token: 0x060036B1 RID: 14001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyPoseFromOtherPoseableComponent_Internal(IntPtr @this, IntPtr InComponentToCopy);

		// Token: 0x060036B2 RID: 14002 RVA: 0x0004D103 File Offset: 0x0004B303
		static UPoseableMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PoseableMeshComponent");
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0004D111 File Offset: 0x0004B311
		protected UPoseableMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040012D6 RID: 4822
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PoseableMeshComponent";

		// Token: 0x040012D7 RID: 4823
		private static IntPtr _ClassPtr;

		// Token: 0x040012D8 RID: 4824
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
