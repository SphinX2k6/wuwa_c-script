using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200201F RID: 8223
	[UnrealObjectPath("/Script/LGUI.LGUIAtlasSettings")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLGUIAtlasSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFAE RID: 126894 RVA: 0x002E121E File Offset: 0x002DF41E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIAtlasSettings._ScriptStructPtr != 0) ? FLGUIAtlasSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIAtlasSettings", ref FLGUIAtlasSettings._ScriptStructPtr);
		}

		// Token: 0x17007B4E RID: 31566
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x002E1242 File Offset: 0x002DF442
		// (set) Token: 0x0601EFB0 RID: 126896 RVA: 0x002E1252 File Offset: 0x002DF452
		public unsafe ELGUIAtlasTextureSizeType atlasTextureInitialSize
		{
			get
			{
				return (ELGUIAtlasTextureSizeType)(*(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureInitialSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureInitialSize) = (byte)value;
			}
		}

		// Token: 0x17007B4F RID: 31567
		// (get) Token: 0x0601EFB1 RID: 126897 RVA: 0x002E1263 File Offset: 0x002DF463
		// (set) Token: 0x0601EFB2 RID: 126898 RVA: 0x002E1273 File Offset: 0x002DF473
		public unsafe bool atlasTextureUseSRGB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureUseSRGB) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureUseSRGB) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B50 RID: 31568
		// (get) Token: 0x0601EFB3 RID: 126899 RVA: 0x002E1284 File Offset: 0x002DF484
		// (set) Token: 0x0601EFB4 RID: 126900 RVA: 0x002E1298 File Offset: 0x002DF498
		public unsafe TEnumAsByte<TextureFilter> atlasTextureFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_atlasTextureFilter) = value;
			}
		}

		// Token: 0x17007B51 RID: 31569
		// (get) Token: 0x0601EFB5 RID: 126901 RVA: 0x002E12AD File Offset: 0x002DF4AD
		// (set) Token: 0x0601EFB6 RID: 126902 RVA: 0x002E12BD File Offset: 0x002DF4BD
		public unsafe int spaceBetweenSprites
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_spaceBetweenSprites);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIAtlasSettings.__PropertyOffset_spaceBetweenSprites) = value;
			}
		}

		// Token: 0x0601EFB7 RID: 126903 RVA: 0x002E12CE File Offset: 0x002DF4CE
		public FLGUIAtlasSettings()
		{
		}

		// Token: 0x0601EFB8 RID: 126904 RVA: 0x002E12D6 File Offset: 0x002DF4D6
		public FLGUIAtlasSettings(ELGUIAtlasTextureSizeType atlasTextureInitialSize, bool atlasTextureUseSRGB, TEnumAsByte<TextureFilter> atlasTextureFilter, int spaceBetweenSprites)
		{
			this.atlasTextureInitialSize = atlasTextureInitialSize;
			this.atlasTextureUseSRGB = atlasTextureUseSRGB;
			this.atlasTextureFilter = atlasTextureFilter;
			this.spaceBetweenSprites = spaceBetweenSprites;
		}

		// Token: 0x0601EFB9 RID: 126905 RVA: 0x002E12FB File Offset: 0x002DF4FB
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIAtlasSettings.StaticStruct();
		}

		// Token: 0x0601EFBA RID: 126906 RVA: 0x002E1307 File Offset: 0x002DF507
		[NullableContext(2)]
		public FLGUIAtlasSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFBB RID: 126907 RVA: 0x002E1311 File Offset: 0x002DF511
		public FLGUIAtlasSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFBC RID: 126908 RVA: 0x002E131C File Offset: 0x002DF51C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIAtlasSettings(Pointer, false, true);
		}

		// Token: 0x0601EFBD RID: 126909 RVA: 0x002E1326 File Offset: 0x002DF526
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIAtlasSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010D78 RID: 68984
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIAtlasSettings";

		// Token: 0x04010D79 RID: 68985
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D7A RID: 68986
		internal static int __PropertyOffset_atlasTextureInitialSize;

		// Token: 0x04010D7B RID: 68987
		internal static int __PropertyOffset_atlasTextureUseSRGB;

		// Token: 0x04010D7C RID: 68988
		internal static int __PropertyOffset_atlasTextureFilter;

		// Token: 0x04010D7D RID: 68989
		internal static int __PropertyOffset_spaceBetweenSprites;
	}
}
