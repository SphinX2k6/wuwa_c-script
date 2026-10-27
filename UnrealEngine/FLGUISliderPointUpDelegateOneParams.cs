using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C6 RID: 8390
	public sealed class FLGUISliderPointUpDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F9AD RID: 129453 RVA: 0x002EFE26 File Offset: 0x002EE026
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderPointUpDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x0601F9AE RID: 129454 RVA: 0x002EFE32 File Offset: 0x002EE032
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderPointUpDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderPointUpDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderPointUpDelegateOneParams__DelegateSignature");
			}
			return FLGUISliderPointUpDelegateOneParams._FunctionPtr;
		}

		// Token: 0x0601F9AF RID: 129455 RVA: 0x002EFE55 File Offset: 0x002EE055
		public FLGUISliderPointUpDelegateOneParams()
		{
		}

		// Token: 0x0601F9B0 RID: 129456 RVA: 0x002EFE5D File Offset: 0x002EE05D
		[NullableContext(2)]
		public FLGUISliderPointUpDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9B1 RID: 129457 RVA: 0x002EFE67 File Offset: 0x002EE067
		public FLGUISliderPointUpDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9B2 RID: 129458 RVA: 0x002EFE72 File Offset: 0x002EE072
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F9B3 RID: 129459 RVA: 0x002EFEA4 File Offset: 0x002EE0A4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUISliderPointUpDelegateOneParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISliderPointUpDelegateOneParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISliderPointUpDelegateOneParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISliderPointUpDelegateOneParams.OnScriptCallback));
				}
				FLGUISliderPointUpDelegateOneParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISliderPointUpDelegateOneParams.RegisterId);
		}

		// Token: 0x0601F9B4 RID: 129460 RVA: 0x002EFEE0 File Offset: 0x002EE0E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams* ptr = stackalloc FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISliderPointUpDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F9B5 RID: 129461 RVA: 0x002EFF2C File Offset: 0x002EE12C
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040110ED RID: 69869
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110EE RID: 69870
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderPointUpDelegateOneParams__DelegateSignature";

		// Token: 0x040110EF RID: 69871
		private static int RegisterId;

		// Token: 0x020034BF RID: 13503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUISliderPointUpDelegateOneParams_DelegateParams
		{
			// Token: 0x040174C8 RID: 95432
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x020034C0 RID: 13504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C9 RID: 95433
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
