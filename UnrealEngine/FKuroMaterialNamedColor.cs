using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B66 RID: 7014
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroMaterialNamedColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8D2 RID: 108754 RVA: 0x002726EE File Offset: 0x002708EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedColor._ScriptStructPtr != 0) ? FKuroMaterialNamedColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor", ref FKuroMaterialNamedColor._ScriptStructPtr);
		}

		// Token: 0x17006AB5 RID: 27317
		// (get) Token: 0x0601A8D3 RID: 108755 RVA: 0x00272712 File Offset: 0x00270912
		// (set) Token: 0x0601A8D4 RID: 108756 RVA: 0x00272726 File Offset: 0x00270926
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedColor.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedColor.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006AB6 RID: 27318
		// (get) Token: 0x0601A8D5 RID: 108757 RVA: 0x0027273B File Offset: 0x0027093B
		// (set) Token: 0x0601A8D6 RID: 108758 RVA: 0x0027274F File Offset: 0x0027094F
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedColor.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedColor.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601A8D7 RID: 108759 RVA: 0x00272764 File Offset: 0x00270964
		public FKuroMaterialNamedColor()
		{
		}

		// Token: 0x0601A8D8 RID: 108760 RVA: 0x0027276C File Offset: 0x0027096C
		public FKuroMaterialNamedColor(FName Name, FLinearColor Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601A8D9 RID: 108761 RVA: 0x00272782 File Offset: 0x00270982
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedColor.StaticStruct();
		}

		// Token: 0x0601A8DA RID: 108762 RVA: 0x0027278E File Offset: 0x0027098E
		[NullableContext(2)]
		public FKuroMaterialNamedColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8DB RID: 108763 RVA: 0x00272798 File Offset: 0x00270998
		public FKuroMaterialNamedColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8DC RID: 108764 RVA: 0x002727A3 File Offset: 0x002709A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedColor(Pointer, false, true);
		}

		// Token: 0x0601A8DD RID: 108765 RVA: 0x002727AD File Offset: 0x002709AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400E610 RID: 58896
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor";

		// Token: 0x0400E611 RID: 58897
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E612 RID: 58898
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E613 RID: 58899
		internal static int __PropertyOffset_Value;
	}
}
