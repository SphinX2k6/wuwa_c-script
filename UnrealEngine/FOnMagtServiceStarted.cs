using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200227F RID: 8831
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMagtServiceStarted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021934 RID: 137524 RVA: 0x0031AC50 File Offset: 0x00318E50
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMagtServiceStarted.StaticFunctionPtr();
		}

		// Token: 0x06021935 RID: 137525 RVA: 0x0031AC5C File Offset: 0x00318E5C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMagtServiceStarted._FunctionPtr == IntPtr.Zero)
			{
				FOnMagtServiceStarted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnMagtServiceStarted__DelegateSignature");
			}
			return FOnMagtServiceStarted._FunctionPtr;
		}

		// Token: 0x06021936 RID: 137526 RVA: 0x0031AC7F File Offset: 0x00318E7F
		public FOnMagtServiceStarted()
		{
		}

		// Token: 0x06021937 RID: 137527 RVA: 0x0031AC87 File Offset: 0x00318E87
		[NullableContext(2)]
		public FOnMagtServiceStarted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021938 RID: 137528 RVA: 0x0031AC91 File Offset: 0x00318E91
		public FOnMagtServiceStarted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021939 RID: 137529 RVA: 0x0031AC9C File Offset: 0x00318E9C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602193A RID: 137530 RVA: 0x0031ACCE File Offset: 0x00318ECE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMagtServiceStarted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMagtServiceStarted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMagtServiceStarted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMagtServiceStarted.OnScriptCallback));
				}
				FOnMagtServiceStarted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMagtServiceStarted.RegisterId);
		}

		// Token: 0x0602193B RID: 137531 RVA: 0x0031AD08 File Offset: 0x00318F08
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602193C RID: 137532 RVA: 0x0031AD11 File Offset: 0x00318F11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602193D RID: 137533 RVA: 0x0031AD1C File Offset: 0x00318F1C
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

		// Token: 0x04011EE4 RID: 73444
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EE5 RID: 73445
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnMagtServiceStarted__DelegateSignature";

		// Token: 0x04011EE6 RID: 73446
		private static int RegisterId;

		// Token: 0x02003608 RID: 13832
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017692 RID: 95890
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
