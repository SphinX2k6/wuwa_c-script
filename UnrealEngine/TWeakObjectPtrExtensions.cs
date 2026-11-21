using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200007C RID: 124
	public static class TWeakObjectPtrExtensions
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x000134ED File Offset: 0x000116ED
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
