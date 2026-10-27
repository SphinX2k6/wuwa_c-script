using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F4 RID: 6644
	public sealed class FKuroGateWayPingCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018A06 RID: 100870 RVA: 0x00244B5D File Offset: 0x00242D5D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroGateWayPingCallBack.StaticFunctionPtr();
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x00244B69 File Offset: 0x00242D69
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroGateWayPingCallBack._FunctionPtr == IntPtr.Zero)
			{
				FKuroGateWayPingCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroGateWayPingCallBack__DelegateSignature");
			}
			return FKuroGateWayPingCallBack._FunctionPtr;
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x00244B8C File Offset: 0x00242D8C
		public FKuroGateWayPingCallBack()
		{
		}

		// Token: 0x06018A09 RID: 100873 RVA: 0x00244B94 File Offset: 0x00242D94
		[NullableContext(2)]
		public FKuroGateWayPingCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018A0A RID: 100874 RVA: 0x00244B9E File Offset: 0x00242D9E
		public FKuroGateWayPingCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018A0B RID: 100875 RVA: 0x00244BA9 File Offset: 0x00242DA9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, int, double, EKuroNetworkPingResponseStatus>) ?? ((Action<string, int, double, EKuroNetworkPingResponseStatus>)Delegate.CreateDelegate(typeof(Action<string, int, double, EKuroNetworkPingResponseStatus>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018A0C RID: 100876 RVA: 0x00244BDB File Offset: 0x00242DDB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, int, double, EKuroNetworkPingResponseStatus> Callback)
		{
			if (FKuroGateWayPingCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroGateWayPingCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroGateWayPingCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroGateWayPingCallBack.OnScriptCallback));
				}
				FKuroGateWayPingCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroGateWayPingCallBack.RegisterId);
		}

		// Token: 0x06018A0D RID: 100877 RVA: 0x00244C18 File Offset: 0x00242E18
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Address, int Port, double Time, EKuroNetworkPingResponseStatus Result)
		{
			FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams* ptr = stackalloc FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroGateWayPingCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Address), Address);
			ptr->Port = Port;
			ptr->Time = Time;
			ptr->Result = Result;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroGateWayPingCallBack._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A0E RID: 100878 RVA: 0x00244C84 File Offset: 0x00242E84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, int, double, EKuroNetworkPingResponseStatus> action = target as Action<string, int, double, EKuroNetworkPingResponseStatus>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams*)__Parameters)->Address));
			action(arg, ((FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams*)__Parameters)->Port, ((FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams*)__Parameters)->Time, ((FKuroGateWayPingCallBack.__FKuroGateWayPingCallBack_DelegateParams*)__Parameters)->Result);
		}

		// Token: 0x0400D4FA RID: 54522
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D4FB RID: 54523
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroGateWayPingCallBack__DelegateSignature";

		// Token: 0x0400D4FC RID: 54524
		private static int RegisterId;

		// Token: 0x0200309F RID: 12447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FKuroGateWayPingCallBack_DelegateParams
		{
			// Token: 0x04016DC8 RID: 93640
			[FieldOffset(0)]
			public FString Address;

			// Token: 0x04016DC9 RID: 93641
			[FieldOffset(16)]
			public int Port;

			// Token: 0x04016DCA RID: 93642
			[FieldOffset(24)]
			public double Time;

			// Token: 0x04016DCB RID: 93643
			[FieldOffset(32)]
			public EKuroNetworkPingResponseStatus Result;
		}

		// Token: 0x020030A0 RID: 12448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DCC RID: 93644
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
