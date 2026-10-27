using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EEC RID: 3820
	[UnrealObjectPath("/Script/Engine.NetworkPredictionInterface")]
	public interface INetworkPredictionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CF2A RID: 53034
		int InterfaceOffset();

		// Token: 0x04006FB7 RID: 28599
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NetworkPredictionInterface";
	}
}
