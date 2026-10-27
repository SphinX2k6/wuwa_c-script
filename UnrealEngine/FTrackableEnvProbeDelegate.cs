using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040B RID: 1035
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackableEnvProbeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003796 RID: 14230 RVA: 0x00054919 File Offset: 0x00052B19
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackableEnvProbeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00054925 File Offset: 0x00052B25
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackableEnvProbeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackableEnvProbeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackableEnvProbeDelegate__DelegateSignature");
			}
			return FTrackableEnvProbeDelegate._FunctionPtr;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00054948 File Offset: 0x00052B48
		public FTrackableEnvProbeDelegate()
		{
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x00054950 File Offset: 0x00052B50
		[NullableContext(2)]
		public FTrackableEnvProbeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0005495A File Offset: 0x00052B5A
		public FTrackableEnvProbeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00054965 File Offset: 0x00052B65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAREnvironmentCaptureProbe>) ?? ((Action<UAREnvironmentCaptureProbe>)Delegate.CreateDelegate(typeof(Action<UAREnvironmentCaptureProbe>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00054997 File Offset: 0x00052B97
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAREnvironmentCaptureProbe> Callback)
		{
			if (FTrackableEnvProbeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackableEnvProbeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackableEnvProbeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackableEnvProbeDelegate.OnScriptCallback));
				}
				FTrackableEnvProbeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackableEnvProbeDelegate.RegisterId);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000549D1 File Offset: 0x00052BD1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAREnvironmentCaptureProbe> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000549DC File Offset: 0x00052BDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UAREnvironmentCaptureProbe TrackedEnvProbe)
		{
			FTrackableEnvProbeDelegate.__FTrackableEnvProbeDelegate_DelegateParams* ptr = stackalloc FTrackableEnvProbeDelegate.__FTrackableEnvProbeDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackableEnvProbeDelegate.__FTrackableEnvProbeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackableEnvProbeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedEnvProbe = ((TrackedEnvProbe != null) ? TrackedEnvProbe.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x00054A28 File Offset: 0x00052C28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAREnvironmentCaptureProbe> action = target as Action<UAREnvironmentCaptureProbe>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAREnvironmentCaptureProbe orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAREnvironmentCaptureProbe>(((FTrackableEnvProbeDelegate.__FTrackableEnvProbeDelegate_DelegateParams*)__Parameters)->TrackedEnvProbe);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400193F RID: 6463
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001940 RID: 6464
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackableEnvProbeDelegate__DelegateSignature";

		// Token: 0x04001941 RID: 6465
		private static int RegisterId;

		// Token: 0x02002C2D RID: 11309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackableEnvProbeDelegate_DelegateParams
		{
			// Token: 0x04016536 RID: 91446
			[FieldOffset(0)]
			public IntPtr TrackedEnvProbe;
		}

		// Token: 0x02002C2E RID: 11310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016537 RID: 91447
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
