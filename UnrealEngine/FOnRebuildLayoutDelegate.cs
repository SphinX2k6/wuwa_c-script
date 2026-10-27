using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F3 RID: 8435
	public sealed class FOnRebuildLayoutDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC15 RID: 130069 RVA: 0x002F3769 File Offset: 0x002F1969
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRebuildLayoutDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FC16 RID: 130070 RVA: 0x002F3775 File Offset: 0x002F1975
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRebuildLayoutDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnRebuildLayoutDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnRebuildLayoutDelegate__DelegateSignature");
			}
			return FOnRebuildLayoutDelegate._FunctionPtr;
		}

		// Token: 0x0601FC17 RID: 130071 RVA: 0x002F3798 File Offset: 0x002F1998
		public FOnRebuildLayoutDelegate()
		{
		}

		// Token: 0x0601FC18 RID: 130072 RVA: 0x002F37A0 File Offset: 0x002F19A0
		[NullableContext(2)]
		public FOnRebuildLayoutDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC19 RID: 130073 RVA: 0x002F37AA File Offset: 0x002F19AA
		public FOnRebuildLayoutDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC1A RID: 130074 RVA: 0x002F37B5 File Offset: 0x002F19B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUILayoutBase>) ?? ((Action<UUILayoutBase>)Delegate.CreateDelegate(typeof(Action<UUILayoutBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC1B RID: 130075 RVA: 0x002F37E7 File Offset: 0x002F19E7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUILayoutBase> Callback)
		{
			if (FOnRebuildLayoutDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRebuildLayoutDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRebuildLayoutDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRebuildLayoutDelegate.OnScriptCallback));
				}
				FOnRebuildLayoutDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnRebuildLayoutDelegate.RegisterId);
		}

		// Token: 0x0601FC1C RID: 130076 RVA: 0x002F3824 File Offset: 0x002F1A24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUILayoutBase Layout)
		{
			FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams* ptr = stackalloc FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRebuildLayoutDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Layout = ((Layout != null) ? Layout.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FC1D RID: 130077 RVA: 0x002F3870 File Offset: 0x002F1A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUILayoutBase> action = target as Action<UUILayoutBase>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUILayoutBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUILayoutBase>(((FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams*)__Parameters)->Layout);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040111E6 RID: 70118
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111E7 RID: 70119
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnRebuildLayoutDelegate__DelegateSignature";

		// Token: 0x040111E8 RID: 70120
		private static int RegisterId;

		// Token: 0x020034D7 RID: 13527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnRebuildLayoutDelegate_DelegateParams
		{
			// Token: 0x040174EA RID: 95466
			[FieldOffset(0)]
			public IntPtr Layout;
		}

		// Token: 0x020034D8 RID: 13528
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174EB RID: 95467
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
