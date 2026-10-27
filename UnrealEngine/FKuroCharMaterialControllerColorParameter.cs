using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC1 RID: 6849
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorParameter")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FKuroCharMaterialControllerColorParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019714 RID: 104212 RVA: 0x00259BE5 File Offset: 0x00257DE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharMaterialControllerColorParameter._ScriptStructPtr != 0) ? FKuroCharMaterialControllerColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorParameter", ref FKuroCharMaterialControllerColorParameter._ScriptStructPtr);
		}

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x06019715 RID: 104213 RVA: 0x00259C09 File Offset: 0x00257E09
		// (set) Token: 0x06019716 RID: 104214 RVA: 0x00259C1D File Offset: 0x00257E1D
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x06019717 RID: 104215 RVA: 0x00259C34 File Offset: 0x00257E34
		// (set) Token: 0x06019718 RID: 104216 RVA: 0x00259C77 File Offset: 0x00257E77
		public FKuroCurveLinearColor ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorParameter.__PropertyOffset_ParameterValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorParameter.__PropertyOffset_ParameterValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019719 RID: 104217 RVA: 0x00259C98 File Offset: 0x00257E98
		public FKuroCharMaterialControllerColorParameter()
		{
		}

		// Token: 0x0601971A RID: 104218 RVA: 0x00259CA0 File Offset: 0x00257EA0
		public FKuroCharMaterialControllerColorParameter(FName ParameterName, FKuroCurveLinearColor ParameterValue)
		{
			this.ParameterName = ParameterName;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x0601971B RID: 104219 RVA: 0x00259CB6 File Offset: 0x00257EB6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharMaterialControllerColorParameter.StaticStruct();
		}

		// Token: 0x0601971C RID: 104220 RVA: 0x00259CC2 File Offset: 0x00257EC2
		[NullableContext(2)]
		public FKuroCharMaterialControllerColorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601971D RID: 104221 RVA: 0x00259CCC File Offset: 0x00257ECC
		public FKuroCharMaterialControllerColorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601971E RID: 104222 RVA: 0x00259CD7 File Offset: 0x00257ED7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharMaterialControllerColorParameter(Pointer, false, true);
		}

		// Token: 0x0601971F RID: 104223 RVA: 0x00259CE1 File Offset: 0x00257EE1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharMaterialControllerColorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDAD RID: 56749
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorParameter";

		// Token: 0x0400DDAE RID: 56750
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDAF RID: 56751
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400DDB0 RID: 56752
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x0400DDB1 RID: 56753
		[Nullable(2)]
		private FKuroCurveLinearColor _ParameterValue;
	}
}
