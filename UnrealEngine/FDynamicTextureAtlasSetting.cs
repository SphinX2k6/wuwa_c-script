using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001804 RID: 6148
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicAtlas.DynamicTextureAtlasSetting")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FDynamicTextureAtlasSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C17 RID: 93207 RVA: 0x0021360B File Offset: 0x0021180B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDynamicTextureAtlasSetting._ScriptStructPtr != 0) ? FDynamicTextureAtlasSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicAtlas.DynamicTextureAtlasSetting", ref FDynamicTextureAtlasSetting._ScriptStructPtr);
		}

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x06016C18 RID: 93208 RVA: 0x0021362F File Offset: 0x0021182F
		// (set) Token: 0x06016C19 RID: 93209 RVA: 0x00213643 File Offset: 0x00211843
		public unsafe string AtlasTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_AtlasTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_AtlasTag)), value);
			}
		}

		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x06016C1A RID: 93210 RVA: 0x00213658 File Offset: 0x00211858
		// (set) Token: 0x06016C1B RID: 93211 RVA: 0x00213668 File Offset: 0x00211868
		public unsafe int DefaultWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_DefaultWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_DefaultWidth) = value;
			}
		}

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x06016C1C RID: 93212 RVA: 0x00213679 File Offset: 0x00211879
		// (set) Token: 0x06016C1D RID: 93213 RVA: 0x00213689 File Offset: 0x00211889
		public unsafe int DefaultHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_DefaultHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_DefaultHeight) = value;
			}
		}

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x06016C1E RID: 93214 RVA: 0x0021369A File Offset: 0x0021189A
		// (set) Token: 0x06016C1F RID: 93215 RVA: 0x002136AA File Offset: 0x002118AA
		public unsafe int MaxAtlasTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_MaxAtlasTextures);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_MaxAtlasTextures) = value;
			}
		}

		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x06016C20 RID: 93216 RVA: 0x002136BB File Offset: 0x002118BB
		// (set) Token: 0x06016C21 RID: 93217 RVA: 0x002136CB File Offset: 0x002118CB
		public unsafe int MaxUpdateSlotCountInOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_MaxUpdateSlotCountInOneFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_MaxUpdateSlotCountInOneFrame) = value;
			}
		}

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x06016C22 RID: 93218 RVA: 0x002136DC File Offset: 0x002118DC
		// (set) Token: 0x06016C23 RID: 93219 RVA: 0x002136EC File Offset: 0x002118EC
		public unsafe bool InitWithTransparent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_InitWithTransparent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_InitWithTransparent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x06016C24 RID: 93220 RVA: 0x002136FD File Offset: 0x002118FD
		// (set) Token: 0x06016C25 RID: 93221 RVA: 0x0021370D File Offset: 0x0021190D
		public unsafe ExpandMode ExpandMode
		{
			get
			{
				return (ExpandMode)(*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_ExpandMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureAtlasSetting.__PropertyOffset_ExpandMode) = (byte)value;
			}
		}

		// Token: 0x06016C26 RID: 93222 RVA: 0x0021371E File Offset: 0x0021191E
		public FDynamicTextureAtlasSetting()
		{
		}

		// Token: 0x06016C27 RID: 93223 RVA: 0x00213726 File Offset: 0x00211926
		public FDynamicTextureAtlasSetting(string AtlasTag, int DefaultWidth, int DefaultHeight, int MaxAtlasTextures, int MaxUpdateSlotCountInOneFrame, bool InitWithTransparent, ExpandMode ExpandMode)
		{
			this.AtlasTag = AtlasTag;
			this.DefaultWidth = DefaultWidth;
			this.DefaultHeight = DefaultHeight;
			this.MaxAtlasTextures = MaxAtlasTextures;
			this.MaxUpdateSlotCountInOneFrame = MaxUpdateSlotCountInOneFrame;
			this.InitWithTransparent = InitWithTransparent;
			this.ExpandMode = ExpandMode;
		}

		// Token: 0x06016C28 RID: 93224 RVA: 0x00213763 File Offset: 0x00211963
		protected override IntPtr GetUStructPtr()
		{
			return FDynamicTextureAtlasSetting.StaticStruct();
		}

		// Token: 0x06016C29 RID: 93225 RVA: 0x0021376F File Offset: 0x0021196F
		[NullableContext(2)]
		public FDynamicTextureAtlasSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C2A RID: 93226 RVA: 0x00213779 File Offset: 0x00211979
		public FDynamicTextureAtlasSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C2B RID: 93227 RVA: 0x00213784 File Offset: 0x00211984
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDynamicTextureAtlasSetting(Pointer, false, true);
		}

		// Token: 0x06016C2C RID: 93228 RVA: 0x0021378E File Offset: 0x0021198E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDynamicTextureAtlasSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400C596 RID: 50582
		public const string __ObjectPath = "/Script/KuroDynamicAtlas.DynamicTextureAtlasSetting";

		// Token: 0x0400C597 RID: 50583
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C598 RID: 50584
		internal static int __PropertyOffset_AtlasTag;

		// Token: 0x0400C599 RID: 50585
		internal static int __PropertyOffset_DefaultWidth;

		// Token: 0x0400C59A RID: 50586
		internal static int __PropertyOffset_DefaultHeight;

		// Token: 0x0400C59B RID: 50587
		internal static int __PropertyOffset_MaxAtlasTextures;

		// Token: 0x0400C59C RID: 50588
		internal static int __PropertyOffset_MaxUpdateSlotCountInOneFrame;

		// Token: 0x0400C59D RID: 50589
		internal static int __PropertyOffset_InitWithTransparent;

		// Token: 0x0400C59E RID: 50590
		internal static int __PropertyOffset_ExpandMode;
	}
}
