using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002092 RID: 8338
	public sealed class FLGUIOnScrollTriggeredDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F71E RID: 128798 RVA: 0x002EB7C8 File Offset: 0x002E99C8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIOnScrollTriggeredDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F71F RID: 128799 RVA: 0x002EB7D4 File Offset: 0x002E99D4
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIOnScrollTriggeredDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIOnScrollTriggeredDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIOnScrollTriggeredDelegate__DelegateSignature");
			}
			return FLGUIOnScrollTriggeredDelegate._FunctionPtr;
		}

		// Token: 0x0601F720 RID: 128800 RVA: 0x002EB7F7 File Offset: 0x002E99F7
		public FLGUIOnScrollTriggeredDelegate()
		{
		}

		// Token: 0x0601F721 RID: 128801 RVA: 0x002EB7FF File Offset: 0x002E99FF
		[NullableContext(2)]
		public FLGUIOnScrollTriggeredDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F722 RID: 128802 RVA: 0x002EB809 File Offset: 0x002E9A09
		public FLGUIOnScrollTriggeredDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F723 RID: 128803 RVA: 0x002EB814 File Offset: 0x002E9A14
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F724 RID: 128804 RVA: 0x002EB846 File Offset: 0x002E9A46
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIOnScrollTriggeredDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIOnScrollTriggeredDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIOnScrollTriggeredDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIOnScrollTriggeredDelegate.OnScriptCallback));
				}
				FLGUIOnScrollTriggeredDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIOnScrollTriggeredDelegate.RegisterId);
		}

		// Token: 0x0601F725 RID: 128805 RVA: 0x002EB880 File Offset: 0x002E9A80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams* ptr = stackalloc FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIOnScrollTriggeredDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F726 RID: 128806 RVA: 0x002EB8CC File Offset: 0x002E9ACC
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010FB4 RID: 69556
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FB5 RID: 69557
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIOnScrollTriggeredDelegate__DelegateSignature";

		// Token: 0x04010FB6 RID: 69558
		private static int RegisterId;

		// Token: 0x02003496 RID: 13462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIOnScrollTriggeredDelegate_DelegateParams
		{
			// Token: 0x0401748E RID: 95374
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02003497 RID: 13463
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401748F RID: 95375
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
