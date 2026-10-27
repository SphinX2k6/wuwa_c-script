using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A09 RID: 6665
	public sealed class FOnReceivedTcpExceptionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B2C RID: 101164 RVA: 0x00246ECC File Offset: 0x002450CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedTcpExceptionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B2D RID: 101165 RVA: 0x00246ED8 File Offset: 0x002450D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedTcpExceptionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedTcpExceptionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedTcpExceptionDelegate__DelegateSignature");
			}
			return FOnReceivedTcpExceptionDelegate._FunctionPtr;
		}

		// Token: 0x06018B2E RID: 101166 RVA: 0x00246EFB File Offset: 0x002450FB
		public FOnReceivedTcpExceptionDelegate()
		{
		}

		// Token: 0x06018B2F RID: 101167 RVA: 0x00246F03 File Offset: 0x00245103
		[NullableContext(2)]
		public FOnReceivedTcpExceptionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B30 RID: 101168 RVA: 0x00246F0D File Offset: 0x0024510D
		public FOnReceivedTcpExceptionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B31 RID: 101169 RVA: 0x00246F18 File Offset: 0x00245118
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<uint>) ?? ((Action<uint>)Delegate.CreateDelegate(typeof(Action<uint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B32 RID: 101170 RVA: 0x00246F4A File Offset: 0x0024514A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<uint> Callback)
		{
			if (FOnReceivedTcpExceptionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedTcpExceptionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedTcpExceptionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedTcpExceptionDelegate.OnScriptCallback));
				}
				FOnReceivedTcpExceptionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedTcpExceptionDelegate.RegisterId);
		}

		// Token: 0x06018B33 RID: 101171 RVA: 0x00246F84 File Offset: 0x00245184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(uint ErrorCode)
		{
			FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams* ptr = stackalloc FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedTcpExceptionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B34 RID: 101172 RVA: 0x00246FC4 File Offset: 0x002451C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<uint> action = target as Action<uint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x0400D56B RID: 54635
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D56C RID: 54636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedTcpExceptionDelegate__DelegateSignature";

		// Token: 0x0400D56D RID: 54637
		private static int RegisterId;

		// Token: 0x020030BD RID: 12477
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnReceivedTcpExceptionDelegate_DelegateParams
		{
			// Token: 0x04016E15 RID: 93717
			[FieldOffset(0)]
			public uint ErrorCode;
		}

		// Token: 0x020030BE RID: 12478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E16 RID: 93718
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
