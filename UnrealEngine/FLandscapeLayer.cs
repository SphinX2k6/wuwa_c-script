using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F7A RID: 8058
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeLayer")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FLandscapeLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E929 RID: 125225 RVA: 0x002D6FD2 File Offset: 0x002D51D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeLayer._ScriptStructPtr != 0) ? FLandscapeLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeLayer", ref FLandscapeLayer._ScriptStructPtr);
		}

		// Token: 0x170079A5 RID: 31141
		// (get) Token: 0x0601E92A RID: 125226 RVA: 0x002D6FF6 File Offset: 0x002D51F6
		// (set) Token: 0x0601E92B RID: 125227 RVA: 0x002D700A File Offset: 0x002D520A
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x170079A6 RID: 31142
		// (get) Token: 0x0601E92C RID: 125228 RVA: 0x002D701F File Offset: 0x002D521F
		// (set) Token: 0x0601E92D RID: 125229 RVA: 0x002D7033 File Offset: 0x002D5233
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170079A7 RID: 31143
		// (get) Token: 0x0601E92E RID: 125230 RVA: 0x002D7048 File Offset: 0x002D5248
		// (set) Token: 0x0601E92F RID: 125231 RVA: 0x002D7058 File Offset: 0x002D5258
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_bVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_bVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x170079A8 RID: 31144
		// (get) Token: 0x0601E930 RID: 125232 RVA: 0x002D7069 File Offset: 0x002D5269
		// (set) Token: 0x0601E931 RID: 125233 RVA: 0x002D7079 File Offset: 0x002D5279
		public unsafe bool bLocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_bLocked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_bLocked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170079A9 RID: 31145
		// (get) Token: 0x0601E932 RID: 125234 RVA: 0x002D708A File Offset: 0x002D528A
		// (set) Token: 0x0601E933 RID: 125235 RVA: 0x002D709A File Offset: 0x002D529A
		public unsafe float HeightmapAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_HeightmapAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_HeightmapAlpha) = value;
			}
		}

		// Token: 0x170079AA RID: 31146
		// (get) Token: 0x0601E934 RID: 125236 RVA: 0x002D70AB File Offset: 0x002D52AB
		// (set) Token: 0x0601E935 RID: 125237 RVA: 0x002D70BB File Offset: 0x002D52BB
		public unsafe float WeightmapAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_WeightmapAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_WeightmapAlpha) = value;
			}
		}

		// Token: 0x170079AB RID: 31147
		// (get) Token: 0x0601E936 RID: 125238 RVA: 0x002D70CC File Offset: 0x002D52CC
		// (set) Token: 0x0601E937 RID: 125239 RVA: 0x002D70E0 File Offset: 0x002D52E0
		[Nullable(0)]
		public unsafe TEnumAsByte<ELandscapeBlendMode> BlendMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_BlendMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_BlendMode) = value;
			}
		}

		// Token: 0x170079AC RID: 31148
		// (get) Token: 0x0601E938 RID: 125240 RVA: 0x002D70F8 File Offset: 0x002D52F8
		// (set) Token: 0x0601E939 RID: 125241 RVA: 0x002D713B File Offset: 0x002D533B
		public TArray<FLandscapeLayerBrush> Brushes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeLayerBrush> result;
				if ((result = this._Brushes) == null)
				{
					result = (this._Brushes = new TArray<FLandscapeLayerBrush>(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_Brushes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Brushes.CopyAssign(value);
			}
		}

		// Token: 0x170079AD RID: 31149
		// (get) Token: 0x0601E93A RID: 125242 RVA: 0x002D714C File Offset: 0x002D534C
		// (set) Token: 0x0601E93B RID: 125243 RVA: 0x002D718F File Offset: 0x002D538F
		public TMap<ULandscapeLayerInfoObject, bool> WeightmapLayerAllocationBlend
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ULandscapeLayerInfoObject, bool> result;
				if ((result = this._WeightmapLayerAllocationBlend) == null)
				{
					result = (this._WeightmapLayerAllocationBlend = new TMap<ULandscapeLayerInfoObject, bool>(base.NativePtr + (IntPtr)FLandscapeLayer.__PropertyOffset_WeightmapLayerAllocationBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeightmapLayerAllocationBlend.CopyAssign(value);
			}
		}

		// Token: 0x0601E93C RID: 125244 RVA: 0x002D719D File Offset: 0x002D539D
		public FLandscapeLayer()
		{
		}

		// Token: 0x0601E93D RID: 125245 RVA: 0x002D71A8 File Offset: 0x002D53A8
		public FLandscapeLayer(FGuid Guid, FName Name, bool bVisible, bool bLocked, float HeightmapAlpha, float WeightmapAlpha, [Nullable(0)] TEnumAsByte<ELandscapeBlendMode> BlendMode, TArray<FLandscapeLayerBrush> Brushes, TMap<ULandscapeLayerInfoObject, bool> WeightmapLayerAllocationBlend)
		{
			this.Guid = Guid;
			this.Name = Name;
			this.bVisible = bVisible;
			this.bLocked = bLocked;
			this.HeightmapAlpha = HeightmapAlpha;
			this.WeightmapAlpha = WeightmapAlpha;
			this.BlendMode = BlendMode;
			this.Brushes = Brushes;
			this.WeightmapLayerAllocationBlend = WeightmapLayerAllocationBlend;
		}

		// Token: 0x0601E93E RID: 125246 RVA: 0x002D7200 File Offset: 0x002D5400
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeLayer.StaticStruct();
		}

		// Token: 0x0601E93F RID: 125247 RVA: 0x002D720C File Offset: 0x002D540C
		[NullableContext(2)]
		public FLandscapeLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E940 RID: 125248 RVA: 0x002D7216 File Offset: 0x002D5416
		public FLandscapeLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E941 RID: 125249 RVA: 0x002D7221 File Offset: 0x002D5421
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeLayer(Pointer, false, true);
		}

		// Token: 0x0601E942 RID: 125250 RVA: 0x002D722B File Offset: 0x002D542B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeLayer(Pointer, MemoryOwner);
		}

		// Token: 0x0401085A RID: 67674
		public const string __ObjectPath = "/Script/Landscape.LandscapeLayer";

		// Token: 0x0401085B RID: 67675
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401085C RID: 67676
		internal static int __PropertyOffset_Guid;

		// Token: 0x0401085D RID: 67677
		internal static int __PropertyOffset_Name;

		// Token: 0x0401085E RID: 67678
		internal static int __PropertyOffset_bVisible;

		// Token: 0x0401085F RID: 67679
		internal static int __PropertyOffset_bLocked;

		// Token: 0x04010860 RID: 67680
		internal static int __PropertyOffset_HeightmapAlpha;

		// Token: 0x04010861 RID: 67681
		internal static int __PropertyOffset_WeightmapAlpha;

		// Token: 0x04010862 RID: 67682
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x04010863 RID: 67683
		internal static int __PropertyOffset_Brushes;

		// Token: 0x04010864 RID: 67684
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeLayerBrush> _Brushes;

		// Token: 0x04010865 RID: 67685
		internal static int __PropertyOffset_WeightmapLayerAllocationBlend;

		// Token: 0x04010866 RID: 67686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ULandscapeLayerInfoObject, bool> _WeightmapLayerAllocationBlend;
	}
}
