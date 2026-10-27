using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E57 RID: 7767
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SummonedEntity")]
	public interface IKSC_SummonedEntity : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D94A RID: 121162
		int InterfaceOffset();

		// Token: 0x04010091 RID: 65681
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SummonedEntity";
	}
}
