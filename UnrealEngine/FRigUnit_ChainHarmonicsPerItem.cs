using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055F RID: 1375
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 640)]
	public class FRigUnit_ChainHarmonicsPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048EB RID: 18667 RVA: 0x0006C26C File Offset: 0x0006A46C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonicsPerItem._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonicsPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem", ref FRigUnit_ChainHarmonicsPerItem._ScriptStructPtr);
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x0006C290 File Offset: 0x0006A490
		// (set) Token: 0x060048ED RID: 18669 RVA: 0x0006C2D3 File Offset: 0x0006A4D3
		public FRigElementKey ChainRoot
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._ChainRoot) == null)
				{
					result = (this._ChainRoot = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_ChainRoot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_ChainRoot, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x0006C2F4 File Offset: 0x0006A4F4
		// (set) Token: 0x060048EF RID: 18671 RVA: 0x0006C308 File Offset: 0x0006A508
		public unsafe FVector Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x0006C320 File Offset: 0x0006A520
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x0006C363 File Offset: 0x0006A563
		public FRigUnit_ChainHarmonics_Reach Reach
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Reach result;
				if ((result = this._Reach) == null)
				{
					result = (this._Reach = new FRigUnit_ChainHarmonics_Reach(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Reach, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Reach.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Reach, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0006C384 File Offset: 0x0006A584
		// (set) Token: 0x060048F3 RID: 18675 RVA: 0x0006C3C7 File Offset: 0x0006A5C7
		public FRigUnit_ChainHarmonics_Wave Wave
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Wave result;
				if ((result = this._Wave) == null)
				{
					result = (this._Wave = new FRigUnit_ChainHarmonics_Wave(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Wave, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Wave.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Wave, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x0006C42B File Offset: 0x0006A62B
		public FRuntimeFloatCurve WaveCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._WaveCurve) == null)
				{
					result = (this._WaveCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_WaveCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_WaveCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x0006C44C File Offset: 0x0006A64C
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x0006C48F File Offset: 0x0006A68F
		public FRigUnit_ChainHarmonics_Pendulum Pendulum
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_Pendulum result;
				if ((result = this._Pendulum) == null)
				{
					result = (this._Pendulum = new FRigUnit_ChainHarmonics_Pendulum(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Pendulum, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_Pendulum.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_Pendulum, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x0006C4D1 File Offset: 0x0006A6D1
		// (set) Token: 0x060048FB RID: 18683 RVA: 0x0006C4E5 File Offset: 0x0006A6E5
		public unsafe FTransform DrawWorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_DrawWorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_DrawWorldOffset) = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x0006C4FC File Offset: 0x0006A6FC
		// (set) Token: 0x060048FD RID: 18685 RVA: 0x0006C53F File Offset: 0x0006A73F
		public FRigUnit_ChainHarmonics_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ChainHarmonics_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_ChainHarmonics_WorkData(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ChainHarmonics_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ChainHarmonicsPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x0006C560 File Offset: 0x0006A760
		public FRigUnit_ChainHarmonicsPerItem()
		{
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x0006C568 File Offset: 0x0006A768
		public FRigUnit_ChainHarmonicsPerItem(FRigElementKey ChainRoot, FVector Speed, FRigUnit_ChainHarmonics_Reach Reach, FRigUnit_ChainHarmonics_Wave Wave, FRuntimeFloatCurve WaveCurve, FRigUnit_ChainHarmonics_Pendulum Pendulum, bool bDrawDebug, FTransform DrawWorldOffset, FRigUnit_ChainHarmonics_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
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

		// Token: 0x06004900 RID: 18688 RVA: 0x0006C5C8 File Offset: 0x0006A7C8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonicsPerItem.StaticStruct();
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x0006C5D4 File Offset: 0x0006A7D4
		[NullableContext(2)]
		public FRigUnit_ChainHarmonicsPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x0006C5DE File Offset: 0x0006A7DE
		public FRigUnit_ChainHarmonicsPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0006C5E9 File Offset: 0x0006A7E9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonicsPerItem(Pointer, false, true);
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0006C5F3 File Offset: 0x0006A7F3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonicsPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002363 RID: 9059
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonicsPerItem";

		// Token: 0x04002364 RID: 9060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002365 RID: 9061
		internal static int __PropertyOffset_ChainRoot;

		// Token: 0x04002366 RID: 9062
		[Nullable(2)]
		private FRigElementKey _ChainRoot;

		// Token: 0x04002367 RID: 9063
		internal static int __PropertyOffset_Speed;

		// Token: 0x04002368 RID: 9064
		internal static int __PropertyOffset_Reach;

		// Token: 0x04002369 RID: 9065
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Reach _Reach;

		// Token: 0x0400236A RID: 9066
		internal static int __PropertyOffset_Wave;

		// Token: 0x0400236B RID: 9067
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Wave _Wave;

		// Token: 0x0400236C RID: 9068
		internal static int __PropertyOffset_WaveCurve;

		// Token: 0x0400236D RID: 9069
		[Nullable(2)]
		private FRuntimeFloatCurve _WaveCurve;

		// Token: 0x0400236E RID: 9070
		internal static int __PropertyOffset_Pendulum;

		// Token: 0x0400236F RID: 9071
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_Pendulum _Pendulum;

		// Token: 0x04002370 RID: 9072
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04002371 RID: 9073
		internal static int __PropertyOffset_DrawWorldOffset;

		// Token: 0x04002372 RID: 9074
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002373 RID: 9075
		[Nullable(2)]
		private FRigUnit_ChainHarmonics_WorkData _WorkData;
	}
}
