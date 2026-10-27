using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002991 RID: 10641
	[UnrealObjectPath("/Script/UMG.NamedSlotInterface")]
	public interface INamedSlotInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06027645 RID: 161349
		int InterfaceOffset();

		// Token: 0x04015A1A RID: 88602
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.NamedSlotInterface";
	}
}
