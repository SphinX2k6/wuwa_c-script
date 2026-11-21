using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AE RID: 1966
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroNearbyTransferEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AAD4 RID: 43732 RVA: 0x000FBFCE File Offset: 0x000FA1CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNearbyTransferEvent.StaticFunctionPtr();
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x000FBFDA File Offset: 0x000FA1DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNearbyTransferEvent._FunctionPtr == IntPtr.Zero)
			{
				FKuroNearbyTransferEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/OHNearby.KuroNearbyTransferEvent__DelegateSignature");
			}
			return FKuroNearbyTransferEvent._FunctionPtr;
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x000FBFFD File Offset: 0x000FA1FD
		public FKuroNearbyTransferEvent()
		{
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x000FC005 File Offset: 0x000FA205
		[NullableContext(2)]
		public FKuroNearbyTransferEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x000FC00F File Offset: 0x000FA20F
		public FKuroNearbyTransferEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AAD9 RID: 43737 RVA: 0x000FC01A File Offset: 0x000FA21A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x000FC04C File Offset: 0x000FA24C
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FKuroNearbyTransferEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroNearbyTransferEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroNearbyTransferEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroNearbyTransferEvent.OnScriptCallback));
				}
				FKuroNearbyTransferEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroNearbyTransferEvent.RegisterId);
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x000FC086 File Offset: 0x000FA286
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x000FC090 File Offset: 0x000FA290
		[SkipLocalsInit]
		public unsafe void Broadcast(int State)
		{
			FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams* ptr = stackalloc FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroNearbyTransferEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AADD RID: 43741 RVA: 0x000FC0CC File Offset: 0x000FA2CC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x04004925 RID: 18725
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004926 RID: 18726
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OHNearby.KuroNearbyTransferEvent__DelegateSignature";

		// Token: 0x04004927 RID: 18727
		private static int RegisterId;

		// Token: 0x02000F65 RID: 3941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroNearbyTransferEvent_DelegateParams
		{
			// Token: 0x0400633C RID: 25404
			[FieldOffset(0)]
			public int State;
		}

		// Token: 0x02000F66 RID: 3942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400633D RID: 25405
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
