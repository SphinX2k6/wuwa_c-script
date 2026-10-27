using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C8 RID: 6344
	public sealed class FKuroEffectFinishCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017713 RID: 96019 RVA: 0x002248A0 File Offset: 0x00222AA0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectFinishCallback.StaticFunctionPtr();
		}

		// Token: 0x06017714 RID: 96020 RVA: 0x002248AC File Offset: 0x00222AAC
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectFinishCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectFinishCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectFinishCallback__DelegateSignature");
			}
			return FKuroEffectFinishCallback._FunctionPtr;
		}

		// Token: 0x06017715 RID: 96021 RVA: 0x002248CF File Offset: 0x00222ACF
		public FKuroEffectFinishCallback()
		{
		}

		// Token: 0x06017716 RID: 96022 RVA: 0x002248D7 File Offset: 0x00222AD7
		[NullableContext(2)]
		public FKuroEffectFinishCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017717 RID: 96023 RVA: 0x002248E1 File Offset: 0x00222AE1
		public FKuroEffectFinishCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017718 RID: 96024 RVA: 0x002248EC File Offset: 0x00222AEC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017719 RID: 96025 RVA: 0x0022491E File Offset: 0x00222B1E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectFinishCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectFinishCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectFinishCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectFinishCallback.OnScriptCallback));
				}
				FKuroEffectFinishCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectFinishCallback.RegisterId);
		}

		// Token: 0x0601771A RID: 96026 RVA: 0x00224958 File Offset: 0x00222B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams* ptr = stackalloc FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectFinishCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601771B RID: 96027 RVA: 0x00224998 File Offset: 0x00222B98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400CBF7 RID: 52215
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBF8 RID: 52216
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectFinishCallback__DelegateSignature";

		// Token: 0x0400CBF9 RID: 52217
		private static int RegisterId;

		// Token: 0x02002FB4 RID: 12212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroEffectFinishCallback_DelegateParams
		{
			// Token: 0x04016B97 RID: 93079
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02002FB5 RID: 12213
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B98 RID: 93080
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
