using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015FE RID: 5630
	public sealed class FOnSubtreeDeactivatedDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014432 RID: 82994 RVA: 0x001DC58B File Offset: 0x001DA78B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSubtreeDeactivatedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06014433 RID: 82995 RVA: 0x001DC597 File Offset: 0x001DA797
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSubtreeDeactivatedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnSubtreeDeactivatedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAI.OnSubtreeDeactivatedDynamic__DelegateSignature");
			}
			return FOnSubtreeDeactivatedDynamic._FunctionPtr;
		}

		// Token: 0x06014434 RID: 82996 RVA: 0x001DC5BA File Offset: 0x001DA7BA
		public FOnSubtreeDeactivatedDynamic()
		{
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x001DC5C2 File Offset: 0x001DA7C2
		[NullableContext(2)]
		public FOnSubtreeDeactivatedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x001DC5CC File Offset: 0x001DA7CC
		public FOnSubtreeDeactivatedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014437 RID: 82999 RVA: 0x001DC5D7 File Offset: 0x001DA7D7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UBehaviorTreeComponent, int>) ?? ((Action<UBehaviorTreeComponent, int>)Delegate.CreateDelegate(typeof(Action<UBehaviorTreeComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x001DC609 File Offset: 0x001DA809
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UBehaviorTreeComponent, int> Callback)
		{
			if (FOnSubtreeDeactivatedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSubtreeDeactivatedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSubtreeDeactivatedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSubtreeDeactivatedDynamic.OnScriptCallback));
				}
				FOnSubtreeDeactivatedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSubtreeDeactivatedDynamic.RegisterId);
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x001DC644 File Offset: 0x001DA844
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UBehaviorTreeComponent OwnerComp, int NodeId)
		{
			FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams* ptr = stackalloc FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSubtreeDeactivatedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerComp = ((OwnerComp != null) ? OwnerComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601443A RID: 83002 RVA: 0x001DC698 File Offset: 0x001DA898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UBehaviorTreeComponent, int> action = target as Action<UBehaviorTreeComponent, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UBehaviorTreeComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBehaviorTreeComponent>(((FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams*)__Parameters)->OwnerComp);
			action(orCreateUObjectByNativePointer, ((FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams*)__Parameters)->NodeId);
		}

		// Token: 0x0400B063 RID: 45155
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B064 RID: 45156
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAI.OnSubtreeDeactivatedDynamic__DelegateSignature";

		// Token: 0x0400B065 RID: 45157
		private static int RegisterId;

		// Token: 0x02002ED9 RID: 11993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSubtreeDeactivatedDynamic_DelegateParams
		{
			// Token: 0x040169F6 RID: 92662
			[FieldOffset(0)]
			public IntPtr OwnerComp;

			// Token: 0x040169F7 RID: 92663
			[FieldOffset(8)]
			public int NodeId;
		}

		// Token: 0x02002EDA RID: 11994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169F8 RID: 92664
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
