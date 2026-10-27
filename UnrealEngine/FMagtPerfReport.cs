using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002276 RID: 8822
	[UnrealObjectPath("/Script/MagtModule.MagtPerfReport")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMagtPerfReport : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602188F RID: 137359 RVA: 0x00318FE2 File Offset: 0x003171E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtPerfReport._ScriptStructPtr != 0) ? FMagtPerfReport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtPerfReport", ref FMagtPerfReport._ScriptStructPtr);
		}

		// Token: 0x1700825F RID: 33375
		// (get) Token: 0x06021890 RID: 137360 RVA: 0x00319006 File Offset: 0x00317206
		// (set) Token: 0x06021891 RID: 137361 RVA: 0x00319016 File Offset: 0x00317216
		public unsafe int CPUStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUStatus) = value;
			}
		}

		// Token: 0x17008260 RID: 33376
		// (get) Token: 0x06021892 RID: 137362 RVA: 0x00319027 File Offset: 0x00317227
		// (set) Token: 0x06021893 RID: 137363 RVA: 0x00319037 File Offset: 0x00317237
		public unsafe int GPUStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUStatus) = value;
			}
		}

		// Token: 0x17008261 RID: 33377
		// (get) Token: 0x06021894 RID: 137364 RVA: 0x00319048 File Offset: 0x00317248
		// (set) Token: 0x06021895 RID: 137365 RVA: 0x00319058 File Offset: 0x00317258
		public unsafe int CPUPerfIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUPerfIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUPerfIndex) = value;
			}
		}

		// Token: 0x17008262 RID: 33378
		// (get) Token: 0x06021896 RID: 137366 RVA: 0x00319069 File Offset: 0x00317269
		// (set) Token: 0x06021897 RID: 137367 RVA: 0x00319079 File Offset: 0x00317279
		public unsafe int CPULoadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPULoadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPULoadIndex) = value;
			}
		}

		// Token: 0x17008263 RID: 33379
		// (get) Token: 0x06021898 RID: 137368 RVA: 0x0031908A File Offset: 0x0031728A
		// (set) Token: 0x06021899 RID: 137369 RVA: 0x0031909A File Offset: 0x0031729A
		public unsafe int GPUPerfIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUPerfIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUPerfIndex) = value;
			}
		}

		// Token: 0x17008264 RID: 33380
		// (get) Token: 0x0602189A RID: 137370 RVA: 0x003190AB File Offset: 0x003172AB
		// (set) Token: 0x0602189B RID: 137371 RVA: 0x003190BB File Offset: 0x003172BB
		public unsafe int GPULoadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPULoadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPULoadIndex) = value;
			}
		}

		// Token: 0x17008265 RID: 33381
		// (get) Token: 0x0602189C RID: 137372 RVA: 0x003190CC File Offset: 0x003172CC
		// (set) Token: 0x0602189D RID: 137373 RVA: 0x003190DC File Offset: 0x003172DC
		public unsafe int ThermalStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_ThermalStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_ThermalStatus) = value;
			}
		}

		// Token: 0x17008266 RID: 33382
		// (get) Token: 0x0602189E RID: 137374 RVA: 0x003190ED File Offset: 0x003172ED
		// (set) Token: 0x0602189F RID: 137375 RVA: 0x003190FD File Offset: 0x003172FD
		public unsafe int TargetFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_TargetFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_TargetFPS) = value;
			}
		}

		// Token: 0x17008267 RID: 33383
		// (get) Token: 0x060218A0 RID: 137376 RVA: 0x0031910E File Offset: 0x0031730E
		// (set) Token: 0x060218A1 RID: 137377 RVA: 0x0031911E File Offset: 0x0031731E
		public unsafe int CPUFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_CPUFrameTime) = value;
			}
		}

		// Token: 0x17008268 RID: 33384
		// (get) Token: 0x060218A2 RID: 137378 RVA: 0x0031912F File Offset: 0x0031732F
		// (set) Token: 0x060218A3 RID: 137379 RVA: 0x0031913F File Offset: 0x0031733F
		public unsafe int GPUFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtPerfReport.__PropertyOffset_GPUFrameTime) = value;
			}
		}

		// Token: 0x060218A4 RID: 137380 RVA: 0x00319150 File Offset: 0x00317350
		public FMagtPerfReport()
		{
		}

		// Token: 0x060218A5 RID: 137381 RVA: 0x00319158 File Offset: 0x00317358
		public FMagtPerfReport(int CPUStatus, int GPUStatus, int CPUPerfIndex, int CPULoadIndex, int GPUPerfIndex, int GPULoadIndex, int ThermalStatus, int TargetFPS, int CPUFrameTime, int GPUFrameTime)
		{
			this.CPUStatus = CPUStatus;
			this.GPUStatus = GPUStatus;
			this.CPUPerfIndex = CPUPerfIndex;
			this.CPULoadIndex = CPULoadIndex;
			this.GPUPerfIndex = GPUPerfIndex;
			this.GPULoadIndex = GPULoadIndex;
			this.ThermalStatus = ThermalStatus;
			this.TargetFPS = TargetFPS;
			this.CPUFrameTime = CPUFrameTime;
			this.GPUFrameTime = GPUFrameTime;
		}

		// Token: 0x060218A6 RID: 137382 RVA: 0x003191B8 File Offset: 0x003173B8
		protected override IntPtr GetUStructPtr()
		{
			return FMagtPerfReport.StaticStruct();
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x003191C4 File Offset: 0x003173C4
		[NullableContext(2)]
		public FMagtPerfReport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x003191CE File Offset: 0x003173CE
		public FMagtPerfReport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060218A9 RID: 137385 RVA: 0x003191D9 File Offset: 0x003173D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtPerfReport(Pointer, false, true);
		}

		// Token: 0x060218AA RID: 137386 RVA: 0x003191E3 File Offset: 0x003173E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtPerfReport(Pointer, MemoryOwner);
		}

		// Token: 0x04011E7E RID: 73342
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtPerfReport";

		// Token: 0x04011E7F RID: 73343
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E80 RID: 73344
		internal static int __PropertyOffset_CPUStatus;

		// Token: 0x04011E81 RID: 73345
		internal static int __PropertyOffset_GPUStatus;

		// Token: 0x04011E82 RID: 73346
		internal static int __PropertyOffset_CPUPerfIndex;

		// Token: 0x04011E83 RID: 73347
		internal static int __PropertyOffset_CPULoadIndex;

		// Token: 0x04011E84 RID: 73348
		internal static int __PropertyOffset_GPUPerfIndex;

		// Token: 0x04011E85 RID: 73349
		internal static int __PropertyOffset_GPULoadIndex;

		// Token: 0x04011E86 RID: 73350
		internal static int __PropertyOffset_ThermalStatus;

		// Token: 0x04011E87 RID: 73351
		internal static int __PropertyOffset_TargetFPS;

		// Token: 0x04011E88 RID: 73352
		internal static int __PropertyOffset_CPUFrameTime;

		// Token: 0x04011E89 RID: 73353
		internal static int __PropertyOffset_GPUFrameTime;
	}
}
