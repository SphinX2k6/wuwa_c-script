using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ABE RID: 6846
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroChangeSkeletalMaterialsComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019638 RID: 103992 RVA: 0x00258426 File Offset: 0x00256626
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroChangeSkeletalMaterialsComponent._ClassPtr;
		}

		// Token: 0x06019639 RID: 103993 RVA: 0x00258434 File Offset: 0x00256634
		public UKuroChangeSkeletalMaterialsComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroChangeSkeletalMaterialsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601963A RID: 103994 RVA: 0x0025845C File Offset: 0x0025665C
		[NullableContext(1)]
		public UKuroChangeSkeletalMaterialsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroChangeSkeletalMaterialsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601963B RID: 103995 RVA: 0x0025848F File Offset: 0x0025668F
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

		// Token: 0x0601963C RID: 103996 RVA: 0x002584BD File Offset: 0x002566BD
		[NullableContext(2)]
		public void ChangeMaterialsWithDataAsset(UKuroChangeMaterialsTextures DataAsset)
		{
			UKuroChangeSkeletalMaterialsComponent.__ChangeMaterialsWithDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601963D RID: 103997 RVA: 0x002584DA File Offset: 0x002566DA
		public void CancelChangeMaterials()
		{
			UKuroChangeSkeletalMaterialsComponent.__CancelChangeMaterials_Internal(base.NativePtr);
		}

		// Token: 0x0601963E RID: 103998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeMaterialsWithTextures_Internal(IntPtr @this, IntPtr SkeletalMeshComponent, FName ParameterName, IntPtr Textures);

		// Token: 0x0601963F RID: 103999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeMaterialsWithDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x06019640 RID: 104000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelChangeMaterials_Internal(IntPtr @this);

		// Token: 0x06019641 RID: 104001 RVA: 0x002584E7 File Offset: 0x002566E7
		static UKuroChangeSkeletalMaterialsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent");
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x002584F5 File Offset: 0x002566F5
		protected UKuroChangeSkeletalMaterialsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD5D RID: 56669
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeSkeletalMaterialsComponent";

		// Token: 0x0400DD5E RID: 56670
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD5F RID: 56671
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
