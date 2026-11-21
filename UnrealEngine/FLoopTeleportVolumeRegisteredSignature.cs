using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040A RID: 1034
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLoopTeleportVolumeRegisteredSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600651A RID: 25882 RVA: 0x00090424 File Offset: 0x0008E624
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLoopTeleportVolumeRegisteredSignature.StaticFunctionPtr();
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00090430 File Offset: 0x0008E630
		private static IntPtr StaticFunctionPtr()
		{
			if (FLoopTeleportVolumeRegisteredSignature._FunctionPtr == IntPtr.Zero)
			{
				FLoopTeleportVolumeRegisteredSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.LoopTeleportVolumeRegisteredSignature__DelegateSignature");
			}
			return FLoopTeleportVolumeRegisteredSignature._FunctionPtr;
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00090453 File Offset: 0x0008E653
		public FLoopTeleportVolumeRegisteredSignature()
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0009045B File Offset: 0x0008E65B
		[NullableContext(2)]
		public FLoopTeleportVolumeRegisteredSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00090465 File Offset: 0x0008E665
		public FLoopTeleportVolumeRegisteredSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00090470 File Offset: 0x0008E670
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroLoopTeleportVolume>) ?? ((Action<AKuroLoopTeleportVolume>)Delegate.CreateDelegate(typeof(Action<AKuroLoopTeleportVolume>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x000904A2 File Offset: 0x0008E6A2
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

		// Token: 0x06006521 RID: 25889 RVA: 0x000904DC File Offset: 0x0008E6DC
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLoopTeleportVolume> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x000904E8 File Offset: 0x0008E6E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AKuroLoopTeleportVolume Volume)
		{
			FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams* ptr = stackalloc FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLoopTeleportVolumeRegisteredSignature.__FLoopTeleportVolumeRegisteredSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLoopTeleportVolumeRegisteredSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Volume = ((Volume != null) ? Volume.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x00090534 File Offset: 0x0008E734
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002A8A RID: 10890
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A8B RID: 10891
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.LoopTeleportVolumeRegisteredSignature__DelegateSignature";

		// Token: 0x04002A8C RID: 10892
		private static int RegisterId;

		// Token: 0x02000AF5 RID: 2805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLoopTeleportVolumeRegisteredSignature_DelegateParams
		{
			// Token: 0x04005B84 RID: 23428
			[FieldOffset(0)]
			public IntPtr Volume;
		}

		// Token: 0x02000AF6 RID: 2806
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B85 RID: 23429
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
