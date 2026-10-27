using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001295 RID: 4757
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WpMapRegionInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FWpMapRegionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601175B RID: 71515 RVA: 0x0019A1DB File Offset: 0x001983DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWpMapRegionInfo._ScriptStructPtr != 0) ? FWpMapRegionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WpMapRegionInfo", ref FWpMapRegionInfo._ScriptStructPtr);
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x0601175C RID: 71516 RVA: 0x0019A1FF File Offset: 0x001983FF
		// (set) Token: 0x0601175D RID: 71517 RVA: 0x0019A213 File Offset: 0x00198413
		public unsafe string MapName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWpMapRegionInfo.__PropertyOffset_MapName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWpMapRegionInfo.__PropertyOffset_MapName)), value);
			}
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x0601175E RID: 71518 RVA: 0x0019A228 File Offset: 0x00198428
		// (set) Token: 0x0601175F RID: 71519 RVA: 0x0019A26B File Offset: 0x0019846B
		public TMap<string, FBox> Regions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FBox> result;
				if ((result = this._Regions) == null)
				{
					result = (this._Regions = new TMap<string, FBox>(base.NativePtr + (IntPtr)FWpMapRegionInfo.__PropertyOffset_Regions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Regions.CopyAssign(value);
			}
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x06011760 RID: 71520 RVA: 0x0019A27C File Offset: 0x0019847C
		// (set) Token: 0x06011761 RID: 71521 RVA: 0x0019A2BF File Offset: 0x001984BF
		public TArray<string> RegionGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RegionGroups) == null)
				{
					result = (this._RegionGroups = new TArray<string>(base.NativePtr + (IntPtr)FWpMapRegionInfo.__PropertyOffset_RegionGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RegionGroups.CopyAssign(value);
			}
		}

		// Token: 0x06011762 RID: 71522 RVA: 0x0019A2CD File Offset: 0x001984CD
		public FWpMapRegionInfo()
		{
		}

		// Token: 0x06011763 RID: 71523 RVA: 0x0019A2D5 File Offset: 0x001984D5
		public FWpMapRegionInfo(string MapName, TMap<string, FBox> Regions, TArray<string> RegionGroups)
		{
			this.MapName = MapName;
			this.Regions = Regions;
			this.RegionGroups = RegionGroups;
		}

		// Token: 0x06011764 RID: 71524 RVA: 0x0019A2F2 File Offset: 0x001984F2
		protected override IntPtr GetUStructPtr()
		{
			return FWpMapRegionInfo.StaticStruct();
		}

		// Token: 0x06011765 RID: 71525 RVA: 0x0019A2FE File Offset: 0x001984FE
		[NullableContext(2)]
		public FWpMapRegionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011766 RID: 71526 RVA: 0x0019A308 File Offset: 0x00198508
		public FWpMapRegionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011767 RID: 71527 RVA: 0x0019A313 File Offset: 0x00198513
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWpMapRegionInfo(Pointer, false, true);
		}

		// Token: 0x06011768 RID: 71528 RVA: 0x0019A31D File Offset: 0x0019851D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWpMapRegionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009589 RID: 38281
		public const string __ObjectPath = "/Script/Engine.WpMapRegionInfo";

		// Token: 0x0400958A RID: 38282
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400958B RID: 38283
		internal static int __PropertyOffset_MapName;

		// Token: 0x0400958C RID: 38284
		internal static int __PropertyOffset_Regions;

		// Token: 0x0400958D RID: 38285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FBox> _Regions;

		// Token: 0x0400958E RID: 38286
		internal static int __PropertyOffset_RegionGroups;

		// Token: 0x0400958F RID: 38287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RegionGroups;
	}
}
