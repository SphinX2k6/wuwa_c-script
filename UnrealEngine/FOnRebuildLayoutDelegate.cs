using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D2 RID: 1746
	public sealed class FOnRebuildLayoutDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094C0 RID: 38080 RVA: 0x000E057A File Offset: 0x000DE77A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRebuildLayoutDelegate.StaticFunctionPtr();
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x000E0586 File Offset: 0x000DE786
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRebuildLayoutDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnRebuildLayoutDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnRebuildLayoutDelegate__DelegateSignature");
			}
			return FOnRebuildLayoutDelegate._FunctionPtr;
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x000E05A9 File Offset: 0x000DE7A9
		public FOnRebuildLayoutDelegate()
		{
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x000E05B1 File Offset: 0x000DE7B1
		[NullableContext(2)]
		public FOnRebuildLayoutDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x000E05BB File Offset: 0x000DE7BB
		public FOnRebuildLayoutDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x000E05C6 File Offset: 0x000DE7C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUILayoutBase>) ?? ((Action<UUILayoutBase>)Delegate.CreateDelegate(typeof(Action<UUILayoutBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x000E05F8 File Offset: 0x000DE7F8
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

		// Token: 0x060094C7 RID: 38087 RVA: 0x000E0634 File Offset: 0x000DE834
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUILayoutBase Layout)
		{
			FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams* ptr = stackalloc FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRebuildLayoutDelegate.__FOnRebuildLayoutDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRebuildLayoutDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Layout = ((Layout != null) ? Layout.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x000E0680 File Offset: 0x000DE880
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040040B4 RID: 16564
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040B5 RID: 16565
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnRebuildLayoutDelegate__DelegateSignature";

		// Token: 0x040040B6 RID: 16566
		private static int RegisterId;

		// Token: 0x02000F03 RID: 3843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnRebuildLayoutDelegate_DelegateParams
		{
			// Token: 0x040062CF RID: 25295
			[FieldOffset(0)]
			public IntPtr Layout;
		}

		// Token: 0x02000F04 RID: 3844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062D0 RID: 25296
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
