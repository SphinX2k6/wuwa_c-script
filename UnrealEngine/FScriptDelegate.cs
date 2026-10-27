using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000080 RID: 128
	public abstract class FScriptDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000EC0 RID: 3776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr AllocScriptDelegate();

		// Token: 0x06000EC1 RID: 3777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocScriptDelegate(IntPtr NativePtr);

		// Token: 0x06000EC2 RID: 3778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src);

		// Token: 0x06000EC3 RID: 3779
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000EC4 RID: 3780
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void BindInternal(IntPtr Handle, int Callback);

		// Token: 0x06000EC5 RID: 3781
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void UnbindInternal();

		// Token: 0x06000EC6 RID: 3782
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe extern bool ExecuteInternal(void* Parameters);

		// Token: 0x06000EC7 RID: 3783
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern bool FindExistDelegate(out IntPtr Handle);

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000162AC File Offset: 0x000144AC
		[NullableContext(1)]
		protected void Bind(Delegate Delegate, int Callback)
		{
			if (Delegate == null)
			{
				throw new NullReferenceException("Delegate is null or possibly fail to convert to acceptable type");
			}
			GCHandle value = GCHandle.Alloc(Delegate, GCHandleType.Normal);
			this.BindInternal(GCHandle.ToIntPtr(value), Callback);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000162DC File Offset: 0x000144DC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Unbind()
		{
			this.UnbindInternal();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000162E4 File Offset: 0x000144E4
		protected override IntPtr AllocNativePtr()
		{
			return FScriptDelegate.AllocScriptDelegate();
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000162EB File Offset: 0x000144EB
		protected override void DeallocNativePtr()
		{
			FScriptDelegate.DeallocScriptDelegate(this._NativePtr);
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x000162F8 File Offset: 0x000144F8
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000162FB File Offset: 0x000144FB
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000162FE File Offset: 0x000144FE
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FScriptDelegate.NativeCopy(this._NativePtr, FromNativePtr);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0001630C File Offset: 0x0001450C
		protected FScriptDelegate()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00016314 File Offset: 0x00014514
		[NullableContext(2)]
		protected FScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001631E File Offset: 0x0001451E
		protected FScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00016329 File Offset: 0x00014529
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FScriptDelegate.NativeCopy(DestPtr, this._NativePtr);
		}

		// Token: 0x02002B25 RID: 11045
		internal struct FScriptDelegateLayout
		{
			// Token: 0x04016378 RID: 91000
			public FWeakObjectPtr Object;

			// Token: 0x04016379 RID: 91001
			public FName FunctionName;

			// Token: 0x0401637A RID: 91002
			private IntPtr __SharedPtr;

			// Token: 0x0401637B RID: 91003
			private IntPtr __SharedCountPtr;
		}
	}
}
