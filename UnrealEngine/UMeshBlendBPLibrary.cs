using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022BF RID: 8895
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMeshBlendBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CA2 RID: 138402 RVA: 0x0031F39F File Offset: 0x0031D59F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshBlendBPLibrary._ClassPtr;
		}

		// Token: 0x06021CA3 RID: 138403 RVA: 0x0031F3AC File Offset: 0x0031D5AC
		public UMeshBlendBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UMeshBlendBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CA4 RID: 138404 RVA: 0x0031F3D4 File Offset: 0x0031D5D4
		[NullableContext(1)]
		public UMeshBlendBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshBlendBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021CA5 RID: 138405 RVA: 0x0031F407 File Offset: 0x0031D607
		public static void SetBlendUserDataOnMesh(UStaticMesh Mesh, EAutoBlendOption NewBlendOption)
		{
			UMeshBlendBPLibrary.__SetBlendUserDataOnMesh_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, NewBlendOption);
		}

		// Token: 0x06021CA6 RID: 138406 RVA: 0x0031F41F File Offset: 0x0031D61F
		public static void SetBlendOptionOnActor(AActor Actor, EAutoBlendOption NewBlendOption)
		{
			UMeshBlendBPLibrary.__SetBlendOptionOnActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, NewBlendOption);
		}

		// Token: 0x06021CA7 RID: 138407 RVA: 0x0031F437 File Offset: 0x0031D637
		public static void RefreshBlendOnActor(AActor Actor, bool bSoftReset)
		{
			UMeshBlendBPLibrary.__RefreshBlendOnActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bSoftReset);
		}

		// Token: 0x06021CA8 RID: 138408 RVA: 0x0031F44F File Offset: 0x0031D64F
		public static void DisableBlendOnActor(AActor Actor)
		{
			UMeshBlendBPLibrary.__DisableBlendOnActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021CA9 RID: 138409 RVA: 0x0031F466 File Offset: 0x0031D666
		public static void ClearBlendUserDataFromMesh(UStaticMesh Mesh)
		{
			UMeshBlendBPLibrary.__ClearBlendUserDataFromMesh_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021CAA RID: 138410 RVA: 0x0031F47D File Offset: 0x0031D67D
		public static void ClearBlendOptionFromActor(AActor Actor)
		{
			UMeshBlendBPLibrary.__ClearBlendOptionFromActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021CAB RID: 138411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlendUserDataOnMesh_Internal(IntPtr Mesh, EAutoBlendOption NewBlendOption);

		// Token: 0x06021CAC RID: 138412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlendOptionOnActor_Internal(IntPtr Actor, EAutoBlendOption NewBlendOption);

		// Token: 0x06021CAD RID: 138413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshBlendOnActor_Internal(IntPtr Actor, bool bSoftReset);

		// Token: 0x06021CAE RID: 138414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableBlendOnActor_Internal(IntPtr Actor);

		// Token: 0x06021CAF RID: 138415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBlendUserDataFromMesh_Internal(IntPtr Mesh);

		// Token: 0x06021CB0 RID: 138416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBlendOptionFromActor_Internal(IntPtr Actor);

		// Token: 0x06021CB1 RID: 138417 RVA: 0x0031F494 File Offset: 0x0031D694
		static UMeshBlendBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendBPLibrary");
		}

		// Token: 0x06021CB2 RID: 138418 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
		protected UMeshBlendBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401207A RID: 73850
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendBPLibrary";

		// Token: 0x0401207B RID: 73851
		private static IntPtr _ClassPtr;

		// Token: 0x0401207C RID: 73852
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
