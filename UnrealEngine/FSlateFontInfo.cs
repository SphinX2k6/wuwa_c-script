using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200282C RID: 10284
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SlateCore.SlateFontInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FSlateFontInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026381 RID: 156545 RVA: 0x003A0289 File Offset: 0x0039E489
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateFontInfo._ScriptStructPtr != 0) ? FSlateFontInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateFontInfo", ref FSlateFontInfo._ScriptStructPtr);
		}

		// Token: 0x17009389 RID: 37769
		// (get) Token: 0x06026382 RID: 156546 RVA: 0x003A02AD File Offset: 0x0039E4AD
		// (set) Token: 0x06026383 RID: 156547 RVA: 0x003A02C1 File Offset: 0x0039E4C1
		public unsafe UObject FontObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontObject, value);
			}
		}

		// Token: 0x1700938A RID: 37770
		// (get) Token: 0x06026384 RID: 156548 RVA: 0x003A02D6 File Offset: 0x0039E4D6
		// (set) Token: 0x06026385 RID: 156549 RVA: 0x003A02EA File Offset: 0x0039E4EA
		public unsafe UObject FontMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontMaterial, value);
			}
		}

		// Token: 0x1700938B RID: 37771
		// (get) Token: 0x06026386 RID: 156550 RVA: 0x003A0300 File Offset: 0x0039E500
		// (set) Token: 0x06026387 RID: 156551 RVA: 0x003A0343 File Offset: 0x0039E543
		[Nullable(1)]
		public FFontOutlineSettings OutlineSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFontOutlineSettings result;
				if ((result = this._OutlineSettings) == null)
				{
					result = (this._OutlineSettings = new FFontOutlineSettings(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_OutlineSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFontOutlineSettings.StaticStruct(), base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_OutlineSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700938C RID: 37772
		// (get) Token: 0x06026388 RID: 156552 RVA: 0x003A0364 File Offset: 0x0039E564
		// (set) Token: 0x06026389 RID: 156553 RVA: 0x003A0378 File Offset: 0x0039E578
		public unsafe FName TypefaceFontName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_TypefaceFontName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_TypefaceFontName) = value;
			}
		}

		// Token: 0x1700938D RID: 37773
		// (get) Token: 0x0602638A RID: 156554 RVA: 0x003A038D File Offset: 0x0039E58D
		// (set) Token: 0x0602638B RID: 156555 RVA: 0x003A039D File Offset: 0x0039E59D
		public unsafe int Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x1700938E RID: 37774
		// (get) Token: 0x0602638C RID: 156556 RVA: 0x003A03AE File Offset: 0x0039E5AE
		// (set) Token: 0x0602638D RID: 156557 RVA: 0x003A03BE File Offset: 0x0039E5BE
		public unsafe int LetterSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_LetterSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_LetterSpacing) = value;
			}
		}

		// Token: 0x0602638E RID: 156558 RVA: 0x003A03CF File Offset: 0x0039E5CF
		public FSlateFontInfo()
		{
		}

		// Token: 0x0602638F RID: 156559 RVA: 0x003A03D7 File Offset: 0x0039E5D7
		[NullableContext(1)]
		public FSlateFontInfo(UObject FontObject, UObject FontMaterial, FFontOutlineSettings OutlineSettings, FName TypefaceFontName, int Size, int LetterSpacing, FName FontName_DEPRECATED, EFontHinting Hinting_DEPRECATED)
		{
			this.FontObject = FontObject;
			this.FontMaterial = FontMaterial;
			this.OutlineSettings = OutlineSettings;
			this.TypefaceFontName = TypefaceFontName;
			this.Size = Size;
			this.LetterSpacing = LetterSpacing;
		}

		// Token: 0x06026390 RID: 156560 RVA: 0x003A040C File Offset: 0x0039E60C
		protected override IntPtr GetUStructPtr()
		{
			return FSlateFontInfo.StaticStruct();
		}

		// Token: 0x06026391 RID: 156561 RVA: 0x003A0418 File Offset: 0x0039E618
		public FSlateFontInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026392 RID: 156562 RVA: 0x003A0422 File Offset: 0x0039E622
		public FSlateFontInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026393 RID: 156563 RVA: 0x003A042D File Offset: 0x0039E62D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateFontInfo(Pointer, false, true);
		}

		// Token: 0x06026394 RID: 156564 RVA: 0x003A0437 File Offset: 0x0039E637
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateFontInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014EB5 RID: 85685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateFontInfo";

		// Token: 0x04014EB6 RID: 85686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EB7 RID: 85687
		internal static int __PropertyOffset_FontObject;

		// Token: 0x04014EB8 RID: 85688
		internal static int __PropertyOffset_FontMaterial;

		// Token: 0x04014EB9 RID: 85689
		internal static int __PropertyOffset_OutlineSettings;

		// Token: 0x04014EBA RID: 85690
		private FFontOutlineSettings _OutlineSettings;

		// Token: 0x04014EBB RID: 85691
		internal static int __PropertyOffset_TypefaceFontName;

		// Token: 0x04014EBC RID: 85692
		internal static int __PropertyOffset_Size;

		// Token: 0x04014EBD RID: 85693
		internal static int __PropertyOffset_LetterSpacing;
	}
}
