using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000378 RID: 888
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnReceiveCommandEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060059E6 RID: 23014 RVA: 0x0007F0C4 File Offset: 0x0007D2C4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceiveCommandEvent.StaticFunctionPtr();
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x0007F0D0 File Offset: 0x0007D2D0
		private static IntPtr StaticFunctionPtr()
		{
			if (UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.CommandService:OnReceiveCommandEvent__DelegateSignature");
			}
			return UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0007F0F3 File Offset: 0x0007D2F3
		public FOnReceiveCommandEvent()
		{
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x0007F0FB File Offset: 0x0007D2FB
		[NullableContext(2)]
		public FOnReceiveCommandEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x0007F105 File Offset: 0x0007D305
		public FOnReceiveCommandEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0007F110 File Offset: 0x0007D310
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x0007F142 File Offset: 0x0007D342
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FOnReceiveCommandEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceiveCommandEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceiveCommandEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceiveCommandEvent.OnScriptCallback));
				}
				FOnReceiveCommandEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnReceiveCommandEvent.RegisterId);
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x0007F17C File Offset: 0x0007D37C
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x0007F188 File Offset: 0x0007D388
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string ReceiveData)
		{
			FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams* ptr = stackalloc FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceiveCommandEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ReceiveData), ReceiveData);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCommandService.__OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x0007F1DC File Offset: 0x0007D3DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnReceiveCommandEvent.__FOnReceiveCommandEvent_DelegateParams*)__Parameters)->ReceiveData));
			action(obj);
		}

		// Token: 0x0400254A RID: 9546
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.CommandService:OnReceiveCommandEvent__DelegateSignature";

		// Token: 0x0400254B RID: 9547
		private static int RegisterId;

		// Token: 0x02000A8D RID: 2701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnReceiveCommandEvent_DelegateParams
		{
			// Token: 0x04005ADD RID: 23261
			[FieldOffset(0)]
			public FString ReceiveData;
		}

		// Token: 0x02000A8E RID: 2702
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ADE RID: 23262
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
