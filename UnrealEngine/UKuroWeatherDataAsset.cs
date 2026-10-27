using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE5 RID: 7141
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset")]
	[UnrealStructLayout(5248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5248)]
	public class UKuroWeatherDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B73A RID: 112442 RVA: 0x00286DF0 File Offset: 0x00284FF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWeatherDataAsset._ClassPtr;
		}

		// Token: 0x0601B73B RID: 112443 RVA: 0x00286DFC File Offset: 0x00284FFC
		public UKuroWeatherDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroWeatherDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B73C RID: 112444 RVA: 0x00286E24 File Offset: 0x00285024
		public UKuroWeatherDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWeatherDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E66 RID: 28262
		// (get) Token: 0x0601B73D RID: 112445 RVA: 0x00286E57 File Offset: 0x00285057
		// (set) Token: 0x0601B73E RID: 112446 RVA: 0x00286E67 File Offset: 0x00285067
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

		// Token: 0x17006E67 RID: 28263
		// (get) Token: 0x0601B73F RID: 112447 RVA: 0x00286E78 File Offset: 0x00285078
		// (set) Token: 0x0601B740 RID: 112448 RVA: 0x00286E88 File Offset: 0x00285088
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

		// Token: 0x17006E68 RID: 28264
		// (get) Token: 0x0601B741 RID: 112449 RVA: 0x00286E99 File Offset: 0x00285099
		// (set) Token: 0x0601B742 RID: 112450 RVA: 0x00286EA9 File Offset: 0x002850A9
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

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x0601B743 RID: 112451 RVA: 0x00286EBA File Offset: 0x002850BA
		// (set) Token: 0x0601B744 RID: 112452 RVA: 0x00286ECA File Offset: 0x002850CA
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

		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x0601B745 RID: 112453 RVA: 0x00286EDB File Offset: 0x002850DB
		// (set) Token: 0x0601B746 RID: 112454 RVA: 0x00286EEB File Offset: 0x002850EB
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

		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x0601B747 RID: 112455 RVA: 0x00286EFC File Offset: 0x002850FC
		// (set) Token: 0x0601B748 RID: 112456 RVA: 0x00286F0C File Offset: 0x0028510C
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

		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x0601B749 RID: 112457 RVA: 0x00286F1D File Offset: 0x0028511D
		// (set) Token: 0x0601B74A RID: 112458 RVA: 0x00286F2D File Offset: 0x0028512D
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

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x0601B74B RID: 112459 RVA: 0x00286F3E File Offset: 0x0028513E
		// (set) Token: 0x0601B74C RID: 112460 RVA: 0x00286F4E File Offset: 0x0028514E
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

		// Token: 0x17006E6E RID: 28270
		// (get) Token: 0x0601B74D RID: 112461 RVA: 0x00286F5F File Offset: 0x0028515F
		// (set) Token: 0x0601B74E RID: 112462 RVA: 0x00286F6F File Offset: 0x0028516F
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

		// Token: 0x17006E6F RID: 28271
		// (get) Token: 0x0601B74F RID: 112463 RVA: 0x00286F80 File Offset: 0x00285180
		// (set) Token: 0x0601B750 RID: 112464 RVA: 0x00286F90 File Offset: 0x00285190
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

		// Token: 0x17006E70 RID: 28272
		// (get) Token: 0x0601B751 RID: 112465 RVA: 0x00286FA1 File Offset: 0x002851A1
		// (set) Token: 0x0601B752 RID: 112466 RVA: 0x00286FB1 File Offset: 0x002851B1
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

		// Token: 0x17006E71 RID: 28273
		// (get) Token: 0x0601B753 RID: 112467 RVA: 0x00286FC2 File Offset: 0x002851C2
		// (set) Token: 0x0601B754 RID: 112468 RVA: 0x00286FD2 File Offset: 0x002851D2
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

		// Token: 0x17006E72 RID: 28274
		// (get) Token: 0x0601B755 RID: 112469 RVA: 0x00286FE3 File Offset: 0x002851E3
		// (set) Token: 0x0601B756 RID: 112470 RVA: 0x00286FF3 File Offset: 0x002851F3
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

		// Token: 0x17006E73 RID: 28275
		// (get) Token: 0x0601B757 RID: 112471 RVA: 0x00287004 File Offset: 0x00285204
		// (set) Token: 0x0601B758 RID: 112472 RVA: 0x00287018 File Offset: 0x00285218
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

		// Token: 0x17006E74 RID: 28276
		// (get) Token: 0x0601B759 RID: 112473 RVA: 0x0028702D File Offset: 0x0028522D
		// (set) Token: 0x0601B75A RID: 112474 RVA: 0x0028703D File Offset: 0x0028523D
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

		// Token: 0x17006E75 RID: 28277
		// (get) Token: 0x0601B75B RID: 112475 RVA: 0x0028704E File Offset: 0x0028524E
		// (set) Token: 0x0601B75C RID: 112476 RVA: 0x0028705E File Offset: 0x0028525E
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

		// Token: 0x17006E76 RID: 28278
		// (get) Token: 0x0601B75D RID: 112477 RVA: 0x00287070 File Offset: 0x00285270
		// (set) Token: 0x0601B75E RID: 112478 RVA: 0x002870A9 File Offset: 0x002852A9
		public FKuroGISetting GISetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGISetting result;
				if ((result = this._GISetting) == null)
				{
					result = (this._GISetting = new FKuroGISetting(base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_GISetting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGISetting.StaticStruct(), base.NativePtr + (IntPtr)UKuroWeatherDataAsset.__PropertyOffset_GISetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B75F RID: 112479 RVA: 0x002870CA File Offset: 0x002852CA
		static UKuroWeatherDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset");
		}

		// Token: 0x0601B760 RID: 112480 RVA: 0x002870D8 File Offset: 0x002852D8
		protected UKuroWeatherDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC57 RID: 60503
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherDataAsset";

		// Token: 0x0400EC58 RID: 60504
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC59 RID: 60505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC5A RID: 60506
		internal static int __PropertyOffset_UseOnlyOverrideProperty;

		// Token: 0x0400EC5B RID: 60507
		internal static int __PropertyOffset_bPolarDaynight;

		// Token: 0x0400EC5C RID: 60508
		internal static int __PropertyOffset_bSpecialBlend;

		// Token: 0x0400EC5D RID: 60509
		internal static int __PropertyOffset_UseFixedTime;

		// Token: 0x0400EC5E RID: 60510
		internal static int __PropertyOffset_FixedTime;

		// Token: 0x0400EC5F RID: 60511
		internal static int __PropertyOffset_UseFixedSunAngle;

		// Token: 0x0400EC60 RID: 60512
		internal static int __PropertyOffset_FixedSunHorizonAngle;

		// Token: 0x0400EC61 RID: 60513
		internal static int __PropertyOffset_FixedSunVerticalAngle;

		// Token: 0x0400EC62 RID: 60514
		internal static int __PropertyOffset_IsReversed;

		// Token: 0x0400EC63 RID: 60515
		internal static int __PropertyOffset_ReverseZCenter;

		// Token: 0x0400EC64 RID: 60516
		internal static int __PropertyOffset_DisableGlobalGITransition;

		// Token: 0x0400EC65 RID: 60517
		internal static int __PropertyOffset_DisableSkyBlendingSkip;

		// Token: 0x0400EC66 RID: 60518
		internal static int __PropertyOffset_bLockSceneLightVerticalAngle;

		// Token: 0x0400EC67 RID: 60519
		internal static int __PropertyOffset_SceneLightVerticalAngleRange;

		// Token: 0x0400EC68 RID: 60520
		internal static int __PropertyOffset_ForbidWeatherWhenTakeOver;

		// Token: 0x0400EC69 RID: 60521
		internal static int __PropertyOffset_ForbidWeatherThreshold;

		// Token: 0x0400EC6A RID: 60522
		internal static int __PropertyOffset_GISetting;

		// Token: 0x0400EC6B RID: 60523
		[Nullable(2)]
		private FKuroGISetting _GISetting;
	}
}
