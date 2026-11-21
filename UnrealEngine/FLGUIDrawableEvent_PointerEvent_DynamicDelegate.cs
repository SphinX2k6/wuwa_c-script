using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000686 RID: 1670
	public sealed class FLGUIDrawableEvent_PointerEvent_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090A4 RID: 37028 RVA: 0x000D9531 File Offset: 0x000D7731
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_PointerEvent_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x000D953D File Offset: 0x000D773D
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_PointerEvent_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090A6 RID: 37030 RVA: 0x000D9560 File Offset: 0x000D7760
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate()
		{
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x000D9568 File Offset: 0x000D7768
		[NullableContext(2)]
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x000D9572 File Offset: 0x000D7772
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090A9 RID: 37033 RVA: 0x000D957D File Offset: 0x000D777D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x000D95AF File Offset: 0x000D77AF
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIDrawableEvent_PointerEvent_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_PointerEvent_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_PointerEvent_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_PointerEvent_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_PointerEvent_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_PointerEvent_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x000D95EC File Offset: 0x000D77EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIPointerEventData value)
		{
			FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_PointerEvent_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x000D9638 File Offset: 0x000D7838
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIPointerEventData> action = target as Action<ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams*)__Parameters)->value);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04003F2B RID: 16171
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F2C RID: 16172
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_PointerEvent_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F2D RID: 16173
		private static int RegisterId;

		// Token: 0x02000E9F RID: 3743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400624E RID: 25166
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x02000EA0 RID: 3744
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400624F RID: 25167
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
