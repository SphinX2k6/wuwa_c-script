using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B6 RID: 1718
	public sealed class FLGUIScrollbarDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600938C RID: 37772 RVA: 0x000DE20A File Offset: 0x000DC40A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollbarDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x000DE216 File Offset: 0x000DC416
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollbarDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollbarDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollbarDelegate__DelegateSignature");
			}
			return FLGUIScrollbarDelegate._FunctionPtr;
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x000DE239 File Offset: 0x000DC439
		public FLGUIScrollbarDelegate()
		{
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x000DE241 File Offset: 0x000DC441
		[NullableContext(2)]
		public FLGUIScrollbarDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x000DE24B File Offset: 0x000DC44B
		public FLGUIScrollbarDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x000DE256 File Offset: 0x000DC456
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIScrollbarComponent, bool>) ?? ((Action<UUIScrollbarComponent, bool>)Delegate.CreateDelegate(typeof(Action<UUIScrollbarComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x000DE288 File Offset: 0x000DC488
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIScrollbarComponent, bool> Callback)
		{
			if (FLGUIScrollbarDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollbarDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollbarDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollbarDelegate.OnScriptCallback));
				}
				FLGUIScrollbarDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollbarDelegate.RegisterId);
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x000DE2C4 File Offset: 0x000DC4C4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUIScrollbarComponent ScrollbarComponent, bool ativeOrInactive)
		{
			FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams* ptr = stackalloc FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollbarDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScrollbarComponent = ((ScrollbarComponent != null) ? ScrollbarComponent.NativePtr : IntPtr.Zero);
			ptr->ativeOrInactive = ativeOrInactive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x000DE318 File Offset: 0x000DC518
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIScrollbarComponent, bool> action = target as Action<UUIScrollbarComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIScrollbarComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIScrollbarComponent>(((FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams*)__Parameters)->ScrollbarComponent);
			action(orCreateUObjectByNativePointer, ((FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams*)__Parameters)->ativeOrInactive);
		}

		// Token: 0x04004057 RID: 16471
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004058 RID: 16472
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollbarDelegate__DelegateSignature";

		// Token: 0x04004059 RID: 16473
		private static int RegisterId;

		// Token: 0x02000EDC RID: 3804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIScrollbarDelegate_DelegateParams
		{
			// Token: 0x0400629C RID: 25244
			[FieldOffset(0)]
			public IntPtr ScrollbarComponent;

			// Token: 0x0400629D RID: 25245
			[FieldOffset(8)]
			public bool ativeOrInactive;
		}

		// Token: 0x02000EDD RID: 3805
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400629E RID: 25246
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
