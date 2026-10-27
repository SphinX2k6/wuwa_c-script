using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200266B RID: 9835
	[UnrealObjectPath("/Script/PropertyAccess.PropertyEventBroadcaster")]
	public interface IPropertyEventBroadcaster : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060248C5 RID: 149701
		int InterfaceOffset();

		// Token: 0x04013A30 RID: 80432
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyEventBroadcaster";
	}
}
