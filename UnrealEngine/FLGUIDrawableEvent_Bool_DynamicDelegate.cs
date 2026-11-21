using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067D RID: 1661
	public sealed class FLGUIDrawableEvent_Bool_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009053 RID: 36947 RVA: 0x000D89F5 File Offset: 0x000D6BF5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Bool_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x000D8A01 File Offset: 0x000D6C01
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Bool_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x000D8A24 File Offset: 0x000D6C24
		public FLGUIDrawableEvent_Bool_DynamicDelegate()
		{
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x000D8A2C File Offset: 0x000D6C2C
		[NullableContext(2)]
		public FLGUIDrawableEvent_Bool_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x000D8A36 File Offset: 0x000D6C36
		public FLGUIDrawableEvent_Bool_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x000D8A41 File Offset: 0x000D6C41
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x000D8A73 File Offset: 0x000D6C73
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIDrawableEvent_Bool_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Bool_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Bool_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Bool_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Bool_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Bool_DynamicDelegate.RegisterId);
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x000D8AB0 File Offset: 0x000D6CB0
		[SkipLocalsInit]
		public unsafe void Execute(bool value)
		{
			FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Bool_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x000D8AF0 File Offset: 0x000D6CF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F10 RID: 16144
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F11 RID: 16145
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Bool_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F12 RID: 16146
		private static int RegisterId;

		// Token: 0x02000E8D RID: 3725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400623D RID: 25149
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x02000E8E RID: 3726
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400623E RID: 25150
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
