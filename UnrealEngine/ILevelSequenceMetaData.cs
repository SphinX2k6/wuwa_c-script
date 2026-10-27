using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FBD RID: 8125
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceMetaData")]
	public interface ILevelSequenceMetaData : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601ED5F RID: 126303
		int InterfaceOffset();

		// Token: 0x04010A9C RID: 68252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceMetaData";
	}
}
