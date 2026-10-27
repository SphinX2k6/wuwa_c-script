using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002663 RID: 9827
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccess")]
	public interface IPropertyAccess : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06024848 RID: 149576
		int InterfaceOffset();

		// Token: 0x040139F5 RID: 80373
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccess";
	}
}
