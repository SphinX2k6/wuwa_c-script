using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004ED RID: 1261
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset")]
	[UnrealStructLayout(5264, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5264)]
	public class UKuroWeatherDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060076E4 RID: 30436 RVA: 0x000ADBB2 File Offset: 0x000ABDB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWeatherDataAsset._ClassPtr;
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x000ADBC0 File Offset: 0x000ABDC0
		public UKuroWeatherDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroWeatherDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x000ADBE8 File Offset: 0x000ABDE8
		[NullableContext(1)]
		public UKuroWeatherDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWeatherDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x000ADC1B File Offset: 0x000ABE1B
		// (set) Token: 0x060076E8 RID: 30440 RVA: 0x000ADC2B File Offset: 0x000ABE2B
		public unsafe bool UseOnlyOverrideProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseOnlyOverrideProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseOnlyOverrideProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x060076E9 RID: 30441 RVA: 0x000ADC3C File Offset: 0x000ABE3C
		// (set) Token: 0x060076EA RID: 30442 RVA: 0x000ADC4C File Offset: 0x000ABE4C
		public unsafe bool bPolarDaynight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bPolarDaynight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bPolarDaynight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x060076EB RID: 30443 RVA: 0x000ADC5D File Offset: 0x000ABE5D
		// (set) Token: 0x060076EC RID: 30444 RVA: 0x000ADC6D File Offset: 0x000ABE6D
		public unsafe bool bSpecialBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bSpecialBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bSpecialBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x000ADC7E File Offset: 0x000ABE7E
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x000ADC8E File Offset: 0x000ABE8E
		public unsafe bool UseFixedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseFixedTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseFixedTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x000ADC9F File Offset: 0x000ABE9F
		// (set) Token: 0x060076F0 RID: 30448 RVA: 0x000ADCAF File Offset: 0x000ABEAF
		public unsafe float FixedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedTime) = value;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x000ADCC0 File Offset: 0x000ABEC0
		// (set) Token: 0x060076F2 RID: 30450 RVA: 0x000ADCD0 File Offset: 0x000ABED0
		public unsafe bool UseFixedSunAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseFixedSunAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_UseFixedSunAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x060076F3 RID: 30451 RVA: 0x000ADCE1 File Offset: 0x000ABEE1
		// (set) Token: 0x060076F4 RID: 30452 RVA: 0x000ADCF1 File Offset: 0x000ABEF1
		public unsafe float FixedSunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedSunHorizonAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedSunHorizonAngle) = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x000ADD02 File Offset: 0x000ABF02
		// (set) Token: 0x060076F6 RID: 30454 RVA: 0x000ADD12 File Offset: 0x000ABF12
		public unsafe float FixedSunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedSunVerticalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_FixedSunVerticalAngle) = value;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x060076F7 RID: 30455 RVA: 0x000ADD23 File Offset: 0x000ABF23
		// (set) Token: 0x060076F8 RID: 30456 RVA: 0x000ADD33 File Offset: 0x000ABF33
		public unsafe bool IsReversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_IsReversed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_IsReversed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x000ADD44 File Offset: 0x000ABF44
		// (set) Token: 0x060076FA RID: 30458 RVA: 0x000ADD54 File Offset: 0x000ABF54
		public unsafe float ReverseZCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ReverseZCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ReverseZCenter) = value;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x000ADD65 File Offset: 0x000ABF65
		// (set) Token: 0x060076FC RID: 30460 RVA: 0x000ADD75 File Offset: 0x000ABF75
		public unsafe bool DisableGlobalGITransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_DisableGlobalGITransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_DisableGlobalGITransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x000ADD86 File Offset: 0x000ABF86
		// (set) Token: 0x060076FE RID: 30462 RVA: 0x000ADD96 File Offset: 0x000ABF96
		public unsafe bool DisableSkyBlendingSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_DisableSkyBlendingSkip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_DisableSkyBlendingSkip) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x060076FF RID: 30463 RVA: 0x000ADDA7 File Offset: 0x000ABFA7
		// (set) Token: 0x06007700 RID: 30464 RVA: 0x000ADDB7 File Offset: 0x000ABFB7
		public unsafe bool bLockSceneLightVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bLockSceneLightVerticalAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_bLockSceneLightVerticalAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x000ADDC8 File Offset: 0x000ABFC8
		// (set) Token: 0x06007702 RID: 30466 RVA: 0x000ADDDC File Offset: 0x000ABFDC
		public unsafe FVector2D SceneLightVerticalAngleRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_SceneLightVerticalAngleRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_SceneLightVerticalAngleRange) = value;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x000ADDF1 File Offset: 0x000ABFF1
		// (set) Token: 0x06007704 RID: 30468 RVA: 0x000ADE01 File Offset: 0x000AC001
		public unsafe bool ForbidWeatherWhenTakeOver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ForbidWeatherWhenTakeOver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ForbidWeatherWhenTakeOver) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007705 RID: 30469 RVA: 0x000ADE12 File Offset: 0x000AC012
		// (set) Token: 0x06007706 RID: 30470 RVA: 0x000ADE22 File Offset: 0x000AC022
		public unsafe float ForbidWeatherThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ForbidWeatherThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_ForbidWeatherThreshold) = value;
			}
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x000ADE33 File Offset: 0x000AC033
		static UKuroWeatherDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset");
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x000ADE41 File Offset: 0x000AC041
		protected UKuroWeatherDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400321E RID: 12830
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset";

		// Token: 0x0400321F RID: 12831
		private static IntPtr _ClassPtr;

		// Token: 0x04003220 RID: 12832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003221 RID: 12833
		internal static int __PropertyOffset_UseOnlyOverrideProperty;

		// Token: 0x04003222 RID: 12834
		internal static int __PropertyOffset_bPolarDaynight;

		// Token: 0x04003223 RID: 12835
		internal static int __PropertyOffset_bSpecialBlend;

		// Token: 0x04003224 RID: 12836
		internal static int __PropertyOffset_UseFixedTime;

		// Token: 0x04003225 RID: 12837
		internal static int __PropertyOffset_FixedTime;

		// Token: 0x04003226 RID: 12838
		internal static int __PropertyOffset_UseFixedSunAngle;

		// Token: 0x04003227 RID: 12839
		internal static int __PropertyOffset_FixedSunHorizonAngle;

		// Token: 0x04003228 RID: 12840
		internal static int __PropertyOffset_FixedSunVerticalAngle;

		// Token: 0x04003229 RID: 12841
		internal static int __PropertyOffset_IsReversed;

		// Token: 0x0400322A RID: 12842
		internal static int __PropertyOffset_ReverseZCenter;

		// Token: 0x0400322B RID: 12843
		internal static int __PropertyOffset_DisableGlobalGITransition;

		// Token: 0x0400322C RID: 12844
		internal static int __PropertyOffset_DisableSkyBlendingSkip;

		// Token: 0x0400322D RID: 12845
		internal static int __PropertyOffset_bLockSceneLightVerticalAngle;

		// Token: 0x0400322E RID: 12846
		internal static int __PropertyOffset_SceneLightVerticalAngleRange;

		// Token: 0x0400322F RID: 12847
		internal static int __PropertyOffset_ForbidWeatherWhenTakeOver;

		// Token: 0x04003230 RID: 12848
		internal static int __PropertyOffset_ForbidWeatherThreshold;
	}
}
