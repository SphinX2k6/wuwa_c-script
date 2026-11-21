using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000832 RID: 2098
	[UnrealObjectPath("/Script/SMSystem.SMInstanceInterface")]
	public interface ISMInstanceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600B700 RID: 46848
		int InterfaceOffset();

		// Token: 0x040052FA RID: 21242
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMInstanceInterface";
	}
}
