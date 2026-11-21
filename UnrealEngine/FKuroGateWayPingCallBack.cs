using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047A RID: 1146
	public sealed class FKuroGateWayPingCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006C83 RID: 27779 RVA: 0x0009E361 File Offset: 0x0009C561
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroGateWayPingCallBack.StaticFunctionPtr();
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x0009E36D File Offset: 0x0009C56D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroGateWayPingCallBack._FunctionPtr == IntPtr.Zero)
			{
				FKuroGateWayPingCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroGateWayPingCallBack__DelegateSignature");
			}
			return FKuroGateWayPingCallBack._FunctionPtr;
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x0009E390 File Offset: 0x0009C590
		public FKuroGateWayPingCallBack()
		{
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0009E398 File Offset: 0x0009C598
		[NullableContext(2)]
		public FKuroGateWayPingCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x0009E3A2 File Offset: 0x0009C5A2
		public FKuroGateWayPingCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x0009E3AD File Offset: 0x0009C5AD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, int, double, EKuroNetworkPingResponseStatus>) ?? ((Action<string, int, double, EKuroNetworkPingResponseStatus>)Delegate.CreateDelegate(typeof(Action<string, int, double, EKuroNetworkPingResponseStatus>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x0009E3DF File Offset: 0x0009C5DF
		[NullableContext(1)]
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

		// Token: 0x06006C8A RID: 27786 RVA: 0x0009E41C File Offset: 0x0009C61C
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x06006C8B RID: 27787 RVA: 0x0009E488 File Offset: 0x0009C688
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002E5C RID: 11868
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E5D RID: 11869
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroGateWayPingCallBack__DelegateSignature";

		// Token: 0x04002E5E RID: 11870
		private static int RegisterId;

		// Token: 0x02000B7F RID: 2943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FKuroGateWayPingCallBack_DelegateParams
		{
			// Token: 0x04005CD9 RID: 23769
			[FieldOffset(0)]
			public FString Address;

			// Token: 0x04005CDA RID: 23770
			[FieldOffset(16)]
			public int Port;

			// Token: 0x04005CDB RID: 23771
			[FieldOffset(24)]
			public double Time;

			// Token: 0x04005CDC RID: 23772
			[FieldOffset(32)]
			public EKuroNetworkPingResponseStatus Result;
		}

		// Token: 0x02000B80 RID: 2944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005CDD RID: 23773
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
