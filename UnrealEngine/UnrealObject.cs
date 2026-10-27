using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200009C RID: 156
	public abstract class UnrealObject : IUnrealObject
	{
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00018A40 File Offset: 0x00016C40
		public IntPtr NativePtr
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				SharpherealAssert.NativePtrAssert(this._NativePtr);
				return this._NativePtr;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00018A53 File Offset: 0x00016C53
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public IntPtr GetNativePtr_Unchecked()
		{
			return this._NativePtr;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00018A5B File Offset: 0x00016C5B
		protected UnrealObject()
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00018A63 File Offset: 0x00016C63
		protected UnrealObject(IntPtr NativePtr)
		{
			SharpherealAssert.NativePtrAssert(NativePtr);
			this._NativePtr = NativePtr;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00018A78 File Offset: 0x00016C78
		public virtual bool IsValid()
		{
			return this._NativePtr > (IntPtr)0;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00018A84 File Offset: 0x00016C84
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void FastCheckIsValid()
		{
			if (this._NativePtr == 0)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x04000203 RID: 515
		internal IntPtr _NativePtr;
	}
}
