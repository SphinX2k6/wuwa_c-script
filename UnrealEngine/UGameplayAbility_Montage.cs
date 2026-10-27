using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001367 RID: 4967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbility_Montage")]
	[UnrealStructLayout(1016, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1016)]
	public class UGameplayAbility_Montage : UGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012374 RID: 74612 RVA: 0x001ABD7E File Offset: 0x001A9F7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbility_Montage._ClassPtr;
		}

		// Token: 0x06012375 RID: 74613 RVA: 0x001ABD8C File Offset: 0x001A9F8C
		public UGameplayAbility_Montage() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility_Montage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012376 RID: 74614 RVA: 0x001ABDB4 File Offset: 0x001A9FB4
		public UGameplayAbility_Montage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility_Montage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x06012377 RID: 74615 RVA: 0x001ABDE7 File Offset: 0x001A9FE7
		// (set) Token: 0x06012378 RID: 74616 RVA: 0x001ABDFB File Offset: 0x001A9FFB
		[Nullable(2)]
		public unsafe UAnimMontage MontageToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayAbility_Montage.__PropertyOffset_MontageToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayAbility_Montage.__PropertyOffset_MontageToPlay, value);
			}
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x06012379 RID: 74617 RVA: 0x001ABE10 File Offset: 0x001AA010
		// (set) Token: 0x0601237A RID: 74618 RVA: 0x001ABE20 File Offset: 0x001AA020
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x0601237B RID: 74619 RVA: 0x001ABE31 File Offset: 0x001AA031
		// (set) Token: 0x0601237C RID: 74620 RVA: 0x001ABE45 File Offset: 0x001AA045
		public unsafe FName SectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_SectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_SectionName) = value;
			}
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x0601237D RID: 74621 RVA: 0x001ABE5C File Offset: 0x001AA05C
		// (set) Token: 0x0601237E RID: 74622 RVA: 0x001ABE95 File Offset: 0x001AA095
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> GameplayEffectClassesWhileAnimating
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._GameplayEffectClassesWhileAnimating) == null)
				{
					result = (this._GameplayEffectClassesWhileAnimating = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_GameplayEffectClassesWhileAnimating, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.GameplayEffectClassesWhileAnimating.CopyAssign(value);
			}
		}

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x0601237F RID: 74623 RVA: 0x001ABEA4 File Offset: 0x001AA0A4
		// (set) Token: 0x06012380 RID: 74624 RVA: 0x001ABEDD File Offset: 0x001AA0DD
		public TArray<UGameplayEffect> GameplayEffectsWhileAnimating
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayEffect> result;
				if ((result = this._GameplayEffectsWhileAnimating) == null)
				{
					result = (this._GameplayEffectsWhileAnimating = new TArray<UGameplayEffect>(base.NativePtr + (IntPtr)UGameplayAbility_Montage.__PropertyOffset_GameplayEffectsWhileAnimating, this));
				}
				return result;
			}
			set
			{
				this.GameplayEffectsWhileAnimating.CopyAssign(value);
			}
		}

		// Token: 0x06012381 RID: 74625 RVA: 0x001ABEEB File Offset: 0x001AA0EB
		static UGameplayAbility_Montage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbility_Montage");
		}

		// Token: 0x06012382 RID: 74626 RVA: 0x001ABEF9 File Offset: 0x001AA0F9
		protected UGameplayAbility_Montage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C17 RID: 39959
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbility_Montage";

		// Token: 0x04009C18 RID: 39960
		private static IntPtr _ClassPtr;

		// Token: 0x04009C19 RID: 39961
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C1A RID: 39962
		internal static int __PropertyOffset_MontageToPlay;

		// Token: 0x04009C1B RID: 39963
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04009C1C RID: 39964
		internal static int __PropertyOffset_SectionName;

		// Token: 0x04009C1D RID: 39965
		internal static int __PropertyOffset_GameplayEffectClassesWhileAnimating;

		// Token: 0x04009C1E RID: 39966
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _GameplayEffectClassesWhileAnimating;

		// Token: 0x04009C1F RID: 39967
		internal static int __PropertyOffset_GameplayEffectsWhileAnimating;

		// Token: 0x04009C20 RID: 39968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayEffect> _GameplayEffectsWhileAnimating;
	}
}
