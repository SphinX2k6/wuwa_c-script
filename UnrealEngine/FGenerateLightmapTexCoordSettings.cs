using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B1 RID: 10161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.GenerateLightmapTexCoordSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGenerateLightmapTexCoordSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025DE7 RID: 155111 RVA: 0x003969E0 File Offset: 0x00394BE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGenerateLightmapTexCoordSettings._ScriptStructPtr != 0) ? FGenerateLightmapTexCoordSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.GenerateLightmapTexCoordSettings", ref FGenerateLightmapTexCoordSettings._ScriptStructPtr);
		}

		// Token: 0x170091F0 RID: 37360
		// (get) Token: 0x06025DE8 RID: 155112 RVA: 0x00396A04 File Offset: 0x00394C04
		// (set) Token: 0x06025DE9 RID: 155113 RVA: 0x00396A1D File Offset: 0x00394C1D
		public unsafe bool GenerateLightmapTexCoord
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_GenerateLightmapTexCoord) & FGenerateLightmapTexCoordSettings.__PropertyMask_GenerateLightmapTexCoord) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_GenerateLightmapTexCoord) = ((*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_GenerateLightmapTexCoord) & ~FGenerateLightmapTexCoordSettings.__PropertyMask_GenerateLightmapTexCoord) | (value ? FGenerateLightmapTexCoordSettings.__PropertyMask_GenerateLightmapTexCoord : 0));
			}
		}

		// Token: 0x170091F1 RID: 37361
		// (get) Token: 0x06025DEA RID: 155114 RVA: 0x00396A4D File Offset: 0x00394C4D
		// (set) Token: 0x06025DEB RID: 155115 RVA: 0x00396A5D File Offset: 0x00394C5D
		public unsafe int LightmapTexCoordLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_LightmapTexCoordLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_LightmapTexCoordLevel) = value;
			}
		}

		// Token: 0x170091F2 RID: 37362
		// (get) Token: 0x06025DEC RID: 155116 RVA: 0x00396A6E File Offset: 0x00394C6E
		// (set) Token: 0x06025DED RID: 155117 RVA: 0x00396A82 File Offset: 0x00394C82
		public unsafe string LightmapTexCoordName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_LightmapTexCoordName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_LightmapTexCoordName)), value);
			}
		}

		// Token: 0x170091F3 RID: 37363
		// (get) Token: 0x06025DEE RID: 155118 RVA: 0x00396A97 File Offset: 0x00394C97
		// (set) Token: 0x06025DEF RID: 155119 RVA: 0x00396AA7 File Offset: 0x00394CA7
		public unsafe EChartAggregatorMode ChartAggregatorMode
		{
			get
			{
				return (EChartAggregatorMode)(*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_ChartAggregatorMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_ChartAggregatorMode) = (byte)value;
			}
		}

		// Token: 0x170091F4 RID: 37364
		// (get) Token: 0x06025DF0 RID: 155120 RVA: 0x00396AB8 File Offset: 0x00394CB8
		// (set) Token: 0x06025DF1 RID: 155121 RVA: 0x00396AC8 File Offset: 0x00394CC8
		public unsafe int TextureWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_TextureWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_TextureWidth) = value;
			}
		}

		// Token: 0x170091F5 RID: 37365
		// (get) Token: 0x06025DF2 RID: 155122 RVA: 0x00396AD9 File Offset: 0x00394CD9
		// (set) Token: 0x06025DF3 RID: 155123 RVA: 0x00396AE9 File Offset: 0x00394CE9
		public unsafe int TextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_TextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_TextureHeight) = value;
			}
		}

		// Token: 0x170091F6 RID: 37366
		// (get) Token: 0x06025DF4 RID: 155124 RVA: 0x00396AFA File Offset: 0x00394CFA
		// (set) Token: 0x06025DF5 RID: 155125 RVA: 0x00396B0A File Offset: 0x00394D0A
		public unsafe int GutterSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_GutterSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_GutterSpace) = value;
			}
		}

		// Token: 0x170091F7 RID: 37367
		// (get) Token: 0x06025DF6 RID: 155126 RVA: 0x00396B1B File Offset: 0x00394D1B
		// (set) Token: 0x06025DF7 RID: 155127 RVA: 0x00396B2B File Offset: 0x00394D2B
		public unsafe int SourceTexCoordLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_SourceTexCoordLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenerateLightmapTexCoordSettings.__PropertyOffset_SourceTexCoordLevel) = value;
			}
		}

		// Token: 0x06025DF8 RID: 155128 RVA: 0x00396B3C File Offset: 0x00394D3C
		public FGenerateLightmapTexCoordSettings()
		{
		}

		// Token: 0x06025DF9 RID: 155129 RVA: 0x00396B44 File Offset: 0x00394D44
		public FGenerateLightmapTexCoordSettings(bool GenerateLightmapTexCoord, int LightmapTexCoordLevel, string LightmapTexCoordName, EChartAggregatorMode ChartAggregatorMode, int TextureWidth, int TextureHeight, int GutterSpace, int SourceTexCoordLevel)
		{
			this.GenerateLightmapTexCoord = GenerateLightmapTexCoord;
			this.LightmapTexCoordLevel = LightmapTexCoordLevel;
			this.LightmapTexCoordName = LightmapTexCoordName;
			this.ChartAggregatorMode = ChartAggregatorMode;
			this.TextureWidth = TextureWidth;
			this.TextureHeight = TextureHeight;
			this.GutterSpace = GutterSpace;
			this.SourceTexCoordLevel = SourceTexCoordLevel;
		}

		// Token: 0x06025DFA RID: 155130 RVA: 0x00396B94 File Offset: 0x00394D94
		protected override IntPtr GetUStructPtr()
		{
			return FGenerateLightmapTexCoordSettings.StaticStruct();
		}

		// Token: 0x06025DFB RID: 155131 RVA: 0x00396BA0 File Offset: 0x00394DA0
		[NullableContext(2)]
		public FGenerateLightmapTexCoordSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025DFC RID: 155132 RVA: 0x00396BAA File Offset: 0x00394DAA
		public FGenerateLightmapTexCoordSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025DFD RID: 155133 RVA: 0x00396BB5 File Offset: 0x00394DB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGenerateLightmapTexCoordSettings(Pointer, false, true);
		}

		// Token: 0x06025DFE RID: 155134 RVA: 0x00396BBF File Offset: 0x00394DBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGenerateLightmapTexCoordSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AB4 RID: 84660
		public const string __ObjectPath = "/Script/SimplygonUObjects.GenerateLightmapTexCoordSettings";

		// Token: 0x04014AB5 RID: 84661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AB6 RID: 84662
		internal static int __PropertyOffset_GenerateLightmapTexCoord;

		// Token: 0x04014AB7 RID: 84663
		internal static byte __PropertyMask_GenerateLightmapTexCoord;

		// Token: 0x04014AB8 RID: 84664
		internal static int __PropertyOffset_LightmapTexCoordLevel;

		// Token: 0x04014AB9 RID: 84665
		internal static int __PropertyOffset_LightmapTexCoordName;

		// Token: 0x04014ABA RID: 84666
		internal static int __PropertyOffset_ChartAggregatorMode;

		// Token: 0x04014ABB RID: 84667
		internal static int __PropertyOffset_TextureWidth;

		// Token: 0x04014ABC RID: 84668
		internal static int __PropertyOffset_TextureHeight;

		// Token: 0x04014ABD RID: 84669
		internal static int __PropertyOffset_GutterSpace;

		// Token: 0x04014ABE RID: 84670
		internal static int __PropertyOffset_SourceTexCoordLevel;
	}
}
