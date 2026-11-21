using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000292 RID: 658
	[UnrealObjectPath("/Script/Engine.StreamableRenderAsset")]
	[UnrealStructLayout(2664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2664)]
	public abstract class UStreamableRenderAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060048C0 RID: 18624 RVA: 0x00065F16 File Offset: 0x00064116
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamableRenderAsset._ClassPtr;
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x00065F22 File Offset: 0x00064122
		// (set) Token: 0x060048C2 RID: 18626 RVA: 0x00065F32 File Offset: 0x00064132
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x00065F43 File Offset: 0x00064143
		// (set) Token: 0x060048C4 RID: 18628 RVA: 0x00065F53 File Offset: 0x00064153
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

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x00065F64 File Offset: 0x00064164
		// (set) Token: 0x060048C6 RID: 18630 RVA: 0x00065F74 File Offset: 0x00064174
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

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x00065F85 File Offset: 0x00064185
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x00065F95 File Offset: 0x00064195
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

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00065FA6 File Offset: 0x000641A6
		// (set) Token: 0x060048CA RID: 18634 RVA: 0x00065FB6 File Offset: 0x000641B6
		public unsafe float KuroKeepRequireMipDurationWhenInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroKeepRequireMipDurationWhenInit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableRenderAsset.__PropertyOffset_KuroKeepRequireMipDurationWhenInit) = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00065FC7 File Offset: 0x000641C7
		// (set) Token: 0x060048CC RID: 18636 RVA: 0x00065FD7 File Offset: 0x000641D7
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

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00065FE8 File Offset: 0x000641E8
		// (set) Token: 0x060048CE RID: 18638 RVA: 0x00065FF8 File Offset: 0x000641F8
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

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x00066009 File Offset: 0x00064209
		// (set) Token: 0x060048D0 RID: 18640 RVA: 0x00066022 File Offset: 0x00064222
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

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x00066052 File Offset: 0x00064252
		// (set) Token: 0x060048D2 RID: 18642 RVA: 0x0006606B File Offset: 0x0006426B
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

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0006609B File Offset: 0x0006429B
		// (set) Token: 0x060048D4 RID: 18644 RVA: 0x000660B4 File Offset: 0x000642B4
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

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x000660E4 File Offset: 0x000642E4
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x000660FD File Offset: 0x000642FD
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

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x0006612D File Offset: 0x0006432D
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x00066146 File Offset: 0x00064346
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

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x00066176 File Offset: 0x00064376
		// (set) Token: 0x060048DA RID: 18650 RVA: 0x0006618F File Offset: 0x0006438F
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

		// Token: 0x060048DB RID: 18651 RVA: 0x000661C0 File Offset: 0x000643C0
		[SkipLocalsInit]
		public unsafe static void SetKuroStreamingQualityLevel(int InQualityLevel)
		{
			UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__SetKuroStreamingQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__SetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQualityLevel = InQualityLevel;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__SetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00066208 File Offset: 0x00064408
		[SkipLocalsInit]
		public unsafe static void SetKuroStreamingLevelState(int InLevelState)
		{
			UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__SetKuroStreamingLevelState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__SetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLevelState = InLevelState;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__SetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x00066250 File Offset: 0x00064450
		[SkipLocalsInit]
		public unsafe static FVector4 GetStreamingRenderAssetsInfo()
		{
			UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingRenderAssetsInfo_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00066294 File Offset: 0x00064494
		[SkipLocalsInit]
		public unsafe static FVector4 GetStreamingPoolInfo()
		{
			UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingPoolInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingPoolInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingPoolInfo_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x000662D8 File Offset: 0x000644D8
		[SkipLocalsInit]
		public unsafe static FVector4 GetStreamingExtendedBudgetInfo()
		{
			UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingExtendedBudgetInfo_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x0006631C File Offset: 0x0006451C
		[SkipLocalsInit]
		public unsafe static FVector4 GetStreamingBudgetInfo()
		{
			UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStreamableRenderAsset.__GetStreamingBudgetInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetStreamingBudgetInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetStreamingBudgetInfo_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00066360 File Offset: 0x00064560
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x000663D0 File Offset: 0x000645D0
		[SkipLocalsInit]
		public unsafe static int GetKuroStreamingQualityLevel()
		{
			UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__GetKuroStreamingQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingQualityLevel_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00066414 File Offset: 0x00064614
		[SkipLocalsInit]
		public unsafe static int GetKuroStreamingLevelState()
		{
			UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UStreamableRenderAsset.__GetKuroStreamingLevelState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__GetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__GetKuroStreamingLevelState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00066458 File Offset: 0x00064658
		[SkipLocalsInit]
		public unsafe static int EncodeStreamingLODBiasMapping(int QualityLevel0 = 0, int QualityLevel1 = 1, int QualityLevel2 = 2, int QualityLevel3 = 3, int QualityLevel4 = 4)
		{
			UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams* ptr = stackalloc UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QualityLevel0 = QualityLevel0;
			ptr->QualityLevel1 = QualityLevel1;
			ptr->QualityLevel2 = QualityLevel2;
			ptr->QualityLevel3 = QualityLevel3;
			ptr->QualityLevel4 = QualityLevel4;
			UnrealReflectionUtils.CallUFunction(UStreamableRenderAsset._ClassDefaultObjectPtr, UStreamableRenderAsset.__EncodeStreamingLODBiasMapping_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x000664C0 File Offset: 0x000646C0
		static UStreamableRenderAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StreamableRenderAsset");
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x000664D0 File Offset: 0x000646D0
		protected UStreamableRenderAsset() : this(BuiltinUtils.AllocNativeUObject(UStreamableRenderAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x000664F8 File Offset: 0x000646F8
		protected UStreamableRenderAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C36 RID: 7222
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StreamableRenderAsset";

		// Token: 0x04001C37 RID: 7223
		private static IntPtr _ClassPtr;

		// Token: 0x04001C38 RID: 7224
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001C39 RID: 7225
		internal static int __PropertyOffset_ForceMipLevelsToBeResidentTimestamp;

		// Token: 0x04001C3A RID: 7226
		internal static int __PropertyOffset_NumCinematicMipLevels;

		// Token: 0x04001C3B RID: 7227
		internal static int __PropertyOffset_KuroRuntimeLODBias_PackedData;

		// Token: 0x04001C3C RID: 7228
		internal static int __PropertyOffset_KuroRuntimeLODBias_PackedData2;

		// Token: 0x04001C3D RID: 7229
		internal static int __PropertyOffset_KuroKeepRequireMipDurationWhenInit;

		// Token: 0x04001C3E RID: 7230
		internal static int __PropertyOffset_StreamingIndex;

		// Token: 0x04001C3F RID: 7231
		internal static int __PropertyOffset_CachedCombinedLODBias;

		// Token: 0x04001C40 RID: 7232
		internal static int __PropertyOffset_NeverStream;

		// Token: 0x04001C41 RID: 7233
		internal static byte __PropertyMask_NeverStream;

		// Token: 0x04001C42 RID: 7234
		internal static int __PropertyOffset_bGlobalForceMipLevelsToBeResident;

		// Token: 0x04001C43 RID: 7235
		internal static byte __PropertyMask_bGlobalForceMipLevelsToBeResident;

		// Token: 0x04001C44 RID: 7236
		internal static int __PropertyOffset_bHasStreamingUpdatePending;

		// Token: 0x04001C45 RID: 7237
		internal static byte __PropertyMask_bHasStreamingUpdatePending;

		// Token: 0x04001C46 RID: 7238
		internal static int __PropertyOffset_bForceMiplevelsToBeResident;

		// Token: 0x04001C47 RID: 7239
		internal static byte __PropertyMask_bForceMiplevelsToBeResident;

		// Token: 0x04001C48 RID: 7240
		internal static int __PropertyOffset_bIgnoreStreamingMipBias;

		// Token: 0x04001C49 RID: 7241
		internal static byte __PropertyMask_bIgnoreStreamingMipBias;

		// Token: 0x04001C4A RID: 7242
		internal static int __PropertyOffset_bUseCinematicMipLevels;

		// Token: 0x04001C4B RID: 7243
		internal static byte __PropertyMask_bUseCinematicMipLevels;

		// Token: 0x04001C4C RID: 7244
		private static IntPtr __SetKuroStreamingQualityLevel_NativeFunctionPtr;

		// Token: 0x04001C4D RID: 7245
		private static IntPtr __SetKuroStreamingLevelState_NativeFunctionPtr;

		// Token: 0x04001C4E RID: 7246
		private static IntPtr __GetStreamingRenderAssetsInfo_NativeFunctionPtr;

		// Token: 0x04001C4F RID: 7247
		private static IntPtr __GetStreamingPoolInfo_NativeFunctionPtr;

		// Token: 0x04001C50 RID: 7248
		private static IntPtr __GetStreamingExtendedBudgetInfo_NativeFunctionPtr;

		// Token: 0x04001C51 RID: 7249
		private static IntPtr __GetStreamingBudgetInfo_NativeFunctionPtr;

		// Token: 0x04001C52 RID: 7250
		private static IntPtr __GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_NativeFunctionPtr;

		// Token: 0x04001C53 RID: 7251
		private static IntPtr __GetKuroStreamingQualityLevel_NativeFunctionPtr;

		// Token: 0x04001C54 RID: 7252
		private static IntPtr __GetKuroStreamingLevelState_NativeFunctionPtr;

		// Token: 0x04001C55 RID: 7253
		private static IntPtr __EncodeStreamingLODBiasMapping_NativeFunctionPtr;

		// Token: 0x020009E9 RID: 2537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroStreamingQualityLevel_FunctionParams
		{
			// Token: 0x04005983 RID: 22915
			[FieldOffset(0)]
			public int InQualityLevel;
		}

		// Token: 0x020009EA RID: 2538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroStreamingLevelState_FunctionParams
		{
			// Token: 0x04005984 RID: 22916
			[FieldOffset(0)]
			public int InLevelState;
		}

		// Token: 0x020009EB RID: 2539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingRenderAssetsInfo_FunctionParams
		{
			// Token: 0x04005985 RID: 22917
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x020009EC RID: 2540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingPoolInfo_FunctionParams
		{
			// Token: 0x04005986 RID: 22918
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x020009ED RID: 2541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingExtendedBudgetInfo_FunctionParams
		{
			// Token: 0x04005987 RID: 22919
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x020009EE RID: 2542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStreamingBudgetInfo_FunctionParams
		{
			// Token: 0x04005988 RID: 22920
			[FieldOffset(0)]
			public FVector4 __Result;
		}

		// Token: 0x020009EF RID: 2543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetKuroStreamingRuntimeLODBiasDeviceMappingIndices_FunctionParams
		{
			// Token: 0x04005989 RID: 22921
			[FieldOffset(0)]
			public int QualityLevel0;

			// Token: 0x0400598A RID: 22922
			[FieldOffset(4)]
			public int QualityLevel1;

			// Token: 0x0400598B RID: 22923
			[FieldOffset(8)]
			public int QualityLevel2;

			// Token: 0x0400598C RID: 22924
			[FieldOffset(12)]
			public int QualityLevel3;

			// Token: 0x0400598D RID: 22925
			[FieldOffset(16)]
			public int QualityLevel4;

			// Token: 0x0400598E RID: 22926
			[FieldOffset(20)]
			public int QualityLevel5;

			// Token: 0x0400598F RID: 22927
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x020009F0 RID: 2544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroStreamingQualityLevel_FunctionParams
		{
			// Token: 0x04005990 RID: 22928
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020009F1 RID: 2545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroStreamingLevelState_FunctionParams
		{
			// Token: 0x04005991 RID: 22929
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020009F2 RID: 2546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EncodeStreamingLODBiasMapping_FunctionParams
		{
			// Token: 0x04005992 RID: 22930
			[FieldOffset(0)]
			public int QualityLevel0;

			// Token: 0x04005993 RID: 22931
			[FieldOffset(4)]
			public int QualityLevel1;

			// Token: 0x04005994 RID: 22932
			[FieldOffset(8)]
			public int QualityLevel2;

			// Token: 0x04005995 RID: 22933
			[FieldOffset(12)]
			public int QualityLevel3;

			// Token: 0x04005996 RID: 22934
			[FieldOffset(16)]
			public int QualityLevel4;

			// Token: 0x04005997 RID: 22935
			[FieldOffset(20)]
			public int __Result;
		}
	}
}
