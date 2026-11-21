using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AE RID: 942
	public sealed class FActorSystemGetRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D16 RID: 23830 RVA: 0x000830A0 File Offset: 0x000812A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSystemGetRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x000830AC File Offset: 0x000812AC
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSystemGetRetVal._FunctionPtr == IntPtr.Zero)
			{
				FActorSystemGetRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActorSystemGetRetVal__DelegateSignature");
			}
			return FActorSystemGetRetVal._FunctionPtr;
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x000830CF File Offset: 0x000812CF
		public FActorSystemGetRetVal()
		{
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x000830D7 File Offset: 0x000812D7
		[NullableContext(2)]
		public FActorSystemGetRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x000830E1 File Offset: 0x000812E1
		public FActorSystemGetRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x000830EC File Offset: 0x000812EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate) ?? ((FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate)Delegate.CreateDelegate(typeof(FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x0008311E File Offset: 0x0008131E
		[NullableContext(1)]
		public void Bind(FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate Callback)
		{
			if (FActorSystemGetRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorSystemGetRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorSystemGetRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorSystemGetRetVal.OnScriptCallback));
				}
				FActorSystemGetRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FActorSystemGetRetVal.RegisterId);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00083158 File Offset: 0x00081358
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe AActor Execute([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, in FTransformDouble Transform)
		{
			FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams* ptr = stackalloc FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams[(UIntPtr)111] + 15L / (long)sizeof(FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorSystemGetRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Class = Class;
			ptr->Transform = Transform;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x000831AC File Offset: 0x000813AC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate factorSystemGetRetVal_ScriptDelegate = target as FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate;
			if (factorSystemGetRetVal_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor aactor = factorSystemGetRetVal_ScriptDelegate(((FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams*)__Parameters)->Class, ((FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams*)__Parameters)->Transform);
			((FActorSystemGetRetVal.__FActorSystemGetRetVal_DelegateParams*)__Parameters)->__Result = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x040026CF RID: 9935
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026D0 RID: 9936
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActorSystemGetRetVal__DelegateSignature";

		// Token: 0x040026D1 RID: 9937
		private static int RegisterId;

		// Token: 0x02000AA7 RID: 2727
		// (Invoke) Token: 0x0600BEF3 RID: 48883
		public delegate AActor FActorSystemGetRetVal_ScriptDelegate([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, in FTransformDouble Transform);

		// Token: 0x02000AA8 RID: 2728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		private ref struct __FActorSystemGetRetVal_DelegateParams
		{
			// Token: 0x04005B01 RID: 23297
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<AActor> Class;

			// Token: 0x04005B02 RID: 23298
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x04005B03 RID: 23299
			[FieldOffset(80)]
			public IntPtr __Result;
		}

		// Token: 0x02000AA9 RID: 2729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B04 RID: 23300
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
