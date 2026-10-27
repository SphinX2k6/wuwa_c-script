using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A41 RID: 6721
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPushSdkMessageBluePrintDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018E19 RID: 101913 RVA: 0x0024C961 File Offset: 0x0024AB61
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPushSdkMessageBluePrintDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018E1A RID: 101914 RVA: 0x0024C96D File Offset: 0x0024AB6D
		private static IntPtr StaticFunctionPtr()
		{
			if (FPushSdkMessageBluePrintDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPushSdkMessageBluePrintDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPushSdk.PushSdkMessageBluePrintDelegate__DelegateSignature");
			}
			return FPushSdkMessageBluePrintDelegate._FunctionPtr;
		}

		// Token: 0x06018E1B RID: 101915 RVA: 0x0024C990 File Offset: 0x0024AB90
		public FPushSdkMessageBluePrintDelegate()
		{
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x0024C998 File Offset: 0x0024AB98
		[NullableContext(2)]
		public FPushSdkMessageBluePrintDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018E1D RID: 101917 RVA: 0x0024C9A2 File Offset: 0x0024ABA2
		public FPushSdkMessageBluePrintDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018E1E RID: 101918 RVA: 0x0024C9AD File Offset: 0x0024ABAD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018E1F RID: 101919 RVA: 0x0024C9DF File Offset: 0x0024ABDF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06018E20 RID: 101920 RVA: 0x0024CA19 File Offset: 0x0024AC19
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018E21 RID: 101921 RVA: 0x0024CA24 File Offset: 0x0024AC24
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string source, string result)
		{
			FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams* ptr = stackalloc FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FPushSdkMessageBluePrintDelegate.__FPushSdkMessageBluePrintDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPushSdkMessageBluePrintDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPushSdkMessageBluePrintDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E22 RID: 101922 RVA: 0x0024CA84 File Offset: 0x0024AC84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400D71C RID: 55068
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D71D RID: 55069
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPushSdk.PushSdkMessageBluePrintDelegate__DelegateSignature";

		// Token: 0x0400D71E RID: 55070
		private static int RegisterId;

		// Token: 0x02003117 RID: 12567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FPushSdkMessageBluePrintDelegate_DelegateParams
		{
			// Token: 0x04016EAC RID: 93868
			[FieldOffset(0)]
			public FString source;

			// Token: 0x04016EAD RID: 93869
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02003118 RID: 12568
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016EAE RID: 93870
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
