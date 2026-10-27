using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002141 RID: 8513
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDropdownOptionData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FUIDropdownOptionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060200FF RID: 131327 RVA: 0x002FAEC1 File Offset: 0x002F90C1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIDropdownOptionData._ScriptStructPtr != 0) ? FUIDropdownOptionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIDropdownOptionData", ref FUIDropdownOptionData._ScriptStructPtr);
		}

		// Token: 0x17007DED RID: 32237
		// (get) Token: 0x06020100 RID: 131328 RVA: 0x002FAEE5 File Offset: 0x002F90E5
		// (set) Token: 0x06020101 RID: 131329 RVA: 0x002FAEF9 File Offset: 0x002F90F9
		public unsafe string TextOrConfigTableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_TextOrConfigTableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_TextOrConfigTableName)), value);
			}
		}

		// Token: 0x17007DEE RID: 32238
		// (get) Token: 0x06020102 RID: 131330 RVA: 0x002FAF0E File Offset: 0x002F910E
		// (set) Token: 0x06020103 RID: 131331 RVA: 0x002FAF22 File Offset: 0x002F9122
		[Nullable(2)]
		public unsafe ULGUISpriteData_BaseObject Sprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + FUIDropdownOptionData.__PropertyOffset_Sprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIDropdownOptionData.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17007DEF RID: 32239
		// (get) Token: 0x06020104 RID: 131332 RVA: 0x002FAF37 File Offset: 0x002F9137
		// (set) Token: 0x06020105 RID: 131333 RVA: 0x002FAF47 File Offset: 0x002F9147
		public unsafe int TextId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIDropdownOptionData.__PropertyOffset_TextId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIDropdownOptionData.__PropertyOffset_TextId) = value;
			}
		}

		// Token: 0x17007DF0 RID: 32240
		// (get) Token: 0x06020106 RID: 131334 RVA: 0x002FAF58 File Offset: 0x002F9158
		// (set) Token: 0x06020107 RID: 131335 RVA: 0x002FAF6C File Offset: 0x002F916C
		public unsafe string SecondText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_SecondText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_SecondText)), value);
			}
		}

		// Token: 0x06020108 RID: 131336 RVA: 0x002FAF81 File Offset: 0x002F9181
		public FUIDropdownOptionData()
		{
		}

		// Token: 0x06020109 RID: 131337 RVA: 0x002FAF89 File Offset: 0x002F9189
		public FUIDropdownOptionData(string TextOrConfigTableName, ULGUISpriteData_BaseObject Sprite, int TextId, string SecondText)
		{
			this.TextOrConfigTableName = TextOrConfigTableName;
			this.Sprite = Sprite;
			this.TextId = TextId;
			this.SecondText = SecondText;
		}

		// Token: 0x0602010A RID: 131338 RVA: 0x002FAFAE File Offset: 0x002F91AE
		protected override IntPtr GetUStructPtr()
		{
			return FUIDropdownOptionData.StaticStruct();
		}

		// Token: 0x0602010B RID: 131339 RVA: 0x002FAFBA File Offset: 0x002F91BA
		[NullableContext(2)]
		public FUIDropdownOptionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602010C RID: 131340 RVA: 0x002FAFC4 File Offset: 0x002F91C4
		public FUIDropdownOptionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602010D RID: 131341 RVA: 0x002FAFCF File Offset: 0x002F91CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIDropdownOptionData(Pointer, false, true);
		}

		// Token: 0x0602010E RID: 131342 RVA: 0x002FAFD9 File Offset: 0x002F91D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIDropdownOptionData(Pointer, MemoryOwner);
		}

		// Token: 0x04011427 RID: 70695
		public const string __ObjectPath = "/Script/LGUI.UIDropdownOptionData";

		// Token: 0x04011428 RID: 70696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011429 RID: 70697
		internal static int __PropertyOffset_TextOrConfigTableName;

		// Token: 0x0401142A RID: 70698
		internal static int __PropertyOffset_Sprite;

		// Token: 0x0401142B RID: 70699
		internal static int __PropertyOffset_TextId;

		// Token: 0x0401142C RID: 70700
		internal static int __PropertyOffset_SecondText;
	}
}
