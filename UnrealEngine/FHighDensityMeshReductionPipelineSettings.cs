using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027B5 RID: 10165
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.HighDensityMeshReductionPipelineSettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FHighDensityMeshReductionPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E40 RID: 155200 RVA: 0x0039717D File Offset: 0x0039537D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHighDensityMeshReductionPipelineSettings._ScriptStructPtr != 0) ? FHighDensityMeshReductionPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.HighDensityMeshReductionPipelineSettings", ref FHighDensityMeshReductionPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x1700920E RID: 37390
		// (get) Token: 0x06025E41 RID: 155201 RVA: 0x003971A4 File Offset: 0x003953A4
		// (set) Token: 0x06025E42 RID: 155202 RVA: 0x003971E7 File Offset: 0x003953E7
		public FHighDensityMeshReductionSettings HighDensityMeshReductionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FHighDensityMeshReductionSettings result;
				if ((result = this._HighDensityMeshReductionSettings) == null)
				{
					result = (this._HighDensityMeshReductionSettings = new FHighDensityMeshReductionSettings(base.NativePtr + (IntPtr)FHighDensityMeshReductionPipelineSettings.__PropertyOffset_HighDensityMeshReductionSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHighDensityMeshReductionSettings.StaticStruct(), base.NativePtr + (IntPtr)FHighDensityMeshReductionPipelineSettings.__PropertyOffset_HighDensityMeshReductionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025E43 RID: 155203 RVA: 0x00397208 File Offset: 0x00395408
		public FHighDensityMeshReductionPipelineSettings()
		{
		}

		// Token: 0x06025E44 RID: 155204 RVA: 0x00397210 File Offset: 0x00395410
		public FHighDensityMeshReductionPipelineSettings(FHighDensityMeshReductionSettings HighDensityMeshReductionSettings)
		{
			this.HighDensityMeshReductionSettings = HighDensityMeshReductionSettings;
		}

		// Token: 0x06025E45 RID: 155205 RVA: 0x0039721F File Offset: 0x0039541F
		protected override IntPtr GetUStructPtr()
		{
			return FHighDensityMeshReductionPipelineSettings.StaticStruct();
		}

		// Token: 0x06025E46 RID: 155206 RVA: 0x0039722B File Offset: 0x0039542B
		[NullableContext(2)]
		public FHighDensityMeshReductionPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E47 RID: 155207 RVA: 0x00397235 File Offset: 0x00395435
		public FHighDensityMeshReductionPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E48 RID: 155208 RVA: 0x00397240 File Offset: 0x00395440
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHighDensityMeshReductionPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025E49 RID: 155209 RVA: 0x0039724A File Offset: 0x0039544A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHighDensityMeshReductionPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AE0 RID: 84704
		public new const string __ObjectPath = "/Script/SimplygonUObjects.HighDensityMeshReductionPipelineSettings";

		// Token: 0x04014AE1 RID: 84705
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AE2 RID: 84706
		internal static int __PropertyOffset_HighDensityMeshReductionSettings;

		// Token: 0x04014AE3 RID: 84707
		[Nullable(2)]
		private FHighDensityMeshReductionSettings _HighDensityMeshReductionSettings;
	}
}
