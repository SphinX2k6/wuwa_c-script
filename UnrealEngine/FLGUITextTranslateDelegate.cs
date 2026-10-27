using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D4 RID: 8404
	public sealed class FLGUITextTranslateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA92 RID: 129682 RVA: 0x002F153C File Offset: 0x002EF73C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextTranslateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA93 RID: 129683 RVA: 0x002F1548 File Offset: 0x002EF748
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextTranslateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextTranslateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextTranslateDelegate__DelegateSignature");
			}
			return FLGUITextTranslateDelegate._FunctionPtr;
		}

		// Token: 0x0601FA94 RID: 129684 RVA: 0x002F156B File Offset: 0x002EF76B
		public FLGUITextTranslateDelegate()
		{
		}

		// Token: 0x0601FA95 RID: 129685 RVA: 0x002F1573 File Offset: 0x002EF773
		[NullableContext(2)]
		public FLGUITextTranslateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA96 RID: 129686 RVA: 0x002F157D File Offset: 0x002EF77D
		public FLGUITextTranslateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA97 RID: 129687 RVA: 0x002F1588 File Offset: 0x002EF788
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIText>) ?? ((Action<UUIText>)Delegate.CreateDelegate(typeof(Action<UUIText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA98 RID: 129688 RVA: 0x002F15BA File Offset: 0x002EF7BA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIText> Callback)
		{
			if (FLGUITextTranslateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextTranslateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextTranslateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextTranslateDelegate.OnScriptCallback));
				}
				FLGUITextTranslateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextTranslateDelegate.RegisterId);
		}

		// Token: 0x0601FA99 RID: 129689 RVA: 0x002F15F4 File Offset: 0x002EF7F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUIText uiText)
		{
			FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams* ptr = stackalloc FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextTranslateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FA9A RID: 129690 RVA: 0x002F1640 File Offset: 0x002EF840
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIText> action = target as Action<UUIText>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIText orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(((FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams*)__Parameters)->uiText);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04011153 RID: 69971
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011154 RID: 69972
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextTranslateDelegate__DelegateSignature";

		// Token: 0x04011155 RID: 69973
		private static int RegisterId;

		// Token: 0x020034CA RID: 13514
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUITextTranslateDelegate_DelegateParams
		{
			// Token: 0x040174D5 RID: 95445
			[FieldOffset(0)]
			public IntPtr uiText;
		}

		// Token: 0x020034CB RID: 13515
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174D6 RID: 95446
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
