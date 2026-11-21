using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 56)]
	public struct FCScriptSetHelperWrapper
	{
		// Token: 0x0600082D RID: 2093
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* AllocNativeMemory(UnrealReflectionPropertyTypeCode ElementTypeCode, IntPtr InnerUStructPtr, int ElementSize, int ElementMinAlignment);

		// Token: 0x0600082E RID: 2094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeallocNativeMemory(IntPtr ScriptSetHelperPtr);

		// Token: 0x0600082F RID: 2095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AllocNativeScriptSet(IntPtr ScriptSetHelperPtr);

		// Token: 0x06000830 RID: 2096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNativeScriptSet(IntPtr ScriptSetHelperPtr, IntPtr ScriptSetPtr, bool bIsNativeScriptSetPtrAllocated);

		// Token: 0x06000831 RID: 2097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveAssign(IntPtr DestScriptSetHelperPtr, IntPtr SrcScriptSetPtr);

		// Token: 0x06000832 RID: 2098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveTo(IntPtr DestScriptSetPtr, IntPtr SrcScriptSetHelperPtr);

		// Token: 0x06000833 RID: 2099
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyAssign(IntPtr DestScriptSetHelperPtr, IntPtr SrcScriptSetPtr);

		// Token: 0x06000834 RID: 2100
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyTo(IntPtr DestScriptSetPtr, IntPtr SrcScriptSetHelperPtr);

		// Token: 0x06000835 RID: 2101
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Add(IntPtr ScriptSetHelperPtr, void* ElementToAdd);

		// Token: 0x06000836 RID: 2102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool Remove(IntPtr ScriptSetHelperPtr, void* ElementToRemove);

		// Token: 0x06000837 RID: 2103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern int FindIndex(IntPtr ScriptSetHelperPtr, void* ElementToFind);

		// Token: 0x06000838 RID: 2104
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetElementPtr(IntPtr ScriptSetHelperPtr, int Index);

		// Token: 0x06000839 RID: 2105
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidIndex(IntPtr ScriptSetHelperPtr, int Index);

		// Token: 0x0600083A RID: 2106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxIndex(IntPtr ScriptSetHelperPtr);

		// Token: 0x0600083B RID: 2107
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Num(IntPtr ScriptSetHelperPtr);

		// Token: 0x0600083C RID: 2108
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Empty(IntPtr ScriptSetHelperPtr, int Slack);

		// Token: 0x0400010C RID: 268
		[FieldOffset(0)]
		private IntPtr _vtable;

		// Token: 0x0400010D RID: 269
		[FieldOffset(8)]
		internal IntPtr ElementProp;

		// Token: 0x0400010E RID: 270
		[FieldOffset(16)]
		internal IntPtr Set;

		// Token: 0x0400010F RID: 271
		[FieldOffset(24)]
		internal FScriptSetLayout SetLayout;

		// Token: 0x04000110 RID: 272
		[FieldOffset(48)]
		internal bool bIsScriptSetAllocated;
	}
}
