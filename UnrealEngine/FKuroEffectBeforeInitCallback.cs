using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C5 RID: 6341
	public sealed class FKuroEffectBeforeInitCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060176E7 RID: 95975 RVA: 0x00224428 File Offset: 0x00222628
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectBeforeInitCallback.StaticFunctionPtr();
		}

		// Token: 0x060176E8 RID: 95976 RVA: 0x00224434 File Offset: 0x00222634
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectBeforeInitCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectBeforeInitCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectBeforeInitCallback__DelegateSignature");
			}
			return FKuroEffectBeforeInitCallback._FunctionPtr;
		}

		// Token: 0x060176E9 RID: 95977 RVA: 0x00224457 File Offset: 0x00222657
		public FKuroEffectBeforeInitCallback()
		{
		}

		// Token: 0x060176EA RID: 95978 RVA: 0x0022445F File Offset: 0x0022265F
		[NullableContext(2)]
		public FKuroEffectBeforeInitCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176EB RID: 95979 RVA: 0x00224469 File Offset: 0x00222669
		public FKuroEffectBeforeInitCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176EC RID: 95980 RVA: 0x00224474 File Offset: 0x00222674
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060176ED RID: 95981 RVA: 0x002244A6 File Offset: 0x002226A6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectBeforeInitCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectBeforeInitCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectBeforeInitCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectBeforeInitCallback.OnScriptCallback));
				}
				FKuroEffectBeforeInitCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectBeforeInitCallback.RegisterId);
		}

		// Token: 0x060176EE RID: 95982 RVA: 0x002244E0 File Offset: 0x002226E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams* ptr = stackalloc FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectBeforeInitCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060176EF RID: 95983 RVA: 0x00224520 File Offset: 0x00222720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400CBE6 RID: 52198
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBE7 RID: 52199
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectBeforeInitCallback__DelegateSignature";

		// Token: 0x0400CBE8 RID: 52200
		private static int RegisterId;

		// Token: 0x02002FB0 RID: 12208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroEffectBeforeInitCallback_DelegateParams
		{
			// Token: 0x04016B93 RID: 93075
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02002FB1 RID: 12209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B94 RID: 93076
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
