using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000544 RID: 1348
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKPostRedPointDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CCF RID: 31951 RVA: 0x000B9147 File Offset: 0x000B7347
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKPostRedPointDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x000B9153 File Offset: 0x000B7353
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKPostRedPointDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKPostRedPointDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKPostRedPointDelegate__DelegateSignature");
			}
			return FSDKPostRedPointDelegate._FunctionPtr;
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x000B9176 File Offset: 0x000B7376
		public FSDKPostRedPointDelegate()
		{
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x000B917E File Offset: 0x000B737E
		[NullableContext(2)]
		public FSDKPostRedPointDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x000B9188 File Offset: 0x000B7388
		public FSDKPostRedPointDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x000B9193 File Offset: 0x000B7393
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x000B91C5 File Offset: 0x000B73C5
		[NullableContext(1)]
		public void Add(Action<byte> Callback)
		{
			if (FSDKPostRedPointDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKPostRedPointDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKPostRedPointDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKPostRedPointDelegate.OnScriptCallback));
				}
				FSDKPostRedPointDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKPostRedPointDelegate.RegisterId);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x000B91FF File Offset: 0x000B73FF
		[NullableContext(1)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x000B9208 File Offset: 0x000B7408
		[SkipLocalsInit]
		public unsafe void Broadcast(byte flagId)
		{
			FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams* ptr = stackalloc FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKPostRedPointDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->flagId = flagId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x000B9244 File Offset: 0x000B7444
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams*)__Parameters)->flagId);
		}

		// Token: 0x0400354C RID: 13644
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400354D RID: 13645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKPostRedPointDelegate__DelegateSignature";

		// Token: 0x0400354E RID: 13646
		private static int RegisterId;

		// Token: 0x02000CFC RID: 3324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FSDKPostRedPointDelegate_DelegateParams
		{
			// Token: 0x04005F86 RID: 24454
			[FieldOffset(0)]
			public byte flagId;
		}

		// Token: 0x02000CFD RID: 3325
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F87 RID: 24455
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
