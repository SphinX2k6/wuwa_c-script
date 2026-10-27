using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC3 RID: 6851
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatParameter")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FKuroCharMaterialControllerFloatParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601972E RID: 104238 RVA: 0x00259E95 File Offset: 0x00258095
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharMaterialControllerFloatParameter._ScriptStructPtr != 0) ? FKuroCharMaterialControllerFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatParameter", ref FKuroCharMaterialControllerFloatParameter._ScriptStructPtr);
		}

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x0601972F RID: 104239 RVA: 0x00259EB9 File Offset: 0x002580B9
		// (set) Token: 0x06019730 RID: 104240 RVA: 0x00259ECD File Offset: 0x002580CD
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x06019731 RID: 104241 RVA: 0x00259EE4 File Offset: 0x002580E4
		// (set) Token: 0x06019732 RID: 104242 RVA: 0x00259F27 File Offset: 0x00258127
		public FKuroCurveFloat ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatParameter.__PropertyOffset_ParameterValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatParameter.__PropertyOffset_ParameterValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019733 RID: 104243 RVA: 0x00259F48 File Offset: 0x00258148
		public FKuroCharMaterialControllerFloatParameter()
		{
		}

		// Token: 0x06019734 RID: 104244 RVA: 0x00259F50 File Offset: 0x00258150
		public FKuroCharMaterialControllerFloatParameter(FName ParameterName, FKuroCurveFloat ParameterValue)
		{
			this.ParameterName = ParameterName;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x06019735 RID: 104245 RVA: 0x00259F66 File Offset: 0x00258166
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharMaterialControllerFloatParameter.StaticStruct();
		}

		// Token: 0x06019736 RID: 104246 RVA: 0x00259F72 File Offset: 0x00258172
		[NullableContext(2)]
		public FKuroCharMaterialControllerFloatParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019737 RID: 104247 RVA: 0x00259F7C File Offset: 0x0025817C
		public FKuroCharMaterialControllerFloatParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019738 RID: 104248 RVA: 0x00259F87 File Offset: 0x00258187
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharMaterialControllerFloatParameter(Pointer, false, true);
		}

		// Token: 0x06019739 RID: 104249 RVA: 0x00259F91 File Offset: 0x00258191
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharMaterialControllerFloatParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDBA RID: 56762
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatParameter";

		// Token: 0x0400DDBB RID: 56763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDBC RID: 56764
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400DDBD RID: 56765
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x0400DDBE RID: 56766
		[Nullable(2)]
		private FKuroCurveFloat _ParameterValue;
	}
}
