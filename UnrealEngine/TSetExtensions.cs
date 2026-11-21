using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200005C RID: 92
	[NullableContext(1)]
	[Nullable(0)]
	public static class TSetExtensions
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00010A6B File Offset: 0x0000EC6B
		public static void CopyTo<T>(this TSet<T> Self, IntPtr DestScriptSetPtr)
		{
			FCScriptSetHelperWrapper.CopyTo(DestScriptSetPtr, Self.NativePtr);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00010A79 File Offset: 0x0000EC79
		public static void MoveTo<T>(this TSet<T> Self, IntPtr DestScriptSetPtr)
		{
			FCScriptSetHelperWrapper.MoveTo(DestScriptSetPtr, Self.NativePtr);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00010A87 File Offset: 0x0000EC87
		public static void CopyTo<T>(this TSet<T> Self, TSet<T> Dest)
		{
			FCScriptSetHelperWrapper.CopyTo(Dest.NativeSetPtr, Self.NativePtr);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00010A9A File Offset: 0x0000EC9A
		public static void CopyAssign<T>(this TSet<T> Self, TSet<T> Src)
		{
			FCScriptSetHelperWrapper.CopyTo(Self.NativeSetPtr, Src.NativePtr);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00010AAD File Offset: 0x0000ECAD
		public static void MoveTo<T>(this TSet<T> Self, TSet<T> Dest)
		{
			FCScriptSetHelperWrapper.MoveTo(Dest.NativeSetPtr, Self.NativePtr);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		public static void MoveAssign<T>(this TSet<T> Self, TSet<T> Src)
		{
			FCScriptSetHelperWrapper.MoveTo(Self.NativeSetPtr, Src.NativePtr);
		}
	}
}
