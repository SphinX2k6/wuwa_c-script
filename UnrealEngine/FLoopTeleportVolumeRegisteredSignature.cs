using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191C RID: 6428
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLoopTeleportVolumeRegisteredSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DA4 RID: 97700 RVA: 0x0022EE24 File Offset: 0x0022D024
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLoopTeleportVolumeRegisteredSignature.StaticFunctionPtr();
		}

		// Token: 0x06017DA5 RID: 97701 RVA: 0x0022EE30 File Offset: 0x0022D030
		private static IntPtr StaticFunctionPtr()
		{
			if (FLoopTeleportVolumeRegisteredSignature._FunctionPtr == IntPtr.Zero)
			{
				FLoopTeleportVolumeRegisteredSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.LoopTeleportVolumeRegisteredSignature__DelegateSignature");
			}
			return FLoopTeleportVolumeRegisteredSignature._FunctionPtr;
		}

		// Token: 0x06017DA6 RID: 97702 RVA: 0x0022EE53 File Offset: 0x0022D053
		public FLoopTeleportVolumeRegisteredSignature()
		{
		}

		// Token: 0x06017DA7 RID: 97703 RVA: 0x0022EE5B File Offset: 0x0022D05B
		[NullableContext(2)]
		public FLoopTeleportVolumeRegisteredSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DA8 RID: 97704 RVA: 0x0022EE65 File Offset: 0x0022D065
		public FLoopTeleportVolumeRegisteredSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DA9 RID: 97705 RVA: 0x0022EE70 File Offset: 0x0022D070
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroLoopTeleportVolume>) ?? ((Action<AKuroLoopTeleportVolume>)Delegate.CreateDelegate(typeof(Action<AKuroLoopTeleportVolume>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DAA RID: 97706 RVA: 0x0022EEA2 File Offset: 0x0022D0A2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLoopTeleportVolume> Callback)
		{
			if (FLoopTeleportVolumeRegisteredSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLoopTeleportVolumeRegisteredSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLoopTeleportVolumeRegisteredSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLoopTeleportVolumeRegisteredSignature.OnScriptCallback));
				}
				FLoopTeleportVolumeRegisteredSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLoopTeleportVolumeRegisteredSignature.RegisterId);
		}

		// Token: 0x06017DAB RID: 97707 RVA: 0x0022EEDC File Offset: 0x0022D0DC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLoopTeleportVolume> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017DAC RID: 97708 RVA: 0x0022EEE8 File Offset: 0x0022D0E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AKuroLoopTeleportVolume Volume)
		{
			FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams* ptr = stackalloc FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLoopTeleportVolumeRegisteredSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Volume = ((Volume != null) ? Volume.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06017DAD RID: 97709 RVA: 0x0022EF34 File Offset: 0x0022D134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AKuroLoopTeleportVolume> action = target as Action<AKuroLoopTeleportVolume>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AKuroLoopTeleportVolume orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroLoopTeleportVolume>(((FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams*)__Parameters)->Volume);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400CEC5 RID: 52933
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEC6 RID: 52934
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.LoopTeleportVolumeRegisteredSignature__DelegateSignature";

		// Token: 0x0400CEC7 RID: 52935
		private static int RegisterId;

		// Token: 0x02002FE1 RID: 12257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLoopTeleportVolumeRegisteredSignature_DelegateParams
		{
			// Token: 0x04016BDB RID: 93147
			[FieldOffset(0)]
			public IntPtr Volume;
		}

		// Token: 0x02002FE2 RID: 12258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BDC RID: 93148
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
