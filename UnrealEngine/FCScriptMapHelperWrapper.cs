using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000047 RID: 71
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 72)]
	public struct FCScriptMapHelperWrapper
	{
		// Token: 0x06000896 RID: 2198
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* AllocNativeMemory(UnrealReflectionPropertyTypeCode KeyElementTypeCode, IntPtr KeyInnerUStructPtr, int KeyElementSize, int KeyElementMinAlignment, UnrealReflectionPropertyTypeCode ValueElementTypeCode, IntPtr ValueInnerUStructPtr, int ValueElementSize, int ValueElementMinAlignment);

		// Token: 0x06000897 RID: 2199
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeallocNativeMemory(IntPtr ScriptMapHelperPtr);

		// Token: 0x06000898 RID: 2200
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AllocNativeScriptMap(IntPtr ScriptMapHelperPtr);

		// Token: 0x06000899 RID: 2201
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNativeScriptMap(IntPtr ScriptMapHelperPtr, IntPtr ScriptMapPtr, bool bIsNativeScriptMapPtrAllocated);

		// Token: 0x0600089A RID: 2202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveAssign(IntPtr DestScriptMapHelperPtr, IntPtr SrcScriptMapPtr);

		// Token: 0x0600089B RID: 2203
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MoveTo(IntPtr DestScriptMapPtr, IntPtr SrcScriptMapHelperPtr);

		// Token: 0x0600089C RID: 2204
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyAssign(IntPtr DestScriptMapHelperPtr, IntPtr SrcScriptMapPtr);

		// Token: 0x0600089D RID: 2205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyTo(IntPtr DestScriptMapPtr, IntPtr SrcScriptMapHelperPtr);

		// Token: 0x0600089E RID: 2206
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Add(IntPtr ScriptMapHelperPtr, void* Key, void* Value);

		// Token: 0x0600089F RID: 2207
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern bool Remove(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x060008A0 RID: 2208
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetKeyPtr(IntPtr ScriptMapHelperPtr, int Index);

		// Token: 0x060008A1 RID: 2209
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* GetValuePtr(IntPtr ScriptMapHelperPtr, int Index);

		// Token: 0x060008A2 RID: 2210
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* FindValue(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x060008A3 RID: 2211
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern int FindIndex(IntPtr ScriptMapHelperPtr, void* Key);

		// Token: 0x060008A4 RID: 2212
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxIndex(IntPtr ScriptMapHelperPtr);

		// Token: 0x060008A5 RID: 2213
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidIndex(IntPtr ScriptMapHelperPtr, int index);

		// Token: 0x060008A6 RID: 2214
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Num(IntPtr ScriptMapHelperPtr);

		// Token: 0x060008A7 RID: 2215
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Empty(IntPtr ScriptMapHelperPtr, int Slack);

		// Token: 0x04000146 RID: 326
		[FieldOffset(0)]
		private IntPtr _vtable;

		// Token: 0x04000147 RID: 327
		[FieldOffset(8)]
		internal IntPtr KeyProp;

		// Token: 0x04000148 RID: 328
		[FieldOffset(16)]
		internal IntPtr ValueProp;

		// Token: 0x04000149 RID: 329
		[FieldOffset(24)]
		internal IntPtr Map;

		// Token: 0x0400014A RID: 330
		[FieldOffset(32)]
		internal FScriptMapLayout MapLayout;

		// Token: 0x0400014B RID: 331
		[FieldOffset(56)]
		internal int MapFlags;

		// Token: 0x0400014C RID: 332
		[FieldOffset(64)]
		internal bool bIsScriptMapAllocated;
	}
}
