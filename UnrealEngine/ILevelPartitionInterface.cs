using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D34 RID: 3380
	[UnrealObjectPath("/Script/Engine.LevelPartitionInterface")]
	public interface ILevelPartitionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600B4F9 RID: 46329
		int InterfaceOffset();

		// Token: 0x04005F21 RID: 24353
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelPartitionInterface";
	}
}
