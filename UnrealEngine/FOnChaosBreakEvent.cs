using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001435 RID: 5173
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnChaosBreakEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012ED1 RID: 77521 RVA: 0x001BD201 File Offset: 0x001BB401
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnChaosBreakEvent.StaticFunctionPtr();
		}

		// Token: 0x06012ED2 RID: 77522 RVA: 0x001BD20D File Offset: 0x001BB40D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnChaosBreakEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnChaosBreakEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature");
			}
			return FOnChaosBreakEvent._FunctionPtr;
		}

		// Token: 0x06012ED3 RID: 77523 RVA: 0x001BD230 File Offset: 0x001BB430
		public FOnChaosBreakEvent()
		{
		}

		// Token: 0x06012ED4 RID: 77524 RVA: 0x001BD238 File Offset: 0x001BB438
		[NullableContext(2)]
		public FOnChaosBreakEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012ED5 RID: 77525 RVA: 0x001BD242 File Offset: 0x001BB442
		public FOnChaosBreakEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012ED6 RID: 77526 RVA: 0x001BD24D File Offset: 0x001BB44D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FChaosBreakEvent>) ?? ((Action<FChaosBreakEvent>)Delegate.CreateDelegate(typeof(Action<FChaosBreakEvent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012ED7 RID: 77527 RVA: 0x001BD27F File Offset: 0x001BB47F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FChaosBreakEvent> Callback)
		{
			if (FOnChaosBreakEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnChaosBreakEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnChaosBreakEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnChaosBreakEvent.OnScriptCallback));
				}
				FOnChaosBreakEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnChaosBreakEvent.RegisterId);
		}

		// Token: 0x06012ED8 RID: 77528 RVA: 0x001BD2B9 File Offset: 0x001BB4B9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FChaosBreakEvent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012ED9 RID: 77529 RVA: 0x001BD2C4 File Offset: 0x001BB4C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FChaosBreakEvent BreakEvent)
		{
			FOnChaosBreakEvent.__FOnChaosBreakEvent_DelegateParams* ptr = stackalloc FOnChaosBreakEvent.__FOnChaosBreakEvent_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FOnChaosBreakEvent.__FOnChaosBreakEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnChaosBreakEvent.StaticFunctionPtr(), (void*)ptr, 1);
			if (BreakEvent != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosBreakEvent.StaticStruct(), &ptr->BreakEvent, BreakEvent.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012EDA RID: 77530 RVA: 0x001BD320 File Offset: 0x001BB520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FChaosBreakEvent> action = target as Action<FChaosBreakEvent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FChaosBreakEvent obj = new FChaosBreakEvent(&((FOnChaosBreakEvent.__FOnChaosBreakEvent_DelegateParams*)__Parameters)->BreakEvent, true, true);
			action(obj);
		}

		// Token: 0x0400A1C3 RID: 41411
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A1C4 RID: 41412
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.OnChaosBreakEvent__DelegateSignature";

		// Token: 0x0400A1C5 RID: 41413
		private static int RegisterId;

		// Token: 0x02002E84 RID: 11908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FOnChaosBreakEvent_DelegateParams
		{
			// Token: 0x04016958 RID: 92504
			[FieldOffset(0)]
			public byte BreakEvent;
		}

		// Token: 0x02002E85 RID: 11909
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016959 RID: 92505
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
