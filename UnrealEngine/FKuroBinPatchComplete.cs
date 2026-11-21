using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043E RID: 1086
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBinPatchComplete : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006906 RID: 26886 RVA: 0x00099612 File Offset: 0x00097812
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBinPatchComplete.StaticFunctionPtr();
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x0009961E File Offset: 0x0009781E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBinPatchComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroBinPatchComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroBinPatchComplete__DelegateSignature");
			}
			return FKuroBinPatchComplete._FunctionPtr;
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x00099641 File Offset: 0x00097841
		public FKuroBinPatchComplete()
		{
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x00099649 File Offset: 0x00097849
		[NullableContext(2)]
		public FKuroBinPatchComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00099653 File Offset: 0x00097853
		public FKuroBinPatchComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x0009965E File Offset: 0x0009785E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, TArray<string>>) ?? ((Action<int, TArray<string>>)Delegate.CreateDelegate(typeof(Action<int, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x00099690 File Offset: 0x00097890
		[NullableContext(1)]
		public void Add(Action<int, TArray<string>> Callback)
		{
			if (FKuroBinPatchComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBinPatchComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBinPatchComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBinPatchComplete.OnScriptCallback));
				}
				FKuroBinPatchComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBinPatchComplete.RegisterId);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x000996CA File Offset: 0x000978CA
		[NullableContext(1)]
		public void Remove(Action<int, TArray<string>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x000996D4 File Offset: 0x000978D4
		[SkipLocalsInit]
		public unsafe void Broadcast(int ResultCode, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> SucFiles)
		{
			FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams* ptr = stackalloc FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBinPatchComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ResultCode = ResultCode;
			if (SucFiles != null)
			{
				SucFiles.CopyTo(&ptr->SucFiles, default(UScriptStructStackOnlyPtr));
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroBinPatchComplete._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x0009973C File Offset: 0x0009793C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, TArray<string>> action = target as Action<int, TArray<string>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> arg = new TArray<string>(&((FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams*)__Parameters)->SucFiles, true, true);
			action(((FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams*)__Parameters)->ResultCode, arg);
		}

		// Token: 0x04002CC6 RID: 11462
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CC7 RID: 11463
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatchComplete__DelegateSignature";

		// Token: 0x04002CC8 RID: 11464
		private static int RegisterId;

		// Token: 0x02000B5F RID: 2911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroBinPatchComplete_DelegateParams
		{
			// Token: 0x04005C76 RID: 23670
			[FieldOffset(0)]
			public int ResultCode;

			// Token: 0x04005C77 RID: 23671
			[FieldOffset(8)]
			public byte SucFiles;
		}

		// Token: 0x02000B60 RID: 2912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C78 RID: 23672
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
