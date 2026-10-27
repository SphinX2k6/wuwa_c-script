using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001190 RID: 4496
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMaterialLayersParameter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FStaticMaterialLayersParameter : FStaticParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010835 RID: 67637 RVA: 0x00183F09 File Offset: 0x00182109
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMaterialLayersParameter._ScriptStructPtr != 0) ? FStaticMaterialLayersParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMaterialLayersParameter", ref FStaticMaterialLayersParameter._ScriptStructPtr);
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x06010836 RID: 67638 RVA: 0x00183F30 File Offset: 0x00182130
		// (set) Token: 0x06010837 RID: 67639 RVA: 0x00183F73 File Offset: 0x00182173
		public FMaterialLayersFunctions Value
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLayersFunctions result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FMaterialLayersFunctions(base.NativePtr + (IntPtr)FStaticMaterialLayersParameter.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLayersFunctions.StaticStruct(), base.NativePtr + (IntPtr)FStaticMaterialLayersParameter.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010838 RID: 67640 RVA: 0x00183F94 File Offset: 0x00182194
		public FStaticMaterialLayersParameter()
		{
		}

		// Token: 0x06010839 RID: 67641 RVA: 0x00183F9C File Offset: 0x0018219C
		public FStaticMaterialLayersParameter(FMaterialLayersFunctions Value, FMaterialParameterInfo ParameterInfo, bool bOverride, FGuid ExpressionGUID)
		{
			this.Value = Value;
			base.ParameterInfo = ParameterInfo;
			base.bOverride = bOverride;
			base.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0601083A RID: 67642 RVA: 0x00183FC1 File Offset: 0x001821C1
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMaterialLayersParameter.StaticStruct();
		}

		// Token: 0x0601083B RID: 67643 RVA: 0x00183FCD File Offset: 0x001821CD
		[NullableContext(2)]
		public FStaticMaterialLayersParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601083C RID: 67644 RVA: 0x00183FD7 File Offset: 0x001821D7
		public FStaticMaterialLayersParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601083D RID: 67645 RVA: 0x00183FE2 File Offset: 0x001821E2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMaterialLayersParameter(Pointer, false, true);
		}

		// Token: 0x0601083E RID: 67646 RVA: 0x00183FEC File Offset: 0x001821EC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMaterialLayersParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04008D4E RID: 36174
		public new const string __ObjectPath = "/Script/Engine.StaticMaterialLayersParameter";

		// Token: 0x04008D4F RID: 36175
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D50 RID: 36176
		internal static int __PropertyOffset_Value;

		// Token: 0x04008D51 RID: 36177
		[Nullable(2)]
		private FMaterialLayersFunctions _Value;
	}
}
