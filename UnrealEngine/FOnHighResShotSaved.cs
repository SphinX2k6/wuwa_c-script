using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000426 RID: 1062
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHighResShotSaved : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600664B RID: 26187 RVA: 0x000931D4 File Offset: 0x000913D4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHighResShotSaved.StaticFunctionPtr();
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x000931E0 File Offset: 0x000913E0
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHighResShotSaved._FunctionPtr == IntPtr.Zero)
			{
				FOnHighResShotSaved._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnHighResShotSaved__DelegateSignature");
			}
			return FOnHighResShotSaved._FunctionPtr;
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x00093203 File Offset: 0x00091403
		public FOnHighResShotSaved()
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x0009320B File Offset: 0x0009140B
		[NullableContext(2)]
		public FOnHighResShotSaved(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00093215 File Offset: 0x00091415
		public FOnHighResShotSaved(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x00093220 File Offset: 0x00091420
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00093252 File Offset: 0x00091452
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FOnHighResShotSaved.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHighResShotSaved.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHighResShotSaved.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHighResShotSaved.OnScriptCallback));
				}
				FOnHighResShotSaved.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHighResShotSaved.RegisterId);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0009328C File Offset: 0x0009148C
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x00093298 File Offset: 0x00091498
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string SavedFilePath)
		{
			FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams* ptr = stackalloc FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHighResShotSaved.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SavedFilePath), SavedFilePath);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnHighResShotSaved._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x000932EC File Offset: 0x000914EC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams*)__Parameters)->SavedFilePath));
			action(obj);
		}

		// Token: 0x04002B06 RID: 11014
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002B07 RID: 11015
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnHighResShotSaved__DelegateSignature";

		// Token: 0x04002B08 RID: 11016
		private static int RegisterId;

		// Token: 0x02000B29 RID: 2857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnHighResShotSaved_DelegateParams
		{
			// Token: 0x04005BF4 RID: 23540
			[FieldOffset(0)]
			public FString SavedFilePath;
		}

		// Token: 0x02000B2A RID: 2858
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BF5 RID: 23541
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
