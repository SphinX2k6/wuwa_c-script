using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001656 RID: 5718
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceChar")]
	[UnrealStructLayout(2768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2768)]
	public class UKuroAnimInstanceChar : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060149B4 RID: 84404 RVA: 0x001E5811 File Offset: 0x001E3A11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceChar._ClassPtr;
		}

		// Token: 0x060149B5 RID: 84405 RVA: 0x001E5820 File Offset: 0x001E3A20
		public UKuroAnimInstanceChar() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceChar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060149B6 RID: 84406 RVA: 0x001E5848 File Offset: 0x001E3A48
		[NullableContext(1)]
		public UKuroAnimInstanceChar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceChar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x060149B7 RID: 84407 RVA: 0x001E587B File Offset: 0x001E3A7B
		// (set) Token: 0x060149B8 RID: 84408 RVA: 0x001E588F File Offset: 0x001E3A8F
		public unsafe UAbpLogicParams LogicParams
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbpLogicParams>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceChar.__PropertyOffset_LogicParams);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceChar.__PropertyOffset_LogicParams, value);
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x060149B9 RID: 84409 RVA: 0x001E58A4 File Offset: 0x001E3AA4
		// (set) Token: 0x060149BA RID: 84410 RVA: 0x001E58B8 File Offset: 0x001E3AB8
		public unsafe ABaseCharacter BaseCharacter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceChar.__PropertyOffset_BaseCharacter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceChar.__PropertyOffset_BaseCharacter, value);
			}
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x060149BB RID: 84411 RVA: 0x001E58CD File Offset: 0x001E3ACD
		// (set) Token: 0x060149BC RID: 84412 RVA: 0x001E58DD File Offset: 0x001E3ADD
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_DeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_DeltaTime) = value;
			}
		}

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x060149BD RID: 84413 RVA: 0x001E58EE File Offset: 0x001E3AEE
		// (set) Token: 0x060149BE RID: 84414 RVA: 0x001E58FE File Offset: 0x001E3AFE
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x060149BF RID: 84415 RVA: 0x001E590F File Offset: 0x001E3B0F
		// (set) Token: 0x060149C0 RID: 84416 RVA: 0x001E591F File Offset: 0x001E3B1F
		public unsafe bool bIsAutonomousProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bIsAutonomousProxy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bIsAutonomousProxy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x060149C1 RID: 84417 RVA: 0x001E5930 File Offset: 0x001E3B30
		// (set) Token: 0x060149C2 RID: 84418 RVA: 0x001E5944 File Offset: 0x001E3B44
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x060149C3 RID: 84419 RVA: 0x001E5959 File Offset: 0x001E3B59
		// (set) Token: 0x060149C4 RID: 84420 RVA: 0x001E5969 File Offset: 0x001E3B69
		public unsafe bool bIsMovedLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bIsMovedLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bIsMovedLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x060149C5 RID: 84421 RVA: 0x001E597A File Offset: 0x001E3B7A
		// (set) Token: 0x060149C6 RID: 84422 RVA: 0x001E598E File Offset: 0x001E3B8E
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x060149C7 RID: 84423 RVA: 0x001E59A3 File Offset: 0x001E3BA3
		// (set) Token: 0x060149C8 RID: 84424 RVA: 0x001E59B7 File Offset: 0x001E3BB7
		public unsafe FVector ActorForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_ActorForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_ActorForward) = value;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x060149C9 RID: 84425 RVA: 0x001E59CC File Offset: 0x001E3BCC
		// (set) Token: 0x060149CA RID: 84426 RVA: 0x001E59DC File Offset: 0x001E3BDC
		public unsafe float OnJumpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_OnJumpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_OnJumpSpeed) = value;
			}
		}

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x060149CB RID: 84427 RVA: 0x001E59ED File Offset: 0x001E3BED
		// (set) Token: 0x060149CC RID: 84428 RVA: 0x001E59FD File Offset: 0x001E3BFD
		public unsafe bool bStunned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bStunned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_bStunned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x060149CD RID: 84429 RVA: 0x001E5A0E File Offset: 0x001E3C0E
		// (set) Token: 0x060149CE RID: 84430 RVA: 0x001E5A22 File Offset: 0x001E3C22
		public unsafe FRotator LowerBodyRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_LowerBodyRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_LowerBodyRotator) = value;
			}
		}

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x060149CF RID: 84431 RVA: 0x001E5A37 File Offset: 0x001E3C37
		// (set) Token: 0x060149D0 RID: 84432 RVA: 0x001E5A4B File Offset: 0x001E3C4B
		public unsafe FVectorDouble LocationProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_LocationProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_LocationProxy) = value;
			}
		}

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x060149D1 RID: 84433 RVA: 0x001E5A60 File Offset: 0x001E3C60
		// (set) Token: 0x060149D2 RID: 84434 RVA: 0x001E5A70 File Offset: 0x001E3C70
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceChar.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x060149D3 RID: 84435 RVA: 0x001E5A81 File Offset: 0x001E3C81
		static UKuroAnimInstanceChar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceChar");
		}

		// Token: 0x060149D4 RID: 84436 RVA: 0x001E5A8F File Offset: 0x001E3C8F
		protected UKuroAnimInstanceChar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3D1 RID: 46033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceChar";

		// Token: 0x0400B3D2 RID: 46034
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3D3 RID: 46035
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3D4 RID: 46036
		internal static int __PropertyOffset_LogicParams;

		// Token: 0x0400B3D5 RID: 46037
		internal static int __PropertyOffset_BaseCharacter;

		// Token: 0x0400B3D6 RID: 46038
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x0400B3D7 RID: 46039
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400B3D8 RID: 46040
		internal static int __PropertyOffset_bIsAutonomousProxy;

		// Token: 0x0400B3D9 RID: 46041
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400B3DA RID: 46042
		internal static int __PropertyOffset_bIsMovedLocation;

		// Token: 0x0400B3DB RID: 46043
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0400B3DC RID: 46044
		internal static int __PropertyOffset_ActorForward;

		// Token: 0x0400B3DD RID: 46045
		internal static int __PropertyOffset_OnJumpSpeed;

		// Token: 0x0400B3DE RID: 46046
		internal static int __PropertyOffset_bStunned;

		// Token: 0x0400B3DF RID: 46047
		internal static int __PropertyOffset_LowerBodyRotator;

		// Token: 0x0400B3E0 RID: 46048
		internal static int __PropertyOffset_LocationProxy;

		// Token: 0x0400B3E1 RID: 46049
		internal static int __PropertyOffset_SightLockMode;
	}
}
