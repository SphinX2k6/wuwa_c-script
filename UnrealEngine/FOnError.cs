using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A02 RID: 6658
	public sealed class FOnError : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018AEA RID: 101098 RVA: 0x002465F6 File Offset: 0x002447F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnError.StaticFunctionPtr();
		}

		// Token: 0x06018AEB RID: 101099 RVA: 0x00246602 File Offset: 0x00244802
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnError._FunctionPtr == IntPtr.Zero)
			{
				FOnError._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnError__DelegateSignature");
			}
			return FOnError._FunctionPtr;
		}

		// Token: 0x06018AEC RID: 101100 RVA: 0x00246625 File Offset: 0x00244825
		public FOnError()
		{
		}

		// Token: 0x06018AED RID: 101101 RVA: 0x0024662D File Offset: 0x0024482D
		[NullableContext(2)]
		public FOnError(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018AEE RID: 101102 RVA: 0x00246637 File Offset: 0x00244837
		public FOnError(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018AEF RID: 101103 RVA: 0x00246642 File Offset: 0x00244842
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int, int, int, int>) ?? ((Action<int, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<int, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018AF0 RID: 101104 RVA: 0x00246674 File Offset: 0x00244874
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int, int, int, int> Callback)
		{
			if (FOnError.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnError.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnError.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnError.OnScriptCallback));
				}
				FOnError.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnError.RegisterId);
		}

		// Token: 0x06018AF1 RID: 101105 RVA: 0x002466B0 File Offset: 0x002448B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Code1, int Code2, int Code3, int Code4, int Code5)
		{
			FOnError.__FOnError_DelegateParams* ptr = stackalloc FOnError.__FOnError_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FOnError.__FOnError_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnError.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Code1 = Code1;
			ptr->Code2 = Code2;
			ptr->Code3 = Code3;
			ptr->Code4 = Code4;
			ptr->Code5 = Code5;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018AF2 RID: 101106 RVA: 0x0024670C File Offset: 0x0024490C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, int, int, int> action = target as Action<int, int, int, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnError.__FOnError_DelegateParams*)__Parameters)->Code1, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code2, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code3, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code4, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code5);
		}

		// Token: 0x0400D556 RID: 54614
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D557 RID: 54615
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnError__DelegateSignature";

		// Token: 0x0400D558 RID: 54616
		private static int RegisterId;

		// Token: 0x020030B2 RID: 12466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FOnError_DelegateParams
		{
			// Token: 0x04016DFE RID: 93694
			[FieldOffset(0)]
			public int Code1;

			// Token: 0x04016DFF RID: 93695
			[FieldOffset(4)]
			public int Code2;

			// Token: 0x04016E00 RID: 93696
			[FieldOffset(8)]
			public int Code3;

			// Token: 0x04016E01 RID: 93697
			[FieldOffset(12)]
			public int Code4;

			// Token: 0x04016E02 RID: 93698
			[FieldOffset(16)]
			public int Code5;
		}

		// Token: 0x020030B3 RID: 12467
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E03 RID: 93699
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
