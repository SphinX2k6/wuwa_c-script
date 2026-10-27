using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001393 RID: 5011
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectUIData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UGameplayEffectUIData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601267B RID: 75387 RVA: 0x001B0DA3 File Offset: 0x001AEFA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffectUIData._ClassPtr;
		}

		// Token: 0x0601267C RID: 75388 RVA: 0x001B0DAF File Offset: 0x001AEFAF
		static UGameplayEffectUIData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffectUIData");
		}

		// Token: 0x0601267D RID: 75389 RVA: 0x001B0DC0 File Offset: 0x001AEFC0
		protected UGameplayEffectUIData() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectUIData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x001B0DE8 File Offset: 0x001AEFE8
		protected UGameplayEffectUIData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009DB2 RID: 40370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectUIData";

		// Token: 0x04009DB3 RID: 40371
		private static IntPtr _ClassPtr;

		// Token: 0x04009DB4 RID: 40372
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
