using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A4 RID: 1700
	public sealed class FLGUIMultiTemplateScrollViewItemClearDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009259 RID: 37465 RVA: 0x000DC65C File Offset: 0x000DA85C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemClearDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x000DC668 File Offset: 0x000DA868
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemClearDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr;
		}

		// Token: 0x0600925B RID: 37467 RVA: 0x000DC68B File Offset: 0x000DA88B
		public FLGUIMultiTemplateScrollViewItemClearDelegate()
		{
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x000DC693 File Offset: 0x000DA893
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemClearDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x000DC69D File Offset: 0x000DA89D
		public FLGUIMultiTemplateScrollViewItemClearDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x000DC6A8 File Offset: 0x000DA8A8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x000DC6DA File Offset: 0x000DA8DA
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIMultiTemplateScrollViewItemClearDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIMultiTemplateScrollViewItemClearDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIMultiTemplateScrollViewItemClearDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIMultiTemplateScrollViewItemClearDelegate.OnScriptCallback));
				}
				FLGUIMultiTemplateScrollViewItemClearDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIMultiTemplateScrollViewItemClearDelegate.RegisterId);
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x000DC714 File Offset: 0x000DA914
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemClearDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x000DC768 File Offset: 0x000DA968
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams*)__Parameters)->GridIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003FD3 RID: 16339
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FD4 RID: 16340
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemClearDelegate__DelegateSignature";

		// Token: 0x04003FD5 RID: 16341
		private static int RegisterId;

		// Token: 0x02000ECD RID: 3789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams
		{
			// Token: 0x04006289 RID: 25225
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x0400628A RID: 25226
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000ECE RID: 3790
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400628B RID: 25227
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
