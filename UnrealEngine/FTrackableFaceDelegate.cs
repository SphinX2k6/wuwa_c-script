using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040C RID: 1036
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackableFaceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060037A0 RID: 14240 RVA: 0x00054A79 File Offset: 0x00052C79
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackableFaceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00054A85 File Offset: 0x00052C85
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackableFaceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackableFaceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackableFaceDelegate__DelegateSignature");
			}
			return FTrackableFaceDelegate._FunctionPtr;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00054AA8 File Offset: 0x00052CA8
		public FTrackableFaceDelegate()
		{
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00054AB0 File Offset: 0x00052CB0
		[NullableContext(2)]
		public FTrackableFaceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00054ABA File Offset: 0x00052CBA
		public FTrackableFaceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00054AC5 File Offset: 0x00052CC5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARFaceGeometry>) ?? ((Action<UARFaceGeometry>)Delegate.CreateDelegate(typeof(Action<UARFaceGeometry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00054AF7 File Offset: 0x00052CF7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARFaceGeometry> Callback)
		{
			if (FTrackableFaceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackableFaceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackableFaceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackableFaceDelegate.OnScriptCallback));
				}
				FTrackableFaceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackableFaceDelegate.RegisterId);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00054B31 File Offset: 0x00052D31
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARFaceGeometry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00054B3C File Offset: 0x00052D3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARFaceGeometry TrackedFace)
		{
			FTrackableFaceDelegate.__FTrackableFaceDelegate_DelegateParams* ptr = stackalloc FTrackableFaceDelegate.__FTrackableFaceDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackableFaceDelegate.__FTrackableFaceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackableFaceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedFace = ((TrackedFace != null) ? TrackedFace.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00054B88 File Offset: 0x00052D88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARFaceGeometry> action = target as Action<UARFaceGeometry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARFaceGeometry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARFaceGeometry>(((FTrackableFaceDelegate.__FTrackableFaceDelegate_DelegateParams*)__Parameters)->TrackedFace);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001942 RID: 6466
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001943 RID: 6467
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackableFaceDelegate__DelegateSignature";

		// Token: 0x04001944 RID: 6468
		private static int RegisterId;

		// Token: 0x02002C2F RID: 11311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackableFaceDelegate_DelegateParams
		{
			// Token: 0x04016538 RID: 91448
			[FieldOffset(0)]
			public IntPtr TrackedFace;
		}

		// Token: 0x02002C30 RID: 11312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016539 RID: 91449
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
