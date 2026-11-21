using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A9 RID: 1705
	public sealed class FLGUIOnScrollTriggeredDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009286 RID: 37510 RVA: 0x000DCC98 File Offset: 0x000DAE98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIOnScrollTriggeredDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x000DCCA4 File Offset: 0x000DAEA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIOnScrollTriggeredDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIOnScrollTriggeredDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIOnScrollTriggeredDelegate__DelegateSignature");
			}
			return FLGUIOnScrollTriggeredDelegate._FunctionPtr;
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x000DCCC7 File Offset: 0x000DAEC7
		public FLGUIOnScrollTriggeredDelegate()
		{
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x000DCCCF File Offset: 0x000DAECF
		[NullableContext(2)]
		public FLGUIOnScrollTriggeredDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x000DCCD9 File Offset: 0x000DAED9
		public FLGUIOnScrollTriggeredDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x000DCCE4 File Offset: 0x000DAEE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x000DCD16 File Offset: 0x000DAF16
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIOnScrollTriggeredDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIOnScrollTriggeredDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIOnScrollTriggeredDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIOnScrollTriggeredDelegate.OnScriptCallback));
				}
				FLGUIOnScrollTriggeredDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIOnScrollTriggeredDelegate.RegisterId);
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x000DCD50 File Offset: 0x000DAF50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIPointerEventData eventData)
		{
			FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams* ptr = stackalloc FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIOnScrollTriggeredDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x000DCD9C File Offset: 0x000DAF9C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIPointerEventData> action = target as Action<ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIOnScrollTriggeredDelegate.__FLGUIOnScrollTriggeredDelegate_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04003FE4 RID: 16356
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FE5 RID: 16357
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIOnScrollTriggeredDelegate__DelegateSignature";

		// Token: 0x04003FE6 RID: 16358
		private static int RegisterId;

		// Token: 0x02000ED5 RID: 3797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIOnScrollTriggeredDelegate_DelegateParams
		{
			// Token: 0x04006295 RID: 25237
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000ED6 RID: 3798
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006296 RID: 25238
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
