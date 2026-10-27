using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002889 RID: 10377
	[UnrealObjectPath("/Script/SMSystem.SMInstanceInterface")]
	public interface ISMInstanceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06026721 RID: 157473
		int InterfaceOffset();

		// Token: 0x04015191 RID: 86417
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMInstanceInterface";
	}
}
