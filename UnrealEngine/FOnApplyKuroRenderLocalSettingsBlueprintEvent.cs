using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004EF RID: 1263
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnApplyKuroRenderLocalSettingsBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007710 RID: 30480 RVA: 0x000ADEF3 File Offset: 0x000AC0F3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnApplyKuroRenderLocalSettingsBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x000ADEFF File Offset: 0x000AC0FF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnApplyKuroRenderLocalSettingsBlueprintEvent__DelegateSignature");
			}
			return FOnApplyKuroRenderLocalSettingsBlueprintEvent._FunctionPtr;
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x000ADF22 File Offset: 0x000AC122
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent()
		{
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x000ADF2A File Offset: 0x000AC12A
		[NullableContext(2)]
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x000ADF34 File Offset: 0x000AC134
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x000ADF3F File Offset: 0x000AC13F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x000ADF71 File Offset: 0x000AC171
		[NullableContext(1)]
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

		// Token: 0x06007717 RID: 30487 RVA: 0x000ADFAB File Offset: 0x000AC1AB
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x000ADFB4 File Offset: 0x000AC1B4
		[SkipLocalsInit]
		public unsafe void Broadcast(int LocalIndex)
		{
			FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams* ptr = stackalloc FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnApplyKuroRenderLocalSettingsBlueprintEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LocalIndex = LocalIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x000ADFF0 File Offset: 0x000AC1F0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnApplyKuroRenderLocalSettingsBlueprintEvent.__FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams*)__Parameters)->LocalIndex);
		}

		// Token: 0x04003235 RID: 12853
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003236 RID: 12854
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnApplyKuroRenderLocalSettingsBlueprintEvent__DelegateSignature";

		// Token: 0x04003237 RID: 12855
		private static int RegisterId;

		// Token: 0x02000C2D RID: 3117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnApplyKuroRenderLocalSettingsBlueprintEvent_DelegateParams
		{
			// Token: 0x04005E7A RID: 24186
			[FieldOffset(0)]
			public int LocalIndex;
		}

		// Token: 0x02000C2E RID: 3118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E7B RID: 24187
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
