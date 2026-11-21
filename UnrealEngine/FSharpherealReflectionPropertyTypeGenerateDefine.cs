using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000816 RID: 2070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSharpherealReflectionPropertyTypeGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B59D RID: 46493 RVA: 0x00120FE1 File Offset: 0x0011F1E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine", ref FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600B59E RID: 46494 RVA: 0x00121005 File Offset: 0x0011F205
		// (set) Token: 0x0600B59F RID: 46495 RVA: 0x00121015 File Offset: 0x0011F215
		public unsafe ESharpherealReflectionTypeCode TypeCode
		{
			get
			{
				return (ESharpherealReflectionTypeCode)(*(base.NativePtr + (IntPtr)FSharpherealReflectionPropertyTypeGenerateDefine.__PropertyOffset_TypeCode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealReflectionPropertyTypeGenerateDefine.__PropertyOffset_TypeCode) = (byte)value;
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600B5A0 RID: 46496 RVA: 0x00121026 File Offset: 0x0011F226
		// (set) Token: 0x0600B5A1 RID: 46497 RVA: 0x0012103A File Offset: 0x0011F23A
		public unsafe string MetaType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionPropertyTypeGenerateDefine.__PropertyOffset_MetaType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionPropertyTypeGenerateDefine.__PropertyOffset_MetaType)), value);
			}
		}

		// Token: 0x0600B5A2 RID: 46498 RVA: 0x0012104F File Offset: 0x0011F24F
		public FSharpherealReflectionPropertyTypeGenerateDefine()
		{
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x00121057 File Offset: 0x0011F257
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionPropertyTypeGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x00121063 File Offset: 0x0011F263
		[NullableContext(2)]
		public FSharpherealReflectionPropertyTypeGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x0012106D File Offset: 0x0011F26D
		public FSharpherealReflectionPropertyTypeGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x00121078 File Offset: 0x0011F278
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionPropertyTypeGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x00121082 File Offset: 0x0011F282
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionPropertyTypeGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051F9 RID: 20985
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine";

		// Token: 0x040051FA RID: 20986
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051FB RID: 20987
		internal static int __PropertyOffset_TypeCode;

		// Token: 0x040051FC RID: 20988
		internal static int __PropertyOffset_MetaType;
	}
}
