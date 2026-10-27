using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200007E RID: 126
	public abstract class FMulticastScriptDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000E96 RID: 3734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr AllocMulticastScriptDelegate();

		// Token: 0x06000E97 RID: 3735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocMulticastScriptDelegate(IntPtr NativePtr);

		// Token: 0x06000E98 RID: 3736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src);

		// Token: 0x06000E99 RID: 3737
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeMove(IntPtr Dest, IntPtr Src);

		// Token: 0x06000E9A RID: 3738
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000E9B RID: 3739
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void AddInternal(IntPtr Handle, int Callback);

		// Token: 0x06000E9C RID: 3740
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void RemoveInternal();

		// Token: 0x06000E9D RID: 3741
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void ClearInternal();

		// Token: 0x06000E9E RID: 3742
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe extern void BroadcastInternal(void* Parameters);

		// Token: 0x06000E9F RID: 3743
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IterExistDelegate(IntPtr MulticastDelegatePtr, ref int Iter, out IntPtr Handle, out int IndexToRemove);

		// Token: 0x06000EA0 RID: 3744
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveAtIndexInternal(IntPtr MulticastDelegatePtr, int Index);

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00015FBC File Offset: 0x000141BC
		[NullableContext(1)]
		protected void Add(Delegate Delegate, int Callback)
		{
			if (Delegate == null)
			{
				throw new NullReferenceException("Callback is null or possibly fail to convert to acceptable type");
			}
			GCHandle value = GCHandle.Alloc(Delegate);
			this.AddInternal(GCHandle.ToIntPtr(value), Callback);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00015FEC File Offset: 0x000141EC
		[NullableContext(1)]
		protected void Remove(Delegate Delegate)
		{
			int num = 0;
			IntPtr nativePtr = base.NativePtr;
			IntPtr value;
			int index;
			while (FMulticastScriptDelegate.IterExistDelegate(nativePtr, ref num, out value, out index))
			{
				if (Delegate.Remove(GCHandle.FromIntPtr(value).Target as Delegate, Delegate) == null)
				{
					FMulticastScriptDelegate.RemoveAtIndexInternal(nativePtr, index);
					return;
				}
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00016034 File Offset: 0x00014234
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			this.ClearInternal();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0001603C File Offset: 0x0001423C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearScript()
		{
			this.RemoveInternal();
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00016044 File Offset: 0x00014244
		protected override IntPtr AllocNativePtr()
		{
			return FMulticastScriptDelegate.AllocMulticastScriptDelegate();
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0001604B File Offset: 0x0001424B
		protected override void DeallocNativePtr()
		{
			FMulticastScriptDelegate.DeallocMulticastScriptDelegate(this._NativePtr);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00016058 File Offset: 0x00014258
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0001605B File Offset: 0x0001425B
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			FMulticastScriptDelegate.NativeMove(this._NativePtr, FromNativePtr);
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00016069 File Offset: 0x00014269
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0001606C File Offset: 0x0001426C
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FMulticastScriptDelegate.NativeCopy(this._NativePtr, FromNativePtr);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0001607A File Offset: 0x0001427A
		protected FMulticastScriptDelegate()
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00016082 File Offset: 0x00014282
		[NullableContext(2)]
		protected FMulticastScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0001608C File Offset: 0x0001428C
		protected FMulticastScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00016097 File Offset: 0x00014297
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FMulticastScriptDelegate.NativeCopy(DestPtr, this._NativePtr);
		}
	}
}
