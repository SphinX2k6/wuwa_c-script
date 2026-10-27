using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002469 RID: 9321
	[UnrealObjectPath("/Script/MRMesh.MeshReconstructorBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMeshReconstructorBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E5E RID: 142942 RVA: 0x00339882 File Offset: 0x00337A82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshReconstructorBase._ClassPtr;
		}

		// Token: 0x06022E5F RID: 142943 RVA: 0x00339890 File Offset: 0x00337A90
		public UMeshReconstructorBase() : this(BuiltinUtils.AllocNativeUObject(UMeshReconstructorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E60 RID: 142944 RVA: 0x003398B8 File Offset: 0x00337AB8
		[NullableContext(1)]
		public UMeshReconstructorBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshReconstructorBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022E61 RID: 142945 RVA: 0x003398EB File Offset: 0x00337AEB
		public void StopReconstruction()
		{
			UMeshReconstructorBase.__StopReconstruction_Internal(base.NativePtr);
		}

		// Token: 0x06022E62 RID: 142946 RVA: 0x003398F8 File Offset: 0x00337AF8
		public void StartReconstruction()
		{
			UMeshReconstructorBase.__StartReconstruction_Internal(base.NativePtr);
		}

		// Token: 0x06022E63 RID: 142947 RVA: 0x00339905 File Offset: 0x00337B05
		public void PauseReconstruction()
		{
			UMeshReconstructorBase.__PauseReconstruction_Internal(base.NativePtr);
		}

		// Token: 0x06022E64 RID: 142948 RVA: 0x00339912 File Offset: 0x00337B12
		public bool IsReconstructionStarted()
		{
			return UMeshReconstructorBase.__IsReconstructionStarted_Internal(base.NativePtr);
		}

		// Token: 0x06022E65 RID: 142949 RVA: 0x0033991F File Offset: 0x00337B1F
		public bool IsReconstructionPaused()
		{
			return UMeshReconstructorBase.__IsReconstructionPaused_Internal(base.NativePtr);
		}

		// Token: 0x06022E66 RID: 142950 RVA: 0x0033992C File Offset: 0x00337B2C
		public void DisconnectMRMesh()
		{
			UMeshReconstructorBase.__DisconnectMRMesh_Internal(base.NativePtr);
		}

		// Token: 0x06022E67 RID: 142951 RVA: 0x00339939 File Offset: 0x00337B39
		[NullableContext(2)]
		public void ConnectMRMesh(UMRMeshComponent Mesh)
		{
			UMeshReconstructorBase.__ConnectMRMesh_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06022E68 RID: 142952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopReconstruction_Internal(IntPtr @this);

		// Token: 0x06022E69 RID: 142953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartReconstruction_Internal(IntPtr @this);

		// Token: 0x06022E6A RID: 142954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseReconstruction_Internal(IntPtr @this);

		// Token: 0x06022E6B RID: 142955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReconstructionStarted_Internal(IntPtr @this);

		// Token: 0x06022E6C RID: 142956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReconstructionPaused_Internal(IntPtr @this);

		// Token: 0x06022E6D RID: 142957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisconnectMRMesh_Internal(IntPtr @this);

		// Token: 0x06022E6E RID: 142958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConnectMRMesh_Internal(IntPtr @this, IntPtr Mesh);

		// Token: 0x06022E6F RID: 142959 RVA: 0x00339956 File Offset: 0x00337B56
		static UMeshReconstructorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MRMesh.MeshReconstructorBase");
		}

		// Token: 0x06022E70 RID: 142960 RVA: 0x00339964 File Offset: 0x00337B64
		protected UMeshReconstructorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A17 RID: 76311
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MRMesh.MeshReconstructorBase";

		// Token: 0x04012A18 RID: 76312
		private static IntPtr _ClassPtr;

		// Token: 0x04012A19 RID: 76313
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
