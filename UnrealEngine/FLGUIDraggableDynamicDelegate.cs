using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002037 RID: 8247
	public sealed class FLGUIDraggableDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F321 RID: 127777 RVA: 0x002E5092 File Offset: 0x002E3292
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F322 RID: 127778 RVA: 0x002E509E File Offset: 0x002E329E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableDynamicDelegate__DelegateSignature");
			}
			return FLGUIDraggableDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F323 RID: 127779 RVA: 0x002E50C1 File Offset: 0x002E32C1
		public FLGUIDraggableDynamicDelegate()
		{
		}

		// Token: 0x0601F324 RID: 127780 RVA: 0x002E50C9 File Offset: 0x002E32C9
		[NullableContext(2)]
		public FLGUIDraggableDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F325 RID: 127781 RVA: 0x002E50D3 File Offset: 0x002E32D3
		public FLGUIDraggableDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F326 RID: 127782 RVA: 0x002E50DE File Offset: 0x002E32DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F327 RID: 127783 RVA: 0x002E5110 File Offset: 0x002E3310
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIDraggableDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableDynamicDelegate.OnScriptCallback));
				}
				FLGUIDraggableDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F328 RID: 127784 RVA: 0x002E514C File Offset: 0x002E334C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F329 RID: 127785 RVA: 0x002E5198 File Offset: 0x002E3398
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010E26 RID: 69158
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E27 RID: 69159
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableDynamicDelegate__DelegateSignature";

		// Token: 0x04010E28 RID: 69160
		private static int RegisterId;

		// Token: 0x02003440 RID: 13376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDraggableDynamicDelegate_DelegateParams
		{
			// Token: 0x04017422 RID: 95266
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02003441 RID: 13377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017423 RID: 95267
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
