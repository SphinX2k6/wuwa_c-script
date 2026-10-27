using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027CD RID: 10189
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ReductionSettings")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FReductionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025FCD RID: 155597 RVA: 0x00399AB4 File Offset: 0x00397CB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReductionSettings._ScriptStructPtr != 0) ? FReductionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ReductionSettings", ref FReductionSettings._ScriptStructPtr);
		}

		// Token: 0x17009282 RID: 37506
		// (get) Token: 0x06025FCE RID: 155598 RVA: 0x00399AD8 File Offset: 0x00397CD8
		// (set) Token: 0x06025FCF RID: 155599 RVA: 0x00399AF1 File Offset: 0x00397CF1
		public unsafe bool ReductionTargetTriangleRatioEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleRatioEnabled) & FReductionSettings.__PropertyMask_ReductionTargetTriangleRatioEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleRatioEnabled) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleRatioEnabled) & ~FReductionSettings.__PropertyMask_ReductionTargetTriangleRatioEnabled) | (value ? FReductionSettings.__PropertyMask_ReductionTargetTriangleRatioEnabled : 0));
			}
		}

		// Token: 0x17009283 RID: 37507
		// (get) Token: 0x06025FD0 RID: 155600 RVA: 0x00399B21 File Offset: 0x00397D21
		// (set) Token: 0x06025FD1 RID: 155601 RVA: 0x00399B31 File Offset: 0x00397D31
		public unsafe float ReductionTargetTriangleRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleRatio) = value;
			}
		}

		// Token: 0x17009284 RID: 37508
		// (get) Token: 0x06025FD2 RID: 155602 RVA: 0x00399B42 File Offset: 0x00397D42
		// (set) Token: 0x06025FD3 RID: 155603 RVA: 0x00399B5B File Offset: 0x00397D5B
		public unsafe bool ReductionTargetTriangleCountEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleCountEnabled) & FReductionSettings.__PropertyMask_ReductionTargetTriangleCountEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleCountEnabled) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleCountEnabled) & ~FReductionSettings.__PropertyMask_ReductionTargetTriangleCountEnabled) | (value ? FReductionSettings.__PropertyMask_ReductionTargetTriangleCountEnabled : 0));
			}
		}

		// Token: 0x17009285 RID: 37509
		// (get) Token: 0x06025FD4 RID: 155604 RVA: 0x00399B8B File Offset: 0x00397D8B
		// (set) Token: 0x06025FD5 RID: 155605 RVA: 0x00399B9B File Offset: 0x00397D9B
		public unsafe int ReductionTargetTriangleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetTriangleCount) = value;
			}
		}

		// Token: 0x17009286 RID: 37510
		// (get) Token: 0x06025FD6 RID: 155606 RVA: 0x00399BAC File Offset: 0x00397DAC
		// (set) Token: 0x06025FD7 RID: 155607 RVA: 0x00399BC5 File Offset: 0x00397DC5
		public unsafe bool ReductionTargetMaxDeviationEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetMaxDeviationEnabled) & FReductionSettings.__PropertyMask_ReductionTargetMaxDeviationEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetMaxDeviationEnabled) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetMaxDeviationEnabled) & ~FReductionSettings.__PropertyMask_ReductionTargetMaxDeviationEnabled) | (value ? FReductionSettings.__PropertyMask_ReductionTargetMaxDeviationEnabled : 0));
			}
		}

		// Token: 0x17009287 RID: 37511
		// (get) Token: 0x06025FD8 RID: 155608 RVA: 0x00399BF5 File Offset: 0x00397DF5
		// (set) Token: 0x06025FD9 RID: 155609 RVA: 0x00399C05 File Offset: 0x00397E05
		public unsafe float ReductionTargetMaxDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetMaxDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetMaxDeviation) = value;
			}
		}

		// Token: 0x17009288 RID: 37512
		// (get) Token: 0x06025FDA RID: 155610 RVA: 0x00399C16 File Offset: 0x00397E16
		// (set) Token: 0x06025FDB RID: 155611 RVA: 0x00399C2F File Offset: 0x00397E2F
		public unsafe bool ReductionTargetOnScreenSizeEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetOnScreenSizeEnabled) & FReductionSettings.__PropertyMask_ReductionTargetOnScreenSizeEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetOnScreenSizeEnabled) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetOnScreenSizeEnabled) & ~FReductionSettings.__PropertyMask_ReductionTargetOnScreenSizeEnabled) | (value ? FReductionSettings.__PropertyMask_ReductionTargetOnScreenSizeEnabled : 0));
			}
		}

		// Token: 0x17009289 RID: 37513
		// (get) Token: 0x06025FDC RID: 155612 RVA: 0x00399C5F File Offset: 0x00397E5F
		// (set) Token: 0x06025FDD RID: 155613 RVA: 0x00399C6F File Offset: 0x00397E6F
		public unsafe int ReductionTargetOnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetOnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetOnScreenSize) = value;
			}
		}

		// Token: 0x1700928A RID: 37514
		// (get) Token: 0x06025FDE RID: 155614 RVA: 0x00399C80 File Offset: 0x00397E80
		// (set) Token: 0x06025FDF RID: 155615 RVA: 0x00399C90 File Offset: 0x00397E90
		public unsafe EReductionPerformanceMode ReductionPerformanceMode
		{
			get
			{
				return (EReductionPerformanceMode)(*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionPerformanceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionPerformanceMode) = (byte)value;
			}
		}

		// Token: 0x1700928B RID: 37515
		// (get) Token: 0x06025FE0 RID: 155616 RVA: 0x00399CA1 File Offset: 0x00397EA1
		// (set) Token: 0x06025FE1 RID: 155617 RVA: 0x00399CB1 File Offset: 0x00397EB1
		public unsafe EReductionTargetStopCondition ReductionTargetStopCondition
		{
			get
			{
				return (EReductionTargetStopCondition)(*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetStopCondition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionTargetStopCondition) = (byte)value;
			}
		}

		// Token: 0x1700928C RID: 37516
		// (get) Token: 0x06025FE2 RID: 155618 RVA: 0x00399CC2 File Offset: 0x00397EC2
		// (set) Token: 0x06025FE3 RID: 155619 RVA: 0x00399CD2 File Offset: 0x00397ED2
		public unsafe EReductionHeuristics ReductionHeuristics
		{
			get
			{
				return (EReductionHeuristics)(*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionHeuristics));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ReductionHeuristics) = (byte)value;
			}
		}

		// Token: 0x1700928D RID: 37517
		// (get) Token: 0x06025FE4 RID: 155620 RVA: 0x00399CE3 File Offset: 0x00397EE3
		// (set) Token: 0x06025FE5 RID: 155621 RVA: 0x00399CF3 File Offset: 0x00397EF3
		public unsafe float GeometryImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GeometryImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GeometryImportance) = value;
			}
		}

		// Token: 0x1700928E RID: 37518
		// (get) Token: 0x06025FE6 RID: 155622 RVA: 0x00399D04 File Offset: 0x00397F04
		// (set) Token: 0x06025FE7 RID: 155623 RVA: 0x00399D14 File Offset: 0x00397F14
		public unsafe float MaterialImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MaterialImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MaterialImportance) = value;
			}
		}

		// Token: 0x1700928F RID: 37519
		// (get) Token: 0x06025FE8 RID: 155624 RVA: 0x00399D25 File Offset: 0x00397F25
		// (set) Token: 0x06025FE9 RID: 155625 RVA: 0x00399D35 File Offset: 0x00397F35
		public unsafe float TextureImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_TextureImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_TextureImportance) = value;
			}
		}

		// Token: 0x17009290 RID: 37520
		// (get) Token: 0x06025FEA RID: 155626 RVA: 0x00399D46 File Offset: 0x00397F46
		// (set) Token: 0x06025FEB RID: 155627 RVA: 0x00399D56 File Offset: 0x00397F56
		public unsafe float ShadingImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ShadingImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ShadingImportance) = value;
			}
		}

		// Token: 0x17009291 RID: 37521
		// (get) Token: 0x06025FEC RID: 155628 RVA: 0x00399D67 File Offset: 0x00397F67
		// (set) Token: 0x06025FED RID: 155629 RVA: 0x00399D77 File Offset: 0x00397F77
		public unsafe float GroupImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GroupImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GroupImportance) = value;
			}
		}

		// Token: 0x17009292 RID: 37522
		// (get) Token: 0x06025FEE RID: 155630 RVA: 0x00399D88 File Offset: 0x00397F88
		// (set) Token: 0x06025FEF RID: 155631 RVA: 0x00399D98 File Offset: 0x00397F98
		public unsafe float VertexColorImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_VertexColorImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_VertexColorImportance) = value;
			}
		}

		// Token: 0x17009293 RID: 37523
		// (get) Token: 0x06025FF0 RID: 155632 RVA: 0x00399DA9 File Offset: 0x00397FA9
		// (set) Token: 0x06025FF1 RID: 155633 RVA: 0x00399DB9 File Offset: 0x00397FB9
		public unsafe float EdgeSetImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_EdgeSetImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_EdgeSetImportance) = value;
			}
		}

		// Token: 0x17009294 RID: 37524
		// (get) Token: 0x06025FF2 RID: 155634 RVA: 0x00399DCA File Offset: 0x00397FCA
		// (set) Token: 0x06025FF3 RID: 155635 RVA: 0x00399DDA File Offset: 0x00397FDA
		public unsafe float SkinningImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SkinningImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SkinningImportance) = value;
			}
		}

		// Token: 0x17009295 RID: 37525
		// (get) Token: 0x06025FF4 RID: 155636 RVA: 0x00399DEB File Offset: 0x00397FEB
		// (set) Token: 0x06025FF5 RID: 155637 RVA: 0x00399DFB File Offset: 0x00397FFB
		public unsafe float OutwardMoveMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_OutwardMoveMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_OutwardMoveMultiplier) = value;
			}
		}

		// Token: 0x17009296 RID: 37526
		// (get) Token: 0x06025FF6 RID: 155638 RVA: 0x00399E0C File Offset: 0x0039800C
		// (set) Token: 0x06025FF7 RID: 155639 RVA: 0x00399E1C File Offset: 0x0039801C
		public unsafe float InwardMoveMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_InwardMoveMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_InwardMoveMultiplier) = value;
			}
		}

		// Token: 0x17009297 RID: 37527
		// (get) Token: 0x06025FF8 RID: 155640 RVA: 0x00399E2D File Offset: 0x0039802D
		// (set) Token: 0x06025FF9 RID: 155641 RVA: 0x00399E46 File Offset: 0x00398046
		public unsafe bool LimitMaxEdgeLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LimitMaxEdgeLength) & FReductionSettings.__PropertyMask_LimitMaxEdgeLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LimitMaxEdgeLength) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LimitMaxEdgeLength) & ~FReductionSettings.__PropertyMask_LimitMaxEdgeLength) | (value ? FReductionSettings.__PropertyMask_LimitMaxEdgeLength : 0));
			}
		}

		// Token: 0x17009298 RID: 37528
		// (get) Token: 0x06025FFA RID: 155642 RVA: 0x00399E76 File Offset: 0x00398076
		// (set) Token: 0x06025FFB RID: 155643 RVA: 0x00399E86 File Offset: 0x00398086
		public unsafe float MaxEdgeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MaxEdgeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MaxEdgeLength) = value;
			}
		}

		// Token: 0x17009299 RID: 37529
		// (get) Token: 0x06025FFC RID: 155644 RVA: 0x00399E97 File Offset: 0x00398097
		// (set) Token: 0x06025FFD RID: 155645 RVA: 0x00399EB0 File Offset: 0x003980B0
		public unsafe bool KeepSymmetry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepSymmetry) & FReductionSettings.__PropertyMask_KeepSymmetry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepSymmetry) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepSymmetry) & ~FReductionSettings.__PropertyMask_KeepSymmetry) | (value ? FReductionSettings.__PropertyMask_KeepSymmetry : 0));
			}
		}

		// Token: 0x1700929A RID: 37530
		// (get) Token: 0x06025FFE RID: 155646 RVA: 0x00399EE0 File Offset: 0x003980E0
		// (set) Token: 0x06025FFF RID: 155647 RVA: 0x00399EF9 File Offset: 0x003980F9
		public unsafe bool UseSymmetryQuadRetriangulator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseSymmetryQuadRetriangulator) & FReductionSettings.__PropertyMask_UseSymmetryQuadRetriangulator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseSymmetryQuadRetriangulator) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseSymmetryQuadRetriangulator) & ~FReductionSettings.__PropertyMask_UseSymmetryQuadRetriangulator) | (value ? FReductionSettings.__PropertyMask_UseSymmetryQuadRetriangulator : 0));
			}
		}

		// Token: 0x1700929B RID: 37531
		// (get) Token: 0x06026000 RID: 155648 RVA: 0x00399F29 File Offset: 0x00398129
		// (set) Token: 0x06026001 RID: 155649 RVA: 0x00399F42 File Offset: 0x00398142
		public unsafe bool UseAutomaticSymmetryDetection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseAutomaticSymmetryDetection) & FReductionSettings.__PropertyMask_UseAutomaticSymmetryDetection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseAutomaticSymmetryDetection) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseAutomaticSymmetryDetection) & ~FReductionSettings.__PropertyMask_UseAutomaticSymmetryDetection) | (value ? FReductionSettings.__PropertyMask_UseAutomaticSymmetryDetection : 0));
			}
		}

		// Token: 0x1700929C RID: 37532
		// (get) Token: 0x06026002 RID: 155650 RVA: 0x00399F72 File Offset: 0x00398172
		// (set) Token: 0x06026003 RID: 155651 RVA: 0x00399F82 File Offset: 0x00398182
		public unsafe float SymmetryDetectionTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryDetectionTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryDetectionTolerance) = value;
			}
		}

		// Token: 0x1700929D RID: 37533
		// (get) Token: 0x06026004 RID: 155652 RVA: 0x00399F93 File Offset: 0x00398193
		// (set) Token: 0x06026005 RID: 155653 RVA: 0x00399FA3 File Offset: 0x003981A3
		public unsafe ESymmetryAxis SymmetryAxis
		{
			get
			{
				return (ESymmetryAxis)(*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryAxis) = (byte)value;
			}
		}

		// Token: 0x1700929E RID: 37534
		// (get) Token: 0x06026006 RID: 155654 RVA: 0x00399FB4 File Offset: 0x003981B4
		// (set) Token: 0x06026007 RID: 155655 RVA: 0x00399FC4 File Offset: 0x003981C4
		public unsafe float SymmetryOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_SymmetryOffset) = value;
			}
		}

		// Token: 0x1700929F RID: 37535
		// (get) Token: 0x06026008 RID: 155656 RVA: 0x00399FD5 File Offset: 0x003981D5
		// (set) Token: 0x06026009 RID: 155657 RVA: 0x00399FEE File Offset: 0x003981EE
		public unsafe bool CreateGeomorphGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_CreateGeomorphGeometry) & FReductionSettings.__PropertyMask_CreateGeomorphGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_CreateGeomorphGeometry) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_CreateGeomorphGeometry) & ~FReductionSettings.__PropertyMask_CreateGeomorphGeometry) | (value ? FReductionSettings.__PropertyMask_CreateGeomorphGeometry : 0));
			}
		}

		// Token: 0x170092A0 RID: 37536
		// (get) Token: 0x0602600A RID: 155658 RVA: 0x0039A01E File Offset: 0x0039821E
		// (set) Token: 0x0602600B RID: 155659 RVA: 0x0039A037 File Offset: 0x00398237
		public unsafe bool GenerateGeomorphData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GenerateGeomorphData) & FReductionSettings.__PropertyMask_GenerateGeomorphData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GenerateGeomorphData) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_GenerateGeomorphData) & ~FReductionSettings.__PropertyMask_GenerateGeomorphData) | (value ? FReductionSettings.__PropertyMask_GenerateGeomorphData : 0));
			}
		}

		// Token: 0x170092A1 RID: 37537
		// (get) Token: 0x0602600C RID: 155660 RVA: 0x0039A067 File Offset: 0x00398267
		// (set) Token: 0x0602600D RID: 155661 RVA: 0x0039A077 File Offset: 0x00398277
		public unsafe EDataCreationPreferences DataCreationPreferences
		{
			get
			{
				return (EDataCreationPreferences)(*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_DataCreationPreferences));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_DataCreationPreferences) = (byte)value;
			}
		}

		// Token: 0x170092A2 RID: 37538
		// (get) Token: 0x0602600E RID: 155662 RVA: 0x0039A088 File Offset: 0x00398288
		// (set) Token: 0x0602600F RID: 155663 RVA: 0x0039A0A1 File Offset: 0x003982A1
		public unsafe bool UseHighQualityNormalCalculation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseHighQualityNormalCalculation) & FReductionSettings.__PropertyMask_UseHighQualityNormalCalculation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseHighQualityNormalCalculation) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_UseHighQualityNormalCalculation) & ~FReductionSettings.__PropertyMask_UseHighQualityNormalCalculation) | (value ? FReductionSettings.__PropertyMask_UseHighQualityNormalCalculation : 0));
			}
		}

		// Token: 0x170092A3 RID: 37539
		// (get) Token: 0x06026010 RID: 155664 RVA: 0x0039A0D1 File Offset: 0x003982D1
		// (set) Token: 0x06026011 RID: 155665 RVA: 0x0039A0EA File Offset: 0x003982EA
		public unsafe bool LockGeometricBorder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LockGeometricBorder) & FReductionSettings.__PropertyMask_LockGeometricBorder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LockGeometricBorder) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_LockGeometricBorder) & ~FReductionSettings.__PropertyMask_LockGeometricBorder) | (value ? FReductionSettings.__PropertyMask_LockGeometricBorder : 0));
			}
		}

		// Token: 0x170092A4 RID: 37540
		// (get) Token: 0x06026012 RID: 155666 RVA: 0x0039A11A File Offset: 0x0039831A
		// (set) Token: 0x06026013 RID: 155667 RVA: 0x0039A133 File Offset: 0x00398333
		public unsafe bool MergeGeometries
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MergeGeometries) & FReductionSettings.__PropertyMask_MergeGeometries) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MergeGeometries) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_MergeGeometries) & ~FReductionSettings.__PropertyMask_MergeGeometries) | (value ? FReductionSettings.__PropertyMask_MergeGeometries : 0));
			}
		}

		// Token: 0x170092A5 RID: 37541
		// (get) Token: 0x06026014 RID: 155668 RVA: 0x0039A163 File Offset: 0x00398363
		// (set) Token: 0x06026015 RID: 155669 RVA: 0x0039A17C File Offset: 0x0039837C
		public unsafe bool AllowDegenerateTexCoords
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_AllowDegenerateTexCoords) & FReductionSettings.__PropertyMask_AllowDegenerateTexCoords) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_AllowDegenerateTexCoords) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_AllowDegenerateTexCoords) & ~FReductionSettings.__PropertyMask_AllowDegenerateTexCoords) | (value ? FReductionSettings.__PropertyMask_AllowDegenerateTexCoords : 0));
			}
		}

		// Token: 0x170092A6 RID: 37542
		// (get) Token: 0x06026016 RID: 155670 RVA: 0x0039A1AC File Offset: 0x003983AC
		// (set) Token: 0x06026017 RID: 155671 RVA: 0x0039A1BC File Offset: 0x003983BC
		public unsafe int ProcessSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ProcessSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_ProcessSelectionSetID) = value;
			}
		}

		// Token: 0x170092A7 RID: 37543
		// (get) Token: 0x06026018 RID: 155672 RVA: 0x0039A1CD File Offset: 0x003983CD
		// (set) Token: 0x06026019 RID: 155673 RVA: 0x0039A1E1 File Offset: 0x003983E1
		public unsafe string ProcessSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FReductionSettings.__PropertyOffset_ProcessSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FReductionSettings.__PropertyOffset_ProcessSelectionSetName)), value);
			}
		}

		// Token: 0x170092A8 RID: 37544
		// (get) Token: 0x0602601A RID: 155674 RVA: 0x0039A1F6 File Offset: 0x003983F6
		// (set) Token: 0x0602601B RID: 155675 RVA: 0x0039A20F File Offset: 0x0039840F
		public unsafe bool KeepUnprocessedSceneMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & FReductionSettings.__PropertyMask_KeepUnprocessedSceneMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & ~FReductionSettings.__PropertyMask_KeepUnprocessedSceneMeshes) | (value ? FReductionSettings.__PropertyMask_KeepUnprocessedSceneMeshes : 0));
			}
		}

		// Token: 0x170092A9 RID: 37545
		// (get) Token: 0x0602601C RID: 155676 RVA: 0x0039A23F File Offset: 0x0039843F
		// (set) Token: 0x0602601D RID: 155677 RVA: 0x0039A258 File Offset: 0x00398458
		public unsafe bool PreserveQuadFlags
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_PreserveQuadFlags) & FReductionSettings.__PropertyMask_PreserveQuadFlags) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_PreserveQuadFlags) = ((*(base.NativePtr + (IntPtr)FReductionSettings.__PropertyOffset_PreserveQuadFlags) & ~FReductionSettings.__PropertyMask_PreserveQuadFlags) | (value ? FReductionSettings.__PropertyMask_PreserveQuadFlags : 0));
			}
		}

		// Token: 0x0602601E RID: 155678 RVA: 0x0039A288 File Offset: 0x00398488
		public FReductionSettings()
		{
		}

		// Token: 0x0602601F RID: 155679 RVA: 0x0039A290 File Offset: 0x00398490
		public FReductionSettings(bool ReductionTargetTriangleRatioEnabled, float ReductionTargetTriangleRatio, bool ReductionTargetTriangleCountEnabled, int ReductionTargetTriangleCount, bool ReductionTargetMaxDeviationEnabled, float ReductionTargetMaxDeviation, bool ReductionTargetOnScreenSizeEnabled, int ReductionTargetOnScreenSize, EReductionPerformanceMode ReductionPerformanceMode, EReductionTargetStopCondition ReductionTargetStopCondition, EReductionHeuristics ReductionHeuristics, float GeometryImportance, float MaterialImportance, float TextureImportance, float ShadingImportance, float GroupImportance, float VertexColorImportance, float EdgeSetImportance, float SkinningImportance, float OutwardMoveMultiplier, float InwardMoveMultiplier, bool LimitMaxEdgeLength, float MaxEdgeLength, bool KeepSymmetry, bool UseSymmetryQuadRetriangulator, bool UseAutomaticSymmetryDetection, float SymmetryDetectionTolerance, ESymmetryAxis SymmetryAxis, float SymmetryOffset, bool CreateGeomorphGeometry, bool GenerateGeomorphData, EDataCreationPreferences DataCreationPreferences, bool UseHighQualityNormalCalculation, bool LockGeometricBorder, bool MergeGeometries, bool AllowDegenerateTexCoords, int ProcessSelectionSetID, string ProcessSelectionSetName, bool KeepUnprocessedSceneMeshes, bool PreserveQuadFlags)
		{
			this.ReductionTargetTriangleRatioEnabled = ReductionTargetTriangleRatioEnabled;
			this.ReductionTargetTriangleRatio = ReductionTargetTriangleRatio;
			this.ReductionTargetTriangleCountEnabled = ReductionTargetTriangleCountEnabled;
			this.ReductionTargetTriangleCount = ReductionTargetTriangleCount;
			this.ReductionTargetMaxDeviationEnabled = ReductionTargetMaxDeviationEnabled;
			this.ReductionTargetMaxDeviation = ReductionTargetMaxDeviation;
			this.ReductionTargetOnScreenSizeEnabled = ReductionTargetOnScreenSizeEnabled;
			this.ReductionTargetOnScreenSize = ReductionTargetOnScreenSize;
			this.ReductionPerformanceMode = ReductionPerformanceMode;
			this.ReductionTargetStopCondition = ReductionTargetStopCondition;
			this.ReductionHeuristics = ReductionHeuristics;
			this.GeometryImportance = GeometryImportance;
			this.MaterialImportance = MaterialImportance;
			this.TextureImportance = TextureImportance;
			this.ShadingImportance = ShadingImportance;
			this.GroupImportance = GroupImportance;
			this.VertexColorImportance = VertexColorImportance;
			this.EdgeSetImportance = EdgeSetImportance;
			this.SkinningImportance = SkinningImportance;
			this.OutwardMoveMultiplier = OutwardMoveMultiplier;
			this.InwardMoveMultiplier = InwardMoveMultiplier;
			this.LimitMaxEdgeLength = LimitMaxEdgeLength;
			this.MaxEdgeLength = MaxEdgeLength;
			this.KeepSymmetry = KeepSymmetry;
			this.UseSymmetryQuadRetriangulator = UseSymmetryQuadRetriangulator;
			this.UseAutomaticSymmetryDetection = UseAutomaticSymmetryDetection;
			this.SymmetryDetectionTolerance = SymmetryDetectionTolerance;
			this.SymmetryAxis = SymmetryAxis;
			this.SymmetryOffset = SymmetryOffset;
			this.CreateGeomorphGeometry = CreateGeomorphGeometry;
			this.GenerateGeomorphData = GenerateGeomorphData;
			this.DataCreationPreferences = DataCreationPreferences;
			this.UseHighQualityNormalCalculation = UseHighQualityNormalCalculation;
			this.LockGeometricBorder = LockGeometricBorder;
			this.MergeGeometries = MergeGeometries;
			this.AllowDegenerateTexCoords = AllowDegenerateTexCoords;
			this.ProcessSelectionSetID = ProcessSelectionSetID;
			this.ProcessSelectionSetName = ProcessSelectionSetName;
			this.KeepUnprocessedSceneMeshes = KeepUnprocessedSceneMeshes;
			this.PreserveQuadFlags = PreserveQuadFlags;
		}

		// Token: 0x06026020 RID: 155680 RVA: 0x0039A3E0 File Offset: 0x003985E0
		protected override IntPtr GetUStructPtr()
		{
			return FReductionSettings.StaticStruct();
		}

		// Token: 0x06026021 RID: 155681 RVA: 0x0039A3EC File Offset: 0x003985EC
		[NullableContext(2)]
		public FReductionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026022 RID: 155682 RVA: 0x0039A3F6 File Offset: 0x003985F6
		public FReductionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026023 RID: 155683 RVA: 0x0039A401 File Offset: 0x00398601
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReductionSettings(Pointer, false, true);
		}

		// Token: 0x06026024 RID: 155684 RVA: 0x0039A40B File Offset: 0x0039860B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReductionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014BCA RID: 84938
		public const string __ObjectPath = "/Script/SimplygonUObjects.ReductionSettings";

		// Token: 0x04014BCB RID: 84939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BCC RID: 84940
		internal static int __PropertyOffset_ReductionTargetTriangleRatioEnabled;

		// Token: 0x04014BCD RID: 84941
		internal static byte __PropertyMask_ReductionTargetTriangleRatioEnabled;

		// Token: 0x04014BCE RID: 84942
		internal static int __PropertyOffset_ReductionTargetTriangleRatio;

		// Token: 0x04014BCF RID: 84943
		internal static int __PropertyOffset_ReductionTargetTriangleCountEnabled;

		// Token: 0x04014BD0 RID: 84944
		internal static byte __PropertyMask_ReductionTargetTriangleCountEnabled;

		// Token: 0x04014BD1 RID: 84945
		internal static int __PropertyOffset_ReductionTargetTriangleCount;

		// Token: 0x04014BD2 RID: 84946
		internal static int __PropertyOffset_ReductionTargetMaxDeviationEnabled;

		// Token: 0x04014BD3 RID: 84947
		internal static byte __PropertyMask_ReductionTargetMaxDeviationEnabled;

		// Token: 0x04014BD4 RID: 84948
		internal static int __PropertyOffset_ReductionTargetMaxDeviation;

		// Token: 0x04014BD5 RID: 84949
		internal static int __PropertyOffset_ReductionTargetOnScreenSizeEnabled;

		// Token: 0x04014BD6 RID: 84950
		internal static byte __PropertyMask_ReductionTargetOnScreenSizeEnabled;

		// Token: 0x04014BD7 RID: 84951
		internal static int __PropertyOffset_ReductionTargetOnScreenSize;

		// Token: 0x04014BD8 RID: 84952
		internal static int __PropertyOffset_ReductionPerformanceMode;

		// Token: 0x04014BD9 RID: 84953
		internal static int __PropertyOffset_ReductionTargetStopCondition;

		// Token: 0x04014BDA RID: 84954
		internal static int __PropertyOffset_ReductionHeuristics;

		// Token: 0x04014BDB RID: 84955
		internal static int __PropertyOffset_GeometryImportance;

		// Token: 0x04014BDC RID: 84956
		internal static int __PropertyOffset_MaterialImportance;

		// Token: 0x04014BDD RID: 84957
		internal static int __PropertyOffset_TextureImportance;

		// Token: 0x04014BDE RID: 84958
		internal static int __PropertyOffset_ShadingImportance;

		// Token: 0x04014BDF RID: 84959
		internal static int __PropertyOffset_GroupImportance;

		// Token: 0x04014BE0 RID: 84960
		internal static int __PropertyOffset_VertexColorImportance;

		// Token: 0x04014BE1 RID: 84961
		internal static int __PropertyOffset_EdgeSetImportance;

		// Token: 0x04014BE2 RID: 84962
		internal static int __PropertyOffset_SkinningImportance;

		// Token: 0x04014BE3 RID: 84963
		internal static int __PropertyOffset_OutwardMoveMultiplier;

		// Token: 0x04014BE4 RID: 84964
		internal static int __PropertyOffset_InwardMoveMultiplier;

		// Token: 0x04014BE5 RID: 84965
		internal static int __PropertyOffset_LimitMaxEdgeLength;

		// Token: 0x04014BE6 RID: 84966
		internal static byte __PropertyMask_LimitMaxEdgeLength;

		// Token: 0x04014BE7 RID: 84967
		internal static int __PropertyOffset_MaxEdgeLength;

		// Token: 0x04014BE8 RID: 84968
		internal static int __PropertyOffset_KeepSymmetry;

		// Token: 0x04014BE9 RID: 84969
		internal static byte __PropertyMask_KeepSymmetry;

		// Token: 0x04014BEA RID: 84970
		internal static int __PropertyOffset_UseSymmetryQuadRetriangulator;

		// Token: 0x04014BEB RID: 84971
		internal static byte __PropertyMask_UseSymmetryQuadRetriangulator;

		// Token: 0x04014BEC RID: 84972
		internal static int __PropertyOffset_UseAutomaticSymmetryDetection;

		// Token: 0x04014BED RID: 84973
		internal static byte __PropertyMask_UseAutomaticSymmetryDetection;

		// Token: 0x04014BEE RID: 84974
		internal static int __PropertyOffset_SymmetryDetectionTolerance;

		// Token: 0x04014BEF RID: 84975
		internal static int __PropertyOffset_SymmetryAxis;

		// Token: 0x04014BF0 RID: 84976
		internal static int __PropertyOffset_SymmetryOffset;

		// Token: 0x04014BF1 RID: 84977
		internal static int __PropertyOffset_CreateGeomorphGeometry;

		// Token: 0x04014BF2 RID: 84978
		internal static byte __PropertyMask_CreateGeomorphGeometry;

		// Token: 0x04014BF3 RID: 84979
		internal static int __PropertyOffset_GenerateGeomorphData;

		// Token: 0x04014BF4 RID: 84980
		internal static byte __PropertyMask_GenerateGeomorphData;

		// Token: 0x04014BF5 RID: 84981
		internal static int __PropertyOffset_DataCreationPreferences;

		// Token: 0x04014BF6 RID: 84982
		internal static int __PropertyOffset_UseHighQualityNormalCalculation;

		// Token: 0x04014BF7 RID: 84983
		internal static byte __PropertyMask_UseHighQualityNormalCalculation;

		// Token: 0x04014BF8 RID: 84984
		internal static int __PropertyOffset_LockGeometricBorder;

		// Token: 0x04014BF9 RID: 84985
		internal static byte __PropertyMask_LockGeometricBorder;

		// Token: 0x04014BFA RID: 84986
		internal static int __PropertyOffset_MergeGeometries;

		// Token: 0x04014BFB RID: 84987
		internal static byte __PropertyMask_MergeGeometries;

		// Token: 0x04014BFC RID: 84988
		internal static int __PropertyOffset_AllowDegenerateTexCoords;

		// Token: 0x04014BFD RID: 84989
		internal static byte __PropertyMask_AllowDegenerateTexCoords;

		// Token: 0x04014BFE RID: 84990
		internal static int __PropertyOffset_ProcessSelectionSetID;

		// Token: 0x04014BFF RID: 84991
		internal static int __PropertyOffset_ProcessSelectionSetName;

		// Token: 0x04014C00 RID: 84992
		internal static int __PropertyOffset_KeepUnprocessedSceneMeshes;

		// Token: 0x04014C01 RID: 84993
		internal static byte __PropertyMask_KeepUnprocessedSceneMeshes;

		// Token: 0x04014C02 RID: 84994
		internal static int __PropertyOffset_PreserveQuadFlags;

		// Token: 0x04014C03 RID: 84995
		internal static byte __PropertyMask_PreserveQuadFlags;
	}
}
