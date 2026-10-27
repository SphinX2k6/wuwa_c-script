using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200283A RID: 10298
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.TypefaceEntry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FTypefaceEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026457 RID: 156759 RVA: 0x003A1E1C File Offset: 0x003A001C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTypefaceEntry._ScriptStructPtr != 0) ? FTypefaceEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.TypefaceEntry", ref FTypefaceEntry._ScriptStructPtr);
		}

		// Token: 0x170093C4 RID: 37828
		// (get) Token: 0x06026458 RID: 156760 RVA: 0x003A1E40 File Offset: 0x003A0040
		// (set) Token: 0x06026459 RID: 156761 RVA: 0x003A1E54 File Offset: 0x003A0054
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTypefaceEntry.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTypefaceEntry.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170093C5 RID: 37829
		// (get) Token: 0x0602645A RID: 156762 RVA: 0x003A1E6C File Offset: 0x003A006C
		// (set) Token: 0x0602645B RID: 156763 RVA: 0x003A1EAF File Offset: 0x003A00AF
		public FFontData Font
		{
			get
			{
				base.FastCheckIsValid();
				FFontData result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FFontData(base.NativePtr + (IntPtr)FTypefaceEntry.__PropertyOffset_Font, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFontData.StaticStruct(), base.NativePtr + (IntPtr)FTypefaceEntry.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602645C RID: 156764 RVA: 0x003A1ED0 File Offset: 0x003A00D0
		public FTypefaceEntry()
		{
		}

		// Token: 0x0602645D RID: 156765 RVA: 0x003A1ED8 File Offset: 0x003A00D8
		public FTypefaceEntry(FName Name, FFontData Font)
		{
			this.Name = Name;
			this.Font = Font;
		}

		// Token: 0x0602645E RID: 156766 RVA: 0x003A1EEE File Offset: 0x003A00EE
		protected override IntPtr GetUStructPtr()
		{
			return FTypefaceEntry.StaticStruct();
		}

		// Token: 0x0602645F RID: 156767 RVA: 0x003A1EFA File Offset: 0x003A00FA
		[NullableContext(2)]
		public FTypefaceEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026460 RID: 156768 RVA: 0x003A1F04 File Offset: 0x003A0104
		public FTypefaceEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026461 RID: 156769 RVA: 0x003A1F0F File Offset: 0x003A010F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTypefaceEntry(Pointer, false, true);
		}

		// Token: 0x06026462 RID: 156770 RVA: 0x003A1F19 File Offset: 0x003A0119
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTypefaceEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04014F3E RID: 85822
		public const string __ObjectPath = "/Script/SlateCore.TypefaceEntry";

		// Token: 0x04014F3F RID: 85823
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F40 RID: 85824
		internal static int __PropertyOffset_Name;

		// Token: 0x04014F41 RID: 85825
		internal static int __PropertyOffset_Font;

		// Token: 0x04014F42 RID: 85826
		[Nullable(2)]
		private FFontData _Font;
	}
}
