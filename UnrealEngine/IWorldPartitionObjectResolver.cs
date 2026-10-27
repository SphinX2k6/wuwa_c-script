using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001268 RID: 4712
	[UnrealObjectPath("/Script/Engine.WorldPartitionObjectResolver")]
	public interface IWorldPartitionObjectResolver : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060114A8 RID: 70824
		int InterfaceOffset();

		// Token: 0x04009412 RID: 37906
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionObjectResolver";
	}
}
