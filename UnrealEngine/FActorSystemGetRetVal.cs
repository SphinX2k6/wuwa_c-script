using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200188A RID: 6282
	public sealed class FActorSystemGetRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601726B RID: 94827 RVA: 0x0021BC00 File Offset: 0x00219E00
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSystemGetRetVal.StaticFunctionPtr();
		}

		// Token: 0x0601726C RID: 94828 RVA: 0x0021BC0C File Offset: 0x00219E0C
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSystemGetRetVal._FunctionPtr == IntPtr.Zero)
			{
				FActorSystemGetRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActorSystemGetRetVal__DelegateSignature");
			}
			return FActorSystemGetRetVal._FunctionPtr;
		}

		// Token: 0x0601726D RID: 94829 RVA: 0x0021BC2F File Offset: 0x00219E2F
		public FActorSystemGetRetVal()
		{
		}

		// Token: 0x0601726E RID: 94830 RVA: 0x0021BC37 File Offset: 0x00219E37
		[NullableContext(2)]
		public FActorSystemGetRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601726F RID: 94831 RVA: 0x0021BC41 File Offset: 0x00219E41
		public FActorSystemGetRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017270 RID: 94832 RVA: 0x0021BC4C File Offset: 0x00219E4C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate) ?? ((FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate)Delegate.CreateDelegate(typeof(FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017271 RID: 94833 RVA: 0x0021BC7E File Offset: 0x00219E7E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017272 RID: 94834 RVA: 0x0021BCB8 File Offset: 0x00219EB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017273 RID: 94835 RVA: 0x0021BD0C File Offset: 0x00219F0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C8E6 RID: 51430
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8E7 RID: 51431
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActorSystemGetRetVal__DelegateSignature";

		// Token: 0x0400C8E8 RID: 51432
		private static int RegisterId;

		// Token: 0x02002F84 RID: 12164
		// (Invoke) Token: 0x06028582 RID: 165250
		public delegate AActor FActorSystemGetRetVal_ScriptDelegate([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, in FTransformDouble Transform);

		// Token: 0x02002F85 RID: 12165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __FActorSystemGetRetVal_DelegateParams
		{
			// Token: 0x04016B44 RID: 92996
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<AActor> Class;

			// Token: 0x04016B45 RID: 92997
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x04016B46 RID: 92998
			[FieldOffset(80)]
			public IntPtr __Result;
		}

		// Token: 0x02002F86 RID: 12166
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B47 RID: 92999
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
