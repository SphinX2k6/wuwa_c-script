using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002763 RID: 10083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpGameAssemblyConfig")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSharpGameAssemblyConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025B56 RID: 154454 RVA: 0x00392672 File Offset: 0x00390872
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpGameAssemblyConfig._ScriptStructPtr != 0) ? FSharpGameAssemblyConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpGameAssemblyConfig", ref FSharpGameAssemblyConfig._ScriptStructPtr);
		}

		// Token: 0x17009138 RID: 37176
		// (get) Token: 0x06025B57 RID: 154455 RVA: 0x00392696 File Offset: 0x00390896
		// (set) Token: 0x06025B58 RID: 154456 RVA: 0x003926AA File Offset: 0x003908AA
		public unsafe string AssemblyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpGameAssemblyConfig.__PropertyOffset_AssemblyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpGameAssemblyConfig.__PropertyOffset_AssemblyName)), value);
			}
		}

		// Token: 0x17009139 RID: 37177
		// (get) Token: 0x06025B59 RID: 154457 RVA: 0x003926BF File Offset: 0x003908BF
		// (set) Token: 0x06025B5A RID: 154458 RVA: 0x003926D3 File Offset: 0x003908D3
		public unsafe string GeneratedOutputDir
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpGameAssemblyConfig.__PropertyOffset_GeneratedOutputDir)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpGameAssemblyConfig.__PropertyOffset_GeneratedOutputDir)), value);
			}
		}

		// Token: 0x1700913A RID: 37178
		// (get) Token: 0x06025B5B RID: 154459 RVA: 0x003926E8 File Offset: 0x003908E8
		// (set) Token: 0x06025B5C RID: 154460 RVA: 0x0039272B File Offset: 0x0039092B
		public TArray<string> TsSourcePathPrefixes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TsSourcePathPrefixes) == null)
				{
					result = (this._TsSourcePathPrefixes = new TArray<string>(base.NativePtr + (IntPtr)FSharpGameAssemblyConfig.__PropertyOffset_TsSourcePathPrefixes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TsSourcePathPrefixes.CopyAssign(value);
			}
		}

		// Token: 0x06025B5D RID: 154461 RVA: 0x00392739 File Offset: 0x00390939
		public FSharpGameAssemblyConfig()
		{
		}

		// Token: 0x06025B5E RID: 154462 RVA: 0x00392741 File Offset: 0x00390941
		public FSharpGameAssemblyConfig(string AssemblyName, string GeneratedOutputDir, TArray<string> TsSourcePathPrefixes)
		{
			this.AssemblyName = AssemblyName;
			this.GeneratedOutputDir = GeneratedOutputDir;
			this.TsSourcePathPrefixes = TsSourcePathPrefixes;
		}

		// Token: 0x06025B5F RID: 154463 RVA: 0x0039275E File Offset: 0x0039095E
		protected override IntPtr GetUStructPtr()
		{
			return FSharpGameAssemblyConfig.StaticStruct();
		}

		// Token: 0x06025B60 RID: 154464 RVA: 0x0039276A File Offset: 0x0039096A
		[NullableContext(2)]
		public FSharpGameAssemblyConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B61 RID: 154465 RVA: 0x00392774 File Offset: 0x00390974
		public FSharpGameAssemblyConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B62 RID: 154466 RVA: 0x0039277F File Offset: 0x0039097F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpGameAssemblyConfig(Pointer, false, true);
		}

		// Token: 0x06025B63 RID: 154467 RVA: 0x00392789 File Offset: 0x00390989
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpGameAssemblyConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014878 RID: 84088
		public const string __ObjectPath = "/Script/Sharphereal.SharpGameAssemblyConfig";

		// Token: 0x04014879 RID: 84089
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401487A RID: 84090
		internal static int __PropertyOffset_AssemblyName;

		// Token: 0x0401487B RID: 84091
		internal static int __PropertyOffset_GeneratedOutputDir;

		// Token: 0x0401487C RID: 84092
		internal static int __PropertyOffset_TsSourcePathPrefixes;

		// Token: 0x0401487D RID: 84093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TsSourcePathPrefixes;
	}
}
