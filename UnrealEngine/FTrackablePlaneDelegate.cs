using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040F RID: 1039
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackablePlaneDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x00054E99 File Offset: 0x00053099
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackablePlaneDelegate.StaticFunctionPtr();
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00054EA5 File Offset: 0x000530A5
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackablePlaneDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackablePlaneDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackablePlaneDelegate__DelegateSignature");
			}
			return FTrackablePlaneDelegate._FunctionPtr;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00054EC8 File Offset: 0x000530C8
		public FTrackablePlaneDelegate()
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00054ED0 File Offset: 0x000530D0
		[NullableContext(2)]
		public FTrackablePlaneDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00054EDA File Offset: 0x000530DA
		public FTrackablePlaneDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00054EE5 File Offset: 0x000530E5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARPlaneGeometry>) ?? ((Action<UARPlaneGeometry>)Delegate.CreateDelegate(typeof(Action<UARPlaneGeometry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00054F17 File Offset: 0x00053117
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARPlaneGeometry> Callback)
		{
			if (FTrackablePlaneDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackablePlaneDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackablePlaneDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackablePlaneDelegate.OnScriptCallback));
				}
				FTrackablePlaneDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackablePlaneDelegate.RegisterId);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00054F51 File Offset: 0x00053151
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARPlaneGeometry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00054F5C File Offset: 0x0005315C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARPlaneGeometry TrackedPlane)
		{
			FTrackablePlaneDelegate.__FTrackablePlaneDelegate_DelegateParams* ptr = stackalloc FTrackablePlaneDelegate.__FTrackablePlaneDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackablePlaneDelegate.__FTrackablePlaneDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackablePlaneDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedPlane = ((TrackedPlane != null) ? TrackedPlane.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00054FA8 File Offset: 0x000531A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARPlaneGeometry> action = target as Action<UARPlaneGeometry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARPlaneGeometry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARPlaneGeometry>(((FTrackablePlaneDelegate.__FTrackablePlaneDelegate_DelegateParams*)__Parameters)->TrackedPlane);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400194B RID: 6475
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400194C RID: 6476
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackablePlaneDelegate__DelegateSignature";

		// Token: 0x0400194D RID: 6477
		private static int RegisterId;

		// Token: 0x02002C35 RID: 11317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackablePlaneDelegate_DelegateParams
		{
			// Token: 0x0401653E RID: 91454
			[FieldOffset(0)]
			public IntPtr TrackedPlane;
		}

		// Token: 0x02002C36 RID: 11318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401653F RID: 91455
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
