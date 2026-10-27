using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200159A RID: 5530
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ToolFrameworkComponent")]
	public interface IToolFrameworkComponent : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013EEC RID: 81644
		int InterfaceOffset();

		// Token: 0x0400AC9F RID: 44191
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.ToolFrameworkComponent";
	}
}
