using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002782 RID: 10114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ChartAggregatorSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FChartAggregatorSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025D0E RID: 154894 RVA: 0x00395584 File Offset: 0x00393784
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChartAggregatorSettings._ScriptStructPtr != 0) ? FChartAggregatorSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ChartAggregatorSettings", ref FChartAggregatorSettings._ScriptStructPtr);
		}

		// Token: 0x170091A7 RID: 37287
		// (get) Token: 0x06025D0F RID: 154895 RVA: 0x003955A8 File Offset: 0x003937A8
		// (set) Token: 0x06025D10 RID: 154896 RVA: 0x003955B8 File Offset: 0x003937B8
		public unsafe EChartAggregatorMode ChartAggregatorMode
		{
			get
			{
				return (EChartAggregatorMode)(*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_ChartAggregatorMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_ChartAggregatorMode) = (byte)value;
			}
		}

		// Token: 0x170091A8 RID: 37288
		// (get) Token: 0x06025D11 RID: 154897 RVA: 0x003955C9 File Offset: 0x003937C9
		// (set) Token: 0x06025D12 RID: 154898 RVA: 0x003955D9 File Offset: 0x003937D9
		public unsafe ESurfaceAreaScale SurfaceAreaScale
		{
			get
			{
				return (ESurfaceAreaScale)(*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SurfaceAreaScale));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SurfaceAreaScale) = (byte)value;
			}
		}

		// Token: 0x170091A9 RID: 37289
		// (get) Token: 0x06025D13 RID: 154899 RVA: 0x003955EA File Offset: 0x003937EA
		// (set) Token: 0x06025D14 RID: 154900 RVA: 0x003955FA File Offset: 0x003937FA
		public unsafe int OriginalTexCoordLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalTexCoordLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalTexCoordLevel) = value;
			}
		}

		// Token: 0x170091AA RID: 37290
		// (get) Token: 0x06025D15 RID: 154901 RVA: 0x0039560B File Offset: 0x0039380B
		// (set) Token: 0x06025D16 RID: 154902 RVA: 0x0039561F File Offset: 0x0039381F
		public unsafe string OriginalTexCoordName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalTexCoordName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalTexCoordName)), value);
			}
		}

		// Token: 0x170091AB RID: 37291
		// (get) Token: 0x06025D17 RID: 154903 RVA: 0x00395634 File Offset: 0x00393834
		// (set) Token: 0x06025D18 RID: 154904 RVA: 0x0039564D File Offset: 0x0039384D
		public unsafe bool SeparateOverlappingCharts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SeparateOverlappingCharts) & FChartAggregatorSettings.__PropertyMask_SeparateOverlappingCharts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SeparateOverlappingCharts) = ((*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SeparateOverlappingCharts) & ~FChartAggregatorSettings.__PropertyMask_SeparateOverlappingCharts) | (value ? FChartAggregatorSettings.__PropertyMask_SeparateOverlappingCharts : 0));
			}
		}

		// Token: 0x170091AC RID: 37292
		// (get) Token: 0x06025D19 RID: 154905 RVA: 0x0039567D File Offset: 0x0039387D
		// (set) Token: 0x06025D1A RID: 154906 RVA: 0x00395696 File Offset: 0x00393896
		public unsafe bool SplitMirroredCharts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SplitMirroredCharts) & FChartAggregatorSettings.__PropertyMask_SplitMirroredCharts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SplitMirroredCharts) = ((*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_SplitMirroredCharts) & ~FChartAggregatorSettings.__PropertyMask_SplitMirroredCharts) | (value ? FChartAggregatorSettings.__PropertyMask_SplitMirroredCharts : 0));
			}
		}

		// Token: 0x170091AD RID: 37293
		// (get) Token: 0x06025D1B RID: 154907 RVA: 0x003956C6 File Offset: 0x003938C6
		// (set) Token: 0x06025D1C RID: 154908 RVA: 0x003956DA File Offset: 0x003938DA
		public unsafe string OriginalChartProportionsChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalChartProportionsChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FChartAggregatorSettings.__PropertyOffset_OriginalChartProportionsChannel)), value);
			}
		}

		// Token: 0x170091AE RID: 37294
		// (get) Token: 0x06025D1D RID: 154909 RVA: 0x003956EF File Offset: 0x003938EF
		// (set) Token: 0x06025D1E RID: 154910 RVA: 0x00395708 File Offset: 0x00393908
		public unsafe bool LockUVRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_LockUVRotation) & FChartAggregatorSettings.__PropertyMask_LockUVRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_LockUVRotation) = ((*(base.NativePtr + (IntPtr)FChartAggregatorSettings.__PropertyOffset_LockUVRotation) & ~FChartAggregatorSettings.__PropertyMask_LockUVRotation) | (value ? FChartAggregatorSettings.__PropertyMask_LockUVRotation : 0));
			}
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x00395738 File Offset: 0x00393938
		public FChartAggregatorSettings()
		{
		}

		// Token: 0x06025D20 RID: 154912 RVA: 0x00395740 File Offset: 0x00393940
		public FChartAggregatorSettings(EChartAggregatorMode ChartAggregatorMode, ESurfaceAreaScale SurfaceAreaScale, int OriginalTexCoordLevel, string OriginalTexCoordName, bool SeparateOverlappingCharts, bool SplitMirroredCharts, string OriginalChartProportionsChannel, bool LockUVRotation)
		{
			this.ChartAggregatorMode = ChartAggregatorMode;
			this.SurfaceAreaScale = SurfaceAreaScale;
			this.OriginalTexCoordLevel = OriginalTexCoordLevel;
			this.OriginalTexCoordName = OriginalTexCoordName;
			this.SeparateOverlappingCharts = SeparateOverlappingCharts;
			this.SplitMirroredCharts = SplitMirroredCharts;
			this.OriginalChartProportionsChannel = OriginalChartProportionsChannel;
			this.LockUVRotation = LockUVRotation;
		}

		// Token: 0x06025D21 RID: 154913 RVA: 0x00395790 File Offset: 0x00393990
		protected override IntPtr GetUStructPtr()
		{
			return FChartAggregatorSettings.StaticStruct();
		}

		// Token: 0x06025D22 RID: 154914 RVA: 0x0039579C File Offset: 0x0039399C
		[NullableContext(2)]
		public FChartAggregatorSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x003957A6 File Offset: 0x003939A6
		public FChartAggregatorSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025D24 RID: 154916 RVA: 0x003957B1 File Offset: 0x003939B1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChartAggregatorSettings(Pointer, false, true);
		}

		// Token: 0x06025D25 RID: 154917 RVA: 0x003957BB File Offset: 0x003939BB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChartAggregatorSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401496B RID: 84331
		public const string __ObjectPath = "/Script/SimplygonUObjects.ChartAggregatorSettings";

		// Token: 0x0401496C RID: 84332
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401496D RID: 84333
		internal static int __PropertyOffset_ChartAggregatorMode;

		// Token: 0x0401496E RID: 84334
		internal static int __PropertyOffset_SurfaceAreaScale;

		// Token: 0x0401496F RID: 84335
		internal static int __PropertyOffset_OriginalTexCoordLevel;

		// Token: 0x04014970 RID: 84336
		internal static int __PropertyOffset_OriginalTexCoordName;

		// Token: 0x04014971 RID: 84337
		internal static int __PropertyOffset_SeparateOverlappingCharts;

		// Token: 0x04014972 RID: 84338
		internal static byte __PropertyMask_SeparateOverlappingCharts;

		// Token: 0x04014973 RID: 84339
		internal static int __PropertyOffset_SplitMirroredCharts;

		// Token: 0x04014974 RID: 84340
		internal static byte __PropertyMask_SplitMirroredCharts;

		// Token: 0x04014975 RID: 84341
		internal static int __PropertyOffset_OriginalChartProportionsChannel;

		// Token: 0x04014976 RID: 84342
		internal static int __PropertyOffset_LockUVRotation;

		// Token: 0x04014977 RID: 84343
		internal static byte __PropertyMask_LockUVRotation;
	}
}
