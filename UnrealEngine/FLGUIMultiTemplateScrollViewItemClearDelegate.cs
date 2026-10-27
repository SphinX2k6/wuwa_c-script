using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208B RID: 8331
	public sealed class FLGUIMultiTemplateScrollViewItemClearDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F6DF RID: 128735 RVA: 0x002EAEA6 File Offset: 0x002E90A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemClearDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F6E0 RID: 128736 RVA: 0x002EAEB2 File Offset: 0x002E90B2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemClearDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemClearDelegate._FunctionPtr;
		}

		// Token: 0x0601F6E1 RID: 128737 RVA: 0x002EAED5 File Offset: 0x002E90D5
		public FLGUIMultiTemplateScrollViewItemClearDelegate()
		{
		}

		// Token: 0x0601F6E2 RID: 128738 RVA: 0x002EAEDD File Offset: 0x002E90DD
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemClearDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6E3 RID: 128739 RVA: 0x002EAEE7 File Offset: 0x002E90E7
		public FLGUIMultiTemplateScrollViewItemClearDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6E4 RID: 128740 RVA: 0x002EAEF2 File Offset: 0x002E90F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F6E5 RID: 128741 RVA: 0x002EAF24 File Offset: 0x002E9124
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F6E6 RID: 128742 RVA: 0x002EAF60 File Offset: 0x002E9160
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemClearDelegate.__FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemClearDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F6E7 RID: 128743 RVA: 0x002EAFB4 File Offset: 0x002E91B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010F9D RID: 69533
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F9E RID: 69534
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemClearDelegate__DelegateSignature";

		// Token: 0x04010F9F RID: 69535
		private static int RegisterId;

		// Token: 0x0200348A RID: 13450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIMultiTemplateScrollViewItemClearDelegate_DelegateParams
		{
			// Token: 0x0401747A RID: 95354
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x0401747B RID: 95355
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x0200348B RID: 13451
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401747C RID: 95356
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
