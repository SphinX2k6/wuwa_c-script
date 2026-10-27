using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5A RID: 7002
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSampleConst")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroMaterialControllerParam_TextureSampleConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A82B RID: 108587 RVA: 0x00271628 File Offset: 0x0026F828
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_TextureSampleConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_TextureSampleConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSampleConst", ref FKuroMaterialControllerParam_TextureSampleConst._ScriptStructPtr);
		}

		// Token: 0x17006A91 RID: 27281
		// (get) Token: 0x0601A82C RID: 108588 RVA: 0x0027164C File Offset: 0x0026F84C
		// (set) Token: 0x0601A82D RID: 108589 RVA: 0x00271660 File Offset: 0x0026F860
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_MaskTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_MaskTexture, value);
			}
		}

		// Token: 0x17006A92 RID: 27282
		// (get) Token: 0x0601A82E RID: 108590 RVA: 0x00271675 File Offset: 0x0026F875
		// (set) Token: 0x0601A82F RID: 108591 RVA: 0x00271689 File Offset: 0x0026F889
		public unsafe FLinearColor TextureScaleAndOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureScaleAndOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureScaleAndOffset) = value;
			}
		}

		// Token: 0x17006A93 RID: 27283
		// (get) Token: 0x0601A830 RID: 108592 RVA: 0x0027169E File Offset: 0x0026F89E
		// (set) Token: 0x0601A831 RID: 108593 RVA: 0x002716B2 File Offset: 0x0026F8B2
		public unsafe FLinearColor TextureSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureSpeed) = value;
			}
		}

		// Token: 0x17006A94 RID: 27284
		// (get) Token: 0x0601A832 RID: 108594 RVA: 0x002716C7 File Offset: 0x0026F8C7
		// (set) Token: 0x0601A833 RID: 108595 RVA: 0x002716DB File Offset: 0x0026F8DB
		public unsafe FLinearColor TextureColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureColorTint) = value;
			}
		}

		// Token: 0x17006A95 RID: 27285
		// (get) Token: 0x0601A834 RID: 108596 RVA: 0x002716F0 File Offset: 0x0026F8F0
		// (set) Token: 0x0601A835 RID: 108597 RVA: 0x00271700 File Offset: 0x0026F900
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17006A96 RID: 27286
		// (get) Token: 0x0601A836 RID: 108598 RVA: 0x00271711 File Offset: 0x0026F911
		// (set) Token: 0x0601A837 RID: 108599 RVA: 0x00271721 File Offset: 0x0026F921
		public unsafe bool bUseAlphaToMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_bUseAlphaToMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_bUseAlphaToMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A97 RID: 27287
		// (get) Token: 0x0601A838 RID: 108600 RVA: 0x00271732 File Offset: 0x0026F932
		// (set) Token: 0x0601A839 RID: 108601 RVA: 0x00271742 File Offset: 0x0026F942
		public unsafe float TextureMaskRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureMaskRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_TextureMaskRange) = value;
			}
		}

		// Token: 0x17006A98 RID: 27288
		// (get) Token: 0x0601A83A RID: 108602 RVA: 0x00271753 File Offset: 0x0026F953
		// (set) Token: 0x0601A83B RID: 108603 RVA: 0x00271763 File Offset: 0x0026F963
		public unsafe ECharacterControllerUVSwitch UvSelection
		{
			get
			{
				return (ECharacterControllerUVSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_UvSelection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSampleConst.__PropertyOffset_UvSelection) = (byte)value;
			}
		}

		// Token: 0x0601A83C RID: 108604 RVA: 0x00271774 File Offset: 0x0026F974
		public FKuroMaterialControllerParam_TextureSampleConst()
		{
		}

		// Token: 0x0601A83D RID: 108605 RVA: 0x0027177C File Offset: 0x0026F97C
		[NullableContext(1)]
		public FKuroMaterialControllerParam_TextureSampleConst(UTexture2D MaskTexture, FLinearColor TextureScaleAndOffset, FLinearColor TextureSpeed, FLinearColor TextureColorTint, float Rotation, bool bUseAlphaToMask, float TextureMaskRange, ECharacterControllerUVSwitch UvSelection)
		{
			this.MaskTexture = MaskTexture;
			this.TextureScaleAndOffset = TextureScaleAndOffset;
			this.TextureSpeed = TextureSpeed;
			this.TextureColorTint = TextureColorTint;
			this.Rotation = Rotation;
			this.bUseAlphaToMask = bUseAlphaToMask;
			this.TextureMaskRange = TextureMaskRange;
			this.UvSelection = UvSelection;
		}

		// Token: 0x0601A83E RID: 108606 RVA: 0x002717CC File Offset: 0x0026F9CC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_TextureSampleConst.StaticStruct();
		}

		// Token: 0x0601A83F RID: 108607 RVA: 0x002717D8 File Offset: 0x0026F9D8
		[NullableContext(2)]
		public FKuroMaterialControllerParam_TextureSampleConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A840 RID: 108608 RVA: 0x002717E2 File Offset: 0x0026F9E2
		public FKuroMaterialControllerParam_TextureSampleConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A841 RID: 108609 RVA: 0x002717ED File Offset: 0x0026F9ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_TextureSampleConst(Pointer, false, true);
		}

		// Token: 0x0601A842 RID: 108610 RVA: 0x002717F7 File Offset: 0x0026F9F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_TextureSampleConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5C0 RID: 58816
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSampleConst";

		// Token: 0x0400E5C1 RID: 58817
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5C2 RID: 58818
		internal static int __PropertyOffset_MaskTexture;

		// Token: 0x0400E5C3 RID: 58819
		internal static int __PropertyOffset_TextureScaleAndOffset;

		// Token: 0x0400E5C4 RID: 58820
		internal static int __PropertyOffset_TextureSpeed;

		// Token: 0x0400E5C5 RID: 58821
		internal static int __PropertyOffset_TextureColorTint;

		// Token: 0x0400E5C6 RID: 58822
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400E5C7 RID: 58823
		internal static int __PropertyOffset_bUseAlphaToMask;

		// Token: 0x0400E5C8 RID: 58824
		internal static int __PropertyOffset_TextureMaskRange;

		// Token: 0x0400E5C9 RID: 58825
		internal static int __PropertyOffset_UvSelection;
	}
}
