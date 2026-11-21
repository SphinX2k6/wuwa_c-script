using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000676 RID: 1654
	public sealed class FLGUIDragDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009014 RID: 36884 RVA: 0x000D811A File Offset: 0x000D631A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDragDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x000D8126 File Offset: 0x000D6326
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDragDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDragDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDragDelegateOneParams__DelegateSignature");
			}
			return FLGUIDragDelegateOneParams._FunctionPtr;
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x000D8149 File Offset: 0x000D6349
		public FLGUIDragDelegateOneParams()
		{
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x000D8151 File Offset: 0x000D6351
		[NullableContext(2)]
		public FLGUIDragDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x000D815B File Offset: 0x000D635B
		public FLGUIDragDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x000D8166 File Offset: 0x000D6366
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x000D8198 File Offset: 0x000D6398
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

		// Token: 0x0600901B RID: 36891 RVA: 0x000D81D4 File Offset: 0x000D63D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDragDelegateOneParams.__FLGUIDragDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDragDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x000D8228 File Offset: 0x000D6428
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003EFB RID: 16123
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EFC RID: 16124
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDragDelegateOneParams__DelegateSignature";

		// Token: 0x04003EFD RID: 16125
		private static int RegisterId;

		// Token: 0x02000E81 RID: 3713
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDragDelegateOneParams_DelegateParams
		{
			// Token: 0x0400622E RID: 25134
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0400622F RID: 25135
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000E82 RID: 3714
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006230 RID: 25136
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
