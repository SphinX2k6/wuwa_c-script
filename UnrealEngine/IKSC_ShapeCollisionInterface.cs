using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E3D RID: 7741
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_ShapeCollisionInterface")]
	public interface IKSC_ShapeCollisionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D7F8 RID: 120824
		int InterfaceOffset();

		// Token: 0x0400FFD0 RID: 65488
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_ShapeCollisionInterface";
	}
}
