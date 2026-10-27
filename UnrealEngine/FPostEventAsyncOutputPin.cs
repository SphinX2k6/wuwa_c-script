using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029C RID: 668
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPostEventAsyncOutputPin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x00037842 File Offset: 0x00035A42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostEventAsyncOutputPin.StaticFunctionPtr();
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0003784E File Offset: 0x00035A4E
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostEventAsyncOutputPin._FunctionPtr == IntPtr.Zero)
			{
				FPostEventAsyncOutputPin._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature");
			}
			return FPostEventAsyncOutputPin._FunctionPtr;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00037871 File Offset: 0x00035A71
		public FPostEventAsyncOutputPin()
		{
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00037879 File Offset: 0x00035A79
		[NullableContext(2)]
		public FPostEventAsyncOutputPin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00037883 File Offset: 0x00035A83
		public FPostEventAsyncOutputPin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0003788E File Offset: 0x00035A8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000378C0 File Offset: 0x00035AC0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FPostEventAsyncOutputPin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostEventAsyncOutputPin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostEventAsyncOutputPin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostEventAsyncOutputPin.OnScriptCallback));
				}
				FPostEventAsyncOutputPin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPostEventAsyncOutputPin.RegisterId);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000378FA File Offset: 0x00035AFA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00037904 File Offset: 0x00035B04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int PlayingID)
		{
			FPostEventAsyncOutputPin.__FPostEventAsyncOutputPin_DelegateParams* ptr = stackalloc FPostEventAsyncOutputPin.__FPostEventAsyncOutputPin_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPostEventAsyncOutputPin.__FPostEventAsyncOutputPin_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostEventAsyncOutputPin.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00037940 File Offset: 0x00035B40
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
			action(((FPostEventAsyncOutputPin.__FPostEventAsyncOutputPin_DelegateParams*)__Parameters)->PlayingID);
		}

		// Token: 0x04000E21 RID: 3617
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E22 RID: 3618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature";

		// Token: 0x04000E23 RID: 3619
		private static int RegisterId;

		// Token: 0x02002BA7 RID: 11175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPostEventAsyncOutputPin_DelegateParams
		{
			// Token: 0x0401643D RID: 91197
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02002BA8 RID: 11176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401643E RID: 91198
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
