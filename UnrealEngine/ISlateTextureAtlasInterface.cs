using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001118 RID: 4376
	[UnrealObjectPath("/Script/Engine.SlateTextureAtlasInterface")]
	public interface ISlateTextureAtlasInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600FFDF RID: 65503
		int InterfaceOffset();

		// Token: 0x04008981 RID: 35201
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SlateTextureAtlasInterface";
	}
}
