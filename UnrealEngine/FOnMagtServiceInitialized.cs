using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200227E RID: 8830
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMagtServiceInitialized : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602192A RID: 137514 RVA: 0x0031AAF9 File Offset: 0x00318CF9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMagtServiceInitialized.StaticFunctionPtr();
		}

		// Token: 0x0602192B RID: 137515 RVA: 0x0031AB05 File Offset: 0x00318D05
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMagtServiceInitialized._FunctionPtr == IntPtr.Zero)
			{
				FOnMagtServiceInitialized._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnMagtServiceInitialized__DelegateSignature");
			}
			return FOnMagtServiceInitialized._FunctionPtr;
		}

		// Token: 0x0602192C RID: 137516 RVA: 0x0031AB28 File Offset: 0x00318D28
		public FOnMagtServiceInitialized()
		{
		}

		// Token: 0x0602192D RID: 137517 RVA: 0x0031AB30 File Offset: 0x00318D30
		[NullableContext(2)]
		public FOnMagtServiceInitialized(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602192E RID: 137518 RVA: 0x0031AB3A File Offset: 0x00318D3A
		public FOnMagtServiceInitialized(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602192F RID: 137519 RVA: 0x0031AB45 File Offset: 0x00318D45
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int>) ?? ((Action<bool, int>)Delegate.CreateDelegate(typeof(Action<bool, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021930 RID: 137520 RVA: 0x0031AB77 File Offset: 0x00318D77
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, int> Callback)
		{
			if (FOnMagtServiceInitialized.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMagtServiceInitialized.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMagtServiceInitialized.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMagtServiceInitialized.OnScriptCallback));
				}
				FOnMagtServiceInitialized.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMagtServiceInitialized.RegisterId);
		}

		// Token: 0x06021931 RID: 137521 RVA: 0x0031ABB1 File Offset: 0x00318DB1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021932 RID: 137522 RVA: 0x0031ABBC File Offset: 0x00318DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bSuccess, int ResultCode)
		{
			FOnMagtServiceInitialized.__FOnMagtServiceInitialized_DelegateParams* ptr = stackalloc FOnMagtServiceInitialized.__FOnMagtServiceInitialized_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnMagtServiceInitialized.__FOnMagtServiceInitialized_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMagtServiceInitialized.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			ptr->ResultCode = ResultCode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021933 RID: 137523 RVA: 0x0031AC00 File Offset: 0x00318E00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int> action = target as Action<bool, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMagtServiceInitialized.__FOnMagtServiceInitialized_DelegateParams*)__Parameters)->bSuccess, ((FOnMagtServiceInitialized.__FOnMagtServiceInitialized_DelegateParams*)__Parameters)->ResultCode);
		}

		// Token: 0x04011EE1 RID: 73441
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EE2 RID: 73442
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnMagtServiceInitialized__DelegateSignature";

		// Token: 0x04011EE3 RID: 73443
		private static int RegisterId;

		// Token: 0x02003606 RID: 13830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnMagtServiceInitialized_DelegateParams
		{
			// Token: 0x0401768F RID: 95887
			[FieldOffset(0)]
			public bool bSuccess;

			// Token: 0x04017690 RID: 95888
			[FieldOffset(4)]
			public int ResultCode;
		}

		// Token: 0x02003607 RID: 13831
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017691 RID: 95889
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
