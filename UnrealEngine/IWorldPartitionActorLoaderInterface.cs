using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200124F RID: 4687
	[UnrealObjectPath("/Script/Engine.WorldPartitionActorLoaderInterface")]
	public interface IWorldPartitionActorLoaderInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060113F1 RID: 70641
		int InterfaceOffset();

		// Token: 0x04009399 RID: 37785
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionActorLoaderInterface";
	}
}
