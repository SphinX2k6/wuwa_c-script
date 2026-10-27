using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E9C RID: 3740
	[UnrealObjectPath("/Script/Engine.MatineeAnimInterface")]
	public interface IMatineeAnimInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600C9AE RID: 51630
		int InterfaceOffset();

		// Token: 0x04006C90 RID: 27792
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MatineeAnimInterface";
	}
}
