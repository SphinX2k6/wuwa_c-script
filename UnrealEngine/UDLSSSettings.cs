using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000783 RID: 1923
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/DLSS.DLSSSettings")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UDLSSSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006441 RID: 25665 RVA: 0x0008FF8A File Offset: 0x0008E18A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDLSSSettings._ClassPtr;
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x0008FF98 File Offset: 0x0008E198
		public UDLSSSettings() : this(BuiltinUtils.AllocNativeUObject(UDLSSSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x0008FFC0 File Offset: 0x0008E1C0
		public UDLSSSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDLSSSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x0008FFF3 File Offset: 0x0008E1F3
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x00090003 File Offset: 0x0008E203
		public unsafe bool bAllowOTAUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bAllowOTAUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bAllowOTAUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x00090014 File Offset: 0x0008E214
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x00090024 File Offset: 0x0008E224
		public unsafe uint NVIDIANGXApplicationId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_NVIDIANGXApplicationId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_NVIDIANGXApplicationId) = (int)value;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x00090035 File Offset: 0x0008E235
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x00090045 File Offset: 0x0008E245
		public unsafe byte BiasCurrentColorStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_BiasCurrentColorStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_BiasCurrentColorStencilValue) = value;
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x00090056 File Offset: 0x0008E256
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x00090066 File Offset: 0x0008E266
		public unsafe bool bEnableDLSSD3D12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSD3D12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSD3D12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x00090077 File Offset: 0x0008E277
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x00090087 File Offset: 0x0008E287
		public unsafe bool bEnableDLSSD3D11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSD3D11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSD3D11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x00090098 File Offset: 0x0008E298
		// (set) Token: 0x0600644F RID: 25679 RVA: 0x000900A8 File Offset: 0x0008E2A8
		public unsafe bool bEnableDLSSVulkan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSVulkan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSVulkan) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06006450 RID: 25680 RVA: 0x000900B9 File Offset: 0x0008E2B9
		// (set) Token: 0x06006451 RID: 25681 RVA: 0x000900C9 File Offset: 0x0008E2C9
		public unsafe bool bShowDLSSIncompatiblePluginsToolsWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06006452 RID: 25682 RVA: 0x000900DA File Offset: 0x0008E2DA
		// (set) Token: 0x06006453 RID: 25683 RVA: 0x000900EA File Offset: 0x0008E2EA
		public unsafe bool bEnableDLSSInEditorViewports
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSInEditorViewports) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSInEditorViewports) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x000900FB File Offset: 0x0008E2FB
		// (set) Token: 0x06006455 RID: 25685 RVA: 0x0009010B File Offset: 0x0008E30B
		public unsafe bool bEnableDLSSInPlayInEditorViewports
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSInPlayInEditorViewports) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bEnableDLSSInPlayInEditorViewports) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x0009011C File Offset: 0x0008E31C
		// (set) Token: 0x06006457 RID: 25687 RVA: 0x0009012C File Offset: 0x0008E32C
		public unsafe bool bShowDLSSSDebugOnScreenMessages
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bShowDLSSSDebugOnScreenMessages) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bShowDLSSSDebugOnScreenMessages) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06006458 RID: 25688 RVA: 0x0009013D File Offset: 0x0008E33D
		// (set) Token: 0x06006459 RID: 25689 RVA: 0x00090151 File Offset: 0x0008E351
		public unsafe string GenericDLSSSRBinaryPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_GenericDLSSSRBinaryPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_GenericDLSSSRBinaryPath)), value);
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x0600645A RID: 25690 RVA: 0x00090166 File Offset: 0x0008E366
		// (set) Token: 0x0600645B RID: 25691 RVA: 0x00090176 File Offset: 0x0008E376
		public unsafe bool bGenericDLSSSRBinaryExists
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bGenericDLSSSRBinaryExists) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bGenericDLSSSRBinaryExists) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x0600645C RID: 25692 RVA: 0x00090187 File Offset: 0x0008E387
		// (set) Token: 0x0600645D RID: 25693 RVA: 0x0009019B File Offset: 0x0008E39B
		public unsafe string CustomDLSSSRBinaryPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_CustomDLSSSRBinaryPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_CustomDLSSSRBinaryPath)), value);
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600645E RID: 25694 RVA: 0x000901B0 File Offset: 0x0008E3B0
		// (set) Token: 0x0600645F RID: 25695 RVA: 0x000901C0 File Offset: 0x0008E3C0
		public unsafe bool bCustomDLSSSRBinaryExists
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bCustomDLSSSRBinaryExists) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bCustomDLSSSRBinaryExists) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06006460 RID: 25696 RVA: 0x000901D1 File Offset: 0x0008E3D1
		// (set) Token: 0x06006461 RID: 25697 RVA: 0x000901E1 File Offset: 0x0008E3E1
		public unsafe EDLSSPreset DLAAPreset
		{
			get
			{
				return (EDLSSPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLAAPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLAAPreset) = (byte)value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06006462 RID: 25698 RVA: 0x000901F2 File Offset: 0x0008E3F2
		// (set) Token: 0x06006463 RID: 25699 RVA: 0x00090202 File Offset: 0x0008E402
		public unsafe EDLSSPreset DLSSQualityPreset
		{
			get
			{
				return (EDLSSPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSQualityPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSQualityPreset) = (byte)value;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06006464 RID: 25700 RVA: 0x00090213 File Offset: 0x0008E413
		// (set) Token: 0x06006465 RID: 25701 RVA: 0x00090223 File Offset: 0x0008E423
		public unsafe EDLSSPreset DLSSBalancedPreset
		{
			get
			{
				return (EDLSSPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSBalancedPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSBalancedPreset) = (byte)value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x00090234 File Offset: 0x0008E434
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x00090244 File Offset: 0x0008E444
		public unsafe EDLSSPreset DLSSPerformancePreset
		{
			get
			{
				return (EDLSSPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSPerformancePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSPerformancePreset) = (byte)value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x00090255 File Offset: 0x0008E455
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x00090265 File Offset: 0x0008E465
		public unsafe EDLSSPreset DLSSUltraPerformancePreset
		{
			get
			{
				return (EDLSSPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSUltraPerformancePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSUltraPerformancePreset) = (byte)value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x00090276 File Offset: 0x0008E476
		// (set) Token: 0x0600646B RID: 25707 RVA: 0x0009028A File Offset: 0x0008E48A
		public unsafe string GenericDLSSRRBinaryPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_GenericDLSSRRBinaryPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_GenericDLSSRRBinaryPath)), value);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x0009029F File Offset: 0x0008E49F
		// (set) Token: 0x0600646D RID: 25709 RVA: 0x000902AF File Offset: 0x0008E4AF
		public unsafe bool bGenericDLSSRRBinaryExists
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bGenericDLSSRRBinaryExists) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bGenericDLSSRRBinaryExists) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x000902C0 File Offset: 0x0008E4C0
		// (set) Token: 0x0600646F RID: 25711 RVA: 0x000902D4 File Offset: 0x0008E4D4
		public unsafe string CustomDLSSRRBinaryPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_CustomDLSSRRBinaryPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDLSSSettings.__PropertyOffset_CustomDLSSRRBinaryPath)), value);
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06006470 RID: 25712 RVA: 0x000902E9 File Offset: 0x0008E4E9
		// (set) Token: 0x06006471 RID: 25713 RVA: 0x000902F9 File Offset: 0x0008E4F9
		public unsafe bool bCustomDLSSRRBinaryExists
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bCustomDLSSRRBinaryExists) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_bCustomDLSSRRBinaryExists) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x0009030A File Offset: 0x0008E50A
		// (set) Token: 0x06006473 RID: 25715 RVA: 0x0009031A File Offset: 0x0008E51A
		public unsafe EDLSSRRPreset DLAARRPreset
		{
			get
			{
				return (EDLSSRRPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLAARRPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLAARRPreset) = (byte)value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x0009032B File Offset: 0x0008E52B
		// (set) Token: 0x06006475 RID: 25717 RVA: 0x0009033B File Offset: 0x0008E53B
		public unsafe EDLSSRRPreset DLSSRRQualityPreset
		{
			get
			{
				return (EDLSSRRPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRQualityPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRQualityPreset) = (byte)value;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06006476 RID: 25718 RVA: 0x0009034C File Offset: 0x0008E54C
		// (set) Token: 0x06006477 RID: 25719 RVA: 0x0009035C File Offset: 0x0008E55C
		public unsafe EDLSSRRPreset DLSSRRBalancedPreset
		{
			get
			{
				return (EDLSSRRPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRBalancedPreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRBalancedPreset) = (byte)value;
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06006478 RID: 25720 RVA: 0x0009036D File Offset: 0x0008E56D
		// (set) Token: 0x06006479 RID: 25721 RVA: 0x0009037D File Offset: 0x0008E57D
		public unsafe EDLSSRRPreset DLSSRRPerformancePreset
		{
			get
			{
				return (EDLSSRRPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRPerformancePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRPerformancePreset) = (byte)value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600647A RID: 25722 RVA: 0x0009038E File Offset: 0x0008E58E
		// (set) Token: 0x0600647B RID: 25723 RVA: 0x0009039E File Offset: 0x0008E59E
		public unsafe EDLSSRRPreset DLSSRRUltraPerformancePreset
		{
			get
			{
				return (EDLSSRRPreset)(*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRUltraPerformancePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSSettings.__PropertyOffset_DLSSRRUltraPerformancePreset) = (byte)value;
			}
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x000903AF File Offset: 0x0008E5AF
		static UDLSSSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DLSS.DLSSSettings");
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x000903BD File Offset: 0x0008E5BD
		protected UDLSSSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003053 RID: 12371
		public new const string __ObjectPath = "/Script/DLSS.DLSSSettings";

		// Token: 0x04003054 RID: 12372
		private static IntPtr _ClassPtr;

		// Token: 0x04003055 RID: 12373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003056 RID: 12374
		internal static int __PropertyOffset_bAllowOTAUpdate;

		// Token: 0x04003057 RID: 12375
		internal static int __PropertyOffset_NVIDIANGXApplicationId;

		// Token: 0x04003058 RID: 12376
		internal static int __PropertyOffset_BiasCurrentColorStencilValue;

		// Token: 0x04003059 RID: 12377
		internal static int __PropertyOffset_bEnableDLSSD3D12;

		// Token: 0x0400305A RID: 12378
		internal static int __PropertyOffset_bEnableDLSSD3D11;

		// Token: 0x0400305B RID: 12379
		internal static int __PropertyOffset_bEnableDLSSVulkan;

		// Token: 0x0400305C RID: 12380
		internal static int __PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings;

		// Token: 0x0400305D RID: 12381
		internal static int __PropertyOffset_bEnableDLSSInEditorViewports;

		// Token: 0x0400305E RID: 12382
		internal static int __PropertyOffset_bEnableDLSSInPlayInEditorViewports;

		// Token: 0x0400305F RID: 12383
		internal static int __PropertyOffset_bShowDLSSSDebugOnScreenMessages;

		// Token: 0x04003060 RID: 12384
		internal static int __PropertyOffset_GenericDLSSSRBinaryPath;

		// Token: 0x04003061 RID: 12385
		internal static int __PropertyOffset_bGenericDLSSSRBinaryExists;

		// Token: 0x04003062 RID: 12386
		internal static int __PropertyOffset_CustomDLSSSRBinaryPath;

		// Token: 0x04003063 RID: 12387
		internal static int __PropertyOffset_bCustomDLSSSRBinaryExists;

		// Token: 0x04003064 RID: 12388
		internal static int __PropertyOffset_DLAAPreset;

		// Token: 0x04003065 RID: 12389
		internal static int __PropertyOffset_DLSSQualityPreset;

		// Token: 0x04003066 RID: 12390
		internal static int __PropertyOffset_DLSSBalancedPreset;

		// Token: 0x04003067 RID: 12391
		internal static int __PropertyOffset_DLSSPerformancePreset;

		// Token: 0x04003068 RID: 12392
		internal static int __PropertyOffset_DLSSUltraPerformancePreset;

		// Token: 0x04003069 RID: 12393
		internal static int __PropertyOffset_GenericDLSSRRBinaryPath;

		// Token: 0x0400306A RID: 12394
		internal static int __PropertyOffset_bGenericDLSSRRBinaryExists;

		// Token: 0x0400306B RID: 12395
		internal static int __PropertyOffset_CustomDLSSRRBinaryPath;

		// Token: 0x0400306C RID: 12396
		internal static int __PropertyOffset_bCustomDLSSRRBinaryExists;

		// Token: 0x0400306D RID: 12397
		internal static int __PropertyOffset_DLAARRPreset;

		// Token: 0x0400306E RID: 12398
		internal static int __PropertyOffset_DLSSRRQualityPreset;

		// Token: 0x0400306F RID: 12399
		internal static int __PropertyOffset_DLSSRRBalancedPreset;

		// Token: 0x04003070 RID: 12400
		internal static int __PropertyOffset_DLSSRRPerformancePreset;

		// Token: 0x04003071 RID: 12401
		internal static int __PropertyOffset_DLSSRRUltraPerformancePreset;
	}
}
