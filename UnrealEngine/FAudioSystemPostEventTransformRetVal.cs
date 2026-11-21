using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B4 RID: 948
	public sealed class FAudioSystemPostEventTransformRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D4C RID: 23884 RVA: 0x00083916 File Offset: 0x00081B16
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemPostEventTransformRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00083922 File Offset: 0x00081B22
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemPostEventTransformRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemPostEventTransformRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemPostEventTransformRetVal__DelegateSignature");
			}
			return FAudioSystemPostEventTransformRetVal._FunctionPtr;
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x00083945 File Offset: 0x00081B45
		public FAudioSystemPostEventTransformRetVal()
		{
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x0008394D File Offset: 0x00081B4D
		[NullableContext(2)]
		public FAudioSystemPostEventTransformRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x00083957 File Offset: 0x00081B57
		public FAudioSystemPostEventTransformRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x00083962 File Offset: 0x00081B62
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, FTransformDouble, int>) ?? ((Func<string, FTransformDouble, int>)Delegate.CreateDelegate(typeof(Func<string, FTransformDouble, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x00083994 File Offset: 0x00081B94
		[NullableContext(1)]
		public void Bind(Func<string, FTransformDouble, int> Callback)
		{
			if (FAudioSystemPostEventTransformRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemPostEventTransformRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemPostEventTransformRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemPostEventTransformRetVal.OnScriptCallback));
				}
				FAudioSystemPostEventTransformRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemPostEventTransformRetVal.RegisterId);
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x000839D0 File Offset: 0x00081BD0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe int Execute(string EventName, in FTransformDouble Transform)
		{
			FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams* ptr = stackalloc FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams[(UIntPtr)111] + 15L / (long)sizeof(FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemPostEventTransformRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			ptr->Transform = Transform;
			base.ExecuteInternal((void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FAudioSystemPostEventTransformRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00083A38 File Offset: 0x00081C38
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, FTransformDouble, int> func = target as Func<string, FTransformDouble, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->EventName));
			int _Result = func(arg, ((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->Transform);
			((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026E1 RID: 9953
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026E2 RID: 9954
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemPostEventTransformRetVal__DelegateSignature";

		// Token: 0x040026E3 RID: 9955
		private static int RegisterId;

		// Token: 0x02000AB3 RID: 2739
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		private ref struct __FAudioSystemPostEventTransformRetVal_DelegateParams
		{
			// Token: 0x04005B15 RID: 23317
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04005B16 RID: 23318
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x04005B17 RID: 23319
			[FieldOffset(80)]
			public int __Result;
		}

		// Token: 0x02000AB4 RID: 2740
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B18 RID: 23320
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
