using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DE RID: 734
	public sealed class FOnSubtreeDeactivatedDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004EF3 RID: 20211 RVA: 0x0006EA03 File Offset: 0x0006CC03
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSubtreeDeactivatedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0006EA0F File Offset: 0x0006CC0F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSubtreeDeactivatedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnSubtreeDeactivatedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAI.OnSubtreeDeactivatedDynamic__DelegateSignature");
			}
			return FOnSubtreeDeactivatedDynamic._FunctionPtr;
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0006EA32 File Offset: 0x0006CC32
		public FOnSubtreeDeactivatedDynamic()
		{
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x0006EA3A File Offset: 0x0006CC3A
		[NullableContext(2)]
		public FOnSubtreeDeactivatedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x0006EA44 File Offset: 0x0006CC44
		public FOnSubtreeDeactivatedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x0006EA4F File Offset: 0x0006CC4F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UBehaviorTreeComponent, int>) ?? ((Action<UBehaviorTreeComponent, int>)Delegate.CreateDelegate(typeof(Action<UBehaviorTreeComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0006EA81 File Offset: 0x0006CC81
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

		// Token: 0x06004EFA RID: 20218 RVA: 0x0006EABC File Offset: 0x0006CCBC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UBehaviorTreeComponent OwnerComp, int NodeId)
		{
			FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams* ptr = stackalloc FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSubtreeDeactivatedDynamic.__FOnSubtreeDeactivatedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSubtreeDeactivatedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerComp = ((OwnerComp != null) ? OwnerComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0006EB10 File Offset: 0x0006CD10
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04001F9E RID: 8094
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F9F RID: 8095
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAI.OnSubtreeDeactivatedDynamic__DelegateSignature";

		// Token: 0x04001FA0 RID: 8096
		private static int RegisterId;

		// Token: 0x02000A12 RID: 2578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnSubtreeDeactivatedDynamic_DelegateParams
		{
			// Token: 0x040059D1 RID: 22993
			[FieldOffset(0)]
			public IntPtr OwnerComp;

			// Token: 0x040059D2 RID: 22994
			[FieldOffset(8)]
			public int NodeId;
		}

		// Token: 0x02000A13 RID: 2579
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D3 RID: 22995
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
