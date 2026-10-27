using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A8 RID: 8360
	public sealed class FLGUIPointerEventDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F85F RID: 129119 RVA: 0x002ED9F5 File Offset: 0x002EBBF5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPointerEventDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F860 RID: 129120 RVA: 0x002EDA01 File Offset: 0x002EBC01
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPointerEventDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPointerEventDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPointerEventDynamicDelegate__DelegateSignature");
			}
			return FLGUIPointerEventDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F861 RID: 129121 RVA: 0x002EDA24 File Offset: 0x002EBC24
		public FLGUIPointerEventDynamicDelegate()
		{
		}

		// Token: 0x0601F862 RID: 129122 RVA: 0x002EDA2C File Offset: 0x002EBC2C
		[NullableContext(2)]
		public FLGUIPointerEventDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F863 RID: 129123 RVA: 0x002EDA36 File Offset: 0x002EBC36
		public FLGUIPointerEventDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F864 RID: 129124 RVA: 0x002EDA41 File Offset: 0x002EBC41
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F865 RID: 129125 RVA: 0x002EDA73 File Offset: 0x002EBC73
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIPointerEventDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPointerEventDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPointerEventDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPointerEventDynamicDelegate.OnScriptCallback));
				}
				FLGUIPointerEventDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPointerEventDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F866 RID: 129126 RVA: 0x002EDAB0 File Offset: 0x002EBCB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData pointerEventData)
		{
			FLGUIPointerEventDynamicDelegate.__FLGUIPointerEventDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIPointerEventDynamicDelegate.__FLGUIPointerEventDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIPointerEventDynamicDelegate.__FLGUIPointerEventDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIPointerEventDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->pointerEventData = ((pointerEventData != null) ? pointerEventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F867 RID: 129127 RVA: 0x002EDAFC File Offset: 0x002EBCFC
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIPointerEventDynamicDelegate.__FLGUIPointerEventDynamicDelegate_DelegateParams*)__Parameters)->pointerEventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401104B RID: 69707
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401104C RID: 69708
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerEventDynamicDelegate__DelegateSignature";

		// Token: 0x0401104D RID: 69709
		private static int RegisterId;

		// Token: 0x020034A6 RID: 13478
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIPointerEventDynamicDelegate_DelegateParams
		{
			// Token: 0x040174A9 RID: 95401
			[FieldOffset(0)]
			public IntPtr pointerEventData;
		}

		// Token: 0x020034A7 RID: 13479
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174AA RID: 95402
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
