using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001350 RID: 4944
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGameplayAbilityLocalAnimMontage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012228 RID: 74280 RVA: 0x001A9EEA File Offset: 0x001A80EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityLocalAnimMontage._ScriptStructPtr != 0) ? FGameplayAbilityLocalAnimMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage", ref FGameplayAbilityLocalAnimMontage._ScriptStructPtr);
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x06012229 RID: 74281 RVA: 0x001A9F0E File Offset: 0x001A810E
		// (set) Token: 0x0601222A RID: 74282 RVA: 0x001A9F22 File Offset: 0x001A8122
		public unsafe UAnimMontage AnimMontage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimMontage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimMontage, value);
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x0601222B RID: 74283 RVA: 0x001A9F37 File Offset: 0x001A8137
		// (set) Token: 0x0601222C RID: 74284 RVA: 0x001A9F47 File Offset: 0x001A8147
		public unsafe bool PlayBit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PlayBit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PlayBit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0601222D RID: 74285 RVA: 0x001A9F58 File Offset: 0x001A8158
		// (set) Token: 0x0601222E RID: 74286 RVA: 0x001A9F9B File Offset: 0x001A819B
		[Nullable(1)]
		public FPredictionKey PredictionKey
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0601222F RID: 74287 RVA: 0x001A9FBC File Offset: 0x001A81BC
		// (set) Token: 0x06012230 RID: 74288 RVA: 0x001A9FD0 File Offset: 0x001A81D0
		public unsafe UGameplayAbility AnimatingAbility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimatingAbility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimatingAbility, value);
			}
		}

		// Token: 0x06012231 RID: 74289 RVA: 0x001A9FE5 File Offset: 0x001A81E5
		public FGameplayAbilityLocalAnimMontage()
		{
		}

		// Token: 0x06012232 RID: 74290 RVA: 0x001A9FED File Offset: 0x001A81ED
		[NullableContext(1)]
		public FGameplayAbilityLocalAnimMontage(UAnimMontage AnimMontage, bool PlayBit, FPredictionKey PredictionKey, UGameplayAbility AnimatingAbility)
		{
			this.AnimMontage = AnimMontage;
			this.PlayBit = PlayBit;
			this.PredictionKey = PredictionKey;
			this.AnimatingAbility = AnimatingAbility;
		}

		// Token: 0x06012233 RID: 74291 RVA: 0x001AA012 File Offset: 0x001A8212
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityLocalAnimMontage.StaticStruct();
		}

		// Token: 0x06012234 RID: 74292 RVA: 0x001AA01E File Offset: 0x001A821E
		public FGameplayAbilityLocalAnimMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012235 RID: 74293 RVA: 0x001AA028 File Offset: 0x001A8228
		public FGameplayAbilityLocalAnimMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012236 RID: 74294 RVA: 0x001AA033 File Offset: 0x001A8233
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityLocalAnimMontage(Pointer, false, true);
		}

		// Token: 0x06012237 RID: 74295 RVA: 0x001AA03D File Offset: 0x001A823D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityLocalAnimMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04009B6B RID: 39787
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage";

		// Token: 0x04009B6C RID: 39788
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B6D RID: 39789
		internal static int __PropertyOffset_AnimMontage;

		// Token: 0x04009B6E RID: 39790
		internal static int __PropertyOffset_PlayBit;

		// Token: 0x04009B6F RID: 39791
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009B70 RID: 39792
		private FPredictionKey _PredictionKey;

		// Token: 0x04009B71 RID: 39793
		internal static int __PropertyOffset_AnimatingAbility;
	}
}
