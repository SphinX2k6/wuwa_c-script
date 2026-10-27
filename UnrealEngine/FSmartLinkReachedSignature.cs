using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E0 RID: 480
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSmartLinkReachedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001C5E RID: 7262 RVA: 0x0002A551 File Offset: 0x00028751
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSmartLinkReachedSignature.StaticFunctionPtr();
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0002A55D File Offset: 0x0002875D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSmartLinkReachedSignature._FunctionPtr == IntPtr.Zero)
			{
				FSmartLinkReachedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.SmartLinkReachedSignature__DelegateSignature");
			}
			return FSmartLinkReachedSignature._FunctionPtr;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0002A580 File Offset: 0x00028780
		public FSmartLinkReachedSignature()
		{
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0002A588 File Offset: 0x00028788
		[NullableContext(2)]
		public FSmartLinkReachedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0002A592 File Offset: 0x00028792
		public FSmartLinkReachedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0002A59D File Offset: 0x0002879D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FVector>) ?? ((Action<AActor, FVector>)Delegate.CreateDelegate(typeof(Action<AActor, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0002A5CF File Offset: 0x000287CF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, FVector> Callback)
		{
			if (FSmartLinkReachedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSmartLinkReachedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSmartLinkReachedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSmartLinkReachedSignature.OnScriptCallback));
				}
				FSmartLinkReachedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSmartLinkReachedSignature.RegisterId);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0002A609 File Offset: 0x00028809
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0002A614 File Offset: 0x00028814
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor MovingActor, in FVector DestinationPoint)
		{
			FSmartLinkReachedSignature.__FSmartLinkReachedSignature_DelegateParams* ptr = stackalloc FSmartLinkReachedSignature.__FSmartLinkReachedSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSmartLinkReachedSignature.__FSmartLinkReachedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSmartLinkReachedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MovingActor = ((MovingActor != null) ? MovingActor.NativePtr : IntPtr.Zero);
			ptr->DestinationPoint = DestinationPoint;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0002A66C File Offset: 0x0002886C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FVector> action = target as Action<AActor, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSmartLinkReachedSignature.__FSmartLinkReachedSignature_DelegateParams*)__Parameters)->MovingActor);
			action(orCreateUObjectByNativePointer, ((FSmartLinkReachedSignature.__FSmartLinkReachedSignature_DelegateParams*)__Parameters)->DestinationPoint);
		}

		// Token: 0x0400093D RID: 2365
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400093E RID: 2366
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.SmartLinkReachedSignature__DelegateSignature";

		// Token: 0x0400093F RID: 2367
		private static int RegisterId;

		// Token: 0x02002B7B RID: 11131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSmartLinkReachedSignature_DelegateParams
		{
			// Token: 0x04016405 RID: 91141
			[FieldOffset(0)]
			public IntPtr MovingActor;

			// Token: 0x04016406 RID: 91142
			[FieldOffset(8)]
			public FVector DestinationPoint;
		}

		// Token: 0x02002B7C RID: 11132
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016407 RID: 91143
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
