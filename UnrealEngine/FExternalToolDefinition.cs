using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BCF RID: 3023
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ExternalToolDefinition")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FExternalToolDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600949A RID: 38042 RVA: 0x000D4175 File Offset: 0x000D2375
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExternalToolDefinition._ScriptStructPtr != 0) ? FExternalToolDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExternalToolDefinition", ref FExternalToolDefinition._ScriptStructPtr);
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600949B RID: 38043 RVA: 0x000D4199 File Offset: 0x000D2399
		// (set) Token: 0x0600949C RID: 38044 RVA: 0x000D41AD File Offset: 0x000D23AD
		public unsafe string ToolName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_ToolName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_ToolName)), value);
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x000D41C4 File Offset: 0x000D23C4
		// (set) Token: 0x0600949E RID: 38046 RVA: 0x000D4207 File Offset: 0x000D2407
		public FFilePath ExecutablePath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._ExecutablePath) == null)
				{
					result = (this._ExecutablePath = new FFilePath(base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_ExecutablePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_ExecutablePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x000D4228 File Offset: 0x000D2428
		// (set) Token: 0x060094A0 RID: 38048 RVA: 0x000D423C File Offset: 0x000D243C
		public unsafe string CommandLineOptions
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_CommandLineOptions)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_CommandLineOptions)), value);
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x060094A1 RID: 38049 RVA: 0x000D4254 File Offset: 0x000D2454
		// (set) Token: 0x060094A2 RID: 38050 RVA: 0x000D4297 File Offset: 0x000D2497
		public FDirectoryPath WorkingDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._WorkingDirectory) == null)
				{
					result = (this._WorkingDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_WorkingDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_WorkingDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x060094A3 RID: 38051 RVA: 0x000D42B8 File Offset: 0x000D24B8
		// (set) Token: 0x060094A4 RID: 38052 RVA: 0x000D42CC File Offset: 0x000D24CC
		public unsafe string ScriptExtension
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_ScriptExtension)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FExternalToolDefinition.__PropertyOffset_ScriptExtension)), value);
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x060094A5 RID: 38053 RVA: 0x000D42E4 File Offset: 0x000D24E4
		// (set) Token: 0x060094A6 RID: 38054 RVA: 0x000D4327 File Offset: 0x000D2527
		public FDirectoryPath ScriptDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._ScriptDirectory) == null)
				{
					result = (this._ScriptDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_ScriptDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)FExternalToolDefinition.__PropertyOffset_ScriptDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x000D4348 File Offset: 0x000D2548
		public FExternalToolDefinition()
		{
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x000D4350 File Offset: 0x000D2550
		public FExternalToolDefinition(string ToolName, FFilePath ExecutablePath, string CommandLineOptions, FDirectoryPath WorkingDirectory, string ScriptExtension, FDirectoryPath ScriptDirectory)
		{
			this.ToolName = ToolName;
			this.ExecutablePath = ExecutablePath;
			this.CommandLineOptions = CommandLineOptions;
			this.WorkingDirectory = WorkingDirectory;
			this.ScriptExtension = ScriptExtension;
			this.ScriptDirectory = ScriptDirectory;
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x000D4385 File Offset: 0x000D2585
		protected override IntPtr GetUStructPtr()
		{
			return FExternalToolDefinition.StaticStruct();
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x000D4391 File Offset: 0x000D2591
		[NullableContext(2)]
		public FExternalToolDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x000D439B File Offset: 0x000D259B
		public FExternalToolDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x000D43A6 File Offset: 0x000D25A6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExternalToolDefinition(Pointer, false, true);
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x000D43B0 File Offset: 0x000D25B0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExternalToolDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04005379 RID: 21369
		public const string __ObjectPath = "/Script/Engine.ExternalToolDefinition";

		// Token: 0x0400537A RID: 21370
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400537B RID: 21371
		internal static int __PropertyOffset_ToolName;

		// Token: 0x0400537C RID: 21372
		internal static int __PropertyOffset_ExecutablePath;

		// Token: 0x0400537D RID: 21373
		[Nullable(2)]
		private FFilePath _ExecutablePath;

		// Token: 0x0400537E RID: 21374
		internal static int __PropertyOffset_CommandLineOptions;

		// Token: 0x0400537F RID: 21375
		internal static int __PropertyOffset_WorkingDirectory;

		// Token: 0x04005380 RID: 21376
		[Nullable(2)]
		private FDirectoryPath _WorkingDirectory;

		// Token: 0x04005381 RID: 21377
		internal static int __PropertyOffset_ScriptExtension;

		// Token: 0x04005382 RID: 21378
		internal static int __PropertyOffset_ScriptDirectory;

		// Token: 0x04005383 RID: 21379
		[Nullable(2)]
		private FDirectoryPath _ScriptDirectory;
	}
}
