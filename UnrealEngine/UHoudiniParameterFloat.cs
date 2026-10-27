using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014EE RID: 5358
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterFloat")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UHoudiniParameterFloat : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013697 RID: 79511 RVA: 0x001C8AC4 File Offset: 0x001C6CC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterFloat._ClassPtr;
		}

		// Token: 0x06013698 RID: 79512 RVA: 0x001C8AD0 File Offset: 0x001C6CD0
		public UHoudiniParameterFloat() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013699 RID: 79513 RVA: 0x001C8AF8 File Offset: 0x001C6CF8
		public UHoudiniParameterFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x0601369A RID: 79514 RVA: 0x001C8B2C File Offset: 0x001C6D2C
		// (set) Token: 0x0601369B RID: 79515 RVA: 0x001C8B65 File Offset: 0x001C6D65
		public TArray<float> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x0601369C RID: 79516 RVA: 0x001C8B74 File Offset: 0x001C6D74
		// (set) Token: 0x0601369D RID: 79517 RVA: 0x001C8BAD File Offset: 0x001C6DAD
		public TArray<float> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x0601369E RID: 79518 RVA: 0x001C8BBB File Offset: 0x001C6DBB
		// (set) Token: 0x0601369F RID: 79519 RVA: 0x001C8BCF File Offset: 0x001C6DCF
		public unsafe string Unit
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterFloat.__PropertyOffset_Unit)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterFloat.__PropertyOffset_Unit)), value);
			}
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x060136A0 RID: 79520 RVA: 0x001C8BE4 File Offset: 0x001C6DE4
		// (set) Token: 0x060136A1 RID: 79521 RVA: 0x001C8BF4 File Offset: 0x001C6DF4
		public unsafe bool bNoSwap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bNoSwap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bNoSwap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x060136A2 RID: 79522 RVA: 0x001C8C05 File Offset: 0x001C6E05
		// (set) Token: 0x060136A3 RID: 79523 RVA: 0x001C8C15 File Offset: 0x001C6E15
		public unsafe bool bHasMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasMin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasMin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x060136A4 RID: 79524 RVA: 0x001C8C26 File Offset: 0x001C6E26
		// (set) Token: 0x060136A5 RID: 79525 RVA: 0x001C8C36 File Offset: 0x001C6E36
		public unsafe bool bHasMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x060136A6 RID: 79526 RVA: 0x001C8C47 File Offset: 0x001C6E47
		// (set) Token: 0x060136A7 RID: 79527 RVA: 0x001C8C57 File Offset: 0x001C6E57
		public unsafe bool bHasUIMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasUIMin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasUIMin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x060136A8 RID: 79528 RVA: 0x001C8C68 File Offset: 0x001C6E68
		// (set) Token: 0x060136A9 RID: 79529 RVA: 0x001C8C78 File Offset: 0x001C6E78
		public unsafe bool bHasUIMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasUIMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bHasUIMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x060136AA RID: 79530 RVA: 0x001C8C89 File Offset: 0x001C6E89
		// (set) Token: 0x060136AB RID: 79531 RVA: 0x001C8C99 File Offset: 0x001C6E99
		public unsafe bool bIsLogarithmic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bIsLogarithmic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bIsLogarithmic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x060136AC RID: 79532 RVA: 0x001C8CAA File Offset: 0x001C6EAA
		// (set) Token: 0x060136AD RID: 79533 RVA: 0x001C8CBA File Offset: 0x001C6EBA
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x060136AE RID: 79534 RVA: 0x001C8CCB File Offset: 0x001C6ECB
		// (set) Token: 0x060136AF RID: 79535 RVA: 0x001C8CDB File Offset: 0x001C6EDB
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x060136B0 RID: 79536 RVA: 0x001C8CEC File Offset: 0x001C6EEC
		// (set) Token: 0x060136B1 RID: 79537 RVA: 0x001C8CFC File Offset: 0x001C6EFC
		public unsafe float UIMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_UIMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_UIMin) = value;
			}
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x060136B2 RID: 79538 RVA: 0x001C8D0D File Offset: 0x001C6F0D
		// (set) Token: 0x060136B3 RID: 79539 RVA: 0x001C8D1D File Offset: 0x001C6F1D
		public unsafe float UIMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_UIMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_UIMax) = value;
			}
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x060136B4 RID: 79540 RVA: 0x001C8D2E File Offset: 0x001C6F2E
		// (set) Token: 0x060136B5 RID: 79541 RVA: 0x001C8D3E File Offset: 0x001C6F3E
		public unsafe bool bIsChildOfRamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bIsChildOfRamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFloat.__PropertyOffset_bIsChildOfRamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x060136B6 RID: 79542 RVA: 0x001C8D4F File Offset: 0x001C6F4F
		static UHoudiniParameterFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterFloat");
		}

		// Token: 0x060136B7 RID: 79543 RVA: 0x001C8D5D File Offset: 0x001C6F5D
		protected UHoudiniParameterFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7D4 RID: 42964
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterFloat";

		// Token: 0x0400A7D5 RID: 42965
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7D6 RID: 42966
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7D7 RID: 42967
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A7D8 RID: 42968
		[Nullable(2)]
		private TArray<float> _Values;

		// Token: 0x0400A7D9 RID: 42969
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A7DA RID: 42970
		[Nullable(2)]
		private TArray<float> _DefaultValues;

		// Token: 0x0400A7DB RID: 42971
		internal static int __PropertyOffset_Unit;

		// Token: 0x0400A7DC RID: 42972
		internal static int __PropertyOffset_bNoSwap;

		// Token: 0x0400A7DD RID: 42973
		internal static int __PropertyOffset_bHasMin;

		// Token: 0x0400A7DE RID: 42974
		internal static int __PropertyOffset_bHasMax;

		// Token: 0x0400A7DF RID: 42975
		internal static int __PropertyOffset_bHasUIMin;

		// Token: 0x0400A7E0 RID: 42976
		internal static int __PropertyOffset_bHasUIMax;

		// Token: 0x0400A7E1 RID: 42977
		internal static int __PropertyOffset_bIsLogarithmic;

		// Token: 0x0400A7E2 RID: 42978
		internal static int __PropertyOffset_Min;

		// Token: 0x0400A7E3 RID: 42979
		internal static int __PropertyOffset_Max;

		// Token: 0x0400A7E4 RID: 42980
		internal static int __PropertyOffset_UIMin;

		// Token: 0x0400A7E5 RID: 42981
		internal static int __PropertyOffset_UIMax;

		// Token: 0x0400A7E6 RID: 42982
		internal static int __PropertyOffset_bIsChildOfRamp;
	}
}
