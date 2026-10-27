using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000111 RID: 273
	[UnrealObjectPath("/Script/AIModule.AISightTargetInterface")]
	public interface IAISightTargetInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06001436 RID: 5174
		int InterfaceOffset();

		// Token: 0x040003FB RID: 1019
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AISightTargetInterface";
	}
}
