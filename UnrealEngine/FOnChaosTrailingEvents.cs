using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001438 RID: 5176
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnChaosTrailingEvents : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012EEF RID: 77551 RVA: 0x001BD6B7 File Offset: 0x001BB8B7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnChaosTrailingEvents.StaticFunctionPtr();
		}

		// Token: 0x06012EF0 RID: 77552 RVA: 0x001BD6C3 File Offset: 0x001BB8C3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnChaosTrailingEvents._FunctionPtr == IntPtr.Zero)
			{
				FOnChaosTrailingEvents._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature");
			}
			return FOnChaosTrailingEvents._FunctionPtr;
		}

		// Token: 0x06012EF1 RID: 77553 RVA: 0x001BD6E6 File Offset: 0x001BB8E6
		public FOnChaosTrailingEvents()
		{
		}

		// Token: 0x06012EF2 RID: 77554 RVA: 0x001BD6EE File Offset: 0x001BB8EE
		[NullableContext(2)]
		public FOnChaosTrailingEvents(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EF3 RID: 77555 RVA: 0x001BD6F8 File Offset: 0x001BB8F8
		public FOnChaosTrailingEvents(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EF4 RID: 77556 RVA: 0x001BD703 File Offset: 0x001BB903
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate) ?? ((FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012EF5 RID: 77557 RVA: 0x001BD735 File Offset: 0x001BB935
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate Callback)
		{
			if (FOnChaosTrailingEvents.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnChaosTrailingEvents.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnChaosTrailingEvents.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnChaosTrailingEvents.OnScriptCallback));
				}
				FOnChaosTrailingEvents.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnChaosTrailingEvents.RegisterId);
		}

		// Token: 0x06012EF6 RID: 77558 RVA: 0x001BD76F File Offset: 0x001BB96F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012EF7 RID: 77559 RVA: 0x001BD778 File Offset: 0x001BB978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosTrailingEventData> TrailingEvents)
		{
			FOnChaosTrailingEvents.__FOnChaosTrailingEvents_DelegateParams* ptr = stackalloc FOnChaosTrailingEvents.__FOnChaosTrailingEvents_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnChaosTrailingEvents.__FOnChaosTrailingEvents_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnChaosTrailingEvents.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FChaosTrailingEventData> tarray = TrailingEvents;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TrailingEvents);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FChaosTrailingEventData> tarray2 = TrailingEvents;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TrailingEvents);
			}
			UnrealReflectionUtils.DestroyStruct(FOnChaosTrailingEvents._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06012EF8 RID: 77560 RVA: 0x001BD7E8 File Offset: 0x001BB9E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate fonChaosTrailingEvents_ScriptDelegate = target as FOnChaosTrailingEvents.FOnChaosTrailingEvents_ScriptDelegate;
			if (fonChaosTrailingEvents_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FChaosTrailingEventData> tarray = new TArray<FChaosTrailingEventData>(&((FOnChaosTrailingEvents.__FOnChaosTrailingEvents_DelegateParams*)__Parameters)->TrailingEvents, true, true);
			fonChaosTrailingEvents_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnChaosTrailingEvents.__FOnChaosTrailingEvents_DelegateParams*)__Parameters)->TrailingEvents, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400A1CC RID: 41420
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A1CD RID: 41421
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.OnChaosTrailingEvents__DelegateSignature";

		// Token: 0x0400A1CE RID: 41422
		private static int RegisterId;

		// Token: 0x02002E8C RID: 11916
		// (Invoke) Token: 0x06028572 RID: 165234
		public delegate void FOnChaosTrailingEvents_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FChaosTrailingEventData> TrailingEvents);

		// Token: 0x02002E8D RID: 11917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnChaosTrailingEvents_DelegateParams
		{
			// Token: 0x0401695E RID: 92510
			[FieldOffset(0)]
			public byte TrailingEvents;
		}

		// Token: 0x02002E8E RID: 11918
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401695F RID: 92511
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
