using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A6 RID: 4518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StreamableRenderAsset")]
	[UnrealStructLayout(2544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public abstract class UStreamableRenderAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A51 RID: 68177 RVA: 0x00186FDA File Offset: 0x001851DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamableRenderAsset._ClassPtr;
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x06010A52 RID: 68178 RVA: 0x00186FE6 File Offset: 0x001851E6
		// (set) Token: 0x06010A53 RID: 68179 RVA: 0x00186FF6 File Offset: 0x001851F6
		public unsafe double ForceMipLevelsToBeResidentTimestamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_ForceMipLevelsToBeResidentTimestamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_ForceMipLevelsToBeResidentTimestamp) = value;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x06010A54 RID: 68180 RVA: 0x00187007 File Offset: 0x00185207
		// (set) Token: 0x06010A55 RID: 68181 RVA: 0x00187017 File Offset: 0x00185217
		public unsafe int NumCinematicMipLevels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_NumCinematicMipLevels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_NumCinematicMipLevels) = value;
			}
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x06010A56 RID: 68182 RVA: 0x00187028 File Offset: 0x00185228
		// (set) Token: 0x06010A57 RID: 68183 RVA: 0x00187061 File Offset: 0x00185261
		public FPerPlatformInt KuroRuntimeLODBias
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroRuntimeLODBias) == null)
				{
					result = (this._KuroRuntimeLODBias = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x06010A58 RID: 68184 RVA: 0x00187084 File Offset: 0x00185284
		// (set) Token: 0x06010A59 RID: 68185 RVA: 0x001870BD File Offset: 0x001852BD
		public FPerPlatformInt KuroDeviceLevelExtraLODBias
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroDeviceLevelExtraLODBias) == null)
				{
					result = (this._KuroDeviceLevelExtraLODBias = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroDeviceLevelExtraLODBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroDeviceLevelExtraLODBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x06010A5A RID: 68186 RVA: 0x001870E0 File Offset: 0x001852E0
		// (set) Token: 0x06010A5B RID: 68187 RVA: 0x00187119 File Offset: 0x00185319
		public FPerPlatformInt KuroDeviceLevelExtraLODBiasEffectedLevel
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroDeviceLevelExtraLODBiasEffectedLevel) == null)
				{
					result = (this._KuroDeviceLevelExtraLODBiasEffectedLevel = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroDeviceLevelExtraLODBiasEffectedLevel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroDeviceLevelExtraLODBiasEffectedLevel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x06010A5C RID: 68188 RVA: 0x0018713A File Offset: 0x0018533A
		// (set) Token: 0x06010A5D RID: 68189 RVA: 0x0018714A File Offset: 0x0018534A
		public unsafe long KuroRuntimeLODBias_PackedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias_PackedData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias_PackedData) = value;
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x06010A5E RID: 68190 RVA: 0x0018715B File Offset: 0x0018535B
		// (set) Token: 0x06010A5F RID: 68191 RVA: 0x0018716B File Offset: 0x0018536B
		public unsafe long KuroRuntimeLODBias_PackedData2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias_PackedData2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroRuntimeLODBias_PackedData2) = value;
			}
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x06010A60 RID: 68192 RVA: 0x0018717C File Offset: 0x0018537C
		// (set) Token: 0x06010A61 RID: 68193 RVA: 0x001871B5 File Offset: 0x001853B5
		public FPerPlatformInt KuroStreamingBoostFactor
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroStreamingBoostFactor) == null)
				{
					result = (this._KuroStreamingBoostFactor = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingBoostFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingBoostFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x06010A62 RID: 68194 RVA: 0x001871D8 File Offset: 0x001853D8
		// (set) Token: 0x06010A63 RID: 68195 RVA: 0x00187211 File Offset: 0x00185411
		public FPerPlatformInt KuroStreamingPriority
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroStreamingPriority) == null)
				{
					result = (this._KuroStreamingPriority = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingPriority, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingPriority, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x06010A64 RID: 68196 RVA: 0x00187234 File Offset: 0x00185434
		// (set) Token: 0x06010A65 RID: 68197 RVA: 0x0018726D File Offset: 0x0018546D
		public FPerPlatformInt KuroStreamingPriorityDistanceScale
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroStreamingPriorityDistanceScale) == null)
				{
					result = (this._KuroStreamingPriorityDistanceScale = new FPerPlatformInt(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingPriorityDistanceScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingPriorityDistanceScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x06010A66 RID: 68198 RVA: 0x0018728E File Offset: 0x0018548E
		// (set) Token: 0x06010A67 RID: 68199 RVA: 0x0018729E File Offset: 0x0018549E
		public unsafe EKuroStreamingGroup KuroStreamingGroup
		{
			get
			{
				return (EKuroStreamingGroup)(*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroStreamingGroup) = (byte)value;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x06010A68 RID: 68200 RVA: 0x001872AF File Offset: 0x001854AF
		// (set) Token: 0x06010A69 RID: 68201 RVA: 0x001872BF File Offset: 0x001854BF
		public unsafe EKuroStreamingGroup KuroMobileStreamingGroup
		{
			get
			{
				return (EKuroStreamingGroup)(*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroMobileStreamingGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroMobileStreamingGroup) = (byte)value;
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x06010A6A RID: 68202 RVA: 0x001872D0 File Offset: 0x001854D0
		// (set) Token: 0x06010A6B RID: 68203 RVA: 0x001872E0 File Offset: 0x001854E0
		public unsafe EKuroStreamingGroup KuroPS5StreamingGroup
		{
			get
			{
				return (EKuroStreamingGroup)(*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroPS5StreamingGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroPS5StreamingGroup) = (byte)value;
			}
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x06010A6C RID: 68204 RVA: 0x001872F1 File Offset: 0x001854F1
		// (set) Token: 0x06010A6D RID: 68205 RVA: 0x00187301 File Offset: 0x00185501
		public unsafe int StreamingIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_StreamingIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_StreamingIndex) = value;
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x06010A6E RID: 68206 RVA: 0x00187312 File Offset: 0x00185512
		// (set) Token: 0x06010A6F RID: 68207 RVA: 0x00187322 File Offset: 0x00185522
		public unsafe int CachedCombinedLODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_CachedCombinedLODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_CachedCombinedLODBias) = value;
			}
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x06010A70 RID: 68208 RVA: 0x00187333 File Offset: 0x00185533
		// (set) Token: 0x06010A71 RID: 68209 RVA: 0x0018734C File Offset: 0x0018554C
		public unsafe bool NeverStream
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_NeverStream) & UStreamableRenderAsset.__PropertyMask_NeverStream) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_NeverStream) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_NeverStream) & ~UStreamableRenderAsset.__PropertyMask_NeverStream) | (value ? UStreamableRenderAsset.__PropertyMask_NeverStream : 0));
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x06010A72 RID: 68210 RVA: 0x0018737C File Offset: 0x0018557C
		// (set) Token: 0x06010A73 RID: 68211 RVA: 0x00187395 File Offset: 0x00185595
		public unsafe bool bGlobalForceMipLevelsToBeResident
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bGlobalForceMipLevelsToBeResident) & UStreamableRenderAsset.__PropertyMask_bGlobalForceMipLevelsToBeResident) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bGlobalForceMipLevelsToBeResident) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bGlobalForceMipLevelsToBeResident) & ~UStreamableRenderAsset.__PropertyMask_bGlobalForceMipLevelsToBeResident) | (value ? UStreamableRenderAsset.__PropertyMask_bGlobalForceMipLevelsToBeResident : 0));
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x06010A74 RID: 68212 RVA: 0x001873C5 File Offset: 0x001855C5
		// (set) Token: 0x06010A75 RID: 68213 RVA: 0x001873DE File Offset: 0x001855DE
		public unsafe bool bHasStreamingUpdatePending
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bHasStreamingUpdatePending) & UStreamableRenderAsset.__PropertyMask_bHasStreamingUpdatePending) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bHasStreamingUpdatePending) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bHasStreamingUpdatePending) & ~UStreamableRenderAsset.__PropertyMask_bHasStreamingUpdatePending) | (value ? UStreamableRenderAsset.__PropertyMask_bHasStreamingUpdatePending : 0));
			}
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x06010A76 RID: 68214 RVA: 0x0018740E File Offset: 0x0018560E
		// (set) Token: 0x06010A77 RID: 68215 RVA: 0x00187427 File Offset: 0x00185627
		public unsafe bool bForceMiplevelsToBeResident
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bForceMiplevelsToBeResident) & UStreamableRenderAsset.__PropertyMask_bForceMiplevelsToBeResident) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bForceMiplevelsToBeResident) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bForceMiplevelsToBeResident) & ~UStreamableRenderAsset.__PropertyMask_bForceMiplevelsToBeResident) | (value ? UStreamableRenderAsset.__PropertyMask_bForceMiplevelsToBeResident : 0));
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x06010A78 RID: 68216 RVA: 0x00187457 File Offset: 0x00185657
		// (set) Token: 0x06010A79 RID: 68217 RVA: 0x00187470 File Offset: 0x00185670
		public unsafe bool bIgnoreStreamingMipBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bIgnoreStreamingMipBias) & UStreamableRenderAsset.__PropertyMask_bIgnoreStreamingMipBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bIgnoreStreamingMipBias) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bIgnoreStreamingMipBias) & ~UStreamableRenderAsset.__PropertyMask_bIgnoreStreamingMipBias) | (value ? UStreamableRenderAsset.__PropertyMask_bIgnoreStreamingMipBias : 0));
			}
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x06010A7A RID: 68218 RVA: 0x001874A0 File Offset: 0x001856A0
		// (set) Token: 0x06010A7B RID: 68219 RVA: 0x001874B9 File Offset: 0x001856B9
		public unsafe bool bUseCinematicMipLevels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bUseCinematicMipLevels) & UStreamableRenderAsset.__PropertyMask_bUseCinematicMipLevels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bUseCinematicMipLevels) = ((*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_bUseCinematicMipLevels) & ~UStreamableRenderAsset.__PropertyMask_bUseCinematicMipLevels) | (value ? UStreamableRenderAsset.__PropertyMask_bUseCinematicMipLevels : 0));
			}
		}

		// Token: 0x06010A7C RID: 68220 RVA: 0x001874EC File Offset: 0x001856EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetKuroStreamingQualityLevel(int InQualityLevel)
		{
			UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__SetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQualityLevel = InQualityLevel;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__SetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06010A7D RID: 68221 RVA: 0x00187534 File Offset: 0x00185734
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetKuroStreamingLevelState(int InLevelState)
		{
			UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__SetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLevelState = InLevelState;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__SetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06010A7E RID: 68222 RVA: 0x0018757C File Offset: 0x0018577C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FVector4 GetStreamingRenderAssetsInfo()
		{
			UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A7F RID: 68223 RVA: 0x001875C4 File Offset: 0x001857C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FVector4 GetStreamingPoolInfo()
		{
			UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingPoolInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingPoolInfo_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A80 RID: 68224 RVA: 0x0018760C File Offset: 0x0018580C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FVector4 GetStreamingExtendedBudgetInfo()
		{
			UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A81 RID: 68225 RVA: 0x00187654 File Offset: 0x00185854
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FVector4 GetStreamingBudgetInfo()
		{
			UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingBudgetInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingBudgetInfo_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A82 RID: 68226 RVA: 0x0018769C File Offset: 0x0018589C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetKuroStreamingRuntimeLODBiasDeviceMappingIndices(int QualityLevel0 = 0, int QualityLevel1 = 1, int QualityLevel2 = 2, int QualityLevel3 = 3, int QualityLevel4 = 3, int QualityLevel5 = 4)
		{
			UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QualityLevel0 = QualityLevel0;
			ptr->QualityLevel1 = QualityLevel1;
			ptr->QualityLevel2 = QualityLevel2;
			ptr->QualityLevel3 = QualityLevel3;
			ptr->QualityLevel4 = QualityLevel4;
			ptr->QualityLevel5 = QualityLevel5;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A83 RID: 68227 RVA: 0x00187710 File Offset: 0x00185910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetKuroStreamingQualityLevel()
		{
			UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A84 RID: 68228 RVA: 0x00187758 File Offset: 0x00185958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetKuroStreamingLevelState()
		{
			UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A85 RID: 68229 RVA: 0x001877A0 File Offset: 0x001859A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int EncodeStreamingLODBiasMapping(int QualityLevel0 = 0, int QualityLevel1 = 1, int QualityLevel2 = 2, int QualityLevel3 = 3, int QualityLevel4 = 4)
		{
			UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QualityLevel0 = QualityLevel0;
			ptr->QualityLevel1 = QualityLevel1;
			ptr->QualityLevel2 = QualityLevel2;
			ptr->QualityLevel3 = QualityLevel3;
			ptr->QualityLevel4 = QualityLevel4;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010A86 RID: 68230 RVA: 0x00187809 File Offset: 0x00185A09
		static UStreamableRenderAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StreamableRenderAsset");
		}

		// Token: 0x06010A87 RID: 68231 RVA: 0x00187818 File Offset: 0x00185A18
		protected UStreamableRenderAsset() : this(BuiltinUtils.AllocNativeUObject(UStreamableRenderAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A88 RID: 68232 RVA: 0x00187840 File Offset: 0x00185A40
		protected UStreamableRenderAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E63 RID: 36451
		public new const string __ObjectPath = "/Script/Engine.StreamableRenderAsset";

		// Token: 0x04008E64 RID: 36452
		private static IntPtr _ClassPtr;

		// Token: 0x04008E65 RID: 36453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008E66 RID: 36454
		internal static int __PropertyOffset_ForceMipLevelsToBeResidentTimestamp;

		// Token: 0x04008E67 RID: 36455
		internal static int __PropertyOffset_NumCinematicMipLevels;

		// Token: 0x04008E68 RID: 36456
		internal static int __PropertyOffset_KuroRuntimeLODBias;

		// Token: 0x04008E69 RID: 36457
		[Nullable(2)]
		private FPerPlatformInt _KuroRuntimeLODBias;

		// Token: 0x04008E6A RID: 36458
		internal static int __PropertyOffset_KuroDeviceLevelExtraLODBias;

		// Token: 0x04008E6B RID: 36459
		[Nullable(2)]
		private FPerPlatformInt _KuroDeviceLevelExtraLODBias;

		// Token: 0x04008E6C RID: 36460
		internal static int __PropertyOffset_KuroDeviceLevelExtraLODBiasEffectedLevel;

		// Token: 0x04008E6D RID: 36461
		[Nullable(2)]
		private FPerPlatformInt _KuroDeviceLevelExtraLODBiasEffectedLevel;

		// Token: 0x04008E6E RID: 36462
		internal static int __PropertyOffset_KuroRuntimeLODBias_PackedData;

		// Token: 0x04008E6F RID: 36463
		internal static int __PropertyOffset_KuroRuntimeLODBias_PackedData2;

		// Token: 0x04008E70 RID: 36464
		internal static int __PropertyOffset_KuroStreamingBoostFactor;

		// Token: 0x04008E71 RID: 36465
		[Nullable(2)]
		private FPerPlatformInt _KuroStreamingBoostFactor;

		// Token: 0x04008E72 RID: 36466
		internal static int __PropertyOffset_KuroStreamingPriority;

		// Token: 0x04008E73 RID: 36467
		[Nullable(2)]
		private FPerPlatformInt _KuroStreamingPriority;

		// Token: 0x04008E74 RID: 36468
		internal static int __PropertyOffset_KuroStreamingPriorityDistanceScale;

		// Token: 0x04008E75 RID: 36469
		[Nullable(2)]
		private FPerPlatformInt _KuroStreamingPriorityDistanceScale;

		// Token: 0x04008E76 RID: 36470
		internal static int __PropertyOffset_KuroStreamingGroup;

		// Token: 0x04008E77 RID: 36471
		internal static int __PropertyOffset_KuroMobileStreamingGroup;

		// Token: 0x04008E78 RID: 36472
		internal static int __PropertyOffset_KuroPS5StreamingGroup;

		// Token: 0x04008E79 RID: 36473
		internal static int __PropertyOffset_StreamingIndex;

		// Token: 0x04008E7A RID: 36474
		internal static int __PropertyOffset_CachedCombinedLODBias;

		// Token: 0x04008E7B RID: 36475
		internal static int __PropertyOffset_NeverStream;

		// Token: 0x04008E7C RID: 36476
		internal static byte __PropertyMask_NeverStream;

		// Token: 0x04008E7D RID: 36477
		internal static int __PropertyOffset_bGlobalForceMipLevelsToBeResident;

		// Token: 0x04008E7E RID: 36478
		internal static byte __PropertyMask_bGlobalForceMipLevelsToBeResident;

		// Token: 0x04008E7F RID: 36479
		internal static int __PropertyOffset_bHasStreamingUpdatePending;

		// Token: 0x04008E80 RID: 36480
		internal static byte __PropertyMask_bHasStreamingUpdatePending;

		// Token: 0x04008E81 RID: 36481
		internal static int __PropertyOffset_bForceMiplevelsToBeResident;

		// Token: 0x04008E82 RID: 36482
		internal static byte __PropertyMask_bForceMiplevelsToBeResident;

		// Token: 0x04008E83 RID: 36483
		internal static int __PropertyOffset_bIgnoreStreamingMipBias;

		// Token: 0x04008E84 RID: 36484
		internal static byte __PropertyMask_bIgnoreStreamingMipBias;

		// Token: 0x04008E85 RID: 36485
		internal static int __PropertyOffset_bUseCinematicMipLevels;

		// Token: 0x04008E86 RID: 36486
		internal static byte __PropertyMask_bUseCinematicMipLevels;

		// Token: 0x04008E87 RID: 36487
		private static IntPtr __SetKuroStreamingQualityLevel_NativeFunctionPtr;

		// Token: 0x04008E88 RID: 36488
		private static IntPtr __SetKuroStreamingLevelState_NativeFunctionPtr;

		// Token: 0x04008E89 RID: 36489
		private static IntPtr __GetStreamingRenderAssetsInfo_NativeFunctionPtr;

		// Token: 0x04008E8A RID: 36490
		private static IntPtr __GetStreamingPoolInfo_NativeFunctionPtr;

		// Token: 0x04008E8B RID: 36491
		private static IntPtr __GetStreamingExtendedBudgetInfo_NativeFunctionPtr;

		// Token: 0x04008E8C RID: 36492
		private static IntPtr __GetStreamingBudgetInfo_NativeFunctionPtr;

		// Token: 0x04008E8D RID: 36493
		private static IntPtr __GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_NativeFunctionPtr;

		// Token: 0x04008E8E RID: 36494
		private static IntPtr __GetKuroStreamingQualityLevel_NativeFunctionPtr;

		// Token: 0x04008E8F RID: 36495
		private static IntPtr __GetKuroStreamingLevelState_NativeFunctionPtr;

		// Token: 0x04008E90 RID: 36496
		private static IntPtr __EncodeStreamingLODBiasMapping_NativeFunctionPtr;

		// Token: 0x02002DE9 RID: 11753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroStreamingQualityLevel_FunctionParams
		{
			// Token: 0x0401682D RID: 92205
			[FieldOffset(0)]
			public int InQualityLevel;
		}

		// Token: 0x02002DEA RID: 11754
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroStreamingLevelState_FunctionParams
		{
			// Token: 0x0401682E RID: 92206
			[FieldOffset(0)]
			public int InLevelState;
		}

		// Token: 0x02002DEB RID: 11755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingRenderAssetsInfo_FunctionParams
		{
			// Token: 0x0401682F RID: 92207
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x02002DEC RID: 11756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingPoolInfo_FunctionParams
		{
			// Token: 0x04016830 RID: 92208
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x02002DED RID: 11757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingExtendedBudgetInfo_FunctionParams
		{
			// Token: 0x04016831 RID: 92209
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x02002DEE RID: 11758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingBudgetInfo_FunctionParams
		{
			// Token: 0x04016832 RID: 92210
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x02002DEF RID: 11759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_FunctionParams
		{
			// Token: 0x04016833 RID: 92211
			[FieldOffset(0)]
			public int QualityLevel0;

			// Token: 0x04016834 RID: 92212
			[FieldOffset(4)]
			public int QualityLevel1;

			// Token: 0x04016835 RID: 92213
			[FieldOffset(8)]
			public int QualityLevel2;

			// Token: 0x04016836 RID: 92214
			[FieldOffset(12)]
			public int QualityLevel3;

			// Token: 0x04016837 RID: 92215
			[FieldOffset(16)]
			public int QualityLevel4;

			// Token: 0x04016838 RID: 92216
			[FieldOffset(20)]
			public int QualityLevel5;

			// Token: 0x04016839 RID: 92217
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02002DF0 RID: 11760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroStreamingQualityLevel_FunctionParams
		{
			// Token: 0x0401683A RID: 92218
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DF1 RID: 11761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroStreamingLevelState_FunctionParams
		{
			// Token: 0x0401683B RID: 92219
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DF2 RID: 11762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EncodeStreamingLODBiasMapping_FunctionParams
		{
			// Token: 0x0401683C RID: 92220
			[FieldOffset(0)]
			public int QualityLevel0;

			// Token: 0x0401683D RID: 92221
			[FieldOffset(4)]
			public int QualityLevel1;

			// Token: 0x0401683E RID: 92222
			[FieldOffset(8)]
			public int QualityLevel2;

			// Token: 0x0401683F RID: 92223
			[FieldOffset(12)]
			public int QualityLevel3;

			// Token: 0x04016840 RID: 92224
			[FieldOffset(16)]
			public int QualityLevel4;

			// Token: 0x04016841 RID: 92225
			[FieldOffset(20)]
			public int __Result;
		}
	}
}
