using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001823 RID: 6179
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnReceiveCommandEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016D20 RID: 93472 RVA: 0x0021515C File Offset: 0x0021335C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceiveCommandEvent.StaticFunctionPtr();
		}

		// Token: 0x06016D21 RID: 93473 RVA: 0x00215168 File Offset: 0x00213368
		private static IntPtr StaticFunctionPtr()
		{
			if (UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.CommandService:OnReceiveCommandEvent__DelegateSignature");
			}
			return UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x0021518B File Offset: 0x0021338B
		public FOnReceiveCommandEvent()
		{
		}

		// Token: 0x06016D23 RID: 93475 RVA: 0x00215193 File Offset: 0x00213393
		[NullableContext(2)]
		public FOnReceiveCommandEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D24 RID: 93476 RVA: 0x0021519D File Offset: 0x0021339D
		public FOnReceiveCommandEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x002151A8 File Offset: 0x002133A8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x002151DA File Offset: 0x002133DA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnReceiveCommandEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceiveCommandEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceiveCommandEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceiveCommandEvent.OnScriptCallback));
				}
				FOnReceiveCommandEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnReceiveCommandEvent.RegisterId);
		}

		// Token: 0x06016D27 RID: 93479 RVA: 0x00215214 File Offset: 0x00213414
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016D28 RID: 93480 RVA: 0x00215220 File Offset: 0x00213420
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string ReceiveData)
		{
			FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams* ptr = stackalloc FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceiveCommandEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ReceiveData), ReceiveData);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016D29 RID: 93481 RVA: 0x00215274 File Offset: 0x00213474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams*)__Parameters)->ReceiveData));
			action(obj);
		}

		// Token: 0x0400C654 RID: 50772
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.CommandService:OnReceiveCommandEvent__DelegateSignature";

		// Token: 0x0400C655 RID: 50773
		private static int RegisterId;

		// Token: 0x02002F64 RID: 12132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnReceiveCommandEvent_DelegateParams
		{
			// Token: 0x04016B1B RID: 92955
			[FieldOffset(0)]
			public FString ReceiveData;
		}

		// Token: 0x02002F65 RID: 12133
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B1C RID: 92956
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
