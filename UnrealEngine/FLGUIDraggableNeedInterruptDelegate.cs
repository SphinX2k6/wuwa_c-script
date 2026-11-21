using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067B RID: 1659
	public sealed class FLGUIDraggableNeedInterruptDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009041 RID: 36929 RVA: 0x000D8736 File Offset: 0x000D6936
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNeedInterruptDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x000D8742 File Offset: 0x000D6942
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNeedInterruptDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNeedInterruptDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNeedInterruptDelegate__DelegateSignature");
			}
			return FLGUIDraggableNeedInterruptDelegate._FunctionPtr;
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x000D8765 File Offset: 0x000D6965
		public FLGUIDraggableNeedInterruptDelegate()
		{
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x000D876D File Offset: 0x000D696D
		[NullableContext(2)]
		public FLGUIDraggableNeedInterruptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x000D8777 File Offset: 0x000D6977
		public FLGUIDraggableNeedInterruptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x000D8782 File Offset: 0x000D6982
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIBaseEventData, bool>) ?? ((Func<ULGUIBaseEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIBaseEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x000D87B4 File Offset: 0x000D69B4
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<ULGUIBaseEventData, bool> Callback)
		{
			if (FLGUIDraggableNeedInterruptDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableNeedInterruptDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableNeedInterruptDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableNeedInterruptDelegate.OnScriptCallback));
				}
				FLGUIDraggableNeedInterruptDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableNeedInterruptDelegate.RegisterId);
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x000D87F0 File Offset: 0x000D69F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool Execute(ULGUIBaseEventData eventData)
		{
			FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams* ptr = stackalloc FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableNeedInterruptDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x000D8844 File Offset: 0x000D6A44
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ULGUIBaseEventData, bool> func = target as Func<ULGUIBaseEventData, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIBaseEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIBaseEventData>(((FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams*)__Parameters)->eventData);
			bool _Result = func(orCreateUObjectByNativePointer);
			((FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04003F0A RID: 16138
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F0B RID: 16139
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNeedInterruptDelegate__DelegateSignature";

		// Token: 0x04003F0C RID: 16140
		private static int RegisterId;

		// Token: 0x02000E89 RID: 3721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDraggableNeedInterruptDelegate_DelegateParams
		{
			// Token: 0x04006238 RID: 25144
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04006239 RID: 25145
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000E8A RID: 3722
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400623A RID: 25146
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
