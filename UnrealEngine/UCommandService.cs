using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000373 RID: 883
	[UnrealObjectPath("/Script/KuroEditorRuntime.CommandService")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UCommandService : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060059B5 RID: 22965 RVA: 0x0007E6D3 File Offset: 0x0007C8D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCommandService._ClassPtr;
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x0007E6E0 File Offset: 0x0007C8E0
		public UCommandService() : this(BuiltinUtils.AllocNativeUObject(UCommandService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x0007E708 File Offset: 0x0007C908
		[NullableContext(1)]
		public UCommandService(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCommandService.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x0007E73C File Offset: 0x0007C93C
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x0007E775 File Offset: 0x0007C975
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

		// Token: 0x060059BA RID: 22970 RVA: 0x0007E796 File Offset: 0x0007C996
		[SkipLocalsInit]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x0007E7AC File Offset: 0x0007C9AC
		[SkipLocalsInit]
		public unsafe void Start(int Port)
		{
			UCommandService.__Start_FunctionParams* ptr = stackalloc UCommandService.__Start_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UCommandService.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCommandService.__Start_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__Start_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		[SkipLocalsInit]
		public unsafe void EnableRecvLog(bool isEnable)
		{
			UCommandService.__EnableRecvLog_FunctionParams* ptr = stackalloc UCommandService.__EnableRecvLog_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UCommandService.__EnableRecvLog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCommandService.__EnableRecvLog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isEnable = isEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UCommandService.__EnableRecvLog_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x0007E83A File Offset: 0x0007CA3A
		static UCommandService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroEditorRuntime.CommandService");
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x0007E848 File Offset: 0x0007CA48
		protected UCommandService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400252E RID: 9518
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroEditorRuntime.CommandService";

		// Token: 0x0400252F RID: 9519
		private static IntPtr _ClassPtr;

		// Token: 0x04002530 RID: 9520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002531 RID: 9521
		public static IntPtr __OnReceiveCommandEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04002532 RID: 9522
		internal static int __PropertyOffset_OnReceivedCommand;

		// Token: 0x04002533 RID: 9523
		[Nullable(2)]
		private FOnReceiveCommandEvent _OnReceivedCommand;

		// Token: 0x04002534 RID: 9524
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04002535 RID: 9525
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04002536 RID: 9526
		private static IntPtr __EnableRecvLog_NativeFunctionPtr;

		// Token: 0x02000A7D RID: 2685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Start_FunctionParams
		{
			// Token: 0x04005ABD RID: 23229
			[FieldOffset(0)]
			public int Port;
		}

		// Token: 0x02000A7E RID: 2686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableRecvLog_FunctionParams
		{
			// Token: 0x04005ABE RID: 23230
			[FieldOffset(0)]
			public bool isEnable;
		}
	}
}
