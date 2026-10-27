using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200134F RID: 4943
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityBlueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class UGameplayAbilityBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012223 RID: 74275 RVA: 0x001A9E6C File Offset: 0x001A806C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbilityBlueprint._ClassPtr;
		}

		// Token: 0x06012224 RID: 74276 RVA: 0x001A9E78 File Offset: 0x001A8078
		public UGameplayAbilityBlueprint() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbilityBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012225 RID: 74277 RVA: 0x001A9EA0 File Offset: 0x001A80A0
		[NullableContext(1)]
		public UGameplayAbilityBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbilityBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012226 RID: 74278 RVA: 0x001A9ED3 File Offset: 0x001A80D3
		static UGameplayAbilityBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityBlueprint");
		}

		// Token: 0x06012227 RID: 74279 RVA: 0x001A9EE1 File Offset: 0x001A80E1
		protected UGameplayAbilityBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009B68 RID: 39784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityBlueprint";

		// Token: 0x04009B69 RID: 39785
		private static IntPtr _ClassPtr;

		// Token: 0x04009B6A RID: 39786
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
