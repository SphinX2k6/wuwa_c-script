using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001254 RID: 4692
	[UnrealObjectPath("/Script/Engine.WorldPartitionCell")]
	public interface IWorldPartitionCell : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06011417 RID: 70679
		int InterfaceOffset();

		// Token: 0x040093B4 RID: 37812
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionCell";
	}
}
