using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B0 RID: 10160
	[UnrealObjectPath("/Script/SimplygonUObjects.FoliageSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FFoliageSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025DD1 RID: 155089 RVA: 0x0039680C File Offset: 0x00394A0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoliageSettings._ScriptStructPtr != 0) ? FFoliageSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.FoliageSettings", ref FFoliageSettings._ScriptStructPtr);
		}

		// Token: 0x170091E9 RID: 37353
		// (get) Token: 0x06025DD2 RID: 155090 RVA: 0x00396830 File Offset: 0x00394A30
		// (set) Token: 0x06025DD3 RID: 155091 RVA: 0x00396849 File Offset: 0x00394A49
		public unsafe bool MaintainLeafConnections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_MaintainLeafConnections) & FFoliageSettings.__PropertyMask_MaintainLeafConnections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_MaintainLeafConnections) = ((*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_MaintainLeafConnections) & ~FFoliageSettings.__PropertyMask_MaintainLeafConnections) | (value ? FFoliageSettings.__PropertyMask_MaintainLeafConnections : 0));
			}
		}

		// Token: 0x170091EA RID: 37354
		// (get) Token: 0x06025DD4 RID: 155092 RVA: 0x00396879 File Offset: 0x00394A79
		// (set) Token: 0x06025DD5 RID: 155093 RVA: 0x00396892 File Offset: 0x00394A92
		public unsafe bool SeparateTrunkAndFoliage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateTrunkAndFoliage) & FFoliageSettings.__PropertyMask_SeparateTrunkAndFoliage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateTrunkAndFoliage) = ((*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateTrunkAndFoliage) & ~FFoliageSettings.__PropertyMask_SeparateTrunkAndFoliage) | (value ? FFoliageSettings.__PropertyMask_SeparateTrunkAndFoliage : 0));
			}
		}

		// Token: 0x170091EB RID: 37355
		// (get) Token: 0x06025DD6 RID: 155094 RVA: 0x003968C2 File Offset: 0x00394AC2
		// (set) Token: 0x06025DD7 RID: 155095 RVA: 0x003968D2 File Offset: 0x00394AD2
		public unsafe float SeparateFoliageTriangleRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageTriangleRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageTriangleRatio) = value;
			}
		}

		// Token: 0x170091EC RID: 37356
		// (get) Token: 0x06025DD8 RID: 155096 RVA: 0x003968E3 File Offset: 0x00394AE3
		// (set) Token: 0x06025DD9 RID: 155097 RVA: 0x003968F3 File Offset: 0x00394AF3
		public unsafe int SeparateFoliageTriangleThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageTriangleThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageTriangleThreshold) = value;
			}
		}

		// Token: 0x170091ED RID: 37357
		// (get) Token: 0x06025DDA RID: 155098 RVA: 0x00396904 File Offset: 0x00394B04
		// (set) Token: 0x06025DDB RID: 155099 RVA: 0x00396914 File Offset: 0x00394B14
		public unsafe float SeparateFoliageAreaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageAreaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageAreaThreshold) = value;
			}
		}

		// Token: 0x170091EE RID: 37358
		// (get) Token: 0x06025DDC RID: 155100 RVA: 0x00396925 File Offset: 0x00394B25
		// (set) Token: 0x06025DDD RID: 155101 RVA: 0x00396935 File Offset: 0x00394B35
		public unsafe float SeparateFoliageSizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageSizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_SeparateFoliageSizeThreshold) = value;
			}
		}

		// Token: 0x170091EF RID: 37359
		// (get) Token: 0x06025DDE RID: 155102 RVA: 0x00396946 File Offset: 0x00394B46
		// (set) Token: 0x06025DDF RID: 155103 RVA: 0x00396956 File Offset: 0x00394B56
		public unsafe float TrunkReductionRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_TrunkReductionRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageSettings.__PropertyOffset_TrunkReductionRatio) = value;
			}
		}

		// Token: 0x06025DE0 RID: 155104 RVA: 0x00396967 File Offset: 0x00394B67
		public FFoliageSettings()
		{
		}

		// Token: 0x06025DE1 RID: 155105 RVA: 0x0039696F File Offset: 0x00394B6F
		public FFoliageSettings(bool MaintainLeafConnections, bool SeparateTrunkAndFoliage, float SeparateFoliageTriangleRatio, int SeparateFoliageTriangleThreshold, float SeparateFoliageAreaThreshold, float SeparateFoliageSizeThreshold, float TrunkReductionRatio)
		{
			this.MaintainLeafConnections = MaintainLeafConnections;
			this.SeparateTrunkAndFoliage = SeparateTrunkAndFoliage;
			this.SeparateFoliageTriangleRatio = SeparateFoliageTriangleRatio;
			this.SeparateFoliageTriangleThreshold = SeparateFoliageTriangleThreshold;
			this.SeparateFoliageAreaThreshold = SeparateFoliageAreaThreshold;
			this.SeparateFoliageSizeThreshold = SeparateFoliageSizeThreshold;
			this.TrunkReductionRatio = TrunkReductionRatio;
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x003969AC File Offset: 0x00394BAC
		protected override IntPtr GetUStructPtr()
		{
			return FFoliageSettings.StaticStruct();
		}

		// Token: 0x06025DE3 RID: 155107 RVA: 0x003969B8 File Offset: 0x00394BB8
		[NullableContext(2)]
		public FFoliageSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x003969C2 File Offset: 0x00394BC2
		public FFoliageSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025DE5 RID: 155109 RVA: 0x003969CD File Offset: 0x00394BCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoliageSettings(Pointer, false, true);
		}

		// Token: 0x06025DE6 RID: 155110 RVA: 0x003969D7 File Offset: 0x00394BD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoliageSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AA9 RID: 84649
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.FoliageSettings";

		// Token: 0x04014AAA RID: 84650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AAB RID: 84651
		internal static int __PropertyOffset_MaintainLeafConnections;

		// Token: 0x04014AAC RID: 84652
		internal static byte __PropertyMask_MaintainLeafConnections;

		// Token: 0x04014AAD RID: 84653
		internal static int __PropertyOffset_SeparateTrunkAndFoliage;

		// Token: 0x04014AAE RID: 84654
		internal static byte __PropertyMask_SeparateTrunkAndFoliage;

		// Token: 0x04014AAF RID: 84655
		internal static int __PropertyOffset_SeparateFoliageTriangleRatio;

		// Token: 0x04014AB0 RID: 84656
		internal static int __PropertyOffset_SeparateFoliageTriangleThreshold;

		// Token: 0x04014AB1 RID: 84657
		internal static int __PropertyOffset_SeparateFoliageAreaThreshold;

		// Token: 0x04014AB2 RID: 84658
		internal static int __PropertyOffset_SeparateFoliageSizeThreshold;

		// Token: 0x04014AB3 RID: 84659
		internal static int __PropertyOffset_TrunkReductionRatio;
	}
}
