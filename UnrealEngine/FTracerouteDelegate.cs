using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0E RID: 6670
	public sealed class FTracerouteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B5D RID: 101213 RVA: 0x002475FC File Offset: 0x002457FC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTracerouteDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B5E RID: 101214 RVA: 0x00247608 File Offset: 0x00245808
		private static IntPtr StaticFunctionPtr()
		{
			if (FTracerouteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTracerouteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.TracerouteDelegate__DelegateSignature");
			}
			return FTracerouteDelegate._FunctionPtr;
		}

		// Token: 0x06018B5F RID: 101215 RVA: 0x0024762B File Offset: 0x0024582B
		public FTracerouteDelegate()
		{
		}

		// Token: 0x06018B60 RID: 101216 RVA: 0x00247633 File Offset: 0x00245833
		[NullableContext(2)]
		public FTracerouteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B61 RID: 101217 RVA: 0x0024763D File Offset: 0x0024583D
		public FTracerouteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B62 RID: 101218 RVA: 0x00247648 File Offset: 0x00245848
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B63 RID: 101219 RVA: 0x0024767A File Offset: 0x0024587A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FTracerouteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTracerouteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTracerouteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTracerouteDelegate.OnScriptCallback));
				}
				FTracerouteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTracerouteDelegate.RegisterId);
		}

		// Token: 0x06018B64 RID: 101220 RVA: 0x002476B4 File Offset: 0x002458B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool IsReached)
		{
			FTracerouteDelegate.__FTracerouteDelegate_DelegateParams* ptr = stackalloc FTracerouteDelegate.__FTracerouteDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FTracerouteDelegate.__FTracerouteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTracerouteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsReached = IsReached;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B65 RID: 101221 RVA: 0x002476F4 File Offset: 0x002458F4
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
			action(((FTracerouteDelegate.__FTracerouteDelegate_DelegateParams*)__Parameters)->IsReached);
		}

		// Token: 0x0400D57E RID: 54654
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D57F RID: 54655
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.TracerouteDelegate__DelegateSignature";

		// Token: 0x0400D580 RID: 54656
		private static int RegisterId;

		// Token: 0x020030C5 RID: 12485
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FTracerouteDelegate_DelegateParams
		{
			// Token: 0x04016E22 RID: 93730
			[FieldOffset(0)]
			public bool IsReached;
		}

		// Token: 0x020030C6 RID: 12486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E23 RID: 93731
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
