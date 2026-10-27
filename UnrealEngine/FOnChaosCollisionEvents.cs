using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001437 RID: 5175
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnChaosCollisionEvents : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012EE5 RID: 77541 RVA: 0x001BD517 File Offset: 0x001BB717
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnChaosCollisionEvents.StaticFunctionPtr();
		}

		// Token: 0x06012EE6 RID: 77542 RVA: 0x001BD523 File Offset: 0x001BB723
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnChaosCollisionEvents._FunctionPtr == IntPtr.Zero)
			{
				FOnChaosCollisionEvents._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature");
			}
			return FOnChaosCollisionEvents._FunctionPtr;
		}

		// Token: 0x06012EE7 RID: 77543 RVA: 0x001BD546 File Offset: 0x001BB746
		public FOnChaosCollisionEvents()
		{
		}

		// Token: 0x06012EE8 RID: 77544 RVA: 0x001BD54E File Offset: 0x001BB74E
		[NullableContext(2)]
		public FOnChaosCollisionEvents(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EE9 RID: 77545 RVA: 0x001BD558 File Offset: 0x001BB758
		public FOnChaosCollisionEvents(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EEA RID: 77546 RVA: 0x001BD563 File Offset: 0x001BB763
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate) ?? ((FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012EEB RID: 77547 RVA: 0x001BD595 File Offset: 0x001BB795
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate Callback)
		{
			if (FOnChaosCollisionEvents.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnChaosCollisionEvents.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnChaosCollisionEvents.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnChaosCollisionEvents.OnScriptCallback));
				}
				FOnChaosCollisionEvents.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnChaosCollisionEvents.RegisterId);
		}

		// Token: 0x06012EEC RID: 77548 RVA: 0x001BD5CF File Offset: 0x001BB7CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012EED RID: 77549 RVA: 0x001BD5D8 File Offset: 0x001BB7D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosCollisionEventData> CollisionEvents)
		{
			FOnChaosCollisionEvents.__FOnChaosCollisionEvents_DelegateParams* ptr = stackalloc FOnChaosCollisionEvents.__FOnChaosCollisionEvents_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnChaosCollisionEvents.__FOnChaosCollisionEvents_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnChaosCollisionEvents.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FChaosCollisionEventData> tarray = CollisionEvents;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CollisionEvents);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FChaosCollisionEventData> tarray2 = CollisionEvents;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CollisionEvents);
			}
			UnrealReflectionUtils.DestroyStruct(FOnChaosCollisionEvents._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06012EEE RID: 77550 RVA: 0x001BD648 File Offset: 0x001BB848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate fonChaosCollisionEvents_ScriptDelegate = target as FOnChaosCollisionEvents.FOnChaosCollisionEvents_ScriptDelegate;
			if (fonChaosCollisionEvents_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FChaosCollisionEventData> tarray = new TArray<FChaosCollisionEventData>(&((FOnChaosCollisionEvents.__FOnChaosCollisionEvents_DelegateParams*)__Parameters)->CollisionEvents, true, true);
			fonChaosCollisionEvents_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnChaosCollisionEvents.__FOnChaosCollisionEvents_DelegateParams*)__Parameters)->CollisionEvents, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400A1C9 RID: 41417
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A1CA RID: 41418
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.OnChaosCollisionEvents__DelegateSignature";

		// Token: 0x0400A1CB RID: 41419
		private static int RegisterId;

		// Token: 0x02002E89 RID: 11913
		// (Invoke) Token: 0x0602856E RID: 165230
		public delegate void FOnChaosCollisionEvents_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosCollisionEventData> CollisionEvents);

		// Token: 0x02002E8A RID: 11914
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnChaosCollisionEvents_DelegateParams
		{
			// Token: 0x0401695C RID: 92508
			[FieldOffset(0)]
			public byte CollisionEvents;
		}

		// Token: 0x02002E8B RID: 11915
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401695D RID: 92509
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
