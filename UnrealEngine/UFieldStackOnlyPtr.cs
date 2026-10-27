using System;

namespace UnrealEngine
{
	// Token: 0x0200009A RID: 154
	public readonly struct UFieldStackOnlyPtr
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x000189DE File Offset: 0x00016BDE
		public UFieldStackOnlyPtr(IntPtr NativePtr)
		{
			this.FieldPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x000189ED File Offset: 0x00016BED
		public IntPtr FieldPtr { get; }

		// Token: 0x06001070 RID: 4208 RVA: 0x000189F5 File Offset: 0x00016BF5
		public bool IsValid()
		{
			return this.FieldPtr != IntPtr.Zero;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00018A07 File Offset: 0x00016C07
		public static implicit operator UFieldStackOnlyPtr(IntPtr Ptr)
		{
			return new UFieldStackOnlyPtr(Ptr);
		}
	}
}
