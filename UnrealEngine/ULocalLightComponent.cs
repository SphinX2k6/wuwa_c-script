using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D60 RID: 3424
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LocalLightComponent")]
	[UnrealStructLayout(1168, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public abstract class ULocalLightComponent : ULightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8FD RID: 47357 RVA: 0x0010740B File Offset: 0x0010560B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalLightComponent._ClassPtr;
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x00107417 File Offset: 0x00105617
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x00107427 File Offset: 0x00105627
		public unsafe ELightUnits IntensityUnits
		{
			get
			{
				return (ELightUnits)(*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_IntensityUnits));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_IntensityUnits) = (byte)value;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x00107438 File Offset: 0x00105638
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x00107448 File Offset: 0x00105648
		public unsafe float Radius_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_Radius_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_Radius_DEPRECATED) = value;
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x00107459 File Offset: 0x00105659
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x00107469 File Offset: 0x00105669
		public unsafe float AttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_AttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_AttenuationRadius) = value;
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600B904 RID: 47364 RVA: 0x0010747A File Offset: 0x0010567A
		// (set) Token: 0x0600B905 RID: 47365 RVA: 0x0010748A File Offset: 0x0010568A
		public unsafe float IndrectInfluenceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_IndrectInfluenceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_IndrectInfluenceFactor) = value;
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x0010749C File Offset: 0x0010569C
		// (set) Token: 0x0600B907 RID: 47367 RVA: 0x001074D5 File Offset: 0x001056D5
		public FLightmassPointLightSettings LightmassSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLightmassPointLightSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassPointLightSettings(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassPointLightSettings.StaticStruct(), base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600B908 RID: 47368 RVA: 0x001074F6 File Offset: 0x001056F6
		// (set) Token: 0x0600B909 RID: 47369 RVA: 0x0010750F File Offset: 0x0010570F
		public unsafe bool bEnableCullVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bEnableCullVolume) & ULocalLightComponent.__PropertyMask_bEnableCullVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bEnableCullVolume) = ((*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bEnableCullVolume) & ~ULocalLightComponent.__PropertyMask_bEnableCullVolume) | (value ? ULocalLightComponent.__PropertyMask_bEnableCullVolume : 0));
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600B90A RID: 47370 RVA: 0x0010753F File Offset: 0x0010573F
		// (set) Token: 0x0600B90B RID: 47371 RVA: 0x00107553 File Offset: 0x00105753
		public unsafe FVector4 CullVolumePointA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointA) = value;
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600B90C RID: 47372 RVA: 0x00107568 File Offset: 0x00105768
		// (set) Token: 0x0600B90D RID: 47373 RVA: 0x0010757C File Offset: 0x0010577C
		public unsafe FVector4 CullVolumePointB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointB) = value;
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600B90E RID: 47374 RVA: 0x00107591 File Offset: 0x00105791
		// (set) Token: 0x0600B90F RID: 47375 RVA: 0x001075A5 File Offset: 0x001057A5
		public unsafe FVector4 CullVolumePointC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_CullVolumePointC) = value;
			}
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x001075BA File Offset: 0x001057BA
		public void SetIntensityUnits(ELightUnits NewIntensityUnits)
		{
			ULocalLightComponent.__SetIntensityUnits_Internal(base.NativePtr, NewIntensityUnits);
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x001075C8 File Offset: 0x001057C8
		public void SetAttenuationRadius(float NewRadius)
		{
			ULocalLightComponent.__SetAttenuationRadius_Internal(base.NativePtr, NewRadius);
		}

		// Token: 0x0600B912 RID: 47378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetUnitsConversionFactor(ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle = -1f);

		// Token: 0x0600B913 RID: 47379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensityUnits_Internal(IntPtr @this, ELightUnits NewIntensityUnits);

		// Token: 0x0600B914 RID: 47380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttenuationRadius_Internal(IntPtr @this, float NewRadius);

		// Token: 0x0600B915 RID: 47381 RVA: 0x001075D6 File Offset: 0x001057D6
		static ULocalLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalLightComponent");
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x001075E4 File Offset: 0x001057E4
		protected ULocalLightComponent() : this(BuiltinUtils.AllocNativeUObject(ULocalLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x0010760C File Offset: 0x0010580C
		protected ULocalLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060EB RID: 24811
		public new const string __ObjectPath = "/Script/Engine.LocalLightComponent";

		// Token: 0x040060EC RID: 24812
		private static IntPtr _ClassPtr;

		// Token: 0x040060ED RID: 24813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040060EE RID: 24814
		internal static int __PropertyOffset_IntensityUnits;

		// Token: 0x040060EF RID: 24815
		internal static int __PropertyOffset_Radius_DEPRECATED;

		// Token: 0x040060F0 RID: 24816
		internal static int __PropertyOffset_AttenuationRadius;

		// Token: 0x040060F1 RID: 24817
		internal static int __PropertyOffset_IndrectInfluenceFactor;

		// Token: 0x040060F2 RID: 24818
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x040060F3 RID: 24819
		[Nullable(2)]
		private FLightmassPointLightSettings _LightmassSettings;

		// Token: 0x040060F4 RID: 24820
		internal static int __PropertyOffset_bEnableCullVolume;

		// Token: 0x040060F5 RID: 24821
		internal static byte __PropertyMask_bEnableCullVolume;

		// Token: 0x040060F6 RID: 24822
		internal static int __PropertyOffset_CullVolumePointA;

		// Token: 0x040060F7 RID: 24823
		internal static int __PropertyOffset_CullVolumePointB;

		// Token: 0x040060F8 RID: 24824
		internal static int __PropertyOffset_CullVolumePointC;
	}
}
