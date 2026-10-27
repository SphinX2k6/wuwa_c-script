using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001832 RID: 6194
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionInterface")]
	public interface IKuroFastCollisionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016D64 RID: 93540
		int InterfaceOffset();

		// Token: 0x0400C6A4 RID: 50852
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionInterface";
	}
}
