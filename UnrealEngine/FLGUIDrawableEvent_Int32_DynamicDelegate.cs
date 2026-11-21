using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000682 RID: 1666
	public sealed class FLGUIDrawableEvent_Int32_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009080 RID: 36992 RVA: 0x000D900E File Offset: 0x000D720E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Int32_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x000D901A File Offset: 0x000D721A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Int32_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x000D903D File Offset: 0x000D723D
		public FLGUIDrawableEvent_Int32_DynamicDelegate()
		{
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x000D9045 File Offset: 0x000D7245
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int32_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x000D904F File Offset: 0x000D724F
		public FLGUIDrawableEvent_Int32_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x000D905A File Offset: 0x000D725A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x000D908C File Offset: 0x000D728C
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Int32_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Int32_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Int32_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId);
		}

		// Token: 0x06009087 RID: 36999 RVA: 0x000D90C8 File Offset: 0x000D72C8
		[SkipLocalsInit]
		public unsafe void Execute(int value)
		{
			FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Int32_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x000D9108 File Offset: 0x000D7308
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F1F RID: 16159
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F20 RID: 16160
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int32_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F21 RID: 16161
		private static int RegisterId;

		// Token: 0x02000E97 RID: 3735
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006246 RID: 25158
			[FieldOffset(0)]
			public int value;
		}

		// Token: 0x02000E98 RID: 3736
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006247 RID: 25159
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
