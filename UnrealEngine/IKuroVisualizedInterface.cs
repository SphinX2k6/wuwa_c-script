using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200184E RID: 6222
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroVisualizedInterface")]
	public interface IKuroVisualizedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016EE1 RID: 93921
		int InterfaceOffset();

		// Token: 0x0400C752 RID: 51026
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroVisualizedInterface";
	}
}
