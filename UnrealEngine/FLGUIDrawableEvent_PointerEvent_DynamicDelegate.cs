using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002057 RID: 8279
	public sealed class FLGUIDrawableEvent_PointerEvent_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F446 RID: 128070 RVA: 0x002E6D9F File Offset: 0x002E4F9F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_PointerEvent_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F447 RID: 128071 RVA: 0x002E6DAB File Offset: 0x002E4FAB
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_PointerEvent_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_PointerEvent_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F448 RID: 128072 RVA: 0x002E6DCE File Offset: 0x002E4FCE
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate()
		{
		}

		// Token: 0x0601F449 RID: 128073 RVA: 0x002E6DD6 File Offset: 0x002E4FD6
		[NullableContext(2)]
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F44A RID: 128074 RVA: 0x002E6DE0 File Offset: 0x002E4FE0
		public FLGUIDrawableEvent_PointerEvent_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F44B RID: 128075 RVA: 0x002E6DEB File Offset: 0x002E4FEB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F44C RID: 128076 RVA: 0x002E6E1D File Offset: 0x002E501D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F44D RID: 128077 RVA: 0x002E6E58 File Offset: 0x002E5058
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData value)
		{
			FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_PointerEvent_DynamicDelegate.__FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_PointerEvent_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F44E RID: 128078 RVA: 0x002E6EA4 File Offset: 0x002E50A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010E9F RID: 69279
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EA0 RID: 69280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_PointerEvent_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EA1 RID: 69281
		private static int RegisterId;

		// Token: 0x0200345C RID: 13404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_PointerEvent_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401743F RID: 95295
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x0200345D RID: 13405
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017440 RID: 95296
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
