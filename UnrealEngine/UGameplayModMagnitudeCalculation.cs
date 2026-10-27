using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001399 RID: 5017
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayModMagnitudeCalculation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UGameplayModMagnitudeCalculation : UGameplayEffectCalculation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060126D4 RID: 75476 RVA: 0x001B177D File Offset: 0x001AF97D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayModMagnitudeCalculation._ClassPtr;
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x060126D5 RID: 75477 RVA: 0x001B1789 File Offset: 0x001AF989
		// (set) Token: 0x060126D6 RID: 75478 RVA: 0x001B1799 File Offset: 0x001AF999
		public unsafe bool bAllowNonNetAuthorityDependencyRegistration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayModMagnitudeCalculation.__PropertyOffset_bAllowNonNetAuthorityDependencyRegistration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayModMagnitudeCalculation.__PropertyOffset_bAllowNonNetAuthorityDependencyRegistration) = (value ? 1 : 0);
			}
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x001B17AA File Offset: 0x001AF9AA
		static UGameplayModMagnitudeCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayModMagnitudeCalculation");
		}

		// Token: 0x060126D8 RID: 75480 RVA: 0x001B17B8 File Offset: 0x001AF9B8
		protected UGameplayModMagnitudeCalculation() : this(BuiltinUtils.AllocNativeUObject(UGameplayModMagnitudeCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060126D9 RID: 75481 RVA: 0x001B17E0 File Offset: 0x001AF9E0
		protected UGameplayModMagnitudeCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009DE5 RID: 40421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayModMagnitudeCalculation";

		// Token: 0x04009DE6 RID: 40422
		private static IntPtr _ClassPtr;

		// Token: 0x04009DE7 RID: 40423
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009DE8 RID: 40424
		internal static int __PropertyOffset_bAllowNonNetAuthorityDependencyRegistration;
	}
}
