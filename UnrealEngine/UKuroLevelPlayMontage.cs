using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019AD RID: 6573
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelPlayMontage")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroLevelPlayMontage : UKuroLevelStateAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601874D RID: 100173 RVA: 0x00240A4E File Offset: 0x0023EC4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayMontage._ClassPtr;
		}

		// Token: 0x0601874E RID: 100174 RVA: 0x00240A5C File Offset: 0x0023EC5C
		public UKuroLevelPlayMontage() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601874F RID: 100175 RVA: 0x00240A84 File Offset: 0x0023EC84
		[NullableContext(1)]
		public UKuroLevelPlayMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x06018750 RID: 100176 RVA: 0x00240AB7 File Offset: 0x0023ECB7
		// (set) Token: 0x06018751 RID: 100177 RVA: 0x00240ACB File Offset: 0x0023ECCB
		public unsafe ASkeletalMeshActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMontage.__PropertyOffset_TargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMontage.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x06018752 RID: 100178 RVA: 0x00240AE0 File Offset: 0x0023ECE0
		// (set) Token: 0x06018753 RID: 100179 RVA: 0x00240AF4 File Offset: 0x0023ECF4
		public unsafe UAnimMontage Montage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMontage.__PropertyOffset_Montage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMontage.__PropertyOffset_Montage, value);
			}
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x06018754 RID: 100180 RVA: 0x00240B09 File Offset: 0x0023ED09
		// (set) Token: 0x06018755 RID: 100181 RVA: 0x00240B19 File Offset: 0x0023ED19
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayMontage.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayMontage.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x06018756 RID: 100182 RVA: 0x00240B2A File Offset: 0x0023ED2A
		// (set) Token: 0x06018757 RID: 100183 RVA: 0x00240B3A File Offset: 0x0023ED3A
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayMontage.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayMontage.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x06018758 RID: 100184 RVA: 0x00240B4B File Offset: 0x0023ED4B
		static UKuroLevelPlayMontage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelPlayMontage");
		}

		// Token: 0x06018759 RID: 100185 RVA: 0x00240B59 File Offset: 0x0023ED59
		protected UKuroLevelPlayMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D364 RID: 54116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelPlayMontage";

		// Token: 0x0400D365 RID: 54117
		private static IntPtr _ClassPtr;

		// Token: 0x0400D366 RID: 54118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D367 RID: 54119
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0400D368 RID: 54120
		internal static int __PropertyOffset_Montage;

		// Token: 0x0400D369 RID: 54121
		internal static int __PropertyOffset_bLooping;

		// Token: 0x0400D36A RID: 54122
		internal static int __PropertyOffset_PlayRate;
	}
}
