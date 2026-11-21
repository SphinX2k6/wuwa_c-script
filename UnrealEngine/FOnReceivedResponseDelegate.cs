using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048B RID: 1163
	public sealed class FOnReceivedResponseDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D6D RID: 28013 RVA: 0x000A0062 File Offset: 0x0009E262
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedResponseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x000A006E File Offset: 0x0009E26E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedResponseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedResponseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedResponseDelegate__DelegateSignature");
			}
			return FOnReceivedResponseDelegate._FunctionPtr;
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x000A0091 File Offset: 0x0009E291
		public FOnReceivedResponseDelegate()
		{
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x000A0099 File Offset: 0x0009E299
		[NullableContext(2)]
		public FOnReceivedResponseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x000A00A3 File Offset: 0x0009E2A3
		public FOnReceivedResponseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x000A00AE File Offset: 0x0009E2AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, short, ushort, FArrayBuffer>) ?? ((Action<int, short, ushort, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, short, ushort, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x000A00E0 File Offset: 0x0009E2E0
		[NullableContext(1)]
		public void Bind(Action<int, short, ushort, FArrayBuffer> Callback)
		{
			if (FOnReceivedResponseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedResponseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedResponseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedResponseDelegate.OnScriptCallback));
				}
				FOnReceivedResponseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedResponseDelegate.RegisterId);
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x000A011C File Offset: 0x0009E31C
		[SkipLocalsInit]
		public unsafe void Execute(int SeqNo, short RpdId, ushort MessageId, FArrayBuffer MessageBuffer)
		{
			FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams* ptr = stackalloc FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedResponseDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->RpdId = RpdId;
			ptr->MessageId = MessageId;
			ptr->MessageBuffer = MessageBuffer;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x000A0170 File Offset: 0x0009E370
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, short, ushort, FArrayBuffer> action = target as Action<int, short, ushort, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->RpdId, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->MessageId, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->MessageBuffer);
		}

		// Token: 0x04002EB2 RID: 11954
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EB3 RID: 11955
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedResponseDelegate__DelegateSignature";

		// Token: 0x04002EB4 RID: 11956
		private static int RegisterId;

		// Token: 0x02000B98 RID: 2968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnReceivedResponseDelegate_DelegateParams
		{
			// Token: 0x04005D16 RID: 23830
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04005D17 RID: 23831
			[FieldOffset(4)]
			public short RpdId;

			// Token: 0x04005D18 RID: 23832
			[FieldOffset(6)]
			public ushort MessageId;

			// Token: 0x04005D19 RID: 23833
			[FieldOffset(8)]
			public FArrayBuffer MessageBuffer;
		}

		// Token: 0x02000B99 RID: 2969
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D1A RID: 23834
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
