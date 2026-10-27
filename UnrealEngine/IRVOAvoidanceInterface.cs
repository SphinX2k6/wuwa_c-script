using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010CA RID: 4298
	[UnrealObjectPath("/Script/Engine.RVOAvoidanceInterface")]
	public interface IRVOAvoidanceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600F55A RID: 62810
		int InterfaceOffset();

		// Token: 0x040084EF RID: 34031
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RVOAvoidanceInterface";
	}
}
