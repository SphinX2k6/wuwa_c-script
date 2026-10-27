using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001848 RID: 6216
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFreeVisualizedInterface")]
	public interface IKuroFreeVisualizedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016EAA RID: 93866
		int InterfaceOffset();

		// Token: 0x0400C740 RID: 51008
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFreeVisualizedInterface";
	}
}
