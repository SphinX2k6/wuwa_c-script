using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F0A RID: 3850
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioVirtualizationChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D054 RID: 53332 RVA: 0x00130253 File Offset: 0x0012E453
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioVirtualizationChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x0013025F File Offset: 0x0012E45F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioVirtualizationChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioVirtualizationChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature");
			}
			return FOnAudioVirtualizationChanged._FunctionPtr;
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x00130282 File Offset: 0x0012E482
		public FOnAudioVirtualizationChanged()
		{
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x0013028A File Offset: 0x0012E48A
		[NullableContext(2)]
		public FOnAudioVirtualizationChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D058 RID: 53336 RVA: 0x00130294 File Offset: 0x0012E494
		public FOnAudioVirtualizationChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D059 RID: 53337 RVA: 0x0013029F File Offset: 0x0012E49F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x001302D1 File Offset: 0x0012E4D1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnAudioVirtualizationChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioVirtualizationChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioVirtualizationChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioVirtualizationChanged.OnScriptCallback));
				}
				FOnAudioVirtualizationChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioVirtualizationChanged.RegisterId);
		}

		// Token: 0x0600D05B RID: 53339 RVA: 0x0013030B File Offset: 0x0012E50B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D05C RID: 53340 RVA: 0x00130314 File Offset: 0x0012E514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsVirtualized)
		{
			FOnAudioVirtualizationChanged.__FOnAudioVirtualizationChanged_DelegateParams* ptr = stackalloc FOnAudioVirtualizationChanged.__FOnAudioVirtualizationChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnAudioVirtualizationChanged.__FOnAudioVirtualizationChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioVirtualizationChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsVirtualized = bIsVirtualized;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x00130350 File Offset: 0x0012E550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAudioVirtualizationChanged.__FOnAudioVirtualizationChanged_DelegateParams*)__Parameters)->bIsVirtualized);
		}

		// Token: 0x04007033 RID: 28723
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007034 RID: 28724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature";

		// Token: 0x04007035 RID: 28725
		private static int RegisterId;

		// Token: 0x02002D63 RID: 11619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnAudioVirtualizationChanged_DelegateParams
		{
			// Token: 0x0401677B RID: 92027
			[FieldOffset(0)]
			public bool bIsVirtualized;
		}

		// Token: 0x02002D64 RID: 11620
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401677C RID: 92028
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
