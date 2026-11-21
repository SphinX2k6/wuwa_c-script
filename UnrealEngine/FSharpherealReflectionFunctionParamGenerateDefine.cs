using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000814 RID: 2068
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSharpherealReflectionFunctionParamGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B585 RID: 46469 RVA: 0x00120E09 File Offset: 0x0011F009
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine", ref FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600B586 RID: 46470 RVA: 0x00120E2D File Offset: 0x0011F02D
		// (set) Token: 0x0600B587 RID: 46471 RVA: 0x00120E41 File Offset: 0x0011F041
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600B588 RID: 46472 RVA: 0x00120E56 File Offset: 0x0011F056
		// (set) Token: 0x0600B589 RID: 46473 RVA: 0x00120E66 File Offset: 0x0011F066
		public unsafe ESharpherealReflectionUFunctionParamMode Mode
		{
			get
			{
				return (ESharpherealReflectionUFunctionParamMode)(*(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600B58A RID: 46474 RVA: 0x00120E78 File Offset: 0x0011F078
		// (set) Token: 0x0600B58B RID: 46475 RVA: 0x00120EBB File Offset: 0x0011F0BB
		public TArray<FSharpherealReflectionPropertyTypeGenerateDefine> TypeDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionPropertyTypeGenerateDefine> result;
				if ((result = this._TypeDefine) == null)
				{
					result = (this._TypeDefine = new TArray<FSharpherealReflectionPropertyTypeGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_TypeDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TypeDefine.CopyAssign(value);
			}
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x00120EC9 File Offset: 0x0011F0C9
		public FSharpherealReflectionFunctionParamGenerateDefine()
		{
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x00120ED1 File Offset: 0x0011F0D1
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionFunctionParamGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x00120EDD File Offset: 0x0011F0DD
		[NullableContext(2)]
		public FSharpherealReflectionFunctionParamGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x00120EE7 File Offset: 0x0011F0E7
		public FSharpherealReflectionFunctionParamGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B590 RID: 46480 RVA: 0x00120EF2 File Offset: 0x0011F0F2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionFunctionParamGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x00120EFC File Offset: 0x0011F0FC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionFunctionParamGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051EE RID: 20974
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine";

		// Token: 0x040051EF RID: 20975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051F0 RID: 20976
		internal static int __PropertyOffset_Name;

		// Token: 0x040051F1 RID: 20977
		internal static int __PropertyOffset_Mode;

		// Token: 0x040051F2 RID: 20978
		internal static int __PropertyOffset_TypeDefine;

		// Token: 0x040051F3 RID: 20979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyTypeGenerateDefine> _TypeDefine;
	}
}
