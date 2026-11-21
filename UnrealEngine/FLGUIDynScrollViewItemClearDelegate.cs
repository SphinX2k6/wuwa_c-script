using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068E RID: 1678
	public sealed class FLGUIDynScrollViewItemClearDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090EC RID: 37100 RVA: 0x000D9F82 File Offset: 0x000D8182
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemClearDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x000D9F8E File Offset: 0x000D818E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemClearDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemClearDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemClearDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemClearDelegate._FunctionPtr;
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x000D9FB1 File Offset: 0x000D81B1
		public FLGUIDynScrollViewItemClearDelegate()
		{
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x000D9FB9 File Offset: 0x000D81B9
		[NullableContext(2)]
		public FLGUIDynScrollViewItemClearDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x000D9FC3 File Offset: 0x000D81C3
		public FLGUIDynScrollViewItemClearDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x000D9FCE File Offset: 0x000D81CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x000DA000 File Offset: 0x000D8200
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

		// Token: 0x060090F3 RID: 37107 RVA: 0x000DA03C File Offset: 0x000D823C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int Index, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDynScrollViewItemClearDelegate.__FLGUIDynScrollViewItemClearDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemClearDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x000DA090 File Offset: 0x000D8290
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F43 RID: 16195
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F44 RID: 16196
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemClearDelegate__DelegateSignature";

		// Token: 0x04003F45 RID: 16197
		private static int RegisterId;

		// Token: 0x02000EAF RID: 3759
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDynScrollViewItemClearDelegate_DelegateParams
		{
			// Token: 0x0400625E RID: 25182
			[FieldOffset(0)]
			public int Index;

			// Token: 0x0400625F RID: 25183
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000EB0 RID: 3760
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006260 RID: 25184
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
