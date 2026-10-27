using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012EF RID: 4847
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemInterface")]
	public interface IAbilitySystemInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06011DC0 RID: 73152
		int InterfaceOffset();

		// Token: 0x040098CB RID: 39115
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemInterface";
	}
}
