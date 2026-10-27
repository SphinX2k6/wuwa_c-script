using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172F RID: 5935
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KSC_DA_Buff_Period_KuroBullet")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UKSC_DA_Buff_Period_KuroBullet : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155CB RID: 87499 RVA: 0x001F63A8 File Offset: 0x001F45A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_KuroBullet._ClassPtr;
		}

		// Token: 0x060155CC RID: 87500 RVA: 0x001F63B4 File Offset: 0x001F45B4
		public UKSC_DA_Buff_Period_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155CD RID: 87501 RVA: 0x001F63DC File Offset: 0x001F45DC
		public UKSC_DA_Buff_Period_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x060155CE RID: 87502 RVA: 0x001F640F File Offset: 0x001F460F
		// (set) Token: 0x060155CF RID: 87503 RVA: 0x001F641F File Offset: 0x001F461F
		public unsafe long BulletId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_BulletId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_BulletId) = value;
			}
		}

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x060155D0 RID: 87504 RVA: 0x001F6430 File Offset: 0x001F4630
		// (set) Token: 0x060155D1 RID: 87505 RVA: 0x001F6440 File Offset: 0x001F4640
		public unsafe EKSC_BulletTarget Target
		{
			get
			{
				return (EKSC_BulletTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_Target));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_Target) = (byte)value;
			}
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x060155D2 RID: 87506 RVA: 0x001F6451 File Offset: 0x001F4651
		// (set) Token: 0x060155D3 RID: 87507 RVA: 0x001F6461 File Offset: 0x001F4661
		public unsafe bool NoTargetNoBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_NoTargetNoBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_NoTargetNoBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x060155D4 RID: 87508 RVA: 0x001F6472 File Offset: 0x001F4672
		// (set) Token: 0x060155D5 RID: 87509 RVA: 0x001F6482 File Offset: 0x001F4682
		public unsafe EKSC_BuffBulletInitTrans BulletInitTrans
		{
			get
			{
				return (EKSC_BuffBulletInitTrans)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_BulletInitTrans));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_BulletInitTrans) = (byte)value;
			}
		}

		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x060155D6 RID: 87510 RVA: 0x001F6494 File Offset: 0x001F4694
		// (set) Token: 0x060155D7 RID: 87511 RVA: 0x001F64CD File Offset: 0x001F46CD
		public TArray<EKSC_Faction> IgnoreFaction
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFaction) == null)
				{
					result = (this._IgnoreFaction = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_IgnoreFaction, this));
				}
				return result;
			}
			set
			{
				this.IgnoreFaction.CopyAssign(value);
			}
		}

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x060155D8 RID: 87512 RVA: 0x001F64DB File Offset: 0x001F46DB
		// (set) Token: 0x060155D9 RID: 87513 RVA: 0x001F64EB File Offset: 0x001F46EB
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x060155DA RID: 87514 RVA: 0x001F64FC File Offset: 0x001F46FC
		// (set) Token: 0x060155DB RID: 87515 RVA: 0x001F6510 File Offset: 0x001F4710
		public unsafe FTransformDouble SceneRelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_SceneRelativeTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_SceneRelativeTrans) = value;
			}
		}

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x060155DC RID: 87516 RVA: 0x001F6525 File Offset: 0x001F4725
		// (set) Token: 0x060155DD RID: 87517 RVA: 0x001F6535 File Offset: 0x001F4735
		public unsafe float RandomRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_RandomRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_KuroBullet.__PropertyOffset_RandomRadius) = value;
			}
		}

		// Token: 0x060155DE RID: 87518 RVA: 0x001F6546 File Offset: 0x001F4746
		static UKSC_DA_Buff_Period_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_DA_Buff_Period_KuroBullet");
		}

		// Token: 0x060155DF RID: 87519 RVA: 0x001F6554 File Offset: 0x001F4754
		protected UKSC_DA_Buff_Period_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA62 RID: 47714
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_DA_Buff_Period_KuroBullet";

		// Token: 0x0400BA63 RID: 47715
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA64 RID: 47716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA65 RID: 47717
		internal static int __PropertyOffset_BulletId;

		// Token: 0x0400BA66 RID: 47718
		internal static int __PropertyOffset_Target;

		// Token: 0x0400BA67 RID: 47719
		internal static int __PropertyOffset_NoTargetNoBullet;

		// Token: 0x0400BA68 RID: 47720
		internal static int __PropertyOffset_BulletInitTrans;

		// Token: 0x0400BA69 RID: 47721
		internal static int __PropertyOffset_IgnoreFaction;

		// Token: 0x0400BA6A RID: 47722
		[Nullable(2)]
		private TArray<EKSC_Faction> _IgnoreFaction;

		// Token: 0x0400BA6B RID: 47723
		internal static int __PropertyOffset_Range;

		// Token: 0x0400BA6C RID: 47724
		internal static int __PropertyOffset_SceneRelativeTrans;

		// Token: 0x0400BA6D RID: 47725
		internal static int __PropertyOffset_RandomRadius;
	}
}
