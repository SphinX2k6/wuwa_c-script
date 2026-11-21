using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C6 RID: 1734
	public sealed class FLGUITextTranslateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600941B RID: 37915 RVA: 0x000DF5E6 File Offset: 0x000DD7E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextTranslateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x000DF5F2 File Offset: 0x000DD7F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextTranslateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextTranslateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextTranslateDelegate__DelegateSignature");
			}
			return FLGUITextTranslateDelegate._FunctionPtr;
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x000DF615 File Offset: 0x000DD815
		public FLGUITextTranslateDelegate()
		{
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x000DF61D File Offset: 0x000DD81D
		[NullableContext(2)]
		public FLGUITextTranslateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x000DF627 File Offset: 0x000DD827
		public FLGUITextTranslateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x000DF632 File Offset: 0x000DD832
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIText>) ?? ((Action<UUIText>)Delegate.CreateDelegate(typeof(Action<UUIText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x000DF664 File Offset: 0x000DD864
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

		// Token: 0x06009422 RID: 37922 RVA: 0x000DF6A0 File Offset: 0x000DD8A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUIText uiText)
		{
			FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams* ptr = stackalloc FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUITextTranslateDelegate.__FLGUITextTranslateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextTranslateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->uiText = ((uiText != null) ? uiText.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x000DF6EC File Offset: 0x000DD8EC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004087 RID: 16519
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004088 RID: 16520
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextTranslateDelegate__DelegateSignature";

		// Token: 0x04004089 RID: 16521
		private static int RegisterId;

		// Token: 0x02000EF8 RID: 3832
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUITextTranslateDelegate_DelegateParams
		{
			// Token: 0x040062BC RID: 25276
			[FieldOffset(0)]
			public IntPtr uiText;
		}

		// Token: 0x02000EF9 RID: 3833
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062BD RID: 25277
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
