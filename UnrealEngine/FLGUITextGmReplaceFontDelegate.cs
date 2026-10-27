using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D0 RID: 8400
	public sealed class FLGUITextGmReplaceFontDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA55 RID: 129621 RVA: 0x002F0E27 File Offset: 0x002EF027
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextGmReplaceFontDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA56 RID: 129622 RVA: 0x002F0E33 File Offset: 0x002EF033
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextGmReplaceFontDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextGmReplaceFontDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextGmReplaceFontDelegate__DelegateSignature");
			}
			return FLGUITextGmReplaceFontDelegate._FunctionPtr;
		}

		// Token: 0x0601FA57 RID: 129623 RVA: 0x002F0E56 File Offset: 0x002EF056
		public FLGUITextGmReplaceFontDelegate()
		{
		}

		// Token: 0x0601FA58 RID: 129624 RVA: 0x002F0E5E File Offset: 0x002EF05E
		[NullableContext(2)]
		public FLGUITextGmReplaceFontDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA59 RID: 129625 RVA: 0x002F0E68 File Offset: 0x002EF068
		public FLGUITextGmReplaceFontDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA5A RID: 129626 RVA: 0x002F0E73 File Offset: 0x002EF073
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIText>) ?? ((Action<UUIText>)Delegate.CreateDelegate(typeof(Action<UUIText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA5B RID: 129627 RVA: 0x002F0EA5 File Offset: 0x002EF0A5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIText> Callback)
		{
			if (FLGUITextGmReplaceFontDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextGmReplaceFontDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextGmReplaceFontDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextGmReplaceFontDelegate.OnScriptCallback));
				}
				FLGUITextGmReplaceFontDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextGmReplaceFontDelegate.RegisterId);
		}

		// Token: 0x0601FA5C RID: 129628 RVA: 0x002F0EE0 File Offset: 0x002EF0E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUIText uiText)
		{
			FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams* ptr = stackalloc FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextGmReplaceFontDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FA5D RID: 129629 RVA: 0x002F0F2C File Offset: 0x002EF12C
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
			UUIText orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(((FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams*)__Parameters)->uiText);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401113B RID: 69947
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401113C RID: 69948
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextGmReplaceFontDelegate__DelegateSignature";

		// Token: 0x0401113D RID: 69949
		private static int RegisterId;

		// Token: 0x020034C4 RID: 13508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUITextGmReplaceFontDelegate_DelegateParams
		{
			// Token: 0x040174CE RID: 95438
			[FieldOffset(0)]
			public IntPtr uiText;
		}

		// Token: 0x020034C5 RID: 13509
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174CF RID: 95439
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
