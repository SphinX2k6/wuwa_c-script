using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001000 RID: 4096
	public sealed class FPlatformInterfaceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DDD3 RID: 56787 RVA: 0x00146C41 File Offset: 0x00144E41
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformInterfaceDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x00146C4D File Offset: 0x00144E4D
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlatformInterfaceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPlatformInterfaceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformInterfaceDelegate__DelegateSignature");
			}
			return FPlatformInterfaceDelegate._FunctionPtr;
		}

		// Token: 0x0600DDD5 RID: 56789 RVA: 0x00146C70 File Offset: 0x00144E70
		public FPlatformInterfaceDelegate()
		{
		}

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x00146C78 File Offset: 0x00144E78
		[NullableContext(2)]
		public FPlatformInterfaceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x00146C82 File Offset: 0x00144E82
		public FPlatformInterfaceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00146C8D File Offset: 0x00144E8D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FPlatformInterfaceDelegateResult>) ?? ((Action<FPlatformInterfaceDelegateResult>)Delegate.CreateDelegate(typeof(Action<FPlatformInterfaceDelegateResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x00146CBF File Offset: 0x00144EBF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FPlatformInterfaceDelegateResult> Callback)
		{
			if (FPlatformInterfaceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformInterfaceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformInterfaceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformInterfaceDelegate.OnScriptCallback));
				}
				FPlatformInterfaceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlatformInterfaceDelegate.RegisterId);
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x00146CFC File Offset: 0x00144EFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FPlatformInterfaceDelegateResult Result)
		{
			FPlatformInterfaceDelegate.__FPlatformInterfaceDelegate_DelegateParams* ptr = stackalloc FPlatformInterfaceDelegate.__FPlatformInterfaceDelegate_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FPlatformInterfaceDelegate.__FPlatformInterfaceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformInterfaceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformInterfaceDelegateResult.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPlatformInterfaceDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DDDB RID: 56795 RVA: 0x00146D68 File Offset: 0x00144F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FPlatformInterfaceDelegateResult> action = target as Action<FPlatformInterfaceDelegateResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FPlatformInterfaceDelegateResult obj = new FPlatformInterfaceDelegateResult(&((FPlatformInterfaceDelegate.__FPlatformInterfaceDelegate_DelegateParams*)__Parameters)->Result, true, true);
			action(obj);
		}

		// Token: 0x040077EE RID: 30702
		internal static IntPtr _FunctionPtr;

		// Token: 0x040077EF RID: 30703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformInterfaceDelegate__DelegateSignature";

		// Token: 0x040077F0 RID: 30704
		private static int RegisterId;

		// Token: 0x02002DC6 RID: 11718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FPlatformInterfaceDelegate_DelegateParams
		{
			// Token: 0x040167FE RID: 92158
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02002DC7 RID: 11719
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167FF RID: 92159
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
