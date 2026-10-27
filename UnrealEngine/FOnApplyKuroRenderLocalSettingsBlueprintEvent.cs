using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C15 RID: 7189
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnApplyKuroRenderLocalSettingsBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBC0 RID: 113600 RVA: 0x0028CF15 File Offset: 0x0028B115
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnApplyKuroRenderLocalSettingsBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x0601BBC1 RID: 113601 RVA: 0x0028CF21 File Offset: 0x0028B121
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnApplyKuroRenderLocalSettingsBlueprintEvent__DelegateSignature");
			}
			return FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr;
		}

		// Token: 0x0601BBC2 RID: 113602 RVA: 0x0028CF44 File Offset: 0x0028B144
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent()
		{
		}

		// Token: 0x0601BBC3 RID: 113603 RVA: 0x0028CF4C File Offset: 0x0028B14C
		[NullableContext(2)]
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBC4 RID: 113604 RVA: 0x0028CF56 File Offset: 0x0028B156
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBC5 RID: 113605 RVA: 0x0028CF61 File Offset: 0x0028B161
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBC6 RID: 113606 RVA: 0x0028CF93 File Offset: 0x0028B193
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnApplyKuroRenderLocalSettingsBlueprintEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnApplyKuroRenderLocalSettingsBlueprintEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnApplyKuroRenderLocalSettingsBlueprintEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnApplyKuroRenderLocalSettingsBlueprintEvent.OnScriptCallback));
				}
				FOnApplyKuroRenderLocalSettingsBlueprintEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnApplyKuroRenderLocalSettingsBlueprintEvent.RegisterId);
		}

		// Token: 0x0601BBC7 RID: 113607 RVA: 0x0028CFCD File Offset: 0x0028B1CD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BBC8 RID: 113608 RVA: 0x0028CFD8 File Offset: 0x0028B1D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int LocalIndex)
		{
			FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams* ptr = stackalloc FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnApplyKuroRenderLocalSettingsBlueprintEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LocalIndex = LocalIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601BBC9 RID: 113609 RVA: 0x0028D014 File Offset: 0x0028B214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams*)__Parameters)->LocalIndex);
		}

		// Token: 0x0400EE90 RID: 61072
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EE91 RID: 61073
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnApplyKuroRenderLocalSettingsBlueprintEvent__DelegateSignature";

		// Token: 0x0400EE92 RID: 61074
		private static int RegisterId;

		// Token: 0x02003197 RID: 12695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams
		{
			// Token: 0x04016FD5 RID: 94165
			[FieldOffset(0)]
			public int LocalIndex;
		}

		// Token: 0x02003198 RID: 12696
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FD6 RID: 94166
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
