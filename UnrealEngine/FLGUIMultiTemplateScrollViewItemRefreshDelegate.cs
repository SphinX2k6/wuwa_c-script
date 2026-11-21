using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A7 RID: 1703
	public sealed class FLGUIMultiTemplateScrollViewItemRefreshDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009274 RID: 37492 RVA: 0x000DCA72 File Offset: 0x000DAC72
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemRefreshDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x000DCA7E File Offset: 0x000DAC7E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemRefreshDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr;
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x000DCAA1 File Offset: 0x000DACA1
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate()
		{
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x000DCAA9 File Offset: 0x000DACA9
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x000DCAB3 File Offset: 0x000DACB3
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x000DCABE File Offset: 0x000DACBE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x000DCAF0 File Offset: 0x000DACF0
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIMultiTemplateScrollViewItemRefreshDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIMultiTemplateScrollViewItemRefreshDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIMultiTemplateScrollViewItemRefreshDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIMultiTemplateScrollViewItemRefreshDelegate.OnScriptCallback));
				}
				FLGUIMultiTemplateScrollViewItemRefreshDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIMultiTemplateScrollViewItemRefreshDelegate.RegisterId);
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x000DCB2C File Offset: 0x000DAD2C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemRefreshDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x000DCB80 File Offset: 0x000DAD80
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams*)__Parameters)->GridIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003FDC RID: 16348
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FDD RID: 16349
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemRefreshDelegate__DelegateSignature";

		// Token: 0x04003FDE RID: 16350
		private static int RegisterId;

		// Token: 0x02000ED3 RID: 3795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams
		{
			// Token: 0x04006292 RID: 25234
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x04006293 RID: 25235
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000ED4 RID: 3796
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006294 RID: 25236
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
