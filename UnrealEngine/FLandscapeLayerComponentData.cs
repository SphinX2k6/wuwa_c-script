using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F7C RID: 8060
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeLayerComponentData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLandscapeLayerComponentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E94B RID: 125259 RVA: 0x002D729C File Offset: 0x002D549C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeLayerComponentData._ScriptStructPtr != 0) ? FLandscapeLayerComponentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeLayerComponentData", ref FLandscapeLayerComponentData._ScriptStructPtr);
		}

		// Token: 0x170079AE RID: 31150
		// (get) Token: 0x0601E94C RID: 125260 RVA: 0x002D72C0 File Offset: 0x002D54C0
		// (set) Token: 0x0601E94D RID: 125261 RVA: 0x002D7303 File Offset: 0x002D5503
		public FHeightmapData HeightmapData
		{
			get
			{
				base.FastCheckIsValid();
				FHeightmapData result;
				if ((result = this._HeightmapData) == null)
				{
					result = (this._HeightmapData = new FHeightmapData(base.NativePtr + (IntPtr)FLandscapeLayerComponentData.__PropertyOffset_HeightmapData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHeightmapData.StaticStruct(), base.NativePtr + (IntPtr)FLandscapeLayerComponentData.__PropertyOffset_HeightmapData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170079AF RID: 31151
		// (get) Token: 0x0601E94E RID: 125262 RVA: 0x002D7324 File Offset: 0x002D5524
		// (set) Token: 0x0601E94F RID: 125263 RVA: 0x002D7367 File Offset: 0x002D5567
		public FWeightmapData WeightmapData
		{
			get
			{
				base.FastCheckIsValid();
				FWeightmapData result;
				if ((result = this._WeightmapData) == null)
				{
					result = (this._WeightmapData = new FWeightmapData(base.NativePtr + (IntPtr)FLandscapeLayerComponentData.__PropertyOffset_WeightmapData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWeightmapData.StaticStruct(), base.NativePtr + (IntPtr)FLandscapeLayerComponentData.__PropertyOffset_WeightmapData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E950 RID: 125264 RVA: 0x002D7388 File Offset: 0x002D5588
		public FLandscapeLayerComponentData()
		{
		}

		// Token: 0x0601E951 RID: 125265 RVA: 0x002D7390 File Offset: 0x002D5590
		public FLandscapeLayerComponentData(FHeightmapData HeightmapData, FWeightmapData WeightmapData)
		{
			this.HeightmapData = HeightmapData;
			this.WeightmapData = WeightmapData;
		}

		// Token: 0x0601E952 RID: 125266 RVA: 0x002D73A6 File Offset: 0x002D55A6
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeLayerComponentData.StaticStruct();
		}

		// Token: 0x0601E953 RID: 125267 RVA: 0x002D73B2 File Offset: 0x002D55B2
		[NullableContext(2)]
		public FLandscapeLayerComponentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E954 RID: 125268 RVA: 0x002D73BC File Offset: 0x002D55BC
		public FLandscapeLayerComponentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E955 RID: 125269 RVA: 0x002D73C7 File Offset: 0x002D55C7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeLayerComponentData(Pointer, false, true);
		}

		// Token: 0x0601E956 RID: 125270 RVA: 0x002D73D1 File Offset: 0x002D55D1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeLayerComponentData(Pointer, MemoryOwner);
		}

		// Token: 0x04010869 RID: 67689
		public const string __ObjectPath = "/Script/Landscape.LandscapeLayerComponentData";

		// Token: 0x0401086A RID: 67690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401086B RID: 67691
		internal static int __PropertyOffset_HeightmapData;

		// Token: 0x0401086C RID: 67692
		[Nullable(2)]
		private FHeightmapData _HeightmapData;

		// Token: 0x0401086D RID: 67693
		internal static int __PropertyOffset_WeightmapData;

		// Token: 0x0401086E RID: 67694
		[Nullable(2)]
		private FWeightmapData _WeightmapData;
	}
}
