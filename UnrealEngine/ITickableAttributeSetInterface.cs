using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013B8 RID: 5048
	[UnrealObjectPath("/Script/GameplayAbilities.TickableAttributeSetInterface")]
	public interface ITickableAttributeSetInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601283C RID: 75836
		int InterfaceOffset();

		// Token: 0x04009E75 RID: 40565
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.TickableAttributeSetInterface";
	}
}
