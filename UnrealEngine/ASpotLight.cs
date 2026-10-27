using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001180 RID: 4480
	[UnrealObjectPath("/Script/Engine.SpotLight")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ASpotLight : ALight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010764 RID: 67428 RVA: 0x00182C59 File Offset: 0x00180E59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASpotLight._ClassPtr;
		}

		// Token: 0x06010765 RID: 67429 RVA: 0x00182C68 File Offset: 0x00180E68
		public ASpotLight() : this(BuiltinUtils.AllocNativeUObject(ASpotLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010766 RID: 67430 RVA: 0x00182C90 File Offset: 0x00180E90
		[NullableContext(1)]
		public ASpotLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASpotLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x06010767 RID: 67431 RVA: 0x00182CC3 File Offset: 0x00180EC3
		// (set) Token: 0x06010768 RID: 67432 RVA: 0x00182CD7 File Offset: 0x00180ED7
		[Nullable(2)]
		public unsafe USpotLightComponent SpotLightComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASpotLight.__PropertyOffset_SpotLightComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASpotLight.__PropertyOffset_SpotLightComponent, value);
			}
		}

		// Token: 0x06010769 RID: 67433 RVA: 0x00182CEC File Offset: 0x00180EEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetOuterConeAngle(float NewOuterConeAngle)
		{
			ASpotLight.__SetOuterConeAngle_FunctionParams* ptr = stackalloc ASpotLight.__SetOuterConeAngle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ASpotLight.__SetOuterConeAngle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ASpotLight.__SetOuterConeAngle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewOuterConeAngle = NewOuterConeAngle;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ASpotLight.__SetOuterConeAngle_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601076A RID: 67434 RVA: 0x00182D34 File Offset: 0x00180F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInnerConeAngle(float NewInnerConeAngle)
		{
			ASpotLight.__SetInnerConeAngle_FunctionParams* ptr = stackalloc ASpotLight.__SetInnerConeAngle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ASpotLight.__SetInnerConeAngle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ASpotLight.__SetInnerConeAngle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewInnerConeAngle = NewInnerConeAngle;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ASpotLight.__SetInnerConeAngle_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601076B RID: 67435 RVA: 0x00182D7B File Offset: 0x00180F7B
		static ASpotLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpotLight");
		}

		// Token: 0x0601076C RID: 67436 RVA: 0x00182D89 File Offset: 0x00180F89
		protected ASpotLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CDF RID: 36063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpotLight";

		// Token: 0x04008CE0 RID: 36064
		private static IntPtr _ClassPtr;

		// Token: 0x04008CE1 RID: 36065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008CE2 RID: 36066
		internal static int __PropertyOffset_SpotLightComponent;

		// Token: 0x04008CE3 RID: 36067
		private static IntPtr __SetOuterConeAngle_NativeFunctionPtr;

		// Token: 0x04008CE4 RID: 36068
		private static IntPtr __SetInnerConeAngle_NativeFunctionPtr;

		// Token: 0x02002DE4 RID: 11748
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetOuterConeAngle_FunctionParams
		{
			// Token: 0x04016827 RID: 92199
			[FieldOffset(0)]
			public float NewOuterConeAngle;
		}

		// Token: 0x02002DE5 RID: 11749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetInnerConeAngle_FunctionParams
		{
			// Token: 0x04016828 RID: 92200
			[FieldOffset(0)]
			public float NewInnerConeAngle;
		}
	}
}
