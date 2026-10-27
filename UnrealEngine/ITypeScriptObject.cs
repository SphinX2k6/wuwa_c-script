using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015BD RID: 5565
	[UnrealObjectPath("/Script/JsEnv.TypeScriptObject")]
	public interface ITypeScriptObject : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06014141 RID: 82241
		int InterfaceOffset();

		// Token: 0x0400AEA5 RID: 44709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.TypeScriptObject";
	}
}
