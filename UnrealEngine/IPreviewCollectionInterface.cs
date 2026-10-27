using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001034 RID: 4148
	[UnrealObjectPath("/Script/Engine.PreviewCollectionInterface")]
	public interface IPreviewCollectionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600E963 RID: 59747
		int InterfaceOffset();

		// Token: 0x04007EAF RID: 32431
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PreviewCollectionInterface";
	}
}
