using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002069 RID: 8297
	public sealed class FLGUIDynScrollViewItemClearDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4DE RID: 128222 RVA: 0x002E7C7E File Offset: 0x002E5E7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemClearDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4DF RID: 128223 RVA: 0x002E7C8A File Offset: 0x002E5E8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemClearDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemClearDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemClearDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemClearDelegate._FunctionPtr;
		}

		// Token: 0x0601F4E0 RID: 128224 RVA: 0x002E7CAD File Offset: 0x002E5EAD
		public FLGUIDynScrollViewItemClearDelegate()
		{
		}

		// Token: 0x0601F4E1 RID: 128225 RVA: 0x002E7CB5 File Offset: 0x002E5EB5
		[NullableContext(2)]
		public FLGUIDynScrollViewItemClearDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4E2 RID: 128226 RVA: 0x002E7CBF File Offset: 0x002E5EBF
		public FLGUIDynScrollViewItemClearDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4E3 RID: 128227 RVA: 0x002E7CCA File Offset: 0x002E5ECA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4E4 RID: 128228 RVA: 0x002E7CFC File Offset: 0x002E5EFC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIDynScrollViewItemClearDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDynScrollViewItemClearDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDynScrollViewItemClearDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDynScrollViewItemClearDelegate.OnScriptCallback));
				}
				FLGUIDynScrollViewItemClearDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDynScrollViewItemClearDelegate.RegisterId);
		}

		// Token: 0x0601F4E5 RID: 128229 RVA: 0x002E7D38 File Offset: 0x002E5F38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Index, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemClearDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4E6 RID: 128230 RVA: 0x002E7D8C File Offset: 0x002E5F8C
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
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams*)__Parameters)->Index, orCreateUObjectByNativePointer);
		}

		// Token: 0x04010ECB RID: 69323
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010ECC RID: 69324
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemClearDelegate__DelegateSignature";

		// Token: 0x04010ECD RID: 69325
		private static int RegisterId;

		// Token: 0x0200346C RID: 13420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDynScrollViewItemClearDelegate_DelegateParams
		{
			// Token: 0x0401744F RID: 95311
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017450 RID: 95312
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x0200346D RID: 13421
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017451 RID: 95313
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
