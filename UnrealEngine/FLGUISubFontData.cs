using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020CB RID: 8395
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISubFontData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUISubFontData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FA1E RID: 129566 RVA: 0x002F0860 File Offset: 0x002EEA60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUISubFontData._ScriptStructPtr != 0) ? FLGUISubFontData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUISubFontData", ref FLGUISubFontData._ScriptStructPtr);
		}

		// Token: 0x17007CC0 RID: 31936
		// (get) Token: 0x0601FA1F RID: 129567 RVA: 0x002F0884 File Offset: 0x002EEA84
		// (set) Token: 0x0601FA20 RID: 129568 RVA: 0x002F0898 File Offset: 0x002EEA98
		[Nullable(2)]
		public unsafe UFontFace unrealFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFontFace>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUISubFontData.__PropertyOffset_unrealFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUISubFontData.__PropertyOffset_unrealFont, value);
			}
		}

		// Token: 0x17007CC1 RID: 31937
		// (get) Token: 0x0601FA21 RID: 129569 RVA: 0x002F08B0 File Offset: 0x002EEAB0
		// (set) Token: 0x0601FA22 RID: 129570 RVA: 0x002F08F3 File Offset: 0x002EEAF3
		public TArray<FInt32Range> CharacterRanges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInt32Range> result;
				if ((result = this._CharacterRanges) == null)
				{
					result = (this._CharacterRanges = new TArray<FInt32Range>(base.NativePtr + (IntPtr)FLGUISubFontData.__PropertyOffset_CharacterRanges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CharacterRanges.CopyAssign(value);
			}
		}

		// Token: 0x17007CC2 RID: 31938
		// (get) Token: 0x0601FA23 RID: 129571 RVA: 0x002F0901 File Offset: 0x002EEB01
		// (set) Token: 0x0601FA24 RID: 129572 RVA: 0x002F0911 File Offset: 0x002EEB11
		public unsafe Culture Cultures
		{
			get
			{
				return (Culture)(*(base.NativePtr + (IntPtr)FLGUISubFontData.__PropertyOffset_Cultures));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISubFontData.__PropertyOffset_Cultures) = (byte)value;
			}
		}

		// Token: 0x17007CC3 RID: 31939
		// (get) Token: 0x0601FA25 RID: 129573 RVA: 0x002F0922 File Offset: 0x002EEB22
		// (set) Token: 0x0601FA26 RID: 129574 RVA: 0x002F0932 File Offset: 0x002EEB32
		public unsafe float VerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISubFontData.__PropertyOffset_VerticalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISubFontData.__PropertyOffset_VerticalOffset) = value;
			}
		}

		// Token: 0x0601FA27 RID: 129575 RVA: 0x002F0943 File Offset: 0x002EEB43
		public FLGUISubFontData()
		{
		}

		// Token: 0x0601FA28 RID: 129576 RVA: 0x002F094B File Offset: 0x002EEB4B
		public FLGUISubFontData(UFontFace unrealFont, TArray<FInt32Range> CharacterRanges, Culture Cultures, float VerticalOffset)
		{
			this.unrealFont = unrealFont;
			this.CharacterRanges = CharacterRanges;
			this.Cultures = Cultures;
			this.VerticalOffset = VerticalOffset;
		}

		// Token: 0x0601FA29 RID: 129577 RVA: 0x002F0970 File Offset: 0x002EEB70
		protected override IntPtr GetUStructPtr()
		{
			return FLGUISubFontData.StaticStruct();
		}

		// Token: 0x0601FA2A RID: 129578 RVA: 0x002F097C File Offset: 0x002EEB7C
		[NullableContext(2)]
		public FLGUISubFontData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA2B RID: 129579 RVA: 0x002F0986 File Offset: 0x002EEB86
		public FLGUISubFontData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA2C RID: 129580 RVA: 0x002F0991 File Offset: 0x002EEB91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUISubFontData(Pointer, false, true);
		}

		// Token: 0x0601FA2D RID: 129581 RVA: 0x002F099B File Offset: 0x002EEB9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUISubFontData(Pointer, MemoryOwner);
		}

		// Token: 0x04011122 RID: 69922
		public const string __ObjectPath = "/Script/LGUI.LGUISubFontData";

		// Token: 0x04011123 RID: 69923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011124 RID: 69924
		internal static int __PropertyOffset_unrealFont;

		// Token: 0x04011125 RID: 69925
		internal static int __PropertyOffset_CharacterRanges;

		// Token: 0x04011126 RID: 69926
		[Nullable(2)]
		private TArray<FInt32Range> _CharacterRanges;

		// Token: 0x04011127 RID: 69927
		internal static int __PropertyOffset_Cultures;

		// Token: 0x04011128 RID: 69928
		internal static int __PropertyOffset_VerticalOffset;
	}
}
