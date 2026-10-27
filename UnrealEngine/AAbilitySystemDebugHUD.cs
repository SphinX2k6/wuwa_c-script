using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012ED RID: 4845
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemDebugHUD")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class AAbilitySystemDebugHUD : AHUD, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011D6A RID: 73066 RVA: 0x001A2AA7 File Offset: 0x001A0CA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAbilitySystemDebugHUD._ClassPtr;
		}

		// Token: 0x06011D6B RID: 73067 RVA: 0x001A2AB4 File Offset: 0x001A0CB4
		public AAbilitySystemDebugHUD() : this(BuiltinUtils.AllocNativeUObject(AAbilitySystemDebugHUD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011D6C RID: 73068 RVA: 0x001A2ADC File Offset: 0x001A0CDC
		[NullableContext(1)]
		public AAbilitySystemDebugHUD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAbilitySystemDebugHUD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011D6D RID: 73069 RVA: 0x001A2B0F File Offset: 0x001A0D0F
		static AAbilitySystemDebugHUD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemDebugHUD");
		}

		// Token: 0x06011D6E RID: 73070 RVA: 0x001A2B1D File Offset: 0x001A0D1D
		protected AAbilitySystemDebugHUD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009899 RID: 39065
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemDebugHUD";

		// Token: 0x0400989A RID: 39066
		private static IntPtr _ClassPtr;

		// Token: 0x0400989B RID: 39067
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
