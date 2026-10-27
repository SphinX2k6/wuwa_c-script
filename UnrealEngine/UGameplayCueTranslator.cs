using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001377 RID: 4983
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslator")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UGameplayCueTranslator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012499 RID: 74905 RVA: 0x001AD7D7 File Offset: 0x001AB9D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueTranslator._ClassPtr;
		}

		// Token: 0x0601249A RID: 74906 RVA: 0x001AD7E3 File Offset: 0x001AB9E3
		static UGameplayCueTranslator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueTranslator");
		}

		// Token: 0x0601249B RID: 74907 RVA: 0x001AD7F4 File Offset: 0x001AB9F4
		protected UGameplayCueTranslator() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueTranslator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601249C RID: 74908 RVA: 0x001AD81C File Offset: 0x001ABA1C
		protected UGameplayCueTranslator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C99 RID: 40089
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslator";

		// Token: 0x04009C9A RID: 40090
		private static IntPtr _ClassPtr;

		// Token: 0x04009C9B RID: 40091
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
