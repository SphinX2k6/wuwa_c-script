using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine.Script
{
	// Token: 0x02000889 RID: 2185
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnControllerConnectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BD7E RID: 48510 RVA: 0x0012E5A0 File Offset: 0x0012C7A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnControllerConnectionChanged.StaticFunctionPtr();
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x0012E5AC File Offset: 0x0012C7AC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnControllerConnectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnControllerConnectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnControllerConnectionChanged__DelegateSignature");
			}
			return FOnControllerConnectionChanged._FunctionPtr;
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x0012E5CF File Offset: 0x0012C7CF
		public FOnControllerConnectionChanged()
		{
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x0012E5D7 File Offset: 0x0012C7D7
		[NullableContext(2)]
		public FOnControllerConnectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x0012E5E1 File Offset: 0x0012C7E1
		public FOnControllerConnectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x0012E5EC File Offset: 0x0012C7EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, int>) ?? ((Action<bool, int, int>)Delegate.CreateDelegate(typeof(Action<bool, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x0012E61E File Offset: 0x0012C81E
		[NullableContext(1)]
		public void Add(Action<bool, int, int> Callback)
		{
			if (FOnControllerConnectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnControllerConnectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnControllerConnectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnControllerConnectionChanged.OnScriptCallback));
				}
				FOnControllerConnectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnControllerConnectionChanged.RegisterId);
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x0012E658 File Offset: 0x0012C858
		[NullableContext(1)]
		public void Remove(Action<bool, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x0012E664 File Offset: 0x0012C864
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bIsConnected, int PlatformUserId, int ControllerId)
		{
			FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams* ptr = stackalloc FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnControllerConnectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsConnected = bIsConnected;
			ptr->PlatformUserId = PlatformUserId;
			ptr->ControllerId = ControllerId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x0012E6B0 File Offset: 0x0012C8B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, int> action = target as Action<bool, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->bIsConnected, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->PlatformUserId, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->ControllerId);
		}

		// Token: 0x04005696 RID: 22166
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005697 RID: 22167
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnControllerConnectionChanged__DelegateSignature";

		// Token: 0x04005698 RID: 22168
		private static int RegisterId;

		// Token: 0x02001413 RID: 5139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FOnControllerConnectionChanged_DelegateParams
		{
			// Token: 0x040068C1 RID: 26817
			[FieldOffset(0)]
			public bool bIsConnected;

			// Token: 0x040068C2 RID: 26818
			[FieldOffset(4)]
			public int PlatformUserId;

			// Token: 0x040068C3 RID: 26819
			[FieldOffset(8)]
			public int ControllerId;
		}

		// Token: 0x02001414 RID: 5140
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068C4 RID: 26820
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
