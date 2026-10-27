using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCF RID: 7119
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSurfaceRipple")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class AKuroSurfaceRipple : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B518 RID: 111896 RVA: 0x00283FC6 File Offset: 0x002821C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSurfaceRipple._ClassPtr;
		}

		// Token: 0x0601B519 RID: 111897 RVA: 0x00283FD4 File Offset: 0x002821D4
		public AKuroSurfaceRipple() : this(BuiltinUtils.AllocNativeUObject(AKuroSurfaceRipple.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B51A RID: 111898 RVA: 0x00283FFC File Offset: 0x002821FC
		[NullableContext(1)]
		public AKuroSurfaceRipple(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSurfaceRipple.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x0601B51B RID: 111899 RVA: 0x0028402F File Offset: 0x0028222F
		// (set) Token: 0x0601B51C RID: 111900 RVA: 0x00284043 File Offset: 0x00282243
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_Global_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_Global_MPC, value);
			}
		}

		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x0601B51D RID: 111901 RVA: 0x00284058 File Offset: 0x00282258
		// (set) Token: 0x0601B51E RID: 111902 RVA: 0x0028406C File Offset: 0x0028226C
		public unsafe UMaterialInstanceDynamic MID_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_MID_Ripple);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_MID_Ripple, value);
			}
		}

		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x0601B51F RID: 111903 RVA: 0x00284081 File Offset: 0x00282281
		// (set) Token: 0x0601B520 RID: 111904 RVA: 0x00284091 File Offset: 0x00282291
		public unsafe float RainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainDensity) = value;
			}
		}

		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x0601B521 RID: 111905 RVA: 0x002840A2 File Offset: 0x002822A2
		// (set) Token: 0x0601B522 RID: 111906 RVA: 0x002840B2 File Offset: 0x002822B2
		public unsafe float LastRainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_LastRainDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_LastRainDensity) = value;
			}
		}

		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x0601B523 RID: 111907 RVA: 0x002840C3 File Offset: 0x002822C3
		// (set) Token: 0x0601B524 RID: 111908 RVA: 0x002840D3 File Offset: 0x002822D3
		public unsafe float RainTimePassed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainTimePassed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainTimePassed) = value;
			}
		}

		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x0601B525 RID: 111909 RVA: 0x002840E4 File Offset: 0x002822E4
		// (set) Token: 0x0601B526 RID: 111910 RVA: 0x002840F4 File Offset: 0x002822F4
		public unsafe float RainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainIntensity) = value;
			}
		}

		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x0601B527 RID: 111911 RVA: 0x00284105 File Offset: 0x00282305
		// (set) Token: 0x0601B528 RID: 111912 RVA: 0x00284115 File Offset: 0x00282315
		public unsafe bool UpdateRainRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_UpdateRainRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_UpdateRainRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x0601B529 RID: 111913 RVA: 0x00284126 File Offset: 0x00282326
		// (set) Token: 0x0601B52A RID: 111914 RVA: 0x0028413A File Offset: 0x0028233A
		public unsafe FVector4 RainHeightNoiseData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainHeightNoiseData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainHeightNoiseData) = value;
			}
		}

		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x0601B52B RID: 111915 RVA: 0x0028414F File Offset: 0x0028234F
		// (set) Token: 0x0601B52C RID: 111916 RVA: 0x00284163 File Offset: 0x00282363
		public unsafe FVector4 RainGradualData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainGradualData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_RainGradualData) = value;
			}
		}

		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x0601B52D RID: 111917 RVA: 0x00284178 File Offset: 0x00282378
		// (set) Token: 0x0601B52E RID: 111918 RVA: 0x00284188 File Offset: 0x00282388
		public unsafe float MaxRainTimePassed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_MaxRainTimePassed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSurfaceRipple.__PropertyOffset_MaxRainTimePassed) = value;
			}
		}

		// Token: 0x17006DCB RID: 28107
		// (get) Token: 0x0601B52F RID: 111919 RVA: 0x00284199 File Offset: 0x00282399
		// (set) Token: 0x0601B530 RID: 111920 RVA: 0x002841AD File Offset: 0x002823AD
		public unsafe UTextureRenderTarget2D RT_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_RT_Ripple);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSurfaceRipple.__PropertyOffset_RT_Ripple, value);
			}
		}

		// Token: 0x0601B531 RID: 111921 RVA: 0x002841C2 File Offset: 0x002823C2
		public void SetRainRoughness()
		{
			AKuroSurfaceRipple.__SetRainRoughness_Internal(base.NativePtr);
		}

		// Token: 0x0601B532 RID: 111922 RVA: 0x002841D0 File Offset: 0x002823D0
		public unsafe void SetRainIntensity(EKuroRainType KuroRainType, float InRainIntensity, float InMaxRainTimePassed, FVector4 InRainGradualData, float RainRippleNormalIntensity, FVector4 InRainHeightNoiseData)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InRainGradualData;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = InRainHeightNoiseData;
			AKuroSurfaceRipple.__SetRainIntensity_Internal(base.NativePtr, KuroRainType, InRainIntensity, InMaxRainTimePassed, ptr, RainRippleNormalIntensity, ptr2);
		}

		// Token: 0x0601B533 RID: 111923 RVA: 0x00284224 File Offset: 0x00282424
		public void SetNoRainRoughness()
		{
			AKuroSurfaceRipple.__SetNoRainRoughness_Internal(base.NativePtr);
		}

		// Token: 0x0601B534 RID: 111924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRainRoughness_Internal(IntPtr @this);

		// Token: 0x0601B535 RID: 111925
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRainIntensity_Internal(IntPtr @this, TEnumAsByte<EKuroRainType> KuroRainType, float InRainIntensity, float InMaxRainTimePassed, in FVector4 InRainGradualData, float RainRippleNormalIntensity, in FVector4 InRainHeightNoiseData);

		// Token: 0x0601B536 RID: 111926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNoRainRoughness_Internal(IntPtr @this);

		// Token: 0x0601B537 RID: 111927 RVA: 0x00284231 File Offset: 0x00282431
		static AKuroSurfaceRipple()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSurfaceRipple");
		}

		// Token: 0x0601B538 RID: 111928 RVA: 0x0028423F File Offset: 0x0028243F
		protected AKuroSurfaceRipple(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB5A RID: 60250
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSurfaceRipple";

		// Token: 0x0400EB5B RID: 60251
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB5C RID: 60252
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB5D RID: 60253
		internal static int __PropertyOffset_Global_MPC;

		// Token: 0x0400EB5E RID: 60254
		internal static int __PropertyOffset_MID_Ripple;

		// Token: 0x0400EB5F RID: 60255
		internal static int __PropertyOffset_RainDensity;

		// Token: 0x0400EB60 RID: 60256
		internal static int __PropertyOffset_LastRainDensity;

		// Token: 0x0400EB61 RID: 60257
		internal static int __PropertyOffset_RainTimePassed;

		// Token: 0x0400EB62 RID: 60258
		internal static int __PropertyOffset_RainIntensity;

		// Token: 0x0400EB63 RID: 60259
		internal static int __PropertyOffset_UpdateRainRT;

		// Token: 0x0400EB64 RID: 60260
		internal static int __PropertyOffset_RainHeightNoiseData;

		// Token: 0x0400EB65 RID: 60261
		internal static int __PropertyOffset_RainGradualData;

		// Token: 0x0400EB66 RID: 60262
		internal static int __PropertyOffset_MaxRainTimePassed;

		// Token: 0x0400EB67 RID: 60263
		internal static int __PropertyOffset_RT_Ripple;
	}
}
