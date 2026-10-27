using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200203B RID: 8251
	public sealed class FLGUIDraggableNeedInterruptDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F345 RID: 127813 RVA: 0x002E5546 File Offset: 0x002E3746
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNeedInterruptDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F346 RID: 127814 RVA: 0x002E5552 File Offset: 0x002E3752
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNeedInterruptDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNeedInterruptDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNeedInterruptDelegate__DelegateSignature");
			}
			return FLGUIDraggableNeedInterruptDelegate._FunctionPtr;
		}

		// Token: 0x0601F347 RID: 127815 RVA: 0x002E5575 File Offset: 0x002E3775
		public FLGUIDraggableNeedInterruptDelegate()
		{
		}

		// Token: 0x0601F348 RID: 127816 RVA: 0x002E557D File Offset: 0x002E377D
		[NullableContext(2)]
		public FLGUIDraggableNeedInterruptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F349 RID: 127817 RVA: 0x002E5587 File Offset: 0x002E3787
		public FLGUIDraggableNeedInterruptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F34A RID: 127818 RVA: 0x002E5592 File Offset: 0x002E3792
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIBaseEventData, bool>) ?? ((Func<ULGUIBaseEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIBaseEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F34B RID: 127819 RVA: 0x002E55C4 File Offset: 0x002E37C4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F34C RID: 127820 RVA: 0x002E5600 File Offset: 0x002E3800
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(ULGUIBaseEventData eventData)
		{
			FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams* ptr = stackalloc FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDraggableNeedInterruptDelegate.__FLGUIDraggableNeedInterruptDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableNeedInterruptDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F34D RID: 127821 RVA: 0x002E5654 File Offset: 0x002E3854
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010E32 RID: 69170
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E33 RID: 69171
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNeedInterruptDelegate__DelegateSignature";

		// Token: 0x04010E34 RID: 69172
		private static int RegisterId;

		// Token: 0x02003446 RID: 13382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDraggableNeedInterruptDelegate_DelegateParams
		{
			// Token: 0x04017429 RID: 95273
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0401742A RID: 95274
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02003447 RID: 13383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401742B RID: 95275
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
