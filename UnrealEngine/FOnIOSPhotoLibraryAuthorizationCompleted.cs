using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000427 RID: 1063
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIOSPhotoLibraryAuthorizationCompleted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006655 RID: 26197 RVA: 0x0009333E File Offset: 0x0009153E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIOSPhotoLibraryAuthorizationCompleted.StaticFunctionPtr();
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x0009334A File Offset: 0x0009154A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr == IntPtr.Zero)
			{
				FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnIOSPhotoLibraryAuthorizationCompleted__DelegateSignature");
			}
			return FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr;
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x0009336D File Offset: 0x0009156D
		public FOnIOSPhotoLibraryAuthorizationCompleted()
		{
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00093375 File Offset: 0x00091575
		[NullableContext(2)]
		public FOnIOSPhotoLibraryAuthorizationCompleted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x0009337F File Offset: 0x0009157F
		public FOnIOSPhotoLibraryAuthorizationCompleted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x0009338A File Offset: 0x0009158A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x000933BC File Offset: 0x000915BC
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIOSPhotoLibraryAuthorizationCompleted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIOSPhotoLibraryAuthorizationCompleted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIOSPhotoLibraryAuthorizationCompleted.OnScriptCallback));
				}
				FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId);
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x000933F6 File Offset: 0x000915F6
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x00093400 File Offset: 0x00091600
		[SkipLocalsInit]
		public unsafe void Broadcast(bool IsGranted)
		{
			FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams* ptr = stackalloc FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnIOSPhotoLibraryAuthorizationCompleted.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsGranted = IsGranted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x0009343C File Offset: 0x0009163C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams*)__Parameters)->IsGranted);
		}

		// Token: 0x04002B09 RID: 11017
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002B0A RID: 11018
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnIOSPhotoLibraryAuthorizationCompleted__DelegateSignature";

		// Token: 0x04002B0B RID: 11019
		private static int RegisterId;

		// Token: 0x02000B2B RID: 2859
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams
		{
			// Token: 0x04005BF6 RID: 23542
			[FieldOffset(0)]
			public bool IsGranted;
		}

		// Token: 0x02000B2C RID: 2860
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BF7 RID: 23543
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
