using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000063 RID: 99
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FMulticastScriptDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000A29 RID: 2601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr AllocMulticastScriptDelegate();

		// Token: 0x06000A2A RID: 2602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocMulticastScriptDelegate(IntPtr NativePtr);

		// Token: 0x06000A2B RID: 2603
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src);

		// Token: 0x06000A2C RID: 2604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeMove(IntPtr Dest, IntPtr Src);

		// Token: 0x06000A2D RID: 2605
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000A2E RID: 2606
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void AddInternal(IntPtr Handle, int Callback);

		// Token: 0x06000A2F RID: 2607
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void RemoveInternal();

		// Token: 0x06000A30 RID: 2608
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void ClearInternal();

		// Token: 0x06000A31 RID: 2609
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe extern void BroadcastInternal(void* Parameters);

		// Token: 0x06000A32 RID: 2610
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IterExistDelegate(IntPtr MulticastDelegatePtr, ref int Iter, out IntPtr Handle, out int IndexToRemove);

		// Token: 0x06000A33 RID: 2611
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveAtIndexInternal(IntPtr MulticastDelegatePtr, int Index);

		// Token: 0x06000A34 RID: 2612 RVA: 0x00010CDC File Offset: 0x0000EEDC
		protected void Add(Delegate Delegate, int Callback)
		{
			if (Delegate == null)
			{
				throw new NullReferenceException("Callback is null or possibly fail to convert to acceptable type");
			}
			if (FMulticastScriptDelegate.ExistDelegate(base.NativePtr, Delegate))
			{
				return;
			}
			GCHandle value = GCHandle.Alloc(Delegate);
			this.AddInternal(GCHandle.ToIntPtr(value), Callback);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00010D1A File Offset: 0x0000EF1A
		protected void Remove(Delegate Delegate)
		{
			FMulticastScriptDelegate.RemoveDelegate(base.NativePtr, Delegate);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00010D29 File Offset: 0x0000EF29
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			this.ClearInternal();
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00010D31 File Offset: 0x0000EF31
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearScript()
		{
			this.RemoveInternal();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00010D3C File Offset: 0x0000EF3C
		internal static bool ExistDelegate(IntPtr DelegatePtr, Delegate Delegate)
		{
			int num = 0;
			IntPtr value;
			int num2;
			while (FMulticastScriptDelegate.IterExistDelegate(DelegatePtr, ref num, out value, out num2))
			{
				Delegate obj = GCHandle.FromIntPtr(value).Target as Delegate;
				if (Delegate.Equals(obj))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00010D7C File Offset: 0x0000EF7C
		internal static bool RemoveDelegate(IntPtr DelegatePtr, Delegate Delegate)
		{
			int num = 0;
			IntPtr value;
			int index;
			while (FMulticastScriptDelegate.IterExistDelegate(DelegatePtr, ref num, out value, out index))
			{
				if (Delegate.Remove(GCHandle.FromIntPtr(value).Target as Delegate, Delegate) == null)
				{
					FMulticastScriptDelegate.RemoveAtIndexInternal(DelegatePtr, index);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00010DBE File Offset: 0x0000EFBE
		protected override IntPtr AllocNativePtr()
		{
			return FMulticastScriptDelegate.AllocMulticastScriptDelegate();
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00010DC5 File Offset: 0x0000EFC5
		protected override void DeallocNativePtr()
		{
			FMulticastScriptDelegate.DeallocMulticastScriptDelegate(this._NativePtr);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00010DD2 File Offset: 0x0000EFD2
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00010DD5 File Offset: 0x0000EFD5
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			FMulticastScriptDelegate.NativeMove(this._NativePtr, FromNativePtr);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00010DE3 File Offset: 0x0000EFE3
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00010DE6 File Offset: 0x0000EFE6
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FMulticastScriptDelegate.NativeCopy(this._NativePtr, FromNativePtr);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		protected FMulticastScriptDelegate()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00010DFC File Offset: 0x0000EFFC
		[NullableContext(2)]
		protected FMulticastScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00010E06 File Offset: 0x0000F006
		protected FMulticastScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00010E11 File Offset: 0x0000F011
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FMulticastScriptDelegate.NativeCopy(DestPtr, this._NativePtr);
		}
	}
}
