using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002019 RID: 8217
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LangTextureInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLangTextureInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF70 RID: 126832 RVA: 0x002E0C9C File Offset: 0x002DEE9C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLangTextureInfo._ScriptStructPtr != 0) ? FLangTextureInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LangTextureInfo", ref FLangTextureInfo._ScriptStructPtr);
		}

		// Token: 0x17007B44 RID: 31556
		// (get) Token: 0x0601EF71 RID: 126833 RVA: 0x002E0CC0 File Offset: 0x002DEEC0
		// (set) Token: 0x0601EF72 RID: 126834 RVA: 0x002E0CD0 File Offset: 0x002DEED0
		public unsafe EUILanguageType Language
		{
			get
			{
				return (EUILanguageType)(*(base.NativePtr + (IntPtr)FLangTextureInfo.__PropertyOffset_Language));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLangTextureInfo.__PropertyOffset_Language) = (byte)value;
			}
		}

		// Token: 0x17007B45 RID: 31557
		// (get) Token: 0x0601EF73 RID: 126835 RVA: 0x002E0CE1 File Offset: 0x002DEEE1
		// (set) Token: 0x0601EF74 RID: 126836 RVA: 0x002E0D00 File Offset: 0x002DEF00
		public TSoftObjectPtr<UTexture2D> Texture
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)FLangTextureInfo.__PropertyOffset_Texture, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FLangTextureInfo.__PropertyOffset_Texture, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601EF75 RID: 126837 RVA: 0x002E0D25 File Offset: 0x002DEF25
		public FLangTextureInfo()
		{
		}

		// Token: 0x0601EF76 RID: 126838 RVA: 0x002E0D2D File Offset: 0x002DEF2D
		public FLangTextureInfo(EUILanguageType Language, TSoftObjectPtr<UTexture2D> Texture)
		{
			this.Language = Language;
			this.Texture = Texture;
		}

		// Token: 0x0601EF77 RID: 126839 RVA: 0x002E0D43 File Offset: 0x002DEF43
		protected override IntPtr GetUStructPtr()
		{
			return FLangTextureInfo.StaticStruct();
		}

		// Token: 0x0601EF78 RID: 126840 RVA: 0x002E0D4F File Offset: 0x002DEF4F
		[NullableContext(2)]
		public FLangTextureInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF79 RID: 126841 RVA: 0x002E0D59 File Offset: 0x002DEF59
		public FLangTextureInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF7A RID: 126842 RVA: 0x002E0D64 File Offset: 0x002DEF64
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLangTextureInfo(Pointer, false, true);
		}

		// Token: 0x0601EF7B RID: 126843 RVA: 0x002E0D6E File Offset: 0x002DEF6E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLangTextureInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010D59 RID: 68953
		public const string __ObjectPath = "/Script/LGUI.LangTextureInfo";

		// Token: 0x04010D5A RID: 68954
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D5B RID: 68955
		internal static int __PropertyOffset_Language;

		// Token: 0x04010D5C RID: 68956
		internal static int __PropertyOffset_Texture;
	}
}
