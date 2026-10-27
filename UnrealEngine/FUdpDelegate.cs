using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0F RID: 6671
	public sealed class FUdpDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B66 RID: 101222 RVA: 0x0024773E File Offset: 0x0024593E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUdpDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B67 RID: 101223 RVA: 0x0024774A File Offset: 0x0024594A
		private static IntPtr StaticFunctionPtr()
		{
			if (FUdpDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUdpDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.UdpDelegate__DelegateSignature");
			}
			return FUdpDelegate._FunctionPtr;
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x0024776D File Offset: 0x0024596D
		public FUdpDelegate()
		{
		}

		// Token: 0x06018B69 RID: 101225 RVA: 0x00247775 File Offset: 0x00245975
		[NullableContext(2)]
		public FUdpDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B6A RID: 101226 RVA: 0x0024777F File Offset: 0x0024597F
		public FUdpDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B6B RID: 101227 RVA: 0x0024778A File Offset: 0x0024598A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B6C RID: 101228 RVA: 0x002477BC File Offset: 0x002459BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool, string> Callback)
		{
			if (FUdpDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUdpDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUdpDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUdpDelegate.OnScriptCallback));
				}
				FUdpDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUdpDelegate.RegisterId);
		}

		// Token: 0x06018B6D RID: 101229 RVA: 0x002477F8 File Offset: 0x002459F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool IsSuccess, string Response)
		{
			FUdpDelegate.__FUdpDelegate_DelegateParams* ptr = stackalloc FUdpDelegate.__FUdpDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FUdpDelegate.__FUdpDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUdpDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsSuccess = IsSuccess;
			FString.CopyFrom((void*)(&ptr->Response), Response);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FUdpDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018B6E RID: 101230 RVA: 0x00247854 File Offset: 0x00245A54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FUdpDelegate.__FUdpDelegate_DelegateParams*)__Parameters)->Response));
			action(((FUdpDelegate.__FUdpDelegate_DelegateParams*)__Parameters)->IsSuccess, arg);
		}

		// Token: 0x0400D581 RID: 54657
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D582 RID: 54658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.UdpDelegate__DelegateSignature";

		// Token: 0x0400D583 RID: 54659
		private static int RegisterId;

		// Token: 0x020030C7 RID: 12487
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FUdpDelegate_DelegateParams
		{
			// Token: 0x04016E24 RID: 93732
			[FieldOffset(0)]
			public bool IsSuccess;

			// Token: 0x04016E25 RID: 93733
			[FieldOffset(8)]
			public FString Response;
		}

		// Token: 0x020030C8 RID: 12488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E26 RID: 93734
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
