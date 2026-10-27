using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001889 RID: 6281
	public sealed class FActionBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017262 RID: 94818 RVA: 0x0021BA88 File Offset: 0x00219C88
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActionBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x0021BA94 File Offset: 0x00219C94
		private static IntPtr StaticFunctionPtr()
		{
			if (FActionBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActionBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActionBindingDelegate__DelegateSignature");
			}
			return FActionBindingDelegate._FunctionPtr;
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x0021BAB7 File Offset: 0x00219CB7
		public FActionBindingDelegate()
		{
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x0021BABF File Offset: 0x00219CBF
		[NullableContext(2)]
		public FActionBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017266 RID: 94822 RVA: 0x0021BAC9 File Offset: 0x00219CC9
		public FActionBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017267 RID: 94823 RVA: 0x0021BAD4 File Offset: 0x00219CD4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKey>) ?? ((Action<FKey>)Delegate.CreateDelegate(typeof(Action<FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x0021BB06 File Offset: 0x00219D06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FKey> Callback)
		{
			if (FActionBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActionBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActionBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActionBindingDelegate.OnScriptCallback));
				}
				FActionBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FActionBindingDelegate.RegisterId);
		}

		// Token: 0x06017269 RID: 94825 RVA: 0x0021BB40 File Offset: 0x00219D40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FKey Key)
		{
			FActionBindingDelegate.__FActionBindingDelegate_DelegateParams* ptr = stackalloc FActionBindingDelegate.__FActionBindingDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FActionBindingDelegate.__FActionBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActionBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActionBindingDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601726A RID: 94826 RVA: 0x0021BBAC File Offset: 0x00219DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKey> action = target as Action<FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKey obj = new FKey(&((FActionBindingDelegate.__FActionBindingDelegate_DelegateParams*)__Parameters)->Key, true, true);
			action(obj);
		}

		// Token: 0x0400C8E3 RID: 51427
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8E4 RID: 51428
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActionBindingDelegate__DelegateSignature";

		// Token: 0x0400C8E5 RID: 51429
		private static int RegisterId;

		// Token: 0x02002F82 RID: 12162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FActionBindingDelegate_DelegateParams
		{
			// Token: 0x04016B42 RID: 92994
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02002F83 RID: 12163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B43 RID: 92995
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
