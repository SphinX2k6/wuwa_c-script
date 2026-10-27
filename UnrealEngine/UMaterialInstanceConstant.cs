using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E8C RID: 3724
	[UnrealObjectPath("/Script/Engine.MaterialInstanceConstant")]
	[UnrealStructLayout(1888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class UMaterialInstanceConstant : UMaterialInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C83D RID: 51261 RVA: 0x00123788 File Offset: 0x00121988
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstanceConstant._ClassPtr;
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x00123794 File Offset: 0x00121994
		public UMaterialInstanceConstant() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x001237BC File Offset: 0x001219BC
		[NullableContext(1)]
		public UMaterialInstanceConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600C840 RID: 51264 RVA: 0x001237EF File Offset: 0x001219EF
		// (set) Token: 0x0600C841 RID: 51265 RVA: 0x00123803 File Offset: 0x00121A03
		[Nullable(2)]
		public unsafe UPhysicalMaterialMask PhysMaterialMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterialMask>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstanceConstant.__PropertyOffset_PhysMaterialMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstanceConstant.__PropertyOffset_PhysMaterialMask, value);
			}
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x00123818 File Offset: 0x00121A18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FLinearColor K2_GetVectorParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetVectorParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetVectorParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetVectorParameterValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600C843 RID: 51267 RVA: 0x00123868 File Offset: 0x00121A68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UTexture K2_GetTextureParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetTextureParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetTextureParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetTextureParameterValue_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(ptr->__Result);
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x001238BC File Offset: 0x00121ABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float K2_GetScalarParameterValue(FName ParameterName)
		{
			UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams* ptr = stackalloc UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMaterialInstanceConstant.__K2_GetScalarParameterValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInstanceConstant.__K2_GetScalarParameterValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParameterName = ParameterName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInstanceConstant.__K2_GetScalarParameterValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x00123909 File Offset: 0x00121B09
		static UMaterialInstanceConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstanceConstant");
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x00123917 File Offset: 0x00121B17
		protected UMaterialInstanceConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006BCD RID: 27597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInstanceConstant";

		// Token: 0x04006BCE RID: 27598
		private static IntPtr _ClassPtr;

		// Token: 0x04006BCF RID: 27599
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006BD0 RID: 27600
		internal static int __PropertyOffset_PhysMaterialMask;

		// Token: 0x04006BD1 RID: 27601
		private static IntPtr __K2_GetVectorParameterValue_NativeFunctionPtr;

		// Token: 0x04006BD2 RID: 27602
		private static IntPtr __K2_GetTextureParameterValue_NativeFunctionPtr;

		// Token: 0x04006BD3 RID: 27603
		private static IntPtr __K2_GetScalarParameterValue_NativeFunctionPtr;

		// Token: 0x02002D40 RID: 11584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __K2_GetVectorParameterValue_FunctionParams
		{
			// Token: 0x04016744 RID: 91972
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04016745 RID: 91973
			[FieldOffset(12)]
			public FLinearColor __Result;
		}

		// Token: 0x02002D41 RID: 11585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_GetTextureParameterValue_FunctionParams
		{
			// Token: 0x04016746 RID: 91974
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04016747 RID: 91975
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002D42 RID: 11586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_GetScalarParameterValue_FunctionParams
		{
			// Token: 0x04016748 RID: 91976
			[FieldOffset(0)]
			public FName ParameterName;

			// Token: 0x04016749 RID: 91977
			[FieldOffset(12)]
			public float __Result;
		}
	}
}
