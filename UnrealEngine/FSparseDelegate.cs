using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000086 RID: 134
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FSparseDelegate : UnrealScriptDelegate
	{
		// Token: 0x06000F35 RID: 3893
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected unsafe static extern void BroadcastInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName, void* Parameters);

		// Token: 0x06000F36 RID: 3894
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsBound();

		// Token: 0x06000F37 RID: 3895
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void AddInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName, IntPtr Handle, int Callback);

		// Token: 0x06000F38 RID: 3896
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void RemoveInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000F39 RID: 3897
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern void ClearInternal(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000F3A RID: 3898
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern IntPtr GetMulticastDelegate(IntPtr DelegateOwnerNativePtr, FName DelegateName);

		// Token: 0x06000F3B RID: 3899 RVA: 0x00016BC4 File Offset: 0x00014DC4
		protected void Add(in FName DelegateName, Delegate Delegate, int Callback)
		{
			if (Delegate == null)
			{
				throw new NullReferenceException("Callback is null or possibly fail to convert to acceptable type");
			}
			IntPtr nativePtr = this.GetOwner().NativePtr;
			GCHandle value = GCHandle.Alloc(Delegate);
			this.AddInternal(nativePtr, DelegateName, GCHandle.ToIntPtr(value), Callback);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00016C08 File Offset: 0x00014E08
		protected void Remove(in FName DelegateName, Delegate Delegate)
		{
			IntPtr nativePtr = this.GetOwner().NativePtr;
			IntPtr multicastDelegate = this.GetMulticastDelegate(nativePtr, DelegateName);
			if (multicastDelegate == 0)
			{
				return;
			}
			int num = 0;
			IntPtr value;
			int index;
			while (FMulticastScriptDelegate.IterExistDelegate(multicastDelegate, ref num, out value, out index))
			{
				if (Delegate.Remove(GCHandle.FromIntPtr(value).Target as Delegate, Delegate) == null)
				{
					FMulticastScriptDelegate.RemoveAtIndexInternal(multicastDelegate, index);
					return;
				}
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00016C68 File Offset: 0x00014E68
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			this.ClearInternal(this.GetOwner().NativePtr, this.DelegateName);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00016C81 File Offset: 0x00014E81
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearScript()
		{
			this.RemoveInternal(this.GetOwner().NativePtr, this.DelegateName);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F3F RID: 3903
		public abstract FName DelegateName { get; }

		// Token: 0x06000F40 RID: 3904 RVA: 0x00016C9A File Offset: 0x00014E9A
		protected override IntPtr AllocNativePtr()
		{
			throw new UnreachableException();
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00016CA1 File Offset: 0x00014EA1
		protected override void DeallocNativePtr()
		{
			throw new UnreachableException();
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00016CA8 File Offset: 0x00014EA8
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00016CAB File Offset: 0x00014EAB
		public override bool AllowCopyAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00016CAE File Offset: 0x00014EAE
		protected UObject GetOwner()
		{
			return (UObject)base.MemoryOwner;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00016CBB File Offset: 0x00014EBB
		[NullableContext(2)]
		protected FSparseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			SharpherealAssert.Assert(MemoryOwner is UObject);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00016CD3 File Offset: 0x00014ED3
		public sealed override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			throw new UnreachableException();
		}
	}
}
