using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B8 RID: 1720
	public sealed class FLGUIScrollViewDownUp : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600939E RID: 37790 RVA: 0x000DE4B2 File Offset: 0x000DC6B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollViewDownUp.StaticFunctionPtr();
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x000DE4BE File Offset: 0x000DC6BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollViewDownUp._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollViewDownUp._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollViewDownUp__DelegateSignature");
			}
			return FLGUIScrollViewDownUp._FunctionPtr;
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x000DE4E1 File Offset: 0x000DC6E1
		public FLGUIScrollViewDownUp()
		{
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x000DE4E9 File Offset: 0x000DC6E9
		[NullableContext(2)]
		public FLGUIScrollViewDownUp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x000DE4F3 File Offset: 0x000DC6F3
		public FLGUIScrollViewDownUp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x000DE4FE File Offset: 0x000DC6FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x000DE530 File Offset: 0x000DC730
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIScrollViewDownUp.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollViewDownUp.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollViewDownUp.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollViewDownUp.OnScriptCallback));
				}
				FLGUIScrollViewDownUp.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollViewDownUp.RegisterId);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x000DE56C File Offset: 0x000DC76C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIPointerEventData EventData)
		{
			FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams* ptr = stackalloc FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollViewDownUp.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventData = ((EventData != null) ? EventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x000DE5B8 File Offset: 0x000DC7B8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIPointerEventData> action = target as Action<ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams*)__Parameters)->EventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400405D RID: 16477
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400405E RID: 16478
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollViewDownUp__DelegateSignature";

		// Token: 0x0400405F RID: 16479
		private static int RegisterId;

		// Token: 0x02000EE0 RID: 3808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIScrollViewDownUp_DelegateParams
		{
			// Token: 0x040062A1 RID: 25249
			[FieldOffset(0)]
			public IntPtr EventData;
		}

		// Token: 0x02000EE1 RID: 3809
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062A2 RID: 25250
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
