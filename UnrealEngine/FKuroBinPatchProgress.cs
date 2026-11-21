using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043F RID: 1087
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBinPatchProgress : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006910 RID: 26896 RVA: 0x00099796 File Offset: 0x00097996
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBinPatchProgress.StaticFunctionPtr();
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x000997A2 File Offset: 0x000979A2
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBinPatchProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroBinPatchProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroBinPatchProgress__DelegateSignature");
			}
			return FKuroBinPatchProgress._FunctionPtr;
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x000997C5 File Offset: 0x000979C5
		public FKuroBinPatchProgress()
		{
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x000997CD File Offset: 0x000979CD
		[NullableContext(2)]
		public FKuroBinPatchProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x000997D7 File Offset: 0x000979D7
		public FKuroBinPatchProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x000997E2 File Offset: 0x000979E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00099814 File Offset: 0x00097A14
		[NullableContext(1)]
		public void Add(Action<long> Callback)
		{
			if (FKuroBinPatchProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBinPatchProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBinPatchProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBinPatchProgress.OnScriptCallback));
				}
				FKuroBinPatchProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBinPatchProgress.RegisterId);
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x0009984E File Offset: 0x00097A4E
		[NullableContext(1)]
		public void Remove(Action<long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x00099858 File Offset: 0x00097A58
		[SkipLocalsInit]
		public unsafe void Broadcast(long CurrentSize)
		{
			FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams* ptr = stackalloc FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBinPatchProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentSize = CurrentSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x00099894 File Offset: 0x00097A94
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long> action = target as Action<long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams*)__Parameters)->CurrentSize);
		}

		// Token: 0x04002CC9 RID: 11465
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CCA RID: 11466
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatchProgress__DelegateSignature";

		// Token: 0x04002CCB RID: 11467
		private static int RegisterId;

		// Token: 0x02000B61 RID: 2913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FKuroBinPatchProgress_DelegateParams
		{
			// Token: 0x04005C79 RID: 23673
			[FieldOffset(0)]
			public long CurrentSize;
		}

		// Token: 0x02000B62 RID: 2914
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C7A RID: 23674
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
