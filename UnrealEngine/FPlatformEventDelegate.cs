using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FFA RID: 4090
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformEventDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DD76 RID: 56694 RVA: 0x001460FA File Offset: 0x001442FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DD77 RID: 56695 RVA: 0x00146106 File Offset: 0x00144306
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformEventsComponent.__PlatformEventDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformEventsComponent.__PlatformEventDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature");
			}
			return UPlatformEventsComponent.__PlatformEventDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x00146129 File Offset: 0x00144329
		public FPlatformEventDelegate()
		{
		}

		// Token: 0x0600DD79 RID: 56697 RVA: 0x00146131 File Offset: 0x00144331
		[NullableContext(2)]
		public FPlatformEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x0014613B File Offset: 0x0014433B
		public FPlatformEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x00146146 File Offset: 0x00144346
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DD7C RID: 56700 RVA: 0x00146178 File Offset: 0x00144378
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FPlatformEventDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformEventDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformEventDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformEventDelegate.OnScriptCallback));
				}
				FPlatformEventDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformEventDelegate.RegisterId);
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x001461B2 File Offset: 0x001443B2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DD7E RID: 56702 RVA: 0x001461BB File Offset: 0x001443BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600DD7F RID: 56703 RVA: 0x001461C8 File Offset: 0x001443C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040077B0 RID: 30640
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature";

		// Token: 0x040077B1 RID: 30641
		private static int RegisterId;

		// Token: 0x02002DC3 RID: 11715
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167FB RID: 92155
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
