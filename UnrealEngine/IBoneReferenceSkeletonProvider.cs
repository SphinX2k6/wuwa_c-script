using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008DD RID: 2269
	[UnrealObjectPath("/Script/Engine.BoneReferenceSkeletonProvider")]
	public interface IBoneReferenceSkeletonProvider : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06007CB8 RID: 31928
		int InterfaceOffset();

		// Token: 0x04003BC4 RID: 15300
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneReferenceSkeletonProvider";
	}
}
