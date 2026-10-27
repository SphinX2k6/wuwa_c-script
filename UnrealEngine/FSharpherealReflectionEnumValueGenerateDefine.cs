using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200276C RID: 10092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionEnumValueGenerateDefine")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSharpherealReflectionEnumValueGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BBA RID: 154554 RVA: 0x00393387 File Offset: 0x00391587
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionEnumValueGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionEnumValueGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionEnumValueGenerateDefine", ref FSharpherealReflectionEnumValueGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17009144 RID: 37188
		// (get) Token: 0x06025BBB RID: 154555 RVA: 0x003933AB File Offset: 0x003915AB
		// (set) Token: 0x06025BBC RID: 154556 RVA: 0x003933BF File Offset: 0x003915BF
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionEnumValueGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionEnumValueGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17009145 RID: 37189
		// (get) Token: 0x06025BBD RID: 154557 RVA: 0x003933D4 File Offset: 0x003915D4
		// (set) Token: 0x06025BBE RID: 154558 RVA: 0x003933E4 File Offset: 0x003915E4
		public unsafe long Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealReflectionEnumValueGenerateDefine.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealReflectionEnumValueGenerateDefine.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06025BBF RID: 154559 RVA: 0x003933F5 File Offset: 0x003915F5
		public FSharpherealReflectionEnumValueGenerateDefine()
		{
		}

		// Token: 0x06025BC0 RID: 154560 RVA: 0x003933FD File Offset: 0x003915FD
		public FSharpherealReflectionEnumValueGenerateDefine(string Name, long Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x06025BC1 RID: 154561 RVA: 0x00393413 File Offset: 0x00391613
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionEnumValueGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BC2 RID: 154562 RVA: 0x0039341F File Offset: 0x0039161F
		[NullableContext(2)]
		public FSharpherealReflectionEnumValueGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BC3 RID: 154563 RVA: 0x00393429 File Offset: 0x00391629
		public FSharpherealReflectionEnumValueGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BC4 RID: 154564 RVA: 0x00393434 File Offset: 0x00391634
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionEnumValueGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BC5 RID: 154565 RVA: 0x0039343E File Offset: 0x0039163E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionEnumValueGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148A5 RID: 84133
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionEnumValueGenerateDefine";

		// Token: 0x040148A6 RID: 84134
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148A7 RID: 84135
		internal static int __PropertyOffset_Name;

		// Token: 0x040148A8 RID: 84136
		internal static int __PropertyOffset_Value;
	}
}
