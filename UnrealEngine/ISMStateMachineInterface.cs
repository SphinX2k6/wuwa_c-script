using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002899 RID: 10393
	[UnrealObjectPath("/Script/SMSystem.SMStateMachineInterface")]
	public interface ISMStateMachineInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060268B5 RID: 157877
		int InterfaceOffset();

		// Token: 0x040152B4 RID: 86708
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMStateMachineInterface";
	}
}
