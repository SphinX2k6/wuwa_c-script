using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0D RID: 6669
	public sealed class FTestUdpResultDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B54 RID: 101204 RVA: 0x002474AF File Offset: 0x002456AF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTestUdpResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B55 RID: 101205 RVA: 0x002474BB File Offset: 0x002456BB
		private static IntPtr StaticFunctionPtr()
		{
			if (FTestUdpResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTestUdpResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.TestUdpResultDelegate__DelegateSignature");
			}
			return FTestUdpResultDelegate._FunctionPtr;
		}

		// Token: 0x06018B56 RID: 101206 RVA: 0x002474DE File Offset: 0x002456DE
		public FTestUdpResultDelegate()
		{
		}

		// Token: 0x06018B57 RID: 101207 RVA: 0x002474E6 File Offset: 0x002456E6
		[NullableContext(2)]
		public FTestUdpResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B58 RID: 101208 RVA: 0x002474F0 File Offset: 0x002456F0
		public FTestUdpResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B59 RID: 101209 RVA: 0x002474FB File Offset: 0x002456FB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B5A RID: 101210 RVA: 0x0024752D File Offset: 0x0024572D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int> Callback)
		{
			if (FTestUdpResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTestUdpResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTestUdpResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTestUdpResultDelegate.OnScriptCallback));
				}
				FTestUdpResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTestUdpResultDelegate.RegisterId);
		}

		// Token: 0x06018B5B RID: 101211 RVA: 0x00247568 File Offset: 0x00245768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int SuccessCount, int ErrorCode)
		{
			FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams* ptr = stackalloc FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTestUdpResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SuccessCount = SuccessCount;
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B5C RID: 101212 RVA: 0x002475AC File Offset: 0x002457AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams*)__Parameters)->SuccessCount, ((FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x0400D57B RID: 54651
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D57C RID: 54652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.TestUdpResultDelegate__DelegateSignature";

		// Token: 0x0400D57D RID: 54653
		private static int RegisterId;

		// Token: 0x020030C3 RID: 12483
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTestUdpResultDelegate_DelegateParams
		{
			// Token: 0x04016E1F RID: 93727
			[FieldOffset(0)]
			public int SuccessCount;

			// Token: 0x04016E20 RID: 93728
			[FieldOffset(4)]
			public int ErrorCode;
		}

		// Token: 0x020030C4 RID: 12484
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E21 RID: 93729
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
