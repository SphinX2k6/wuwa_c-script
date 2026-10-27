using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200266C RID: 9836
	[UnrealObjectPath("/Script/PropertyAccess.PropertyEventSubscriber")]
	public interface IPropertyEventSubscriber : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060248C6 RID: 149702
		int InterfaceOffset();

		// Token: 0x04013A31 RID: 80433
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyEventSubscriber";
	}
}
