using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002770 RID: 10096
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSharpherealReflectionPropertyTypeGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BF0 RID: 154608 RVA: 0x003937D7 File Offset: 0x003919D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine", ref FSharpherealReflectionPropertyTypeGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x1700914F RID: 37199
		// (get) Token: 0x06025BF1 RID: 154609 RVA: 0x003937FB File Offset: 0x003919FB
		// (set) Token: 0x06025BF2 RID: 154610 RVA: 0x0039380B File Offset: 0x00391A0B
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

		// Token: 0x17009150 RID: 37200
		// (get) Token: 0x06025BF3 RID: 154611 RVA: 0x0039381C File Offset: 0x00391A1C
		// (set) Token: 0x06025BF4 RID: 154612 RVA: 0x00393830 File Offset: 0x00391A30
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

		// Token: 0x06025BF5 RID: 154613 RVA: 0x00393845 File Offset: 0x00391A45
		public FSharpherealReflectionPropertyTypeGenerateDefine()
		{
		}

		// Token: 0x06025BF6 RID: 154614 RVA: 0x0039384D File Offset: 0x00391A4D
		public FSharpherealReflectionPropertyTypeGenerateDefine(ESharpherealReflectionTypeCode TypeCode, string MetaType)
		{
			this.TypeCode = TypeCode;
			this.MetaType = MetaType;
		}

		// Token: 0x06025BF7 RID: 154615 RVA: 0x00393863 File Offset: 0x00391A63
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionPropertyTypeGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BF8 RID: 154616 RVA: 0x0039386F File Offset: 0x00391A6F
		[NullableContext(2)]
		public FSharpherealReflectionPropertyTypeGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BF9 RID: 154617 RVA: 0x00393879 File Offset: 0x00391A79
		public FSharpherealReflectionPropertyTypeGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BFA RID: 154618 RVA: 0x00393884 File Offset: 0x00391A84
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionPropertyTypeGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BFB RID: 154619 RVA: 0x0039388E File Offset: 0x00391A8E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionPropertyTypeGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148BC RID: 84156
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionPropertyTypeGenerateDefine";

		// Token: 0x040148BD RID: 84157
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148BE RID: 84158
		internal static int __PropertyOffset_TypeCode;

		// Token: 0x040148BF RID: 84159
		internal static int __PropertyOffset_MetaType;
	}
}
