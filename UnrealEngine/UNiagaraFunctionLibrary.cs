using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A8 RID: 1960
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AA4C RID: 43596 RVA: 0x000FB316 File Offset: 0x000F9516
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x000FB324 File Offset: 0x000F9524
		public UNiagaraFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x000FB34C File Offset: 0x000F954C
		[NullableContext(1)]
		public UNiagaraFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x000FB380 File Offset: 0x000F9580
		public unsafe static void SetTextureObjectV2(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UTexture Texture)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetTextureObjectV2_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x000FB3C4 File Offset: 0x000F95C4
		public unsafe static void SetTextureObject(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UTexture Texture)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetTextureObject_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x000FB408 File Offset: 0x000F9608
		public unsafe static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, in TArray<FName> SamplingRegions)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__SetSkeletalMeshDataInterfaceSamplingRegions_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SamplingRegions ?? new TArray<FName>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x000FB44C File Offset: 0x000F964C
		public unsafe static bool SetNiagaraEmitterMesh(UNiagaraSystem System, [Nullable(1)] string EmitterName, UStaticMesh NewMesh, int MeshIndex)
		{
			FString fstring = FString.AllocTemp(EmitterName);
			bool result = UNiagaraFunctionLibrary.__SetNiagaraEmitterMesh_Internal((System != null) ? System.NativePtr : IntPtr.Zero, fstring, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero, MeshIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x000FB494 File Offset: 0x000F9694
		public unsafe static bool SetNiagaraEmitterMaterial(UNiagaraSystem System, [Nullable(1)] string EmitterName, UMaterialInterface Material, int MaterialIndex)
		{
			FString fstring = FString.AllocTemp(EmitterName);
			bool result = UNiagaraFunctionLibrary.__SetNiagaraEmitterMaterial_Internal((System != null) ? System.NativePtr : IntPtr.Zero, fstring, (Material != null) ? Material.NativePtr : IntPtr.Zero, MaterialIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x000FB4DC File Offset: 0x000F96DC
		public unsafe static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UStaticMeshComponent StaticMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableStaticMeshComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x000FB520 File Offset: 0x000F9720
		public unsafe static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, UStaticMesh StaticMesh)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableStaticMesh_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x000FB564 File Offset: 0x000F9764
		public unsafe static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UNiagaraFunctionLibrary.__OverrideSystemUserVariableSkeletalMeshComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x000FB5A8 File Offset: 0x000F97A8
		public static void MarkNiagaraScalabilityNeedUpdate(UObject WorldContextObject)
		{
			UNiagaraFunctionLibrary.__MarkNiagaraScalabilityNeedUpdate_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x000FB5BF File Offset: 0x000F97BF
		[NullableContext(1)]
		public static TArray<FNiagaraAssetInfoEntry> GetTopNiagaraAssets(int TopN)
		{
			return new TArray<FNiagaraAssetInfoEntry>(UNiagaraFunctionLibrary.__GetTopNiagaraAssets_Internal(TopN), null);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x000FB5CD File Offset: 0x000F97CD
		[NullableContext(1)]
		public static FNiagaraGlobalInfoInHUD GetGlobalInfo()
		{
			return new FNiagaraGlobalInfoInHUD(UNiagaraFunctionLibrary.__GetGlobalInfo_Internal(), null);
		}

		// Token: 0x0600AA5A RID: 43610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureObjectV2_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr Texture);

		// Token: 0x0600AA5B RID: 43611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureObject_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr Texture);

		// Token: 0x0600AA5C RID: 43612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshDataInterfaceSamplingRegions_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SamplingRegions);

		// Token: 0x0600AA5D RID: 43613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraEmitterMesh_Internal(IntPtr System, in FString EmitterName, IntPtr NewMesh, int MeshIndex);

		// Token: 0x0600AA5E RID: 43614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraEmitterMaterial_Internal(IntPtr System, in FString EmitterName, IntPtr Material, int MaterialIndex);

		// Token: 0x0600AA5F RID: 43615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableStaticMeshComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr StaticMeshComponent);

		// Token: 0x0600AA60 RID: 43616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableStaticMesh_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr StaticMesh);

		// Token: 0x0600AA61 RID: 43617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideSystemUserVariableSkeletalMeshComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SkeletalMeshComponent);

		// Token: 0x0600AA62 RID: 43618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkNiagaraScalabilityNeedUpdate_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AA63 RID: 43619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTopNiagaraAssets_Internal(int TopN);

		// Token: 0x0600AA64 RID: 43620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalInfo_Internal();

		// Token: 0x0600AA65 RID: 43621 RVA: 0x000FB5DA File Offset: 0x000F97DA
		static UNiagaraFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraFunctionLibrary");
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x000FB5E8 File Offset: 0x000F97E8
		protected UNiagaraFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048EE RID: 18670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraFunctionLibrary";

		// Token: 0x040048EF RID: 18671
		private static IntPtr _ClassPtr;

		// Token: 0x040048F0 RID: 18672
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
