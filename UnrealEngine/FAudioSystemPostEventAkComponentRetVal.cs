using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B3 RID: 947
	public sealed class FAudioSystemPostEventAkComponentRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D43 RID: 23875 RVA: 0x00083783 File Offset: 0x00081983
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemPostEventAkComponentRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x0008378F File Offset: 0x0008198F
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemPostEventAkComponentRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemPostEventAkComponentRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemPostEventAkComponentRetVal__DelegateSignature");
			}
			return FAudioSystemPostEventAkComponentRetVal._FunctionPtr;
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x000837B2 File Offset: 0x000819B2
		public FAudioSystemPostEventAkComponentRetVal()
		{
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x000837BA File Offset: 0x000819BA
		[NullableContext(2)]
		public FAudioSystemPostEventAkComponentRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x000837C4 File Offset: 0x000819C4
		public FAudioSystemPostEventAkComponentRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x000837CF File Offset: 0x000819CF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UAkComponent, int>) ?? ((Func<string, UAkComponent, int>)Delegate.CreateDelegate(typeof(Func<string, UAkComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00083801 File Offset: 0x00081A01
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, UAkComponent, int> Callback)
		{
			if (FAudioSystemPostEventAkComponentRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemPostEventAkComponentRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemPostEventAkComponentRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemPostEventAkComponentRetVal.OnScriptCallback));
				}
				FAudioSystemPostEventAkComponentRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemPostEventAkComponentRetVal.RegisterId);
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x0008383C File Offset: 0x00081A3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe int Execute(string EventName, [Nullable(2)] UAkComponent AkComponent)
		{
			FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams* ptr = stackalloc FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemPostEventAkComponentRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			ptr->AkComponent = ((AkComponent != null) ? AkComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FAudioSystemPostEventAkComponentRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x000838AC File Offset: 0x00081AAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, UAkComponent, int> func = target as Func<string, UAkComponent, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->EventName));
			UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->AkComponent);
			int _Result = func(arg, orCreateUObjectByNativePointer);
			((FAudioSystemPostEventAkComponentRetVal.__FAudioSystemPostEventAkComponentRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026DE RID: 9950
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026DF RID: 9951
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemPostEventAkComponentRetVal__DelegateSignature";

		// Token: 0x040026E0 RID: 9952
		private static int RegisterId;

		// Token: 0x02000AB1 RID: 2737
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FAudioSystemPostEventAkComponentRetVal_DelegateParams
		{
			// Token: 0x04005B11 RID: 23313
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04005B12 RID: 23314
			[FieldOffset(16)]
			public IntPtr AkComponent;

			// Token: 0x04005B13 RID: 23315
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02000AB2 RID: 2738
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B14 RID: 23316
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
