using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001047 RID: 4167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOConverterConfigShaderTypeFilter")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPSOConverterConfigShaderTypeFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED1C RID: 60700 RVA: 0x0015FACF File Offset: 0x0015DCCF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOConverterConfigShaderTypeFilter._ScriptStructPtr != 0) ? FPSOConverterConfigShaderTypeFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOConverterConfigShaderTypeFilter", ref FPSOConverterConfigShaderTypeFilter._ScriptStructPtr);
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600ED1D RID: 60701 RVA: 0x0015FAF3 File Offset: 0x0015DCF3
		// (set) Token: 0x0600ED1E RID: 60702 RVA: 0x0015FB07 File Offset: 0x0015DD07
		public unsafe string ShaderTypeRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderTypeFilter.__PropertyOffset_ShaderTypeRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderTypeFilter.__PropertyOffset_ShaderTypeRegex)), value);
			}
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x0015FB1C File Offset: 0x0015DD1C
		public FPSOConverterConfigShaderTypeFilter()
		{
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x0015FB24 File Offset: 0x0015DD24
		public FPSOConverterConfigShaderTypeFilter(string ShaderTypeRegex)
		{
			this.ShaderTypeRegex = ShaderTypeRegex;
		}

		// Token: 0x0600ED21 RID: 60705 RVA: 0x0015FB33 File Offset: 0x0015DD33
		protected override IntPtr GetUStructPtr()
		{
			return FPSOConverterConfigShaderTypeFilter.StaticStruct();
		}

		// Token: 0x0600ED22 RID: 60706 RVA: 0x0015FB3F File Offset: 0x0015DD3F
		[NullableContext(2)]
		public FPSOConverterConfigShaderTypeFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED23 RID: 60707 RVA: 0x0015FB49 File Offset: 0x0015DD49
		public FPSOConverterConfigShaderTypeFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED24 RID: 60708 RVA: 0x0015FB54 File Offset: 0x0015DD54
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOConverterConfigShaderTypeFilter(Pointer, false, true);
		}

		// Token: 0x0600ED25 RID: 60709 RVA: 0x0015FB5E File Offset: 0x0015DD5E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOConverterConfigShaderTypeFilter(Pointer, MemoryOwner);
		}

		// Token: 0x0400805B RID: 32859
		public const string __ObjectPath = "/Script/Engine.PSOConverterConfigShaderTypeFilter";

		// Token: 0x0400805C RID: 32860
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400805D RID: 32861
		internal static int __PropertyOffset_ShaderTypeRegex;
	}
}
