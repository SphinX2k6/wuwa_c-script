using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000324 RID: 804
	[UnrealObjectPath("/Script/KuroBulletCore.BulletContext")]
	public interface IBulletContext : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600545C RID: 21596
		int InterfaceOffset();

		// Token: 0x0400227A RID: 8826
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletContext";
	}
}
