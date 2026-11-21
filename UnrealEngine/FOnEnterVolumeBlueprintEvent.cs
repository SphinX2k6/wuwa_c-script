using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004F1 RID: 1265
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEnterVolumeBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007723 RID: 30499 RVA: 0x000AE17E File Offset: 0x000AC37E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEnterVolumeBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x000AE18A File Offset: 0x000AC38A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEnterVolumeBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnEnterVolumeBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnEnterVolumeBlueprintEvent__DelegateSignature");
			}
			return FOnEnterVolumeBlueprintEvent._FunctionPtr;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x000AE1AD File Offset: 0x000AC3AD
		public FOnEnterVolumeBlueprintEvent()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x000AE1B5 File Offset: 0x000AC3B5
		[NullableContext(2)]
		public FOnEnterVolumeBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x000AE1BF File Offset: 0x000AC3BF
		public FOnEnterVolumeBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x000AE1CA File Offset: 0x000AC3CA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x000AE1FC File Offset: 0x000AC3FC
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnEnterVolumeBlueprintEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEnterVolumeBlueprintEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEnterVolumeBlueprintEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEnterVolumeBlueprintEvent.OnScriptCallback));
				}
				FOnEnterVolumeBlueprintEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEnterVolumeBlueprintEvent.RegisterId);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x000AE236 File Offset: 0x000AC436
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x000AE23F File Offset: 0x000AC43F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x000AE24C File Offset: 0x000AC44C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400323B RID: 12859
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400323C RID: 12860
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnEnterVolumeBlueprintEvent__DelegateSignature";

		// Token: 0x0400323D RID: 12861
		private static int RegisterId;

		// Token: 0x02000C31 RID: 3121
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E7E RID: 24190
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
