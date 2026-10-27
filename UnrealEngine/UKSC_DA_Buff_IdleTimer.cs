using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D60 RID: 7520
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_IdleTimer")]
	[UnrealStructLayout(784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 784)]
	public class UKSC_DA_Buff_IdleTimer : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCE1 RID: 117985 RVA: 0x002A9389 File Offset: 0x002A7589
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_IdleTimer._ClassPtr;
		}

		// Token: 0x0601CCE2 RID: 117986 RVA: 0x002A9398 File Offset: 0x002A7598
		public UKSC_DA_Buff_IdleTimer() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_IdleTimer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCE3 RID: 117987 RVA: 0x002A93C0 File Offset: 0x002A75C0
		public UKSC_DA_Buff_IdleTimer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_IdleTimer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007404 RID: 29700
		// (get) Token: 0x0601CCE4 RID: 117988 RVA: 0x002A93F3 File Offset: 0x002A75F3
		// (set) Token: 0x0601CCE5 RID: 117989 RVA: 0x002A9403 File Offset: 0x002A7603
		public unsafe float IdleTimeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_IdleTimeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_IdleTimeThreshold) = value;
			}
		}

		// Token: 0x17007405 RID: 29701
		// (get) Token: 0x0601CCE6 RID: 117990 RVA: 0x002A9414 File Offset: 0x002A7614
		// (set) Token: 0x0601CCE7 RID: 117991 RVA: 0x002A9424 File Offset: 0x002A7624
		public unsafe EKSC_Buff_IdleTimer_CheckType CheckType
		{
			get
			{
				return (EKSC_Buff_IdleTimer_CheckType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_CheckType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_CheckType) = (byte)value;
			}
		}

		// Token: 0x17007406 RID: 29702
		// (get) Token: 0x0601CCE8 RID: 117992 RVA: 0x002A9435 File Offset: 0x002A7635
		// (set) Token: 0x0601CCE9 RID: 117993 RVA: 0x002A9445 File Offset: 0x002A7645
		public unsafe float MovementThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_MovementThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_MovementThreshold) = value;
			}
		}

		// Token: 0x17007407 RID: 29703
		// (get) Token: 0x0601CCEA RID: 117994 RVA: 0x002A9456 File Offset: 0x002A7656
		// (set) Token: 0x0601CCEB RID: 117995 RVA: 0x002A9466 File Offset: 0x002A7666
		public unsafe float RotationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_RotationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_RotationThreshold) = value;
			}
		}

		// Token: 0x17007408 RID: 29704
		// (get) Token: 0x0601CCEC RID: 117996 RVA: 0x002A9477 File Offset: 0x002A7677
		// (set) Token: 0x0601CCED RID: 117997 RVA: 0x002A9487 File Offset: 0x002A7687
		public unsafe float TriggerCoolDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_TriggerCoolDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_TriggerCoolDown) = value;
			}
		}

		// Token: 0x17007409 RID: 29705
		// (get) Token: 0x0601CCEE RID: 117998 RVA: 0x002A9498 File Offset: 0x002A7698
		// (set) Token: 0x0601CCEF RID: 117999 RVA: 0x002A94A8 File Offset: 0x002A76A8
		public unsafe int MaxTriggerCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_MaxTriggerCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_MaxTriggerCount) = value;
			}
		}

		// Token: 0x1700740A RID: 29706
		// (get) Token: 0x0601CCF0 RID: 118000 RVA: 0x002A94BC File Offset: 0x002A76BC
		// (set) Token: 0x0601CCF1 RID: 118001 RVA: 0x002A94F5 File Offset: 0x002A76F5
		public FKuroResponseConfig IdleTriggerConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroResponseConfig result;
				if ((result = this._IdleTriggerConfig) == null)
				{
					result = (this._IdleTriggerConfig = new FKuroResponseConfig(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_IdleTriggerConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroResponseConfig.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_IdleTriggerConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700740B RID: 29707
		// (get) Token: 0x0601CCF2 RID: 118002 RVA: 0x002A9518 File Offset: 0x002A7718
		// (set) Token: 0x0601CCF3 RID: 118003 RVA: 0x002A9551 File Offset: 0x002A7751
		public FKuroResponseConfig BreakIdleTriggerConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroResponseConfig result;
				if ((result = this._BreakIdleTriggerConfig) == null)
				{
					result = (this._BreakIdleTriggerConfig = new FKuroResponseConfig(base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_BreakIdleTriggerConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroResponseConfig.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_IdleTimer.__PropertyOffset_BreakIdleTriggerConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CCF4 RID: 118004 RVA: 0x002A9572 File Offset: 0x002A7772
		static UKSC_DA_Buff_IdleTimer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_IdleTimer");
		}

		// Token: 0x0601CCF5 RID: 118005 RVA: 0x002A9580 File Offset: 0x002A7780
		protected UKSC_DA_Buff_IdleTimer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9F5 RID: 63989
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_IdleTimer";

		// Token: 0x0400F9F6 RID: 63990
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9F7 RID: 63991
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9F8 RID: 63992
		internal static int __PropertyOffset_IdleTimeThreshold;

		// Token: 0x0400F9F9 RID: 63993
		internal static int __PropertyOffset_CheckType;

		// Token: 0x0400F9FA RID: 63994
		internal static int __PropertyOffset_MovementThreshold;

		// Token: 0x0400F9FB RID: 63995
		internal static int __PropertyOffset_RotationThreshold;

		// Token: 0x0400F9FC RID: 63996
		internal static int __PropertyOffset_TriggerCoolDown;

		// Token: 0x0400F9FD RID: 63997
		internal static int __PropertyOffset_MaxTriggerCount;

		// Token: 0x0400F9FE RID: 63998
		internal static int __PropertyOffset_IdleTriggerConfig;

		// Token: 0x0400F9FF RID: 63999
		[Nullable(2)]
		private FKuroResponseConfig _IdleTriggerConfig;

		// Token: 0x0400FA00 RID: 64000
		internal static int __PropertyOffset_BreakIdleTriggerConfig;

		// Token: 0x0400FA01 RID: 64001
		[Nullable(2)]
		private FKuroResponseConfig _BreakIdleTriggerConfig;
	}
}
