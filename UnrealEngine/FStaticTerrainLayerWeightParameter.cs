using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200119E RID: 4510
	[UnrealObjectPath("/Script/Engine.StaticTerrainLayerWeightParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FStaticTerrainLayerWeightParameter : FStaticParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060109CC RID: 68044 RVA: 0x001865A4 File Offset: 0x001847A4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticTerrainLayerWeightParameter._ScriptStructPtr != 0) ? FStaticTerrainLayerWeightParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticTerrainLayerWeightParameter", ref FStaticTerrainLayerWeightParameter._ScriptStructPtr);
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x060109CD RID: 68045 RVA: 0x001865C8 File Offset: 0x001847C8
		// (set) Token: 0x060109CE RID: 68046 RVA: 0x001865D8 File Offset: 0x001847D8
		public unsafe int WeightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticTerrainLayerWeightParameter.__PropertyOffset_WeightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticTerrainLayerWeightParameter.__PropertyOffset_WeightmapIndex) = value;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x060109CF RID: 68047 RVA: 0x001865E9 File Offset: 0x001847E9
		// (set) Token: 0x060109D0 RID: 68048 RVA: 0x001865F9 File Offset: 0x001847F9
		public unsafe bool bWeightBasedBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticTerrainLayerWeightParameter.__PropertyOffset_bWeightBasedBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticTerrainLayerWeightParameter.__PropertyOffset_bWeightBasedBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x060109D1 RID: 68049 RVA: 0x0018660A File Offset: 0x0018480A
		public FStaticTerrainLayerWeightParameter()
		{
		}

		// Token: 0x060109D2 RID: 68050 RVA: 0x00186612 File Offset: 0x00184812
		[NullableContext(1)]
		public FStaticTerrainLayerWeightParameter(int WeightmapIndex, bool bWeightBasedBlend, FMaterialParameterInfo ParameterInfo, bool bOverride, FGuid ExpressionGUID)
		{
			this.WeightmapIndex = WeightmapIndex;
			this.bWeightBasedBlend = bWeightBasedBlend;
			base.ParameterInfo = ParameterInfo;
			base.bOverride = bOverride;
			base.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x060109D3 RID: 68051 RVA: 0x0018663F File Offset: 0x0018483F
		protected override IntPtr GetUStructPtr()
		{
			return FStaticTerrainLayerWeightParameter.StaticStruct();
		}

		// Token: 0x060109D4 RID: 68052 RVA: 0x0018664B File Offset: 0x0018484B
		[NullableContext(2)]
		public FStaticTerrainLayerWeightParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060109D5 RID: 68053 RVA: 0x00186655 File Offset: 0x00184855
		public FStaticTerrainLayerWeightParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060109D6 RID: 68054 RVA: 0x00186660 File Offset: 0x00184860
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticTerrainLayerWeightParameter(Pointer, false, true);
		}

		// Token: 0x060109D7 RID: 68055 RVA: 0x0018666A File Offset: 0x0018486A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticTerrainLayerWeightParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04008E2C RID: 36396
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticTerrainLayerWeightParameter";

		// Token: 0x04008E2D RID: 36397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E2E RID: 36398
		internal static int __PropertyOffset_WeightmapIndex;

		// Token: 0x04008E2F RID: 36399
		internal static int __PropertyOffset_bWeightBasedBlend;
	}
}
