using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200271E RID: 10014
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Serialization.StructSerializerBuiltinTestStruct")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FStructSerializerBuiltinTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025198 RID: 151960 RVA: 0x0036F154 File Offset: 0x0036D354
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerBuiltinTestStruct._ScriptStructPtr != 0) ? FStructSerializerBuiltinTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerBuiltinTestStruct", ref FStructSerializerBuiltinTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F25 RID: 36645
		// (get) Token: 0x06025199 RID: 151961 RVA: 0x0036F178 File Offset: 0x0036D378
		// (set) Token: 0x0602519A RID: 151962 RVA: 0x0036F18C File Offset: 0x0036D38C
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17008F26 RID: 36646
		// (get) Token: 0x0602519B RID: 151963 RVA: 0x0036F1A1 File Offset: 0x0036D3A1
		// (set) Token: 0x0602519C RID: 151964 RVA: 0x0036F1B5 File Offset: 0x0036D3B5
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008F27 RID: 36647
		// (get) Token: 0x0602519D RID: 151965 RVA: 0x0036F1CA File Offset: 0x0036D3CA
		// (set) Token: 0x0602519E RID: 151966 RVA: 0x0036F1DE File Offset: 0x0036D3DE
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_String)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x17008F28 RID: 36648
		// (get) Token: 0x0602519F RID: 151967 RVA: 0x0036F1F4 File Offset: 0x0036D3F4
		// (set) Token: 0x060251A0 RID: 151968 RVA: 0x0036F237 File Offset: 0x0036D437
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Text, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008F29 RID: 36649
		// (get) Token: 0x060251A1 RID: 151969 RVA: 0x0036F252 File Offset: 0x0036D452
		// (set) Token: 0x060251A2 RID: 151970 RVA: 0x0036F266 File Offset: 0x0036D466
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17008F2A RID: 36650
		// (get) Token: 0x060251A3 RID: 151971 RVA: 0x0036F27B File Offset: 0x0036D47B
		// (set) Token: 0x060251A4 RID: 151972 RVA: 0x0036F28F File Offset: 0x0036D48F
		public unsafe FVector4 Vector4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Vector4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Vector4) = value;
			}
		}

		// Token: 0x17008F2B RID: 36651
		// (get) Token: 0x060251A5 RID: 151973 RVA: 0x0036F2A4 File Offset: 0x0036D4A4
		// (set) Token: 0x060251A6 RID: 151974 RVA: 0x0036F2B8 File Offset: 0x0036D4B8
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x17008F2C RID: 36652
		// (get) Token: 0x060251A7 RID: 151975 RVA: 0x0036F2CD File Offset: 0x0036D4CD
		// (set) Token: 0x060251A8 RID: 151976 RVA: 0x0036F2E1 File Offset: 0x0036D4E1
		public unsafe FQuat Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Quat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Quat) = value;
			}
		}

		// Token: 0x17008F2D RID: 36653
		// (get) Token: 0x060251A9 RID: 151977 RVA: 0x0036F2F6 File Offset: 0x0036D4F6
		// (set) Token: 0x060251AA RID: 151978 RVA: 0x0036F30A File Offset: 0x0036D50A
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBuiltinTestStruct.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x060251AB RID: 151979 RVA: 0x0036F31F File Offset: 0x0036D51F
		public FStructSerializerBuiltinTestStruct()
		{
		}

		// Token: 0x060251AC RID: 151980 RVA: 0x0036F328 File Offset: 0x0036D528
		public FStructSerializerBuiltinTestStruct(FGuid Guid, FName Name, string String, FText Text, FVector Vector, FVector4 Vector4, FRotator Rotator, FQuat Quat, FColor Color)
		{
			this.Guid = Guid;
			this.Name = Name;
			this.String = String;
			this.Text = Text;
			this.Vector = Vector;
			this.Vector4 = Vector4;
			this.Rotator = Rotator;
			this.Quat = Quat;
			this.Color = Color;
		}

		// Token: 0x060251AD RID: 151981 RVA: 0x0036F380 File Offset: 0x0036D580
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerBuiltinTestStruct.StaticStruct();
		}

		// Token: 0x060251AE RID: 151982 RVA: 0x0036F38C File Offset: 0x0036D58C
		[NullableContext(2)]
		public FStructSerializerBuiltinTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060251AF RID: 151983 RVA: 0x0036F396 File Offset: 0x0036D596
		public FStructSerializerBuiltinTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060251B0 RID: 151984 RVA: 0x0036F3A1 File Offset: 0x0036D5A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerBuiltinTestStruct(Pointer, false, true);
		}

		// Token: 0x060251B1 RID: 151985 RVA: 0x0036F3AB File Offset: 0x0036D5AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerBuiltinTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04013FE3 RID: 81891
		public const string __ObjectPath = "/Script/Serialization.StructSerializerBuiltinTestStruct";

		// Token: 0x04013FE4 RID: 81892
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FE5 RID: 81893
		internal static int __PropertyOffset_Guid;

		// Token: 0x04013FE6 RID: 81894
		internal static int __PropertyOffset_Name;

		// Token: 0x04013FE7 RID: 81895
		internal static int __PropertyOffset_String;

		// Token: 0x04013FE8 RID: 81896
		internal static int __PropertyOffset_Text;

		// Token: 0x04013FE9 RID: 81897
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04013FEA RID: 81898
		internal static int __PropertyOffset_Vector;

		// Token: 0x04013FEB RID: 81899
		internal static int __PropertyOffset_Vector4;

		// Token: 0x04013FEC RID: 81900
		internal static int __PropertyOffset_Rotator;

		// Token: 0x04013FED RID: 81901
		internal static int __PropertyOffset_Quat;

		// Token: 0x04013FEE RID: 81902
		internal static int __PropertyOffset_Color;
	}
}
