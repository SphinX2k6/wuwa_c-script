using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000517 RID: 1303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigControl")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 768)]
	public class FRigControl : FRigElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004419 RID: 17433 RVA: 0x0006575A File Offset: 0x0006395A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigControl._ScriptStructPtr != 0) ? FRigControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigControl", ref FRigControl._ScriptStructPtr);
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600441A RID: 17434 RVA: 0x0006577E File Offset: 0x0006397E
		// (set) Token: 0x0600441B RID: 17435 RVA: 0x0006578E File Offset: 0x0006398E
		public unsafe ERigControlType ControlType
		{
			get
			{
				return (ERigControlType)(*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ControlType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ControlType) = (byte)value;
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600441C RID: 17436 RVA: 0x0006579F File Offset: 0x0006399F
		// (set) Token: 0x0600441D RID: 17437 RVA: 0x000657B3 File Offset: 0x000639B3
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600441E RID: 17438 RVA: 0x000657C8 File Offset: 0x000639C8
		// (set) Token: 0x0600441F RID: 17439 RVA: 0x000657DC File Offset: 0x000639DC
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x000657F1 File Offset: 0x000639F1
		// (set) Token: 0x06004421 RID: 17441 RVA: 0x00065801 File Offset: 0x00063A01
		public unsafe int ParentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ParentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_ParentIndex) = value;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x00065812 File Offset: 0x00063A12
		// (set) Token: 0x06004423 RID: 17443 RVA: 0x00065826 File Offset: 0x00063A26
		public unsafe FName SpaceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_SpaceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_SpaceName) = value;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x0006583B File Offset: 0x00063A3B
		// (set) Token: 0x06004425 RID: 17445 RVA: 0x0006584B File Offset: 0x00063A4B
		public unsafe int SpaceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_SpaceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_SpaceIndex) = value;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x0006585C File Offset: 0x00063A5C
		// (set) Token: 0x06004427 RID: 17447 RVA: 0x00065870 File Offset: 0x00063A70
		public unsafe FTransform OffsetTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_OffsetTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_OffsetTransform) = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x00065888 File Offset: 0x00063A88
		// (set) Token: 0x06004429 RID: 17449 RVA: 0x000658CB File Offset: 0x00063ACB
		public FRigControlValue InitialValue
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlValue result;
				if ((result = this._InitialValue) == null)
				{
					result = (this._InitialValue = new FRigControlValue(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_InitialValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlValue.StaticStruct(), base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_InitialValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x000658EC File Offset: 0x00063AEC
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x0006592F File Offset: 0x00063B2F
		public FRigControlValue Value
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlValue result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FRigControlValue(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlValue.StaticStruct(), base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x00065950 File Offset: 0x00063B50
		// (set) Token: 0x0600442D RID: 17453 RVA: 0x00065960 File Offset: 0x00063B60
		public unsafe ERigControlAxis PrimaryAxis
		{
			get
			{
				return (ERigControlAxis)(*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_PrimaryAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_PrimaryAxis) = (byte)value;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x00065971 File Offset: 0x00063B71
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x00065981 File Offset: 0x00063B81
		public unsafe bool bIsCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bIsCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bIsCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x00065992 File Offset: 0x00063B92
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x000659A2 File Offset: 0x00063BA2
		public unsafe bool bAnimatable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bAnimatable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bAnimatable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x000659B3 File Offset: 0x00063BB3
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x000659C3 File Offset: 0x00063BC3
		public unsafe bool bLimitTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x000659D4 File Offset: 0x00063BD4
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x000659E4 File Offset: 0x00063BE4
		public unsafe bool bLimitRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x000659F5 File Offset: 0x00063BF5
		// (set) Token: 0x06004437 RID: 17463 RVA: 0x00065A05 File Offset: 0x00063C05
		public unsafe bool bLimitScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bLimitScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x00065A16 File Offset: 0x00063C16
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x00065A26 File Offset: 0x00063C26
		public unsafe bool bDrawLimits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bDrawLimits) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bDrawLimits) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x00065A38 File Offset: 0x00063C38
		// (set) Token: 0x0600443B RID: 17467 RVA: 0x00065A7B File Offset: 0x00063C7B
		public FRigControlValue MinimumValue
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlValue result;
				if ((result = this._MinimumValue) == null)
				{
					result = (this._MinimumValue = new FRigControlValue(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_MinimumValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlValue.StaticStruct(), base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_MinimumValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00065A9C File Offset: 0x00063C9C
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x00065ADF File Offset: 0x00063CDF
		public FRigControlValue MaximumValue
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlValue result;
				if ((result = this._MaximumValue) == null)
				{
					result = (this._MaximumValue = new FRigControlValue(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_MaximumValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlValue.StaticStruct(), base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_MaximumValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x00065B00 File Offset: 0x00063D00
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x00065B10 File Offset: 0x00063D10
		public unsafe bool bGizmoEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bGizmoEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bGizmoEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x00065B21 File Offset: 0x00063D21
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x00065B31 File Offset: 0x00063D31
		public unsafe bool bGizmoVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bGizmoVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bGizmoVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x00065B42 File Offset: 0x00063D42
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x00065B56 File Offset: 0x00063D56
		public unsafe FName GizmoName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoName) = value;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x00065B6B File Offset: 0x00063D6B
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x00065B7F File Offset: 0x00063D7F
		public unsafe FTransform GizmoTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoTransform) = value;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x00065B94 File Offset: 0x00063D94
		// (set) Token: 0x06004447 RID: 17479 RVA: 0x00065BA8 File Offset: 0x00063DA8
		public unsafe FLinearColor GizmoColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_GizmoColor) = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x00065BC0 File Offset: 0x00063DC0
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x00065C03 File Offset: 0x00063E03
		public TArray<int> Dependents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Dependents) == null)
				{
					result = (this._Dependents = new TArray<int>(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_Dependents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Dependents.CopyAssign(value);
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x00065C11 File Offset: 0x00063E11
		// (set) Token: 0x0600444B RID: 17483 RVA: 0x00065C21 File Offset: 0x00063E21
		public unsafe bool bIsTransientControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bIsTransientControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControl.__PropertyOffset_bIsTransientControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x00065C32 File Offset: 0x00063E32
		// (set) Token: 0x0600444D RID: 17485 RVA: 0x00065C46 File Offset: 0x00063E46
		[Nullable(2)]
		public unsafe UEnum ControlEnum
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + FRigControl.__PropertyOffset_ControlEnum);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRigControl.__PropertyOffset_ControlEnum, value);
			}
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00065C5B File Offset: 0x00063E5B
		public FRigControl()
		{
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00065C64 File Offset: 0x00063E64
		public FRigControl(ERigControlType ControlType, FName DisplayName, FName ParentName, int ParentIndex, FName SpaceName, int SpaceIndex, FTransform OffsetTransform, FRigControlValue InitialValue, FRigControlValue Value, ERigControlAxis PrimaryAxis, bool bIsCurve, bool bAnimatable, bool bLimitTranslation, bool bLimitRotation, bool bLimitScale, bool bDrawLimits, FRigControlValue MinimumValue, FRigControlValue MaximumValue, bool bGizmoEnabled, bool bGizmoVisible, FName GizmoName, FTransform GizmoTransform, FLinearColor GizmoColor, TArray<int> Dependents, bool bIsTransientControl, UEnum ControlEnum, FName Name, int Index)
		{
			this.ControlType = ControlType;
			this.DisplayName = DisplayName;
			this.ParentName = ParentName;
			this.ParentIndex = ParentIndex;
			this.SpaceName = SpaceName;
			this.SpaceIndex = SpaceIndex;
			this.OffsetTransform = OffsetTransform;
			this.InitialValue = InitialValue;
			this.Value = Value;
			this.PrimaryAxis = PrimaryAxis;
			this.bIsCurve = bIsCurve;
			this.bAnimatable = bAnimatable;
			this.bLimitTranslation = bLimitTranslation;
			this.bLimitRotation = bLimitRotation;
			this.bLimitScale = bLimitScale;
			this.bDrawLimits = bDrawLimits;
			this.MinimumValue = MinimumValue;
			this.MaximumValue = MaximumValue;
			this.bGizmoEnabled = bGizmoEnabled;
			this.bGizmoVisible = bGizmoVisible;
			this.GizmoName = GizmoName;
			this.GizmoTransform = GizmoTransform;
			this.GizmoColor = GizmoColor;
			this.Dependents = Dependents;
			this.bIsTransientControl = bIsTransientControl;
			this.ControlEnum = ControlEnum;
			base.Name = Name;
			base.Index = Index;
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00065D54 File Offset: 0x00063F54
		protected override IntPtr GetUStructPtr()
		{
			return FRigControl.StaticStruct();
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00065D60 File Offset: 0x00063F60
		[NullableContext(2)]
		public FRigControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00065D6A File Offset: 0x00063F6A
		public FRigControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00065D75 File Offset: 0x00063F75
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigControl(Pointer, false, true);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00065D7F File Offset: 0x00063F7F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigControl(Pointer, MemoryOwner);
		}

		// Token: 0x0400212F RID: 8495
		public new const string __ObjectPath = "/Script/ControlRig.RigControl";

		// Token: 0x04002130 RID: 8496
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002131 RID: 8497
		internal static int __PropertyOffset_ControlType;

		// Token: 0x04002132 RID: 8498
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04002133 RID: 8499
		internal static int __PropertyOffset_ParentName;

		// Token: 0x04002134 RID: 8500
		internal static int __PropertyOffset_ParentIndex;

		// Token: 0x04002135 RID: 8501
		internal static int __PropertyOffset_SpaceName;

		// Token: 0x04002136 RID: 8502
		internal static int __PropertyOffset_SpaceIndex;

		// Token: 0x04002137 RID: 8503
		internal static int __PropertyOffset_OffsetTransform;

		// Token: 0x04002138 RID: 8504
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x04002139 RID: 8505
		[Nullable(2)]
		private FRigControlValue _InitialValue;

		// Token: 0x0400213A RID: 8506
		internal static int __PropertyOffset_Value;

		// Token: 0x0400213B RID: 8507
		[Nullable(2)]
		private FRigControlValue _Value;

		// Token: 0x0400213C RID: 8508
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x0400213D RID: 8509
		internal static int __PropertyOffset_bIsCurve;

		// Token: 0x0400213E RID: 8510
		internal static int __PropertyOffset_bAnimatable;

		// Token: 0x0400213F RID: 8511
		internal static int __PropertyOffset_bLimitTranslation;

		// Token: 0x04002140 RID: 8512
		internal static int __PropertyOffset_bLimitRotation;

		// Token: 0x04002141 RID: 8513
		internal static int __PropertyOffset_bLimitScale;

		// Token: 0x04002142 RID: 8514
		internal static int __PropertyOffset_bDrawLimits;

		// Token: 0x04002143 RID: 8515
		internal static int __PropertyOffset_MinimumValue;

		// Token: 0x04002144 RID: 8516
		[Nullable(2)]
		private FRigControlValue _MinimumValue;

		// Token: 0x04002145 RID: 8517
		internal static int __PropertyOffset_MaximumValue;

		// Token: 0x04002146 RID: 8518
		[Nullable(2)]
		private FRigControlValue _MaximumValue;

		// Token: 0x04002147 RID: 8519
		internal static int __PropertyOffset_bGizmoEnabled;

		// Token: 0x04002148 RID: 8520
		internal static int __PropertyOffset_bGizmoVisible;

		// Token: 0x04002149 RID: 8521
		internal static int __PropertyOffset_GizmoName;

		// Token: 0x0400214A RID: 8522
		internal static int __PropertyOffset_GizmoTransform;

		// Token: 0x0400214B RID: 8523
		internal static int __PropertyOffset_GizmoColor;

		// Token: 0x0400214C RID: 8524
		internal static int __PropertyOffset_Dependents;

		// Token: 0x0400214D RID: 8525
		[Nullable(2)]
		private TArray<int> _Dependents;

		// Token: 0x0400214E RID: 8526
		internal static int __PropertyOffset_bIsTransientControl;

		// Token: 0x0400214F RID: 8527
		internal static int __PropertyOffset_ControlEnum;
	}
}
