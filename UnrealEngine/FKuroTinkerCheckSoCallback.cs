using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E77 RID: 7799
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroTinkerCheckSoCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB1F RID: 121631 RVA: 0x002BDDE5 File Offset: 0x002BBFE5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroTinkerCheckSoCallback.StaticFunctionPtr();
		}

		// Token: 0x0601DB20 RID: 121632 RVA: 0x002BDDF1 File Offset: 0x002BBFF1
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroTinkerCheckSoCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroTinkerCheckSoCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSoHotPatch.KuroTinkerCheckSoCallback__DelegateSignature");
			}
			return FKuroTinkerCheckSoCallback._FunctionPtr;
		}

		// Token: 0x0601DB21 RID: 121633 RVA: 0x002BDE14 File Offset: 0x002BC014
		public FKuroTinkerCheckSoCallback()
		{
		}

		// Token: 0x0601DB22 RID: 121634 RVA: 0x002BDE1C File Offset: 0x002BC01C
		[NullableContext(2)]
		public FKuroTinkerCheckSoCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB23 RID: 121635 RVA: 0x002BDE26 File Offset: 0x002BC026
		public FKuroTinkerCheckSoCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB24 RID: 121636 RVA: 0x002BDE31 File Offset: 0x002BC031
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB25 RID: 121637 RVA: 0x002BDE63 File Offset: 0x002BC063
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DB26 RID: 121638 RVA: 0x002BDE9D File Offset: 0x002BC09D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB27 RID: 121639 RVA: 0x002BDEA8 File Offset: 0x002BC0A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ResultCode)
		{
			FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams* ptr = stackalloc FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroTinkerCheckSoCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ResultCode = ResultCode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601DB28 RID: 121640 RVA: 0x002BDEE4 File Offset: 0x002BC0E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroTinkerCheckSoCallback.__FKuroTinkerCheckSoCallback_DelegateParams*)__Parameters)->ResultCode);
		}

		// Token: 0x04010146 RID: 65862
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010147 RID: 65863
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSoHotPatch.KuroTinkerCheckSoCallback__DelegateSignature";

		// Token: 0x04010148 RID: 65864
		private static int RegisterId;

		// Token: 0x020032CC RID: 13004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroTinkerCheckSoCallback_DelegateParams
		{
			// Token: 0x04017173 RID: 94579
			[FieldOffset(0)]
			public int ResultCode;
		}

		// Token: 0x020032CD RID: 13005
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017174 RID: 94580
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
