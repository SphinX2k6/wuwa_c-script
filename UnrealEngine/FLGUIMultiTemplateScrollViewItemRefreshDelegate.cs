using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208E RID: 8334
	public sealed class FLGUIMultiTemplateScrollViewItemRefreshDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F6FA RID: 128762 RVA: 0x002EB2BE File Offset: 0x002E94BE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemRefreshDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F6FB RID: 128763 RVA: 0x002EB2CA File Offset: 0x002E94CA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemRefreshDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemRefreshDelegate._FunctionPtr;
		}

		// Token: 0x0601F6FC RID: 128764 RVA: 0x002EB2ED File Offset: 0x002E94ED
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate()
		{
		}

		// Token: 0x0601F6FD RID: 128765 RVA: 0x002EB2F5 File Offset: 0x002E94F5
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6FE RID: 128766 RVA: 0x002EB2FF File Offset: 0x002E94FF
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6FF RID: 128767 RVA: 0x002EB30A File Offset: 0x002E950A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F700 RID: 128768 RVA: 0x002EB33C File Offset: 0x002E953C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F701 RID: 128769 RVA: 0x002EB378 File Offset: 0x002E9578
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemRefreshDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F702 RID: 128770 RVA: 0x002EB3CC File Offset: 0x002E95CC
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
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIMultiTemplateScrollViewItemRefreshDelegate.__FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams*)__Parameters)->GridIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04010FA6 RID: 69542
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FA7 RID: 69543
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemRefreshDelegate__DelegateSignature";

		// Token: 0x04010FA8 RID: 69544
		private static int RegisterId;

		// Token: 0x02003490 RID: 13456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIMultiTemplateScrollViewItemRefreshDelegate_DelegateParams
		{
			// Token: 0x04017483 RID: 95363
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x04017484 RID: 95364
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02003491 RID: 13457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017485 RID: 95365
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
