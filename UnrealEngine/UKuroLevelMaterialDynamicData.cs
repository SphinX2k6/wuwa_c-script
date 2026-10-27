using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E3 RID: 6371
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelMaterialDynamicData")]
	[UnrealStructLayout(10856, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 10856)]
	public class UKuroLevelMaterialDynamicData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601797E RID: 96638 RVA: 0x00228E51 File Offset: 0x00227051
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelMaterialDynamicData._ClassPtr;
		}

		// Token: 0x0601797F RID: 96639 RVA: 0x00228E60 File Offset: 0x00227060
		public UKuroLevelMaterialDynamicData() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelMaterialDynamicData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017980 RID: 96640 RVA: 0x00228E88 File Offset: 0x00227088
		public UKuroLevelMaterialDynamicData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelMaterialDynamicData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x06017981 RID: 96641 RVA: 0x00228EBB File Offset: 0x002270BB
		// (set) Token: 0x06017982 RID: 96642 RVA: 0x00228ECB File Offset: 0x002270CB
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x06017983 RID: 96643 RVA: 0x00228EDC File Offset: 0x002270DC
		// (set) Token: 0x06017984 RID: 96644 RVA: 0x00228EEC File Offset: 0x002270EC
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x17005EF9 RID: 24313
		// (get) Token: 0x06017985 RID: 96645 RVA: 0x00228EFD File Offset: 0x002270FD
		// (set) Token: 0x06017986 RID: 96646 RVA: 0x00228F0D File Offset: 0x0022710D
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EndTime) = value;
			}
		}

		// Token: 0x17005EFA RID: 24314
		// (get) Token: 0x06017987 RID: 96647 RVA: 0x00228F1E File Offset: 0x0022711E
		// (set) Token: 0x06017988 RID: 96648 RVA: 0x00228F2E File Offset: 0x0022712E
		public unsafe bool bEnableBaseColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableBaseColorScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableBaseColorScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x06017989 RID: 96649 RVA: 0x00228F40 File Offset: 0x00227140
		// (set) Token: 0x0601798A RID: 96650 RVA: 0x00228F79 File Offset: 0x00227179
		public FKuroCurveFloat BaseColorScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BaseColorScale) == null)
				{
					result = (this._BaseColorScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_BaseColorScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_BaseColorScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0601798B RID: 96651 RVA: 0x00228F9A File Offset: 0x0022719A
		// (set) Token: 0x0601798C RID: 96652 RVA: 0x00228FAA File Offset: 0x002271AA
		public unsafe bool bEnableAddEmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableAddEmissionColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableAddEmissionColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x0601798D RID: 96653 RVA: 0x00228FBC File Offset: 0x002271BC
		// (set) Token: 0x0601798E RID: 96654 RVA: 0x00228FF5 File Offset: 0x002271F5
		public FKuroCurveLinearColor AddEmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._AddEmissionColor) == null)
				{
					result = (this._AddEmissionColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_AddEmissionColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_AddEmissionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x0601798F RID: 96655 RVA: 0x00229016 File Offset: 0x00227216
		// (set) Token: 0x06017990 RID: 96656 RVA: 0x00229026 File Offset: 0x00227226
		public unsafe bool bEnableRimLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableRimLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableRimLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x06017991 RID: 96657 RVA: 0x00229038 File Offset: 0x00227238
		// (set) Token: 0x06017992 RID: 96658 RVA: 0x00229071 File Offset: 0x00227271
		public FKuroCurveLinearColor RimLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._RimLightColor) == null)
				{
					result = (this._RimLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimLightColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimLightColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x06017993 RID: 96659 RVA: 0x00229094 File Offset: 0x00227294
		// (set) Token: 0x06017994 RID: 96660 RVA: 0x002290CD File Offset: 0x002272CD
		public FKuroCurveFloat RimPower
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RimPower) == null)
				{
					result = (this._RimPower = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimPower, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimPower, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x06017995 RID: 96661 RVA: 0x002290EE File Offset: 0x002272EE
		// (set) Token: 0x06017996 RID: 96662 RVA: 0x002290FE File Offset: 0x002272FE
		public unsafe bool bEnableEmissionChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableEmissionChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableEmissionChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x06017997 RID: 96663 RVA: 0x00229110 File Offset: 0x00227310
		// (set) Token: 0x06017998 RID: 96664 RVA: 0x00229149 File Offset: 0x00227349
		public FKuroCurveFloat EmissionLightColorChangeProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EmissionLightColorChangeProgress) == null)
				{
					result = (this._EmissionLightColorChangeProgress = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x06017999 RID: 96665 RVA: 0x0022916C File Offset: 0x0022736C
		// (set) Token: 0x0601799A RID: 96666 RVA: 0x002291A5 File Offset: 0x002273A5
		public FKuroCurveFloat EmissionLightColorChangeStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EmissionLightColorChangeStrength) == null)
				{
					result = (this._EmissionLightColorChangeStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x0601799B RID: 96667 RVA: 0x002291C8 File Offset: 0x002273C8
		// (set) Token: 0x0601799C RID: 96668 RVA: 0x00229201 File Offset: 0x00227401
		public FKuroCurveLinearColor EmissionLightColorChangeColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._EmissionLightColorChangeColor) == null)
				{
					result = (this._EmissionLightColorChangeColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionLightColorChangeColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0601799D RID: 96669 RVA: 0x00229222 File Offset: 0x00227422
		// (set) Token: 0x0601799E RID: 96670 RVA: 0x00229232 File Offset: 0x00227432
		public unsafe bool bEnableDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x0601799F RID: 96671 RVA: 0x00229244 File Offset: 0x00227444
		// (set) Token: 0x060179A0 RID: 96672 RVA: 0x0022927D File Offset: 0x0022747D
		public FKuroCurveFloat DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x060179A1 RID: 96673 RVA: 0x002292A0 File Offset: 0x002274A0
		// (set) Token: 0x060179A2 RID: 96674 RVA: 0x002292D9 File Offset: 0x002274D9
		public FKuroCurveFloat DissolveAdjustment
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissolveAdjustment) == null)
				{
					result = (this._DissolveAdjustment = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveAdjustment, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveAdjustment, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x060179A3 RID: 96675 RVA: 0x002292FC File Offset: 0x002274FC
		// (set) Token: 0x060179A4 RID: 96676 RVA: 0x00229335 File Offset: 0x00227535
		public FKuroCurveLinearColor DissolveTexScaleOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._DissolveTexScaleOffset) == null)
				{
					result = (this._DissolveTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveTexScaleOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveTexScaleOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x060179A5 RID: 96677 RVA: 0x00229358 File Offset: 0x00227558
		// (set) Token: 0x060179A6 RID: 96678 RVA: 0x00229391 File Offset: 0x00227591
		public FKuroCurveLinearColor DissolveTexSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._DissolveTexSpeed) == null)
				{
					result = (this._DissolveTexSpeed = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveTexSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveTexSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F0A RID: 24330
		// (get) Token: 0x060179A7 RID: 96679 RVA: 0x002293B2 File Offset: 0x002275B2
		// (set) Token: 0x060179A8 RID: 96680 RVA: 0x002293C2 File Offset: 0x002275C2
		public unsafe ECharacterControllerUVSwitch DissolveUv
		{
			get
			{
				return (ECharacterControllerUVSwitch)(*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveUv));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveUv) = (byte)value;
			}
		}

		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x060179A9 RID: 96681 RVA: 0x002293D4 File Offset: 0x002275D4
		// (set) Token: 0x060179AA RID: 96682 RVA: 0x0022940D File Offset: 0x0022760D
		public FKuroCurveLinearColor DissolveEdgeColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._DissolveEdgeColor) == null)
				{
					result = (this._DissolveEdgeColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x060179AB RID: 96683 RVA: 0x00229430 File Offset: 0x00227630
		// (set) Token: 0x060179AC RID: 96684 RVA: 0x00229469 File Offset: 0x00227669
		public FKuroCurveFloat DissolveEdgeStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissolveEdgeStrength) == null)
				{
					result = (this._DissolveEdgeStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x060179AD RID: 96685 RVA: 0x0022948C File Offset: 0x0022768C
		// (set) Token: 0x060179AE RID: 96686 RVA: 0x002294C5 File Offset: 0x002276C5
		public FKuroCurveFloat DissolveEdgeWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissolveEdgeWidth) == null)
				{
					result = (this._DissolveEdgeWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_DissolveEdgeWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x060179AF RID: 96687 RVA: 0x002294E6 File Offset: 0x002276E6
		// (set) Token: 0x060179B0 RID: 96688 RVA: 0x002294F6 File Offset: 0x002276F6
		public unsafe bool bEnableScanning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableScanning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableScanning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x060179B1 RID: 96689 RVA: 0x00229508 File Offset: 0x00227708
		// (set) Token: 0x060179B2 RID: 96690 RVA: 0x00229541 File Offset: 0x00227741
		public FKuroCurveFloat ScanningOutlineStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ScanningOutlineStrength) == null)
				{
					result = (this._ScanningOutlineStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x060179B3 RID: 96691 RVA: 0x00229564 File Offset: 0x00227764
		// (set) Token: 0x060179B4 RID: 96692 RVA: 0x0022959D File Offset: 0x0022779D
		public FKuroCurveLinearColor ScanningOutlineTexScaleOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ScanningOutlineTexScaleOffset) == null)
				{
					result = (this._ScanningOutlineTexScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineTexScaleOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineTexScaleOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x060179B5 RID: 96693 RVA: 0x002295C0 File Offset: 0x002277C0
		// (set) Token: 0x060179B6 RID: 96694 RVA: 0x002295F9 File Offset: 0x002277F9
		public FKuroCurveLinearColor ScanningOutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ScanningOutlineColor) == null)
				{
					result = (this._ScanningOutlineColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x060179B7 RID: 96695 RVA: 0x0022961C File Offset: 0x0022781C
		// (set) Token: 0x060179B8 RID: 96696 RVA: 0x00229655 File Offset: 0x00227855
		public FKuroCurveFloat ScanningOutlineMixNoiseStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ScanningOutlineMixNoiseStrength) == null)
				{
					result = (this._ScanningOutlineMixNoiseStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineMixNoiseStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_ScanningOutlineMixNoiseStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x060179B9 RID: 96697 RVA: 0x00229676 File Offset: 0x00227876
		// (set) Token: 0x060179BA RID: 96698 RVA: 0x00229686 File Offset: 0x00227886
		public unsafe bool bDisableFoliageEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bDisableFoliageEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bDisableFoliageEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x060179BB RID: 96699 RVA: 0x00229697 File Offset: 0x00227897
		// (set) Token: 0x060179BC RID: 96700 RVA: 0x002296A7 File Offset: 0x002278A7
		public unsafe bool bEnableFoliageEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableFoliageEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableFoliageEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x060179BD RID: 96701 RVA: 0x002296B8 File Offset: 0x002278B8
		// (set) Token: 0x060179BE RID: 96702 RVA: 0x002296C8 File Offset: 0x002278C8
		public unsafe bool bUseRimLightColorSpecil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bUseRimLightColorSpecil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bUseRimLightColorSpecil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x060179BF RID: 96703 RVA: 0x002296DC File Offset: 0x002278DC
		// (set) Token: 0x060179C0 RID: 96704 RVA: 0x00229715 File Offset: 0x00227915
		public FKuroCurveLinearColor RimLightColorSpecil
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._RimLightColorSpecil) == null)
				{
					result = (this._RimLightColorSpecil = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimLightColorSpecil, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimLightColorSpecil, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x060179C1 RID: 96705 RVA: 0x00229738 File Offset: 0x00227938
		// (set) Token: 0x060179C2 RID: 96706 RVA: 0x00229771 File Offset: 0x00227971
		public FKuroCurveFloat RimlightColorStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RimlightColorStrength) == null)
				{
					result = (this._RimlightColorStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimlightColorStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_RimlightColorStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x060179C3 RID: 96707 RVA: 0x00229792 File Offset: 0x00227992
		// (set) Token: 0x060179C4 RID: 96708 RVA: 0x002297A2 File Offset: 0x002279A2
		public unsafe bool bUseEmissionTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bUseEmissionTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bUseEmissionTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x060179C5 RID: 96709 RVA: 0x002297B4 File Offset: 0x002279B4
		// (set) Token: 0x060179C6 RID: 96710 RVA: 0x002297ED File Offset: 0x002279ED
		public FKuroCurveFloat EmissionTexStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EmissionTexStrength) == null)
				{
					result = (this._EmissionTexStrength = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionTexStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_EmissionTexStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x060179C7 RID: 96711 RVA: 0x0022980E File Offset: 0x00227A0E
		// (set) Token: 0x060179C8 RID: 96712 RVA: 0x0022981E File Offset: 0x00227A1E
		public unsafe bool bSimpleUseFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bSimpleUseFlow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bSimpleUseFlow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x060179C9 RID: 96713 RVA: 0x00229830 File Offset: 0x00227A30
		// (set) Token: 0x060179CA RID: 96714 RVA: 0x00229869 File Offset: 0x00227A69
		public FKuroCurveFloat SimpleUspeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SimpleUspeed) == null)
				{
					result = (this._SimpleUspeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_SimpleUspeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_SimpleUspeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x060179CB RID: 96715 RVA: 0x0022988C File Offset: 0x00227A8C
		// (set) Token: 0x060179CC RID: 96716 RVA: 0x002298C5 File Offset: 0x00227AC5
		public FKuroCurveFloat SimpleVspeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SimpleVspeed) == null)
				{
					result = (this._SimpleVspeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_SimpleVspeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_SimpleVspeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x060179CD RID: 96717 RVA: 0x002298E8 File Offset: 0x00227AE8
		// (set) Token: 0x060179CE RID: 96718 RVA: 0x00229921 File Offset: 0x00227B21
		public TMap<FName, FKuroCurveFloat> CustomScalarParMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._CustomScalarParMap) == null)
				{
					result = (this._CustomScalarParMap = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_CustomScalarParMap, this));
				}
				return result;
			}
			set
			{
				this.CustomScalarParMap.CopyAssign(value);
			}
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x060179CF RID: 96719 RVA: 0x00229930 File Offset: 0x00227B30
		// (set) Token: 0x060179D0 RID: 96720 RVA: 0x00229969 File Offset: 0x00227B69
		public TMap<FName, FKuroCurveLinearColor> CustomColorParMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._CustomColorParMap) == null)
				{
					result = (this._CustomColorParMap = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_CustomColorParMap, this));
				}
				return result;
			}
			set
			{
				this.CustomColorParMap.CopyAssign(value);
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x060179D1 RID: 96721 RVA: 0x00229978 File Offset: 0x00227B78
		// (set) Token: 0x060179D2 RID: 96722 RVA: 0x002299B1 File Offset: 0x00227BB1
		public FKuroCurveFloat VertexAnimTimeDebug
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VertexAnimTimeDebug) == null)
				{
					result = (this._VertexAnimTimeDebug = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_VertexAnimTimeDebug, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_VertexAnimTimeDebug, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x060179D3 RID: 96723 RVA: 0x002299D4 File Offset: 0x00227BD4
		// (set) Token: 0x060179D4 RID: 96724 RVA: 0x00229A0D File Offset: 0x00227C0D
		public FKuroCurveFloat VertexAnimFrame
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VertexAnimFrame) == null)
				{
					result = (this._VertexAnimFrame = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_VertexAnimFrame, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_VertexAnimFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x060179D5 RID: 96725 RVA: 0x00229A2E File Offset: 0x00227C2E
		// (set) Token: 0x060179D6 RID: 96726 RVA: 0x00229A3E File Offset: 0x00227C3E
		public unsafe bool bEnablePivotPainterWorldPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnablePivotPainterWorldPositionOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnablePivotPainterWorldPositionOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x060179D7 RID: 96727 RVA: 0x00229A50 File Offset: 0x00227C50
		// (set) Token: 0x060179D8 RID: 96728 RVA: 0x00229A89 File Offset: 0x00227C89
		public FKuroCurveLinearColor PivotPainterTransform
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._PivotPainterTransform) == null)
				{
					result = (this._PivotPainterTransform = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_PivotPainterTransform, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_PivotPainterTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x060179D9 RID: 96729 RVA: 0x00229AAC File Offset: 0x00227CAC
		// (set) Token: 0x060179DA RID: 96730 RVA: 0x00229AE5 File Offset: 0x00227CE5
		public FKuroCurveFloat FloatingThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FloatingThreshold) == null)
				{
					result = (this._FloatingThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_FloatingThreshold, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_FloatingThreshold, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x060179DB RID: 96731 RVA: 0x00229B06 File Offset: 0x00227D06
		// (set) Token: 0x060179DC RID: 96732 RVA: 0x00229B16 File Offset: 0x00227D16
		public unsafe bool bEnableWorldPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableWorldPositionOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableWorldPositionOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x060179DD RID: 96733 RVA: 0x00229B28 File Offset: 0x00227D28
		// (set) Token: 0x060179DE RID: 96734 RVA: 0x00229B61 File Offset: 0x00227D61
		public FKuroCurveLinearColor WorldPositionOffsetOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._WorldPositionOffsetOffset) == null)
				{
					result = (this._WorldPositionOffsetOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_WorldPositionOffsetOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_WorldPositionOffsetOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x060179DF RID: 96735 RVA: 0x00229B84 File Offset: 0x00227D84
		// (set) Token: 0x060179E0 RID: 96736 RVA: 0x00229BBD File Offset: 0x00227DBD
		public FKuroCurveFloat WorldPositionOffsetNormal
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WorldPositionOffsetNormal) == null)
				{
					result = (this._WorldPositionOffsetNormal = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_WorldPositionOffsetNormal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_WorldPositionOffsetNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x060179E1 RID: 96737 RVA: 0x00229BDE File Offset: 0x00227DDE
		// (set) Token: 0x060179E2 RID: 96738 RVA: 0x00229BEE File Offset: 0x00227DEE
		public unsafe bool bEnableQuanXiPinTu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableQuanXiPinTu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableQuanXiPinTu) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x060179E3 RID: 96739 RVA: 0x00229C00 File Offset: 0x00227E00
		// (set) Token: 0x060179E4 RID: 96740 RVA: 0x00229C39 File Offset: 0x00227E39
		public FKuroCurveFloat TransparencyQuanXiPinTu
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TransparencyQuanXiPinTu) == null)
				{
					result = (this._TransparencyQuanXiPinTu = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparencyQuanXiPinTu, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparencyQuanXiPinTu, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x060179E5 RID: 96741 RVA: 0x00229C5C File Offset: 0x00227E5C
		// (set) Token: 0x060179E6 RID: 96742 RVA: 0x00229C95 File Offset: 0x00227E95
		public FKuroCurveLinearColor TransparentColorQuanXiPinTu
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._TransparentColorQuanXiPinTu) == null)
				{
					result = (this._TransparentColorQuanXiPinTu = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparentColorQuanXiPinTu, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparentColorQuanXiPinTu, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x060179E7 RID: 96743 RVA: 0x00229CB8 File Offset: 0x00227EB8
		// (set) Token: 0x060179E8 RID: 96744 RVA: 0x00229CF1 File Offset: 0x00227EF1
		public FKuroCurveLinearColor OpaqueColorQuanXiPinTu
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._OpaqueColorQuanXiPinTu) == null)
				{
					result = (this._OpaqueColorQuanXiPinTu = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_OpaqueColorQuanXiPinTu, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_OpaqueColorQuanXiPinTu, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x060179E9 RID: 96745 RVA: 0x00229D12 File Offset: 0x00227F12
		// (set) Token: 0x060179EA RID: 96746 RVA: 0x00229D22 File Offset: 0x00227F22
		public unsafe bool bEnableQuanXiFengSuo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableQuanXiFengSuo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_bEnableQuanXiFengSuo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x060179EB RID: 96747 RVA: 0x00229D34 File Offset: 0x00227F34
		// (set) Token: 0x060179EC RID: 96748 RVA: 0x00229D6D File Offset: 0x00227F6D
		public FKuroCurveFloat TransparencyQuanXiFengSuo
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TransparencyQuanXiFengSuo) == null)
				{
					result = (this._TransparencyQuanXiFengSuo = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparencyQuanXiFengSuo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparencyQuanXiFengSuo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x060179ED RID: 96749 RVA: 0x00229D90 File Offset: 0x00227F90
		// (set) Token: 0x060179EE RID: 96750 RVA: 0x00229DC9 File Offset: 0x00227FC9
		public FKuroCurveLinearColor TransparentColorQuanXiFengSuo
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._TransparentColorQuanXiFengSuo) == null)
				{
					result = (this._TransparentColorQuanXiFengSuo = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparentColorQuanXiFengSuo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelMaterialDynamicData.__PropertyOffset_TransparentColorQuanXiFengSuo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060179EF RID: 96751 RVA: 0x00229DEA File Offset: 0x00227FEA
		static UKuroLevelMaterialDynamicData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelMaterialDynamicData");
		}

		// Token: 0x060179F0 RID: 96752 RVA: 0x00229DF8 File Offset: 0x00227FF8
		protected UKuroLevelMaterialDynamicData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCEB RID: 52459
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelMaterialDynamicData";

		// Token: 0x0400CCEC RID: 52460
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCED RID: 52461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCEE RID: 52462
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0400CCEF RID: 52463
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x0400CCF0 RID: 52464
		internal static int __PropertyOffset_EndTime;

		// Token: 0x0400CCF1 RID: 52465
		internal static int __PropertyOffset_bEnableBaseColorScale;

		// Token: 0x0400CCF2 RID: 52466
		internal static int __PropertyOffset_BaseColorScale;

		// Token: 0x0400CCF3 RID: 52467
		[Nullable(2)]
		private FKuroCurveFloat _BaseColorScale;

		// Token: 0x0400CCF4 RID: 52468
		internal static int __PropertyOffset_bEnableAddEmissionColor;

		// Token: 0x0400CCF5 RID: 52469
		internal static int __PropertyOffset_AddEmissionColor;

		// Token: 0x0400CCF6 RID: 52470
		[Nullable(2)]
		private FKuroCurveLinearColor _AddEmissionColor;

		// Token: 0x0400CCF7 RID: 52471
		internal static int __PropertyOffset_bEnableRimLight;

		// Token: 0x0400CCF8 RID: 52472
		internal static int __PropertyOffset_RimLightColor;

		// Token: 0x0400CCF9 RID: 52473
		[Nullable(2)]
		private FKuroCurveLinearColor _RimLightColor;

		// Token: 0x0400CCFA RID: 52474
		internal static int __PropertyOffset_RimPower;

		// Token: 0x0400CCFB RID: 52475
		[Nullable(2)]
		private FKuroCurveFloat _RimPower;

		// Token: 0x0400CCFC RID: 52476
		internal static int __PropertyOffset_bEnableEmissionChange;

		// Token: 0x0400CCFD RID: 52477
		internal static int __PropertyOffset_EmissionLightColorChangeProgress;

		// Token: 0x0400CCFE RID: 52478
		[Nullable(2)]
		private FKuroCurveFloat _EmissionLightColorChangeProgress;

		// Token: 0x0400CCFF RID: 52479
		internal static int __PropertyOffset_EmissionLightColorChangeStrength;

		// Token: 0x0400CD00 RID: 52480
		[Nullable(2)]
		private FKuroCurveFloat _EmissionLightColorChangeStrength;

		// Token: 0x0400CD01 RID: 52481
		internal static int __PropertyOffset_EmissionLightColorChangeColor;

		// Token: 0x0400CD02 RID: 52482
		[Nullable(2)]
		private FKuroCurveLinearColor _EmissionLightColorChangeColor;

		// Token: 0x0400CD03 RID: 52483
		internal static int __PropertyOffset_bEnableDissolve;

		// Token: 0x0400CD04 RID: 52484
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400CD05 RID: 52485
		[Nullable(2)]
		private FKuroCurveFloat _DissolveProgress;

		// Token: 0x0400CD06 RID: 52486
		internal static int __PropertyOffset_DissolveAdjustment;

		// Token: 0x0400CD07 RID: 52487
		[Nullable(2)]
		private FKuroCurveFloat _DissolveAdjustment;

		// Token: 0x0400CD08 RID: 52488
		internal static int __PropertyOffset_DissolveTexScaleOffset;

		// Token: 0x0400CD09 RID: 52489
		[Nullable(2)]
		private FKuroCurveLinearColor _DissolveTexScaleOffset;

		// Token: 0x0400CD0A RID: 52490
		internal static int __PropertyOffset_DissolveTexSpeed;

		// Token: 0x0400CD0B RID: 52491
		[Nullable(2)]
		private FKuroCurveLinearColor _DissolveTexSpeed;

		// Token: 0x0400CD0C RID: 52492
		internal static int __PropertyOffset_DissolveUv;

		// Token: 0x0400CD0D RID: 52493
		internal static int __PropertyOffset_DissolveEdgeColor;

		// Token: 0x0400CD0E RID: 52494
		[Nullable(2)]
		private FKuroCurveLinearColor _DissolveEdgeColor;

		// Token: 0x0400CD0F RID: 52495
		internal static int __PropertyOffset_DissolveEdgeStrength;

		// Token: 0x0400CD10 RID: 52496
		[Nullable(2)]
		private FKuroCurveFloat _DissolveEdgeStrength;

		// Token: 0x0400CD11 RID: 52497
		internal static int __PropertyOffset_DissolveEdgeWidth;

		// Token: 0x0400CD12 RID: 52498
		[Nullable(2)]
		private FKuroCurveFloat _DissolveEdgeWidth;

		// Token: 0x0400CD13 RID: 52499
		internal static int __PropertyOffset_bEnableScanning;

		// Token: 0x0400CD14 RID: 52500
		internal static int __PropertyOffset_ScanningOutlineStrength;

		// Token: 0x0400CD15 RID: 52501
		[Nullable(2)]
		private FKuroCurveFloat _ScanningOutlineStrength;

		// Token: 0x0400CD16 RID: 52502
		internal static int __PropertyOffset_ScanningOutlineTexScaleOffset;

		// Token: 0x0400CD17 RID: 52503
		[Nullable(2)]
		private FKuroCurveLinearColor _ScanningOutlineTexScaleOffset;

		// Token: 0x0400CD18 RID: 52504
		internal static int __PropertyOffset_ScanningOutlineColor;

		// Token: 0x0400CD19 RID: 52505
		[Nullable(2)]
		private FKuroCurveLinearColor _ScanningOutlineColor;

		// Token: 0x0400CD1A RID: 52506
		internal static int __PropertyOffset_ScanningOutlineMixNoiseStrength;

		// Token: 0x0400CD1B RID: 52507
		[Nullable(2)]
		private FKuroCurveFloat _ScanningOutlineMixNoiseStrength;

		// Token: 0x0400CD1C RID: 52508
		internal static int __PropertyOffset_bDisableFoliageEffect;

		// Token: 0x0400CD1D RID: 52509
		internal static int __PropertyOffset_bEnableFoliageEffect;

		// Token: 0x0400CD1E RID: 52510
		internal static int __PropertyOffset_bUseRimLightColorSpecil;

		// Token: 0x0400CD1F RID: 52511
		internal static int __PropertyOffset_RimLightColorSpecil;

		// Token: 0x0400CD20 RID: 52512
		[Nullable(2)]
		private FKuroCurveLinearColor _RimLightColorSpecil;

		// Token: 0x0400CD21 RID: 52513
		internal static int __PropertyOffset_RimlightColorStrength;

		// Token: 0x0400CD22 RID: 52514
		[Nullable(2)]
		private FKuroCurveFloat _RimlightColorStrength;

		// Token: 0x0400CD23 RID: 52515
		internal static int __PropertyOffset_bUseEmissionTex;

		// Token: 0x0400CD24 RID: 52516
		internal static int __PropertyOffset_EmissionTexStrength;

		// Token: 0x0400CD25 RID: 52517
		[Nullable(2)]
		private FKuroCurveFloat _EmissionTexStrength;

		// Token: 0x0400CD26 RID: 52518
		internal static int __PropertyOffset_bSimpleUseFlow;

		// Token: 0x0400CD27 RID: 52519
		internal static int __PropertyOffset_SimpleUspeed;

		// Token: 0x0400CD28 RID: 52520
		[Nullable(2)]
		private FKuroCurveFloat _SimpleUspeed;

		// Token: 0x0400CD29 RID: 52521
		internal static int __PropertyOffset_SimpleVspeed;

		// Token: 0x0400CD2A RID: 52522
		[Nullable(2)]
		private FKuroCurveFloat _SimpleVspeed;

		// Token: 0x0400CD2B RID: 52523
		internal static int __PropertyOffset_CustomScalarParMap;

		// Token: 0x0400CD2C RID: 52524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _CustomScalarParMap;

		// Token: 0x0400CD2D RID: 52525
		internal static int __PropertyOffset_CustomColorParMap;

		// Token: 0x0400CD2E RID: 52526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _CustomColorParMap;

		// Token: 0x0400CD2F RID: 52527
		internal static int __PropertyOffset_VertexAnimTimeDebug;

		// Token: 0x0400CD30 RID: 52528
		[Nullable(2)]
		private FKuroCurveFloat _VertexAnimTimeDebug;

		// Token: 0x0400CD31 RID: 52529
		internal static int __PropertyOffset_VertexAnimFrame;

		// Token: 0x0400CD32 RID: 52530
		[Nullable(2)]
		private FKuroCurveFloat _VertexAnimFrame;

		// Token: 0x0400CD33 RID: 52531
		internal static int __PropertyOffset_bEnablePivotPainterWorldPositionOffset;

		// Token: 0x0400CD34 RID: 52532
		internal static int __PropertyOffset_PivotPainterTransform;

		// Token: 0x0400CD35 RID: 52533
		[Nullable(2)]
		private FKuroCurveLinearColor _PivotPainterTransform;

		// Token: 0x0400CD36 RID: 52534
		internal static int __PropertyOffset_FloatingThreshold;

		// Token: 0x0400CD37 RID: 52535
		[Nullable(2)]
		private FKuroCurveFloat _FloatingThreshold;

		// Token: 0x0400CD38 RID: 52536
		internal static int __PropertyOffset_bEnableWorldPositionOffset;

		// Token: 0x0400CD39 RID: 52537
		internal static int __PropertyOffset_WorldPositionOffsetOffset;

		// Token: 0x0400CD3A RID: 52538
		[Nullable(2)]
		private FKuroCurveLinearColor _WorldPositionOffsetOffset;

		// Token: 0x0400CD3B RID: 52539
		internal static int __PropertyOffset_WorldPositionOffsetNormal;

		// Token: 0x0400CD3C RID: 52540
		[Nullable(2)]
		private FKuroCurveFloat _WorldPositionOffsetNormal;

		// Token: 0x0400CD3D RID: 52541
		internal static int __PropertyOffset_bEnableQuanXiPinTu;

		// Token: 0x0400CD3E RID: 52542
		internal static int __PropertyOffset_TransparencyQuanXiPinTu;

		// Token: 0x0400CD3F RID: 52543
		[Nullable(2)]
		private FKuroCurveFloat _TransparencyQuanXiPinTu;

		// Token: 0x0400CD40 RID: 52544
		internal static int __PropertyOffset_TransparentColorQuanXiPinTu;

		// Token: 0x0400CD41 RID: 52545
		[Nullable(2)]
		private FKuroCurveLinearColor _TransparentColorQuanXiPinTu;

		// Token: 0x0400CD42 RID: 52546
		internal static int __PropertyOffset_OpaqueColorQuanXiPinTu;

		// Token: 0x0400CD43 RID: 52547
		[Nullable(2)]
		private FKuroCurveLinearColor _OpaqueColorQuanXiPinTu;

		// Token: 0x0400CD44 RID: 52548
		internal static int __PropertyOffset_bEnableQuanXiFengSuo;

		// Token: 0x0400CD45 RID: 52549
		internal static int __PropertyOffset_TransparencyQuanXiFengSuo;

		// Token: 0x0400CD46 RID: 52550
		[Nullable(2)]
		private FKuroCurveFloat _TransparencyQuanXiFengSuo;

		// Token: 0x0400CD47 RID: 52551
		internal static int __PropertyOffset_TransparentColorQuanXiFengSuo;

		// Token: 0x0400CD48 RID: 52552
		[Nullable(2)]
		private FKuroCurveLinearColor _TransparentColorQuanXiFengSuo;
	}
}
