using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001382 RID: 4994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectCalculation")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UGameplayEffectCalculation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012560 RID: 75104 RVA: 0x001AEF01 File Offset: 0x001AD101
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffectCalculation._ClassPtr;
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x06012561 RID: 75105 RVA: 0x001AEF10 File Offset: 0x001AD110
		// (set) Token: 0x06012562 RID: 75106 RVA: 0x001AEF49 File Offset: 0x001AD149
		public TArray<FGameplayEffectAttributeCaptureDefinition> RelevantAttributesToCapture
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectAttributeCaptureDefinition> result;
				if ((result = this._RelevantAttributesToCapture) == null)
				{
					result = (this._RelevantAttributesToCapture = new TArray<FGameplayEffectAttributeCaptureDefinition>(base.NativePtr + (IntPtr)UGameplayEffectCalculation.__PropertyOffset_RelevantAttributesToCapture, this));
				}
				return result;
			}
			set
			{
				this.RelevantAttributesToCapture.CopyAssign(value);
			}
		}

		// Token: 0x06012563 RID: 75107 RVA: 0x001AEF57 File Offset: 0x001AD157
		static UGameplayEffectCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffectCalculation");
		}

		// Token: 0x06012564 RID: 75108 RVA: 0x001AEF68 File Offset: 0x001AD168
		protected UGameplayEffectCalculation() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012565 RID: 75109 RVA: 0x001AEF90 File Offset: 0x001AD190
		protected UGameplayEffectCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009D10 RID: 40208
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectCalculation";

		// Token: 0x04009D11 RID: 40209
		private static IntPtr _ClassPtr;

		// Token: 0x04009D12 RID: 40210
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009D13 RID: 40211
		internal static int __PropertyOffset_RelevantAttributesToCapture;

		// Token: 0x04009D14 RID: 40212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectAttributeCaptureDefinition> _RelevantAttributesToCapture;
	}
}
