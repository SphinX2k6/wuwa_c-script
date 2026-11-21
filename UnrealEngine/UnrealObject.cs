using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000081 RID: 129
	public abstract class UnrealObject : IUnrealObject
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00013764 File Offset: 0x00011964
		public IntPtr NativePtr
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				SharpherealAssert.NativePtrAssert(this._NativePtr);
				return this._NativePtr;
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00013777 File Offset: 0x00011977
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public IntPtr GetNativePtr_Unchecked()
		{
			return this._NativePtr;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001377F File Offset: 0x0001197F
		protected UnrealObject()
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00013787 File Offset: 0x00011987
		protected UnrealObject(IntPtr NativePtr)
		{
			SharpherealAssert.NativePtrAssert(NativePtr);
			this._NativePtr = NativePtr;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0001379C File Offset: 0x0001199C
		public virtual bool IsValid()
		{
			return this._NativePtr > (IntPtr)0;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000137A8 File Offset: 0x000119A8
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void FastCheckIsValid()
		{
			if (this._NativePtr == 0)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x040001BC RID: 444
		internal IntPtr _NativePtr;
	}
}
