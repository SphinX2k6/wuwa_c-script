using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000097 RID: 151
	public static class TWeakObjectPtrExtensions
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x000187C9 File Offset: 0x000169C9
		public static UClassStackOnlyPtr GetClass<T>([Nullable(new byte[]
		{
			0,
			1
		})] this TWeakObjectPtr<T> weakObjectPtr) where T : UClass
		{
			return weakObjectPtr._WeakObjectPtr.GetNativePtr();
		}
	}
}
