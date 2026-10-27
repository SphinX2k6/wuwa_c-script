using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002610 RID: 9744
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroNearbyTransferEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060243F3 RID: 148467 RVA: 0x0035AADE File Offset: 0x00358CDE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNearbyTransferEvent.StaticFunctionPtr();
		}

		// Token: 0x060243F4 RID: 148468 RVA: 0x0035AAEA File Offset: 0x00358CEA
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNearbyTransferEvent._FunctionPtr == IntPtr.Zero)
			{
				FKuroNearbyTransferEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/OHNearby.KuroNearbyTransferEvent__DelegateSignature");
			}
			return FKuroNearbyTransferEvent._FunctionPtr;
		}

		// Token: 0x060243F5 RID: 148469 RVA: 0x0035AB0D File Offset: 0x00358D0D
		public FKuroNearbyTransferEvent()
		{
		}

		// Token: 0x060243F6 RID: 148470 RVA: 0x0035AB15 File Offset: 0x00358D15
		[NullableContext(2)]
		public FKuroNearbyTransferEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243F7 RID: 148471 RVA: 0x0035AB1F File Offset: 0x00358D1F
		public FKuroNearbyTransferEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243F8 RID: 148472 RVA: 0x0035AB2A File Offset: 0x00358D2A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060243F9 RID: 148473 RVA: 0x0035AB5C File Offset: 0x00358D5C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060243FA RID: 148474 RVA: 0x0035AB96 File Offset: 0x00358D96
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060243FB RID: 148475 RVA: 0x0035ABA0 File Offset: 0x00358DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int State)
		{
			FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams* ptr = stackalloc FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroNearbyTransferEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060243FC RID: 148476 RVA: 0x0035ABDC File Offset: 0x00358DDC
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
			action(((FKuroNearbyTransferEvent.__FKuroNearbyTransferEvent_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x04013727 RID: 79655
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013728 RID: 79656
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OHNearby.KuroNearbyTransferEvent__DelegateSignature";

		// Token: 0x04013729 RID: 79657
		private static int RegisterId;

		// Token: 0x0200367C RID: 13948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroNearbyTransferEvent_DelegateParams
		{
			// Token: 0x04017754 RID: 96084
			[FieldOffset(0)]
			public int State;
		}

		// Token: 0x0200367D RID: 13949
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017755 RID: 96085
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
