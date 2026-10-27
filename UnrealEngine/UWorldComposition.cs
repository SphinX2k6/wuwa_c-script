using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200124A RID: 4682
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldComposition")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UWorldComposition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011399 RID: 70553 RVA: 0x001944E0 File Offset: 0x001926E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldComposition._ClassPtr;
		}

		// Token: 0x0601139A RID: 70554 RVA: 0x001944EC File Offset: 0x001926EC
		public UWorldComposition() : this(BuiltinUtils.AllocNativeUObject(UWorldComposition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601139B RID: 70555 RVA: 0x00194514 File Offset: 0x00192714
		public UWorldComposition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldComposition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0601139C RID: 70556 RVA: 0x00194548 File Offset: 0x00192748
		// (set) Token: 0x0601139D RID: 70557 RVA: 0x00194581 File Offset: 0x00192781
		public TArray<ULevelStreaming> TilesStreaming
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelStreaming> result;
				if ((result = this._TilesStreaming) == null)
				{
					result = (this._TilesStreaming = new TArray<ULevelStreaming>(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_TilesStreaming, this));
				}
				return result;
			}
			set
			{
				this.TilesStreaming.CopyAssign(value);
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x0601139E RID: 70558 RVA: 0x0019458F File Offset: 0x0019278F
		// (set) Token: 0x0601139F RID: 70559 RVA: 0x0019459F File Offset: 0x0019279F
		public unsafe double TilesStreamingTimeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_TilesStreamingTimeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_TilesStreamingTimeThreshold) = value;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x060113A0 RID: 70560 RVA: 0x001945B0 File Offset: 0x001927B0
		// (set) Token: 0x060113A1 RID: 70561 RVA: 0x001945C0 File Offset: 0x001927C0
		public unsafe bool bLoadAllTilesDuringCinematic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_bLoadAllTilesDuringCinematic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_bLoadAllTilesDuringCinematic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x060113A2 RID: 70562 RVA: 0x001945D1 File Offset: 0x001927D1
		// (set) Token: 0x060113A3 RID: 70563 RVA: 0x001945E1 File Offset: 0x001927E1
		public unsafe bool bRebaseOriginIn3DSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_bRebaseOriginIn3DSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_bRebaseOriginIn3DSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x060113A4 RID: 70564 RVA: 0x001945F2 File Offset: 0x001927F2
		// (set) Token: 0x060113A5 RID: 70565 RVA: 0x00194602 File Offset: 0x00192802
		public unsafe float RebaseOriginDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_RebaseOriginDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldComposition.__PropertyOffset_RebaseOriginDistance) = value;
			}
		}

		// Token: 0x060113A6 RID: 70566 RVA: 0x00194613 File Offset: 0x00192813
		static UWorldComposition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldComposition");
		}

		// Token: 0x060113A7 RID: 70567 RVA: 0x00194621 File Offset: 0x00192821
		protected UWorldComposition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400935F RID: 37727
		public new const string __ObjectPath = "/Script/Engine.WorldComposition";

		// Token: 0x04009360 RID: 37728
		private static IntPtr _ClassPtr;

		// Token: 0x04009361 RID: 37729
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009362 RID: 37730
		internal static int __PropertyOffset_TilesStreaming;

		// Token: 0x04009363 RID: 37731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelStreaming> _TilesStreaming;

		// Token: 0x04009364 RID: 37732
		internal static int __PropertyOffset_TilesStreamingTimeThreshold;

		// Token: 0x04009365 RID: 37733
		internal static int __PropertyOffset_bLoadAllTilesDuringCinematic;

		// Token: 0x04009366 RID: 37734
		internal static int __PropertyOffset_bRebaseOriginIn3DSpace;

		// Token: 0x04009367 RID: 37735
		internal static int __PropertyOffset_RebaseOriginDistance;
	}
}
