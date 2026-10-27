using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D4F RID: 3407
	[UnrealObjectPath("/Script/Engine.LightmassDebugOptions")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLightmassDebugOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B7D5 RID: 47061 RVA: 0x00105882 File Offset: 0x00103A82
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassDebugOptions._ScriptStructPtr != 0) ? FLightmassDebugOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassDebugOptions", ref FLightmassDebugOptions._ScriptStructPtr);
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x001058A6 File Offset: 0x00103AA6
		// (set) Token: 0x0600B7D7 RID: 47063 RVA: 0x001058BF File Offset: 0x00103ABF
		public unsafe bool bDebugMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMode) & FLightmassDebugOptions.__PropertyMask_bDebugMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMode) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMode) & ~FLightmassDebugOptions.__PropertyMask_bDebugMode) | (value ? FLightmassDebugOptions.__PropertyMask_bDebugMode : 0));
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x001058EF File Offset: 0x00103AEF
		// (set) Token: 0x0600B7D9 RID: 47065 RVA: 0x00105908 File Offset: 0x00103B08
		public unsafe bool bStatsEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bStatsEnabled) & FLightmassDebugOptions.__PropertyMask_bStatsEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bStatsEnabled) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bStatsEnabled) & ~FLightmassDebugOptions.__PropertyMask_bStatsEnabled) | (value ? FLightmassDebugOptions.__PropertyMask_bStatsEnabled : 0));
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x00105938 File Offset: 0x00103B38
		// (set) Token: 0x0600B7DB RID: 47067 RVA: 0x00105951 File Offset: 0x00103B51
		public unsafe bool bGatherBSPSurfacesAcrossComponents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bGatherBSPSurfacesAcrossComponents) & FLightmassDebugOptions.__PropertyMask_bGatherBSPSurfacesAcrossComponents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bGatherBSPSurfacesAcrossComponents) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bGatherBSPSurfacesAcrossComponents) & ~FLightmassDebugOptions.__PropertyMask_bGatherBSPSurfacesAcrossComponents) | (value ? FLightmassDebugOptions.__PropertyMask_bGatherBSPSurfacesAcrossComponents : 0));
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600B7DC RID: 47068 RVA: 0x00105981 File Offset: 0x00103B81
		// (set) Token: 0x0600B7DD RID: 47069 RVA: 0x00105991 File Offset: 0x00103B91
		public unsafe float CoplanarTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_CoplanarTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_CoplanarTolerance) = value;
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600B7DE RID: 47070 RVA: 0x001059A2 File Offset: 0x00103BA2
		// (set) Token: 0x0600B7DF RID: 47071 RVA: 0x001059BB File Offset: 0x00103BBB
		public unsafe bool bUseImmediateImport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseImmediateImport) & FLightmassDebugOptions.__PropertyMask_bUseImmediateImport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseImmediateImport) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseImmediateImport) & ~FLightmassDebugOptions.__PropertyMask_bUseImmediateImport) | (value ? FLightmassDebugOptions.__PropertyMask_bUseImmediateImport : 0));
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x001059EB File Offset: 0x00103BEB
		// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x00105A04 File Offset: 0x00103C04
		public unsafe bool bImmediateProcessMappings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bImmediateProcessMappings) & FLightmassDebugOptions.__PropertyMask_bImmediateProcessMappings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bImmediateProcessMappings) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bImmediateProcessMappings) & ~FLightmassDebugOptions.__PropertyMask_bImmediateProcessMappings) | (value ? FLightmassDebugOptions.__PropertyMask_bImmediateProcessMappings : 0));
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x00105A34 File Offset: 0x00103C34
		// (set) Token: 0x0600B7E3 RID: 47075 RVA: 0x00105A4D File Offset: 0x00103C4D
		public unsafe bool bSortMappings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bSortMappings) & FLightmassDebugOptions.__PropertyMask_bSortMappings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bSortMappings) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bSortMappings) & ~FLightmassDebugOptions.__PropertyMask_bSortMappings) | (value ? FLightmassDebugOptions.__PropertyMask_bSortMappings : 0));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0600B7E4 RID: 47076 RVA: 0x00105A7D File Offset: 0x00103C7D
		// (set) Token: 0x0600B7E5 RID: 47077 RVA: 0x00105A96 File Offset: 0x00103C96
		public unsafe bool bDumpBinaryFiles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDumpBinaryFiles) & FLightmassDebugOptions.__PropertyMask_bDumpBinaryFiles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDumpBinaryFiles) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDumpBinaryFiles) & ~FLightmassDebugOptions.__PropertyMask_bDumpBinaryFiles) | (value ? FLightmassDebugOptions.__PropertyMask_bDumpBinaryFiles : 0));
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x00105AC6 File Offset: 0x00103CC6
		// (set) Token: 0x0600B7E7 RID: 47079 RVA: 0x00105ADF File Offset: 0x00103CDF
		public unsafe bool bDebugMaterials
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMaterials) & FLightmassDebugOptions.__PropertyMask_bDebugMaterials) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMaterials) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugMaterials) & ~FLightmassDebugOptions.__PropertyMask_bDebugMaterials) | (value ? FLightmassDebugOptions.__PropertyMask_bDebugMaterials : 0));
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x00105B0F File Offset: 0x00103D0F
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x00105B28 File Offset: 0x00103D28
		public unsafe bool bPadMappings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bPadMappings) & FLightmassDebugOptions.__PropertyMask_bPadMappings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bPadMappings) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bPadMappings) & ~FLightmassDebugOptions.__PropertyMask_bPadMappings) | (value ? FLightmassDebugOptions.__PropertyMask_bPadMappings : 0));
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x00105B58 File Offset: 0x00103D58
		// (set) Token: 0x0600B7EB RID: 47083 RVA: 0x00105B71 File Offset: 0x00103D71
		public unsafe bool bDebugPaddings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugPaddings) & FLightmassDebugOptions.__PropertyMask_bDebugPaddings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugPaddings) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bDebugPaddings) & ~FLightmassDebugOptions.__PropertyMask_bDebugPaddings) | (value ? FLightmassDebugOptions.__PropertyMask_bDebugPaddings : 0));
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600B7EC RID: 47084 RVA: 0x00105BA1 File Offset: 0x00103DA1
		// (set) Token: 0x0600B7ED RID: 47085 RVA: 0x00105BBA File Offset: 0x00103DBA
		public unsafe bool bOnlyCalcDebugTexelMappings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bOnlyCalcDebugTexelMappings) & FLightmassDebugOptions.__PropertyMask_bOnlyCalcDebugTexelMappings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bOnlyCalcDebugTexelMappings) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bOnlyCalcDebugTexelMappings) & ~FLightmassDebugOptions.__PropertyMask_bOnlyCalcDebugTexelMappings) | (value ? FLightmassDebugOptions.__PropertyMask_bOnlyCalcDebugTexelMappings : 0));
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600B7EE RID: 47086 RVA: 0x00105BEA File Offset: 0x00103DEA
		// (set) Token: 0x0600B7EF RID: 47087 RVA: 0x00105C03 File Offset: 0x00103E03
		public unsafe bool bUseRandomColors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseRandomColors) & FLightmassDebugOptions.__PropertyMask_bUseRandomColors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseRandomColors) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bUseRandomColors) & ~FLightmassDebugOptions.__PropertyMask_bUseRandomColors) | (value ? FLightmassDebugOptions.__PropertyMask_bUseRandomColors : 0));
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600B7F0 RID: 47088 RVA: 0x00105C33 File Offset: 0x00103E33
		// (set) Token: 0x0600B7F1 RID: 47089 RVA: 0x00105C4C File Offset: 0x00103E4C
		public unsafe bool bColorBordersGreen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorBordersGreen) & FLightmassDebugOptions.__PropertyMask_bColorBordersGreen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorBordersGreen) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorBordersGreen) & ~FLightmassDebugOptions.__PropertyMask_bColorBordersGreen) | (value ? FLightmassDebugOptions.__PropertyMask_bColorBordersGreen : 0));
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600B7F2 RID: 47090 RVA: 0x00105C7C File Offset: 0x00103E7C
		// (set) Token: 0x0600B7F3 RID: 47091 RVA: 0x00105C95 File Offset: 0x00103E95
		public unsafe bool bColorByExecutionTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorByExecutionTime) & FLightmassDebugOptions.__PropertyMask_bColorByExecutionTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorByExecutionTime) = ((*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_bColorByExecutionTime) & ~FLightmassDebugOptions.__PropertyMask_bColorByExecutionTime) | (value ? FLightmassDebugOptions.__PropertyMask_bColorByExecutionTime : 0));
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600B7F4 RID: 47092 RVA: 0x00105CC5 File Offset: 0x00103EC5
		// (set) Token: 0x0600B7F5 RID: 47093 RVA: 0x00105CD5 File Offset: 0x00103ED5
		public unsafe float ExecutionTimeDivisor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_ExecutionTimeDivisor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassDebugOptions.__PropertyOffset_ExecutionTimeDivisor) = value;
			}
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x00105CE6 File Offset: 0x00103EE6
		public FLightmassDebugOptions()
		{
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x00105CF0 File Offset: 0x00103EF0
		public FLightmassDebugOptions(bool bDebugMode, bool bStatsEnabled, bool bGatherBSPSurfacesAcrossComponents, float CoplanarTolerance, bool bUseImmediateImport, bool bImmediateProcessMappings, bool bSortMappings, bool bDumpBinaryFiles, bool bDebugMaterials, bool bPadMappings, bool bDebugPaddings, bool bOnlyCalcDebugTexelMappings, bool bUseRandomColors, bool bColorBordersGreen, bool bColorByExecutionTime, float ExecutionTimeDivisor)
		{
			this.bDebugMode = bDebugMode;
			this.bStatsEnabled = bStatsEnabled;
			this.bGatherBSPSurfacesAcrossComponents = bGatherBSPSurfacesAcrossComponents;
			this.CoplanarTolerance = CoplanarTolerance;
			this.bUseImmediateImport = bUseImmediateImport;
			this.bImmediateProcessMappings = bImmediateProcessMappings;
			this.bSortMappings = bSortMappings;
			this.bDumpBinaryFiles = bDumpBinaryFiles;
			this.bDebugMaterials = bDebugMaterials;
			this.bPadMappings = bPadMappings;
			this.bDebugPaddings = bDebugPaddings;
			this.bOnlyCalcDebugTexelMappings = bOnlyCalcDebugTexelMappings;
			this.bUseRandomColors = bUseRandomColors;
			this.bColorBordersGreen = bColorBordersGreen;
			this.bColorByExecutionTime = bColorByExecutionTime;
			this.ExecutionTimeDivisor = ExecutionTimeDivisor;
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x00105D80 File Offset: 0x00103F80
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassDebugOptions.StaticStruct();
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x00105D8C File Offset: 0x00103F8C
		[NullableContext(2)]
		public FLightmassDebugOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x00105D96 File Offset: 0x00103F96
		public FLightmassDebugOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x00105DA1 File Offset: 0x00103FA1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassDebugOptions(Pointer, false, true);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x00105DAB File Offset: 0x00103FAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassDebugOptions(Pointer, MemoryOwner);
		}

		// Token: 0x0400604C RID: 24652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightmassDebugOptions";

		// Token: 0x0400604D RID: 24653
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400604E RID: 24654
		internal static int __PropertyOffset_bDebugMode;

		// Token: 0x0400604F RID: 24655
		internal static byte __PropertyMask_bDebugMode;

		// Token: 0x04006050 RID: 24656
		internal static int __PropertyOffset_bStatsEnabled;

		// Token: 0x04006051 RID: 24657
		internal static byte __PropertyMask_bStatsEnabled;

		// Token: 0x04006052 RID: 24658
		internal static int __PropertyOffset_bGatherBSPSurfacesAcrossComponents;

		// Token: 0x04006053 RID: 24659
		internal static byte __PropertyMask_bGatherBSPSurfacesAcrossComponents;

		// Token: 0x04006054 RID: 24660
		internal static int __PropertyOffset_CoplanarTolerance;

		// Token: 0x04006055 RID: 24661
		internal static int __PropertyOffset_bUseImmediateImport;

		// Token: 0x04006056 RID: 24662
		internal static byte __PropertyMask_bUseImmediateImport;

		// Token: 0x04006057 RID: 24663
		internal static int __PropertyOffset_bImmediateProcessMappings;

		// Token: 0x04006058 RID: 24664
		internal static byte __PropertyMask_bImmediateProcessMappings;

		// Token: 0x04006059 RID: 24665
		internal static int __PropertyOffset_bSortMappings;

		// Token: 0x0400605A RID: 24666
		internal static byte __PropertyMask_bSortMappings;

		// Token: 0x0400605B RID: 24667
		internal static int __PropertyOffset_bDumpBinaryFiles;

		// Token: 0x0400605C RID: 24668
		internal static byte __PropertyMask_bDumpBinaryFiles;

		// Token: 0x0400605D RID: 24669
		internal static int __PropertyOffset_bDebugMaterials;

		// Token: 0x0400605E RID: 24670
		internal static byte __PropertyMask_bDebugMaterials;

		// Token: 0x0400605F RID: 24671
		internal static int __PropertyOffset_bPadMappings;

		// Token: 0x04006060 RID: 24672
		internal static byte __PropertyMask_bPadMappings;

		// Token: 0x04006061 RID: 24673
		internal static int __PropertyOffset_bDebugPaddings;

		// Token: 0x04006062 RID: 24674
		internal static byte __PropertyMask_bDebugPaddings;

		// Token: 0x04006063 RID: 24675
		internal static int __PropertyOffset_bOnlyCalcDebugTexelMappings;

		// Token: 0x04006064 RID: 24676
		internal static byte __PropertyMask_bOnlyCalcDebugTexelMappings;

		// Token: 0x04006065 RID: 24677
		internal static int __PropertyOffset_bUseRandomColors;

		// Token: 0x04006066 RID: 24678
		internal static byte __PropertyMask_bUseRandomColors;

		// Token: 0x04006067 RID: 24679
		internal static int __PropertyOffset_bColorBordersGreen;

		// Token: 0x04006068 RID: 24680
		internal static byte __PropertyMask_bColorBordersGreen;

		// Token: 0x04006069 RID: 24681
		internal static int __PropertyOffset_bColorByExecutionTime;

		// Token: 0x0400606A RID: 24682
		internal static byte __PropertyMask_bColorByExecutionTime;

		// Token: 0x0400606B RID: 24683
		internal static int __PropertyOffset_ExecutionTimeDivisor;
	}
}
