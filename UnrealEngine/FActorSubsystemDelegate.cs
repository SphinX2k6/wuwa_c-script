using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000172 RID: 370
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FActorSubsystemDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00023572 File Offset: 0x00021772
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSubsystemDelegate.StaticFunctionPtr();
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0002357E File Offset: 0x0002177E
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSubsystemDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActorSubsystemDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorSubsystemDelegate__DelegateSignature");
			}
			return FActorSubsystemDelegate._FunctionPtr;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000235A1 File Offset: 0x000217A1
		public FActorSubsystemDelegate()
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000235A9 File Offset: 0x000217A9
		[NullableContext(2)]
		public FActorSubsystemDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000235B3 File Offset: 0x000217B3
		public FActorSubsystemDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000235BE File Offset: 0x000217BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000235F0 File Offset: 0x000217F0
		[NullableContext(1)]
		public void Add(Action<FName> Callback)
		{
			if (FActorSubsystemDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorSubsystemDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorSubsystemDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorSubsystemDelegate.OnScriptCallback));
				}
				FActorSubsystemDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FActorSubsystemDelegate.RegisterId);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0002362A File Offset: 0x0002182A
		[NullableContext(1)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00023634 File Offset: 0x00021834
		[SkipLocalsInit]
		public unsafe void Broadcast(FName ActorKey)
		{
			FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams* ptr = stackalloc FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorSubsystemDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00023670 File Offset: 0x00021870
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x04000734 RID: 1844
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000735 RID: 1845
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorSubsystemDelegate__DelegateSignature";

		// Token: 0x04000736 RID: 1846
		private static int RegisterId;

		// Token: 0x02000964 RID: 2404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FActorSubsystemDelegate_DelegateParams
		{
			// Token: 0x04005890 RID: 22672
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x02000965 RID: 2405
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005891 RID: 22673
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
