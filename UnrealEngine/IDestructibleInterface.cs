using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009B7 RID: 2487
	[UnrealObjectPath("/Script/Engine.DestructibleInterface")]
	public interface IDestructibleInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06008C92 RID: 35986
		int InterfaceOffset();

		// Token: 0x040042BB RID: 17083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DestructibleInterface";
	}
}
