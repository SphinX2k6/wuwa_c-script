using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001579 RID: 5497
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolEditorGizmoAPI")]
	public interface IInteractiveToolEditorGizmoAPI : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013E0D RID: 81421
		int InterfaceOffset();

		// Token: 0x0400AC17 RID: 44055
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolEditorGizmoAPI";
	}
}
