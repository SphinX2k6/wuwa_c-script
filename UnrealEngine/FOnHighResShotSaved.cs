using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001946 RID: 6470
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHighResShotSaved : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017FA8 RID: 98216 RVA: 0x00232B89 File Offset: 0x00230D89
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHighResShotSaved.StaticFunctionPtr();
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x00232B95 File Offset: 0x00230D95
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHighResShotSaved._FunctionPtr == IntPtr.Zero)
			{
				FOnHighResShotSaved._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnHighResShotSaved__DelegateSignature");
			}
			return FOnHighResShotSaved._FunctionPtr;
		}

		// Token: 0x06017FAA RID: 98218 RVA: 0x00232BB8 File Offset: 0x00230DB8
		public FOnHighResShotSaved()
		{
		}

		// Token: 0x06017FAB RID: 98219 RVA: 0x00232BC0 File Offset: 0x00230DC0
		[NullableContext(2)]
		public FOnHighResShotSaved(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017FAC RID: 98220 RVA: 0x00232BCA File Offset: 0x00230DCA
		public FOnHighResShotSaved(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017FAD RID: 98221 RVA: 0x00232BD5 File Offset: 0x00230DD5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017FAE RID: 98222 RVA: 0x00232C07 File Offset: 0x00230E07
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017FAF RID: 98223 RVA: 0x00232C41 File Offset: 0x00230E41
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017FB0 RID: 98224 RVA: 0x00232C4C File Offset: 0x00230E4C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string SavedFilePath)
		{
			FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams* ptr = stackalloc FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnHighResShotSaved.__FOnHighResShotSaved_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHighResShotSaved.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SavedFilePath), SavedFilePath);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnHighResShotSaved._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FB1 RID: 98225 RVA: 0x00232CA0 File Offset: 0x00230EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CF8C RID: 53132
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF8D RID: 53133
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnHighResShotSaved__DelegateSignature";

		// Token: 0x0400CF8E RID: 53134
		private static int RegisterId;

		// Token: 0x02003015 RID: 12309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnHighResShotSaved_DelegateParams
		{
			// Token: 0x04016C4B RID: 93259
			[FieldOffset(0)]
			public FString SavedFilePath;
		}

		// Token: 0x02003016 RID: 12310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C4C RID: 93260
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
