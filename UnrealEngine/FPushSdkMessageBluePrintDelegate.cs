using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004A1 RID: 1185
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPushSdkMessageBluePrintDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006E5E RID: 28254 RVA: 0x000A2DD3 File Offset: 0x000A0FD3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPushSdkMessageBluePrintDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x000A2DDF File Offset: 0x000A0FDF
		private static IntPtr StaticFunctionPtr()
		{
			if (FPushSdkMessageBluePrintDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPushSdkMessageBluePrintDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPushSdk.PushSdkMessageBluePrintDelegate__DelegateSignature");
			}
			return FPushSdkMessageBluePrintDelegate._FunctionPtr;
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x000A2E02 File Offset: 0x000A1002
		public FPushSdkMessageBluePrintDelegate()
		{
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x000A2E0A File Offset: 0x000A100A
		[NullableContext(2)]
		public FPushSdkMessageBluePrintDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x000A2E14 File Offset: 0x000A1014
		public FPushSdkMessageBluePrintDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x000A2E1F File Offset: 0x000A101F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x000A2E51 File Offset: 0x000A1051
		[NullableContext(1)]
		public void Add(Action<string, string> Callback)
		{
			if (FPushSdkMessageBluePrintDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPushSdkMessageBluePrintDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPushSdkMessageBluePrintDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPushSdkMessageBluePrintDelegate.OnScriptCallback));
				}
				FPushSdkMessageBluePrintDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPushSdkMessageBluePrintDelegate.RegisterId);
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x000A2E8B File Offset: 0x000A108B
		[NullableContext(1)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x000A2E94 File Offset: 0x000A1094
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string source, string result)
		{
			FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams* ptr = stackalloc FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPushSdkMessageBluePrintDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPushSdkMessageBluePrintDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x000A2EF4 File Offset: 0x000A10F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams*)__Parameters)->source));
			string arg2 = FString.ToString((void*)(&((FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams*)__Parameters)->result));
			action(arg, arg2);
		}

		// Token: 0x04002F5C RID: 12124
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002F5D RID: 12125
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPushSdk.PushSdkMessageBluePrintDelegate__DelegateSignature";

		// Token: 0x04002F5E RID: 12126
		private static int RegisterId;

		// Token: 0x02000BEC RID: 3052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FPushSdkMessageBluePrintDelegate_DelegateParams
		{
			// Token: 0x04005DA6 RID: 23974
			[FieldOffset(0)]
			public FString source;

			// Token: 0x04005DA7 RID: 23975
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02000BED RID: 3053
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005DA8 RID: 23976
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
