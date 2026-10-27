using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA5 RID: 8101
	[UnrealObjectPath("/Script/Landscape.WeightmapLayerAllocationInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWeightmapLayerAllocationInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EBD7 RID: 125911 RVA: 0x002DB3FA File Offset: 0x002D95FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWeightmapLayerAllocationInfo._ScriptStructPtr != 0) ? FWeightmapLayerAllocationInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.WeightmapLayerAllocationInfo", ref FWeightmapLayerAllocationInfo._ScriptStructPtr);
		}

		// Token: 0x17007A74 RID: 31348
		// (get) Token: 0x0601EBD8 RID: 125912 RVA: 0x002DB41E File Offset: 0x002D961E
		// (set) Token: 0x0601EBD9 RID: 125913 RVA: 0x002DB432 File Offset: 0x002D9632
		[Nullable(2)]
		public unsafe ULandscapeLayerInfoObject LayerInfo
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeLayerInfoObject>(base.NativePtr / (IntPtr)sizeof(void*) + FWeightmapLayerAllocationInfo.__PropertyOffset_LayerInfo);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FWeightmapLayerAllocationInfo.__PropertyOffset_LayerInfo, value);
			}
		}

		// Token: 0x17007A75 RID: 31349
		// (get) Token: 0x0601EBDA RID: 125914 RVA: 0x002DB447 File Offset: 0x002D9647
		// (set) Token: 0x0601EBDB RID: 125915 RVA: 0x002DB457 File Offset: 0x002D9657
		public unsafe byte WeightmapTextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWeightmapLayerAllocationInfo.__PropertyOffset_WeightmapTextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWeightmapLayerAllocationInfo.__PropertyOffset_WeightmapTextureIndex) = value;
			}
		}

		// Token: 0x17007A76 RID: 31350
		// (get) Token: 0x0601EBDC RID: 125916 RVA: 0x002DB468 File Offset: 0x002D9668
		// (set) Token: 0x0601EBDD RID: 125917 RVA: 0x002DB478 File Offset: 0x002D9678
		public unsafe byte WeightmapTextureChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWeightmapLayerAllocationInfo.__PropertyOffset_WeightmapTextureChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWeightmapLayerAllocationInfo.__PropertyOffset_WeightmapTextureChannel) = value;
			}
		}

		// Token: 0x0601EBDE RID: 125918 RVA: 0x002DB489 File Offset: 0x002D9689
		public FWeightmapLayerAllocationInfo()
		{
		}

		// Token: 0x0601EBDF RID: 125919 RVA: 0x002DB491 File Offset: 0x002D9691
		[NullableContext(1)]
		public FWeightmapLayerAllocationInfo(ULandscapeLayerInfoObject LayerInfo, byte WeightmapTextureIndex, byte WeightmapTextureChannel)
		{
			this.LayerInfo = LayerInfo;
			this.WeightmapTextureIndex = WeightmapTextureIndex;
			this.WeightmapTextureChannel = WeightmapTextureChannel;
		}

		// Token: 0x0601EBE0 RID: 125920 RVA: 0x002DB4AE File Offset: 0x002D96AE
		protected override IntPtr GetUStructPtr()
		{
			return FWeightmapLayerAllocationInfo.StaticStruct();
		}

		// Token: 0x0601EBE1 RID: 125921 RVA: 0x002DB4BA File Offset: 0x002D96BA
		[NullableContext(2)]
		public FWeightmapLayerAllocationInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EBE2 RID: 125922 RVA: 0x002DB4C4 File Offset: 0x002D96C4
		public FWeightmapLayerAllocationInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EBE3 RID: 125923 RVA: 0x002DB4CF File Offset: 0x002D96CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWeightmapLayerAllocationInfo(Pointer, false, true);
		}

		// Token: 0x0601EBE4 RID: 125924 RVA: 0x002DB4D9 File Offset: 0x002D96D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWeightmapLayerAllocationInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040109F4 RID: 68084
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.WeightmapLayerAllocationInfo";

		// Token: 0x040109F5 RID: 68085
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109F6 RID: 68086
		internal static int __PropertyOffset_LayerInfo;

		// Token: 0x040109F7 RID: 68087
		internal static int __PropertyOffset_WeightmapTextureIndex;

		// Token: 0x040109F8 RID: 68088
		internal static int __PropertyOffset_WeightmapTextureChannel;
	}
}
