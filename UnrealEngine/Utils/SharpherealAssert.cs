using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x020008A4 RID: 2212
	[NullableContext(1)]
	[Nullable(0)]
	public static class SharpherealAssert
	{
		// Token: 0x0600BE36 RID: 48694 RVA: 0x0012FCA4 File Offset: 0x0012DEA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Ensure(bool Condition, string Fmt, params object[] Args)
		{
			if (!Condition)
			{
				UnrealLogger.Warn(string.Format(Fmt, Args));
				return false;
			}
			return true;
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x0012FCB8 File Offset: 0x0012DEB8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Ensure(bool Condition)
		{
			return Condition;
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x0012FCC0 File Offset: 0x0012DEC0
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition, string Message)
		{
			if (!Condition)
			{
				throw new Exception(Message);
			}
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x0012FCCC File Offset: 0x0012DECC
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition, string Fmt, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> Args)
		{
			if (!Condition)
			{
				throw new Exception(string.Format(Fmt, Args));
			}
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x0012FCDE File Offset: 0x0012DEDE
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition)
		{
			if (!Condition)
			{
				throw new Exception();
			}
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x0012FCE9 File Offset: 0x0012DEE9
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NativePtrAssert(IntPtr NativePtr)
		{
			if (NativePtr == 0 || NativePtr <= (IntPtr)256)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x0600BE3C RID: 48700 RVA: 0x0012FCFD File Offset: 0x0012DEFD
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FastNativePtrAssert(IntPtr NativePtr)
		{
			if (NativePtr == 0)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x040056BA RID: 22202
		public static bool EnableEnsureBreak = true;
	}
}
