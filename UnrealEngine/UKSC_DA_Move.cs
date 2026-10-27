using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D98 RID: 7576
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UKSC_DA_Move : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFC6 RID: 118726 RVA: 0x002AD856 File Offset: 0x002ABA56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move._ClassPtr;
		}

		// Token: 0x170074EC RID: 29932
		// (get) Token: 0x0601CFC7 RID: 118727 RVA: 0x002AD862 File Offset: 0x002ABA62
		// (set) Token: 0x0601CFC8 RID: 118728 RVA: 0x002AD876 File Offset: 0x002ABA76
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Move> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x170074ED RID: 29933
		// (get) Token: 0x0601CFC9 RID: 118729 RVA: 0x002AD88B File Offset: 0x002ABA8B
		// (set) Token: 0x0601CFCA RID: 118730 RVA: 0x002AD89B File Offset: 0x002ABA9B
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x170074EE RID: 29934
		// (get) Token: 0x0601CFCB RID: 118731 RVA: 0x002AD8AC File Offset: 0x002ABAAC
		// (set) Token: 0x0601CFCC RID: 118732 RVA: 0x002AD8BC File Offset: 0x002ABABC
		public unsafe float MoveSpeedDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_MoveSpeedDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_MoveSpeedDeviation) = value;
			}
		}

		// Token: 0x170074EF RID: 29935
		// (get) Token: 0x0601CFCD RID: 118733 RVA: 0x002AD8CD File Offset: 0x002ABACD
		// (set) Token: 0x0601CFCE RID: 118734 RVA: 0x002AD8DD File Offset: 0x002ABADD
		public unsafe float TrunRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_TrunRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_TrunRate) = value;
			}
		}

		// Token: 0x170074F0 RID: 29936
		// (get) Token: 0x0601CFCF RID: 118735 RVA: 0x002AD8EE File Offset: 0x002ABAEE
		// (set) Token: 0x0601CFD0 RID: 118736 RVA: 0x002AD8FE File Offset: 0x002ABAFE
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x170074F1 RID: 29937
		// (get) Token: 0x0601CFD1 RID: 118737 RVA: 0x002AD90F File Offset: 0x002ABB0F
		// (set) Token: 0x0601CFD2 RID: 118738 RVA: 0x002AD91F File Offset: 0x002ABB1F
		public unsafe float KnockSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockSpeed) = value;
			}
		}

		// Token: 0x170074F2 RID: 29938
		// (get) Token: 0x0601CFD3 RID: 118739 RVA: 0x002AD930 File Offset: 0x002ABB30
		// (set) Token: 0x0601CFD4 RID: 118740 RVA: 0x002AD940 File Offset: 0x002ABB40
		public unsafe float KnockInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockInterval) = value;
			}
		}

		// Token: 0x170074F3 RID: 29939
		// (get) Token: 0x0601CFD5 RID: 118741 RVA: 0x002AD951 File Offset: 0x002ABB51
		// (set) Token: 0x0601CFD6 RID: 118742 RVA: 0x002AD961 File Offset: 0x002ABB61
		public unsafe float KnockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_KnockDistance) = value;
			}
		}

		// Token: 0x170074F4 RID: 29940
		// (get) Token: 0x0601CFD7 RID: 118743 RVA: 0x002AD972 File Offset: 0x002ABB72
		// (set) Token: 0x0601CFD8 RID: 118744 RVA: 0x002AD982 File Offset: 0x002ABB82
		public unsafe bool DeadOnArrival
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_DeadOnArrival) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move.__PropertyOffset_DeadOnArrival) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CFD9 RID: 118745 RVA: 0x002AD993 File Offset: 0x002ABB93
		static UKSC_DA_Move()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move");
		}

		// Token: 0x0601CFDA RID: 118746 RVA: 0x002AD9A4 File Offset: 0x002ABBA4
		protected UKSC_DA_Move() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFDB RID: 118747 RVA: 0x002AD9CC File Offset: 0x002ABBCC
		protected UKSC_DA_Move(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBBB RID: 64443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move";

		// Token: 0x0400FBBC RID: 64444
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBBD RID: 64445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBBE RID: 64446
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FBBF RID: 64447
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x0400FBC0 RID: 64448
		internal static int __PropertyOffset_MoveSpeedDeviation;

		// Token: 0x0400FBC1 RID: 64449
		internal static int __PropertyOffset_TrunRate;

		// Token: 0x0400FBC2 RID: 64450
		internal static int __PropertyOffset_Height;

		// Token: 0x0400FBC3 RID: 64451
		internal static int __PropertyOffset_KnockSpeed;

		// Token: 0x0400FBC4 RID: 64452
		internal static int __PropertyOffset_KnockInterval;

		// Token: 0x0400FBC5 RID: 64453
		internal static int __PropertyOffset_KnockDistance;

		// Token: 0x0400FBC6 RID: 64454
		internal static int __PropertyOffset_DeadOnArrival;
	}
}
