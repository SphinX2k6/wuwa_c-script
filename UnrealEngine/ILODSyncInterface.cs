using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D6A RID: 3434
	[UnrealObjectPath("/Script/Engine.LODSyncInterface")]
	public interface ILODSyncInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600B989 RID: 47497
		int InterfaceOffset();

		// Token: 0x04006138 RID: 24888
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LODSyncInterface";
	}
}
