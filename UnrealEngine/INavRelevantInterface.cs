using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EE4 RID: 3812
	[UnrealObjectPath("/Script/Engine.NavRelevantInterface")]
	public interface INavRelevantInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CE8C RID: 52876
		int InterfaceOffset();

		// Token: 0x04006F63 RID: 28515
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavRelevantInterface";
	}
}
