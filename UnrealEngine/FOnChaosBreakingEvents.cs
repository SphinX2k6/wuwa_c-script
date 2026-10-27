using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001436 RID: 5174
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnChaosBreakingEvents : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012EDB RID: 77531 RVA: 0x001BD374 File Offset: 0x001BB574
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnChaosBreakingEvents.StaticFunctionPtr();
		}

		// Token: 0x06012EDC RID: 77532 RVA: 0x001BD380 File Offset: 0x001BB580
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnChaosBreakingEvents._FunctionPtr == IntPtr.Zero)
			{
				FOnChaosBreakingEvents._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature");
			}
			return FOnChaosBreakingEvents._FunctionPtr;
		}

		// Token: 0x06012EDD RID: 77533 RVA: 0x001BD3A3 File Offset: 0x001BB5A3
		public FOnChaosBreakingEvents()
		{
		}

		// Token: 0x06012EDE RID: 77534 RVA: 0x001BD3AB File Offset: 0x001BB5AB
		[NullableContext(2)]
		public FOnChaosBreakingEvents(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EDF RID: 77535 RVA: 0x001BD3B5 File Offset: 0x001BB5B5
		public FOnChaosBreakingEvents(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EE0 RID: 77536 RVA: 0x001BD3C0 File Offset: 0x001BB5C0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate) ?? ((FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012EE1 RID: 77537 RVA: 0x001BD3F2 File Offset: 0x001BB5F2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate Callback)
		{
			if (FOnChaosBreakingEvents.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnChaosBreakingEvents.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnChaosBreakingEvents.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnChaosBreakingEvents.OnScriptCallback));
				}
				FOnChaosBreakingEvents.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnChaosBreakingEvents.RegisterId);
		}

		// Token: 0x06012EE2 RID: 77538 RVA: 0x001BD42C File Offset: 0x001BB62C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012EE3 RID: 77539 RVA: 0x001BD438 File Offset: 0x001BB638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosBreakingEventData> BreakingEvents)
		{
			FOnChaosBreakingEvents.__FOnChaosBreakingEvents_DelegateParams* ptr = stackalloc FOnChaosBreakingEvents.__FOnChaosBreakingEvents_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnChaosBreakingEvents.__FOnChaosBreakingEvents_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnChaosBreakingEvents.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FChaosBreakingEventData> tarray = BreakingEvents;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->BreakingEvents);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FChaosBreakingEventData> tarray2 = BreakingEvents;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->BreakingEvents);
			}
			UnrealReflectionUtils.DestroyStruct(FOnChaosBreakingEvents._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06012EE4 RID: 77540 RVA: 0x001BD4A8 File Offset: 0x001BB6A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate fonChaosBreakingEvents_ScriptDelegate = target as FOnChaosBreakingEvents.FOnChaosBreakingEvents_ScriptDelegate;
			if (fonChaosBreakingEvents_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FChaosBreakingEventData> tarray = new TArray<FChaosBreakingEventData>(&((FOnChaosBreakingEvents.__FOnChaosBreakingEvents_DelegateParams*)__Parameters)->BreakingEvents, true, true);
			fonChaosBreakingEvents_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnChaosBreakingEvents.__FOnChaosBreakingEvents_DelegateParams*)__Parameters)->BreakingEvents, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400A1C6 RID: 41414
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A1C7 RID: 41415
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.OnChaosBreakingEvents__DelegateSignature";

		// Token: 0x0400A1C8 RID: 41416
		private static int RegisterId;

		// Token: 0x02002E86 RID: 11910
		// (Invoke) Token: 0x0602856A RID: 165226
		public delegate void FOnChaosBreakingEvents_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosBreakingEventData> BreakingEvents);

		// Token: 0x02002E87 RID: 11911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnChaosBreakingEvents_DelegateParams
		{
			// Token: 0x0401695A RID: 92506
			[FieldOffset(0)]
			public byte BreakingEvents;
		}

		// Token: 0x02002E88 RID: 11912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401695B RID: 92507
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
