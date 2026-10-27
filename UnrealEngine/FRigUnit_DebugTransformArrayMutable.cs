using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000590 RID: 1424
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugTransformArrayMutable")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_DebugTransformArrayMutable : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C3D RID: 19517 RVA: 0x00070D54 File Offset: 0x0006EF54
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugTransformArrayMutable._ScriptStructPtr != 0) ? FRigUnit_DebugTransformArrayMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugTransformArrayMutable", ref FRigUnit_DebugTransformArrayMutable._ScriptStructPtr);
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x00070D78 File Offset: 0x0006EF78
		// (set) Token: 0x06004C3F RID: 19519 RVA: 0x00070DBB File Offset: 0x0006EFBB
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x00070DC9 File Offset: 0x0006EFC9
		// (set) Token: 0x06004C41 RID: 19521 RVA: 0x00070DD9 File Offset: 0x0006EFD9
		public unsafe ERigUnitDebugTransformMode Mode
		{
			get
			{
				return (ERigUnitDebugTransformMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x00070DEA File Offset: 0x0006EFEA
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x00070DFE File Offset: 0x0006EFFE
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x00070E13 File Offset: 0x0006F013
		// (set) Token: 0x06004C45 RID: 19525 RVA: 0x00070E23 File Offset: 0x0006F023
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00070E34 File Offset: 0x0006F034
		// (set) Token: 0x06004C47 RID: 19527 RVA: 0x00070E44 File Offset: 0x0006F044
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x00070E55 File Offset: 0x0006F055
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x00070E69 File Offset: 0x0006F069
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x00070E7E File Offset: 0x0006F07E
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x00070E92 File Offset: 0x0006F092
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x00070EA7 File Offset: 0x0006F0A7
		// (set) Token: 0x06004C4D RID: 19533 RVA: 0x00070EB7 File Offset: 0x0006F0B7
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x00070EC8 File Offset: 0x0006F0C8
		// (set) Token: 0x06004C4F RID: 19535 RVA: 0x00070F0B File Offset: 0x0006F10B
		public FRigUnit_DebugTransformArrayMutable_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_DebugTransformArrayMutable_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_DebugTransformArrayMutable_WorkData(base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_DebugTransformArrayMutable_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugTransformArrayMutable.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00070F2C File Offset: 0x0006F12C
		public FRigUnit_DebugTransformArrayMutable()
		{
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x00070F34 File Offset: 0x0006F134
		public FRigUnit_DebugTransformArrayMutable(TArray<FTransform> Transforms, ERigUnitDebugTransformMode Mode, FLinearColor Color, float Thickness, float Scale, FName Space, FTransform WorldOffset, bool bEnabled, FRigUnit_DebugTransformArrayMutable_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Transforms = Transforms;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x00070F94 File Offset: 0x0006F194
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugTransformArrayMutable.StaticStruct();
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00070FA0 File Offset: 0x0006F1A0
		[NullableContext(2)]
		public FRigUnit_DebugTransformArrayMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x00070FAA File Offset: 0x0006F1AA
		public FRigUnit_DebugTransformArrayMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00070FB5 File Offset: 0x0006F1B5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugTransformArrayMutable(Pointer, false, true);
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x00070FBF File Offset: 0x0006F1BF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugTransformArrayMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040024E5 RID: 9445
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugTransformArrayMutable";

		// Token: 0x040024E6 RID: 9446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024E7 RID: 9447
		internal static int __PropertyOffset_Transforms;

		// Token: 0x040024E8 RID: 9448
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x040024E9 RID: 9449
		internal static int __PropertyOffset_Mode;

		// Token: 0x040024EA RID: 9450
		internal static int __PropertyOffset_Color;

		// Token: 0x040024EB RID: 9451
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024EC RID: 9452
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024ED RID: 9453
		internal static int __PropertyOffset_Space;

		// Token: 0x040024EE RID: 9454
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024EF RID: 9455
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040024F0 RID: 9456
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040024F1 RID: 9457
		[Nullable(2)]
		private FRigUnit_DebugTransformArrayMutable_WorkData _WorkData;
	}
}
