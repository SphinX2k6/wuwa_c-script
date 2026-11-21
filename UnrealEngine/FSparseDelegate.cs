using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200006B RID: 107
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FSparseDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000AC8 RID: 2760
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe static extern void BroadcastInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName, void* Parameters);

		// Token: 0x06000AC9 RID: 2761
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000ACA RID: 2762
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void AddInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName, IntPtr Handle, int Callback);

		// Token: 0x06000ACB RID: 2763
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void RemoveInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000ACC RID: 2764
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void ClearInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000ACD RID: 2765
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern IntPtr GetMulticastDelegate(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000ACE RID: 2766 RVA: 0x000118F8 File Offset: 0x0000FAF8
		protected void Add(in FName DelegateName, Delegate Delegate, int Callback)
		{
			if (Delegate == null)
			{
				throw new NullReferenceException("Callback is null or possibly fail to convert to acceptable type");
			}
			IntPtr nativePtr = this.GetOwner().NativePtr;
			IntPtr multicastDelegate = this.GetMulticastDelegate(nativePtr, DelegateName);
			if (multicastDelegate != 0 && FMulticastScriptDelegate.ExistDelegate(multicastDelegate, Delegate))
			{
				return;
			}
			GCHandle value = GCHandle.Alloc(Delegate);
			this.AddInternal(nativePtr, DelegateName, GCHandle.ToIntPtr(value), Callback);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00011958 File Offset: 0x0000FB58
		protected void Remove(in FName DelegateName, Delegate Delegate)
		{
			IntPtr nativePtr = this.GetOwner().NativePtr;
			IntPtr multicastDelegate = this.GetMulticastDelegate(nativePtr, DelegateName);
			if (multicastDelegate == 0)
			{
				return;
			}
			FMulticastScriptDelegate.RemoveDelegate(multicastDelegate, Delegate);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001198B File Offset: 0x0000FB8B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			this.ClearInternal(this.GetOwner().NativePtr, this.DelegateName);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000119A4 File Offset: 0x0000FBA4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearScript()
		{
			this.RemoveInternal(this.GetOwner().NativePtr, this.DelegateName);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000AD2 RID: 2770
		public abstract FName DelegateName { get; }

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000119BD File Offset: 0x0000FBBD
		protected override IntPtr AllocNativePtr()
		{
			throw new UnreachableException();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000119C4 File Offset: 0x0000FBC4
		protected override void DeallocNativePtr()
		{
			throw new UnreachableException();
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000119CB File Offset: 0x0000FBCB
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000119CE File Offset: 0x0000FBCE
		public override bool AllowCopyAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000119D1 File Offset: 0x0000FBD1
		protected UObject GetOwner()
		{
			return (UObject)base.MemoryOwner;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000119DE File Offset: 0x0000FBDE
		[NullableContext(2)]
		protected FSparseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			SharpherealAssert.Assert(MemoryOwner is UObject);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000119F6 File Offset: 0x0000FBF6
		public sealed override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			throw new UnreachableException();
		}
	}
}
