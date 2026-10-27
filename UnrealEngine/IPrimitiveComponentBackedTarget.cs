using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001591 RID: 5521
	[UnrealObjectPath("/Script/InteractiveToolsFramework.PrimitiveComponentBackedTarget")]
	public interface IPrimitiveComponentBackedTarget : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013EC5 RID: 81605
		int InterfaceOffset();

		// Token: 0x0400AC87 RID: 44167
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.PrimitiveComponentBackedTarget";
	}
}
