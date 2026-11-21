using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EF RID: 751
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceChar")]
	[UnrealStructLayout(2784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2784)]
	public class UKuroAnimInstanceChar : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600505F RID: 20575 RVA: 0x00070FB5 File Offset: 0x0006F1B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceChar._ClassPtr;
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00070FC4 File Offset: 0x0006F1C4
		public UKuroAnimInstanceChar() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceChar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00070FEC File Offset: 0x0006F1EC
		[NullableContext(1)]
		public UKuroAnimInstanceChar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceChar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x0007101F File Offset: 0x0006F21F
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x00071033 File Offset: 0x0006F233
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

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x00071048 File Offset: 0x0006F248
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x0007105C File Offset: 0x0006F25C
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

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x00071071 File Offset: 0x0006F271
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x00071081 File Offset: 0x0006F281
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

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x00071092 File Offset: 0x0006F292
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x000710A2 File Offset: 0x0006F2A2
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

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x000710B3 File Offset: 0x0006F2B3
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x000710C3 File Offset: 0x0006F2C3
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

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x000710D4 File Offset: 0x0006F2D4
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x000710E8 File Offset: 0x0006F2E8
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

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x000710FD File Offset: 0x0006F2FD
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x0007110D File Offset: 0x0006F30D
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

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x0007111E File Offset: 0x0006F31E
		// (set) Token: 0x06005071 RID: 20593 RVA: 0x00071132 File Offset: 0x0006F332
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

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x00071147 File Offset: 0x0006F347
		// (set) Token: 0x06005073 RID: 20595 RVA: 0x0007115B File Offset: 0x0006F35B
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

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x00071170 File Offset: 0x0006F370
		// (set) Token: 0x06005075 RID: 20597 RVA: 0x00071180 File Offset: 0x0006F380
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

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x00071191 File Offset: 0x0006F391
		// (set) Token: 0x06005077 RID: 20599 RVA: 0x000711A1 File Offset: 0x0006F3A1
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

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x000711B2 File Offset: 0x0006F3B2
		// (set) Token: 0x06005079 RID: 20601 RVA: 0x000711C6 File Offset: 0x0006F3C6
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

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x000711DB File Offset: 0x0006F3DB
		// (set) Token: 0x0600507B RID: 20603 RVA: 0x000711EF File Offset: 0x0006F3EF
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

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x00071204 File Offset: 0x0006F404
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x00071214 File Offset: 0x0006F414
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

		// Token: 0x0600507E RID: 20606 RVA: 0x00071225 File Offset: 0x0006F425
		static UKuroAnimInstanceChar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceChar");
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00071233 File Offset: 0x0006F433
		protected UKuroAnimInstanceChar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002092 RID: 8338
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceChar";

		// Token: 0x04002093 RID: 8339
		private static IntPtr _ClassPtr;

		// Token: 0x04002094 RID: 8340
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002095 RID: 8341
		internal static int __PropertyOffset_LogicParams;

		// Token: 0x04002096 RID: 8342
		internal static int __PropertyOffset_BaseCharacter;

		// Token: 0x04002097 RID: 8343
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x04002098 RID: 8344
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04002099 RID: 8345
		internal static int __PropertyOffset_bIsAutonomousProxy;

		// Token: 0x0400209A RID: 8346
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400209B RID: 8347
		internal static int __PropertyOffset_bIsMovedLocation;

		// Token: 0x0400209C RID: 8348
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0400209D RID: 8349
		internal static int __PropertyOffset_ActorForward;

		// Token: 0x0400209E RID: 8350
		internal static int __PropertyOffset_OnJumpSpeed;

		// Token: 0x0400209F RID: 8351
		internal static int __PropertyOffset_bStunned;

		// Token: 0x040020A0 RID: 8352
		internal static int __PropertyOffset_LowerBodyRotator;

		// Token: 0x040020A1 RID: 8353
		internal static int __PropertyOffset_LocationProxy;

		// Token: 0x040020A2 RID: 8354
		internal static int __PropertyOffset_SightLockMode;
	}
}
