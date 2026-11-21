using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000545 RID: 1349
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKProductDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CD9 RID: 31961 RVA: 0x000B928E File Offset: 0x000B748E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKProductDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x000B929A File Offset: 0x000B749A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKProductDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKProductDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKProductDelegate__DelegateSignature");
			}
			return FSDKProductDelegate._FunctionPtr;
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x000B92BD File Offset: 0x000B74BD
		public FSDKProductDelegate()
		{
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x000B92C5 File Offset: 0x000B74C5
		[NullableContext(2)]
		public FSDKProductDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x000B92CF File Offset: 0x000B74CF
		public FSDKProductDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x000B92DA File Offset: 0x000B74DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x000B930C File Offset: 0x000B750C
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKProductDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKProductDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKProductDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKProductDelegate.OnScriptCallback));
				}
				FSDKProductDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKProductDelegate.RegisterId);
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x000B9346 File Offset: 0x000B7546
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x000B9350 File Offset: 0x000B7550
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string str)
		{
			FSDKProductDelegate.__FSDKProductDelegate_DelegateParams* ptr = stackalloc FSDKProductDelegate.__FSDKProductDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKProductDelegate.__FSDKProductDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKProductDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->str), str);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKProductDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x000B93A4 File Offset: 0x000B75A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKProductDelegate.__FSDKProductDelegate_DelegateParams*)__Parameters)->str));
			action(obj);
		}

		// Token: 0x0400354F RID: 13647
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003550 RID: 13648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKProductDelegate__DelegateSignature";

		// Token: 0x04003551 RID: 13649
		private static int RegisterId;

		// Token: 0x02000CFE RID: 3326
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKProductDelegate_DelegateParams
		{
			// Token: 0x04005F88 RID: 24456
			[FieldOffset(0)]
			public FString str;
		}

		// Token: 0x02000CFF RID: 3327
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F89 RID: 24457
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
