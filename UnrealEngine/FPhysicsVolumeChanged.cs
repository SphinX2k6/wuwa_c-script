using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FEB RID: 4075
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FPhysicsVolumeChanged : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DCB2 RID: 56498 RVA: 0x00144D8B File Offset: 0x00142F8B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPhysicsVolumeChanged.StaticFunctionPtr();
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x00144D97 File Offset: 0x00142F97
		private static IntPtr StaticFunctionPtr()
		{
			if (FPhysicsVolumeChanged._FunctionPtr == IntPtr.Zero)
			{
				FPhysicsVolumeChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PhysicsVolumeChanged__DelegateSignature");
			}
			return FPhysicsVolumeChanged._FunctionPtr;
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x00144DBA File Offset: 0x00142FBA
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.PhysicsVolumeChangedDelegate;
			}
		}

		// Token: 0x0600DCB5 RID: 56501 RVA: 0x00144DC1 File Offset: 0x00142FC1
		[NullableContext(2)]
		public FPhysicsVolumeChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DCB6 RID: 56502 RVA: 0x00144DCB File Offset: 0x00142FCB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APhysicsVolume>) ?? ((Action<APhysicsVolume>)Delegate.CreateDelegate(typeof(Action<APhysicsVolume>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DCB7 RID: 56503 RVA: 0x00144E00 File Offset: 0x00143000
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<APhysicsVolume> Callback)
		{
			if (FPhysicsVolumeChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPhysicsVolumeChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPhysicsVolumeChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPhysicsVolumeChanged.OnScriptCallback));
				}
				FPhysicsVolumeChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FPhysicsVolumeChanged.RegisterId);
		}

		// Token: 0x0600DCB8 RID: 56504 RVA: 0x00144E50 File Offset: 0x00143050
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<APhysicsVolume> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600DCB9 RID: 56505 RVA: 0x00144E70 File Offset: 0x00143070
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(APhysicsVolume NewVolume)
		{
			FPhysicsVolumeChanged.__FPhysicsVolumeChanged_DelegateParams* ptr = stackalloc FPhysicsVolumeChanged.__FPhysicsVolumeChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPhysicsVolumeChanged.__FPhysicsVolumeChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPhysicsVolumeChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewVolume = ((NewVolume != null) ? NewVolume.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600DCBA RID: 56506 RVA: 0x00144ECC File Offset: 0x001430CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APhysicsVolume> action = target as Action<APhysicsVolume>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APhysicsVolume orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APhysicsVolume>(((FPhysicsVolumeChanged.__FPhysicsVolumeChanged_DelegateParams*)__Parameters)->NewVolume);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400773E RID: 30526
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400773F RID: 30527
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PhysicsVolumeChanged__DelegateSignature";

		// Token: 0x04007740 RID: 30528
		private static int RegisterId;

		// Token: 0x02002DBF RID: 11711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPhysicsVolumeChanged_DelegateParams
		{
			// Token: 0x040167F7 RID: 92151
			[FieldOffset(0)]
			public IntPtr NewVolume;
		}

		// Token: 0x02002DC0 RID: 11712
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167F8 RID: 92152
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
