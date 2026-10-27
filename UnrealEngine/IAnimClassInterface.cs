using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007F3 RID: 2035
	[UnrealObjectPath("/Script/Engine.AnimClassInterface")]
	public interface IAnimClassInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06006CAF RID: 27823
		int InterfaceOffset();

		// Token: 0x0400346B RID: 13419
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimClassInterface";
	}
}
