using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023B RID: 571
	[UnrealObjectPath("/Script/Engine.MaterialInstanceConstant")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1912)]
	public class UMaterialInstanceConstant : UMaterialInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x00045E05 File Offset: 0x00044005
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstanceConstant._ClassPtr;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00045E14 File Offset: 0x00044014
		public UMaterialInstanceConstant() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00045E3C File Offset: 0x0004403C
		[NullableContext(1)]
		public UMaterialInstanceConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00045E70 File Offset: 0x00044070
		[SkipLocalsInit]
		public unsafe FLinearColor K2_GetVectorParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetVectorParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetVectorParameterValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00045EBC File Offset: 0x000440BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UTexture K2_GetTextureParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetTextureParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetTextureParameterValue_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(ptr->__Result);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00045F10 File Offset: 0x00044110
		[SkipLocalsInit]
		public unsafe float K2_GetScalarParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetScalarParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetScalarParameterValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x00045F5C File Offset: 0x0004415C
		static UMaterialInstanceConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstanceConstant");
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00045F6A File Offset: 0x0004416A
		protected UMaterialInstanceConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010CD RID: 4301
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInstanceConstant";

		// Token: 0x040010CE RID: 4302
		private static IntPtr _ClassPtr;

		// Token: 0x040010CF RID: 4303
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040010D0 RID: 4304
		private static IntPtr __K2_GetVectorParameterValue_NativeFunctionPtr;

		// Token: 0x040010D1 RID: 4305
		private static IntPtr __K2_GetTextureParameterValue_NativeFunctionPtr;

		// Token: 0x040010D2 RID: 4306
		private static IntPtr __K2_GetScalarParameterValue_NativeFunctionPtr;

		// Token: 0x020009BA RID: 2490
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __K2_GetVectorParameterValue_FunctionParams
		{
			// Token: 0x04005941 RID: 22849
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04005942 RID: 22850
			[FieldOffset(12)]
			public FLinearColor __Result;
		}

		// Token: 0x020009BB RID: 2491
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_GetTextureParameterValue_FunctionParams
		{
			// Token: 0x04005943 RID: 22851
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04005944 RID: 22852
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020009BC RID: 2492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_GetScalarParameterValue_FunctionParams
		{
			// Token: 0x04005945 RID: 22853
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04005946 RID: 22854
			[FieldOffset(12)]
			public float __Result;
		}
	}
}
