using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000233 RID: 563
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLevelStreamingLoadedStatus : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002DB4 RID: 11700 RVA: 0x00040A24 File Offset: 0x0003EC24
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLevelStreamingLoadedStatus.StaticFunctionPtr();
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00040A30 File Offset: 0x0003EC30
		private static IntPtr StaticFunctionPtr()
		{
			if (FLevelStreamingLoadedStatus._FunctionPtr == IntPtr.Zero)
			{
				FLevelStreamingLoadedStatus._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature");
			}
			return FLevelStreamingLoadedStatus._FunctionPtr;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00040A53 File Offset: 0x0003EC53
		public FLevelStreamingLoadedStatus()
		{
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00040A5B File Offset: 0x0003EC5B
		[NullableContext(2)]
		public FLevelStreamingLoadedStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00040A65 File Offset: 0x0003EC65
		public FLevelStreamingLoadedStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00040A70 File Offset: 0x0003EC70
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00040AA2 File Offset: 0x0003ECA2
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FLevelStreamingLoadedStatus.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLevelStreamingLoadedStatus.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLevelStreamingLoadedStatus.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLevelStreamingLoadedStatus.OnScriptCallback));
				}
				FLevelStreamingLoadedStatus.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLevelStreamingLoadedStatus.RegisterId);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00040ADC File Offset: 0x0003ECDC
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00040AE5 File Offset: 0x0003ECE5
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00040AF0 File Offset: 0x0003ECF0
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

		// Token: 0x04000EA4 RID: 3748
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000EA5 RID: 3749
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature";

		// Token: 0x04000EA6 RID: 3750
		private static int RegisterId;

		// Token: 0x020009B8 RID: 2488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400593F RID: 22847
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
