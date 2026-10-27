using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000410 RID: 1040
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackablePointDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060037C8 RID: 14280 RVA: 0x00054FF9 File Offset: 0x000531F9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackablePointDelegate.StaticFunctionPtr();
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00055005 File Offset: 0x00053205
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackablePointDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackablePointDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackablePointDelegate__DelegateSignature");
			}
			return FTrackablePointDelegate._FunctionPtr;
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00055028 File Offset: 0x00053228
		public FTrackablePointDelegate()
		{
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00055030 File Offset: 0x00053230
		[NullableContext(2)]
		public FTrackablePointDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0005503A File Offset: 0x0005323A
		public FTrackablePointDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00055045 File Offset: 0x00053245
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARTrackedPoint>) ?? ((Action<UARTrackedPoint>)Delegate.CreateDelegate(typeof(Action<UARTrackedPoint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00055077 File Offset: 0x00053277
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedPoint> Callback)
		{
			if (FTrackablePointDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackablePointDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackablePointDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackablePointDelegate.OnScriptCallback));
				}
				FTrackablePointDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackablePointDelegate.RegisterId);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x000550B1 File Offset: 0x000532B1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedPoint> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x000550BC File Offset: 0x000532BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARTrackedPoint TrackedPoint)
		{
			FTrackablePointDelegate.__FTrackablePointDelegate_DelegateParams* ptr = stackalloc FTrackablePointDelegate.__FTrackablePointDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackablePointDelegate.__FTrackablePointDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackablePointDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedPoint = ((TrackedPoint != null) ? TrackedPoint.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00055108 File Offset: 0x00053308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARTrackedPoint> action = target as Action<UARTrackedPoint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARTrackedPoint orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedPoint>(((FTrackablePointDelegate.__FTrackablePointDelegate_DelegateParams*)__Parameters)->TrackedPoint);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400194E RID: 6478
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400194F RID: 6479
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackablePointDelegate__DelegateSignature";

		// Token: 0x04001950 RID: 6480
		private static int RegisterId;

		// Token: 0x02002C37 RID: 11319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackablePointDelegate_DelegateParams
		{
			// Token: 0x04016540 RID: 91456
			[FieldOffset(0)]
			public IntPtr TrackedPoint;
		}

		// Token: 0x02002C38 RID: 11320
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016541 RID: 91457
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
