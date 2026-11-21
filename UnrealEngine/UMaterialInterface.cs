using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023D RID: 573
	[UnrealObjectPath("/Script/Engine.MaterialInterface")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public abstract class UMaterialInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003130 RID: 12592 RVA: 0x00046122 File Offset: 0x00044322
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInterface._ClassPtr;
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x0004612E File Offset: 0x0004432E
		public void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups = 0, bool bFastResponse = false)
		{
			UMaterialInterface.__SetForceMipLevelsToBeResident_Internal(base.NativePtr, OverrideForceMiplevelsToBeResident, bForceMiplevelsToBeResidentValue, ForceDuration, CinematicTextureGroups, bFastResponse);
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00046144 File Offset: 0x00044344
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UPhysicalMaterial GetPhysicalMaterialFromMap(int Index)
		{
			UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams* ptr = stackalloc UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInterface.__GetPhysicalMaterialFromMap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInterface.__GetPhysicalMaterialFromMap_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(ptr->__Result);
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00046198 File Offset: 0x00044398
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UPhysicalMaterial GetPhysicalMaterial()
		{
			UMaterialInterface.__GetPhysicalMaterial_FunctionParams* ptr = stackalloc UMaterialInterface.__GetPhysicalMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMaterialInterface.__GetPhysicalMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInterface.__GetPhysicalMaterial_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInterface.__GetPhysicalMaterial_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(ptr->__Result);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000461E2 File Offset: 0x000443E2
		[NullableContext(2)]
		public UMaterial GetBaseMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterial>(UMaterialInterface.__GetBaseMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06003135 RID: 12597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceMipLevelsToBeResident_Internal(IntPtr @this, bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups, bool bFastResponse);

		// Token: 0x06003136 RID: 12598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBaseMaterial_Internal(IntPtr @this);

		// Token: 0x06003137 RID: 12599 RVA: 0x000461F4 File Offset: 0x000443F4
		static UMaterialInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInterface");
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00046204 File Offset: 0x00044404
		protected UMaterialInterface() : this(BuiltinUtils.AllocNativeUObject(UMaterialInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0004622C File Offset: 0x0004442C
		protected UMaterialInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010D6 RID: 4310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInterface";

		// Token: 0x040010D7 RID: 4311
		private static IntPtr _ClassPtr;

		// Token: 0x040010D8 RID: 4312
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040010D9 RID: 4313
		private static IntPtr __GetPhysicalMaterialFromMap_NativeFunctionPtr;

		// Token: 0x040010DA RID: 4314
		private static IntPtr __GetPhysicalMaterial_NativeFunctionPtr;

		// Token: 0x020009BD RID: 2493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPhysicalMaterialFromMap_FunctionParams
		{
			// Token: 0x04005947 RID: 22855
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04005948 RID: 22856
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x020009BE RID: 2494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPhysicalMaterial_FunctionParams
		{
			// Token: 0x04005949 RID: 22857
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
