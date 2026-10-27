using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AD2 RID: 2770
	[UnrealObjectPath("/Script/Engine.EmitterDynamicParameter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FEmitterDynamicParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600902C RID: 36908 RVA: 0x000CE551 File Offset: 0x000CC751
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterDynamicParameter._ScriptStructPtr != 0) ? FEmitterDynamicParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EmitterDynamicParameter", ref FEmitterDynamicParameter._ScriptStructPtr);
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600902D RID: 36909 RVA: 0x000CE575 File Offset: 0x000CC775
		// (set) Token: 0x0600902E RID: 36910 RVA: 0x000CE589 File Offset: 0x000CC789
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x000CE59E File Offset: 0x000CC79E
		// (set) Token: 0x06009030 RID: 36912 RVA: 0x000CE5B7 File Offset: 0x000CC7B7
		public unsafe bool bUseEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bUseEmitterTime) & FEmitterDynamicParameter.__PropertyMask_bUseEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bUseEmitterTime) = ((*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bUseEmitterTime) & ~FEmitterDynamicParameter.__PropertyMask_bUseEmitterTime) | (value ? FEmitterDynamicParameter.__PropertyMask_bUseEmitterTime : 0));
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x000CE5E7 File Offset: 0x000CC7E7
		// (set) Token: 0x06009032 RID: 36914 RVA: 0x000CE600 File Offset: 0x000CC800
		public unsafe bool bSpawnTimeOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bSpawnTimeOnly) & FEmitterDynamicParameter.__PropertyMask_bSpawnTimeOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bSpawnTimeOnly) = ((*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bSpawnTimeOnly) & ~FEmitterDynamicParameter.__PropertyMask_bSpawnTimeOnly) | (value ? FEmitterDynamicParameter.__PropertyMask_bSpawnTimeOnly : 0));
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06009033 RID: 36915 RVA: 0x000CE630 File Offset: 0x000CC830
		// (set) Token: 0x06009034 RID: 36916 RVA: 0x000CE644 File Offset: 0x000CC844
		public unsafe TEnumAsByte<EEmitterDynamicParameterValue> ValueMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ValueMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ValueMethod) = value;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06009035 RID: 36917 RVA: 0x000CE659 File Offset: 0x000CC859
		// (set) Token: 0x06009036 RID: 36918 RVA: 0x000CE672 File Offset: 0x000CC872
		public unsafe bool bScaleVelocityByParamValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bScaleVelocityByParamValue) & FEmitterDynamicParameter.__PropertyMask_bScaleVelocityByParamValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bScaleVelocityByParamValue) = ((*(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_bScaleVelocityByParamValue) & ~FEmitterDynamicParameter.__PropertyMask_bScaleVelocityByParamValue) | (value ? FEmitterDynamicParameter.__PropertyMask_bScaleVelocityByParamValue : 0));
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06009037 RID: 36919 RVA: 0x000CE6A4 File Offset: 0x000CC8A4
		// (set) Token: 0x06009038 RID: 36920 RVA: 0x000CE6E7 File Offset: 0x000CC8E7
		[Nullable(1)]
		public FRawDistributionFloat ParamValue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._ParamValue) == null)
				{
					result = (this._ParamValue = new FRawDistributionFloat(base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ParamValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)FEmitterDynamicParameter.__PropertyOffset_ParamValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x000CE708 File Offset: 0x000CC908
		public FEmitterDynamicParameter()
		{
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x000CE710 File Offset: 0x000CC910
		public FEmitterDynamicParameter(FName ParamName, bool bUseEmitterTime, bool bSpawnTimeOnly, TEnumAsByte<EEmitterDynamicParameterValue> ValueMethod, bool bScaleVelocityByParamValue, [Nullable(1)] FRawDistributionFloat ParamValue)
		{
			this.ParamName = ParamName;
			this.bUseEmitterTime = bUseEmitterTime;
			this.bSpawnTimeOnly = bSpawnTimeOnly;
			this.ValueMethod = ValueMethod;
			this.bScaleVelocityByParamValue = bScaleVelocityByParamValue;
			this.ParamValue = ParamValue;
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x000CE745 File Offset: 0x000CC945
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterDynamicParameter.StaticStruct();
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x000CE751 File Offset: 0x000CC951
		[NullableContext(2)]
		public FEmitterDynamicParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x000CE75B File Offset: 0x000CC95B
		public FEmitterDynamicParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x000CE766 File Offset: 0x000CC966
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterDynamicParameter(Pointer, false, true);
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x000CE770 File Offset: 0x000CC970
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterDynamicParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04004AC8 RID: 19144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EmitterDynamicParameter";

		// Token: 0x04004AC9 RID: 19145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004ACA RID: 19146
		internal static int __PropertyOffset_ParamName;

		// Token: 0x04004ACB RID: 19147
		internal static int __PropertyOffset_bUseEmitterTime;

		// Token: 0x04004ACC RID: 19148
		internal static byte __PropertyMask_bUseEmitterTime;

		// Token: 0x04004ACD RID: 19149
		internal static int __PropertyOffset_bSpawnTimeOnly;

		// Token: 0x04004ACE RID: 19150
		internal static byte __PropertyMask_bSpawnTimeOnly;

		// Token: 0x04004ACF RID: 19151
		internal static int __PropertyOffset_ValueMethod;

		// Token: 0x04004AD0 RID: 19152
		internal static int __PropertyOffset_bScaleVelocityByParamValue;

		// Token: 0x04004AD1 RID: 19153
		internal static byte __PropertyMask_bScaleVelocityByParamValue;

		// Token: 0x04004AD2 RID: 19154
		internal static int __PropertyOffset_ParamValue;

		// Token: 0x04004AD3 RID: 19155
		[Nullable(2)]
		private FRawDistributionFloat _ParamValue;
	}
}
