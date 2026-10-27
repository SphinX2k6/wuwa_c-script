using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001366 RID: 4966
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbility_CharacterJump")]
	[UnrealStructLayout(960, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UGameplayAbility_CharacterJump : UGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601236F RID: 74607 RVA: 0x001ABCFE File Offset: 0x001A9EFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbility_CharacterJump._ClassPtr;
		}

		// Token: 0x06012370 RID: 74608 RVA: 0x001ABD0C File Offset: 0x001A9F0C
		public UGameplayAbility_CharacterJump() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility_CharacterJump.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012371 RID: 74609 RVA: 0x001ABD34 File Offset: 0x001A9F34
		[NullableContext(1)]
		public UGameplayAbility_CharacterJump(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility_CharacterJump.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012372 RID: 74610 RVA: 0x001ABD67 File Offset: 0x001A9F67
		static UGameplayAbility_CharacterJump()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbility_CharacterJump");
		}

		// Token: 0x06012373 RID: 74611 RVA: 0x001ABD75 File Offset: 0x001A9F75
		protected UGameplayAbility_CharacterJump(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C14 RID: 39956
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbility_CharacterJump";

		// Token: 0x04009C15 RID: 39957
		private static IntPtr _ClassPtr;

		// Token: 0x04009C16 RID: 39958
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
