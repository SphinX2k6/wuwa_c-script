using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C6E RID: 7278
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTunnelFlickSwitch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C376 RID: 115574 RVA: 0x00299A48 File Offset: 0x00297C48
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTunnelFlickSwitch.StaticFunctionPtr();
		}

		// Token: 0x0601C377 RID: 115575 RVA: 0x00299A54 File Offset: 0x00297C54
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTunnelFlickSwitch._FunctionPtr == IntPtr.Zero)
			{
				FOnTunnelFlickSwitch._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnTunnelFlickSwitch__DelegateSignature");
			}
			return FOnTunnelFlickSwitch._FunctionPtr;
		}

		// Token: 0x0601C378 RID: 115576 RVA: 0x00299A77 File Offset: 0x00297C77
		public FOnTunnelFlickSwitch()
		{
		}

		// Token: 0x0601C379 RID: 115577 RVA: 0x00299A7F File Offset: 0x00297C7F
		[NullableContext(2)]
		public FOnTunnelFlickSwitch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C37A RID: 115578 RVA: 0x00299A89 File Offset: 0x00297C89
		public FOnTunnelFlickSwitch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C37B RID: 115579 RVA: 0x00299A94 File Offset: 0x00297C94
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C37C RID: 115580 RVA: 0x00299AC6 File Offset: 0x00297CC6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnTunnelFlickSwitch.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTunnelFlickSwitch.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTunnelFlickSwitch.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTunnelFlickSwitch.OnScriptCallback));
				}
				FOnTunnelFlickSwitch.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTunnelFlickSwitch.RegisterId);
		}

		// Token: 0x0601C37D RID: 115581 RVA: 0x00299B00 File Offset: 0x00297D00
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C37E RID: 115582 RVA: 0x00299B0C File Offset: 0x00297D0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bGoLeft)
		{
			FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams* ptr = stackalloc FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTunnelFlickSwitch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C37F RID: 115583 RVA: 0x00299B48 File Offset: 0x00297D48
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
			action(((FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams*)__Parameters)->bGoLeft);
		}

		// Token: 0x0400F2CE RID: 62158
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2CF RID: 62159
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnTunnelFlickSwitch__DelegateSignature";

		// Token: 0x0400F2D0 RID: 62160
		private static int RegisterId;

		// Token: 0x02003209 RID: 12809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnTunnelFlickSwitch_DelegateParams
		{
			// Token: 0x0401706C RID: 94316
			[FieldOffset(0)]
			public bool bGoLeft;
		}

		// Token: 0x0200320A RID: 12810
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401706D RID: 94317
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
