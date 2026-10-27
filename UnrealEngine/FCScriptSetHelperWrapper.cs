using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200004A RID: 74
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 56)]
	public struct FCScriptSetHelperWrapper
	{
		// Token: 0x060008A8 RID: 2216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* AllocNativeMemory(UnrealReflectionPropertyTypeCode ElementTypeCode, IntPtr InnerUStructPtr, int ElementSize, int ElementMinAlignment);

		// Token: 0x060008A9 RID: 2217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeallocNativeMemory(IntPtr ScriptSetHelperPtr);

		// Token: 0x060008AA RID: 2218
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AllocNativeScriptSet(IntPtr ScriptSetHelperPtr);

		// Token: 0x060008AB RID: 2219
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNativeScriptSet(IntPtr ScriptSetHelperPtr, IntPtr ScriptSetPtr, bool bIsNativeScriptSetPtrAllocated);

		// Token: 0x060008AC RID: 2220
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveAssign(IntPtr DestScriptSetHelperPtr, IntPtr SrcScriptSetPtr);

		// Token: 0x060008AD RID: 2221
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveTo(IntPtr DestScriptSetPtr, IntPtr SrcScriptSetHelperPtr);

		// Token: 0x060008AE RID: 2222
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyAssign(IntPtr DestScriptSetHelperPtr, IntPtr SrcScriptSetPtr);

		// Token: 0x060008AF RID: 2223
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyTo(IntPtr DestScriptSetPtr, IntPtr SrcScriptSetHelperPtr);

		// Token: 0x060008B0 RID: 2224
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Add(IntPtr ScriptSetHelperPtr, void* ElementToAdd);

		// Token: 0x060008B1 RID: 2225
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool Remove(IntPtr ScriptSetHelperPtr, void* ElementToRemove);

		// Token: 0x060008B2 RID: 2226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern int FindIndex(IntPtr ScriptSetHelperPtr, void* ElementToFind);

		// Token: 0x060008B3 RID: 2227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetElementPtr(IntPtr ScriptSetHelperPtr, int Index);

		// Token: 0x060008B4 RID: 2228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidIndex(IntPtr ScriptSetHelperPtr, int Index);

		// Token: 0x060008B5 RID: 2229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxIndex(IntPtr ScriptSetHelperPtr);

		// Token: 0x060008B6 RID: 2230
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Num(IntPtr ScriptSetHelperPtr);

		// Token: 0x060008B7 RID: 2231
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Empty(IntPtr ScriptSetHelperPtr, int Slack);

		// Token: 0x04000153 RID: 339
		[FieldOffset(0)]
		private IntPtr _vtable;

		// Token: 0x04000154 RID: 340
		[FieldOffset(8)]
		internal IntPtr ElementProp;

		// Token: 0x04000155 RID: 341
		[FieldOffset(16)]
		internal IntPtr Set;

		// Token: 0x04000156 RID: 342
		[FieldOffset(24)]
		internal FScriptSetLayout SetLayout;

		// Token: 0x04000157 RID: 343
		[FieldOffset(48)]
		internal bool bIsScriptSetAllocated;
	}
}
