using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030A RID: 778
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroAudioMaterialSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600532D RID: 21293 RVA: 0x000744F6 File Offset: 0x000726F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioMaterialSubsystem._ClassPtr;
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00074504 File Offset: 0x00072704
		public UKuroAudioMaterialSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x0007452C File Offset: 0x0007272C
		[NullableContext(1)]
		public UKuroAudioMaterialSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00074560 File Offset: 0x00072760
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

		// Token: 0x06005331 RID: 21297 RVA: 0x000745BC File Offset: 0x000727BC
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

		// Token: 0x06005332 RID: 21298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __QueryOverlapAnyFoliageInstance_Internal(IntPtr @this, FBox InQueryBounds, ref FName OutInstancedNames, ref IntPtr OutPhysicalMaterial, ref IntPtr OutStaicMeshComponent);

		// Token: 0x06005333 RID: 21299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __QueryInsideAnyFoliageInstance_Internal(IntPtr @this, FVectorDouble InQueryLocation, ref FName OutInstancedNames, ref IntPtr OutPhysicalMaterial, ref IntPtr OutStaicMeshComponent);

		// Token: 0x06005334 RID: 21300 RVA: 0x00074617 File Offset: 0x00072817
		static UKuroAudioMaterialSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem");
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00074625 File Offset: 0x00072825
		protected UKuroAudioMaterialSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021F9 RID: 8697
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudioMaterial.KuroAudioMaterialSubsystem";

		// Token: 0x040021FA RID: 8698
		private static IntPtr _ClassPtr;

		// Token: 0x040021FB RID: 8699
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
