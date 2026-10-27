using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002273 RID: 8819
	[UnrealObjectPath("/Script/MagtModule.MagtCpuMipsData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMagtCpuMipsData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602184B RID: 137291 RVA: 0x00318391 File Offset: 0x00316591
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtCpuMipsData._ScriptStructPtr != 0) ? FMagtCpuMipsData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtCpuMipsData", ref FMagtCpuMipsData._ScriptStructPtr);
		}

		// Token: 0x17008254 RID: 33364
		// (get) Token: 0x0602184C RID: 137292 RVA: 0x003183B5 File Offset: 0x003165B5
		// (set) Token: 0x0602184D RID: 137293 RVA: 0x003183C5 File Offset: 0x003165C5
		public unsafe int CpuId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CpuId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CpuId) = value;
			}
		}

		// Token: 0x17008255 RID: 33365
		// (get) Token: 0x0602184E RID: 137294 RVA: 0x003183D6 File Offset: 0x003165D6
		// (set) Token: 0x0602184F RID: 137295 RVA: 0x003183E6 File Offset: 0x003165E6
		public unsafe float CurrentMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentMips) = value;
			}
		}

		// Token: 0x17008256 RID: 33366
		// (get) Token: 0x06021850 RID: 137296 RVA: 0x003183F7 File Offset: 0x003165F7
		// (set) Token: 0x06021851 RID: 137297 RVA: 0x00318407 File Offset: 0x00316607
		public unsafe float CurrentMcps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentMcps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentMcps) = value;
			}
		}

		// Token: 0x17008257 RID: 33367
		// (get) Token: 0x06021852 RID: 137298 RVA: 0x00318418 File Offset: 0x00316618
		// (set) Token: 0x06021853 RID: 137299 RVA: 0x00318428 File Offset: 0x00316628
		public unsafe float CurrentCpi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentCpi);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CurrentCpi) = value;
			}
		}

		// Token: 0x17008258 RID: 33368
		// (get) Token: 0x06021854 RID: 137300 RVA: 0x00318439 File Offset: 0x00316639
		// (set) Token: 0x06021855 RID: 137301 RVA: 0x00318449 File Offset: 0x00316649
		public unsafe long InstructionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_InstructionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_InstructionCount) = value;
			}
		}

		// Token: 0x17008259 RID: 33369
		// (get) Token: 0x06021856 RID: 137302 RVA: 0x0031845A File Offset: 0x0031665A
		// (set) Token: 0x06021857 RID: 137303 RVA: 0x0031846A File Offset: 0x0031666A
		public unsafe long CycleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CycleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_CycleCount) = value;
			}
		}

		// Token: 0x1700825A RID: 33370
		// (get) Token: 0x06021858 RID: 137304 RVA: 0x0031847B File Offset: 0x0031667B
		// (set) Token: 0x06021859 RID: 137305 RVA: 0x0031848B File Offset: 0x0031668B
		public unsafe long TimeRunningNs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_TimeRunningNs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_TimeRunningNs) = value;
			}
		}

		// Token: 0x1700825B RID: 33371
		// (get) Token: 0x0602185A RID: 137306 RVA: 0x0031849C File Offset: 0x0031669C
		// (set) Token: 0x0602185B RID: 137307 RVA: 0x003184AC File Offset: 0x003166AC
		public unsafe long TimeEnabledNs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_TimeEnabledNs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_TimeEnabledNs) = value;
			}
		}

		// Token: 0x1700825C RID: 33372
		// (get) Token: 0x0602185C RID: 137308 RVA: 0x003184BD File Offset: 0x003166BD
		// (set) Token: 0x0602185D RID: 137309 RVA: 0x003184CD File Offset: 0x003166CD
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuMipsData.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602185E RID: 137310 RVA: 0x003184DE File Offset: 0x003166DE
		public FMagtCpuMipsData()
		{
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x003184E8 File Offset: 0x003166E8
		public FMagtCpuMipsData(int CpuId, float CurrentMips, float CurrentMcps, float CurrentCpi, long InstructionCount, long CycleCount, long TimeRunningNs, long TimeEnabledNs, bool bIsValid)
		{
			this.CpuId = CpuId;
			this.CurrentMips = CurrentMips;
			this.CurrentMcps = CurrentMcps;
			this.CurrentCpi = CurrentCpi;
			this.InstructionCount = InstructionCount;
			this.CycleCount = CycleCount;
			this.TimeRunningNs = TimeRunningNs;
			this.TimeEnabledNs = TimeEnabledNs;
			this.bIsValid = bIsValid;
		}

		// Token: 0x06021860 RID: 137312 RVA: 0x00318540 File Offset: 0x00316740
		protected override IntPtr GetUStructPtr()
		{
			return FMagtCpuMipsData.StaticStruct();
		}

		// Token: 0x06021861 RID: 137313 RVA: 0x0031854C File Offset: 0x0031674C
		[NullableContext(2)]
		public FMagtCpuMipsData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021862 RID: 137314 RVA: 0x00318556 File Offset: 0x00316756
		public FMagtCpuMipsData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021863 RID: 137315 RVA: 0x00318561 File Offset: 0x00316761
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtCpuMipsData(Pointer, false, true);
		}

		// Token: 0x06021864 RID: 137316 RVA: 0x0031856B File Offset: 0x0031676B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtCpuMipsData(Pointer, MemoryOwner);
		}

		// Token: 0x04011E4D RID: 73293
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtCpuMipsData";

		// Token: 0x04011E4E RID: 73294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E4F RID: 73295
		internal static int __PropertyOffset_CpuId;

		// Token: 0x04011E50 RID: 73296
		internal static int __PropertyOffset_CurrentMips;

		// Token: 0x04011E51 RID: 73297
		internal static int __PropertyOffset_CurrentMcps;

		// Token: 0x04011E52 RID: 73298
		internal static int __PropertyOffset_CurrentCpi;

		// Token: 0x04011E53 RID: 73299
		internal static int __PropertyOffset_InstructionCount;

		// Token: 0x04011E54 RID: 73300
		internal static int __PropertyOffset_CycleCount;

		// Token: 0x04011E55 RID: 73301
		internal static int __PropertyOffset_TimeRunningNs;

		// Token: 0x04011E56 RID: 73302
		internal static int __PropertyOffset_TimeEnabledNs;

		// Token: 0x04011E57 RID: 73303
		internal static int __PropertyOffset_bIsValid;
	}
}
