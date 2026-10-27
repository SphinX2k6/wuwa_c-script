using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208C RID: 8332
	public sealed class FLGUIMultiTemplateScrollViewItemCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F6E8 RID: 128744 RVA: 0x002EB00B File Offset: 0x002E920B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F6E9 RID: 128745 RVA: 0x002EB017 File Offset: 0x002E9217
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemCreateDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr;
		}

		// Token: 0x0601F6EA RID: 128746 RVA: 0x002EB03A File Offset: 0x002E923A
		public FLGUIMultiTemplateScrollViewItemCreateDelegate()
		{
		}

		// Token: 0x0601F6EB RID: 128747 RVA: 0x002EB042 File Offset: 0x002E9242
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6EC RID: 128748 RVA: 0x002EB04C File Offset: 0x002E924C
		public FLGUIMultiTemplateScrollViewItemCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6ED RID: 128749 RVA: 0x002EB057 File Offset: 0x002E9257
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F6EE RID: 128750 RVA: 0x002EB089 File Offset: 0x002E9289
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIMultiTemplateScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIMultiTemplateScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIMultiTemplateScrollViewItemCreateDelegate.OnScriptCallback));
				}
				FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId);
		}

		// Token: 0x0601F6EF RID: 128751 RVA: 0x002EB0C4 File Offset: 0x002E92C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F6F0 RID: 128752 RVA: 0x002EB118 File Offset: 0x002E9318
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
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->GridIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04010FA0 RID: 69536
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FA1 RID: 69537
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemCreateDelegate__DelegateSignature";

		// Token: 0x04010FA2 RID: 69538
		private static int RegisterId;

		// Token: 0x0200348C RID: 13452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams
		{
			// Token: 0x0401747D RID: 95357
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x0401747E RID: 95358
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x0200348D RID: 13453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401747F RID: 95359
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
