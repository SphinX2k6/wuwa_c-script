using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055E RID: 1374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonics")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 640)]
	public class FRigUnit_ChainHarmonics : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048D1 RID: 18641 RVA: 0x0006BF19 File Offset: 0x0006A119
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonics._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonics", ref FRigUnit_ChainHarmonics._ScriptStructPtr);
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x0006BF3D File Offset: 0x0006A13D
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x0006BF51 File Offset: 0x0006A151
		public unsafe FName ChainRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_ChainRoot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_ChainRoot) = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x0006BF66 File Offset: 0x0006A166
		// (set) Token: 0x060048D5 RID: 18645 RVA: 0x0006BF7A File Offset: 0x0006A17A
		public unsafe FVector Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x0006BF90 File Offset: 0x0006A190
		// (set) Token: 0x060048D7 RID: 18647 RVA: 0x0006BFD3 File Offset: 0x0006A1D3
		public FRigUnit_ChainHarmonics_Reach Reach
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Reach result;
				if ((result = this._Reach) == null)
				{
					result = (this._Reach = new FRigUnit_ChainHarmonics_Reach(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Reach, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Reach.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Reach, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x0006BFF4 File Offset: 0x0006A1F4
		// (set) Token: 0x060048D9 RID: 18649 RVA: 0x0006C037 File Offset: 0x0006A237
		public FRigUnit_ChainHarmonics_Wave Wave
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Wave result;
				if ((result = this._Wave) == null)
				{
					result = (this._Wave = new FRigUnit_ChainHarmonics_Wave(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Wave, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Wave.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Wave, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x0006C058 File Offset: 0x0006A258
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x0006C09B File Offset: 0x0006A29B
		public FRuntimeFloatCurve WaveCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._WaveCurve) == null)
				{
					result = (this._WaveCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_WaveCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_WaveCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x0006C0BC File Offset: 0x0006A2BC
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x0006C0FF File Offset: 0x0006A2FF
		public FRigUnit_ChainHarmonics_Pendulum Pendulum
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Pendulum result;
				if ((result = this._Pendulum) == null)
				{
					result = (this._Pendulum = new FRigUnit_ChainHarmonics_Pendulum(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Pendulum, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Pendulum.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_Pendulum, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x0006C120 File Offset: 0x0006A320
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x0006C130 File Offset: 0x0006A330
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x0006C141 File Offset: 0x0006A341
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x0006C155 File Offset: 0x0006A355
		public unsafe FTransform DrawWorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_DrawWorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_DrawWorldOffset) = value;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x0006C16C File Offset: 0x0006A36C
		// (set) Token: 0x060048E3 RID: 18659 RVA: 0x0006C1AF File Offset: 0x0006A3AF
		public FRigUnit_ChainHarmonics_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_ChainHarmonics_WorkData(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x0006C1D0 File Offset: 0x0006A3D0
		public FRigUnit_ChainHarmonics()
		{
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x0006C1D8 File Offset: 0x0006A3D8
		public FRigUnit_ChainHarmonics(FName ChainRoot, FVector Speed, FRigUnit_ChainHarmonics_Reach Reach, FRigUnit_ChainHarmonics_Wave Wave, FRuntimeFloatCurve WaveCurve, FRigUnit_ChainHarmonics_Pendulum Pendulum, bool bDrawDebug, FTransform DrawWorldOffset, FRigUnit_ChainHarmonics_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.ChainRoot = ChainRoot;
			this.Speed = Speed;
			this.Reach = Reach;
			this.Wave = Wave;
			this.WaveCurve = WaveCurve;
			this.Pendulum = Pendulum;
			this.bDrawDebug = bDrawDebug;
			this.DrawWorldOffset = DrawWorldOffset;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x0006C238 File Offset: 0x0006A438
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonics.StaticStruct();
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x0006C244 File Offset: 0x0006A444
		[NullableContext(2)]
		public FRigUnit_ChainHarmonics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x0006C24E File Offset: 0x0006A44E
		public FRigUnit_ChainHarmonics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x0006C259 File Offset: 0x0006A459
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonics(Pointer, false, true);
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x0006C263 File Offset: 0x0006A463
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonics(Pointer, MemoryOwner);
		}

		// Token: 0x04002353 RID: 9043
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonics";

		// Token: 0x04002354 RID: 9044
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002355 RID: 9045
		internal static int __PropertyOffset_ChainRoot;

		// Token: 0x04002356 RID: 9046
		internal static int __PropertyOffset_Speed;

		// Token: 0x04002357 RID: 9047
		internal static int __PropertyOffset_Reach;

		// Token: 0x04002358 RID: 9048
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Reach _Reach;

		// Token: 0x04002359 RID: 9049
		internal static int __PropertyOffset_Wave;

		// Token: 0x0400235A RID: 9050
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Wave _Wave;

		// Token: 0x0400235B RID: 9051
		internal static int __PropertyOffset_WaveCurve;

		// Token: 0x0400235C RID: 9052
		[Nullable(2)]
		private FRuntimeFloatCurve _WaveCurve;

		// Token: 0x0400235D RID: 9053
		internal static int __PropertyOffset_Pendulum;

		// Token: 0x0400235E RID: 9054
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Pendulum _Pendulum;

		// Token: 0x0400235F RID: 9055
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04002360 RID: 9056
		internal static int __PropertyOffset_DrawWorldOffset;

		// Token: 0x04002361 RID: 9057
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002362 RID: 9058
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_WorkData _WorkData;
	}
}
