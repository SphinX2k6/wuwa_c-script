using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000491 RID: 1169
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UClothingSimulationInteractor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x0005E4FD File Offset: 0x0005C6FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingSimulationInteractor._ClassPtr;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0005E509 File Offset: 0x0005C709
		public void SetAnimDriveSpringStiffness(float InStiffness)
		{
			UClothingSimulationInteractor.__SetAnimDriveSpringStiffness_Internal(base.NativePtr, InStiffness);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0005E517 File Offset: 0x0005C717
		public void PhysicsAssetUpdated()
		{
			UClothingSimulationInteractor.__PhysicsAssetUpdated_Internal(base.NativePtr);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0005E524 File Offset: 0x0005C724
		public float GetSimulationTime()
		{
			return UClothingSimulationInteractor.__GetSimulationTime_Internal(base.NativePtr);
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x0005E531 File Offset: 0x0005C731
		public int GetNumSubsteps()
		{
			return UClothingSimulationInteractor.__GetNumSubsteps_Internal(base.NativePtr);
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0005E53E File Offset: 0x0005C73E
		public int GetNumKinematicParticles()
		{
			return UClothingSimulationInteractor.__GetNumKinematicParticles_Internal(base.NativePtr);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0005E54B File Offset: 0x0005C74B
		public int GetNumIterations()
		{
			return UClothingSimulationInteractor.__GetNumIterations_Internal(base.NativePtr);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0005E558 File Offset: 0x0005C758
		public int GetNumDynamicParticles()
		{
			return UClothingSimulationInteractor.__GetNumDynamicParticles_Internal(base.NativePtr);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x0005E565 File Offset: 0x0005C765
		public int GetNumCloths()
		{
			return UClothingSimulationInteractor.__GetNumCloths_Internal(base.NativePtr);
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0005E572 File Offset: 0x0005C772
		public void EnableGravityOverride(in FVector InVector)
		{
			UClothingSimulationInteractor.__EnableGravityOverride_Internal(base.NativePtr, InVector);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0005E580 File Offset: 0x0005C780
		public void DisableGravityOverride()
		{
			UClothingSimulationInteractor.__DisableGravityOverride_Internal(base.NativePtr);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0005E58D File Offset: 0x0005C78D
		public void ClothConfigUpdated()
		{
			UClothingSimulationInteractor.__ClothConfigUpdated_Internal(base.NativePtr);
		}

		// Token: 0x06003EC6 RID: 16070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimDriveSpringStiffness_Internal(IntPtr @this, float InStiffness);

		// Token: 0x06003EC7 RID: 16071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhysicsAssetUpdated_Internal(IntPtr @this);

		// Token: 0x06003EC8 RID: 16072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSimulationTime_Internal(IntPtr @this);

		// Token: 0x06003EC9 RID: 16073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSubsteps_Internal(IntPtr @this);

		// Token: 0x06003ECA RID: 16074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumKinematicParticles_Internal(IntPtr @this);

		// Token: 0x06003ECB RID: 16075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumIterations_Internal(IntPtr @this);

		// Token: 0x06003ECC RID: 16076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumDynamicParticles_Internal(IntPtr @this);

		// Token: 0x06003ECD RID: 16077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumCloths_Internal(IntPtr @this);

		// Token: 0x06003ECE RID: 16078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableGravityOverride_Internal(IntPtr @this, in FVector InVector);

		// Token: 0x06003ECF RID: 16079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableGravityOverride_Internal(IntPtr @this);

		// Token: 0x06003ED0 RID: 16080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClothConfigUpdated_Internal(IntPtr @this);

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0005E59A File Offset: 0x0005C79A
		static UClothingSimulationInteractor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor");
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		protected UClothingSimulationInteractor() : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationInteractor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0005E5D0 File Offset: 0x0005C7D0
		protected UClothingSimulationInteractor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D96 RID: 7574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor";

		// Token: 0x04001D97 RID: 7575
		private static IntPtr _ClassPtr;

		// Token: 0x04001D98 RID: 7576
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
