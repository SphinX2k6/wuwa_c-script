using System;

namespace UnrealEngine
{
	// Token: 0x020000A7 RID: 167
	public readonly struct UStructStackOnlyPtr
	{
		// Token: 0x060010CE RID: 4302 RVA: 0x0001938F File Offset: 0x0001758F
		public UStructStackOnlyPtr(IntPtr NativePtr)
		{
			this.StructPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0001939E File Offset: 0x0001759E
		public IntPtr StructPtr { get; }

		// Token: 0x060010D0 RID: 4304 RVA: 0x000193A6 File Offset: 0x000175A6
		public bool IsValid()
		{
			return this.StructPtr != IntPtr.Zero;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000193B8 File Offset: 0x000175B8
		public static implicit operator UStructStackOnlyPtr(IntPtr Ptr)
		{
			return new UStructStackOnlyPtr(Ptr);
		}
	}
}
