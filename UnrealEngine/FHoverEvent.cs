using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000662 RID: 1634
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FHoverEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008DB5 RID: 36277 RVA: 0x000D56A2 File Offset: 0x000D38A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHoverEvent.StaticFunctionPtr();
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x000D56AE File Offset: 0x000D38AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FHoverEvent._FunctionPtr == IntPtr.Zero)
			{
				FHoverEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.HoverEvent__DelegateSignature");
			}
			return FHoverEvent._FunctionPtr;
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x000D56D1 File Offset: 0x000D38D1
		public FHoverEvent()
		{
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x000D56D9 File Offset: 0x000D38D9
		[NullableContext(2)]
		public FHoverEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x000D56E3 File Offset: 0x000D38E3
		public FHoverEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x000D56EE File Offset: 0x000D38EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x000D5720 File Offset: 0x000D3920
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FHoverEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHoverEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHoverEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHoverEvent.OnScriptCallback));
				}
				FHoverEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FHoverEvent.RegisterId);
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x000D575A File Offset: 0x000D395A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x000D5763 File Offset: 0x000D3963
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x000D5770 File Offset: 0x000D3970
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

		// Token: 0x04003E74 RID: 15988
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003E75 RID: 15989
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.HoverEvent__DelegateSignature";

		// Token: 0x04003E76 RID: 15990
		private static int RegisterId;

		// Token: 0x02000E6A RID: 3690
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006212 RID: 25106
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
