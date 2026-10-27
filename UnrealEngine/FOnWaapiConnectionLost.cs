using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000297 RID: 663
	public sealed class FOnWaapiConnectionLost : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002504 RID: 9476 RVA: 0x000373A6 File Offset: 0x000355A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWaapiConnectionLost.StaticFunctionPtr();
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000373B2 File Offset: 0x000355B2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWaapiConnectionLost._FunctionPtr == IntPtr.Zero)
			{
				FOnWaapiConnectionLost._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature");
			}
			return FOnWaapiConnectionLost._FunctionPtr;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000373D5 File Offset: 0x000355D5
		public FOnWaapiConnectionLost()
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000373DD File Offset: 0x000355DD
		[NullableContext(2)]
		public FOnWaapiConnectionLost(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000373E7 File Offset: 0x000355E7
		public FOnWaapiConnectionLost(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000373F2 File Offset: 0x000355F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00037424 File Offset: 0x00035624
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnWaapiConnectionLost.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWaapiConnectionLost.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWaapiConnectionLost.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWaapiConnectionLost.OnScriptCallback));
				}
				FOnWaapiConnectionLost.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnWaapiConnectionLost.RegisterId);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0003745E File Offset: 0x0003565E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0003746C File Offset: 0x0003566C
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

		// Token: 0x04000E0F RID: 3599
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E10 RID: 3600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature";

		// Token: 0x04000E11 RID: 3601
		private static int RegisterId;

		// Token: 0x02002BA3 RID: 11171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016439 RID: 91193
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
