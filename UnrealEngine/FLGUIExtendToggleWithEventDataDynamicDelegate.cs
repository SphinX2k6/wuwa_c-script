using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000698 RID: 1688
	public sealed class FLGUIExtendToggleWithEventDataDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009192 RID: 37266 RVA: 0x000DB0EA File Offset: 0x000D92EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleWithEventDataDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x000DB0F6 File Offset: 0x000D92F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleWithEventDataDynamicDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleWithEventDataDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x000DB119 File Offset: 0x000D9319
		public FLGUIExtendToggleWithEventDataDynamicDelegate()
		{
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x000DB121 File Offset: 0x000D9321
		[NullableContext(2)]
		public FLGUIExtendToggleWithEventDataDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x000DB12B File Offset: 0x000D932B
		public FLGUIExtendToggleWithEventDataDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x000DB136 File Offset: 0x000D9336
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleState, ULGUIPointerEventData>) ?? ((Action<EToggleState, ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<EToggleState, ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x000DB168 File Offset: 0x000D9368
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<EToggleState, ULGUIPointerEventData> Callback)
		{
			if (FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleWithEventDataDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleWithEventDataDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleWithEventDataDynamicDelegate.OnScriptCallback));
				}
				FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleWithEventDataDynamicDelegate.RegisterId);
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x000DB1A4 File Offset: 0x000D93A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(EToggleState State, ULGUIPointerEventData eventData)
		{
			FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleWithEventDataDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x000DB1F8 File Offset: 0x000D93F8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState, ULGUIPointerEventData> action = target as Action<EToggleState, ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams*)__Parameters)->eventData);
			action(((FLGUIExtendToggleWithEventDataDynamicDelegate.__FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams*)__Parameters)->State, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003F75 RID: 16245
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F76 RID: 16246
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleWithEventDataDynamicDelegate__DelegateSignature";

		// Token: 0x04003F77 RID: 16247
		private static int RegisterId;

		// Token: 0x02000EBF RID: 3775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIExtendToggleWithEventDataDynamicDelegate_DelegateParams
		{
			// Token: 0x04006275 RID: 25205
			[FieldOffset(0)]
			public EToggleState State;

			// Token: 0x04006276 RID: 25206
			[FieldOffset(8)]
			public IntPtr eventData;
		}

		// Token: 0x02000EC0 RID: 3776
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006277 RID: 25207
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
