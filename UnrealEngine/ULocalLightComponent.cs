using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000238 RID: 568
	[UnrealObjectPath("/Script/Engine.LocalLightComponent")]
	[UnrealStructLayout(1184, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public abstract class ULocalLightComponent : ULightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002F36 RID: 12086 RVA: 0x000421C9 File Offset: 0x000403C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalLightComponent._ClassPtr;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000421D5 File Offset: 0x000403D5
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000421E5 File Offset: 0x000403E5
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

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x000421F6 File Offset: 0x000403F6
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x00042206 File Offset: 0x00040406
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

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x00042217 File Offset: 0x00040417
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00042227 File Offset: 0x00040427
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

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x00042238 File Offset: 0x00040438
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x00042251 File Offset: 0x00040451
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x00042281 File Offset: 0x00040481
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x00042295 File Offset: 0x00040495
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

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000422AA File Offset: 0x000404AA
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x000422BE File Offset: 0x000404BE
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x000422D3 File Offset: 0x000404D3
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x000422E7 File Offset: 0x000404E7
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000422FC File Offset: 0x000404FC
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x00042315 File Offset: 0x00040515
		public unsafe bool bDisableMovablePrimitiveShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bDisableMovablePrimitiveShadow) & ULocalLightComponent.__PropertyMask_bDisableMovablePrimitiveShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bDisableMovablePrimitiveShadow) = ((*(base.NativePtr + (IntPtr)ULocalLightComponent.__PropertyOffset_bDisableMovablePrimitiveShadow) & ~ULocalLightComponent.__PropertyMask_bDisableMovablePrimitiveShadow) | (value ? ULocalLightComponent.__PropertyMask_bDisableMovablePrimitiveShadow : 0));
			}
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00042345 File Offset: 0x00040545
		public void SetAttenuationRadius(float NewRadius)
		{
			ULocalLightComponent.__SetAttenuationRadius_Internal(base.NativePtr, NewRadius);
		}

		// Token: 0x06002F48 RID: 12104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttenuationRadius_Internal(IntPtr @this, float NewRadius);

		// Token: 0x06002F49 RID: 12105 RVA: 0x00042353 File Offset: 0x00040553
		static ULocalLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalLightComponent");
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00042364 File Offset: 0x00040564
		protected ULocalLightComponent() : this(BuiltinUtils.AllocNativeUObject(ULocalLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0004238C File Offset: 0x0004058C
		protected ULocalLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000F24 RID: 3876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalLightComponent";

		// Token: 0x04000F25 RID: 3877
		private static IntPtr _ClassPtr;

		// Token: 0x04000F26 RID: 3878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000F27 RID: 3879
		internal static int __PropertyOffset_Radius_DEPRECATED;

		// Token: 0x04000F28 RID: 3880
		internal static int __PropertyOffset_AttenuationRadius;

		// Token: 0x04000F29 RID: 3881
		internal static int __PropertyOffset_IndrectInfluenceFactor;

		// Token: 0x04000F2A RID: 3882
		internal static int __PropertyOffset_bEnableCullVolume;

		// Token: 0x04000F2B RID: 3883
		internal static byte __PropertyMask_bEnableCullVolume;

		// Token: 0x04000F2C RID: 3884
		internal static int __PropertyOffset_CullVolumePointA;

		// Token: 0x04000F2D RID: 3885
		internal static int __PropertyOffset_CullVolumePointB;

		// Token: 0x04000F2E RID: 3886
		internal static int __PropertyOffset_CullVolumePointC;

		// Token: 0x04000F2F RID: 3887
		internal static int __PropertyOffset_bDisableMovablePrimitiveShadow;

		// Token: 0x04000F30 RID: 3888
		internal static byte __PropertyMask_bDisableMovablePrimitiveShadow;
	}
}
