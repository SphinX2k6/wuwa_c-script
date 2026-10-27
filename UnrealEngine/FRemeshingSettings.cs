using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027D0 RID: 10192
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.RemeshingSettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRemeshingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026042 RID: 155714 RVA: 0x0039A836 File Offset: 0x00398A36
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRemeshingSettings._ScriptStructPtr != 0) ? FRemeshingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.RemeshingSettings", ref FRemeshingSettings._ScriptStructPtr);
		}

		// Token: 0x170092B2 RID: 37554
		// (get) Token: 0x06026043 RID: 155715 RVA: 0x0039A85A File Offset: 0x00398A5A
		// (set) Token: 0x06026044 RID: 155716 RVA: 0x0039A86A File Offset: 0x00398A6A
		public unsafe ERemeshingTarget RemeshingTarget
		{
			get
			{
				return (ERemeshingTarget)(*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingTarget) = (byte)value;
			}
		}

		// Token: 0x170092B3 RID: 37555
		// (get) Token: 0x06026045 RID: 155717 RVA: 0x0039A87B File Offset: 0x00398A7B
		// (set) Token: 0x06026046 RID: 155718 RVA: 0x0039A88B File Offset: 0x00398A8B
		public unsafe int OnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_OnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_OnScreenSize) = value;
			}
		}

		// Token: 0x170092B4 RID: 37556
		// (get) Token: 0x06026047 RID: 155719 RVA: 0x0039A89C File Offset: 0x00398A9C
		// (set) Token: 0x06026048 RID: 155720 RVA: 0x0039A8AC File Offset: 0x00398AAC
		public unsafe float MaxDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxDeviation) = value;
			}
		}

		// Token: 0x170092B5 RID: 37557
		// (get) Token: 0x06026049 RID: 155721 RVA: 0x0039A8BD File Offset: 0x00398ABD
		// (set) Token: 0x0602604A RID: 155722 RVA: 0x0039A8CD File Offset: 0x00398ACD
		public unsafe int MaxDerivedOnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxDerivedOnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxDerivedOnScreenSize) = value;
			}
		}

		// Token: 0x170092B6 RID: 37558
		// (get) Token: 0x0602604B RID: 155723 RVA: 0x0039A8DE File Offset: 0x00398ADE
		// (set) Token: 0x0602604C RID: 155724 RVA: 0x0039A8EE File Offset: 0x00398AEE
		public unsafe ERemeshingMode RemeshingMode
		{
			get
			{
				return (ERemeshingMode)(*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingMode) = (byte)value;
			}
		}

		// Token: 0x170092B7 RID: 37559
		// (get) Token: 0x0602604D RID: 155725 RVA: 0x0039A8FF File Offset: 0x00398AFF
		// (set) Token: 0x0602604E RID: 155726 RVA: 0x0039A90F File Offset: 0x00398B0F
		public unsafe EHoleFilling HoleFilling
		{
			get
			{
				return (EHoleFilling)(*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_HoleFilling));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_HoleFilling) = (byte)value;
			}
		}

		// Token: 0x170092B8 RID: 37560
		// (get) Token: 0x0602604F RID: 155727 RVA: 0x0039A920 File Offset: 0x00398B20
		// (set) Token: 0x06026050 RID: 155728 RVA: 0x0039A930 File Offset: 0x00398B30
		public unsafe float RemeshingModeManualPositionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionX) = value;
			}
		}

		// Token: 0x170092B9 RID: 37561
		// (get) Token: 0x06026051 RID: 155729 RVA: 0x0039A941 File Offset: 0x00398B41
		// (set) Token: 0x06026052 RID: 155730 RVA: 0x0039A951 File Offset: 0x00398B51
		public unsafe float RemeshingModeManualPositionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionY) = value;
			}
		}

		// Token: 0x170092BA RID: 37562
		// (get) Token: 0x06026053 RID: 155731 RVA: 0x0039A962 File Offset: 0x00398B62
		// (set) Token: 0x06026054 RID: 155732 RVA: 0x0039A972 File Offset: 0x00398B72
		public unsafe float RemeshingModeManualPositionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_RemeshingModeManualPositionZ) = value;
			}
		}

		// Token: 0x170092BB RID: 37563
		// (get) Token: 0x06026055 RID: 155733 RVA: 0x0039A983 File Offset: 0x00398B83
		// (set) Token: 0x06026056 RID: 155734 RVA: 0x0039A993 File Offset: 0x00398B93
		public unsafe ESurfaceTransferMode SurfaceTransferMode
		{
			get
			{
				return (ESurfaceTransferMode)(*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_SurfaceTransferMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_SurfaceTransferMode) = (byte)value;
			}
		}

		// Token: 0x170092BC RID: 37564
		// (get) Token: 0x06026057 RID: 155735 RVA: 0x0039A9A4 File Offset: 0x00398BA4
		// (set) Token: 0x06026058 RID: 155736 RVA: 0x0039A9B4 File Offset: 0x00398BB4
		public unsafe float HardEdgeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_HardEdgeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_HardEdgeAngle) = value;
			}
		}

		// Token: 0x170092BD RID: 37565
		// (get) Token: 0x06026059 RID: 155737 RVA: 0x0039A9C5 File Offset: 0x00398BC5
		// (set) Token: 0x0602605A RID: 155738 RVA: 0x0039A9DE File Offset: 0x00398BDE
		public unsafe bool TransferNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferNormals) & FRemeshingSettings.__PropertyMask_TransferNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferNormals) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferNormals) & ~FRemeshingSettings.__PropertyMask_TransferNormals) | (value ? FRemeshingSettings.__PropertyMask_TransferNormals : 0));
			}
		}

		// Token: 0x170092BE RID: 37566
		// (get) Token: 0x0602605B RID: 155739 RVA: 0x0039AA0E File Offset: 0x00398C0E
		// (set) Token: 0x0602605C RID: 155740 RVA: 0x0039AA27 File Offset: 0x00398C27
		public unsafe bool TransferColors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferColors) & FRemeshingSettings.__PropertyMask_TransferColors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferColors) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TransferColors) & ~FRemeshingSettings.__PropertyMask_TransferColors) | (value ? FRemeshingSettings.__PropertyMask_TransferColors : 0));
			}
		}

		// Token: 0x170092BF RID: 37567
		// (get) Token: 0x0602605D RID: 155741 RVA: 0x0039AA57 File Offset: 0x00398C57
		// (set) Token: 0x0602605E RID: 155742 RVA: 0x0039AA70 File Offset: 0x00398C70
		public unsafe bool LimitMaxEdgeLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_LimitMaxEdgeLength) & FRemeshingSettings.__PropertyMask_LimitMaxEdgeLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_LimitMaxEdgeLength) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_LimitMaxEdgeLength) & ~FRemeshingSettings.__PropertyMask_LimitMaxEdgeLength) | (value ? FRemeshingSettings.__PropertyMask_LimitMaxEdgeLength : 0));
			}
		}

		// Token: 0x170092C0 RID: 37568
		// (get) Token: 0x0602605F RID: 155743 RVA: 0x0039AAA0 File Offset: 0x00398CA0
		// (set) Token: 0x06026060 RID: 155744 RVA: 0x0039AAB0 File Offset: 0x00398CB0
		public unsafe float MaxEdgeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxEdgeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_MaxEdgeLength) = value;
			}
		}

		// Token: 0x170092C1 RID: 37569
		// (get) Token: 0x06026061 RID: 155745 RVA: 0x0039AAC1 File Offset: 0x00398CC1
		// (set) Token: 0x06026062 RID: 155746 RVA: 0x0039AADA File Offset: 0x00398CDA
		public unsafe bool PopulateAttributeTessellationDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_PopulateAttributeTessellationDisplacement) & FRemeshingSettings.__PropertyMask_PopulateAttributeTessellationDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_PopulateAttributeTessellationDisplacement) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_PopulateAttributeTessellationDisplacement) & ~FRemeshingSettings.__PropertyMask_PopulateAttributeTessellationDisplacement) | (value ? FRemeshingSettings.__PropertyMask_PopulateAttributeTessellationDisplacement : 0));
			}
		}

		// Token: 0x170092C2 RID: 37570
		// (get) Token: 0x06026063 RID: 155747 RVA: 0x0039AB0A File Offset: 0x00398D0A
		// (set) Token: 0x06026064 RID: 155748 RVA: 0x0039AB1A File Offset: 0x00398D1A
		public unsafe float GeometricalAccuracy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_GeometricalAccuracy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_GeometricalAccuracy) = value;
			}
		}

		// Token: 0x170092C3 RID: 37571
		// (get) Token: 0x06026065 RID: 155749 RVA: 0x0039AB2B File Offset: 0x00398D2B
		// (set) Token: 0x06026066 RID: 155750 RVA: 0x0039AB3B File Offset: 0x00398D3B
		public unsafe float TopologicalAccuracy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TopologicalAccuracy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_TopologicalAccuracy) = value;
			}
		}

		// Token: 0x170092C4 RID: 37572
		// (get) Token: 0x06026067 RID: 155751 RVA: 0x0039AB4C File Offset: 0x00398D4C
		// (set) Token: 0x06026068 RID: 155752 RVA: 0x0039AB5C File Offset: 0x00398D5C
		public unsafe int ProcessSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_ProcessSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_ProcessSelectionSetID) = value;
			}
		}

		// Token: 0x170092C5 RID: 37573
		// (get) Token: 0x06026069 RID: 155753 RVA: 0x0039AB6D File Offset: 0x00398D6D
		// (set) Token: 0x0602606A RID: 155754 RVA: 0x0039AB81 File Offset: 0x00398D81
		public unsafe string ProcessSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRemeshingSettings.__PropertyOffset_ProcessSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRemeshingSettings.__PropertyOffset_ProcessSelectionSetName)), value);
			}
		}

		// Token: 0x170092C6 RID: 37574
		// (get) Token: 0x0602606B RID: 155755 RVA: 0x0039AB96 File Offset: 0x00398D96
		// (set) Token: 0x0602606C RID: 155756 RVA: 0x0039ABAF File Offset: 0x00398DAF
		public unsafe bool KeepUnprocessedSceneMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & FRemeshingSettings.__PropertyMask_KeepUnprocessedSceneMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & ~FRemeshingSettings.__PropertyMask_KeepUnprocessedSceneMeshes) | (value ? FRemeshingSettings.__PropertyMask_KeepUnprocessedSceneMeshes : 0));
			}
		}

		// Token: 0x170092C7 RID: 37575
		// (get) Token: 0x0602606D RID: 155757 RVA: 0x0039ABDF File Offset: 0x00398DDF
		// (set) Token: 0x0602606E RID: 155758 RVA: 0x0039ABF8 File Offset: 0x00398DF8
		public unsafe bool ForceSoftEdgesWithinTextureCharts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_ForceSoftEdgesWithinTextureCharts) & FRemeshingSettings.__PropertyMask_ForceSoftEdgesWithinTextureCharts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_ForceSoftEdgesWithinTextureCharts) = ((*(base.NativePtr + (IntPtr)FRemeshingSettings.__PropertyOffset_ForceSoftEdgesWithinTextureCharts) & ~FRemeshingSettings.__PropertyMask_ForceSoftEdgesWithinTextureCharts) | (value ? FRemeshingSettings.__PropertyMask_ForceSoftEdgesWithinTextureCharts : 0));
			}
		}

		// Token: 0x0602606F RID: 155759 RVA: 0x0039AC28 File Offset: 0x00398E28
		public FRemeshingSettings()
		{
		}

		// Token: 0x06026070 RID: 155760 RVA: 0x0039AC30 File Offset: 0x00398E30
		public FRemeshingSettings(ERemeshingTarget RemeshingTarget, int OnScreenSize, float MaxDeviation, int MaxDerivedOnScreenSize, ERemeshingMode RemeshingMode, EHoleFilling HoleFilling, float RemeshingModeManualPositionX, float RemeshingModeManualPositionY, float RemeshingModeManualPositionZ, ESurfaceTransferMode SurfaceTransferMode, float HardEdgeAngle, bool TransferNormals, bool TransferColors, bool LimitMaxEdgeLength, float MaxEdgeLength, bool PopulateAttributeTessellationDisplacement, float GeometricalAccuracy, float TopologicalAccuracy, int ProcessSelectionSetID, string ProcessSelectionSetName, bool KeepUnprocessedSceneMeshes, bool ForceSoftEdgesWithinTextureCharts)
		{
			this.RemeshingTarget = RemeshingTarget;
			this.OnScreenSize = OnScreenSize;
			this.MaxDeviation = MaxDeviation;
			this.MaxDerivedOnScreenSize = MaxDerivedOnScreenSize;
			this.RemeshingMode = RemeshingMode;
			this.HoleFilling = HoleFilling;
			this.RemeshingModeManualPositionX = RemeshingModeManualPositionX;
			this.RemeshingModeManualPositionY = RemeshingModeManualPositionY;
			this.RemeshingModeManualPositionZ = RemeshingModeManualPositionZ;
			this.SurfaceTransferMode = SurfaceTransferMode;
			this.HardEdgeAngle = HardEdgeAngle;
			this.TransferNormals = TransferNormals;
			this.TransferColors = TransferColors;
			this.LimitMaxEdgeLength = LimitMaxEdgeLength;
			this.MaxEdgeLength = MaxEdgeLength;
			this.PopulateAttributeTessellationDisplacement = PopulateAttributeTessellationDisplacement;
			this.GeometricalAccuracy = GeometricalAccuracy;
			this.TopologicalAccuracy = TopologicalAccuracy;
			this.ProcessSelectionSetID = ProcessSelectionSetID;
			this.ProcessSelectionSetName = ProcessSelectionSetName;
			this.KeepUnprocessedSceneMeshes = KeepUnprocessedSceneMeshes;
			this.ForceSoftEdgesWithinTextureCharts = ForceSoftEdgesWithinTextureCharts;
		}

		// Token: 0x06026071 RID: 155761 RVA: 0x0039ACF0 File Offset: 0x00398EF0
		protected override IntPtr GetUStructPtr()
		{
			return FRemeshingSettings.StaticStruct();
		}

		// Token: 0x06026072 RID: 155762 RVA: 0x0039ACFC File Offset: 0x00398EFC
		[NullableContext(2)]
		public FRemeshingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026073 RID: 155763 RVA: 0x0039AD06 File Offset: 0x00398F06
		public FRemeshingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026074 RID: 155764 RVA: 0x0039AD11 File Offset: 0x00398F11
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRemeshingSettings(Pointer, false, true);
		}

		// Token: 0x06026075 RID: 155765 RVA: 0x0039AD1B File Offset: 0x00398F1B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRemeshingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C19 RID: 85017
		public const string __ObjectPath = "/Script/SimplygonUObjects.RemeshingSettings";

		// Token: 0x04014C1A RID: 85018
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C1B RID: 85019
		internal static int __PropertyOffset_RemeshingTarget;

		// Token: 0x04014C1C RID: 85020
		internal static int __PropertyOffset_OnScreenSize;

		// Token: 0x04014C1D RID: 85021
		internal static int __PropertyOffset_MaxDeviation;

		// Token: 0x04014C1E RID: 85022
		internal static int __PropertyOffset_MaxDerivedOnScreenSize;

		// Token: 0x04014C1F RID: 85023
		internal static int __PropertyOffset_RemeshingMode;

		// Token: 0x04014C20 RID: 85024
		internal static int __PropertyOffset_HoleFilling;

		// Token: 0x04014C21 RID: 85025
		internal static int __PropertyOffset_RemeshingModeManualPositionX;

		// Token: 0x04014C22 RID: 85026
		internal static int __PropertyOffset_RemeshingModeManualPositionY;

		// Token: 0x04014C23 RID: 85027
		internal static int __PropertyOffset_RemeshingModeManualPositionZ;

		// Token: 0x04014C24 RID: 85028
		internal static int __PropertyOffset_SurfaceTransferMode;

		// Token: 0x04014C25 RID: 85029
		internal static int __PropertyOffset_HardEdgeAngle;

		// Token: 0x04014C26 RID: 85030
		internal static int __PropertyOffset_TransferNormals;

		// Token: 0x04014C27 RID: 85031
		internal static byte __PropertyMask_TransferNormals;

		// Token: 0x04014C28 RID: 85032
		internal static int __PropertyOffset_TransferColors;

		// Token: 0x04014C29 RID: 85033
		internal static byte __PropertyMask_TransferColors;

		// Token: 0x04014C2A RID: 85034
		internal static int __PropertyOffset_LimitMaxEdgeLength;

		// Token: 0x04014C2B RID: 85035
		internal static byte __PropertyMask_LimitMaxEdgeLength;

		// Token: 0x04014C2C RID: 85036
		internal static int __PropertyOffset_MaxEdgeLength;

		// Token: 0x04014C2D RID: 85037
		internal static int __PropertyOffset_PopulateAttributeTessellationDisplacement;

		// Token: 0x04014C2E RID: 85038
		internal static byte __PropertyMask_PopulateAttributeTessellationDisplacement;

		// Token: 0x04014C2F RID: 85039
		internal static int __PropertyOffset_GeometricalAccuracy;

		// Token: 0x04014C30 RID: 85040
		internal static int __PropertyOffset_TopologicalAccuracy;

		// Token: 0x04014C31 RID: 85041
		internal static int __PropertyOffset_ProcessSelectionSetID;

		// Token: 0x04014C32 RID: 85042
		internal static int __PropertyOffset_ProcessSelectionSetName;

		// Token: 0x04014C33 RID: 85043
		internal static int __PropertyOffset_KeepUnprocessedSceneMeshes;

		// Token: 0x04014C34 RID: 85044
		internal static byte __PropertyMask_KeepUnprocessedSceneMeshes;

		// Token: 0x04014C35 RID: 85045
		internal static int __PropertyOffset_ForceSoftEdgesWithinTextureCharts;

		// Token: 0x04014C36 RID: 85046
		internal static byte __PropertyMask_ForceSoftEdgesWithinTextureCharts;
	}
}
