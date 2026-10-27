using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200202C RID: 8236
	public sealed class FLGUIButtonDynamicDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F198 RID: 127384 RVA: 0x002E36EA File Offset: 0x002E18EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonDynamicDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x0601F199 RID: 127385 RVA: 0x002E36F6 File Offset: 0x002E18F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonDynamicDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonDynamicDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonDynamicDelegateOneParams__DelegateSignature");
			}
			return FLGUIButtonDynamicDelegateOneParams._FunctionPtr;
		}

		// Token: 0x0601F19A RID: 127386 RVA: 0x002E3719 File Offset: 0x002E1919
		public FLGUIButtonDynamicDelegateOneParams()
		{
		}

		// Token: 0x0601F19B RID: 127387 RVA: 0x002E3721 File Offset: 0x002E1921
		[NullableContext(2)]
		public FLGUIButtonDynamicDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F19C RID: 127388 RVA: 0x002E372B File Offset: 0x002E192B
		public FLGUIButtonDynamicDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F19D RID: 127389 RVA: 0x002E3736 File Offset: 0x002E1936
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F19E RID: 127390 RVA: 0x002E3768 File Offset: 0x002E1968
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<ULGUIPointerEventData, bool> Callback)
		{
			if (FLGUIButtonDynamicDelegateOneParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonDynamicDelegateOneParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonDynamicDelegateOneParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonDynamicDelegateOneParams.OnScriptCallback));
				}
				FLGUIButtonDynamicDelegateOneParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonDynamicDelegateOneParams.RegisterId);
		}

		// Token: 0x0601F19F RID: 127391 RVA: 0x002E37A4 File Offset: 0x002E19A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonDynamicDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F1A0 RID: 127392 RVA: 0x002E37F8 File Offset: 0x002E19F8
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
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams*)__Parameters)->eventData);
			bool _Result = func(orCreateUObjectByNativePointer);
			((FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04010DB1 RID: 69041
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010DB2 RID: 69042
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonDynamicDelegateOneParams__DelegateSignature";

		// Token: 0x04010DB3 RID: 69043
		private static int RegisterId;

		// Token: 0x0200343A RID: 13370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIButtonDynamicDelegateOneParams_DelegateParams
		{
			// Token: 0x0401741A RID: 95258
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0401741B RID: 95259
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200343B RID: 13371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401741C RID: 95260
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
