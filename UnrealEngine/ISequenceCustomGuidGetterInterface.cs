using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FC5 RID: 8133
	[UnrealObjectPath("/Script/LevelSequence.SequenceCustomGuidGetterInterface")]
	public interface ISequenceCustomGuidGetterInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601EDC6 RID: 126406
		int InterfaceOffset();

		// Token: 0x04010AC8 RID: 68296
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.SequenceCustomGuidGetterInterface";
	}
}
