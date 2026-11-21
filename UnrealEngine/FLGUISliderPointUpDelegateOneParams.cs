using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BF RID: 1727
	public sealed class FLGUISliderPointUpDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093DD RID: 37853 RVA: 0x000DED86 File Offset: 0x000DCF86
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderPointUpDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x000DED92 File Offset: 0x000DCF92
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderPointUpDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderPointUpDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderPointUpDelegateOneParams__DelegateSignature");
			}
			return FLGUISliderPointUpDelegateOneParams._FunctionPtr;
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x000DEDB5 File Offset: 0x000DCFB5
		public FLGUISliderPointUpDelegateOneParams()
		{
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x000DEDBD File Offset: 0x000DCFBD
		[NullableContext(2)]
		public FLGUISliderPointUpDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x000DEDC7 File Offset: 0x000DCFC7
		public FLGUISliderPointUpDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x000DEDD2 File Offset: 0x000DCFD2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x000DEE04 File Offset: 0x000DD004
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

		// Token: 0x060093E4 RID: 37860 RVA: 0x000DEE40 File Offset: 0x000DD040
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams* ptr = stackalloc FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUISliderPointUpDelegateOneParams.__FLGUISliderPointUpDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISliderPointUpDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x000DEE8C File Offset: 0x000DD08C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004072 RID: 16498
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004073 RID: 16499
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderPointUpDelegateOneParams__DelegateSignature";

		// Token: 0x04004074 RID: 16500
		private static int RegisterId;

		// Token: 0x02000EED RID: 3821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUISliderPointUpDelegateOneParams_DelegateParams
		{
			// Token: 0x040062AF RID: 25263
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000EEE RID: 3822
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062B0 RID: 25264
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
