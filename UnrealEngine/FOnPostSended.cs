using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE9 RID: 7913
	public sealed class FOnPostSended : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E13A RID: 123194 RVA: 0x002CA7AF File Offset: 0x002C89AF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPostSended.StaticFunctionPtr();
		}

		// Token: 0x0601E13B RID: 123195 RVA: 0x002CA7BB File Offset: 0x002C89BB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPostSended._FunctionPtr == IntPtr.Zero)
			{
				FOnPostSended._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPostSended__DelegateSignature");
			}
			return FOnPostSended._FunctionPtr;
		}

		// Token: 0x0601E13C RID: 123196 RVA: 0x002CA7DE File Offset: 0x002C89DE
		public FOnPostSended()
		{
		}

		// Token: 0x0601E13D RID: 123197 RVA: 0x002CA7E6 File Offset: 0x002C89E6
		[NullableContext(2)]
		public FOnPostSended(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E13E RID: 123198 RVA: 0x002CA7F0 File Offset: 0x002C89F0
		public FOnPostSended(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E13F RID: 123199 RVA: 0x002CA7FB File Offset: 0x002C89FB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnPostSended.FOnPostSended_ScriptDelegate) ?? ((FOnPostSended.FOnPostSended_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPostSended.FOnPostSended_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E140 RID: 123200 RVA: 0x002CA82D File Offset: 0x002C8A2D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnPostSended.FOnPostSended_ScriptDelegate Callback)
		{
			if (FOnPostSended.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPostSended.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPostSended.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPostSended.OnScriptCallback));
				}
				FOnPostSended.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnPostSended.RegisterId);
		}

		// Token: 0x0601E141 RID: 123201 RVA: 0x002CA868 File Offset: 0x002C8A68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SendedFiles)
		{
			FOnPostSended.__FOnPostSended_DelegateParams* ptr = stackalloc FOnPostSended.__FOnPostSended_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPostSended.__FOnPostSended_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPostSended.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = SendedFiles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SendedFiles);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = SendedFiles;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SendedFiles);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPostSended._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E142 RID: 123202 RVA: 0x002CA8D8 File Offset: 0x002C8AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPostSended.FOnPostSended_ScriptDelegate fonPostSended_ScriptDelegate = target as FOnPostSended.FOnPostSended_ScriptDelegate;
			if (fonPostSended_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FOnPostSended.__FOnPostSended_DelegateParams*)__Parameters)->SendedFiles, true, true);
			fonPostSended_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPostSended.__FOnPostSended_DelegateParams*)__Parameters)->SendedFiles, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010415 RID: 66581
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010416 RID: 66582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPostSended__DelegateSignature";

		// Token: 0x04010417 RID: 66583
		private static int RegisterId;

		// Token: 0x020033BB RID: 13243
		// (Invoke) Token: 0x060285AE RID: 165294
		public delegate void FOnPostSended_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SendedFiles);

		// Token: 0x020033BC RID: 13244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPostSended_DelegateParams
		{
			// Token: 0x04017371 RID: 95089
			[FieldOffset(0)]
			public byte SendedFiles;
		}

		// Token: 0x020033BD RID: 13245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017372 RID: 95090
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
