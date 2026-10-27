using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0A RID: 6666
	public sealed class FResolveDomainDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B35 RID: 101173 RVA: 0x0024700E File Offset: 0x0024520E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FResolveDomainDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B36 RID: 101174 RVA: 0x0024701A File Offset: 0x0024521A
		private static IntPtr StaticFunctionPtr()
		{
			if (FResolveDomainDelegate._FunctionPtr == IntPtr.Zero)
			{
				FResolveDomainDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.ResolveDomainDelegate__DelegateSignature");
			}
			return FResolveDomainDelegate._FunctionPtr;
		}

		// Token: 0x06018B37 RID: 101175 RVA: 0x0024703D File Offset: 0x0024523D
		public FResolveDomainDelegate()
		{
		}

		// Token: 0x06018B38 RID: 101176 RVA: 0x00247045 File Offset: 0x00245245
		[NullableContext(2)]
		public FResolveDomainDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B39 RID: 101177 RVA: 0x0024704F File Offset: 0x0024524F
		public FResolveDomainDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B3A RID: 101178 RVA: 0x0024705A File Offset: 0x0024525A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B3B RID: 101179 RVA: 0x0024708C File Offset: 0x0024528C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FResolveDomainDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FResolveDomainDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FResolveDomainDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FResolveDomainDelegate.OnScriptCallback));
				}
				FResolveDomainDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FResolveDomainDelegate.RegisterId);
		}

		// Token: 0x06018B3C RID: 101180 RVA: 0x002470C8 File Offset: 0x002452C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ErrorCode)
		{
			FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams* ptr = stackalloc FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FResolveDomainDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B3D RID: 101181 RVA: 0x00247108 File Offset: 0x00245308
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
			action(((FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x0400D56E RID: 54638
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D56F RID: 54639
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.ResolveDomainDelegate__DelegateSignature";

		// Token: 0x0400D570 RID: 54640
		private static int RegisterId;

		// Token: 0x020030BF RID: 12479
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FResolveDomainDelegate_DelegateParams
		{
			// Token: 0x04016E17 RID: 93719
			[FieldOffset(0)]
			public int ErrorCode;
		}

		// Token: 0x020030C0 RID: 12480
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E18 RID: 93720
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
