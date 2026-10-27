using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200204B RID: 8267
	public sealed class FLGUIDrawableEvent_Float_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F3E1 RID: 127969 RVA: 0x002E6404 File Offset: 0x002E4604
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Float_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F3E2 RID: 127970 RVA: 0x002E6410 File Offset: 0x002E4610
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Float_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F3E3 RID: 127971 RVA: 0x002E6433 File Offset: 0x002E4633
		public FLGUIDrawableEvent_Float_DynamicDelegate()
		{
		}

		// Token: 0x0601F3E4 RID: 127972 RVA: 0x002E643B File Offset: 0x002E463B
		[NullableContext(2)]
		public FLGUIDrawableEvent_Float_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3E5 RID: 127973 RVA: 0x002E6445 File Offset: 0x002E4645
		public FLGUIDrawableEvent_Float_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3E6 RID: 127974 RVA: 0x002E6450 File Offset: 0x002E4650
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F3E7 RID: 127975 RVA: 0x002E6482 File Offset: 0x002E4682
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Float_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Float_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Float_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F3E8 RID: 127976 RVA: 0x002E64BC File Offset: 0x002E46BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float value)
		{
			FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Float_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F3E9 RID: 127977 RVA: 0x002E64FC File Offset: 0x002E46FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E82 RID: 69250
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E83 RID: 69251
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Float_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E84 RID: 69252
		private static int RegisterId;

		// Token: 0x02003452 RID: 13394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017435 RID: 95285
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x02003453 RID: 13395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017436 RID: 95286
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
