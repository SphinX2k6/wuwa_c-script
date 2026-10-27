using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200184F RID: 6223
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroVisualizerInterface")]
	public interface IKuroVisualizerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016EE2 RID: 93922
		int InterfaceOffset();

		// Token: 0x0400C753 RID: 51027
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroVisualizerInterface";
	}
}
