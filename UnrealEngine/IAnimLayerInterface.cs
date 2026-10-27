using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200080E RID: 2062
	[UnrealObjectPath("/Script/Engine.AnimLayerInterface")]
	public interface IAnimLayerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06006EB0 RID: 28336
		int InterfaceOffset();

		// Token: 0x04003524 RID: 13604
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimLayerInterface";
	}
}
