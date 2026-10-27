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
	public sealed class FTrackableDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600378C RID: 14220 RVA: 0x000547BA File Offset: 0x000529BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackableDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000547C6 File Offset: 0x000529C6
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackableDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackableDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackableDelegate__DelegateSignature");
			}
			return FTrackableDelegate._FunctionPtr;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x000547E9 File Offset: 0x000529E9
		public FTrackableDelegate()
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000547F1 File Offset: 0x000529F1
		[NullableContext(2)]
		public FTrackableDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x000547FB File Offset: 0x000529FB
		public FTrackableDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00054806 File Offset: 0x00052A06
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARTrackedGeometry>) ?? ((Action<UARTrackedGeometry>)Delegate.CreateDelegate(typeof(Action<UARTrackedGeometry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x00054838 File Offset: 0x00052A38
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedGeometry> Callback)
		{
			if (FTrackableDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackableDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackableDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackableDelegate.OnScriptCallback));
				}
				FTrackableDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackableDelegate.RegisterId);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00054872 File Offset: 0x00052A72
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedGeometry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0005487C File Offset: 0x00052A7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARTrackedGeometry TrackedGeometry)
		{
			FTrackableDelegate.__FTrackableDelegate_DelegateParams* ptr = stackalloc FTrackableDelegate.__FTrackableDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackableDelegate.__FTrackableDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackableDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedGeometry = ((TrackedGeometry != null) ? TrackedGeometry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000548C8 File Offset: 0x00052AC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARTrackedGeometry> action = target as Action<UARTrackedGeometry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARTrackedGeometry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedGeometry>(((FTrackableDelegate.__FTrackableDelegate_DelegateParams*)__Parameters)->TrackedGeometry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400193C RID: 6460
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400193D RID: 6461
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackableDelegate__DelegateSignature";

		// Token: 0x0400193E RID: 6462
		private static int RegisterId;

		// Token: 0x02002C2B RID: 11307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackableDelegate_DelegateParams
		{
			// Token: 0x04016534 RID: 91444
			[FieldOffset(0)]
			public IntPtr TrackedGeometry;
		}

		// Token: 0x02002C2C RID: 11308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016535 RID: 91445
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
