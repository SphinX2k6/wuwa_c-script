using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000605 RID: 1541
	public sealed class FPingCallExDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600880C RID: 34828 RVA: 0x000CCD86 File Offset: 0x000CAF86
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPingCallExDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600880D RID: 34829 RVA: 0x000CCD92 File Offset: 0x000CAF92
		private static IntPtr StaticFunctionPtr()
		{
			if (FPingCallExDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPingCallExDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PingCallExDelegate__DelegateSignature");
			}
			return FPingCallExDelegate._FunctionPtr;
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x000CCDB5 File Offset: 0x000CAFB5
		public FPingCallExDelegate()
		{
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x000CCDBD File Offset: 0x000CAFBD
		[NullableContext(2)]
		public FPingCallExDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x000CCDC7 File Offset: 0x000CAFC7
		public FPingCallExDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008811 RID: 34833 RVA: 0x000CCDD2 File Offset: 0x000CAFD2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, float, int>) ?? ((Action<string, float, int>)Delegate.CreateDelegate(typeof(Action<string, float, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x000CCE04 File Offset: 0x000CB004
		[NullableContext(1)]
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

		// Token: 0x06008813 RID: 34835 RVA: 0x000CCE40 File Offset: 0x000CB040
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x06008814 RID: 34836 RVA: 0x000CCEA4 File Offset: 0x000CB0A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003B1A RID: 15130
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B1B RID: 15131
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PingCallExDelegate__DelegateSignature";

		// Token: 0x04003B1C RID: 15132
		private static int RegisterId;

		// Token: 0x02000E2A RID: 3626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FPingCallExDelegate_DelegateParams
		{
			// Token: 0x040061BF RID: 25023
			[FieldOffset(0)]
			public FString Address;

			// Token: 0x040061C0 RID: 25024
			[FieldOffset(16)]
			public float Time;

			// Token: 0x040061C1 RID: 25025
			[FieldOffset(20)]
			public int responseState;
		}

		// Token: 0x02000E2B RID: 3627
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061C2 RID: 25026
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
