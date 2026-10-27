using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F35 RID: 3893
	[UnrealObjectPath("/Script/Engine.OpacityMicromap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FOpacityMicromap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D1E8 RID: 53736 RVA: 0x00133ACA File Offset: 0x00131CCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpacityMicromap._ScriptStructPtr != 0) ? FOpacityMicromap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.OpacityMicromap", ref FOpacityMicromap._ScriptStructPtr);
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600D1E9 RID: 53737 RVA: 0x00133AEE File Offset: 0x00131CEE
		// (set) Token: 0x0600D1EA RID: 53738 RVA: 0x00133AFE File Offset: 0x00131CFE
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600D1EB RID: 53739 RVA: 0x00133B0F File Offset: 0x00131D0F
		// (set) Token: 0x0600D1EC RID: 53740 RVA: 0x00133B1F File Offset: 0x00131D1F
		public unsafe uint SubdivisionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_SubdivisionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_SubdivisionLevel) = (int)value;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600D1ED RID: 53741 RVA: 0x00133B30 File Offset: 0x00131D30
		// (set) Token: 0x0600D1EE RID: 53742 RVA: 0x00133B40 File Offset: 0x00131D40
		public unsafe uint UVChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_UVChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_UVChannelIndex) = (int)value;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600D1EF RID: 53743 RVA: 0x00133B51 File Offset: 0x00131D51
		// (set) Token: 0x0600D1F0 RID: 53744 RVA: 0x00133B61 File Offset: 0x00131D61
		public unsafe uint TextureChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_TextureChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_TextureChannelIndex) = (int)value;
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600D1F1 RID: 53745 RVA: 0x00133B72 File Offset: 0x00131D72
		// (set) Token: 0x0600D1F2 RID: 53746 RVA: 0x00133B82 File Offset: 0x00131D82
		public unsafe float DynamicSubdivisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_DynamicSubdivisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_DynamicSubdivisionScale) = value;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600D1F3 RID: 53747 RVA: 0x00133B93 File Offset: 0x00131D93
		// (set) Token: 0x0600D1F4 RID: 53748 RVA: 0x00133BA3 File Offset: 0x00131DA3
		public unsafe EOpacityMicromapFormat Format
		{
			get
			{
				return (EOpacityMicromapFormat)(*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_Format));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromap.__PropertyOffset_Format) = (short)value;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600D1F5 RID: 53749 RVA: 0x00133BB4 File Offset: 0x00131DB4
		// (set) Token: 0x0600D1F6 RID: 53750 RVA: 0x00133BC8 File Offset: 0x00131DC8
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FOpacityMicromap.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FOpacityMicromap.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x0600D1F7 RID: 53751 RVA: 0x00133BDD File Offset: 0x00131DDD
		public FOpacityMicromap()
		{
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x00133BE5 File Offset: 0x00131DE5
		[NullableContext(1)]
		public FOpacityMicromap(bool bEnabled, uint SubdivisionLevel, uint UVChannelIndex, uint TextureChannelIndex, float DynamicSubdivisionScale, EOpacityMicromapFormat Format, UTexture2D Texture)
		{
			this.bEnabled = bEnabled;
			this.SubdivisionLevel = SubdivisionLevel;
			this.UVChannelIndex = UVChannelIndex;
			this.TextureChannelIndex = TextureChannelIndex;
			this.DynamicSubdivisionScale = DynamicSubdivisionScale;
			this.Format = Format;
			this.Texture = Texture;
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x00133C22 File Offset: 0x00131E22
		protected override IntPtr GetUStructPtr()
		{
			return FOpacityMicromap.StaticStruct();
		}

		// Token: 0x0600D1FA RID: 53754 RVA: 0x00133C2E File Offset: 0x00131E2E
		[NullableContext(2)]
		public FOpacityMicromap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x00133C38 File Offset: 0x00131E38
		public FOpacityMicromap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x00133C43 File Offset: 0x00131E43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpacityMicromap(Pointer, false, true);
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x00133C4D File Offset: 0x00131E4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpacityMicromap(Pointer, MemoryOwner);
		}

		// Token: 0x040070AA RID: 28842
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OpacityMicromap";

		// Token: 0x040070AB RID: 28843
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070AC RID: 28844
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040070AD RID: 28845
		internal static int __PropertyOffset_SubdivisionLevel;

		// Token: 0x040070AE RID: 28846
		internal static int __PropertyOffset_UVChannelIndex;

		// Token: 0x040070AF RID: 28847
		internal static int __PropertyOffset_TextureChannelIndex;

		// Token: 0x040070B0 RID: 28848
		internal static int __PropertyOffset_DynamicSubdivisionScale;

		// Token: 0x040070B1 RID: 28849
		internal static int __PropertyOffset_Format;

		// Token: 0x040070B2 RID: 28850
		internal static int __PropertyOffset_Texture;
	}
}
