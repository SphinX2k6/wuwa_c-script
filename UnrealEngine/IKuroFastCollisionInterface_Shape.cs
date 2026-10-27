using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001833 RID: 6195
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionInterface_Shape")]
	public interface IKuroFastCollisionInterface_Shape : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016D65 RID: 93541
		int InterfaceOffset();

		// Token: 0x0400C6A5 RID: 50853
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionInterface_Shape";
	}
}
