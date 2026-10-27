using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002064 RID: 8292
	public sealed class FLGUIDrawableEvent_Vector2_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4B3 RID: 128179 RVA: 0x002E77CC File Offset: 0x002E59CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector2_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4B4 RID: 128180 RVA: 0x002E77D8 File Offset: 0x002E59D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector2_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector2_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F4B5 RID: 128181 RVA: 0x002E77FB File Offset: 0x002E59FB
		public FLGUIDrawableEvent_Vector2_DynamicDelegate()
		{
		}

		// Token: 0x0601F4B6 RID: 128182 RVA: 0x002E7803 File Offset: 0x002E5A03
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector2_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4B7 RID: 128183 RVA: 0x002E780D File Offset: 0x002E5A0D
		public FLGUIDrawableEvent_Vector2_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4B8 RID: 128184 RVA: 0x002E7818 File Offset: 0x002E5A18
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4B9 RID: 128185 RVA: 0x002E784A File Offset: 0x002E5A4A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F4BA RID: 128186 RVA: 0x002E7884 File Offset: 0x002E5A84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FVector2D value)
		{
			FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector2_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4BB RID: 128187 RVA: 0x002E78C4 File Offset: 0x002E5AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Vector2_DynamicDelegate.__FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EBE RID: 69310
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EBF RID: 69311
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector2_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EC0 RID: 69312
		private static int RegisterId;

		// Token: 0x02003466 RID: 13414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_Vector2_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017449 RID: 95305
			[FieldOffset(0)]
			public FVector2D value;
		}

		// Token: 0x02003467 RID: 13415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401744A RID: 95306
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
