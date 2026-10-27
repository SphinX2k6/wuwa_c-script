using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200156F RID: 5487
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InputBehaviorSource")]
	public interface IInputBehaviorSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013DD0 RID: 81360
		int InterfaceOffset();

		// Token: 0x0400ABF0 RID: 44016
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.InputBehaviorSource";
	}
}
