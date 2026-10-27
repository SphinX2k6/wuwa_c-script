using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF2 RID: 3826
	[UnrealObjectPath("/Script/Engine.NodeMappingProviderInterface")]
	public interface INodeMappingProviderInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CF89 RID: 53129
		int InterfaceOffset();

		// Token: 0x04006FE8 RID: 28648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NodeMappingProviderInterface";
	}
}
