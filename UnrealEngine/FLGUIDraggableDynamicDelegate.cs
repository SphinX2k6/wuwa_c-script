using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000677 RID: 1655
	public sealed class FLGUIDraggableDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600901D RID: 36893 RVA: 0x000D8282 File Offset: 0x000D6482
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x000D828E File Offset: 0x000D648E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableDynamicDelegate__DelegateSignature");
			}
			return FLGUIDraggableDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x000D82B1 File Offset: 0x000D64B1
		public FLGUIDraggableDynamicDelegate()
		{
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x000D82B9 File Offset: 0x000D64B9
		[NullableContext(2)]
		public FLGUIDraggableDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x000D82C3 File Offset: 0x000D64C3
		public FLGUIDraggableDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x000D82CE File Offset: 0x000D64CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x000D8300 File Offset: 0x000D6500
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

		// Token: 0x06009024 RID: 36900 RVA: 0x000D833C File Offset: 0x000D653C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDraggableDynamicDelegate.__FLGUIDraggableDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x000D8388 File Offset: 0x000D6588
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003EFE RID: 16126
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EFF RID: 16127
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableDynamicDelegate__DelegateSignature";

		// Token: 0x04003F00 RID: 16128
		private static int RegisterId;

		// Token: 0x02000E83 RID: 3715
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDraggableDynamicDelegate_DelegateParams
		{
			// Token: 0x04006231 RID: 25137
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000E84 RID: 3716
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006232 RID: 25138
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
