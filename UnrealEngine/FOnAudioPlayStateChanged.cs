using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F08 RID: 3848
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioPlayStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D040 RID: 53312 RVA: 0x0012FF9F File Offset: 0x0012E19F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioPlayStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x0012FFAB File Offset: 0x0012E1AB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioPlayStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioPlayStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioPlayStateChanged__DelegateSignature");
			}
			return FOnAudioPlayStateChanged._FunctionPtr;
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x0012FFCE File Offset: 0x0012E1CE
		public FOnAudioPlayStateChanged()
		{
		}

		// Token: 0x0600D043 RID: 53315 RVA: 0x0012FFD6 File Offset: 0x0012E1D6
		[NullableContext(2)]
		public FOnAudioPlayStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D044 RID: 53316 RVA: 0x0012FFE0 File Offset: 0x0012E1E0
		public FOnAudioPlayStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x0012FFEB File Offset: 0x0012E1EB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EAudioComponentPlayState>) ?? ((Action<EAudioComponentPlayState>)Delegate.CreateDelegate(typeof(Action<EAudioComponentPlayState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x0013001D File Offset: 0x0012E21D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EAudioComponentPlayState> Callback)
		{
			if (FOnAudioPlayStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioPlayStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioPlayStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioPlayStateChanged.OnScriptCallback));
				}
				FOnAudioPlayStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioPlayStateChanged.RegisterId);
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x00130057 File Offset: 0x0012E257
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EAudioComponentPlayState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x00130060 File Offset: 0x0012E260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EAudioComponentPlayState PlayState)
		{
			FOnAudioPlayStateChanged.__FOnAudioPlayStateChanged_DelegateParams* ptr = stackalloc FOnAudioPlayStateChanged.__FOnAudioPlayStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnAudioPlayStateChanged.__FOnAudioPlayStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioPlayStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PlayState = PlayState;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x0013009C File Offset: 0x0012E29C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EAudioComponentPlayState> action = target as Action<EAudioComponentPlayState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAudioPlayStateChanged.__FOnAudioPlayStateChanged_DelegateParams*)__Parameters)->PlayState);
		}

		// Token: 0x0400702D RID: 28717
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400702E RID: 28718
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioPlayStateChanged__DelegateSignature";

		// Token: 0x0400702F RID: 28719
		private static int RegisterId;

		// Token: 0x02002D5F RID: 11615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnAudioPlayStateChanged_DelegateParams
		{
			// Token: 0x04016776 RID: 92022
			[FieldOffset(0)]
			public EAudioComponentPlayState PlayState;
		}

		// Token: 0x02002D60 RID: 11616
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016777 RID: 92023
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
