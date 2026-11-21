using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C3 RID: 1731
	public sealed class FLGUITextGmReplaceFontDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009400 RID: 37888 RVA: 0x000DF1BF File Offset: 0x000DD3BF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextGmReplaceFontDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x000DF1CB File Offset: 0x000DD3CB
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextGmReplaceFontDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextGmReplaceFontDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextGmReplaceFontDelegate__DelegateSignature");
			}
			return FLGUITextGmReplaceFontDelegate._FunctionPtr;
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x000DF1EE File Offset: 0x000DD3EE
		public FLGUITextGmReplaceFontDelegate()
		{
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x000DF1F6 File Offset: 0x000DD3F6
		[NullableContext(2)]
		public FLGUITextGmReplaceFontDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x000DF200 File Offset: 0x000DD400
		public FLGUITextGmReplaceFontDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x000DF20B File Offset: 0x000DD40B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIText>) ?? ((Action<UUIText>)Delegate.CreateDelegate(typeof(Action<UUIText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x000DF23D File Offset: 0x000DD43D
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

		// Token: 0x06009407 RID: 37895 RVA: 0x000DF278 File Offset: 0x000DD478
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUIText uiText)
		{
			FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams* ptr = stackalloc FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUITextGmReplaceFontDelegate.__FLGUITextGmReplaceFontDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextGmReplaceFontDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x000DF2C4 File Offset: 0x000DD4C4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400407E RID: 16510
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400407F RID: 16511
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextGmReplaceFontDelegate__DelegateSignature";

		// Token: 0x04004080 RID: 16512
		private static int RegisterId;

		// Token: 0x02000EF2 RID: 3826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUITextGmReplaceFontDelegate_DelegateParams
		{
			// Token: 0x040062B5 RID: 25269
			[FieldOffset(0)]
			public IntPtr uiText;
		}

		// Token: 0x02000EF3 RID: 3827
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062B6 RID: 25270
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
