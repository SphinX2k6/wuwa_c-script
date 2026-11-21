using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003D8 RID: 984
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroActorStreamingCompleted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060F7 RID: 24823 RVA: 0x0008A908 File Offset: 0x00088B08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroActorStreamingCompleted.StaticFunctionPtr();
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x0008A914 File Offset: 0x00088B14
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroActorStreamingCompleted._FunctionPtr == IntPtr.Zero)
			{
				FKuroActorStreamingCompleted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroActorStreamingCompleted__DelegateSignature");
			}
			return FKuroActorStreamingCompleted._FunctionPtr;
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x0008A937 File Offset: 0x00088B37
		public FKuroActorStreamingCompleted()
		{
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x0008A93F File Offset: 0x00088B3F
		[NullableContext(2)]
		public FKuroActorStreamingCompleted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x0008A949 File Offset: 0x00088B49
		public FKuroActorStreamingCompleted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x0008A954 File Offset: 0x00088B54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x0008A986 File Offset: 0x00088B86
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FKuroActorStreamingCompleted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroActorStreamingCompleted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroActorStreamingCompleted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroActorStreamingCompleted.OnScriptCallback));
				}
				FKuroActorStreamingCompleted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroActorStreamingCompleted.RegisterId);
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x0008A9C0 File Offset: 0x00088BC0
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x0008A9C9 File Offset: 0x00088BC9
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x0008A9D4 File Offset: 0x00088BD4
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

		// Token: 0x04002955 RID: 10581
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002956 RID: 10582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroActorStreamingCompleted__DelegateSignature";

		// Token: 0x04002957 RID: 10583
		private static int RegisterId;

		// Token: 0x02000AD2 RID: 2770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B4F RID: 23375
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
