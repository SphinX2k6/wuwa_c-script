using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200226C RID: 8812
	[UnrealObjectPath("/Script/MagtModule.MagtAPPerfReport")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMagtAPPerfReport : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060217CE RID: 137166 RVA: 0x0031789C File Offset: 0x00315A9C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtAPPerfReport._ScriptStructPtr != 0) ? FMagtAPPerfReport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtAPPerfReport", ref FMagtAPPerfReport._ScriptStructPtr);
		}

		// Token: 0x17008232 RID: 33330
		// (get) Token: 0x060217CF RID: 137167 RVA: 0x003178C0 File Offset: 0x00315AC0
		// (set) Token: 0x060217D0 RID: 137168 RVA: 0x003178D0 File Offset: 0x00315AD0
		public unsafe int CPUStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUStatus) = value;
			}
		}

		// Token: 0x17008233 RID: 33331
		// (get) Token: 0x060217D1 RID: 137169 RVA: 0x003178E1 File Offset: 0x00315AE1
		// (set) Token: 0x060217D2 RID: 137170 RVA: 0x003178F1 File Offset: 0x00315AF1
		public unsafe int CPUPerfIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUPerfIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUPerfIndex) = value;
			}
		}

		// Token: 0x17008234 RID: 33332
		// (get) Token: 0x060217D3 RID: 137171 RVA: 0x00317902 File Offset: 0x00315B02
		// (set) Token: 0x060217D4 RID: 137172 RVA: 0x00317912 File Offset: 0x00315B12
		public unsafe int CPULoadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPULoadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPULoadIndex) = value;
			}
		}

		// Token: 0x17008235 RID: 33333
		// (get) Token: 0x060217D5 RID: 137173 RVA: 0x00317923 File Offset: 0x00315B23
		// (set) Token: 0x060217D6 RID: 137174 RVA: 0x00317933 File Offset: 0x00315B33
		public unsafe int CPUFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CPUFrameTime) = value;
			}
		}

		// Token: 0x17008236 RID: 33334
		// (get) Token: 0x060217D7 RID: 137175 RVA: 0x00317944 File Offset: 0x00315B44
		// (set) Token: 0x060217D8 RID: 137176 RVA: 0x00317954 File Offset: 0x00315B54
		public unsafe int GPUStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUStatus) = value;
			}
		}

		// Token: 0x17008237 RID: 33335
		// (get) Token: 0x060217D9 RID: 137177 RVA: 0x00317965 File Offset: 0x00315B65
		// (set) Token: 0x060217DA RID: 137178 RVA: 0x00317975 File Offset: 0x00315B75
		public unsafe int GPUPerfIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUPerfIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUPerfIndex) = value;
			}
		}

		// Token: 0x17008238 RID: 33336
		// (get) Token: 0x060217DB RID: 137179 RVA: 0x00317986 File Offset: 0x00315B86
		// (set) Token: 0x060217DC RID: 137180 RVA: 0x00317996 File Offset: 0x00315B96
		public unsafe int GPULoadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPULoadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPULoadIndex) = value;
			}
		}

		// Token: 0x17008239 RID: 33337
		// (get) Token: 0x060217DD RID: 137181 RVA: 0x003179A7 File Offset: 0x00315BA7
		// (set) Token: 0x060217DE RID: 137182 RVA: 0x003179B7 File Offset: 0x00315BB7
		public unsafe int GPUFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_GPUFrameTime) = value;
			}
		}

		// Token: 0x1700823A RID: 33338
		// (get) Token: 0x060217DF RID: 137183 RVA: 0x003179C8 File Offset: 0x00315BC8
		// (set) Token: 0x060217E0 RID: 137184 RVA: 0x003179D8 File Offset: 0x00315BD8
		public unsafe int CurrentTemperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CurrentTemperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CurrentTemperature) = value;
			}
		}

		// Token: 0x1700823B RID: 33339
		// (get) Token: 0x060217E1 RID: 137185 RVA: 0x003179E9 File Offset: 0x00315BE9
		// (set) Token: 0x060217E2 RID: 137186 RVA: 0x003179F9 File Offset: 0x00315BF9
		public unsafe int ThermalStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_ThermalStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_ThermalStatus) = value;
			}
		}

		// Token: 0x1700823C RID: 33340
		// (get) Token: 0x060217E3 RID: 137187 RVA: 0x00317A0A File Offset: 0x00315C0A
		// (set) Token: 0x060217E4 RID: 137188 RVA: 0x00317A1A File Offset: 0x00315C1A
		public unsafe int ThermalTempBudget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_ThermalTempBudget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_ThermalTempBudget) = value;
			}
		}

		// Token: 0x1700823D RID: 33341
		// (get) Token: 0x060217E5 RID: 137189 RVA: 0x00317A2B File Offset: 0x00315C2B
		// (set) Token: 0x060217E6 RID: 137190 RVA: 0x00317A3B File Offset: 0x00315C3B
		public unsafe int CurrentPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CurrentPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_CurrentPower) = value;
			}
		}

		// Token: 0x1700823E RID: 33342
		// (get) Token: 0x060217E7 RID: 137191 RVA: 0x00317A4C File Offset: 0x00315C4C
		// (set) Token: 0x060217E8 RID: 137192 RVA: 0x00317A5C File Offset: 0x00315C5C
		public unsafe int AdvisedPowerValue0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_AdvisedPowerValue0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_AdvisedPowerValue0) = value;
			}
		}

		// Token: 0x1700823F RID: 33343
		// (get) Token: 0x060217E9 RID: 137193 RVA: 0x00317A6D File Offset: 0x00315C6D
		// (set) Token: 0x060217EA RID: 137194 RVA: 0x00317A7D File Offset: 0x00315C7D
		public unsafe int AdvisedPowerValue1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_AdvisedPowerValue1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_AdvisedPowerValue1) = value;
			}
		}

		// Token: 0x17008240 RID: 33344
		// (get) Token: 0x060217EB RID: 137195 RVA: 0x00317A8E File Offset: 0x00315C8E
		// (set) Token: 0x060217EC RID: 137196 RVA: 0x00317A9E File Offset: 0x00315C9E
		public unsafe int FrameId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_FrameId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_FrameId) = value;
			}
		}

		// Token: 0x17008241 RID: 33345
		// (get) Token: 0x060217ED RID: 137197 RVA: 0x00317AAF File Offset: 0x00315CAF
		// (set) Token: 0x060217EE RID: 137198 RVA: 0x00317ABF File Offset: 0x00315CBF
		public unsafe int PlatformSupport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_PlatformSupport);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPerfReport.__PropertyOffset_PlatformSupport) = value;
			}
		}

		// Token: 0x060217EF RID: 137199 RVA: 0x00317AD0 File Offset: 0x00315CD0
		public FMagtAPPerfReport()
		{
		}

		// Token: 0x060217F0 RID: 137200 RVA: 0x00317AD8 File Offset: 0x00315CD8
		public FMagtAPPerfReport(int CPUStatus, int CPUPerfIndex, int CPULoadIndex, int CPUFrameTime, int GPUStatus, int GPUPerfIndex, int GPULoadIndex, int GPUFrameTime, int CurrentTemperature, int ThermalStatus, int ThermalTempBudget, int CurrentPower, int AdvisedPowerValue0, int AdvisedPowerValue1, int FrameId, int PlatformSupport)
		{
			this.CPUStatus = CPUStatus;
			this.CPUPerfIndex = CPUPerfIndex;
			this.CPULoadIndex = CPULoadIndex;
			this.CPUFrameTime = CPUFrameTime;
			this.GPUStatus = GPUStatus;
			this.GPUPerfIndex = GPUPerfIndex;
			this.GPULoadIndex = GPULoadIndex;
			this.GPUFrameTime = GPUFrameTime;
			this.CurrentTemperature = CurrentTemperature;
			this.ThermalStatus = ThermalStatus;
			this.ThermalTempBudget = ThermalTempBudget;
			this.CurrentPower = CurrentPower;
			this.AdvisedPowerValue0 = AdvisedPowerValue0;
			this.AdvisedPowerValue1 = AdvisedPowerValue1;
			this.FrameId = FrameId;
			this.PlatformSupport = PlatformSupport;
		}

		// Token: 0x060217F1 RID: 137201 RVA: 0x00317B68 File Offset: 0x00315D68
		protected override IntPtr GetUStructPtr()
		{
			return FMagtAPPerfReport.StaticStruct();
		}

		// Token: 0x060217F2 RID: 137202 RVA: 0x00317B74 File Offset: 0x00315D74
		[NullableContext(2)]
		public FMagtAPPerfReport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060217F3 RID: 137203 RVA: 0x00317B7E File Offset: 0x00315D7E
		public FMagtAPPerfReport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060217F4 RID: 137204 RVA: 0x00317B89 File Offset: 0x00315D89
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtAPPerfReport(Pointer, false, true);
		}

		// Token: 0x060217F5 RID: 137205 RVA: 0x00317B93 File Offset: 0x00315D93
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtAPPerfReport(Pointer, MemoryOwner);
		}

		// Token: 0x04011E11 RID: 73233
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtAPPerfReport";

		// Token: 0x04011E12 RID: 73234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E13 RID: 73235
		internal static int __PropertyOffset_CPUStatus;

		// Token: 0x04011E14 RID: 73236
		internal static int __PropertyOffset_CPUPerfIndex;

		// Token: 0x04011E15 RID: 73237
		internal static int __PropertyOffset_CPULoadIndex;

		// Token: 0x04011E16 RID: 73238
		internal static int __PropertyOffset_CPUFrameTime;

		// Token: 0x04011E17 RID: 73239
		internal static int __PropertyOffset_GPUStatus;

		// Token: 0x04011E18 RID: 73240
		internal static int __PropertyOffset_GPUPerfIndex;

		// Token: 0x04011E19 RID: 73241
		internal static int __PropertyOffset_GPULoadIndex;

		// Token: 0x04011E1A RID: 73242
		internal static int __PropertyOffset_GPUFrameTime;

		// Token: 0x04011E1B RID: 73243
		internal static int __PropertyOffset_CurrentTemperature;

		// Token: 0x04011E1C RID: 73244
		internal static int __PropertyOffset_ThermalStatus;

		// Token: 0x04011E1D RID: 73245
		internal static int __PropertyOffset_ThermalTempBudget;

		// Token: 0x04011E1E RID: 73246
		internal static int __PropertyOffset_CurrentPower;

		// Token: 0x04011E1F RID: 73247
		internal static int __PropertyOffset_AdvisedPowerValue0;

		// Token: 0x04011E20 RID: 73248
		internal static int __PropertyOffset_AdvisedPowerValue1;

		// Token: 0x04011E21 RID: 73249
		internal static int __PropertyOffset_FrameId;

		// Token: 0x04011E22 RID: 73250
		internal static int __PropertyOffset_PlatformSupport;
	}
}
