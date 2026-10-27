using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A9 RID: 5033
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMovementModeChangedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601278C RID: 75660 RVA: 0x001B2782 File Offset: 0x001B0982
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMovementModeChangedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601278D RID: 75661 RVA: 0x001B278E File Offset: 0x001B098E
		private static IntPtr StaticFunctionPtr()
		{
			if (FMovementModeChangedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FMovementModeChangedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.MovementModeChangedDelegate__DelegateSignature");
			}
			return FMovementModeChangedDelegate._FunctionPtr;
		}

		// Token: 0x0601278E RID: 75662 RVA: 0x001B27B1 File Offset: 0x001B09B1
		public FMovementModeChangedDelegate()
		{
		}

		// Token: 0x0601278F RID: 75663 RVA: 0x001B27B9 File Offset: 0x001B09B9
		[NullableContext(2)]
		public FMovementModeChangedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012790 RID: 75664 RVA: 0x001B27C3 File Offset: 0x001B09C3
		public FMovementModeChangedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012791 RID: 75665 RVA: 0x001B27CE File Offset: 0x001B09CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EMovementMode>>) ?? ((Action<TEnumAsByte<EMovementMode>>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EMovementMode>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012792 RID: 75666 RVA: 0x001B2800 File Offset: 0x001B0A00
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EMovementMode>> Callback)
		{
			if (FMovementModeChangedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMovementModeChangedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMovementModeChangedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMovementModeChangedDelegate.OnScriptCallback));
				}
				FMovementModeChangedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMovementModeChangedDelegate.RegisterId);
		}

		// Token: 0x06012793 RID: 75667 RVA: 0x001B283A File Offset: 0x001B0A3A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EMovementMode>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012794 RID: 75668 RVA: 0x001B2844 File Offset: 0x001B0A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EMovementMode NewMovementMode)
		{
			FMovementModeChangedDelegate.__FMovementModeChangedDelegate_DelegateParams* ptr = stackalloc FMovementModeChangedDelegate.__FMovementModeChangedDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FMovementModeChangedDelegate.__FMovementModeChangedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMovementModeChangedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewMovementMode = NewMovementMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012795 RID: 75669 RVA: 0x001B2888 File Offset: 0x001B0A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EMovementMode>> action = target as Action<TEnumAsByte<EMovementMode>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FMovementModeChangedDelegate.__FMovementModeChangedDelegate_DelegateParams*)__Parameters)->NewMovementMode);
		}

		// Token: 0x04009E30 RID: 40496
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E31 RID: 40497
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.MovementModeChangedDelegate__DelegateSignature";

		// Token: 0x04009E32 RID: 40498
		private static int RegisterId;

		// Token: 0x02002E49 RID: 11849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FMovementModeChangedDelegate_DelegateParams
		{
			// Token: 0x04016903 RID: 92419
			[FieldOffset(0)]
			public TEnumAsByte<EMovementMode> NewMovementMode;
		}

		// Token: 0x02002E4A RID: 11850
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016904 RID: 92420
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
