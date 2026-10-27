using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001592 RID: 5522
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SceneComponentBackedTarget")]
	public interface ISceneComponentBackedTarget : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013EC6 RID: 81606
		int InterfaceOffset();

		// Token: 0x0400AC88 RID: 44168
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.SceneComponentBackedTarget";
	}
}
