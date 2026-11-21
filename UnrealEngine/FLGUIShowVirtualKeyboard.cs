using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BC RID: 1724
	public sealed class FLGUIShowVirtualKeyboard : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093C2 RID: 37826 RVA: 0x000DE9F6 File Offset: 0x000DCBF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIShowVirtualKeyboard.StaticFunctionPtr();
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x000DEA02 File Offset: 0x000DCC02
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIShowVirtualKeyboard._FunctionPtr == IntPtr.Zero)
			{
				FLGUIShowVirtualKeyboard._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIShowVirtualKeyboard__DelegateSignature");
			}
			return FLGUIShowVirtualKeyboard._FunctionPtr;
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x000DEA25 File Offset: 0x000DCC25
		public FLGUIShowVirtualKeyboard()
		{
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x000DEA2D File Offset: 0x000DCC2D
		[NullableContext(2)]
		public FLGUIShowVirtualKeyboard(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x000DEA37 File Offset: 0x000DCC37
		public FLGUIShowVirtualKeyboard(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x000DEA42 File Offset: 0x000DCC42
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x000DEA74 File Offset: 0x000DCC74
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIShowVirtualKeyboard.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIShowVirtualKeyboard.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIShowVirtualKeyboard.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIShowVirtualKeyboard.OnScriptCallback));
				}
				FLGUIShowVirtualKeyboard.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIShowVirtualKeyboard.RegisterId);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x000DEAB0 File Offset: 0x000DCCB0
		[SkipLocalsInit]
		public unsafe void Execute(bool state)
		{
			FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams* ptr = stackalloc FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIShowVirtualKeyboard.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->state = state;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x000DEAF0 File Offset: 0x000DCCF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams*)__Parameters)->state);
		}

		// Token: 0x04004069 RID: 16489
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400406A RID: 16490
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIShowVirtualKeyboard__DelegateSignature";

		// Token: 0x0400406B RID: 16491
		private static int RegisterId;

		// Token: 0x02000EE8 RID: 3816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIShowVirtualKeyboard_DelegateParams
		{
			// Token: 0x040062AA RID: 25258
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02000EE9 RID: 3817
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062AB RID: 25259
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
