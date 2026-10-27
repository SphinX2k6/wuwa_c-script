using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED6 RID: 3798
	[UnrealObjectPath("/Script/Engine.NavEdgeProviderInterface")]
	public interface INavEdgeProviderInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CDC6 RID: 52678
		int InterfaceOffset();

		// Token: 0x04006EDC RID: 28380
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavEdgeProviderInterface";
	}
}
