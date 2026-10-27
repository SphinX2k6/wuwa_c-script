using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025CB RID: 9675
	[UnrealObjectPath("/Script/Niagara.NiagaraPlatformSetCVarCondition")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraPlatformSetCVarCondition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F5F RID: 147295 RVA: 0x00352FAA File Offset: 0x003511AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraPlatformSetCVarCondition._ScriptStructPtr != 0) ? FNiagaraPlatformSetCVarCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraPlatformSetCVarCondition", ref FNiagaraPlatformSetCVarCondition._ScriptStructPtr);
		}

		// Token: 0x17008A46 RID: 35398
		// (get) Token: 0x06023F60 RID: 147296 RVA: 0x00352FCE File Offset: 0x003511CE
		// (set) Token: 0x06023F61 RID: 147297 RVA: 0x00352FE2 File Offset: 0x003511E2
		public unsafe FName CVarName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_CVarName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_CVarName) = value;
			}
		}

		// Token: 0x17008A47 RID: 35399
		// (get) Token: 0x06023F62 RID: 147298 RVA: 0x00352FF7 File Offset: 0x003511F7
		// (set) Token: 0x06023F63 RID: 147299 RVA: 0x00353007 File Offset: 0x00351207
		public unsafe bool Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_Value) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_Value) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008A48 RID: 35400
		// (get) Token: 0x06023F64 RID: 147300 RVA: 0x00353018 File Offset: 0x00351218
		// (set) Token: 0x06023F65 RID: 147301 RVA: 0x00353028 File Offset: 0x00351228
		public unsafe int MinInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MinInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MinInt) = value;
			}
		}

		// Token: 0x17008A49 RID: 35401
		// (get) Token: 0x06023F66 RID: 147302 RVA: 0x00353039 File Offset: 0x00351239
		// (set) Token: 0x06023F67 RID: 147303 RVA: 0x00353049 File Offset: 0x00351249
		public unsafe int MaxInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MaxInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MaxInt) = value;
			}
		}

		// Token: 0x17008A4A RID: 35402
		// (get) Token: 0x06023F68 RID: 147304 RVA: 0x0035305A File Offset: 0x0035125A
		// (set) Token: 0x06023F69 RID: 147305 RVA: 0x0035306A File Offset: 0x0035126A
		public unsafe float MinFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MinFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MinFloat) = value;
			}
		}

		// Token: 0x17008A4B RID: 35403
		// (get) Token: 0x06023F6A RID: 147306 RVA: 0x0035307B File Offset: 0x0035127B
		// (set) Token: 0x06023F6B RID: 147307 RVA: 0x0035308B File Offset: 0x0035128B
		public unsafe float MaxFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MaxFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_MaxFloat) = value;
			}
		}

		// Token: 0x17008A4C RID: 35404
		// (get) Token: 0x06023F6C RID: 147308 RVA: 0x0035309C File Offset: 0x0035129C
		// (set) Token: 0x06023F6D RID: 147309 RVA: 0x003530B5 File Offset: 0x003512B5
		public unsafe bool bUseMinInt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinInt) & FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinInt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinInt) = ((*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinInt) & ~FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinInt) | (value ? FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinInt : 0));
			}
		}

		// Token: 0x17008A4D RID: 35405
		// (get) Token: 0x06023F6E RID: 147310 RVA: 0x003530E5 File Offset: 0x003512E5
		// (set) Token: 0x06023F6F RID: 147311 RVA: 0x003530FE File Offset: 0x003512FE
		public unsafe bool bUseMaxInt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxInt) & FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxInt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxInt) = ((*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxInt) & ~FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxInt) | (value ? FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxInt : 0));
			}
		}

		// Token: 0x17008A4E RID: 35406
		// (get) Token: 0x06023F70 RID: 147312 RVA: 0x0035312E File Offset: 0x0035132E
		// (set) Token: 0x06023F71 RID: 147313 RVA: 0x00353147 File Offset: 0x00351347
		public unsafe bool bUseMinFloat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinFloat) & FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinFloat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinFloat) = ((*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMinFloat) & ~FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinFloat) | (value ? FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMinFloat : 0));
			}
		}

		// Token: 0x17008A4F RID: 35407
		// (get) Token: 0x06023F72 RID: 147314 RVA: 0x00353177 File Offset: 0x00351377
		// (set) Token: 0x06023F73 RID: 147315 RVA: 0x00353190 File Offset: 0x00351390
		public unsafe bool bUseMaxFloat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxFloat) & FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxFloat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxFloat) = ((*(base.NativePtr + (IntPtr)FNiagaraPlatformSetCVarCondition.__PropertyOffset_bUseMaxFloat) & ~FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxFloat) | (value ? FNiagaraPlatformSetCVarCondition.__PropertyMask_bUseMaxFloat : 0));
			}
		}

		// Token: 0x06023F74 RID: 147316 RVA: 0x003531C0 File Offset: 0x003513C0
		public FNiagaraPlatformSetCVarCondition()
		{
		}

		// Token: 0x06023F75 RID: 147317 RVA: 0x003531C8 File Offset: 0x003513C8
		public FNiagaraPlatformSetCVarCondition(FName CVarName, bool Value, int MinInt, int MaxInt, float MinFloat, float MaxFloat, bool bUseMinInt, bool bUseMaxInt, bool bUseMinFloat, bool bUseMaxFloat)
		{
			this.CVarName = CVarName;
			this.Value = Value;
			this.MinInt = MinInt;
			this.MaxInt = MaxInt;
			this.MinFloat = MinFloat;
			this.MaxFloat = MaxFloat;
			this.bUseMinInt = bUseMinInt;
			this.bUseMaxInt = bUseMaxInt;
			this.bUseMinFloat = bUseMinFloat;
			this.bUseMaxFloat = bUseMaxFloat;
		}

		// Token: 0x06023F76 RID: 147318 RVA: 0x00353228 File Offset: 0x00351428
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraPlatformSetCVarCondition.StaticStruct();
		}

		// Token: 0x06023F77 RID: 147319 RVA: 0x00353234 File Offset: 0x00351434
		[NullableContext(2)]
		public FNiagaraPlatformSetCVarCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F78 RID: 147320 RVA: 0x0035323E File Offset: 0x0035143E
		public FNiagaraPlatformSetCVarCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F79 RID: 147321 RVA: 0x00353249 File Offset: 0x00351449
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraPlatformSetCVarCondition(Pointer, false, true);
		}

		// Token: 0x06023F7A RID: 147322 RVA: 0x00353253 File Offset: 0x00351453
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraPlatformSetCVarCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04013477 RID: 78967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraPlatformSetCVarCondition";

		// Token: 0x04013478 RID: 78968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013479 RID: 78969
		internal static int __PropertyOffset_CVarName;

		// Token: 0x0401347A RID: 78970
		internal static int __PropertyOffset_Value;

		// Token: 0x0401347B RID: 78971
		internal static int __PropertyOffset_MinInt;

		// Token: 0x0401347C RID: 78972
		internal static int __PropertyOffset_MaxInt;

		// Token: 0x0401347D RID: 78973
		internal static int __PropertyOffset_MinFloat;

		// Token: 0x0401347E RID: 78974
		internal static int __PropertyOffset_MaxFloat;

		// Token: 0x0401347F RID: 78975
		internal static int __PropertyOffset_bUseMinInt;

		// Token: 0x04013480 RID: 78976
		internal static byte __PropertyMask_bUseMinInt;

		// Token: 0x04013481 RID: 78977
		internal static int __PropertyOffset_bUseMaxInt;

		// Token: 0x04013482 RID: 78978
		internal static byte __PropertyMask_bUseMaxInt;

		// Token: 0x04013483 RID: 78979
		internal static int __PropertyOffset_bUseMinFloat;

		// Token: 0x04013484 RID: 78980
		internal static byte __PropertyMask_bUseMinFloat;

		// Token: 0x04013485 RID: 78981
		internal static int __PropertyOffset_bUseMaxFloat;

		// Token: 0x04013486 RID: 78982
		internal static byte __PropertyMask_bUseMaxFloat;
	}
}
