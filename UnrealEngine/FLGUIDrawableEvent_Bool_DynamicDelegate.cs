using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002042 RID: 8258
	public sealed class FLGUIDrawableEvent_Bool_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F395 RID: 127893 RVA: 0x002E5CE7 File Offset: 0x002E3EE7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Bool_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F396 RID: 127894 RVA: 0x002E5CF3 File Offset: 0x002E3EF3
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Bool_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Bool_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F397 RID: 127895 RVA: 0x002E5D16 File Offset: 0x002E3F16
		public FLGUIDrawableEvent_Bool_DynamicDelegate()
		{
		}

		// Token: 0x0601F398 RID: 127896 RVA: 0x002E5D1E File Offset: 0x002E3F1E
		[NullableContext(2)]
		public FLGUIDrawableEvent_Bool_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F399 RID: 127897 RVA: 0x002E5D28 File Offset: 0x002E3F28
		public FLGUIDrawableEvent_Bool_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F39A RID: 127898 RVA: 0x002E5D33 File Offset: 0x002E3F33
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F39B RID: 127899 RVA: 0x002E5D65 File Offset: 0x002E3F65
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F39C RID: 127900 RVA: 0x002E5DA0 File Offset: 0x002E3FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool value)
		{
			FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Bool_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F39D RID: 127901 RVA: 0x002E5DE0 File Offset: 0x002E3FE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Bool_DynamicDelegate.__FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E6C RID: 69228
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E6D RID: 69229
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Bool_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E6E RID: 69230
		private static int RegisterId;

		// Token: 0x0200344A RID: 13386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIDrawableEvent_Bool_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401742E RID: 95278
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x0200344B RID: 13387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401742F RID: 95279
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
