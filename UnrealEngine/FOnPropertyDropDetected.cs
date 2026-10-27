using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000295 RID: 661
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPropertyDropDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024F1 RID: 9457 RVA: 0x000370FA File Offset: 0x000352FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPropertyDropDetected.StaticFunctionPtr();
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00037106 File Offset: 0x00035306
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPropertyDropDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnPropertyDropDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnPropertyDropDetected__DelegateSignature");
			}
			return FOnPropertyDropDetected._FunctionPtr;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00037129 File Offset: 0x00035329
		public FOnPropertyDropDetected()
		{
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00037131 File Offset: 0x00035331
		[NullableContext(2)]
		public FOnPropertyDropDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0003713B File Offset: 0x0003533B
		public FOnPropertyDropDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00037146 File Offset: 0x00035346
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00037178 File Offset: 0x00035378
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnPropertyDropDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPropertyDropDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPropertyDropDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPropertyDropDetected.OnScriptCallback));
				}
				FOnPropertyDropDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPropertyDropDetected.RegisterId);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000371B2 File Offset: 0x000353B2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000371BC File Offset: 0x000353BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertyDropped)
		{
			FOnPropertyDropDetected.__FOnPropertyDropDetected_DelegateParams* ptr = stackalloc FOnPropertyDropDetected.__FOnPropertyDropDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPropertyDropDetected.__FOnPropertyDropDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPropertyDropDetected.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertyDropped), PropertyDropped);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnPropertyDropDetected._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00037210 File Offset: 0x00035410
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
			string obj = FString.ToString((void*)(&((FOnPropertyDropDetected.__FOnPropertyDropDetected_DelegateParams*)__Parameters)->PropertyDropped));
			action(obj);
		}

		// Token: 0x04000E09 RID: 3593
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E0A RID: 3594
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnPropertyDropDetected__DelegateSignature";

		// Token: 0x04000E0B RID: 3595
		private static int RegisterId;

		// Token: 0x02002B9F RID: 11167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPropertyDropDetected_DelegateParams
		{
			// Token: 0x04016435 RID: 91189
			[FieldOffset(0)]
			public FString PropertyDropped;
		}

		// Token: 0x02002BA0 RID: 11168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016436 RID: 91190
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
