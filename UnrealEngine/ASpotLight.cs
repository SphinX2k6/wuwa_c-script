using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028B RID: 651
	[UnrealObjectPath("/Script/Engine.SpotLight")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class ASpotLight : ALight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004781 RID: 18305 RVA: 0x000641D8 File Offset: 0x000623D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASpotLight._ClassPtr;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x000641E4 File Offset: 0x000623E4
		public ASpotLight() : this(BuiltinUtils.AllocNativeUObject(ASpotLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0006420C File Offset: 0x0006240C
		[NullableContext(1)]
		public ASpotLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASpotLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x0006423F File Offset: 0x0006243F
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x00064253 File Offset: 0x00062453
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

		// Token: 0x06004786 RID: 18310 RVA: 0x00064268 File Offset: 0x00062468
		[SkipLocalsInit]
		public unsafe void SetOuterConeAngle(float NewOuterConeAngle)
		{
			ASpotLight.__SetOuterConeAngle_FunctionParams* ptr = stackalloc ASpotLight.__SetOuterConeAngle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ASpotLight.__SetOuterConeAngle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ASpotLight.__SetOuterConeAngle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewOuterConeAngle = NewOuterConeAngle;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ASpotLight.__SetOuterConeAngle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x000642B0 File Offset: 0x000624B0
		[SkipLocalsInit]
		public unsafe void SetInnerConeAngle(float NewInnerConeAngle)
		{
			ASpotLight.__SetInnerConeAngle_FunctionParams* ptr = stackalloc ASpotLight.__SetInnerConeAngle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ASpotLight.__SetInnerConeAngle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ASpotLight.__SetInnerConeAngle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewInnerConeAngle = NewInnerConeAngle;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ASpotLight.__SetInnerConeAngle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000642F6 File Offset: 0x000624F6
		static ASpotLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpotLight");
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00064304 File Offset: 0x00062504
		protected ASpotLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B7F RID: 7039
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpotLight";

		// Token: 0x04001B80 RID: 7040
		private static IntPtr _ClassPtr;

		// Token: 0x04001B81 RID: 7041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B82 RID: 7042
		internal static int __PropertyOffset_SpotLightComponent;

		// Token: 0x04001B83 RID: 7043
		private static IntPtr __SetOuterConeAngle_NativeFunctionPtr;

		// Token: 0x04001B84 RID: 7044
		private static IntPtr __SetInnerConeAngle_NativeFunctionPtr;

		// Token: 0x020009E5 RID: 2533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetOuterConeAngle_FunctionParams
		{
			// Token: 0x0400597E RID: 22910
			[FieldOffset(0)]
			public float NewOuterConeAngle;
		}

		// Token: 0x020009E6 RID: 2534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetInnerConeAngle_FunctionParams
		{
			// Token: 0x0400597F RID: 22911
			[FieldOffset(0)]
			public float NewInnerConeAngle;
		}
	}
}
