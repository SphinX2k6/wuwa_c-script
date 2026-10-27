using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136E RID: 4974
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueNotify_HitImpact")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGameplayCueNotify_HitImpact : UGameplayCueNotify_Static, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060123F8 RID: 74744 RVA: 0x001AC918 File Offset: 0x001AAB18
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueNotify_HitImpact._ClassPtr;
		}

		// Token: 0x060123F9 RID: 74745 RVA: 0x001AC924 File Offset: 0x001AAB24
		public UGameplayCueNotify_HitImpact() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueNotify_HitImpact.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060123FA RID: 74746 RVA: 0x001AC94C File Offset: 0x001AAB4C
		[NullableContext(1)]
		public UGameplayCueNotify_HitImpact(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayCueNotify_HitImpact.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x060123FB RID: 74747 RVA: 0x001AC97F File Offset: 0x001AAB7F
		// (set) Token: 0x060123FC RID: 74748 RVA: 0x001AC993 File Offset: 0x001AAB93
		public unsafe USoundBase Sound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayCueNotify_HitImpact.__PropertyOffset_Sound);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayCueNotify_HitImpact.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x060123FD RID: 74749 RVA: 0x001AC9A8 File Offset: 0x001AABA8
		// (set) Token: 0x060123FE RID: 74750 RVA: 0x001AC9BC File Offset: 0x001AABBC
		public unsafe UParticleSystem ParticleSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayCueNotify_HitImpact.__PropertyOffset_ParticleSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayCueNotify_HitImpact.__PropertyOffset_ParticleSystem, value);
			}
		}

		// Token: 0x060123FF RID: 74751 RVA: 0x001AC9D1 File Offset: 0x001AABD1
		static UGameplayCueNotify_HitImpact()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueNotify_HitImpact");
		}

		// Token: 0x06012400 RID: 74752 RVA: 0x001AC9DF File Offset: 0x001AABDF
		protected UGameplayCueNotify_HitImpact(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C52 RID: 40018
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueNotify_HitImpact";

		// Token: 0x04009C53 RID: 40019
		private static IntPtr _ClassPtr;

		// Token: 0x04009C54 RID: 40020
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C55 RID: 40021
		internal static int __PropertyOffset_Sound;

		// Token: 0x04009C56 RID: 40022
		internal static int __PropertyOffset_ParticleSystem;
	}
}
