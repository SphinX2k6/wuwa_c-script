using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040D RID: 1037
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackableImageDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060037AA RID: 14250 RVA: 0x00054BD9 File Offset: 0x00052DD9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackableImageDelegate.StaticFunctionPtr();
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00054BE5 File Offset: 0x00052DE5
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackableImageDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackableImageDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackableImageDelegate__DelegateSignature");
			}
			return FTrackableImageDelegate._FunctionPtr;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00054C08 File Offset: 0x00052E08
		public FTrackableImageDelegate()
		{
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00054C10 File Offset: 0x00052E10
		[NullableContext(2)]
		public FTrackableImageDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00054C1A File Offset: 0x00052E1A
		public FTrackableImageDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00054C25 File Offset: 0x00052E25
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARTrackedImage>) ?? ((Action<UARTrackedImage>)Delegate.CreateDelegate(typeof(Action<UARTrackedImage>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00054C57 File Offset: 0x00052E57
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedImage> Callback)
		{
			if (FTrackableImageDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackableImageDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackableImageDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackableImageDelegate.OnScriptCallback));
				}
				FTrackableImageDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackableImageDelegate.RegisterId);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00054C91 File Offset: 0x00052E91
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedImage> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00054C9C File Offset: 0x00052E9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARTrackedImage TrackedImage)
		{
			FTrackableImageDelegate.__FTrackableImageDelegate_DelegateParams* ptr = stackalloc FTrackableImageDelegate.__FTrackableImageDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackableImageDelegate.__FTrackableImageDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackableImageDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedImage = ((TrackedImage != null) ? TrackedImage.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x00054CE8 File Offset: 0x00052EE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARTrackedImage> action = target as Action<UARTrackedImage>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARTrackedImage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedImage>(((FTrackableImageDelegate.__FTrackableImageDelegate_DelegateParams*)__Parameters)->TrackedImage);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001945 RID: 6469
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001946 RID: 6470
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackableImageDelegate__DelegateSignature";

		// Token: 0x04001947 RID: 6471
		private static int RegisterId;

		// Token: 0x02002C31 RID: 11313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackableImageDelegate_DelegateParams
		{
			// Token: 0x0401653A RID: 91450
			[FieldOffset(0)]
			public IntPtr TrackedImage;
		}

		// Token: 0x02002C32 RID: 11314
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401653B RID: 91451
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
