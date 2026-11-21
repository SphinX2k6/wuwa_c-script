using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043A RID: 1082
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitGameplayEventDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068D9 RID: 26841 RVA: 0x00099157 File Offset: 0x00097357
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitGameplayEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00099163 File Offset: 0x00097363
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitGameplayEventDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitGameplayEventDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.WaitGameplayEventDelegate__DelegateSignature");
			}
			return FWaitGameplayEventDelegate._FunctionPtr;
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00099186 File Offset: 0x00097386
		public FWaitGameplayEventDelegate()
		{
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x0009918E File Offset: 0x0009738E
		[NullableContext(2)]
		public FWaitGameplayEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00099198 File Offset: 0x00097398
		public FWaitGameplayEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x000991A3 File Offset: 0x000973A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTag, FGameplayEventData>) ?? ((Action<FGameplayTag, FGameplayEventData>)Delegate.CreateDelegate(typeof(Action<FGameplayTag, FGameplayEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x000991D5 File Offset: 0x000973D5
		[NullableContext(1)]
		public void Add(Action<FGameplayTag, FGameplayEventData> Callback)
		{
			if (FWaitGameplayEventDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitGameplayEventDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitGameplayEventDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitGameplayEventDelegate.OnScriptCallback));
				}
				FWaitGameplayEventDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitGameplayEventDelegate.RegisterId);
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x0009920F File Offset: 0x0009740F
		[NullableContext(1)]
		public void Remove(Action<FGameplayTag, FGameplayEventData> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00099218 File Offset: 0x00097418
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(FGameplayTag EventTag, FGameplayEventData Payload)
		{
			FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams* ptr = stackalloc FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams[(UIntPtr)215] + 15L / (long)sizeof(FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitGameplayEventDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventTag = EventTag;
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FWaitGameplayEventDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x0009928C File Offset: 0x0009748C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTag, FGameplayEventData> action = target as Action<FGameplayTag, FGameplayEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayEventData arg = new FGameplayEventData(&((FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams*)__Parameters)->Payload, true, true);
			action(((FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams*)__Parameters)->EventTag, arg);
		}

		// Token: 0x04002CAD RID: 11437
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CAE RID: 11438
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.WaitGameplayEventDelegate__DelegateSignature";

		// Token: 0x04002CAF RID: 11439
		private static int RegisterId;

		// Token: 0x02000B5C RID: 2908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		private ref struct __FWaitGameplayEventDelegate_DelegateParams
		{
			// Token: 0x04005C70 RID: 23664
			[FieldOffset(0)]
			public FGameplayTag EventTag;

			// Token: 0x04005C71 RID: 23665
			[FieldOffset(16)]
			public byte Payload;
		}

		// Token: 0x02000B5D RID: 2909
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C72 RID: 23666
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
