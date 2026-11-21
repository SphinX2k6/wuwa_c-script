using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000697 RID: 1687
	public sealed class FLGUIExtendToggleDynamicDelegateOneParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009189 RID: 37257 RVA: 0x000DAF82 File Offset: 0x000D9182
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleDynamicDelegateOneParams.StaticFunctionPtr();
		}

		// Token: 0x0600918A RID: 37258 RVA: 0x000DAF8E File Offset: 0x000D918E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleDynamicDelegateOneParams__DelegateSignature");
			}
			return FLGUIExtendToggleDynamicDelegateOneParams._FunctionPtr;
		}

		// Token: 0x0600918B RID: 37259 RVA: 0x000DAFB1 File Offset: 0x000D91B1
		public FLGUIExtendToggleDynamicDelegateOneParams()
		{
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x000DAFB9 File Offset: 0x000D91B9
		[NullableContext(2)]
		public FLGUIExtendToggleDynamicDelegateOneParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x000DAFC3 File Offset: 0x000D91C3
		public FLGUIExtendToggleDynamicDelegateOneParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x000DAFCE File Offset: 0x000D91CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ULGUIPointerEventData, bool>) ?? ((Func<ULGUIPointerEventData, bool>)Delegate.CreateDelegate(typeof(Func<ULGUIPointerEventData, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600918F RID: 37263 RVA: 0x000DB000 File Offset: 0x000D9200
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

		// Token: 0x06009190 RID: 37264 RVA: 0x000DB03C File Offset: 0x000D923C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool Execute(ULGUIPointerEventData eventData)
		{
			FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams* ptr = stackalloc FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleDynamicDelegateOneParams.__FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleDynamicDelegateOneParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x000DB090 File Offset: 0x000D9290
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F72 RID: 16242
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F73 RID: 16243
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleDynamicDelegateOneParams__DelegateSignature";

		// Token: 0x04003F74 RID: 16244
		private static int RegisterId;

		// Token: 0x02000EBD RID: 3773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIExtendToggleDynamicDelegateOneParams_DelegateParams
		{
			// Token: 0x04006272 RID: 25202
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04006273 RID: 25203
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000EBE RID: 3774
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006274 RID: 25204
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
