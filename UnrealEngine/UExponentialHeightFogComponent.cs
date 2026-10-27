using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BC6 RID: 3014
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ExponentialHeightFogComponent")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UExponentialHeightFogComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092B8 RID: 37560 RVA: 0x000D270D File Offset: 0x000D090D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UExponentialHeightFogComponent._ClassPtr;
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x000D271C File Offset: 0x000D091C
		public UExponentialHeightFogComponent() : this(BuiltinUtils.AllocNativeUObject(UExponentialHeightFogComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x000D2744 File Offset: 0x000D0944
		public UExponentialHeightFogComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UExponentialHeightFogComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x000D2777 File Offset: 0x000D0977
		// (set) Token: 0x060092BC RID: 37564 RVA: 0x000D278B File Offset: 0x000D098B
		public unsafe FLinearColor KuroDirectionalInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringColor) = value;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x000D27A0 File Offset: 0x000D09A0
		// (set) Token: 0x060092BE RID: 37566 RVA: 0x000D27B0 File Offset: 0x000D09B0
		public unsafe float KuroDirectionalInscatteringAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringAmount) = value;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060092BF RID: 37567 RVA: 0x000D27C1 File Offset: 0x000D09C1
		// (set) Token: 0x060092C0 RID: 37568 RVA: 0x000D27D1 File Offset: 0x000D09D1
		public unsafe float KuroDirectionalInscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringExponent) = value;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060092C1 RID: 37569 RVA: 0x000D27E2 File Offset: 0x000D09E2
		// (set) Token: 0x060092C2 RID: 37570 RVA: 0x000D27F2 File Offset: 0x000D09F2
		public unsafe float KuroDirectionalInscatteringStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDirectionalInscatteringStartDistance) = value;
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x060092C3 RID: 37571 RVA: 0x000D2803 File Offset: 0x000D0A03
		// (set) Token: 0x060092C4 RID: 37572 RVA: 0x000D2813 File Offset: 0x000D0A13
		public unsafe float KuroFog1Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1Density) = value;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x060092C5 RID: 37573 RVA: 0x000D2824 File Offset: 0x000D0A24
		// (set) Token: 0x060092C6 RID: 37574 RVA: 0x000D2834 File Offset: 0x000D0A34
		public unsafe float KuroFog1HeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1HeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1HeightOffset) = value;
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060092C7 RID: 37575 RVA: 0x000D2845 File Offset: 0x000D0A45
		// (set) Token: 0x060092C8 RID: 37576 RVA: 0x000D2855 File Offset: 0x000D0A55
		public unsafe float KuroFog1Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1Falloff) = value;
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060092C9 RID: 37577 RVA: 0x000D2866 File Offset: 0x000D0A66
		// (set) Token: 0x060092CA RID: 37578 RVA: 0x000D2876 File Offset: 0x000D0A76
		public unsafe float KuroFog1FalloffFarSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1FalloffFarSky);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1FalloffFarSky) = value;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060092CB RID: 37579 RVA: 0x000D2887 File Offset: 0x000D0A87
		// (set) Token: 0x060092CC RID: 37580 RVA: 0x000D2897 File Offset: 0x000D0A97
		public unsafe float KuroFog1StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1StartDistance) = value;
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060092CD RID: 37581 RVA: 0x000D28A8 File Offset: 0x000D0AA8
		// (set) Token: 0x060092CE RID: 37582 RVA: 0x000D28B8 File Offset: 0x000D0AB8
		public unsafe float KuroFog1MaxOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1MaxOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFog1MaxOpacity) = value;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x060092CF RID: 37583 RVA: 0x000D28C9 File Offset: 0x000D0AC9
		// (set) Token: 0x060092D0 RID: 37584 RVA: 0x000D28DD File Offset: 0x000D0ADD
		public unsafe FLinearColor KuroFogNearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearColor) = value;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x000D28F2 File Offset: 0x000D0AF2
		// (set) Token: 0x060092D2 RID: 37586 RVA: 0x000D2906 File Offset: 0x000D0B06
		public unsafe FLinearColor KuroFogFarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogFarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogFarColor) = value;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x060092D3 RID: 37587 RVA: 0x000D291B File Offset: 0x000D0B1B
		// (set) Token: 0x060092D4 RID: 37588 RVA: 0x000D292F File Offset: 0x000D0B2F
		public unsafe FLinearColor KuroFogBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogBaseColor) = value;
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x060092D5 RID: 37589 RVA: 0x000D2944 File Offset: 0x000D0B44
		// (set) Token: 0x060092D6 RID: 37590 RVA: 0x000D2954 File Offset: 0x000D0B54
		public unsafe float KuroFogNearColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearColorDistance) = value;
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x060092D7 RID: 37591 RVA: 0x000D2965 File Offset: 0x000D0B65
		// (set) Token: 0x060092D8 RID: 37592 RVA: 0x000D2975 File Offset: 0x000D0B75
		public unsafe float KuroFogFarColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogFarColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogFarColorDistance) = value;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x060092D9 RID: 37593 RVA: 0x000D2986 File Offset: 0x000D0B86
		// (set) Token: 0x060092DA RID: 37594 RVA: 0x000D2996 File Offset: 0x000D0B96
		public unsafe float KuroFogNearFarColorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearFarColorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogNearFarColorRatio) = value;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x060092DB RID: 37595 RVA: 0x000D29A7 File Offset: 0x000D0BA7
		// (set) Token: 0x060092DC RID: 37596 RVA: 0x000D29B7 File Offset: 0x000D0BB7
		public unsafe float KuroFogMixDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogMixDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogMixDistance) = value;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x000D29C8 File Offset: 0x000D0BC8
		// (set) Token: 0x060092DE RID: 37598 RVA: 0x000D29D8 File Offset: 0x000D0BD8
		public unsafe float KuroFogMixWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogMixWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroFogMixWidth) = value;
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x060092DF RID: 37599 RVA: 0x000D29E9 File Offset: 0x000D0BE9
		// (set) Token: 0x060092E0 RID: 37600 RVA: 0x000D29F9 File Offset: 0x000D0BF9
		public unsafe float KuroLowPoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowPoint1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowPoint1) = value;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x000D2A0A File Offset: 0x000D0C0A
		// (set) Token: 0x060092E2 RID: 37602 RVA: 0x000D2A1A File Offset: 0x000D0C1A
		public unsafe float KuroHighPoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroHighPoint1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroHighPoint1) = value;
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x000D2A2B File Offset: 0x000D0C2B
		// (set) Token: 0x060092E4 RID: 37604 RVA: 0x000D2A3B File Offset: 0x000D0C3B
		public unsafe float KuroLowFalloff1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowFalloff1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowFalloff1) = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x000D2A4C File Offset: 0x000D0C4C
		// (set) Token: 0x060092E6 RID: 37606 RVA: 0x000D2A5C File Offset: 0x000D0C5C
		public unsafe float KuroLowSkyFalloff1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowSkyFalloff1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowSkyFalloff1) = value;
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x000D2A6D File Offset: 0x000D0C6D
		// (set) Token: 0x060092E8 RID: 37608 RVA: 0x000D2A7D File Offset: 0x000D0C7D
		public unsafe float KuroLowHighOffset1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowHighOffset1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroLowHighOffset1) = value;
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x000D2A8E File Offset: 0x000D0C8E
		// (set) Token: 0x060092EA RID: 37610 RVA: 0x000D2A9E File Offset: 0x000D0C9E
		public unsafe float ReverseZCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_ReverseZCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_ReverseZCenter) = value;
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x060092EB RID: 37611 RVA: 0x000D2AAF File Offset: 0x000D0CAF
		// (set) Token: 0x060092EC RID: 37612 RVA: 0x000D2ABF File Offset: 0x000D0CBF
		public unsafe bool IsReversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_IsReversed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_IsReversed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x060092ED RID: 37613 RVA: 0x000D2AD0 File Offset: 0x000D0CD0
		// (set) Token: 0x060092EE RID: 37614 RVA: 0x000D2AE0 File Offset: 0x000D0CE0
		public unsafe float KuroEffectFogSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogSwitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogSwitch) = value;
			}
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x060092EF RID: 37615 RVA: 0x000D2AF1 File Offset: 0x000D0CF1
		// (set) Token: 0x060092F0 RID: 37616 RVA: 0x000D2B01 File Offset: 0x000D0D01
		public unsafe float KuroEffectFogBlendSceneFogMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogBlendSceneFogMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogBlendSceneFogMin) = value;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x060092F1 RID: 37617 RVA: 0x000D2B12 File Offset: 0x000D0D12
		// (set) Token: 0x060092F2 RID: 37618 RVA: 0x000D2B22 File Offset: 0x000D0D22
		public unsafe float KuroEffectFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogDensity) = value;
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x060092F3 RID: 37619 RVA: 0x000D2B33 File Offset: 0x000D0D33
		// (set) Token: 0x060092F4 RID: 37620 RVA: 0x000D2B43 File Offset: 0x000D0D43
		public unsafe float KuroEffectFogFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFalloff) = value;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x060092F5 RID: 37621 RVA: 0x000D2B54 File Offset: 0x000D0D54
		// (set) Token: 0x060092F6 RID: 37622 RVA: 0x000D2B64 File Offset: 0x000D0D64
		public unsafe float KuroEffectFogFalloffFarSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFalloffFarSky);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFalloffFarSky) = value;
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x000D2B75 File Offset: 0x000D0D75
		// (set) Token: 0x060092F8 RID: 37624 RVA: 0x000D2B85 File Offset: 0x000D0D85
		public unsafe float KuroEffectFogStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogStartDistance) = value;
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x060092F9 RID: 37625 RVA: 0x000D2B96 File Offset: 0x000D0D96
		// (set) Token: 0x060092FA RID: 37626 RVA: 0x000D2BA6 File Offset: 0x000D0DA6
		public unsafe float KuroEffectFogMaxOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMaxOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMaxOpacity) = value;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x060092FB RID: 37627 RVA: 0x000D2BB7 File Offset: 0x000D0DB7
		// (set) Token: 0x060092FC RID: 37628 RVA: 0x000D2BCB File Offset: 0x000D0DCB
		public unsafe FLinearColor KuroEffectFogNearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearColor) = value;
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x000D2BE0 File Offset: 0x000D0DE0
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x000D2BF4 File Offset: 0x000D0DF4
		public unsafe FLinearColor KuroEffectFogFarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFarColor) = value;
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x000D2C09 File Offset: 0x000D0E09
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x000D2C1D File Offset: 0x000D0E1D
		public unsafe FLinearColor KuroEffectFogBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogBaseColor) = value;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06009301 RID: 37633 RVA: 0x000D2C32 File Offset: 0x000D0E32
		// (set) Token: 0x06009302 RID: 37634 RVA: 0x000D2C42 File Offset: 0x000D0E42
		public unsafe float KuroEffectFogNearColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearColorDistance) = value;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06009303 RID: 37635 RVA: 0x000D2C53 File Offset: 0x000D0E53
		// (set) Token: 0x06009304 RID: 37636 RVA: 0x000D2C63 File Offset: 0x000D0E63
		public unsafe float KuroEffectFogFarColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFarColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogFarColorDistance) = value;
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06009305 RID: 37637 RVA: 0x000D2C74 File Offset: 0x000D0E74
		// (set) Token: 0x06009306 RID: 37638 RVA: 0x000D2C84 File Offset: 0x000D0E84
		public unsafe float KuroEffectFogNearFarColorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearFarColorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogNearFarColorRatio) = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06009307 RID: 37639 RVA: 0x000D2C95 File Offset: 0x000D0E95
		// (set) Token: 0x06009308 RID: 37640 RVA: 0x000D2CA5 File Offset: 0x000D0EA5
		public unsafe float KuroEffectFogMixDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMixDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMixDistance) = value;
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06009309 RID: 37641 RVA: 0x000D2CB6 File Offset: 0x000D0EB6
		// (set) Token: 0x0600930A RID: 37642 RVA: 0x000D2CC6 File Offset: 0x000D0EC6
		public unsafe float KuroEffectFogMixWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMixWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroEffectFogMixWidth) = value;
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600930B RID: 37643 RVA: 0x000D2CD7 File Offset: 0x000D0ED7
		// (set) Token: 0x0600930C RID: 37644 RVA: 0x000D2CE7 File Offset: 0x000D0EE7
		public unsafe float KuroBillboardCloudsNearFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsNearFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsNearFogDensity) = value;
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600930D RID: 37645 RVA: 0x000D2CF8 File Offset: 0x000D0EF8
		// (set) Token: 0x0600930E RID: 37646 RVA: 0x000D2D08 File Offset: 0x000D0F08
		public unsafe float KuroBillboardCloudsFarFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsFarFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsFarFogDensity) = value;
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x000D2D19 File Offset: 0x000D0F19
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x000D2D29 File Offset: 0x000D0F29
		public unsafe float KuroBillboardCloudsBeginDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsBeginDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsBeginDistance) = value;
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x000D2D3A File Offset: 0x000D0F3A
		// (set) Token: 0x06009312 RID: 37650 RVA: 0x000D2D4A File Offset: 0x000D0F4A
		public unsafe float KuroBillboardCloudsFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroBillboardCloudsFadeDistance) = value;
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06009313 RID: 37651 RVA: 0x000D2D5B File Offset: 0x000D0F5B
		// (set) Token: 0x06009314 RID: 37652 RVA: 0x000D2D6B File Offset: 0x000D0F6B
		public unsafe float KuroGICurrentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroGICurrentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroGICurrentTime) = value;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x000D2D7C File Offset: 0x000D0F7C
		// (set) Token: 0x06009316 RID: 37654 RVA: 0x000D2D8C File Offset: 0x000D0F8C
		public unsafe float KuroDayNightTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDayNightTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroDayNightTime) = value;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x000D2D9D File Offset: 0x000D0F9D
		// (set) Token: 0x06009318 RID: 37656 RVA: 0x000D2DB1 File Offset: 0x000D0FB1
		public unsafe FLinearColor KuroSunInscatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroSunInscatterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroSunInscatterColor) = value;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06009319 RID: 37657 RVA: 0x000D2DC6 File Offset: 0x000D0FC6
		// (set) Token: 0x0600931A RID: 37658 RVA: 0x000D2DD6 File Offset: 0x000D0FD6
		public unsafe float KuroSunInscatterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroSunInscatterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroSunInscatterSize) = value;
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600931B RID: 37659 RVA: 0x000D2DE7 File Offset: 0x000D0FE7
		// (set) Token: 0x0600931C RID: 37660 RVA: 0x000D2DF7 File Offset: 0x000D0FF7
		public unsafe bool bKuroWpoFogCorrEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bKuroWpoFogCorrEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bKuroWpoFogCorrEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600931D RID: 37661 RVA: 0x000D2E08 File Offset: 0x000D1008
		// (set) Token: 0x0600931E RID: 37662 RVA: 0x000D2E18 File Offset: 0x000D1018
		public unsafe float KuroWpoFogCorrX0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrX0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrX0) = value;
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600931F RID: 37663 RVA: 0x000D2E29 File Offset: 0x000D1029
		// (set) Token: 0x06009320 RID: 37664 RVA: 0x000D2E39 File Offset: 0x000D1039
		public unsafe float KuroWpoFogCorrR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrR) = value;
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06009321 RID: 37665 RVA: 0x000D2E4A File Offset: 0x000D104A
		// (set) Token: 0x06009322 RID: 37666 RVA: 0x000D2E5A File Offset: 0x000D105A
		public unsafe float KuroWpoFogCorrXMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrXMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrXMin) = value;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x000D2E6B File Offset: 0x000D106B
		// (set) Token: 0x06009324 RID: 37668 RVA: 0x000D2E7B File Offset: 0x000D107B
		public unsafe float KuroWpoFogCorrXMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrXMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrXMax) = value;
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x000D2E8C File Offset: 0x000D108C
		// (set) Token: 0x06009326 RID: 37670 RVA: 0x000D2E9C File Offset: 0x000D109C
		public unsafe float KuroWpoFogCorrYMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrYMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_KuroWpoFogCorrYMin) = value;
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06009327 RID: 37671 RVA: 0x000D2EAD File Offset: 0x000D10AD
		// (set) Token: 0x06009328 RID: 37672 RVA: 0x000D2EBD File Offset: 0x000D10BD
		public unsafe float FogBaseLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogBaseLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogBaseLocation) = value;
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x000D2ECE File Offset: 0x000D10CE
		// (set) Token: 0x0600932A RID: 37674 RVA: 0x000D2EDE File Offset: 0x000D10DE
		public unsafe float FogUseBaseLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogUseBaseLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogUseBaseLocation) = value;
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x000D2EEF File Offset: 0x000D10EF
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x000D2EFF File Offset: 0x000D10FF
		public unsafe float FogUseCameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogUseCameraLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogUseCameraLocation) = value;
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x000D2F10 File Offset: 0x000D1110
		// (set) Token: 0x0600932E RID: 37678 RVA: 0x000D2F20 File Offset: 0x000D1120
		public unsafe float FogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogDensity) = value;
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600932F RID: 37679 RVA: 0x000D2F31 File Offset: 0x000D1131
		// (set) Token: 0x06009330 RID: 37680 RVA: 0x000D2F41 File Offset: 0x000D1141
		public unsafe float FogHeightFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogHeightFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogHeightFalloff) = value;
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x000D2F54 File Offset: 0x000D1154
		// (set) Token: 0x06009332 RID: 37682 RVA: 0x000D2F8D File Offset: 0x000D118D
		public FExponentialHeightFogData SecondFogData
		{
			get
			{
				base.FastCheckIsValid();
				FExponentialHeightFogData result;
				if ((result = this._SecondFogData) == null)
				{
					result = (this._SecondFogData = new FExponentialHeightFogData(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_SecondFogData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExponentialHeightFogData.StaticStruct(), base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_SecondFogData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06009333 RID: 37683 RVA: 0x000D2FAE File Offset: 0x000D11AE
		// (set) Token: 0x06009334 RID: 37684 RVA: 0x000D2FC2 File Offset: 0x000D11C2
		public unsafe FLinearColor FogInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogInscatteringColor) = value;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06009335 RID: 37685 RVA: 0x000D2FD7 File Offset: 0x000D11D7
		// (set) Token: 0x06009336 RID: 37686 RVA: 0x000D2FEB File Offset: 0x000D11EB
		[Nullable(2)]
		public unsafe UTextureCube InscatteringColorCubemap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + UExponentialHeightFogComponent.__PropertyOffset_InscatteringColorCubemap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UExponentialHeightFogComponent.__PropertyOffset_InscatteringColorCubemap, value);
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06009337 RID: 37687 RVA: 0x000D3000 File Offset: 0x000D1200
		// (set) Token: 0x06009338 RID: 37688 RVA: 0x000D3010 File Offset: 0x000D1210
		public unsafe float InscatteringColorCubemapAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_InscatteringColorCubemapAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_InscatteringColorCubemapAngle) = value;
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06009339 RID: 37689 RVA: 0x000D3021 File Offset: 0x000D1221
		// (set) Token: 0x0600933A RID: 37690 RVA: 0x000D3035 File Offset: 0x000D1235
		public unsafe FLinearColor InscatteringTextureTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_InscatteringTextureTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_InscatteringTextureTint) = value;
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x000D304A File Offset: 0x000D124A
		// (set) Token: 0x0600933C RID: 37692 RVA: 0x000D305A File Offset: 0x000D125A
		public unsafe float FullyDirectionalInscatteringColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FullyDirectionalInscatteringColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FullyDirectionalInscatteringColorDistance) = value;
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600933D RID: 37693 RVA: 0x000D306B File Offset: 0x000D126B
		// (set) Token: 0x0600933E RID: 37694 RVA: 0x000D307B File Offset: 0x000D127B
		public unsafe float NonDirectionalInscatteringColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_NonDirectionalInscatteringColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_NonDirectionalInscatteringColorDistance) = value;
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x000D308C File Offset: 0x000D128C
		// (set) Token: 0x06009340 RID: 37696 RVA: 0x000D309C File Offset: 0x000D129C
		public unsafe float DirectionalInscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringExponent) = value;
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x000D30AD File Offset: 0x000D12AD
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x000D30BD File Offset: 0x000D12BD
		public unsafe float DirectionalInscatteringStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringStartDistance) = value;
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x000D30CE File Offset: 0x000D12CE
		// (set) Token: 0x06009344 RID: 37700 RVA: 0x000D30E2 File Offset: 0x000D12E2
		public unsafe FLinearColor DirectionalInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_DirectionalInscatteringColor) = value;
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x000D30F7 File Offset: 0x000D12F7
		// (set) Token: 0x06009346 RID: 37702 RVA: 0x000D3107 File Offset: 0x000D1307
		public unsafe float FogMaxOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogMaxOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogMaxOpacity) = value;
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x000D3118 File Offset: 0x000D1318
		// (set) Token: 0x06009348 RID: 37704 RVA: 0x000D3128 File Offset: 0x000D1328
		public unsafe float StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_StartDistance) = value;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x000D3139 File Offset: 0x000D1339
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x000D3149 File Offset: 0x000D1349
		public unsafe float FogCutoffDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogCutoffDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_FogCutoffDistance) = value;
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x000D315A File Offset: 0x000D135A
		// (set) Token: 0x0600934C RID: 37708 RVA: 0x000D316A File Offset: 0x000D136A
		public unsafe bool bEnableVolumetricFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricFog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricFog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x000D317B File Offset: 0x000D137B
		// (set) Token: 0x0600934E RID: 37710 RVA: 0x000D318B File Offset: 0x000D138B
		public unsafe float VolumetricFogNearFadeInDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogNearFadeInDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogNearFadeInDistance) = value;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x000D319C File Offset: 0x000D139C
		// (set) Token: 0x06009350 RID: 37712 RVA: 0x000D31AC File Offset: 0x000D13AC
		public unsafe float VolumetricFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDensity) = value;
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x000D31BD File Offset: 0x000D13BD
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x000D31CD File Offset: 0x000D13CD
		public unsafe bool bEnableVolumetricLightFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricLightFunction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricLightFunction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x000D31DE File Offset: 0x000D13DE
		// (set) Token: 0x06009354 RID: 37716 RVA: 0x000D31EE File Offset: 0x000D13EE
		public unsafe bool bEnableVolumetricLightFunctionRestore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricLightFunctionRestore) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricLightFunctionRestore) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x000D31FF File Offset: 0x000D13FF
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x000D320F File Offset: 0x000D140F
		public unsafe float VolumetricFogScatteringDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogScatteringDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogScatteringDistribution) = value;
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06009357 RID: 37719 RVA: 0x000D3220 File Offset: 0x000D1420
		// (set) Token: 0x06009358 RID: 37720 RVA: 0x000D3234 File Offset: 0x000D1434
		public unsafe FColor VolumetricFogAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogAlbedo) = value;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x000D3249 File Offset: 0x000D1449
		// (set) Token: 0x0600935A RID: 37722 RVA: 0x000D325D File Offset: 0x000D145D
		public unsafe FLinearColor VolumetricFogTransmittance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogTransmittance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogTransmittance) = value;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600935B RID: 37723 RVA: 0x000D3272 File Offset: 0x000D1472
		// (set) Token: 0x0600935C RID: 37724 RVA: 0x000D3282 File Offset: 0x000D1482
		public unsafe bool bEnableVolumetricSunExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricSunExposure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bEnableVolumetricSunExposure) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600935D RID: 37725 RVA: 0x000D3293 File Offset: 0x000D1493
		// (set) Token: 0x0600935E RID: 37726 RVA: 0x000D32A3 File Offset: 0x000D14A3
		public unsafe float VolumetricDepthFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricDepthFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricDepthFadeDistance) = value;
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0600935F RID: 37727 RVA: 0x000D32B4 File Offset: 0x000D14B4
		// (set) Token: 0x06009360 RID: 37728 RVA: 0x000D32C4 File Offset: 0x000D14C4
		public unsafe float bDisableVolumetricPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bDisableVolumetricPhase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bDisableVolumetricPhase) = value;
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x000D32D5 File Offset: 0x000D14D5
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x000D32E5 File Offset: 0x000D14E5
		public unsafe float VolumetricFogNewPhaseFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogNewPhaseFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogNewPhaseFadeRange) = value;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x000D32F6 File Offset: 0x000D14F6
		// (set) Token: 0x06009364 RID: 37732 RVA: 0x000D330A File Offset: 0x000D150A
		public unsafe FLinearColor VolumetricFogEmissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogEmissive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogEmissive) = value;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x000D331F File Offset: 0x000D151F
		// (set) Token: 0x06009366 RID: 37734 RVA: 0x000D332F File Offset: 0x000D152F
		public unsafe float VolumetricFogSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogSkyLightIntensity) = value;
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x000D3340 File Offset: 0x000D1540
		// (set) Token: 0x06009368 RID: 37736 RVA: 0x000D3350 File Offset: 0x000D1550
		public unsafe float VolumetricFogDirectionalLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDirectionalLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDirectionalLightIntensity) = value;
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06009369 RID: 37737 RVA: 0x000D3361 File Offset: 0x000D1561
		// (set) Token: 0x0600936A RID: 37738 RVA: 0x000D3371 File Offset: 0x000D1571
		public unsafe float VolumetricFogExtinctionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogExtinctionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogExtinctionScale) = value;
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x000D3382 File Offset: 0x000D1582
		// (set) Token: 0x0600936C RID: 37740 RVA: 0x000D3392 File Offset: 0x000D1592
		public unsafe float VolumetricFogDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogDistance) = value;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600936D RID: 37741 RVA: 0x000D33A3 File Offset: 0x000D15A3
		// (set) Token: 0x0600936E RID: 37742 RVA: 0x000D33B3 File Offset: 0x000D15B3
		public unsafe float VolumetricFogStaticLightingScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogStaticLightingScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogStaticLightingScatteringIntensity) = value;
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x000D33C4 File Offset: 0x000D15C4
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x000D33D4 File Offset: 0x000D15D4
		public unsafe float VolumetricFogLocalLightScatteringMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogLocalLightScatteringMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_VolumetricFogLocalLightScatteringMultiplier) = value;
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x000D33E5 File Offset: 0x000D15E5
		// (set) Token: 0x06009372 RID: 37746 RVA: 0x000D33F5 File Offset: 0x000D15F5
		public unsafe bool bOverrideLightColorsWithFogInscatteringColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bOverrideLightColorsWithFogInscatteringColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExponentialHeightFogComponent.__PropertyOffset_bOverrideLightColorsWithFogInscatteringColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x000D3406 File Offset: 0x000D1606
		public void SetVolumetricLocalLightScatteringMultiplier(float Value)
		{
			UExponentialHeightFogComponent.__SetVolumetricLocalLightScatteringMultiplier_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x000D3414 File Offset: 0x000D1614
		public void SetVolumetricFogTransmittance(FLinearColor NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogTransmittance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x000D3422 File Offset: 0x000D1622
		public void SetVolumetricFogStaticLightingScatteringIntensity(float Value)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogStaticLightingScatteringIntensity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x000D3430 File Offset: 0x000D1630
		public void SetVolumetricFogSkyLightIntensity(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogSkyLightIntensity_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x000D343E File Offset: 0x000D163E
		public void SetVolumetricFogScatteringDistribution(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogScatteringDistribution_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x000D344C File Offset: 0x000D164C
		public void SetVolumetricFogNewPhaseFadeRange(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogNewPhaseFadeRange_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x000D345A File Offset: 0x000D165A
		public void SetVolumetricFogNearFadeInDistance(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogNearFadeInDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x000D3468 File Offset: 0x000D1668
		public void SetVolumetricFogExtinctionScale(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogExtinctionScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x000D3476 File Offset: 0x000D1676
		public void SetVolumetricFogEmissive(FLinearColor NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogEmissive_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x000D3484 File Offset: 0x000D1684
		public void SetVolumetricFogDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x000D3492 File Offset: 0x000D1692
		public void SetVolumetricFogDirectionalLightIntensity(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogDirectionalLightIntensity_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x000D34A0 File Offset: 0x000D16A0
		public void SetVolumetricFogDensity(float bNewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogDensity_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x000D34AE File Offset: 0x000D16AE
		public void SetVolumetricFogAlbedo(FColor NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFogAlbedo_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x000D34BC File Offset: 0x000D16BC
		public void SetVolumetricFog(bool bNewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricFog_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x000D34CA File Offset: 0x000D16CA
		public void SetVolumetricDepthFadeDistance(float NewValue)
		{
			UExponentialHeightFogComponent.__SetVolumetricDepthFadeDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x000D34D8 File Offset: 0x000D16D8
		public void SetStartDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetStartDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x000D34E6 File Offset: 0x000D16E6
		public void SetSecondFogData(float Density, float HeightFalloff, float HeightOffset)
		{
			UExponentialHeightFogComponent.__SetSecondFogData_Internal(base.NativePtr, Density, HeightFalloff, HeightOffset);
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x000D34F6 File Offset: 0x000D16F6
		public void SetReverseZCenter(float Value)
		{
			UExponentialHeightFogComponent.__SetReverseZCenter_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x000D3504 File Offset: 0x000D1704
		public void SetNonDirectionalInscatteringColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetNonDirectionalInscatteringColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x000D3512 File Offset: 0x000D1712
		public void SetKuroWpoFogCorrYMin(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrYMin_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x000D3520 File Offset: 0x000D1720
		public void SetKuroWpoFogCorrXMin(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrXMin_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x000D352E File Offset: 0x000D172E
		public void SetKuroWpoFogCorrXMax(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrXMax_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x000D353C File Offset: 0x000D173C
		public void SetKuroWpoFogCorrX0(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrX0_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x000D354A File Offset: 0x000D174A
		public void SetKuroWpoFogCorrR(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrR_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x000D3558 File Offset: 0x000D1758
		public void SetKuroWpoFogCorrEnabled(bool Value)
		{
			UExponentialHeightFogComponent.__SetKuroWpoFogCorrEnabled_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x000D3566 File Offset: 0x000D1766
		public void SetKuroSunInscatterSize(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroSunInscatterSize_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x000D3574 File Offset: 0x000D1774
		public void SetKuroSunInscatterColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroSunInscatterColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x000D3582 File Offset: 0x000D1782
		public void SetKuroLowSkyFalloff1(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroLowSkyFalloff1_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x000D3590 File Offset: 0x000D1790
		public void SetKuroLowPoint1(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroLowPoint1_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x000D359E File Offset: 0x000D179E
		public void SetKuroLowHighOffset1(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroLowHighOffset1_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x000D35AC File Offset: 0x000D17AC
		public void SetKuroLowFalloff1(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroLowFalloff1_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x000D35BA File Offset: 0x000D17BA
		public void SetKuroHighPoint1(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroHighPoint1_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x000D35C8 File Offset: 0x000D17C8
		public void SetKuroGICurrentTime(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroGICurrentTime_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x000D35D6 File Offset: 0x000D17D6
		public void SetKuroFogNearFarColorRatio(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogNearFarColorRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x000D35E4 File Offset: 0x000D17E4
		public void SetKuroFogNearColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogNearColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x000D35F2 File Offset: 0x000D17F2
		public void SetKuroFogNearColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogNearColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x000D3600 File Offset: 0x000D1800
		public void SetKuroFogMixWidth(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogMixWidth_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x000D360E File Offset: 0x000D180E
		public void SetKuroFogMixDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogMixDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x000D361C File Offset: 0x000D181C
		public void SetKuroFogFarColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogFarColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x000D362A File Offset: 0x000D182A
		public void SetKuroFogFarColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogFarColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x000D3638 File Offset: 0x000D1838
		public void SetKuroFogBaseColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroFogBaseColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939C RID: 37788 RVA: 0x000D3646 File Offset: 0x000D1846
		public void SetKuroFog1StartDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1StartDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x000D3654 File Offset: 0x000D1854
		public void SetKuroFog1MaxOpacity(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1MaxOpacity_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x000D3662 File Offset: 0x000D1862
		public void SetKuroFog1HeightOffset(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1HeightOffset_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x000D3670 File Offset: 0x000D1870
		public void SetKuroFog1FalloffFarSky(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1FalloffFarSky_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x000D367E File Offset: 0x000D187E
		public void SetKuroFog1Falloff(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1Falloff_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x000D368C File Offset: 0x000D188C
		public void SetKuroFog1Density(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroFog1Density_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x000D369A File Offset: 0x000D189A
		public void SetKuroEffectFogSwitch(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogSwitch_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x000D36A8 File Offset: 0x000D18A8
		public void SetKuroEffectFogStartDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogStartDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x000D36B6 File Offset: 0x000D18B6
		public void SetKuroEffectFogNearFarColorRatio(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogNearFarColorRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x000D36C4 File Offset: 0x000D18C4
		public void SetKuroEffectFogNearColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogNearColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x000D36D2 File Offset: 0x000D18D2
		public void SetKuroEffectFogNearColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogNearColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x000D36E0 File Offset: 0x000D18E0
		public void SetKuroEffectFogMixWidth(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogMixWidth_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x000D36EE File Offset: 0x000D18EE
		public void SetKuroEffectFogMixDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogMixDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x000D36FC File Offset: 0x000D18FC
		public void SetKuroEffectFogMaxOpacity(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogMaxOpacity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x000D370A File Offset: 0x000D190A
		public void SetKuroEffectFogFarColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogFarColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x000D3718 File Offset: 0x000D1918
		public void SetKuroEffectFogFarColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogFarColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x000D3726 File Offset: 0x000D1926
		public void SetKuroEffectFogFalloffFarSky(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogFalloffFarSky_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x000D3734 File Offset: 0x000D1934
		public void SetKuroEffectFogFalloff(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogFalloff_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x000D3742 File Offset: 0x000D1942
		public void SetKuroEffectFogDensity(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogDensity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x000D3750 File Offset: 0x000D1950
		public void SetKuroEffectFogBlendSceneFogMin(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogBlendSceneFogMin_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x000D375E File Offset: 0x000D195E
		public void SetKuroEffectFogBaseColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroEffectFogBaseColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x000D376C File Offset: 0x000D196C
		public void SetKuroDirectionalInscatteringStartDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroDirectionalInscatteringStartDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x000D377A File Offset: 0x000D197A
		public void SetKuroDirectionalInscatteringExponent(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroDirectionalInscatteringExponent_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x000D3788 File Offset: 0x000D1988
		public void SetKuroDirectionalInscatteringColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetKuroDirectionalInscatteringColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x000D3796 File Offset: 0x000D1996
		public void SetKuroDirectionalInscatteringAmount(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroDirectionalInscatteringAmount_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x000D37A4 File Offset: 0x000D19A4
		public void SetKuroDayNightTime(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroDayNightTime_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x000D37B2 File Offset: 0x000D19B2
		public void SetKuroBillboardCloudsNearFogDensity(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroBillboardCloudsNearFogDensity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x000D37C0 File Offset: 0x000D19C0
		public void SetKuroBillboardCloudsFarFogDensity(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroBillboardCloudsFarFogDensity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x000D37CE File Offset: 0x000D19CE
		public void SetKuroBillboardCloudsFadeDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroBillboardCloudsFadeDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x000D37DC File Offset: 0x000D19DC
		public void SetKuroBillboardCloudsBeginDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetKuroBillboardCloudsBeginDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x000D37EA File Offset: 0x000D19EA
		public void SetIsReversed(bool Value)
		{
			UExponentialHeightFogComponent.__SetIsReversed_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x000D37F8 File Offset: 0x000D19F8
		public void SetInscatteringTextureTint(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetInscatteringTextureTint_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x000D3806 File Offset: 0x000D1A06
		public void SetInscatteringColorCubemapAngle(float Value)
		{
			UExponentialHeightFogComponent.__SetInscatteringColorCubemapAngle_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x000D3814 File Offset: 0x000D1A14
		[NullableContext(2)]
		public void SetInscatteringColorCubemap(UTextureCube Value)
		{
			UExponentialHeightFogComponent.__SetInscatteringColorCubemap_Internal(base.NativePtr, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x000D3831 File Offset: 0x000D1A31
		public void SetFullyDirectionalInscatteringColorDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetFullyDirectionalInscatteringColorDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x000D383F File Offset: 0x000D1A3F
		public void SetFogUseCameraLocation(float Value)
		{
			UExponentialHeightFogComponent.__SetFogUseCameraLocation_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x000D384D File Offset: 0x000D1A4D
		public void SetFogUseBaseLocation(float Value)
		{
			UExponentialHeightFogComponent.__SetFogUseBaseLocation_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x000D385B File Offset: 0x000D1A5B
		public void SetFogMaxOpacity(float Value)
		{
			UExponentialHeightFogComponent.__SetFogMaxOpacity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x000D3869 File Offset: 0x000D1A69
		public void SetFogInscatteringColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetFogInscatteringColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x000D3877 File Offset: 0x000D1A77
		public void SetFogHeightFalloff(float Value)
		{
			UExponentialHeightFogComponent.__SetFogHeightFalloff_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x000D3885 File Offset: 0x000D1A85
		public void SetFogDensity(float Value)
		{
			UExponentialHeightFogComponent.__SetFogDensity_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x000D3893 File Offset: 0x000D1A93
		public void SetFogCutoffDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetFogCutoffDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x000D38A1 File Offset: 0x000D1AA1
		public void SetFogBaseLocation(float Value)
		{
			UExponentialHeightFogComponent.__SetFogBaseLocation_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x000D38AF File Offset: 0x000D1AAF
		public void SetDirectionalInscatteringStartDistance(float Value)
		{
			UExponentialHeightFogComponent.__SetDirectionalInscatteringStartDistance_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x000D38BD File Offset: 0x000D1ABD
		public void SetDirectionalInscatteringExponent(float Value)
		{
			UExponentialHeightFogComponent.__SetDirectionalInscatteringExponent_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x000D38CB File Offset: 0x000D1ACB
		public void SetDirectionalInscatteringColor(FLinearColor Value)
		{
			UExponentialHeightFogComponent.__SetDirectionalInscatteringColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x000D38D9 File Offset: 0x000D1AD9
		public void SetbEnableVolumetricSunExposure(bool NewValue)
		{
			UExponentialHeightFogComponent.__SetbEnableVolumetricSunExposure_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x000D38E7 File Offset: 0x000D1AE7
		public void SetbEnableVolumetricLightFunction(bool bNewValue)
		{
			UExponentialHeightFogComponent.__SetbEnableVolumetricLightFunction_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x000D38F5 File Offset: 0x000D1AF5
		public void SetbDisableVolumetricPhase(float NewValue)
		{
			UExponentialHeightFogComponent.__SetbDisableVolumetricPhase_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060093CD RID: 37837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricLocalLightScatteringMultiplier_Internal(IntPtr @this, float Value);

		// Token: 0x060093CE RID: 37838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogTransmittance_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x060093CF RID: 37839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogStaticLightingScatteringIntensity_Internal(IntPtr @this, float Value);

		// Token: 0x060093D0 RID: 37840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogSkyLightIntensity_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D1 RID: 37841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogScatteringDistribution_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D2 RID: 37842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogNewPhaseFadeRange_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D3 RID: 37843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogNearFadeInDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D4 RID: 37844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogExtinctionScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D5 RID: 37845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogEmissive_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x060093D6 RID: 37846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093D7 RID: 37847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogDirectionalLightIntensity_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093D8 RID: 37848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogDensity_Internal(IntPtr @this, float bNewValue);

		// Token: 0x060093D9 RID: 37849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFogAlbedo_Internal(IntPtr @this, FColor NewValue);

		// Token: 0x060093DA RID: 37850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricFog_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x060093DB RID: 37851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricDepthFadeDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x060093DC RID: 37852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093DD RID: 37853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSecondFogData_Internal(IntPtr @this, float Density, float HeightFalloff, float HeightOffset);

		// Token: 0x060093DE RID: 37854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverseZCenter_Internal(IntPtr @this, float Value);

		// Token: 0x060093DF RID: 37855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNonDirectionalInscatteringColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093E0 RID: 37856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrYMin_Internal(IntPtr @this, float Value);

		// Token: 0x060093E1 RID: 37857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrXMin_Internal(IntPtr @this, float Value);

		// Token: 0x060093E2 RID: 37858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrXMax_Internal(IntPtr @this, float Value);

		// Token: 0x060093E3 RID: 37859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrX0_Internal(IntPtr @this, float Value);

		// Token: 0x060093E4 RID: 37860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrR_Internal(IntPtr @this, float Value);

		// Token: 0x060093E5 RID: 37861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroWpoFogCorrEnabled_Internal(IntPtr @this, bool Value);

		// Token: 0x060093E6 RID: 37862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSunInscatterSize_Internal(IntPtr @this, float Value);

		// Token: 0x060093E7 RID: 37863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSunInscatterColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x060093E8 RID: 37864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroLowSkyFalloff1_Internal(IntPtr @this, float Value);

		// Token: 0x060093E9 RID: 37865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroLowPoint1_Internal(IntPtr @this, float Value);

		// Token: 0x060093EA RID: 37866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroLowHighOffset1_Internal(IntPtr @this, float Value);

		// Token: 0x060093EB RID: 37867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroLowFalloff1_Internal(IntPtr @this, float Value);

		// Token: 0x060093EC RID: 37868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroHighPoint1_Internal(IntPtr @this, float Value);

		// Token: 0x060093ED RID: 37869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroGICurrentTime_Internal(IntPtr @this, float Value);

		// Token: 0x060093EE RID: 37870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogNearFarColorRatio_Internal(IntPtr @this, float Value);

		// Token: 0x060093EF RID: 37871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogNearColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093F0 RID: 37872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogNearColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x060093F1 RID: 37873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogMixWidth_Internal(IntPtr @this, float Value);

		// Token: 0x060093F2 RID: 37874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogMixDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093F3 RID: 37875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogFarColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093F4 RID: 37876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogFarColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x060093F5 RID: 37877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFogBaseColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x060093F6 RID: 37878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1StartDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093F7 RID: 37879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1MaxOpacity_Internal(IntPtr @this, float Value);

		// Token: 0x060093F8 RID: 37880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1HeightOffset_Internal(IntPtr @this, float Value);

		// Token: 0x060093F9 RID: 37881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1FalloffFarSky_Internal(IntPtr @this, float Value);

		// Token: 0x060093FA RID: 37882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1Falloff_Internal(IntPtr @this, float Value);

		// Token: 0x060093FB RID: 37883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFog1Density_Internal(IntPtr @this, float Value);

		// Token: 0x060093FC RID: 37884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogSwitch_Internal(IntPtr @this, float Value);

		// Token: 0x060093FD RID: 37885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogStartDistance_Internal(IntPtr @this, float Value);

		// Token: 0x060093FE RID: 37886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogNearFarColorRatio_Internal(IntPtr @this, float Value);

		// Token: 0x060093FF RID: 37887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogNearColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009400 RID: 37888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogNearColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x06009401 RID: 37889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogMixWidth_Internal(IntPtr @this, float Value);

		// Token: 0x06009402 RID: 37890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogMixDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009403 RID: 37891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogMaxOpacity_Internal(IntPtr @this, float Value);

		// Token: 0x06009404 RID: 37892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogFarColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009405 RID: 37893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogFarColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x06009406 RID: 37894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogFalloffFarSky_Internal(IntPtr @this, float Value);

		// Token: 0x06009407 RID: 37895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogFalloff_Internal(IntPtr @this, float Value);

		// Token: 0x06009408 RID: 37896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogDensity_Internal(IntPtr @this, float Value);

		// Token: 0x06009409 RID: 37897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogBlendSceneFogMin_Internal(IntPtr @this, float Value);

		// Token: 0x0600940A RID: 37898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroEffectFogBaseColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x0600940B RID: 37899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDirectionalInscatteringStartDistance_Internal(IntPtr @this, float Value);

		// Token: 0x0600940C RID: 37900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDirectionalInscatteringExponent_Internal(IntPtr @this, float Value);

		// Token: 0x0600940D RID: 37901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDirectionalInscatteringColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x0600940E RID: 37902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDirectionalInscatteringAmount_Internal(IntPtr @this, float Value);

		// Token: 0x0600940F RID: 37903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDayNightTime_Internal(IntPtr @this, float Value);

		// Token: 0x06009410 RID: 37904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroBillboardCloudsNearFogDensity_Internal(IntPtr @this, float Value);

		// Token: 0x06009411 RID: 37905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroBillboardCloudsFarFogDensity_Internal(IntPtr @this, float Value);

		// Token: 0x06009412 RID: 37906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroBillboardCloudsFadeDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009413 RID: 37907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroBillboardCloudsBeginDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009414 RID: 37908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReversed_Internal(IntPtr @this, bool Value);

		// Token: 0x06009415 RID: 37909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInscatteringTextureTint_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x06009416 RID: 37910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInscatteringColorCubemapAngle_Internal(IntPtr @this, float Value);

		// Token: 0x06009417 RID: 37911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInscatteringColorCubemap_Internal(IntPtr @this, IntPtr Value);

		// Token: 0x06009418 RID: 37912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFullyDirectionalInscatteringColorDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009419 RID: 37913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogUseCameraLocation_Internal(IntPtr @this, float Value);

		// Token: 0x0600941A RID: 37914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogUseBaseLocation_Internal(IntPtr @this, float Value);

		// Token: 0x0600941B RID: 37915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogMaxOpacity_Internal(IntPtr @this, float Value);

		// Token: 0x0600941C RID: 37916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogInscatteringColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x0600941D RID: 37917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogHeightFalloff_Internal(IntPtr @this, float Value);

		// Token: 0x0600941E RID: 37918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogDensity_Internal(IntPtr @this, float Value);

		// Token: 0x0600941F RID: 37919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogCutoffDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009420 RID: 37920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogBaseLocation_Internal(IntPtr @this, float Value);

		// Token: 0x06009421 RID: 37921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirectionalInscatteringStartDistance_Internal(IntPtr @this, float Value);

		// Token: 0x06009422 RID: 37922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirectionalInscatteringExponent_Internal(IntPtr @this, float Value);

		// Token: 0x06009423 RID: 37923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirectionalInscatteringColor_Internal(IntPtr @this, FLinearColor Value);

		// Token: 0x06009424 RID: 37924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetbEnableVolumetricSunExposure_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009425 RID: 37925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetbEnableVolumetricLightFunction_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06009426 RID: 37926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetbDisableVolumetricPhase_Internal(IntPtr @this, float NewValue);

		// Token: 0x06009427 RID: 37927 RVA: 0x000D3903 File Offset: 0x000D1B03
		static UExponentialHeightFogComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ExponentialHeightFogComponent");
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x000D3911 File Offset: 0x000D1B11
		protected UExponentialHeightFogComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040052E9 RID: 21225
		public new const string __ObjectPath = "/Script/Engine.ExponentialHeightFogComponent";

		// Token: 0x040052EA RID: 21226
		private static IntPtr _ClassPtr;

		// Token: 0x040052EB RID: 21227
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040052EC RID: 21228
		internal static int __PropertyOffset_KuroDirectionalInscatteringColor;

		// Token: 0x040052ED RID: 21229
		internal static int __PropertyOffset_KuroDirectionalInscatteringAmount;

		// Token: 0x040052EE RID: 21230
		internal static int __PropertyOffset_KuroDirectionalInscatteringExponent;

		// Token: 0x040052EF RID: 21231
		internal static int __PropertyOffset_KuroDirectionalInscatteringStartDistance;

		// Token: 0x040052F0 RID: 21232
		internal static int __PropertyOffset_KuroFog1Density;

		// Token: 0x040052F1 RID: 21233
		internal static int __PropertyOffset_KuroFog1HeightOffset;

		// Token: 0x040052F2 RID: 21234
		internal static int __PropertyOffset_KuroFog1Falloff;

		// Token: 0x040052F3 RID: 21235
		internal static int __PropertyOffset_KuroFog1FalloffFarSky;

		// Token: 0x040052F4 RID: 21236
		internal static int __PropertyOffset_KuroFog1StartDistance;

		// Token: 0x040052F5 RID: 21237
		internal static int __PropertyOffset_KuroFog1MaxOpacity;

		// Token: 0x040052F6 RID: 21238
		internal static int __PropertyOffset_KuroFogNearColor;

		// Token: 0x040052F7 RID: 21239
		internal static int __PropertyOffset_KuroFogFarColor;

		// Token: 0x040052F8 RID: 21240
		internal static int __PropertyOffset_KuroFogBaseColor;

		// Token: 0x040052F9 RID: 21241
		internal static int __PropertyOffset_KuroFogNearColorDistance;

		// Token: 0x040052FA RID: 21242
		internal static int __PropertyOffset_KuroFogFarColorDistance;

		// Token: 0x040052FB RID: 21243
		internal static int __PropertyOffset_KuroFogNearFarColorRatio;

		// Token: 0x040052FC RID: 21244
		internal static int __PropertyOffset_KuroFogMixDistance;

		// Token: 0x040052FD RID: 21245
		internal static int __PropertyOffset_KuroFogMixWidth;

		// Token: 0x040052FE RID: 21246
		internal static int __PropertyOffset_KuroLowPoint1;

		// Token: 0x040052FF RID: 21247
		internal static int __PropertyOffset_KuroHighPoint1;

		// Token: 0x04005300 RID: 21248
		internal static int __PropertyOffset_KuroLowFalloff1;

		// Token: 0x04005301 RID: 21249
		internal static int __PropertyOffset_KuroLowSkyFalloff1;

		// Token: 0x04005302 RID: 21250
		internal static int __PropertyOffset_KuroLowHighOffset1;

		// Token: 0x04005303 RID: 21251
		internal static int __PropertyOffset_ReverseZCenter;

		// Token: 0x04005304 RID: 21252
		internal static int __PropertyOffset_IsReversed;

		// Token: 0x04005305 RID: 21253
		internal static int __PropertyOffset_KuroEffectFogSwitch;

		// Token: 0x04005306 RID: 21254
		internal static int __PropertyOffset_KuroEffectFogBlendSceneFogMin;

		// Token: 0x04005307 RID: 21255
		internal static int __PropertyOffset_KuroEffectFogDensity;

		// Token: 0x04005308 RID: 21256
		internal static int __PropertyOffset_KuroEffectFogFalloff;

		// Token: 0x04005309 RID: 21257
		internal static int __PropertyOffset_KuroEffectFogFalloffFarSky;

		// Token: 0x0400530A RID: 21258
		internal static int __PropertyOffset_KuroEffectFogStartDistance;

		// Token: 0x0400530B RID: 21259
		internal static int __PropertyOffset_KuroEffectFogMaxOpacity;

		// Token: 0x0400530C RID: 21260
		internal static int __PropertyOffset_KuroEffectFogNearColor;

		// Token: 0x0400530D RID: 21261
		internal static int __PropertyOffset_KuroEffectFogFarColor;

		// Token: 0x0400530E RID: 21262
		internal static int __PropertyOffset_KuroEffectFogBaseColor;

		// Token: 0x0400530F RID: 21263
		internal static int __PropertyOffset_KuroEffectFogNearColorDistance;

		// Token: 0x04005310 RID: 21264
		internal static int __PropertyOffset_KuroEffectFogFarColorDistance;

		// Token: 0x04005311 RID: 21265
		internal static int __PropertyOffset_KuroEffectFogNearFarColorRatio;

		// Token: 0x04005312 RID: 21266
		internal static int __PropertyOffset_KuroEffectFogMixDistance;

		// Token: 0x04005313 RID: 21267
		internal static int __PropertyOffset_KuroEffectFogMixWidth;

		// Token: 0x04005314 RID: 21268
		internal static int __PropertyOffset_KuroBillboardCloudsNearFogDensity;

		// Token: 0x04005315 RID: 21269
		internal static int __PropertyOffset_KuroBillboardCloudsFarFogDensity;

		// Token: 0x04005316 RID: 21270
		internal static int __PropertyOffset_KuroBillboardCloudsBeginDistance;

		// Token: 0x04005317 RID: 21271
		internal static int __PropertyOffset_KuroBillboardCloudsFadeDistance;

		// Token: 0x04005318 RID: 21272
		internal static int __PropertyOffset_KuroGICurrentTime;

		// Token: 0x04005319 RID: 21273
		internal static int __PropertyOffset_KuroDayNightTime;

		// Token: 0x0400531A RID: 21274
		internal static int __PropertyOffset_KuroSunInscatterColor;

		// Token: 0x0400531B RID: 21275
		internal static int __PropertyOffset_KuroSunInscatterSize;

		// Token: 0x0400531C RID: 21276
		internal static int __PropertyOffset_bKuroWpoFogCorrEnabled;

		// Token: 0x0400531D RID: 21277
		internal static int __PropertyOffset_KuroWpoFogCorrX0;

		// Token: 0x0400531E RID: 21278
		internal static int __PropertyOffset_KuroWpoFogCorrR;

		// Token: 0x0400531F RID: 21279
		internal static int __PropertyOffset_KuroWpoFogCorrXMin;

		// Token: 0x04005320 RID: 21280
		internal static int __PropertyOffset_KuroWpoFogCorrXMax;

		// Token: 0x04005321 RID: 21281
		internal static int __PropertyOffset_KuroWpoFogCorrYMin;

		// Token: 0x04005322 RID: 21282
		internal static int __PropertyOffset_FogBaseLocation;

		// Token: 0x04005323 RID: 21283
		internal static int __PropertyOffset_FogUseBaseLocation;

		// Token: 0x04005324 RID: 21284
		internal static int __PropertyOffset_FogUseCameraLocation;

		// Token: 0x04005325 RID: 21285
		internal static int __PropertyOffset_FogDensity;

		// Token: 0x04005326 RID: 21286
		internal static int __PropertyOffset_FogHeightFalloff;

		// Token: 0x04005327 RID: 21287
		internal static int __PropertyOffset_SecondFogData;

		// Token: 0x04005328 RID: 21288
		[Nullable(2)]
		private FExponentialHeightFogData _SecondFogData;

		// Token: 0x04005329 RID: 21289
		internal static int __PropertyOffset_FogInscatteringColor;

		// Token: 0x0400532A RID: 21290
		internal static int __PropertyOffset_InscatteringColorCubemap;

		// Token: 0x0400532B RID: 21291
		internal static int __PropertyOffset_InscatteringColorCubemapAngle;

		// Token: 0x0400532C RID: 21292
		internal static int __PropertyOffset_InscatteringTextureTint;

		// Token: 0x0400532D RID: 21293
		internal static int __PropertyOffset_FullyDirectionalInscatteringColorDistance;

		// Token: 0x0400532E RID: 21294
		internal static int __PropertyOffset_NonDirectionalInscatteringColorDistance;

		// Token: 0x0400532F RID: 21295
		internal static int __PropertyOffset_DirectionalInscatteringExponent;

		// Token: 0x04005330 RID: 21296
		internal static int __PropertyOffset_DirectionalInscatteringStartDistance;

		// Token: 0x04005331 RID: 21297
		internal static int __PropertyOffset_DirectionalInscatteringColor;

		// Token: 0x04005332 RID: 21298
		internal static int __PropertyOffset_FogMaxOpacity;

		// Token: 0x04005333 RID: 21299
		internal static int __PropertyOffset_StartDistance;

		// Token: 0x04005334 RID: 21300
		internal static int __PropertyOffset_FogCutoffDistance;

		// Token: 0x04005335 RID: 21301
		internal static int __PropertyOffset_bEnableVolumetricFog;

		// Token: 0x04005336 RID: 21302
		internal static int __PropertyOffset_VolumetricFogNearFadeInDistance;

		// Token: 0x04005337 RID: 21303
		internal static int __PropertyOffset_VolumetricFogDensity;

		// Token: 0x04005338 RID: 21304
		internal static int __PropertyOffset_bEnableVolumetricLightFunction;

		// Token: 0x04005339 RID: 21305
		internal static int __PropertyOffset_bEnableVolumetricLightFunctionRestore;

		// Token: 0x0400533A RID: 21306
		internal static int __PropertyOffset_VolumetricFogScatteringDistribution;

		// Token: 0x0400533B RID: 21307
		internal static int __PropertyOffset_VolumetricFogAlbedo;

		// Token: 0x0400533C RID: 21308
		internal static int __PropertyOffset_VolumetricFogTransmittance;

		// Token: 0x0400533D RID: 21309
		internal static int __PropertyOffset_bEnableVolumetricSunExposure;

		// Token: 0x0400533E RID: 21310
		internal static int __PropertyOffset_VolumetricDepthFadeDistance;

		// Token: 0x0400533F RID: 21311
		internal static int __PropertyOffset_bDisableVolumetricPhase;

		// Token: 0x04005340 RID: 21312
		internal static int __PropertyOffset_VolumetricFogNewPhaseFadeRange;

		// Token: 0x04005341 RID: 21313
		internal static int __PropertyOffset_VolumetricFogEmissive;

		// Token: 0x04005342 RID: 21314
		internal static int __PropertyOffset_VolumetricFogSkyLightIntensity;

		// Token: 0x04005343 RID: 21315
		internal static int __PropertyOffset_VolumetricFogDirectionalLightIntensity;

		// Token: 0x04005344 RID: 21316
		internal static int __PropertyOffset_VolumetricFogExtinctionScale;

		// Token: 0x04005345 RID: 21317
		internal static int __PropertyOffset_VolumetricFogDistance;

		// Token: 0x04005346 RID: 21318
		internal static int __PropertyOffset_VolumetricFogStaticLightingScatteringIntensity;

		// Token: 0x04005347 RID: 21319
		internal static int __PropertyOffset_VolumetricFogLocalLightScatteringMultiplier;

		// Token: 0x04005348 RID: 21320
		internal static int __PropertyOffset_bOverrideLightColorsWithFogInscatteringColors;
	}
}
