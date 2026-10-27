using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012F0 RID: 4848
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemReplicationProxyInterface")]
	public interface IAbilitySystemReplicationProxyInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06011DC1 RID: 73153
		int InterfaceOffset();

		// Token: 0x040098CC RID: 39116
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemReplicationProxyInterface";
	}
}
