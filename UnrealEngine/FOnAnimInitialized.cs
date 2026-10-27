using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F00 RID: 3840
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAnimInitialized : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600CFF2 RID: 53234 RVA: 0x0012F552 File Offset: 0x0012D752
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAnimInitialized.StaticFunctionPtr();
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x0012F55E File Offset: 0x0012D75E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAnimInitialized._FunctionPtr == IntPtr.Zero)
			{
				FOnAnimInitialized._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAnimInitialized__DelegateSignature");
			}
			return FOnAnimInitialized._FunctionPtr;
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x0012F581 File Offset: 0x0012D781
		public FOnAnimInitialized()
		{
		}

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x0012F589 File Offset: 0x0012D789
		[NullableContext(2)]
		public FOnAnimInitialized(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CFF6 RID: 53238 RVA: 0x0012F593 File Offset: 0x0012D793
		public FOnAnimInitialized(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x0012F59E File Offset: 0x0012D79E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x0012F5D0 File Offset: 0x0012D7D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnAnimInitialized.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAnimInitialized.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAnimInitialized.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAnimInitialized.OnScriptCallback));
				}
				FOnAnimInitialized.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAnimInitialized.RegisterId);
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x0012F60A File Offset: 0x0012D80A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x0012F613 File Offset: 0x0012D813
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x0012F620 File Offset: 0x0012D820
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

		// Token: 0x04007017 RID: 28695
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007018 RID: 28696
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAnimInitialized__DelegateSignature";

		// Token: 0x04007019 RID: 28697
		private static int RegisterId;

		// Token: 0x02002D50 RID: 11600
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016763 RID: 92003
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
