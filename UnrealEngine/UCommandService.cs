using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200181E RID: 6174
	[UnrealObjectPath("/Script/KuroEditorRuntime.CommandService")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UCommandService : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016CEF RID: 93423 RVA: 0x00214766 File Offset: 0x00212966
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCommandService._ClassPtr;
		}

		// Token: 0x06016CF0 RID: 93424 RVA: 0x00214774 File Offset: 0x00212974
		public UCommandService() : this(BuiltinUtils.AllocNativeUObject(UCommandService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016CF1 RID: 93425 RVA: 0x0021479C File Offset: 0x0021299C
		[NullableContext(1)]
		public UCommandService(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCommandService.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x06016CF2 RID: 93426 RVA: 0x002147D0 File Offset: 0x002129D0
		// (set) Token: 0x06016CF3 RID: 93427 RVA: 0x00214809 File Offset: 0x00212A09
		[Nullable(1)]
		public FOnReceiveCommandEvent OnReceivedCommand
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnReceiveCommandEvent result;
				if ((result = this._OnReceivedCommand) == null)
				{
					result = (this._OnReceivedCommand = new FOnReceiveCommandEvent(base.NativePtr + (IntPtr)UCommandService.__PropertyOffset_OnReceivedCommand, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCommandService.__PropertyOffset_OnReceivedCommand, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06016CF4 RID: 93428 RVA: 0x0021482A File Offset: 0x00212A2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__Stop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016CF5 RID: 93429 RVA: 0x00214840 File Offset: 0x00212A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Start(int Port)
		{
			UCommandService.__Start_FunctionParams* ptr = stackalloc UCommandService.__Start_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UCommandService.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCommandService.__Start_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__Start_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016CF6 RID: 93430 RVA: 0x00214888 File Offset: 0x00212A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableRecvLog(bool isEnable)
		{
			UCommandService.__EnableRecvLog_FunctionParams* ptr = stackalloc UCommandService.__EnableRecvLog_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UCommandService.__EnableRecvLog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCommandService.__EnableRecvLog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isEnable = isEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__EnableRecvLog_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016CF7 RID: 93431 RVA: 0x002148CF File Offset: 0x00212ACF
		static UCommandService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroEditorRuntime.CommandService");
		}

		// Token: 0x06016CF8 RID: 93432 RVA: 0x002148DD File Offset: 0x00212ADD
		protected UCommandService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C638 RID: 50744
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroEditorRuntime.CommandService";

		// Token: 0x0400C639 RID: 50745
		private static IntPtr _ClassPtr;

		// Token: 0x0400C63A RID: 50746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C63B RID: 50747
		public static IntPtr __OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400C63C RID: 50748
		internal static int __PropertyOffset_OnReceivedCommand;

		// Token: 0x0400C63D RID: 50749
		[Nullable(2)]
		private FOnReceiveCommandEvent _OnReceivedCommand;

		// Token: 0x0400C63E RID: 50750
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400C63F RID: 50751
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400C640 RID: 50752
		private static IntPtr __EnableRecvLog_NativeFunctionPtr;

		// Token: 0x02002F54 RID: 12116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Start_FunctionParams
		{
			// Token: 0x04016AFB RID: 92923
			[FieldOffset(0)]
			public int Port;
		}

		// Token: 0x02002F55 RID: 12117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableRecvLog_FunctionParams
		{
			// Token: 0x04016AFC RID: 92924
			[FieldOffset(0)]
			public bool isEnable;
		}
	}
}
