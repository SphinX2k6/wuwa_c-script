using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200151B RID: 5403
	public sealed class FOnImageWriteComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06013AC9 RID: 80585 RVA: 0x001CE5B4 File Offset: 0x001CC7B4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnImageWriteComplete.StaticFunctionPtr();
		}

		// Token: 0x06013ACA RID: 80586 RVA: 0x001CE5C0 File Offset: 0x001CC7C0
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnImageWriteComplete._FunctionPtr == IntPtr.Zero)
			{
				FOnImageWriteComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature");
			}
			return FOnImageWriteComplete._FunctionPtr;
		}

		// Token: 0x06013ACB RID: 80587 RVA: 0x001CE5E3 File Offset: 0x001CC7E3
		public FOnImageWriteComplete()
		{
		}

		// Token: 0x06013ACC RID: 80588 RVA: 0x001CE5EB File Offset: 0x001CC7EB
		[NullableContext(2)]
		public FOnImageWriteComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013ACD RID: 80589 RVA: 0x001CE5F5 File Offset: 0x001CC7F5
		public FOnImageWriteComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013ACE RID: 80590 RVA: 0x001CE600 File Offset: 0x001CC800
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06013ACF RID: 80591 RVA: 0x001CE632 File Offset: 0x001CC832
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnImageWriteComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnImageWriteComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnImageWriteComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnImageWriteComplete.OnScriptCallback));
				}
				FOnImageWriteComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnImageWriteComplete.RegisterId);
		}

		// Token: 0x06013AD0 RID: 80592 RVA: 0x001CE66C File Offset: 0x001CC86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bSuccess)
		{
			FOnImageWriteComplete.__FOnImageWriteComplete_DelegateParams* ptr = stackalloc FOnImageWriteComplete.__FOnImageWriteComplete_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnImageWriteComplete.__FOnImageWriteComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnImageWriteComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06013AD1 RID: 80593 RVA: 0x001CE6AC File Offset: 0x001CC8AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnImageWriteComplete.__FOnImageWriteComplete_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x0400A9F3 RID: 43507
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A9F4 RID: 43508
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature";

		// Token: 0x0400A9F5 RID: 43509
		private static int RegisterId;

		// Token: 0x02002EB2 RID: 11954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnImageWriteComplete_DelegateParams
		{
			// Token: 0x040169AE RID: 92590
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x02002EB3 RID: 11955
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169AF RID: 92591
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
