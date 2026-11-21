using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052D RID: 1325
	public sealed class FPluginCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007BEA RID: 31722 RVA: 0x000B70ED File Offset: 0x000B52ED
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPluginCallback.StaticFunctionPtr();
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x000B70F9 File Offset: 0x000B52F9
		private static IntPtr StaticFunctionPtr()
		{
			if (FPluginCallback._FunctionPtr == IntPtr.Zero)
			{
				FPluginCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.PluginCallback__DelegateSignature");
			}
			return FPluginCallback._FunctionPtr;
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x000B711C File Offset: 0x000B531C
		public FPluginCallback()
		{
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x000B7124 File Offset: 0x000B5324
		[NullableContext(2)]
		public FPluginCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x000B712E File Offset: 0x000B532E
		public FPluginCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x000B7139 File Offset: 0x000B5339
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x000B716B File Offset: 0x000B536B
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FPluginCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPluginCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPluginCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPluginCallback.OnScriptCallback));
				}
				FPluginCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPluginCallback.RegisterId);
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x000B71A8 File Offset: 0x000B53A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Result)
		{
			FPluginCallback.__FPluginCallback_DelegateParams* ptr = stackalloc FPluginCallback.__FPluginCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPluginCallback.__FPluginCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPluginCallback.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPluginCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x000B71FC File Offset: 0x000B53FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FPluginCallback.__FPluginCallback_DelegateParams*)__Parameters)->Result));
			action(obj);
		}

		// Token: 0x04003507 RID: 13575
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003508 RID: 13576
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.PluginCallback__DelegateSignature";

		// Token: 0x04003509 RID: 13577
		private static int RegisterId;

		// Token: 0x02000CD1 RID: 3281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FPluginCallback_DelegateParams
		{
			// Token: 0x04005F51 RID: 24401
			[FieldOffset(0)]
			public FString Result;
		}

		// Token: 0x02000CD2 RID: 3282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F52 RID: 24402
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
