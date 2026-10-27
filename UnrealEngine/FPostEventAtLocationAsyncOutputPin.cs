using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029E RID: 670
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPostEventAtLocationAsyncOutputPin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002540 RID: 9536 RVA: 0x00037AA0 File Offset: 0x00035CA0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostEventAtLocationAsyncOutputPin.StaticFunctionPtr();
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00037AAC File Offset: 0x00035CAC
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostEventAtLocationAsyncOutputPin._FunctionPtr == IntPtr.Zero)
			{
				FPostEventAtLocationAsyncOutputPin._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature");
			}
			return FPostEventAtLocationAsyncOutputPin._FunctionPtr;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00037ACF File Offset: 0x00035CCF
		public FPostEventAtLocationAsyncOutputPin()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00037AD7 File Offset: 0x00035CD7
		[NullableContext(2)]
		public FPostEventAtLocationAsyncOutputPin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00037AE1 File Offset: 0x00035CE1
		public FPostEventAtLocationAsyncOutputPin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00037AEC File Offset: 0x00035CEC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00037B1E File Offset: 0x00035D1E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FPostEventAtLocationAsyncOutputPin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostEventAtLocationAsyncOutputPin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostEventAtLocationAsyncOutputPin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostEventAtLocationAsyncOutputPin.OnScriptCallback));
				}
				FPostEventAtLocationAsyncOutputPin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPostEventAtLocationAsyncOutputPin.RegisterId);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00037B58 File Offset: 0x00035D58
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00037B64 File Offset: 0x00035D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int PlayingID)
		{
			FPostEventAtLocationAsyncOutputPin.__FPostEventAtLocationAsyncOutputPin_DelegateParams* ptr = stackalloc FPostEventAtLocationAsyncOutputPin.__FPostEventAtLocationAsyncOutputPin_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPostEventAtLocationAsyncOutputPin.__FPostEventAtLocationAsyncOutputPin_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostEventAtLocationAsyncOutputPin.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00037BA0 File Offset: 0x00035DA0
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
			action(((FPostEventAtLocationAsyncOutputPin.__FPostEventAtLocationAsyncOutputPin_DelegateParams*)__Parameters)->PlayingID);
		}

		// Token: 0x04000E29 RID: 3625
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E2A RID: 3626
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature";

		// Token: 0x04000E2B RID: 3627
		private static int RegisterId;

		// Token: 0x02002BA9 RID: 11177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPostEventAtLocationAsyncOutputPin_DelegateParams
		{
			// Token: 0x0401643F RID: 91199
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02002BAA RID: 11178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016440 RID: 91200
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
