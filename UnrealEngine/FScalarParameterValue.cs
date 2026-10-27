using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010CE RID: 4302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ScalarParameterValue")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FScalarParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F575 RID: 62837 RVA: 0x0016BC4B File Offset: 0x00169E4B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScalarParameterValue._ScriptStructPtr != 0) ? FScalarParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ScalarParameterValue", ref FScalarParameterValue._ScriptStructPtr);
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600F576 RID: 62838 RVA: 0x0016BC70 File Offset: 0x00169E70
		// (set) Token: 0x0600F577 RID: 62839 RVA: 0x0016BCB3 File Offset: 0x00169EB3
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600F578 RID: 62840 RVA: 0x0016BCD4 File Offset: 0x00169ED4
		// (set) Token: 0x0600F579 RID: 62841 RVA: 0x0016BCE4 File Offset: 0x00169EE4
		public unsafe float ParameterValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ParameterValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ParameterValue) = value;
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600F57A RID: 62842 RVA: 0x0016BCF5 File Offset: 0x00169EF5
		// (set) Token: 0x0600F57B RID: 62843 RVA: 0x0016BD09 File Offset: 0x00169F09
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScalarParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0600F57C RID: 62844 RVA: 0x0016BD1E File Offset: 0x00169F1E
		public FScalarParameterValue()
		{
		}

		// Token: 0x0600F57D RID: 62845 RVA: 0x0016BD26 File Offset: 0x00169F26
		public FScalarParameterValue(FName ParameterName_DEPRECATED, FScalarParameterAtlasInstanceData AtlasData, FMaterialParameterInfo ParameterInfo, float ParameterValue, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.ParameterValue = ParameterValue;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0600F57E RID: 62846 RVA: 0x0016BD45 File Offset: 0x00169F45
		protected override IntPtr GetUStructPtr()
		{
			return FScalarParameterValue.StaticStruct();
		}

		// Token: 0x0600F57F RID: 62847 RVA: 0x0016BD51 File Offset: 0x00169F51
		[NullableContext(2)]
		public FScalarParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F580 RID: 62848 RVA: 0x0016BD5B File Offset: 0x00169F5B
		public FScalarParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F581 RID: 62849 RVA: 0x0016BD66 File Offset: 0x00169F66
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScalarParameterValue(Pointer, false, true);
		}

		// Token: 0x0600F582 RID: 62850 RVA: 0x0016BD70 File Offset: 0x00169F70
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScalarParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x040084FA RID: 34042
		public const string __ObjectPath = "/Script/Engine.ScalarParameterValue";

		// Token: 0x040084FB RID: 34043
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040084FC RID: 34044
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x040084FD RID: 34045
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x040084FE RID: 34046
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x040084FF RID: 34047
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
