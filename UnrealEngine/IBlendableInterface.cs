using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008AD RID: 2221
	[UnrealObjectPath("/Script/Engine.BlendableInterface")]
	public interface IBlendableInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06007976 RID: 31094
		int InterfaceOffset();

		// Token: 0x04003A5F RID: 14943
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlendableInterface";
	}
}
