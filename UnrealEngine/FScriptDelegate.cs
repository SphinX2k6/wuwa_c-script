using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000065 RID: 101
	public abstract class FScriptDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000A55 RID: 2645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr AllocScriptDelegate();

		// Token: 0x06000A56 RID: 2646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocScriptDelegate(IntPtr NativePtr);

		// Token: 0x06000A57 RID: 2647
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src);

		// Token: 0x06000A58 RID: 2648
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000A59 RID: 2649
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void BindInternal(IntPtr Handle, int Callback);

		// Token: 0x06000A5A RID: 2650
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void UnbindInternal();

		// Token: 0x06000A5B RID: 2651
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe extern bool ExecuteInternal(void* Parameters);

		// Token: 0x06000A5C RID: 2652
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern bool FindExistDelegate(out IntPtr Handle);

		// Token: 0x06000A5D RID: 2653 RVA: 0x00011028 File Offset: 0x0000F228
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

		// Token: 0x06000A5E RID: 2654 RVA: 0x00011058 File Offset: 0x0000F258
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Unbind()
		{
			this.UnbindInternal();
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00011060 File Offset: 0x0000F260
		protected override IntPtr AllocNativePtr()
		{
			return FScriptDelegate.AllocScriptDelegate();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00011067 File Offset: 0x0000F267
		protected override void DeallocNativePtr()
		{
			FScriptDelegate.DeallocScriptDelegate(this._NativePtr);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00011074 File Offset: 0x0000F274
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00011077 File Offset: 0x0000F277
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001107A File Offset: 0x0000F27A
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FScriptDelegate.NativeCopy(this._NativePtr, FromNativePtr);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00011088 File Offset: 0x0000F288
		protected FScriptDelegate()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00011090 File Offset: 0x0000F290
		[NullableContext(2)]
		protected FScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001109A File Offset: 0x0000F29A
		protected FScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000110A5 File Offset: 0x0000F2A5
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FScriptDelegate.NativeCopy(DestPtr, this._NativePtr);
		}

		// Token: 0x020008D3 RID: 2259
		internal struct FScriptDelegateLayout
		{
			// Token: 0x0400578E RID: 22414
			public FWeakObjectPtr Object;

			// Token: 0x0400578F RID: 22415
			public FName FunctionName;

			// Token: 0x04005790 RID: 22416
			private IntPtr __SharedPtr;

			// Token: 0x04005791 RID: 22417
			private IntPtr __SharedCountPtr;
		}
	}
}
