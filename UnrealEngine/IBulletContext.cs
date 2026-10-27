using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016C6 RID: 5830
	[UnrealObjectPath("/Script/KuroBulletCore.BulletContext")]
	public interface IBulletContext : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060151B6 RID: 86454
		int InterfaceOffset();

		// Token: 0x0400B7CC RID: 47052
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletContext";
	}
}
