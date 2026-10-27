using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FC RID: 6652
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroNetworkChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018A94 RID: 101012 RVA: 0x00245E86 File Offset: 0x00244086
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNetworkChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018A95 RID: 101013 RVA: 0x00245E92 File Offset: 0x00244092
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNetworkChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroNetworkChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroNetworkChangeDelegate__DelegateSignature");
			}
			return FKuroNetworkChangeDelegate._FunctionPtr;
		}

		// Token: 0x06018A96 RID: 101014 RVA: 0x00245EB5 File Offset: 0x002440B5
		public FKuroNetworkChangeDelegate()
		{
		}

		// Token: 0x06018A97 RID: 101015 RVA: 0x00245EBD File Offset: 0x002440BD
		[NullableContext(2)]
		public FKuroNetworkChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018A98 RID: 101016 RVA: 0x00245EC7 File Offset: 0x002440C7
		public FKuroNetworkChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018A99 RID: 101017 RVA: 0x00245ED2 File Offset: 0x002440D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018A9A RID: 101018 RVA: 0x00245F04 File Offset: 0x00244104
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<byte> Callback)
		{
			if (FKuroNetworkChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroNetworkChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroNetworkChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroNetworkChangeDelegate.OnScriptCallback));
				}
				FKuroNetworkChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroNetworkChangeDelegate.RegisterId);
		}

		// Token: 0x06018A9B RID: 101019 RVA: 0x00245F3E File Offset: 0x0024413E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018A9C RID: 101020 RVA: 0x00245F48 File Offset: 0x00244148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(byte NetworkTransportType)
		{
			FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams* ptr = stackalloc FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroNetworkChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NetworkTransportType = NetworkTransportType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018A9D RID: 101021 RVA: 0x00245F84 File Offset: 0x00244184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams*)__Parameters)->NetworkTransportType);
		}

		// Token: 0x0400D53A RID: 54586
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D53B RID: 54587
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkChangeDelegate__DelegateSignature";

		// Token: 0x0400D53C RID: 54588
		private static int RegisterId;

		// Token: 0x020030B0 RID: 12464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FKuroNetworkChangeDelegate_DelegateParams
		{
			// Token: 0x04016DFC RID: 93692
			[FieldOffset(0)]
			public byte NetworkTransportType;
		}

		// Token: 0x020030B1 RID: 12465
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DFD RID: 93693
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
