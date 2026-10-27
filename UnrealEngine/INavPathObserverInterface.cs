using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EE3 RID: 3811
	[UnrealObjectPath("/Script/Engine.NavPathObserverInterface")]
	public interface INavPathObserverInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CE8B RID: 52875
		int InterfaceOffset();

		// Token: 0x04006F62 RID: 28514
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavPathObserverInterface";
	}
}
