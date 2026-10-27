using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001C2 RID: 450
	[UnrealObjectPath("/Script/AIModule.EQSQueryResultSourceInterface")]
	public interface IEQSQueryResultSourceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06001AE7 RID: 6887
		int InterfaceOffset();

		// Token: 0x0400087D RID: 2173
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EQSQueryResultSourceInterface";
	}
}
