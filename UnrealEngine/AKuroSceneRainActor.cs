using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAC RID: 7084
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainActor")]
	[UnrealStructLayout(1504, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class AKuroSceneRainActor : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B179 RID: 110969 RVA: 0x0027EC0D File Offset: 0x0027CE0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSceneRainActor._ClassPtr;
		}

		// Token: 0x0601B17A RID: 110970 RVA: 0x0027EC1C File Offset: 0x0027CE1C
		public AKuroSceneRainActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSceneRainActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B17B RID: 110971 RVA: 0x0027EC44 File Offset: 0x0027CE44
		[NullableContext(1)]
		public AKuroSceneRainActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSceneRainActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C94 RID: 27796
		// (get) Token: 0x0601B17C RID: 110972 RVA: 0x0027EC77 File Offset: 0x0027CE77
		// (set) Token: 0x0601B17D RID: 110973 RVA: 0x0027EC8B File Offset: 0x0027CE8B
		public unsafe UKuroSceneRainEmitterConfig RainConfig_Front
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSceneRainEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainConfig_Front);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainConfig_Front, value);
			}
		}

		// Token: 0x17006C95 RID: 27797
		// (get) Token: 0x0601B17E RID: 110974 RVA: 0x0027ECA0 File Offset: 0x0027CEA0
		// (set) Token: 0x0601B17F RID: 110975 RVA: 0x0027ECB4 File Offset: 0x0027CEB4
		public unsafe UKuroSceneRainEmitterConfig RainConfig_Back
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSceneRainEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainConfig_Back);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainConfig_Back, value);
			}
		}

		// Token: 0x17006C96 RID: 27798
		// (get) Token: 0x0601B180 RID: 110976 RVA: 0x0027ECC9 File Offset: 0x0027CEC9
		// (set) Token: 0x0601B181 RID: 110977 RVA: 0x0027ECDD File Offset: 0x0027CEDD
		public unsafe UKuroRainComponent RainComponent_Front
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainComponent_Front);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainComponent_Front, value);
			}
		}

		// Token: 0x17006C97 RID: 27799
		// (get) Token: 0x0601B182 RID: 110978 RVA: 0x0027ECF2 File Offset: 0x0027CEF2
		// (set) Token: 0x0601B183 RID: 110979 RVA: 0x0027ED06 File Offset: 0x0027CF06
		public unsafe UKuroRainComponent RainComponent_Back
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainComponent_Back);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSceneRainActor.__PropertyOffset_RainComponent_Back, value);
			}
		}

		// Token: 0x0601B184 RID: 110980 RVA: 0x0027ED1B File Offset: 0x0027CF1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopRain()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroSceneRainActor.__StopRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B185 RID: 110981 RVA: 0x0027ED30 File Offset: 0x0027CF30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartRain()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroSceneRainActor.__StartRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B186 RID: 110982 RVA: 0x0027ED48 File Offset: 0x0027CF48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCurrentRain(float InDensity, float InGravity, FVector InWindSpeed)
		{
			AKuroSceneRainActor.__SetCurrentRain_FunctionParams* ptr = stackalloc AKuroSceneRainActor.__SetCurrentRain_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(AKuroSceneRainActor.__SetCurrentRain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroSceneRainActor.__SetCurrentRain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InDensity = InDensity;
			ptr->InGravity = InGravity;
			ptr->InWindSpeed = InWindSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroSceneRainActor.__SetCurrentRain_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B187 RID: 110983 RVA: 0x0027ED9D File Offset: 0x0027CF9D
		static AKuroSceneRainActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainActor");
		}

		// Token: 0x0601B188 RID: 110984 RVA: 0x0027EDAB File Offset: 0x0027CFAB
		protected AKuroSceneRainActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E964 RID: 59748
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainActor";

		// Token: 0x0400E965 RID: 59749
		private static IntPtr _ClassPtr;

		// Token: 0x0400E966 RID: 59750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E967 RID: 59751
		internal static int __PropertyOffset_RainConfig_Front;

		// Token: 0x0400E968 RID: 59752
		internal static int __PropertyOffset_RainConfig_Back;

		// Token: 0x0400E969 RID: 59753
		internal static int __PropertyOffset_RainComponent_Front;

		// Token: 0x0400E96A RID: 59754
		internal static int __PropertyOffset_RainComponent_Back;

		// Token: 0x0400E96B RID: 59755
		private static IntPtr __StopRain_NativeFunctionPtr;

		// Token: 0x0400E96C RID: 59756
		private static IntPtr __StartRain_NativeFunctionPtr;

		// Token: 0x0400E96D RID: 59757
		private static IntPtr __SetCurrentRain_NativeFunctionPtr;

		// Token: 0x02003176 RID: 12662
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetCurrentRain_FunctionParams
		{
			// Token: 0x04016FA7 RID: 94119
			[FieldOffset(0)]
			public float InDensity;

			// Token: 0x04016FA8 RID: 94120
			[FieldOffset(4)]
			public float InGravity;

			// Token: 0x04016FA9 RID: 94121
			[FieldOffset(8)]
			public FVector InWindSpeed;
		}
	}
}
