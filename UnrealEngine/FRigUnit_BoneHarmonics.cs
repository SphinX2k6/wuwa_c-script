using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000555 RID: 1365
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BoneHarmonics")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_BoneHarmonics : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600482B RID: 18475 RVA: 0x0006B037 File Offset: 0x00069237
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BoneHarmonics._ScriptStructPtr != 0) ? FRigUnit_BoneHarmonics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BoneHarmonics", ref FRigUnit_BoneHarmonics._ScriptStructPtr);
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0006B05C File Offset: 0x0006925C
		// (set) Token: 0x0600482D RID: 18477 RVA: 0x0006B09F File Offset: 0x0006929F
		public TArray<FRigUnit_BoneHarmonics_BoneTarget> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_BoneHarmonics_BoneTarget> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FRigUnit_BoneHarmonics_BoneTarget>(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_Bones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x0006B0AD File Offset: 0x000692AD
		// (set) Token: 0x0600482F RID: 18479 RVA: 0x0006B0C1 File Offset: 0x000692C1
		public unsafe FVector WaveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveSpeed) = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x0006B0D6 File Offset: 0x000692D6
		// (set) Token: 0x06004831 RID: 18481 RVA: 0x0006B0EA File Offset: 0x000692EA
		public unsafe FVector WaveFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveFrequency) = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x0006B0FF File Offset: 0x000692FF
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x0006B113 File Offset: 0x00069313
		public unsafe FVector WaveAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveAmplitude) = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x0006B128 File Offset: 0x00069328
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x0006B13C File Offset: 0x0006933C
		public unsafe FVector WaveOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveOffset) = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x0006B151 File Offset: 0x00069351
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x0006B165 File Offset: 0x00069365
		public unsafe FVector WaveNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveNoise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveNoise) = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x0006B17A File Offset: 0x0006937A
		// (set) Token: 0x06004839 RID: 18489 RVA: 0x0006B18A File Offset: 0x0006938A
		public unsafe EControlRigAnimEasingType WaveEase
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveEase) = (byte)value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0006B19B File Offset: 0x0006939B
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x0006B1AB File Offset: 0x000693AB
		public unsafe float WaveMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveMinimum) = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x0006B1BC File Offset: 0x000693BC
		// (set) Token: 0x0600483D RID: 18493 RVA: 0x0006B1CC File Offset: 0x000693CC
		public unsafe float WaveMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WaveMaximum) = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x0006B1DD File Offset: 0x000693DD
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x0006B1ED File Offset: 0x000693ED
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x0006B1FE File Offset: 0x000693FE
		// (set) Token: 0x06004841 RID: 18497 RVA: 0x0006B20E File Offset: 0x0006940E
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x0006B220 File Offset: 0x00069420
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x0006B263 File Offset: 0x00069463
		public FRigUnit_BoneHarmonics_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_BoneHarmonics_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_BoneHarmonics_WorkData(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_BoneHarmonics_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x0006B284 File Offset: 0x00069484
		public FRigUnit_BoneHarmonics()
		{
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x0006B28C File Offset: 0x0006948C
		public FRigUnit_BoneHarmonics(TArray<FRigUnit_BoneHarmonics_BoneTarget> Bones, FVector WaveSpeed, FVector WaveFrequency, FVector WaveAmplitude, FVector WaveOffset, FVector WaveNoise, EControlRigAnimEasingType WaveEase, float WaveMinimum, float WaveMaximum, EControlRigRotationOrder RotationOrder, bool bPropagateToChildren, FRigUnit_BoneHarmonics_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Bones = Bones;
			this.WaveSpeed = WaveSpeed;
			this.WaveFrequency = WaveFrequency;
			this.WaveAmplitude = WaveAmplitude;
			this.WaveOffset = WaveOffset;
			this.WaveNoise = WaveNoise;
			this.WaveEase = WaveEase;
			this.WaveMinimum = WaveMinimum;
			this.WaveMaximum = WaveMaximum;
			this.RotationOrder = RotationOrder;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x0006B304 File Offset: 0x00069504
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BoneHarmonics.StaticStruct();
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x0006B310 File Offset: 0x00069510
		[NullableContext(2)]
		public FRigUnit_BoneHarmonics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0006B31A File Offset: 0x0006951A
		public FRigUnit_BoneHarmonics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0006B325 File Offset: 0x00069525
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BoneHarmonics(Pointer, false, true);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x0006B32F File Offset: 0x0006952F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BoneHarmonics(Pointer, MemoryOwner);
		}

		// Token: 0x04002304 RID: 8964
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BoneHarmonics";

		// Token: 0x04002305 RID: 8965
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002306 RID: 8966
		internal static int __PropertyOffset_Bones;

		// Token: 0x04002307 RID: 8967
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_BoneHarmonics_BoneTarget> _Bones;

		// Token: 0x04002308 RID: 8968
		internal static int __PropertyOffset_WaveSpeed;

		// Token: 0x04002309 RID: 8969
		internal static int __PropertyOffset_WaveFrequency;

		// Token: 0x0400230A RID: 8970
		internal static int __PropertyOffset_WaveAmplitude;

		// Token: 0x0400230B RID: 8971
		internal static int __PropertyOffset_WaveOffset;

		// Token: 0x0400230C RID: 8972
		internal static int __PropertyOffset_WaveNoise;

		// Token: 0x0400230D RID: 8973
		internal static int __PropertyOffset_WaveEase;

		// Token: 0x0400230E RID: 8974
		internal static int __PropertyOffset_WaveMinimum;

		// Token: 0x0400230F RID: 8975
		internal static int __PropertyOffset_WaveMaximum;

		// Token: 0x04002310 RID: 8976
		internal static int __PropertyOffset_RotationOrder;

		// Token: 0x04002311 RID: 8977
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002312 RID: 8978
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002313 RID: 8979
		[Nullable(2)]
		private FRigUnit_BoneHarmonics_WorkData _WorkData;
	}
}
