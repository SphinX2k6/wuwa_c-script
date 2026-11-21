using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000494 RID: 1172
	public sealed class FKuroPakMountedCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006DC9 RID: 28105 RVA: 0x000A0C8B File Offset: 0x0009EE8B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroPakMountedCallback.StaticFunctionPtr();
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x000A0C97 File Offset: 0x0009EE97
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroPakMountedCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroPakMountedCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPakKey.KuroPakMountedCallback__DelegateSignature");
			}
			return FKuroPakMountedCallback._FunctionPtr;
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x000A0CBA File Offset: 0x0009EEBA
		public FKuroPakMountedCallback()
		{
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x000A0CC2 File Offset: 0x0009EEC2
		[NullableContext(2)]
		public FKuroPakMountedCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x000A0CCC File Offset: 0x0009EECC
		public FKuroPakMountedCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x000A0CD7 File Offset: 0x0009EED7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x000A0D09 File Offset: 0x0009EF09
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroPakMountedCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroPakMountedCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroPakMountedCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroPakMountedCallback.OnScriptCallback));
				}
				FKuroPakMountedCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroPakMountedCallback.RegisterId);
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x000A0D44 File Offset: 0x0009EF44
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Tag)
		{
			FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams* ptr = stackalloc FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroPakMountedCallback.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroPakMountedCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x000A0D98 File Offset: 0x0009EF98
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams*)__Parameters)->Tag));
			action(obj);
		}

		// Token: 0x04002ECD RID: 11981
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002ECE RID: 11982
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPakKey.KuroPakMountedCallback__DelegateSignature";

		// Token: 0x04002ECF RID: 11983
		private static int RegisterId;

		// Token: 0x02000BA8 RID: 2984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroPakMountedCallback_DelegateParams
		{
			// Token: 0x04005D30 RID: 23856
			[FieldOffset(0)]
			public FString Tag;
		}

		// Token: 0x02000BA9 RID: 2985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D31 RID: 23857
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
