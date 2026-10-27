using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000341 RID: 833
	[UnrealObjectPath("/Script/AnimGraphRuntime.SequencerAnimationSupport")]
	public interface ISequencerAnimationSupport : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06002E8D RID: 11917
		int InterfaceOffset();

		// Token: 0x040013F4 RID: 5108
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.SequencerAnimationSupport";
	}
}
