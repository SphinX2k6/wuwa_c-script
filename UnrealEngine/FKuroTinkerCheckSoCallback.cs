using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AA RID: 1450
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroTinkerCheckSoCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008289 RID: 33417 RVA: 0x000C10C1 File Offset: 0x000BF2C1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroTinkerCheckSoCallback.StaticFunctionPtr();
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x000C10CD File Offset: 0x000BF2CD
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroTinkerCheckSoCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroTinkerCheckSoCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSoHotPatch.KuroTinkerCheckSoCallback__DelegateSignature");
			}
			return FKuroTinkerCheckSoCallback._FunctionPtr;
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x000C10F0 File Offset: 0x000BF2F0
		public FKuroTinkerCheckSoCallback()
		{
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x000C10F8 File Offset: 0x000BF2F8
		[NullableContext(2)]
		public FKuroTinkerCheckSoCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x000C1102 File Offset: 0x000BF302
		public FKuroTinkerCheckSoCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x000C110D File Offset: 0x000BF30D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x000C113F File Offset: 0x000BF33F
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FKuroTinkerCheckSoCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroTinkerCheckSoCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroTinkerCheckSoCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroTinkerCheckSoCallback.OnScriptCallback));
				}
				FKuroTinkerCheckSoCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroTinkerCheckSoCallback.RegisterId);
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x000C1179 File Offset: 0x000BF379
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x000C1184 File Offset: 0x000BF384
		[SkipLocalsInit]
		public unsafe void Broadcast(int ResultCode)
		{
			FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams* ptr = stackalloc FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroTinkerCheckSoCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ResultCode = ResultCode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x000C11C0 File Offset: 0x000BF3C0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams*)__Parameters)->ResultCode);
		}

		// Token: 0x040038DB RID: 14555
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038DC RID: 14556
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSoHotPatch.KuroTinkerCheckSoCallback__DelegateSignature";

		// Token: 0x040038DD RID: 14557
		private static int RegisterId;

		// Token: 0x02000D2B RID: 3371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroTinkerCheckSoCallback_DelegateParams
		{
			// Token: 0x04005FBF RID: 24511
			[FieldOffset(0)]
			public int ResultCode;
		}

		// Token: 0x02000D2C RID: 3372
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FC0 RID: 24512
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
