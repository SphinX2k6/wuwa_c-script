using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C4 RID: 1732
	public sealed class FLGUITextInputCustomInputTypeDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009409 RID: 37897 RVA: 0x000DF315 File Offset: 0x000DD515
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextInputCustomInputTypeDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x000DF321 File Offset: 0x000DD521
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextInputCustomInputTypeDynamicDelegate__DelegateSignature");
			}
			return FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x000DF344 File Offset: 0x000DD544
		public FLGUITextInputCustomInputTypeDynamicDelegate()
		{
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x000DF34C File Offset: 0x000DD54C
		[NullableContext(2)]
		public FLGUITextInputCustomInputTypeDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x000DF356 File Offset: 0x000DD556
		public FLGUITextInputCustomInputTypeDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x000DF361 File Offset: 0x000DD561
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x000DF393 File Offset: 0x000DD593
		[NullableContext(1)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextInputCustomInputTypeDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextInputCustomInputTypeDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextInputCustomInputTypeDynamicDelegate.OnScriptCallback));
				}
				FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId);
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x000DF3D0 File Offset: 0x000DD5D0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe bool Execute(string InString)
		{
			FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams* ptr = stackalloc FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextInputCustomInputTypeDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x000DF42C File Offset: 0x000DD62C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams*)__Parameters)->InString));
			bool _Result = func(arg);
			((FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04004081 RID: 16513
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004082 RID: 16514
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextInputCustomInputTypeDynamicDelegate__DelegateSignature";

		// Token: 0x04004083 RID: 16515
		private static int RegisterId;

		// Token: 0x02000EF4 RID: 3828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams
		{
			// Token: 0x040062B7 RID: 25271
			[FieldOffset(0)]
			public FString InString;

			// Token: 0x040062B8 RID: 25272
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000EF5 RID: 3829
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062B9 RID: 25273
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
