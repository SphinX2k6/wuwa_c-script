using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C9 RID: 6345
	public sealed class FKuroEffectInitCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601771C RID: 96028 RVA: 0x002249E2 File Offset: 0x00222BE2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectInitCallback.StaticFunctionPtr();
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x002249EE File Offset: 0x00222BEE
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectInitCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectInitCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectInitCallback__DelegateSignature");
			}
			return FKuroEffectInitCallback._FunctionPtr;
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x00224A11 File Offset: 0x00222C11
		public FKuroEffectInitCallback()
		{
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x00224A19 File Offset: 0x00222C19
		[NullableContext(2)]
		public FKuroEffectInitCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x00224A23 File Offset: 0x00222C23
		public FKuroEffectInitCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00224A2E File Offset: 0x00222C2E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte, int>) ?? ((Action<byte, int>)Delegate.CreateDelegate(typeof(Action<byte, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x00224A60 File Offset: 0x00222C60
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<byte, int> Callback)
		{
			if (FKuroEffectInitCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectInitCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectInitCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectInitCallback.OnScriptCallback));
				}
				FKuroEffectInitCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectInitCallback.RegisterId);
		}

		// Token: 0x06017723 RID: 96035 RVA: 0x00224A9C File Offset: 0x00222C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(byte Result, int Handle)
		{
			FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams* ptr = stackalloc FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectInitCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Result = Result;
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x00224AE0 File Offset: 0x00222CE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte, int> action = target as Action<byte, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams*)__Parameters)->Result, ((FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400CBFA RID: 52218
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBFB RID: 52219
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectInitCallback__DelegateSignature";

		// Token: 0x0400CBFC RID: 52220
		private static int RegisterId;

		// Token: 0x02002FB6 RID: 12214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FKuroEffectInitCallback_DelegateParams
		{
			// Token: 0x04016B99 RID: 93081
			[FieldOffset(0)]
			public byte Result;

			// Token: 0x04016B9A RID: 93082
			[FieldOffset(4)]
			public int Handle;
		}

		// Token: 0x02002FB7 RID: 12215
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B9B RID: 93083
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
