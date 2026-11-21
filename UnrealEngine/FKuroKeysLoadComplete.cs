using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000492 RID: 1170
	public sealed class FKuroKeysLoadComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006DAC RID: 28076 RVA: 0x000A09E8 File Offset: 0x0009EBE8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroKeysLoadComplete.StaticFunctionPtr();
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x000A09F4 File Offset: 0x0009EBF4
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroKeysLoadComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroKeysLoadComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPakKey.KuroKeysLoadComplete__DelegateSignature");
			}
			return FKuroKeysLoadComplete._FunctionPtr;
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x000A0A17 File Offset: 0x0009EC17
		public FKuroKeysLoadComplete()
		{
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x000A0A1F File Offset: 0x0009EC1F
		[NullableContext(2)]
		public FKuroKeysLoadComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x000A0A29 File Offset: 0x0009EC29
		public FKuroKeysLoadComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x000A0A34 File Offset: 0x0009EC34
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x000A0A66 File Offset: 0x0009EC66
		[NullableContext(1)]
		public void Bind(Action<bool, string> Callback)
		{
			if (FKuroKeysLoadComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroKeysLoadComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroKeysLoadComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroKeysLoadComplete.OnScriptCallback));
				}
				FKuroKeysLoadComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroKeysLoadComplete.RegisterId);
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x000A0AA0 File Offset: 0x0009ECA0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(bool Success, string Tag)
		{
			FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams* ptr = stackalloc FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroKeysLoadComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Success = Success;
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroKeysLoadComplete._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x000A0AFC File Offset: 0x0009ECFC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams*)__Parameters)->Tag));
			action(((FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams*)__Parameters)->Success, arg);
		}

		// Token: 0x04002EC7 RID: 11975
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EC8 RID: 11976
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPakKey.KuroKeysLoadComplete__DelegateSignature";

		// Token: 0x04002EC9 RID: 11977
		private static int RegisterId;

		// Token: 0x02000BA6 RID: 2982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroKeysLoadComplete_DelegateParams
		{
			// Token: 0x04005D2D RID: 23853
			[FieldOffset(0)]
			public bool Success;

			// Token: 0x04005D2E RID: 23854
			[FieldOffset(8)]
			public FString Tag;
		}

		// Token: 0x02000BA7 RID: 2983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D2F RID: 23855
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
