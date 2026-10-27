using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200125D RID: 4701
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODProvider")]
	public interface IWorldPartitionHLODProvider : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06011442 RID: 70722
		int InterfaceOffset();

		// Token: 0x040093CF RID: 37839
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionHLODProvider";
	}
}
