using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002075 RID: 8309
	public sealed class FLGUIExtendToggleDynamicDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F58C RID: 128396 RVA: 0x002E8E5A File Offset: 0x002E705A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleDynamicDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x0601F58D RID: 128397 RVA: 0x002E8E66 File Offset: 0x002E7066
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleDynamicDelegateOneParams__DelegateSignature");
			}
			return FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr;
		}

		// Token: 0x0601F58E RID: 128398 RVA: 0x002E8E89 File Offset: 0x002E7089
		public FLGUIExtendToggleDynamicDelegateOneParams()
		{
		}

		// Token: 0x0601F58F RID: 128399 RVA: 0x002E8E91 File Offset: 0x002E7091
		[NullableContext(2)]
		public FLGUIExtendToggleDynamicDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F590 RID: 128400 RVA: 0x002E8E9B File Offset: 0x002E709B
		public FLGUIExtendToggleDynamicDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F591 RID: 128401 RVA: 0x002E8EA6 File Offset: 0x002E70A6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F592 RID: 128402 RVA: 0x002E8ED8 File Offset: 0x002E70D8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<ULGUIPointerEventData, bool> Callback)
		{
			if (FLGUIExtendToggleDynamicDelegateOneParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleDynamicDelegateOneParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleDynamicDelegateOneParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleDynamicDelegateOneParams.OnScriptCallback));
				}
				FLGUIExtendToggleDynamicDelegateOneParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleDynamicDelegateOneParams.RegisterId);
		}

		// Token: 0x0601F593 RID: 128403 RVA: 0x002E8F14 File Offset: 0x002E7114
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleDynamicDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F594 RID: 128404 RVA: 0x002E8F68 File Offset: 0x002E7168
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ULGUIPointerEventData, bool> func = target as Func<ULGUIPointerEventData, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams*)__Parameters)->eventData);
			bool _Result = func(orCreateUObjectByNativePointer);
			((FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04010F05 RID: 69381
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F06 RID: 69382
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleDynamicDelegateOneParams__DelegateSignature";

		// Token: 0x04010F07 RID: 69383
		private static int RegisterId;

		// Token: 0x0200347A RID: 13434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams
		{
			// Token: 0x04017463 RID: 95331
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017464 RID: 95332
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200347B RID: 13435
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017465 RID: 95333
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
