using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200168D RID: 5773
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroAudioMaterialSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F38 RID: 85816 RVA: 0x001ECC5E File Offset: 0x001EAE5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioMaterialSubsystem._ClassPtr;
		}

		// Token: 0x06014F39 RID: 85817 RVA: 0x001ECC6C File Offset: 0x001EAE6C
		public UKuroAudioMaterialSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F3A RID: 85818 RVA: 0x001ECC94 File Offset: 0x001EAE94
		[NullableContext(1)]
		public UKuroAudioMaterialSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014F3B RID: 85819 RVA: 0x001ECCC8 File Offset: 0x001EAEC8
		[NullableContext(2)]
		public unsafe bool QueryOverlapAnyFoliageInstance(FBox InQueryBounds, ref FName OutInstancedNames, ref UPhysicalMaterial OutPhysicalMaterial, ref UStaticMeshComponent OutStaicMeshComponent)
		{
			UPhysicalMaterial uphysicalMaterial = OutPhysicalMaterial;
			IntPtr nativeObjectPtr = (uphysicalMaterial != null) ? uphysicalMaterial.NativePtr : IntPtr.Zero;
			UStaticMeshComponent ustaticMeshComponent = OutStaicMeshComponent;
			IntPtr nativeObjectPtr2 = (ustaticMeshComponent != null) ? ustaticMeshComponent.NativePtr : IntPtr.Zero;
			fixed (FName* ptr = &OutInstancedNames)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroAudioMaterialSubsystem.__QueryOverlapAnyFoliageInstance_Internal(base.NativePtr, InQueryBounds, ref OutInstancedNames, ref nativeObjectPtr, ref nativeObjectPtr2);
				OutPhysicalMaterial = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(nativeObjectPtr);
				OutStaicMeshComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshComponent>(nativeObjectPtr2);
				return result;
			}
		}

		// Token: 0x06014F3C RID: 85820 RVA: 0x001ECD24 File Offset: 0x001EAF24
		[NullableContext(2)]
		public unsafe bool QueryInsideAnyFoliageInstance(FVectorDouble InQueryLocation, ref FName OutInstancedNames, ref UPhysicalMaterial OutPhysicalMaterial, ref UStaticMeshComponent OutStaicMeshComponent)
		{
			UPhysicalMaterial uphysicalMaterial = OutPhysicalMaterial;
			IntPtr nativeObjectPtr = (uphysicalMaterial != null) ? uphysicalMaterial.NativePtr : IntPtr.Zero;
			UStaticMeshComponent ustaticMeshComponent = OutStaicMeshComponent;
			IntPtr nativeObjectPtr2 = (ustaticMeshComponent != null) ? ustaticMeshComponent.NativePtr : IntPtr.Zero;
			fixed (FName* ptr = &OutInstancedNames)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroAudioMaterialSubsystem.__QueryInsideAnyFoliageInstance_Internal(base.NativePtr, InQueryLocation, ref OutInstancedNames, ref nativeObjectPtr, ref nativeObjectPtr2);
				OutPhysicalMaterial = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(nativeObjectPtr);
				OutStaicMeshComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshComponent>(nativeObjectPtr2);
				return result;
			}
		}

		// Token: 0x06014F3D RID: 85821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __QueryOverlapAnyFoliageInstance_Internal(IntPtr @this, FBox InQueryBounds, ref FName OutInstancedNames, ref IntPtr OutPhysicalMaterial, ref IntPtr OutStaicMeshComponent);

		// Token: 0x06014F3E RID: 85822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __QueryInsideAnyFoliageInstance_Internal(IntPtr @this, FVectorDouble InQueryLocation, ref FName OutInstancedNames, ref IntPtr OutPhysicalMaterial, ref IntPtr OutStaicMeshComponent);

		// Token: 0x06014F3F RID: 85823 RVA: 0x001ECD7F File Offset: 0x001EAF7F
		static UKuroAudioMaterialSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem");
		}

		// Token: 0x06014F40 RID: 85824 RVA: 0x001ECD8D File Offset: 0x001EAF8D
		protected UKuroAudioMaterialSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B69A RID: 46746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem";

		// Token: 0x0400B69B RID: 46747
		private static IntPtr _ClassPtr;

		// Token: 0x0400B69C RID: 46748
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
