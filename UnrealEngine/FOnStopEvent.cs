using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200034F RID: 847
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStopEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060056C9 RID: 22217 RVA: 0x0007A4CE File Offset: 0x000786CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStopEvent.StaticFunctionPtr();
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x0007A4DA File Offset: 0x000786DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStopEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnStopEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.OnStopEvent__DelegateSignature");
			}
			return FOnStopEvent._FunctionPtr;
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x0007A4FD File Offset: 0x000786FD
		public FOnStopEvent()
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x0007A505 File Offset: 0x00078705
		[NullableContext(2)]
		public FOnStopEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x0007A50F File Offset: 0x0007870F
		public FOnStopEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0007A51A File Offset: 0x0007871A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x0007A54C File Offset: 0x0007874C
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnStopEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStopEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStopEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStopEvent.OnScriptCallback));
				}
				FOnStopEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStopEvent.RegisterId);
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x0007A586 File Offset: 0x00078786
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x0007A58F File Offset: 0x0007878F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x0007A59C File Offset: 0x0007879C
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

		// Token: 0x040023B6 RID: 9142
		internal static IntPtr _FunctionPtr;

		// Token: 0x040023B7 RID: 9143
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.OnStopEvent__DelegateSignature";

		// Token: 0x040023B8 RID: 9144
		private static int RegisterId;

		// Token: 0x02000A61 RID: 2657
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A7B RID: 23163
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
