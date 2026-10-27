using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FF9 RID: 4089
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DD6C RID: 56684 RVA: 0x00145FEA File Offset: 0x001441EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x00145FF6 File Offset: 0x001441F6
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00146019 File Offset: 0x00144219
		public FPlatformDelegate()
		{
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00146021 File Offset: 0x00144221
		[NullableContext(2)]
		public FPlatformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x0014602B File Offset: 0x0014422B
		public FPlatformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00146036 File Offset: 0x00144236
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x00146068 File Offset: 0x00144268
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FPlatformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformDelegate.OnScriptCallback));
				}
				FPlatformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformDelegate.RegisterId);
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x001460A2 File Offset: 0x001442A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x001460AB File Offset: 0x001442AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600DD75 RID: 56693 RVA: 0x001460B8 File Offset: 0x001442B8
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

		// Token: 0x040077AE RID: 30638
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature";

		// Token: 0x040077AF RID: 30639
		private static int RegisterId;

		// Token: 0x02002DC2 RID: 11714
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167FA RID: 92154
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
