using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E3 RID: 1763
	public sealed class FTsGameRichTextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060095B4 RID: 38324 RVA: 0x000E208F File Offset: 0x000E028F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTsGameRichTextDelegate.StaticFunctionPtr();
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x000E209B File Offset: 0x000E029B
		private static IntPtr StaticFunctionPtr()
		{
			if (FTsGameRichTextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTsGameRichTextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.TsGameRichTextDelegate__DelegateSignature");
			}
			return FTsGameRichTextDelegate._FunctionPtr;
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x000E20BE File Offset: 0x000E02BE
		public FTsGameRichTextDelegate()
		{
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x000E20C6 File Offset: 0x000E02C6
		[NullableContext(2)]
		public FTsGameRichTextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x000E20D0 File Offset: 0x000E02D0
		public FTsGameRichTextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x000E20DB File Offset: 0x000E02DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, TArray<string>, string>) ?? ((Func<string, TArray<string>, string>)Delegate.CreateDelegate(typeof(Func<string, TArray<string>, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x000E210D File Offset: 0x000E030D
		[NullableContext(1)]
		public void Bind(Func<string, TArray<string>, string> Callback)
		{
			if (FTsGameRichTextDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTsGameRichTextDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTsGameRichTextDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTsGameRichTextDelegate.OnScriptCallback));
				}
				FTsGameRichTextDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTsGameRichTextDelegate.RegisterId);
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x000E2148 File Offset: 0x000E0348
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string Execute(string RichTextType, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> Params)
		{
			FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams* ptr = stackalloc FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTsGameRichTextDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RichTextType), RichTextType);
			if (Params != null)
			{
				Params.CopyTo(&ptr->Params, default(UScriptStructStackOnlyPtr));
			}
			base.ExecuteInternal((void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(FTsGameRichTextDelegate._FunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x000E21C4 File Offset: 0x000E03C4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, TArray<string>, string> func = target as Func<string, TArray<string>, string>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->RichTextType));
			TArray<string> arg2 = new TArray<string>(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->Params, true, true);
			string src = func(arg, arg2);
			FString.CopyFrom((void*)(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->__Result), src);
		}

		// Token: 0x04004126 RID: 16678
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004127 RID: 16679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.TsGameRichTextDelegate__DelegateSignature";

		// Token: 0x04004128 RID: 16680
		private static int RegisterId;

		// Token: 0x02000F12 RID: 3858
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FTsGameRichTextDelegate_DelegateParams
		{
			// Token: 0x040062DF RID: 25311
			[FieldOffset(0)]
			public FString RichTextType;

			// Token: 0x040062E0 RID: 25312
			[FieldOffset(16)]
			public byte Params;

			// Token: 0x040062E1 RID: 25313
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x02000F13 RID: 3859
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062E2 RID: 25314
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
