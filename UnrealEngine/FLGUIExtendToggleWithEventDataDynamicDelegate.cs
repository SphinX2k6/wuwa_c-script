using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002076 RID: 8310
	public sealed class FLGUIExtendToggleWithEventDataDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F595 RID: 128405 RVA: 0x002E8FC2 File Offset: 0x002E71C2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleWithEventDataDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F596 RID: 128406 RVA: 0x002E8FCE File Offset: 0x002E71CE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleWithEventDataDynamicDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F597 RID: 128407 RVA: 0x002E8FF1 File Offset: 0x002E71F1
		public FLGUIExtendToggleWithEventDataDynamicDelegate()
		{
		}

		// Token: 0x0601F598 RID: 128408 RVA: 0x002E8FF9 File Offset: 0x002E71F9
		[NullableContext(2)]
		public FLGUIExtendToggleWithEventDataDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F599 RID: 128409 RVA: 0x002E9003 File Offset: 0x002E7203
		public FLGUIExtendToggleWithEventDataDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F59A RID: 128410 RVA: 0x002E900E File Offset: 0x002E720E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleState, ULGUIPointerEventData>) ?? ((Action<EToggleState, ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<EToggleState, ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F59B RID: 128411 RVA: 0x002E9040 File Offset: 0x002E7240
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<EToggleState, ULGUIPointerEventData> Callback)
		{
			if (FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleWithEventDataDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleWithEventDataDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleWithEventDataDynamicDelegate.OnScriptCallback));
				}
				FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F59C RID: 128412 RVA: 0x002E907C File Offset: 0x002E727C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EToggleState State, ULGUIPointerEventData eventData)
		{
			FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleWithEventDataDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F59D RID: 128413 RVA: 0x002E90D0 File Offset: 0x002E72D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState, ULGUIPointerEventData> action = target as Action<EToggleState, ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams*)__Parameters)->eventData);
			action(((FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams*)__Parameters)->State, orCreateUObjectByNativePointer);
		}

		// Token: 0x04010F08 RID: 69384
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F09 RID: 69385
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleWithEventDataDynamicDelegate__DelegateSignature";

		// Token: 0x04010F0A RID: 69386
		private static int RegisterId;

		// Token: 0x0200347C RID: 13436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams
		{
			// Token: 0x04017466 RID: 95334
			[FieldOffset(0)]
			public EToggleState State;

			// Token: 0x04017467 RID: 95335
			[FieldOffset(8)]
			public IntPtr eventData;
		}

		// Token: 0x0200347D RID: 13437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017468 RID: 95336
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
