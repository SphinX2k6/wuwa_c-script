using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200154B RID: 5451
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBaseComponentInterface")]
	public interface IGizmoBaseComponentInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013C72 RID: 81010
		int InterfaceOffset();

		// Token: 0x0400AB2E RID: 43822
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBaseComponentInterface";
	}
}
