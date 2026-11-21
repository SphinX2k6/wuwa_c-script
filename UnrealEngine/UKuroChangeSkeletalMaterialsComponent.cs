using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B8 RID: 1208
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroChangeSkeletalMaterialsComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F40 RID: 28480 RVA: 0x000A4A62 File Offset: 0x000A2C62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroChangeSkeletalMaterialsComponent._ClassPtr;
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x000A4A70 File Offset: 0x000A2C70
		public UKuroChangeSkeletalMaterialsComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroChangeSkeletalMaterialsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x000A4A98 File Offset: 0x000A2C98
		[NullableContext(1)]
		public UKuroChangeSkeletalMaterialsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroChangeSkeletalMaterialsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x000A4ACB File Offset: 0x000A2CCB
		[NullableContext(2)]
		public void ChangeMaterialsWithTextures(USkeletalMeshComponent SkeletalMeshComponent, FName ParameterName, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TArray<TSoftObjectPtr<UTexture2D>> Textures)
		{
			UKuroChangeSkeletalMaterialsComponent.__ChangeMaterialsWithTextures_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, ParameterName, (Textures ?? new TArray<TSoftObjectPtr<UTexture2D>>()).NativePtr);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x000A4AF9 File Offset: 0x000A2CF9
		[NullableContext(2)]
		public void ChangeMaterialsWithDataAsset(UKuroChangeMaterialsTextures DataAsset)
		{
			UKuroChangeSkeletalMaterialsComponent.__ChangeMaterialsWithDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x000A4B16 File Offset: 0x000A2D16
		public void CancelChangeMaterials()
		{
			UKuroChangeSkeletalMaterialsComponent.__CancelChangeMaterials_Internal(base.NativePtr);
		}

		// Token: 0x06006F46 RID: 28486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeMaterialsWithTextures_Internal(IntPtr @this, IntPtr SkeletalMeshComponent, FName ParameterName, IntPtr Textures);

		// Token: 0x06006F47 RID: 28487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeMaterialsWithDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x06006F48 RID: 28488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelChangeMaterials_Internal(IntPtr @this);

		// Token: 0x06006F49 RID: 28489 RVA: 0x000A4B23 File Offset: 0x000A2D23
		static UKuroChangeSkeletalMaterialsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent");
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x000A4B31 File Offset: 0x000A2D31
		protected UKuroChangeSkeletalMaterialsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003021 RID: 12321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent";

		// Token: 0x04003022 RID: 12322
		private static IntPtr _ClassPtr;

		// Token: 0x04003023 RID: 12323
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
