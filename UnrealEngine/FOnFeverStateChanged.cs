using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C63 RID: 7267
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnFeverStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C308 RID: 115464 RVA: 0x00298C64 File Offset: 0x00296E64
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFeverStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0601C309 RID: 115465 RVA: 0x00298C70 File Offset: 0x00296E70
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFeverStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnFeverStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnFeverStateChanged__DelegateSignature");
			}
			return FOnFeverStateChanged._FunctionPtr;
		}

		// Token: 0x0601C30A RID: 115466 RVA: 0x00298C93 File Offset: 0x00296E93
		public FOnFeverStateChanged()
		{
		}

		// Token: 0x0601C30B RID: 115467 RVA: 0x00298C9B File Offset: 0x00296E9B
		[NullableContext(2)]
		public FOnFeverStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C30C RID: 115468 RVA: 0x00298CA5 File Offset: 0x00296EA5
		public FOnFeverStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C30D RID: 115469 RVA: 0x00298CB0 File Offset: 0x00296EB0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C30E RID: 115470 RVA: 0x00298CE2 File Offset: 0x00296EE2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnFeverStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFeverStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFeverStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFeverStateChanged.OnScriptCallback));
				}
				FOnFeverStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnFeverStateChanged.RegisterId);
		}

		// Token: 0x0601C30F RID: 115471 RVA: 0x00298D1C File Offset: 0x00296F1C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C310 RID: 115472 RVA: 0x00298D28 File Offset: 0x00296F28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bFeverActive)
		{
			FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams* ptr = stackalloc FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFeverStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bFeverActive = bFeverActive;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C311 RID: 115473 RVA: 0x00298D64 File Offset: 0x00296F64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams*)__Parameters)->bFeverActive);
		}

		// Token: 0x0400F2AD RID: 62125
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2AE RID: 62126
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnFeverStateChanged__DelegateSignature";

		// Token: 0x0400F2AF RID: 62127
		private static int RegisterId;

		// Token: 0x020031F6 RID: 12790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnFeverStateChanged_DelegateParams
		{
			// Token: 0x04017051 RID: 94289
			[FieldOffset(0)]
			public bool bFeverActive;
		}

		// Token: 0x020031F7 RID: 12791
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017052 RID: 94290
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
