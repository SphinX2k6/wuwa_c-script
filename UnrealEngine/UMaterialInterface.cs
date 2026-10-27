using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E8E RID: 3726
	[UnrealObjectPath("/Script/Engine.MaterialInterface")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public abstract class UMaterialInterface : UObject, IUnrealUObject, IUnrealObject, IBlendableInterface, IUnrealNativeInterface, IUnrealInterface, IInterface_AssetUserData
	{
		// Token: 0x0600C870 RID: 51312 RVA: 0x00123BB1 File Offset: 0x00121DB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInterface._ClassPtr;
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x00123BBD File Offset: 0x00121DBD
		int IBlendableInterface.InterfaceOffset()
		{
			return UMaterialInterface.__InterfaceOffset_IBlendableInterface;
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x00123BC4 File Offset: 0x00121DC4
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UMaterialInterface.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600C873 RID: 51315 RVA: 0x00123BCB File Offset: 0x00121DCB
		// (set) Token: 0x0600C874 RID: 51316 RVA: 0x00123BDF File Offset: 0x00121DDF
		[Nullable(2)]
		public unsafe USubsurfaceProfile SubsurfaceProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USubsurfaceProfile>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInterface.__PropertyOffset_SubsurfaceProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInterface.__PropertyOffset_SubsurfaceProfile, value);
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600C875 RID: 51317 RVA: 0x00123BF4 File Offset: 0x00121DF4
		// (set) Token: 0x0600C876 RID: 51318 RVA: 0x00123C2D File Offset: 0x00121E2D
		[Nullable(1)]
		public FLightmassMaterialInterfaceSettings LightmassSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLightmassMaterialInterfaceSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassMaterialInterfaceSettings(base.NativePtr + (IntPtr)UMaterialInterface.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassMaterialInterfaceSettings.StaticStruct(), base.NativePtr + (IntPtr)UMaterialInterface.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600C877 RID: 51319 RVA: 0x00123C50 File Offset: 0x00121E50
		// (set) Token: 0x0600C878 RID: 51320 RVA: 0x00123C89 File Offset: 0x00121E89
		[Nullable(1)]
		public TArray<FMaterialTextureInfo> TextureStreamingData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialTextureInfo> result;
				if ((result = this._TextureStreamingData) == null)
				{
					result = (this._TextureStreamingData = new TArray<FMaterialTextureInfo>(base.NativePtr + (IntPtr)UMaterialInterface.__PropertyOffset_TextureStreamingData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TextureStreamingData.CopyAssign(value);
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600C879 RID: 51321 RVA: 0x00123C98 File Offset: 0x00121E98
		// (set) Token: 0x0600C87A RID: 51322 RVA: 0x00123CD1 File Offset: 0x00121ED1
		[Nullable(1)]
		public TArray<UAssetUserData> AssetUserData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UMaterialInterface.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x00123CDF File Offset: 0x00121EDF
		public void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups = 0, bool bFastResponse = false)
		{
			UMaterialInterface.__SetForceMipLevelsToBeResident_Internal(base.NativePtr, OverrideForceMiplevelsToBeResident, bForceMiplevelsToBeResidentValue, ForceDuration, CinematicTextureGroups, bFastResponse);
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x00123CF4 File Offset: 0x00121EF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UPhysicalMaterialMask GetPhysicalMaterialMask()
		{
			UMaterialInterface.__GetPhysicalMaterialMask_FunctionParams* ptr = stackalloc UMaterialInterface.__GetPhysicalMaterialMask_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMaterialInterface.__GetPhysicalMaterialMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInterface.__GetPhysicalMaterialMask_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInterface.__GetPhysicalMaterialMask_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterialMask>(ptr->__Result);
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x00123D40 File Offset: 0x00121F40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UPhysicalMaterial GetPhysicalMaterialFromMap(int Index)
		{
			UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams* ptr = stackalloc UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMaterialInterface.__GetPhysicalMaterialFromMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInterface.__GetPhysicalMaterialFromMap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInterface.__GetPhysicalMaterialFromMap_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(ptr->__Result);
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x00123D94 File Offset: 0x00121F94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UPhysicalMaterial GetPhysicalMaterial()
		{
			UMaterialInterface.__GetPhysicalMaterial_FunctionParams* ptr = stackalloc UMaterialInterface.__GetPhysicalMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMaterialInterface.__GetPhysicalMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMaterialInterface.__GetPhysicalMaterial_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMaterialInterface.__GetPhysicalMaterial_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(ptr->__Result);
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x00123DDF File Offset: 0x00121FDF
		[NullableContext(1)]
		public FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association, FName ParameterName, [Nullable(2)] UMaterialFunctionInterface LayerFunction)
		{
			return new FMaterialParameterInfo(UMaterialInterface.__GetParameterInfo_Internal(base.NativePtr, Association, ParameterName, (LayerFunction != null) ? LayerFunction.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x00123E09 File Offset: 0x00122009
		[NullableContext(2)]
		public UMaterial GetBaseMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterial>(UMaterialInterface.__GetBaseMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600C881 RID: 51329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceMipLevelsToBeResident_Internal(IntPtr @this, bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups, bool bFastResponse);

		// Token: 0x0600C882 RID: 51330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParameterInfo_Internal(IntPtr @this, TEnumAsByte<EMaterialParameterAssociation> Association, FName ParameterName, IntPtr LayerFunction);

		// Token: 0x0600C883 RID: 51331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBaseMaterial_Internal(IntPtr @this);

		// Token: 0x0600C884 RID: 51332 RVA: 0x00123E1B File Offset: 0x0012201B
		static UMaterialInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInterface");
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00123E2C File Offset: 0x0012202C
		protected UMaterialInterface() : this(BuiltinUtils.AllocNativeUObject(UMaterialInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x00123E54 File Offset: 0x00122054
		protected UMaterialInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006BD7 RID: 27607
		internal static int __InterfaceOffset_IBlendableInterface;

		// Token: 0x04006BD8 RID: 27608
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04006BD9 RID: 27609
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInterface";

		// Token: 0x04006BDA RID: 27610
		private static IntPtr _ClassPtr;

		// Token: 0x04006BDB RID: 27611
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006BDC RID: 27612
		internal static int __PropertyOffset_SubsurfaceProfile;

		// Token: 0x04006BDD RID: 27613
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x04006BDE RID: 27614
		[Nullable(2)]
		private FLightmassMaterialInterfaceSettings _LightmassSettings;

		// Token: 0x04006BDF RID: 27615
		internal static int __PropertyOffset_TextureStreamingData;

		// Token: 0x04006BE0 RID: 27616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialTextureInfo> _TextureStreamingData;

		// Token: 0x04006BE1 RID: 27617
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04006BE2 RID: 27618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x04006BE3 RID: 27619
		private static IntPtr __GetPhysicalMaterialMask_NativeFunctionPtr;

		// Token: 0x04006BE4 RID: 27620
		private static IntPtr __GetPhysicalMaterialFromMap_NativeFunctionPtr;

		// Token: 0x04006BE5 RID: 27621
		private static IntPtr __GetPhysicalMaterial_NativeFunctionPtr;

		// Token: 0x02002D43 RID: 11587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPhysicalMaterialMask_FunctionParams
		{
			// Token: 0x0401674A RID: 91978
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02002D44 RID: 11588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPhysicalMaterialFromMap_FunctionParams
		{
			// Token: 0x0401674B RID: 91979
			[FieldOffset(0)]
			public int Index;

			// Token: 0x0401674C RID: 91980
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002D45 RID: 11589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPhysicalMaterial_FunctionParams
		{
			// Token: 0x0401674D RID: 91981
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
