using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000560 RID: 1376
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonics_Pendulum")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FRigUnit_ChainHarmonics_Pendulum : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004905 RID: 18693 RVA: 0x0006C5FC File Offset: 0x0006A7FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonics_Pendulum._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonics_Pendulum._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonics_Pendulum", ref FRigUnit_ChainHarmonics_Pendulum._ScriptStructPtr);
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x0006C620 File Offset: 0x0006A820
		// (set) Token: 0x06004907 RID: 18695 RVA: 0x0006C630 File Offset: 0x0006A830
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x0006C641 File Offset: 0x0006A841
		// (set) Token: 0x06004909 RID: 18697 RVA: 0x0006C651 File Offset: 0x0006A851
		public unsafe float PendulumStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumStiffness) = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x0006C662 File Offset: 0x0006A862
		// (set) Token: 0x0600490B RID: 18699 RVA: 0x0006C676 File Offset: 0x0006A876
		public unsafe FVector PendulumGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumGravity) = value;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x0006C68B File Offset: 0x0006A88B
		// (set) Token: 0x0600490D RID: 18701 RVA: 0x0006C69B File Offset: 0x0006A89B
		public unsafe float PendulumBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumBlend) = value;
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x0006C6AC File Offset: 0x0006A8AC
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x0006C6BC File Offset: 0x0006A8BC
		public unsafe float PendulumDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumDrag) = value;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x0006C6CD File Offset: 0x0006A8CD
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x0006C6DD File Offset: 0x0006A8DD
		public unsafe float PendulumMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumMinimum) = value;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x0006C6EE File Offset: 0x0006A8EE
		// (set) Token: 0x06004913 RID: 18707 RVA: 0x0006C6FE File Offset: 0x0006A8FE
		public unsafe float PendulumMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumMaximum) = value;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x0006C70F File Offset: 0x0006A90F
		// (set) Token: 0x06004915 RID: 18709 RVA: 0x0006C71F File Offset: 0x0006A91F
		public unsafe EControlRigAnimEasingType PendulumEase
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_PendulumEase) = (byte)value;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x0006C730 File Offset: 0x0006A930
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x0006C744 File Offset: 0x0006A944
		public unsafe FVector UnwindAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindAxis) = value;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x0006C759 File Offset: 0x0006A959
		// (set) Token: 0x06004919 RID: 18713 RVA: 0x0006C769 File Offset: 0x0006A969
		public unsafe float UnwindMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindMinimum) = value;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x0006C77A File Offset: 0x0006A97A
		// (set) Token: 0x0600491B RID: 18715 RVA: 0x0006C78A File Offset: 0x0006A98A
		public unsafe float UnwindMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Pendulum.__PropertyOffset_UnwindMaximum) = value;
			}
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x0006C79B File Offset: 0x0006A99B
		public FRigUnit_ChainHarmonics_Pendulum()
		{
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x0006C7A4 File Offset: 0x0006A9A4
		public FRigUnit_ChainHarmonics_Pendulum(bool bEnabled, float PendulumStiffness, FVector PendulumGravity, float PendulumBlend, float PendulumDrag, float PendulumMinimum, float PendulumMaximum, EControlRigAnimEasingType PendulumEase, FVector UnwindAxis, float UnwindMinimum, float UnwindMaximum)
		{
			this.bEnabled = bEnabled;
			this.PendulumStiffness = PendulumStiffness;
			this.PendulumGravity = PendulumGravity;
			this.PendulumBlend = PendulumBlend;
			this.PendulumDrag = PendulumDrag;
			this.PendulumMinimum = PendulumMinimum;
			this.PendulumMaximum = PendulumMaximum;
			this.PendulumEase = PendulumEase;
			this.UnwindAxis = UnwindAxis;
			this.UnwindMinimum = UnwindMinimum;
			this.UnwindMaximum = UnwindMaximum;
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x0006C80C File Offset: 0x0006AA0C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonics_Pendulum.StaticStruct();
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0006C818 File Offset: 0x0006AA18
		[NullableContext(2)]
		public FRigUnit_ChainHarmonics_Pendulum(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x0006C822 File Offset: 0x0006AA22
		public FRigUnit_ChainHarmonics_Pendulum(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x0006C82D File Offset: 0x0006AA2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonics_Pendulum(Pointer, false, true);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x0006C837 File Offset: 0x0006AA37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonics_Pendulum(Pointer, MemoryOwner);
		}

		// Token: 0x04002374 RID: 9076
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonics_Pendulum";

		// Token: 0x04002375 RID: 9077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002376 RID: 9078
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002377 RID: 9079
		internal static int __PropertyOffset_PendulumStiffness;

		// Token: 0x04002378 RID: 9080
		internal static int __PropertyOffset_PendulumGravity;

		// Token: 0x04002379 RID: 9081
		internal static int __PropertyOffset_PendulumBlend;

		// Token: 0x0400237A RID: 9082
		internal static int __PropertyOffset_PendulumDrag;

		// Token: 0x0400237B RID: 9083
		internal static int __PropertyOffset_PendulumMinimum;

		// Token: 0x0400237C RID: 9084
		internal static int __PropertyOffset_PendulumMaximum;

		// Token: 0x0400237D RID: 9085
		internal static int __PropertyOffset_PendulumEase;

		// Token: 0x0400237E RID: 9086
		internal static int __PropertyOffset_UnwindAxis;

		// Token: 0x0400237F RID: 9087
		internal static int __PropertyOffset_UnwindMinimum;

		// Token: 0x04002380 RID: 9088
		internal static int __PropertyOffset_UnwindMaximum;
	}
}
