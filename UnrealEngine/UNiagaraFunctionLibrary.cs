using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025AA RID: 9642
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023CF0 RID: 146672 RVA: 0x0034F3D0 File Offset: 0x0034D5D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraFunctionLibrary._ClassPtr;
		}

		// Token: 0x06023CF1 RID: 146673 RVA: 0x0034F3DC File Offset: 0x0034D5DC
		public UNiagaraFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CF2 RID: 146674 RVA: 0x0034F404 File Offset: 0x0034D604
		[NullableContext(1)]
		public UNiagaraFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023CF3 RID: 146675 RVA: 0x0034F438 File Offset: 0x0034D638
		public static UNiagaraComponent SpawnSystemAttached(UNiagaraSystem SystemTemplate, USceneComponent AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bAutoDestroy, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = ENCPoolMethod.None, bool bPreCullCheck = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(UNiagaraFunctionLibrary.__SpawnSystemAttached_Internal((SystemTemplate != null) ? SystemTemplate.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck));
		}

		// Token: 0x06023CF4 RID: 146676 RVA: 0x0034F484 File Offset: 0x0034D684
		public static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject, UNiagaraSystem SystemTemplate, FVector Location, FRotator Rotation = default(FRotator), FVector? Scale = null, bool bAutoDestroy = true, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = ENCPoolMethod.None, bool bPreCullCheck = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(UNiagaraFunctionLibrary.__SpawnSystemAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SystemTemplate != null) ? SystemTemplate.NativePtr : IntPtr.Zero, Location, Rotation, Scale ?? new FVector(1f, 1f, 1f), bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck));
		}

		// Token: 0x06023CF5 RID: 146677 RVA: 0x0034F4F0 File Offset: 0x0034D6F0
		public unsafe static void SetVolumeTextureObject(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UVolumeTexture Texture)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetVolumeTextureObject_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CF6 RID: 146678 RVA: 0x0034F534 File Offset: 0x0034D734
		public unsafe static void SetTextureObjectV2(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UTexture Texture)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetTextureObjectV2_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CF7 RID: 146679 RVA: 0x0034F578 File Offset: 0x0034D778
		public unsafe static void SetTextureObject(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UTexture Texture)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetTextureObject_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CF8 RID: 146680 RVA: 0x0034F5BC File Offset: 0x0034D7BC
		public unsafe static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, in TArray<FName> SamplingRegions)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetSkeletalMeshDataInterfaceSamplingRegions_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SamplingRegions ?? new TArray<FName>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CF9 RID: 146681 RVA: 0x0034F600 File Offset: 0x0034D800
		public unsafe static bool SetNiagaraEmitterMesh(UNiagaraSystem System, [Nullable(1)] string EmitterName, UStaticMesh NewMesh, int MeshIndex)
		{
			FString fstring = FString.AllocTemp(EmitterName);
			bool result = UNiagaraFunctionLibrary.__SetNiagaraEmitterMesh_Internal((System != null) ? System.NativePtr : IntPtr.Zero, fstring, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero, MeshIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023CFA RID: 146682 RVA: 0x0034F648 File Offset: 0x0034D848
		public unsafe static bool SetNiagaraEmitterMaterial(UNiagaraSystem System, [Nullable(1)] string EmitterName, UMaterialInterface Material, int MaterialIndex)
		{
			FString fstring = FString.AllocTemp(EmitterName);
			bool result = UNiagaraFunctionLibrary.__SetNiagaraEmitterMaterial_Internal((System != null) ? System.NativePtr : IntPtr.Zero, fstring, (Material != null) ? Material.NativePtr : IntPtr.Zero, MaterialIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023CFB RID: 146683 RVA: 0x0034F690 File Offset: 0x0034D890
		public unsafe static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UStaticMeshComponent StaticMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableStaticMeshComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CFC RID: 146684 RVA: 0x0034F6D4 File Offset: 0x0034D8D4
		public unsafe static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UStaticMesh StaticMesh)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableStaticMesh_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CFD RID: 146685 RVA: 0x0034F718 File Offset: 0x0034D918
		public unsafe static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableSkeletalMeshComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023CFE RID: 146686 RVA: 0x0034F75C File Offset: 0x0034D95C
		public static void MarkNiagaraScalabilityNeedUpdate(UObject WorldContextObject)
		{
			UNiagaraFunctionLibrary.__MarkNiagaraScalabilityNeedUpdate_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06023CFF RID: 146687 RVA: 0x0034F773 File Offset: 0x0034D973
		public static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(UObject WorldContextObject, UNiagaraParameterCollection Collection)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraParameterCollectionInstance>(UNiagaraFunctionLibrary.__GetNiagaraParameterCollection_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06023D00 RID: 146688 RVA: 0x0034F79F File Offset: 0x0034D99F
		[NullableContext(1)]
		public static FNiagaraGlobalInfoInHUD GetGlobalInfo()
		{
			return new FNiagaraGlobalInfoInHUD(UNiagaraFunctionLibrary.__GetGlobalInfo_Internal(), null);
		}

		// Token: 0x06023D01 RID: 146689
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnSystemAttached_Internal(IntPtr SystemTemplate, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck);

		// Token: 0x06023D02 RID: 146690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnSystemAtLocation_Internal(IntPtr WorldContextObject, IntPtr SystemTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck);

		// Token: 0x06023D03 RID: 146691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumeTextureObject_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr Texture);

		// Token: 0x06023D04 RID: 146692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureObjectV2_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr Texture);

		// Token: 0x06023D05 RID: 146693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureObject_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr Texture);

		// Token: 0x06023D06 RID: 146694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshDataInterfaceSamplingRegions_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SamplingRegions);

		// Token: 0x06023D07 RID: 146695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraEmitterMesh_Internal(IntPtr System, in FString EmitterName, IntPtr NewMesh, int MeshIndex);

		// Token: 0x06023D08 RID: 146696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraEmitterMaterial_Internal(IntPtr System, in FString EmitterName, IntPtr Material, int MaterialIndex);

		// Token: 0x06023D09 RID: 146697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableStaticMeshComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr StaticMeshComponent);

		// Token: 0x06023D0A RID: 146698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableStaticMesh_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr StaticMesh);

		// Token: 0x06023D0B RID: 146699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableSkeletalMeshComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SkeletalMeshComponent);

		// Token: 0x06023D0C RID: 146700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkNiagaraScalabilityNeedUpdate_Internal(IntPtr WorldContextObject);

		// Token: 0x06023D0D RID: 146701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParameterCollection_Internal(IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06023D0E RID: 146702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalInfo_Internal();

		// Token: 0x06023D0F RID: 146703 RVA: 0x0034F7AC File Offset: 0x0034D9AC
		static UNiagaraFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraFunctionLibrary");
		}

		// Token: 0x06023D10 RID: 146704 RVA: 0x0034F7BA File Offset: 0x0034D9BA
		protected UNiagaraFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013343 RID: 78659
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraFunctionLibrary";

		// Token: 0x04013344 RID: 78660
		private static IntPtr _ClassPtr;

		// Token: 0x04013345 RID: 78661
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
