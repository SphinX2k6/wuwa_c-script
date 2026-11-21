using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200008A RID: 138
	[NullableContext(1)]
	[Nullable(0)]
	public static class UObjectGlobals
	{
		// Token: 0x06000C50 RID: 3152 RVA: 0x00013F00 File Offset: 0x00012100
		[NullableContext(2)]
		public unsafe static UnrealUObject StaticLoadObject(UClassStackOnlyPtr ObjectClass, UnrealUObject InOuter, [Nullable(1)] string InName)
		{
			if (string.IsNullOrEmpty(InName))
			{
				return null;
			}
			char* ptr;
			if (InName == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = InName.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* inName = ptr;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(UObjectGlobals.Internal_StaticLoadObject(ObjectClass, (InOuter != null) ? InOuter._NativePtr : ((IntPtr)0), inName));
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00013F44 File Offset: 0x00012144
		public unsafe static IntPtr StaticLoadClass([Nullable(2)] UnrealUObject InOuter, string InName)
		{
			if (string.IsNullOrEmpty(InName))
			{
				return (IntPtr)0;
			}
			char* ptr;
			if (InName == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = InName.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* inName = ptr;
			return UObjectGlobals.Internal_StaticLoadClass((InOuter != null) ? InOuter._NativePtr : ((IntPtr)0), inName);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00013F80 File Offset: 0x00012180
		public unsafe static IntPtr StaticLoadScriptStruct([Nullable(2)] UnrealUObject InOuter, string InName)
		{
			if (string.IsNullOrEmpty(InName))
			{
				return (IntPtr)0;
			}
			char* ptr;
			if (InName == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = InName.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* inName = ptr;
			return UObjectGlobals.Internal_StaticLoadScriptStruct((InOuter != null) ? InOuter._NativePtr : ((IntPtr)0), inName);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00013FBC File Offset: 0x000121BC
		public unsafe static IntPtr StaticLoadDelegateFunction([Nullable(2)] UnrealUObject InOuter, string InName)
		{
			if (string.IsNullOrEmpty(InName))
			{
				return (IntPtr)0;
			}
			char* ptr;
			if (InName == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = InName.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* inName = ptr;
			return UObjectGlobals.Internal_StaticLoadDelegateFunction((InOuter != null) ? InOuter._NativePtr : ((IntPtr)0), inName);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00013FF8 File Offset: 0x000121F8
		public unsafe static IntPtr StaticLoadDelegateFunctionChecked([Nullable(2)] UnrealUObject InOuter, string InName)
		{
			if (string.IsNullOrEmpty(InName))
			{
				bool condition = false;
				string fmt = "Failed to load delegate function with ";
				object obj = InName;
				SharpherealAssert.Assert(condition, fmt, new ReadOnlySpan<object>(ref obj));
				return (IntPtr)0;
			}
			char* ptr;
			if (InName == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = InName.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* inName = ptr;
			IntPtr intPtr = UObjectGlobals.Internal_StaticLoadDelegateFunction((InOuter != null) ? InOuter._NativePtr : ((IntPtr)0), inName);
			bool condition2 = intPtr > (IntPtr)0;
			string fmt2 = "Failed to load delegate function with ";
			object obj2 = InName;
			SharpherealAssert.Assert(condition2, fmt2, new ReadOnlySpan<object>(ref obj2));
			return intPtr;
		}

		// Token: 0x06000C55 RID: 3157
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadObject(UClassStackOnlyPtr ObjectClass, IntPtr InOuter, char* InName);

		// Token: 0x06000C56 RID: 3158
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadClass(IntPtr InOuter, char* InName);

		// Token: 0x06000C57 RID: 3159
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadScriptStruct(IntPtr InOuter, char* InName);

		// Token: 0x06000C58 RID: 3160
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadDelegateFunction(IntPtr InOuter, char* InName);

		// Token: 0x06000C59 RID: 3161
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetName(IntPtr ObjectPtr);

		// Token: 0x06000C5A RID: 3162
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName GetFName(IntPtr ObjectPtr);

		// Token: 0x06000C5B RID: 3163
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValid(IntPtr ObjectPtr);

		// Token: 0x06000C5C RID: 3164 RVA: 0x00014060 File Offset: 0x00012260
		public static IntPtr StaticLoadScriptStruct(string InObjectPath, ref IntPtr ScriptStructPtr)
		{
			ScriptStructPtr = UObjectGlobals.StaticLoadScriptStruct(null, InObjectPath);
			if (ScriptStructPtr == 0)
			{
				throw new Exception("Failed to load script struct: " + InObjectPath);
			}
			return ScriptStructPtr;
		}
	}
}
