using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002283 RID: 8835
	[UnrealObjectPath("/Script/MagtModule.PerfData")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FPerfData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602195C RID: 137564 RVA: 0x0031B176 File Offset: 0x00319376
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerfData._ScriptStructPtr != 0) ? FPerfData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.PerfData", ref FPerfData._ScriptStructPtr);
		}

		// Token: 0x17008275 RID: 33397
		// (get) Token: 0x0602195D RID: 137565 RVA: 0x0031B19A File Offset: 0x0031939A
		// (set) Token: 0x0602195E RID: 137566 RVA: 0x0031B1AA File Offset: 0x003193AA
		public unsafe int CPUPerf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_CPUPerf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_CPUPerf) = value;
			}
		}

		// Token: 0x17008276 RID: 33398
		// (get) Token: 0x0602195F RID: 137567 RVA: 0x0031B1BB File Offset: 0x003193BB
		// (set) Token: 0x06021960 RID: 137568 RVA: 0x0031B1CB File Offset: 0x003193CB
		public unsafe int CPULoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_CPULoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_CPULoad) = value;
			}
		}

		// Token: 0x17008277 RID: 33399
		// (get) Token: 0x06021961 RID: 137569 RVA: 0x0031B1DC File Offset: 0x003193DC
		// (set) Token: 0x06021962 RID: 137570 RVA: 0x0031B1EC File Offset: 0x003193EC
		public unsafe int GPUPerf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_GPUPerf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_GPUPerf) = value;
			}
		}

		// Token: 0x17008278 RID: 33400
		// (get) Token: 0x06021963 RID: 137571 RVA: 0x0031B1FD File Offset: 0x003193FD
		// (set) Token: 0x06021964 RID: 137572 RVA: 0x0031B20D File Offset: 0x0031940D
		public unsafe int GPULoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_GPULoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_GPULoad) = value;
			}
		}

		// Token: 0x17008279 RID: 33401
		// (get) Token: 0x06021965 RID: 137573 RVA: 0x0031B21E File Offset: 0x0031941E
		// (set) Token: 0x06021966 RID: 137574 RVA: 0x0031B22E File Offset: 0x0031942E
		public unsafe int FPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_FPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_FPS) = value;
			}
		}

		// Token: 0x1700827A RID: 33402
		// (get) Token: 0x06021967 RID: 137575 RVA: 0x0031B23F File Offset: 0x0031943F
		// (set) Token: 0x06021968 RID: 137576 RVA: 0x0031B24F File Offset: 0x0031944F
		public unsafe int TargetFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_TargetFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_TargetFPS) = value;
			}
		}

		// Token: 0x1700827B RID: 33403
		// (get) Token: 0x06021969 RID: 137577 RVA: 0x0031B260 File Offset: 0x00319460
		// (set) Token: 0x0602196A RID: 137578 RVA: 0x0031B270 File Offset: 0x00319470
		public unsafe int Status
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Status);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Status) = value;
			}
		}

		// Token: 0x1700827C RID: 33404
		// (get) Token: 0x0602196B RID: 137579 RVA: 0x0031B281 File Offset: 0x00319481
		// (set) Token: 0x0602196C RID: 137580 RVA: 0x0031B291 File Offset: 0x00319491
		public unsafe int Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Temperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Temperature) = value;
			}
		}

		// Token: 0x1700827D RID: 33405
		// (get) Token: 0x0602196D RID: 137581 RVA: 0x0031B2A2 File Offset: 0x003194A2
		// (set) Token: 0x0602196E RID: 137582 RVA: 0x0031B2B2 File Offset: 0x003194B2
		public unsafe int Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Power);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_Power) = value;
			}
		}

		// Token: 0x1700827E RID: 33406
		// (get) Token: 0x0602196F RID: 137583 RVA: 0x0031B2C3 File Offset: 0x003194C3
		// (set) Token: 0x06021970 RID: 137584 RVA: 0x0031B2D3 File Offset: 0x003194D3
		public unsafe int ThermalStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_ThermalStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_ThermalStatus) = value;
			}
		}

		// Token: 0x1700827F RID: 33407
		// (get) Token: 0x06021971 RID: 137585 RVA: 0x0031B2E4 File Offset: 0x003194E4
		// (set) Token: 0x06021972 RID: 137586 RVA: 0x0031B2F4 File Offset: 0x003194F4
		public unsafe int ThermalBudget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_ThermalBudget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerfData.__PropertyOffset_ThermalBudget) = value;
			}
		}

		// Token: 0x06021973 RID: 137587 RVA: 0x0031B305 File Offset: 0x00319505
		public FPerfData()
		{
		}

		// Token: 0x06021974 RID: 137588 RVA: 0x0031B310 File Offset: 0x00319510
		public FPerfData(int CPUPerf, int CPULoad, int GPUPerf, int GPULoad, int FPS, int TargetFPS, int Status, int Temperature, int Power, int ThermalStatus, int ThermalBudget)
		{
			this.CPUPerf = CPUPerf;
			this.CPULoad = CPULoad;
			this.GPUPerf = GPUPerf;
			this.GPULoad = GPULoad;
			this.FPS = FPS;
			this.TargetFPS = TargetFPS;
			this.Status = Status;
			this.Temperature = Temperature;
			this.Power = Power;
			this.ThermalStatus = ThermalStatus;
			this.ThermalBudget = ThermalBudget;
		}

		// Token: 0x06021975 RID: 137589 RVA: 0x0031B378 File Offset: 0x00319578
		protected override IntPtr GetUStructPtr()
		{
			return FPerfData.StaticStruct();
		}

		// Token: 0x06021976 RID: 137590 RVA: 0x0031B384 File Offset: 0x00319584
		[NullableContext(2)]
		public FPerfData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021977 RID: 137591 RVA: 0x0031B38E File Offset: 0x0031958E
		public FPerfData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021978 RID: 137592 RVA: 0x0031B399 File Offset: 0x00319599
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerfData(Pointer, false, true);
		}

		// Token: 0x06021979 RID: 137593 RVA: 0x0031B3A3 File Offset: 0x003195A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerfData(Pointer, MemoryOwner);
		}

		// Token: 0x04011EF0 RID: 73456
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.PerfData";

		// Token: 0x04011EF1 RID: 73457
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011EF2 RID: 73458
		internal static int __PropertyOffset_CPUPerf;

		// Token: 0x04011EF3 RID: 73459
		internal static int __PropertyOffset_CPULoad;

		// Token: 0x04011EF4 RID: 73460
		internal static int __PropertyOffset_GPUPerf;

		// Token: 0x04011EF5 RID: 73461
		internal static int __PropertyOffset_GPULoad;

		// Token: 0x04011EF6 RID: 73462
		internal static int __PropertyOffset_FPS;

		// Token: 0x04011EF7 RID: 73463
		internal static int __PropertyOffset_TargetFPS;

		// Token: 0x04011EF8 RID: 73464
		internal static int __PropertyOffset_Status;

		// Token: 0x04011EF9 RID: 73465
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04011EFA RID: 73466
		internal static int __PropertyOffset_Power;

		// Token: 0x04011EFB RID: 73467
		internal static int __PropertyOffset_ThermalStatus;

		// Token: 0x04011EFC RID: 73468
		internal static int __PropertyOffset_ThermalBudget;
	}
}
