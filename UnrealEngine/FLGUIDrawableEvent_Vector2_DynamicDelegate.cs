using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068B RID: 1675
	public sealed class FLGUIDrawableEvent_Vector2_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090D1 RID: 37073 RVA: 0x000D9BB6 File Offset: 0x000D7DB6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector2_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x000D9BC2 File Offset: 0x000D7DC2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector2_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x000D9BE5 File Offset: 0x000D7DE5
		public FLGUIDrawableEvent_Vector2_DynamicDelegate()
		{
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x000D9BED File Offset: 0x000D7DED
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector2_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x000D9BF7 File Offset: 0x000D7DF7
		public FLGUIDrawableEvent_Vector2_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x000D9C02 File Offset: 0x000D7E02
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x000D9C34 File Offset: 0x000D7E34
		[NullableContext(1)]
		public void Bind(Action<FVector2D> Callback)
		{
			if (FLGUIDrawableEvent_Vector2_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Vector2_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Vector2_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Vector2_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Vector2_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Vector2_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x000D9C70 File Offset: 0x000D7E70
		[SkipLocalsInit]
		public unsafe void Execute(FVector2D value)
		{
			FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector2_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F3A RID: 16186
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F3B RID: 16187
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector2_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F3C RID: 16188
		private static int RegisterId;

		// Token: 0x02000EA9 RID: 3753
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006258 RID: 25176
			[FieldOffset(0)]
			public FVector2D value;
		}

		// Token: 0x02000EAA RID: 3754
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006259 RID: 25177
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
