using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028BB RID: 10427
	[UnrealObjectPath("/Script/StandinActor.NearStandinLightmapSettings")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FNearStandinLightmapSettings : FStandinLightmapSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026B8B RID: 158603 RVA: 0x003B1239 File Offset: 0x003AF439
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNearStandinLightmapSettings._ScriptStructPtr != 0) ? FNearStandinLightmapSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StandinActor.NearStandinLightmapSettings", ref FNearStandinLightmapSettings._ScriptStructPtr);
		}

		// Token: 0x17009531 RID: 38193
		// (get) Token: 0x06026B8C RID: 158604 RVA: 0x003B125D File Offset: 0x003AF45D
		// (set) Token: 0x06026B8D RID: 158605 RVA: 0x003B126D File Offset: 0x003AF46D
		public unsafe bool bGenerateLightmapTexCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_bGenerateLightmapTexCoords) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_bGenerateLightmapTexCoords) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009532 RID: 38194
		// (get) Token: 0x06026B8E RID: 158606 RVA: 0x003B127E File Offset: 0x003AF47E
		// (set) Token: 0x06026B8F RID: 158607 RVA: 0x003B128E File Offset: 0x003AF48E
		public unsafe int TexCoordResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordResolution) = value;
			}
		}

		// Token: 0x17009533 RID: 38195
		// (get) Token: 0x06026B90 RID: 158608 RVA: 0x003B129F File Offset: 0x003AF49F
		// (set) Token: 0x06026B91 RID: 158609 RVA: 0x003B12AF File Offset: 0x003AF4AF
		public unsafe int TexCoordGutterSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordGutterSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordGutterSpace) = value;
			}
		}

		// Token: 0x17009534 RID: 38196
		// (get) Token: 0x06026B92 RID: 158610 RVA: 0x003B12C0 File Offset: 0x003AF4C0
		// (set) Token: 0x06026B93 RID: 158611 RVA: 0x003B12D0 File Offset: 0x003AF4D0
		public unsafe EChartAggregatorMode TexCoordPackerMode
		{
			get
			{
				return (EChartAggregatorMode)(*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordPackerMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_TexCoordPackerMode) = (byte)value;
			}
		}

		// Token: 0x17009535 RID: 38197
		// (get) Token: 0x06026B94 RID: 158612 RVA: 0x003B12E1 File Offset: 0x003AF4E1
		// (set) Token: 0x06026B95 RID: 158613 RVA: 0x003B12F1 File Offset: 0x003AF4F1
		public unsafe ESourceTexCoordMode SourceTexCoordMode
		{
			get
			{
				return (ESourceTexCoordMode)(*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_SourceTexCoordMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_SourceTexCoordMode) = (byte)value;
			}
		}

		// Token: 0x17009536 RID: 38198
		// (get) Token: 0x06026B96 RID: 158614 RVA: 0x003B1302 File Offset: 0x003AF502
		// (set) Token: 0x06026B97 RID: 158615 RVA: 0x003B1312 File Offset: 0x003AF512
		public unsafe int SourceTexCoordIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_SourceTexCoordIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNearStandinLightmapSettings.__PropertyOffset_SourceTexCoordIndex) = value;
			}
		}

		// Token: 0x06026B98 RID: 158616 RVA: 0x003B1323 File Offset: 0x003AF523
		public FNearStandinLightmapSettings()
		{
		}

		// Token: 0x06026B99 RID: 158617 RVA: 0x003B132C File Offset: 0x003AF52C
		public FNearStandinLightmapSettings(bool bGenerateLightmapTexCoords, int TexCoordResolution, int TexCoordGutterSpace, EChartAggregatorMode TexCoordPackerMode, ESourceTexCoordMode SourceTexCoordMode, int SourceTexCoordIndex, int LightmapResolution, int LightmapIndex)
		{
			this.bGenerateLightmapTexCoords = bGenerateLightmapTexCoords;
			this.TexCoordResolution = TexCoordResolution;
			this.TexCoordGutterSpace = TexCoordGutterSpace;
			this.TexCoordPackerMode = TexCoordPackerMode;
			this.SourceTexCoordMode = SourceTexCoordMode;
			this.SourceTexCoordIndex = SourceTexCoordIndex;
			base.LightmapResolution = LightmapResolution;
			base.LightmapIndex = LightmapIndex;
		}

		// Token: 0x06026B9A RID: 158618 RVA: 0x003B137C File Offset: 0x003AF57C
		protected override IntPtr GetUStructPtr()
		{
			return FNearStandinLightmapSettings.StaticStruct();
		}

		// Token: 0x06026B9B RID: 158619 RVA: 0x003B1388 File Offset: 0x003AF588
		[NullableContext(2)]
		public FNearStandinLightmapSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026B9C RID: 158620 RVA: 0x003B1392 File Offset: 0x003AF592
		public FNearStandinLightmapSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026B9D RID: 158621 RVA: 0x003B139D File Offset: 0x003AF59D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNearStandinLightmapSettings(Pointer, false, true);
		}

		// Token: 0x06026B9E RID: 158622 RVA: 0x003B13A7 File Offset: 0x003AF5A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNearStandinLightmapSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040153FD RID: 87037
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StandinActor.NearStandinLightmapSettings";

		// Token: 0x040153FE RID: 87038
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040153FF RID: 87039
		internal static int __PropertyOffset_bGenerateLightmapTexCoords;

		// Token: 0x04015400 RID: 87040
		internal static int __PropertyOffset_TexCoordResolution;

		// Token: 0x04015401 RID: 87041
		internal static int __PropertyOffset_TexCoordGutterSpace;

		// Token: 0x04015402 RID: 87042
		internal static int __PropertyOffset_TexCoordPackerMode;

		// Token: 0x04015403 RID: 87043
		internal static int __PropertyOffset_SourceTexCoordMode;

		// Token: 0x04015404 RID: 87044
		internal static int __PropertyOffset_SourceTexCoordIndex;
	}
}
