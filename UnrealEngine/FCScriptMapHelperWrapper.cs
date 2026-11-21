using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200002C RID: 44
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 72)]
	public struct FCScriptMapHelperWrapper
	{
		// Token: 0x0600081B RID: 2075
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* AllocNativeMemory(UnrealReflectionPropertyTypeCode KeyElementTypeCode, IntPtr KeyInnerUStructPtr, int KeyElementSize, int KeyElementMinAlignment, UnrealReflectionPropertyTypeCode ValueElementTypeCode, IntPtr ValueInnerUStructPtr, int ValueElementSize, int ValueElementMinAlignment);

		// Token: 0x0600081C RID: 2076
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeallocNativeMemory(IntPtr ScriptMapHelperPtr);

		// Token: 0x0600081D RID: 2077
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AllocNativeScriptMap(IntPtr ScriptMapHelperPtr);

		// Token: 0x0600081E RID: 2078
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNativeScriptMap(IntPtr ScriptMapHelperPtr, IntPtr ScriptMapPtr, bool bIsNativeScriptMapPtrAllocated);

		// Token: 0x0600081F RID: 2079
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveAssign(IntPtr DestScriptMapHelperPtr, IntPtr SrcScriptMapPtr);

		// Token: 0x06000820 RID: 2080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveTo(IntPtr DestScriptMapPtr, IntPtr SrcScriptMapHelperPtr);

		// Token: 0x06000821 RID: 2081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyAssign(IntPtr DestScriptMapHelperPtr, IntPtr SrcScriptMapPtr);

		// Token: 0x06000822 RID: 2082
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyTo(IntPtr DestScriptMapPtr, IntPtr SrcScriptMapHelperPtr);

		// Token: 0x06000823 RID: 2083
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Add(IntPtr ScriptMapHelperPtr, void* Key, void* Value);

		// Token: 0x06000824 RID: 2084
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool Remove(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x06000825 RID: 2085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetKeyPtr(IntPtr ScriptMapHelperPtr, int Index);

		// Token: 0x06000826 RID: 2086
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetValuePtr(IntPtr ScriptMapHelperPtr, int Index);

		// Token: 0x06000827 RID: 2087
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* FindValue(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x06000828 RID: 2088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern int FindIndex(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x06000829 RID: 2089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxIndex(IntPtr ScriptMapHelperPtr);

		// Token: 0x0600082A RID: 2090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidIndex(IntPtr ScriptMapHelperPtr, int index);

		// Token: 0x0600082B RID: 2091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Num(IntPtr ScriptMapHelperPtr);

		// Token: 0x0600082C RID: 2092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Empty(IntPtr ScriptMapHelperPtr, int Slack);

		// Token: 0x040000FF RID: 255
		[FieldOffset(0)]
		private IntPtr _vtable;

		// Token: 0x04000100 RID: 256
		[FieldOffset(8)]
		internal IntPtr KeyProp;

		// Token: 0x04000101 RID: 257
		[FieldOffset(16)]
		internal IntPtr ValueProp;

		// Token: 0x04000102 RID: 258
		[FieldOffset(24)]
		internal IntPtr Map;

		// Token: 0x04000103 RID: 259
		[FieldOffset(32)]
		internal FScriptMapLayout MapLayout;

		// Token: 0x04000104 RID: 260
		[FieldOffset(56)]
		internal int MapFlags;

		// Token: 0x04000105 RID: 261
		[FieldOffset(64)]
		internal bool bIsScriptMapAllocated;
	}
}
