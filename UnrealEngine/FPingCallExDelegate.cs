using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF8 RID: 7928
	public sealed class FPingCallExDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1CC RID: 123340 RVA: 0x002CBDFE File Offset: 0x002C9FFE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPingCallExDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E1CD RID: 123341 RVA: 0x002CBE0A File Offset: 0x002CA00A
		private static IntPtr StaticFunctionPtr()
		{
			if (FPingCallExDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPingCallExDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PingCallExDelegate__DelegateSignature");
			}
			return FPingCallExDelegate._FunctionPtr;
		}

		// Token: 0x0601E1CE RID: 123342 RVA: 0x002CBE2D File Offset: 0x002CA02D
		public FPingCallExDelegate()
		{
		}

		// Token: 0x0601E1CF RID: 123343 RVA: 0x002CBE35 File Offset: 0x002CA035
		[NullableContext(2)]
		public FPingCallExDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1D0 RID: 123344 RVA: 0x002CBE3F File Offset: 0x002CA03F
		public FPingCallExDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1D1 RID: 123345 RVA: 0x002CBE4A File Offset: 0x002CA04A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, float, int>) ?? ((Action<string, float, int>)Delegate.CreateDelegate(typeof(Action<string, float, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1D2 RID: 123346 RVA: 0x002CBE7C File Offset: 0x002CA07C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, float, int> Callback)
		{
			if (FPingCallExDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPingCallExDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPingCallExDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPingCallExDelegate.OnScriptCallback));
				}
				FPingCallExDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPingCallExDelegate.RegisterId);
		}

		// Token: 0x0601E1D3 RID: 123347 RVA: 0x002CBEB8 File Offset: 0x002CA0B8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Address, float Time, int responseState)
		{
			FPingCallExDelegate.__FPingCallExDelegate_DelegateParams* ptr = stackalloc FPingCallExDelegate.__FPingCallExDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FPingCallExDelegate.__FPingCallExDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPingCallExDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Address), Address);
			ptr->Time = Time;
			ptr->responseState = responseState;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPingCallExDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E1D4 RID: 123348 RVA: 0x002CBF1C File Offset: 0x002CA11C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, float, int> action = target as Action<string, float, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FPingCallExDelegate.__FPingCallExDelegate_DelegateParams*)__Parameters)->Address));
			action(arg, ((FPingCallExDelegate.__FPingCallExDelegate_DelegateParams*)__Parameters)->Time, ((FPingCallExDelegate.__FPingCallExDelegate_DelegateParams*)__Parameters)->responseState);
		}

		// Token: 0x04010448 RID: 66632
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010449 RID: 66633
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PingCallExDelegate__DelegateSignature";

		// Token: 0x0401044A RID: 66634
		private static int RegisterId;

		// Token: 0x020033DB RID: 13275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FPingCallExDelegate_DelegateParams
		{
			// Token: 0x04017390 RID: 95120
			[FieldOffset(0)]
			public FString Address;

			// Token: 0x04017391 RID: 95121
			[FieldOffset(16)]
			public float Time;

			// Token: 0x04017392 RID: 95122
			[FieldOffset(20)]
			public int responseState;
		}

		// Token: 0x020033DC RID: 13276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017393 RID: 95123
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
