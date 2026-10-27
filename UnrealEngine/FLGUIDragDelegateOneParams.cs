using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002036 RID: 8246
	public sealed class FLGUIDragDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F318 RID: 127768 RVA: 0x002E4F2A File Offset: 0x002E312A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDragDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x0601F319 RID: 127769 RVA: 0x002E4F36 File Offset: 0x002E3136
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDragDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDragDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDragDelegateOneParams__DelegateSignature");
			}
			return FLGUIDragDelegateOneParams._FunctionPtr;
		}

		// Token: 0x0601F31A RID: 127770 RVA: 0x002E4F59 File Offset: 0x002E3159
		public FLGUIDragDelegateOneParams()
		{
		}

		// Token: 0x0601F31B RID: 127771 RVA: 0x002E4F61 File Offset: 0x002E3161
		[NullableContext(2)]
		public FLGUIDragDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F31C RID: 127772 RVA: 0x002E4F6B File Offset: 0x002E316B
		public FLGUIDragDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F31D RID: 127773 RVA: 0x002E4F76 File Offset: 0x002E3176
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F31E RID: 127774 RVA: 0x002E4FA8 File Offset: 0x002E31A8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<ULGUIPointerEventData, bool> Callback)
		{
			if (FLGUIDragDelegateOneParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDragDelegateOneParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDragDelegateOneParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDragDelegateOneParams.OnScriptCallback));
				}
				FLGUIDragDelegateOneParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDragDelegateOneParams.RegisterId);
		}

		// Token: 0x0601F31F RID: 127775 RVA: 0x002E4FE4 File Offset: 0x002E31E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDragDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F320 RID: 127776 RVA: 0x002E5038 File Offset: 0x002E3238
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams*)__Parameters)->eventData);
			bool _Result = func(orCreateUObjectByNativePointer);
			((FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04010E23 RID: 69155
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E24 RID: 69156
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDragDelegateOneParams__DelegateSignature";

		// Token: 0x04010E25 RID: 69157
		private static int RegisterId;

		// Token: 0x0200343E RID: 13374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDragDelegateOneParams_DelegateParams
		{
			// Token: 0x0401741F RID: 95263
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017420 RID: 95264
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200343F RID: 13375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017421 RID: 95265
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
