using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001389 RID: 5001
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectExecutionCalculation")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public abstract class UGameplayEffectExecutionCalculation : UGameplayEffectCalculation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060125BA RID: 75194 RVA: 0x001AF751 File Offset: 0x001AD951
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffectExecutionCalculation._ClassPtr;
		}

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x060125BB RID: 75195 RVA: 0x001AF75D File Offset: 0x001AD95D
		// (set) Token: 0x060125BC RID: 75196 RVA: 0x001AF76D File Offset: 0x001AD96D
		public unsafe bool bRequiresPassedInTags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffectExecutionCalculation.__PropertyOffset_bRequiresPassedInTags) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffectExecutionCalculation.__PropertyOffset_bRequiresPassedInTags) = (value ? 1 : 0);
			}
		}

		// Token: 0x060125BD RID: 75197 RVA: 0x001AF77E File Offset: 0x001AD97E
		static UGameplayEffectExecutionCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffectExecutionCalculation");
		}

		// Token: 0x060125BE RID: 75198 RVA: 0x001AF78C File Offset: 0x001AD98C
		protected UGameplayEffectExecutionCalculation() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectExecutionCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x001AF7B4 File Offset: 0x001AD9B4
		protected UGameplayEffectExecutionCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009D3E RID: 40254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectExecutionCalculation";

		// Token: 0x04009D3F RID: 40255
		private static IntPtr _ClassPtr;

		// Token: 0x04009D40 RID: 40256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009D41 RID: 40257
		internal static int __PropertyOffset_bRequiresPassedInTags;
	}
}
