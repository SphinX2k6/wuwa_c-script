using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048A RID: 1162
	public sealed class FOnReceivedPushDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D64 RID: 28004 RVA: 0x0009FF08 File Offset: 0x0009E108
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedPushDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x0009FF14 File Offset: 0x0009E114
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedPushDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedPushDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedPushDelegate__DelegateSignature");
			}
			return FOnReceivedPushDelegate._FunctionPtr;
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0009FF37 File Offset: 0x0009E137
		public FOnReceivedPushDelegate()
		{
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x0009FF3F File Offset: 0x0009E13F
		[NullableContext(2)]
		public FOnReceivedPushDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0009FF49 File Offset: 0x0009E149
		public FOnReceivedPushDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x0009FF54 File Offset: 0x0009E154
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, ushort, FArrayBuffer>) ?? ((Action<int, ushort, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, ushort, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x0009FF86 File Offset: 0x0009E186
		[NullableContext(1)]
		public void Bind(Action<int, ushort, FArrayBuffer> Callback)
		{
			if (FOnReceivedPushDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedPushDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedPushDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedPushDelegate.OnScriptCallback));
				}
				FOnReceivedPushDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedPushDelegate.RegisterId);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		[SkipLocalsInit]
		public unsafe void Execute(int SeqNo, ushort MessageId, FArrayBuffer MessageBuffer)
		{
			FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams* ptr = stackalloc FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedPushDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->MessageId = MessageId;
			ptr->MessageBuffer = MessageBuffer;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x000A000C File Offset: 0x0009E20C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, ushort, FArrayBuffer> action = target as Action<int, ushort, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->MessageId, ((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->MessageBuffer);
		}

		// Token: 0x04002EAF RID: 11951
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EB0 RID: 11952
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedPushDelegate__DelegateSignature";

		// Token: 0x04002EB1 RID: 11953
		private static int RegisterId;

		// Token: 0x02000B96 RID: 2966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnReceivedPushDelegate_DelegateParams
		{
			// Token: 0x04005D12 RID: 23826
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04005D13 RID: 23827
			[FieldOffset(4)]
			public ushort MessageId;

			// Token: 0x04005D14 RID: 23828
			[FieldOffset(8)]
			public FArrayBuffer MessageBuffer;
		}

		// Token: 0x02000B97 RID: 2967
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D15 RID: 23829
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
