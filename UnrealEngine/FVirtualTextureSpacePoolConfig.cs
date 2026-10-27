using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001235 RID: 4661
	[UnrealObjectPath("/Script/Engine.VirtualTextureSpacePoolConfig")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FVirtualTextureSpacePoolConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011229 RID: 70185 RVA: 0x001924B6 File Offset: 0x001906B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualTextureSpacePoolConfig._ScriptStructPtr != 0) ? FVirtualTextureSpacePoolConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VirtualTextureSpacePoolConfig", ref FVirtualTextureSpacePoolConfig._ScriptStructPtr);
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x0601122A RID: 70186 RVA: 0x001924DA File Offset: 0x001906DA
		// (set) Token: 0x0601122B RID: 70187 RVA: 0x001924EA File Offset: 0x001906EA
		public unsafe int MinTileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_MinTileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_MinTileSize) = value;
			}
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x0601122C RID: 70188 RVA: 0x001924FB File Offset: 0x001906FB
		// (set) Token: 0x0601122D RID: 70189 RVA: 0x0019250B File Offset: 0x0019070B
		public unsafe int MaxTileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_MaxTileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_MaxTileSize) = value;
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x0601122E RID: 70190 RVA: 0x0019251C File Offset: 0x0019071C
		// (set) Token: 0x0601122F RID: 70191 RVA: 0x0019255F File Offset: 0x0019075F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EPixelFormat>> Formats
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EPixelFormat>> result;
				if ((result = this._Formats) == null)
				{
					result = (this._Formats = new TArray<TEnumAsByte<EPixelFormat>>(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_Formats, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Formats.CopyAssign(value);
			}
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x06011230 RID: 70192 RVA: 0x0019256D File Offset: 0x0019076D
		// (set) Token: 0x06011231 RID: 70193 RVA: 0x0019257D File Offset: 0x0019077D
		public unsafe int SizeInMegabyte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_SizeInMegabyte);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_SizeInMegabyte) = value;
			}
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x06011232 RID: 70194 RVA: 0x0019258E File Offset: 0x0019078E
		// (set) Token: 0x06011233 RID: 70195 RVA: 0x0019259E File Offset: 0x0019079E
		public unsafe bool bAllowSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_bAllowSizeScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_bAllowSizeScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x06011234 RID: 70196 RVA: 0x001925AF File Offset: 0x001907AF
		// (set) Token: 0x06011235 RID: 70197 RVA: 0x001925BF File Offset: 0x001907BF
		public unsafe uint ScalabilityGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_ScalabilityGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualTextureSpacePoolConfig.__PropertyOffset_ScalabilityGroup) = (int)value;
			}
		}

		// Token: 0x06011236 RID: 70198 RVA: 0x001925D0 File Offset: 0x001907D0
		public FVirtualTextureSpacePoolConfig()
		{
		}

		// Token: 0x06011237 RID: 70199 RVA: 0x001925D8 File Offset: 0x001907D8
		public FVirtualTextureSpacePoolConfig(int MinTileSize, int MaxTileSize, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EPixelFormat>> Formats, int SizeInMegabyte, bool bAllowSizeScale, uint ScalabilityGroup)
		{
			this.MinTileSize = MinTileSize;
			this.MaxTileSize = MaxTileSize;
			this.Formats = Formats;
			this.SizeInMegabyte = SizeInMegabyte;
			this.bAllowSizeScale = bAllowSizeScale;
			this.ScalabilityGroup = ScalabilityGroup;
		}

		// Token: 0x06011238 RID: 70200 RVA: 0x0019260D File Offset: 0x0019080D
		protected override IntPtr GetUStructPtr()
		{
			return FVirtualTextureSpacePoolConfig.StaticStruct();
		}

		// Token: 0x06011239 RID: 70201 RVA: 0x00192619 File Offset: 0x00190819
		[NullableContext(2)]
		public FVirtualTextureSpacePoolConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601123A RID: 70202 RVA: 0x00192623 File Offset: 0x00190823
		public FVirtualTextureSpacePoolConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601123B RID: 70203 RVA: 0x0019262E File Offset: 0x0019082E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVirtualTextureSpacePoolConfig(Pointer, false, true);
		}

		// Token: 0x0601123C RID: 70204 RVA: 0x00192638 File Offset: 0x00190838
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVirtualTextureSpacePoolConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040092BA RID: 37562
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VirtualTextureSpacePoolConfig";

		// Token: 0x040092BB RID: 37563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040092BC RID: 37564
		internal static int __PropertyOffset_MinTileSize;

		// Token: 0x040092BD RID: 37565
		internal static int __PropertyOffset_MaxTileSize;

		// Token: 0x040092BE RID: 37566
		internal static int __PropertyOffset_Formats;

		// Token: 0x040092BF RID: 37567
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EPixelFormat>> _Formats;

		// Token: 0x040092C0 RID: 37568
		internal static int __PropertyOffset_SizeInMegabyte;

		// Token: 0x040092C1 RID: 37569
		internal static int __PropertyOffset_bAllowSizeScale;

		// Token: 0x040092C2 RID: 37570
		internal static int __PropertyOffset_ScalabilityGroup;
	}
}
