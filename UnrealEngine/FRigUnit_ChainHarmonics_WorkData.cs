using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000563 RID: 1379
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonics_WorkData")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_ChainHarmonics_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600494F RID: 18767 RVA: 0x0006CB84 File Offset: 0x0006AD84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonics_WorkData._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonics_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonics_WorkData", ref FRigUnit_ChainHarmonics_WorkData._ScriptStructPtr);
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		// (set) Token: 0x06004951 RID: 18769 RVA: 0x0006CBBC File Offset: 0x0006ADBC
		public unsafe FVector Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x0006CBD4 File Offset: 0x0006ADD4
		// (set) Token: 0x06004953 RID: 18771 RVA: 0x0006CC17 File Offset: 0x0006AE17
		public TArray<FCachedRigElement> Items
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x0006CC28 File Offset: 0x0006AE28
		// (set) Token: 0x06004955 RID: 18773 RVA: 0x0006CC6B File Offset: 0x0006AE6B
		public TArray<float> Ratio
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Ratio) == null)
				{
					result = (this._Ratio = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_Ratio, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Ratio.CopyAssign(value);
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x0006CC7C File Offset: 0x0006AE7C
		// (set) Token: 0x06004957 RID: 18775 RVA: 0x0006CCBF File Offset: 0x0006AEBF
		public TArray<FVector> LocalTip
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._LocalTip) == null)
				{
					result = (this._LocalTip = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_LocalTip, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalTip.CopyAssign(value);
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x0006CCD0 File Offset: 0x0006AED0
		// (set) Token: 0x06004959 RID: 18777 RVA: 0x0006CD13 File Offset: 0x0006AF13
		public TArray<FVector> PendulumTip
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PendulumTip) == null)
				{
					result = (this._PendulumTip = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_PendulumTip, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PendulumTip.CopyAssign(value);
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x0006CD24 File Offset: 0x0006AF24
		// (set) Token: 0x0600495B RID: 18779 RVA: 0x0006CD67 File Offset: 0x0006AF67
		public TArray<FVector> PendulumPosition
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PendulumPosition) == null)
				{
					result = (this._PendulumPosition = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_PendulumPosition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PendulumPosition.CopyAssign(value);
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x0006CD78 File Offset: 0x0006AF78
		// (set) Token: 0x0600495D RID: 18781 RVA: 0x0006CDBB File Offset: 0x0006AFBB
		public TArray<FVector> PendulumVelocity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PendulumVelocity) == null)
				{
					result = (this._PendulumVelocity = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_PendulumVelocity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PendulumVelocity.CopyAssign(value);
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x0006CDCC File Offset: 0x0006AFCC
		// (set) Token: 0x0600495F RID: 18783 RVA: 0x0006CE0F File Offset: 0x0006B00F
		public TArray<FVector> HierarchyLine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._HierarchyLine) == null)
				{
					result = (this._HierarchyLine = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_HierarchyLine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HierarchyLine.CopyAssign(value);
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x0006CE20 File Offset: 0x0006B020
		// (set) Token: 0x06004961 RID: 18785 RVA: 0x0006CE63 File Offset: 0x0006B063
		public TArray<FVector> VelocityLines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VelocityLines) == null)
				{
					result = (this._VelocityLines = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_WorkData.__PropertyOffset_VelocityLines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VelocityLines.CopyAssign(value);
			}
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x0006CE71 File Offset: 0x0006B071
		public FRigUnit_ChainHarmonics_WorkData()
		{
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x0006CE7C File Offset: 0x0006B07C
		public FRigUnit_ChainHarmonics_WorkData(FVector Time, TArray<FCachedRigElement> Items, TArray<float> Ratio, TArray<FVector> LocalTip, TArray<FVector> PendulumTip, TArray<FVector> PendulumPosition, TArray<FVector> PendulumVelocity, TArray<FVector> HierarchyLine, TArray<FVector> VelocityLines)
		{
			this.Time = Time;
			this.Items = Items;
			this.Ratio = Ratio;
			this.LocalTip = LocalTip;
			this.PendulumTip = PendulumTip;
			this.PendulumPosition = PendulumPosition;
			this.PendulumVelocity = PendulumVelocity;
			this.HierarchyLine = HierarchyLine;
			this.VelocityLines = VelocityLines;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x0006CED4 File Offset: 0x0006B0D4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonics_WorkData.StaticStruct();
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
		[NullableContext(2)]
		public FRigUnit_ChainHarmonics_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x0006CEEA File Offset: 0x0006B0EA
		public FRigUnit_ChainHarmonics_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x0006CEF5 File Offset: 0x0006B0F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonics_WorkData(Pointer, false, true);
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x0006CEFF File Offset: 0x0006B0FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonics_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002393 RID: 9107
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonics_WorkData";

		// Token: 0x04002394 RID: 9108
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002395 RID: 9109
		internal static int __PropertyOffset_Time;

		// Token: 0x04002396 RID: 9110
		internal static int __PropertyOffset_Items;

		// Token: 0x04002397 RID: 9111
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _Items;

		// Token: 0x04002398 RID: 9112
		internal static int __PropertyOffset_Ratio;

		// Token: 0x04002399 RID: 9113
		[Nullable(2)]
		private TArray<float> _Ratio;

		// Token: 0x0400239A RID: 9114
		internal static int __PropertyOffset_LocalTip;

		// Token: 0x0400239B RID: 9115
		[Nullable(2)]
		private TArray<FVector> _LocalTip;

		// Token: 0x0400239C RID: 9116
		internal static int __PropertyOffset_PendulumTip;

		// Token: 0x0400239D RID: 9117
		[Nullable(2)]
		private TArray<FVector> _PendulumTip;

		// Token: 0x0400239E RID: 9118
		internal static int __PropertyOffset_PendulumPosition;

		// Token: 0x0400239F RID: 9119
		[Nullable(2)]
		private TArray<FVector> _PendulumPosition;

		// Token: 0x040023A0 RID: 9120
		internal static int __PropertyOffset_PendulumVelocity;

		// Token: 0x040023A1 RID: 9121
		[Nullable(2)]
		private TArray<FVector> _PendulumVelocity;

		// Token: 0x040023A2 RID: 9122
		internal static int __PropertyOffset_HierarchyLine;

		// Token: 0x040023A3 RID: 9123
		[Nullable(2)]
		private TArray<FVector> _HierarchyLine;

		// Token: 0x040023A4 RID: 9124
		internal static int __PropertyOffset_VelocityLines;

		// Token: 0x040023A5 RID: 9125
		[Nullable(2)]
		private TArray<FVector> _VelocityLines;
	}
}
