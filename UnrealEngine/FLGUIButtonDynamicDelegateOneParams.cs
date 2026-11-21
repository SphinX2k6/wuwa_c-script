using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000670 RID: 1648
	public sealed class FLGUIButtonDynamicDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008EFA RID: 36602 RVA: 0x000D6FD6 File Offset: 0x000D51D6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonDynamicDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x000D6FE2 File Offset: 0x000D51E2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonDynamicDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonDynamicDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonDynamicDelegateOneParams__DelegateSignature");
			}
			return FLGUIButtonDynamicDelegateOneParams._FunctionPtr;
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x000D7005 File Offset: 0x000D5205
		public FLGUIButtonDynamicDelegateOneParams()
		{
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x000D700D File Offset: 0x000D520D
		[NullableContext(2)]
		public FLGUIButtonDynamicDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x000D7017 File Offset: 0x000D5217
		public FLGUIButtonDynamicDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x000D7022 File Offset: 0x000D5222
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x000D7054 File Offset: 0x000D5254
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

		// Token: 0x06008F01 RID: 36609 RVA: 0x000D7090 File Offset: 0x000D5290
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIButtonDynamicDelegateOneParams.__FLGUIButtonDynamicDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonDynamicDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x000D70E4 File Offset: 0x000D52E4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003EAE RID: 16046
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EAF RID: 16047
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonDynamicDelegateOneParams__DelegateSignature";

		// Token: 0x04003EB0 RID: 16048
		private static int RegisterId;

		// Token: 0x02000E7D RID: 3709
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIButtonDynamicDelegateOneParams_DelegateParams
		{
			// Token: 0x04006229 RID: 25129
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0400622A RID: 25130
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000E7E RID: 3710
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400622B RID: 25131
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
