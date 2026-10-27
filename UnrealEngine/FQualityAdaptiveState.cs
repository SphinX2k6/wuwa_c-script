using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002284 RID: 8836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.QualityAdaptiveState")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FQualityAdaptiveState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602197A RID: 137594 RVA: 0x0031B3AC File Offset: 0x003195AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualityAdaptiveState._ScriptStructPtr != 0) ? FQualityAdaptiveState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.QualityAdaptiveState", ref FQualityAdaptiveState._ScriptStructPtr);
		}

		// Token: 0x17008280 RID: 33408
		// (get) Token: 0x0602197B RID: 137595 RVA: 0x0031B3D0 File Offset: 0x003195D0
		// (set) Token: 0x0602197C RID: 137596 RVA: 0x0031B3E0 File Offset: 0x003195E0
		public unsafe EPerformJudgement QualityPolicy
		{
			get
			{
				return (EPerformJudgement)(*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_QualityPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_QualityPolicy) = (byte)value;
			}
		}

		// Token: 0x17008281 RID: 33409
		// (get) Token: 0x0602197D RID: 137597 RVA: 0x0031B3F1 File Offset: 0x003195F1
		// (set) Token: 0x0602197E RID: 137598 RVA: 0x0031B401 File Offset: 0x00319601
		public unsafe EPerformJudgement ThermalPolicy
		{
			get
			{
				return (EPerformJudgement)(*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_ThermalPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_ThermalPolicy) = (byte)value;
			}
		}

		// Token: 0x17008282 RID: 33410
		// (get) Token: 0x0602197F RID: 137599 RVA: 0x0031B412 File Offset: 0x00319612
		// (set) Token: 0x06021980 RID: 137600 RVA: 0x0031B422 File Offset: 0x00319622
		public unsafe int SettingId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_SettingId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_SettingId) = value;
			}
		}

		// Token: 0x17008283 RID: 33411
		// (get) Token: 0x06021981 RID: 137601 RVA: 0x0031B433 File Offset: 0x00319633
		// (set) Token: 0x06021982 RID: 137602 RVA: 0x0031B443 File Offset: 0x00319643
		public unsafe int QualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_QualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_QualityIndex) = value;
			}
		}

		// Token: 0x17008284 RID: 33412
		// (get) Token: 0x06021983 RID: 137603 RVA: 0x0031B454 File Offset: 0x00319654
		// (set) Token: 0x06021984 RID: 137604 RVA: 0x0031B497 File Offset: 0x00319697
		public FQualityCollectionGraph RootGraph
		{
			get
			{
				base.FastCheckIsValid();
				FQualityCollectionGraph result;
				if ((result = this._RootGraph) == null)
				{
					result = (this._RootGraph = new FQualityCollectionGraph(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_RootGraph, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualityCollectionGraph.StaticStruct(), base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_RootGraph, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008285 RID: 33413
		// (get) Token: 0x06021985 RID: 137605 RVA: 0x0031B4B8 File Offset: 0x003196B8
		// (set) Token: 0x06021986 RID: 137606 RVA: 0x0031B4C8 File Offset: 0x003196C8
		public unsafe float RunTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_RunTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_RunTime) = value;
			}
		}

		// Token: 0x17008286 RID: 33414
		// (get) Token: 0x06021987 RID: 137607 RVA: 0x0031B4D9 File Offset: 0x003196D9
		// (set) Token: 0x06021988 RID: 137608 RVA: 0x0031B4E9 File Offset: 0x003196E9
		public unsafe float CooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_CooldownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_CooldownTime) = value;
			}
		}

		// Token: 0x17008287 RID: 33415
		// (get) Token: 0x06021989 RID: 137609 RVA: 0x0031B4FA File Offset: 0x003196FA
		// (set) Token: 0x0602198A RID: 137610 RVA: 0x0031B50A File Offset: 0x0031970A
		public unsafe float NextCooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_NextCooldownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_NextCooldownTime) = value;
			}
		}

		// Token: 0x17008288 RID: 33416
		// (get) Token: 0x0602198B RID: 137611 RVA: 0x0031B51B File Offset: 0x0031971B
		// (set) Token: 0x0602198C RID: 137612 RVA: 0x0031B52B File Offset: 0x0031972B
		public unsafe int KeepPolicySteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_KeepPolicySteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_KeepPolicySteps) = value;
			}
		}

		// Token: 0x17008289 RID: 33417
		// (get) Token: 0x0602198D RID: 137613 RVA: 0x0031B53C File Offset: 0x0031973C
		// (set) Token: 0x0602198E RID: 137614 RVA: 0x0031B54C File Offset: 0x0031974C
		public unsafe int SystemAdjustAdvice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_SystemAdjustAdvice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_SystemAdjustAdvice) = value;
			}
		}

		// Token: 0x1700828A RID: 33418
		// (get) Token: 0x0602198F RID: 137615 RVA: 0x0031B55D File Offset: 0x0031975D
		// (set) Token: 0x06021990 RID: 137616 RVA: 0x0031B56D File Offset: 0x0031976D
		public unsafe int LastSystemAdjustAdvice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_LastSystemAdjustAdvice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualityAdaptiveState.__PropertyOffset_LastSystemAdjustAdvice) = value;
			}
		}

		// Token: 0x06021991 RID: 137617 RVA: 0x0031B57E File Offset: 0x0031977E
		public FQualityAdaptiveState()
		{
		}

		// Token: 0x06021992 RID: 137618 RVA: 0x0031B588 File Offset: 0x00319788
		public FQualityAdaptiveState(EPerformJudgement QualityPolicy, EPerformJudgement ThermalPolicy, int SettingId, int QualityIndex, FQualityCollectionGraph RootGraph, float RunTime, float CooldownTime, float NextCooldownTime, int KeepPolicySteps, int SystemAdjustAdvice, int LastSystemAdjustAdvice)
		{
			this.QualityPolicy = QualityPolicy;
			this.ThermalPolicy = ThermalPolicy;
			this.SettingId = SettingId;
			this.QualityIndex = QualityIndex;
			this.RootGraph = RootGraph;
			this.RunTime = RunTime;
			this.CooldownTime = CooldownTime;
			this.NextCooldownTime = NextCooldownTime;
			this.KeepPolicySteps = KeepPolicySteps;
			this.SystemAdjustAdvice = SystemAdjustAdvice;
			this.LastSystemAdjustAdvice = LastSystemAdjustAdvice;
		}

		// Token: 0x06021993 RID: 137619 RVA: 0x0031B5F0 File Offset: 0x003197F0
		protected override IntPtr GetUStructPtr()
		{
			return FQualityAdaptiveState.StaticStruct();
		}

		// Token: 0x06021994 RID: 137620 RVA: 0x0031B5FC File Offset: 0x003197FC
		[NullableContext(2)]
		public FQualityAdaptiveState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021995 RID: 137621 RVA: 0x0031B606 File Offset: 0x00319806
		public FQualityAdaptiveState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021996 RID: 137622 RVA: 0x0031B611 File Offset: 0x00319811
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualityAdaptiveState(Pointer, false, true);
		}

		// Token: 0x06021997 RID: 137623 RVA: 0x0031B61B File Offset: 0x0031981B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualityAdaptiveState(Pointer, MemoryOwner);
		}

		// Token: 0x04011EFD RID: 73469
		public const string __ObjectPath = "/Script/MagtModule.QualityAdaptiveState";

		// Token: 0x04011EFE RID: 73470
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011EFF RID: 73471
		internal static int __PropertyOffset_QualityPolicy;

		// Token: 0x04011F00 RID: 73472
		internal static int __PropertyOffset_ThermalPolicy;

		// Token: 0x04011F01 RID: 73473
		internal static int __PropertyOffset_SettingId;

		// Token: 0x04011F02 RID: 73474
		internal static int __PropertyOffset_QualityIndex;

		// Token: 0x04011F03 RID: 73475
		internal static int __PropertyOffset_RootGraph;

		// Token: 0x04011F04 RID: 73476
		[Nullable(2)]
		private FQualityCollectionGraph _RootGraph;

		// Token: 0x04011F05 RID: 73477
		internal static int __PropertyOffset_RunTime;

		// Token: 0x04011F06 RID: 73478
		internal static int __PropertyOffset_CooldownTime;

		// Token: 0x04011F07 RID: 73479
		internal static int __PropertyOffset_NextCooldownTime;

		// Token: 0x04011F08 RID: 73480
		internal static int __PropertyOffset_KeepPolicySteps;

		// Token: 0x04011F09 RID: 73481
		internal static int __PropertyOffset_SystemAdjustAdvice;

		// Token: 0x04011F0A RID: 73482
		internal static int __PropertyOffset_LastSystemAdjustAdvice;
	}
}
