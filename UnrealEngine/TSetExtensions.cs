using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000077 RID: 119
	[NullableContext(1)]
	[Nullable(0)]
	public static class TSetExtensions
	{
		// Token: 0x06000E77 RID: 3703 RVA: 0x00015D4B File Offset: 0x00013F4B
		public static void CopyTo<T>(this TSet<T> Self, IntPtr DestScriptSetPtr)
		{
			FCScriptSetHelperWrapper.CopyTo(DestScriptSetPtr, Self.NativePtr);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00015D59 File Offset: 0x00013F59
		public static void MoveTo<T>(this TSet<T> Self, IntPtr DestScriptSetPtr)
		{
			FCScriptSetHelperWrapper.MoveTo(DestScriptSetPtr, Self.NativePtr);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00015D67 File Offset: 0x00013F67
		public static void CopyTo<T>(this TSet<T> Self, TSet<T> Dest)
		{
			FCScriptSetHelperWrapper.CopyTo(Dest.NativeSetPtr, Self.NativePtr);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00015D7A File Offset: 0x00013F7A
		public static void CopyAssign<T>(this TSet<T> Self, TSet<T> Src)
		{
			FCScriptSetHelperWrapper.CopyTo(Self.NativeSetPtr, Src.NativePtr);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00015D8D File Offset: 0x00013F8D
		public static void MoveTo<T>(this TSet<T> Self, TSet<T> Dest)
		{
			FCScriptSetHelperWrapper.MoveTo(Dest.NativeSetPtr, Self.NativePtr);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00015DA0 File Offset: 0x00013FA0
		public static void MoveAssign<T>(this TSet<T> Self, TSet<T> Src)
		{
			FCScriptSetHelperWrapper.MoveTo(Self.NativeSetPtr, Src.NativePtr);
		}
	}
}
