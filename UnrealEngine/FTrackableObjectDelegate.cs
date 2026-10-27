using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040E RID: 1038
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTrackableObjectDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060037B4 RID: 14260 RVA: 0x00054D39 File Offset: 0x00052F39
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTrackableObjectDelegate.StaticFunctionPtr();
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00054D45 File Offset: 0x00052F45
		private static IntPtr StaticFunctionPtr()
		{
			if (FTrackableObjectDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTrackableObjectDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.TrackableObjectDelegate__DelegateSignature");
			}
			return FTrackableObjectDelegate._FunctionPtr;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00054D68 File Offset: 0x00052F68
		public FTrackableObjectDelegate()
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00054D70 File Offset: 0x00052F70
		[NullableContext(2)]
		public FTrackableObjectDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00054D7A File Offset: 0x00052F7A
		public FTrackableObjectDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00054D85 File Offset: 0x00052F85
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARTrackedObject>) ?? ((Action<UARTrackedObject>)Delegate.CreateDelegate(typeof(Action<UARTrackedObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00054DB7 File Offset: 0x00052FB7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedObject> Callback)
		{
			if (FTrackableObjectDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTrackableObjectDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTrackableObjectDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTrackableObjectDelegate.OnScriptCallback));
				}
				FTrackableObjectDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTrackableObjectDelegate.RegisterId);
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00054DF1 File Offset: 0x00052FF1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARTrackedObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00054DFC File Offset: 0x00052FFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARTrackedObject TrackedObject)
		{
			FTrackableObjectDelegate.__FTrackableObjectDelegate_DelegateParams* ptr = stackalloc FTrackableObjectDelegate.__FTrackableObjectDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTrackableObjectDelegate.__FTrackableObjectDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTrackableObjectDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TrackedObject = ((TrackedObject != null) ? TrackedObject.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00054E48 File Offset: 0x00053048
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARTrackedObject> action = target as Action<UARTrackedObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARTrackedObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedObject>(((FTrackableObjectDelegate.__FTrackableObjectDelegate_DelegateParams*)__Parameters)->TrackedObject);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001948 RID: 6472
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001949 RID: 6473
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackableObjectDelegate__DelegateSignature";

		// Token: 0x0400194A RID: 6474
		private static int RegisterId;

		// Token: 0x02002C33 RID: 11315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FTrackableObjectDelegate_DelegateParams
		{
			// Token: 0x0401653C RID: 91452
			[FieldOffset(0)]
			public IntPtr TrackedObject;
		}

		// Token: 0x02002C34 RID: 11316
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401653D RID: 91453
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
