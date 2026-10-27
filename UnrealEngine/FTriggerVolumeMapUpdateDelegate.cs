using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F0D RID: 7949
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTriggerVolumeMapUpdateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E29E RID: 123550 RVA: 0x002CD952 File Offset: 0x002CBB52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTriggerVolumeMapUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E29F RID: 123551 RVA: 0x002CD95E File Offset: 0x002CBB5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FTriggerVolumeMapUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTriggerVolumeMapUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.TriggerVolumeMapUpdateDelegate__DelegateSignature");
			}
			return FTriggerVolumeMapUpdateDelegate._FunctionPtr;
		}

		// Token: 0x0601E2A0 RID: 123552 RVA: 0x002CD981 File Offset: 0x002CBB81
		public FTriggerVolumeMapUpdateDelegate()
		{
		}

		// Token: 0x0601E2A1 RID: 123553 RVA: 0x002CD989 File Offset: 0x002CBB89
		[NullableContext(2)]
		public FTriggerVolumeMapUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2A2 RID: 123554 RVA: 0x002CD993 File Offset: 0x002CBB93
		public FTriggerVolumeMapUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2A3 RID: 123555 RVA: 0x002CD99E File Offset: 0x002CBB9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E2A4 RID: 123556 RVA: 0x002CD9D0 File Offset: 0x002CBBD0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName> Callback)
		{
			if (FTriggerVolumeMapUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTriggerVolumeMapUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTriggerVolumeMapUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTriggerVolumeMapUpdateDelegate.OnScriptCallback));
				}
				FTriggerVolumeMapUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTriggerVolumeMapUpdateDelegate.RegisterId);
		}

		// Token: 0x0601E2A5 RID: 123557 RVA: 0x002CDA0A File Offset: 0x002CBC0A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E2A6 RID: 123558 RVA: 0x002CDA14 File Offset: 0x002CBC14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName ActorKey)
		{
			FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams* ptr = stackalloc FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTriggerVolumeMapUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E2A7 RID: 123559 RVA: 0x002CDA50 File Offset: 0x002CBC50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x04010495 RID: 66709
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010496 RID: 66710
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.TriggerVolumeMapUpdateDelegate__DelegateSignature";

		// Token: 0x04010497 RID: 66711
		private static int RegisterId;

		// Token: 0x020033FD RID: 13309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FTriggerVolumeMapUpdateDelegate_DelegateParams
		{
			// Token: 0x040173B7 RID: 95159
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x020033FE RID: 13310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173B8 RID: 95160
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
