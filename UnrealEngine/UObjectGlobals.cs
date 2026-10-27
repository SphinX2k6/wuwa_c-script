using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(1)]
	[Nullable(0)]
	public static class UObjectGlobals
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x000191DC File Offset: 0x000173DC
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

		// Token: 0x060010BE RID: 4286 RVA: 0x00019220 File Offset: 0x00017420
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

		// Token: 0x060010BF RID: 4287 RVA: 0x0001925C File Offset: 0x0001745C
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

		// Token: 0x060010C0 RID: 4288 RVA: 0x00019298 File Offset: 0x00017498
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

		// Token: 0x060010C1 RID: 4289 RVA: 0x000192D4 File Offset: 0x000174D4
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

		// Token: 0x060010C2 RID: 4290
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadObject(UClassStackOnlyPtr ObjectClass, IntPtr InOuter, char* InName);

		// Token: 0x060010C3 RID: 4291
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadClass(IntPtr InOuter, char* InName);

		// Token: 0x060010C4 RID: 4292
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadScriptStruct(IntPtr InOuter, char* InName);

		// Token: 0x060010C5 RID: 4293
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr Internal_StaticLoadDelegateFunction(IntPtr InOuter, char* InName);

		// Token: 0x060010C6 RID: 4294
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetName(IntPtr ObjectPtr);

		// Token: 0x060010C7 RID: 4295
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName GetFName(IntPtr ObjectPtr);

		// Token: 0x060010C8 RID: 4296
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValid(IntPtr ObjectPtr);

		// Token: 0x060010C9 RID: 4297 RVA: 0x0001933C File Offset: 0x0001753C
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
