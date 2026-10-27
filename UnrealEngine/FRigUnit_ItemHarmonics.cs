using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D1 RID: 1489
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ItemHarmonics")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_ItemHarmonics : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600505C RID: 20572 RVA: 0x00076A01 File Offset: 0x00074C01
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ItemHarmonics._ScriptStructPtr != 0) ? FRigUnit_ItemHarmonics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ItemHarmonics", ref FRigUnit_ItemHarmonics._ScriptStructPtr);
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600505D RID: 20573 RVA: 0x00076A28 File Offset: 0x00074C28
		// (set) Token: 0x0600505E RID: 20574 RVA: 0x00076A6B File Offset: 0x00074C6B
		public TArray<FRigUnit_Harmonics_TargetItem> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_Harmonics_TargetItem> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FRigUnit_Harmonics_TargetItem>(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600505F RID: 20575 RVA: 0x00076A79 File Offset: 0x00074C79
		// (set) Token: 0x06005060 RID: 20576 RVA: 0x00076A8D File Offset: 0x00074C8D
		public unsafe FVector WaveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveSpeed) = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x00076AA2 File Offset: 0x00074CA2
		// (set) Token: 0x06005062 RID: 20578 RVA: 0x00076AB6 File Offset: 0x00074CB6
		public unsafe FVector WaveFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveFrequency) = value;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x00076ACB File Offset: 0x00074CCB
		// (set) Token: 0x06005064 RID: 20580 RVA: 0x00076ADF File Offset: 0x00074CDF
		public unsafe FVector WaveAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveAmplitude) = value;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x00076AF4 File Offset: 0x00074CF4
		// (set) Token: 0x06005066 RID: 20582 RVA: 0x00076B08 File Offset: 0x00074D08
		public unsafe FVector WaveOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveOffset) = value;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x00076B1D File Offset: 0x00074D1D
		// (set) Token: 0x06005068 RID: 20584 RVA: 0x00076B31 File Offset: 0x00074D31
		public unsafe FVector WaveNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveNoise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveNoise) = value;
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x00076B46 File Offset: 0x00074D46
		// (set) Token: 0x0600506A RID: 20586 RVA: 0x00076B56 File Offset: 0x00074D56
		public unsafe EControlRigAnimEasingType WaveEase
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveEase) = (byte)value;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600506B RID: 20587 RVA: 0x00076B67 File Offset: 0x00074D67
		// (set) Token: 0x0600506C RID: 20588 RVA: 0x00076B77 File Offset: 0x00074D77
		public unsafe float WaveMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveMinimum) = value;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x00076B88 File Offset: 0x00074D88
		// (set) Token: 0x0600506E RID: 20590 RVA: 0x00076B98 File Offset: 0x00074D98
		public unsafe float WaveMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WaveMaximum) = value;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600506F RID: 20591 RVA: 0x00076BA9 File Offset: 0x00074DA9
		// (set) Token: 0x06005070 RID: 20592 RVA: 0x00076BB9 File Offset: 0x00074DB9
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x00076BCC File Offset: 0x00074DCC
		// (set) Token: 0x06005072 RID: 20594 RVA: 0x00076C0F File Offset: 0x00074E0F
		public FRigUnit_BoneHarmonics_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_BoneHarmonics_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_BoneHarmonics_WorkData(base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_BoneHarmonics_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ItemHarmonics.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00076C30 File Offset: 0x00074E30
		public FRigUnit_ItemHarmonics()
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00076C38 File Offset: 0x00074E38
		public FRigUnit_ItemHarmonics(TArray<FRigUnit_Harmonics_TargetItem> Targets, FVector WaveSpeed, FVector WaveFrequency, FVector WaveAmplitude, FVector WaveOffset, FVector WaveNoise, EControlRigAnimEasingType WaveEase, float WaveMinimum, float WaveMaximum, EControlRigRotationOrder RotationOrder, FRigUnit_BoneHarmonics_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Targets = Targets;
			this.WaveSpeed = WaveSpeed;
			this.WaveFrequency = WaveFrequency;
			this.WaveAmplitude = WaveAmplitude;
			this.WaveOffset = WaveOffset;
			this.WaveNoise = WaveNoise;
			this.WaveEase = WaveEase;
			this.WaveMinimum = WaveMinimum;
			this.WaveMaximum = WaveMaximum;
			this.RotationOrder = RotationOrder;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00076CA8 File Offset: 0x00074EA8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ItemHarmonics.StaticStruct();
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00076CB4 File Offset: 0x00074EB4
		[NullableContext(2)]
		public FRigUnit_ItemHarmonics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00076CBE File Offset: 0x00074EBE
		public FRigUnit_ItemHarmonics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00076CC9 File Offset: 0x00074EC9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ItemHarmonics(Pointer, false, true);
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00076CD3 File Offset: 0x00074ED3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ItemHarmonics(Pointer, MemoryOwner);
		}

		// Token: 0x040026C4 RID: 9924
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ItemHarmonics";

		// Token: 0x040026C5 RID: 9925
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026C6 RID: 9926
		internal static int __PropertyOffset_Targets;

		// Token: 0x040026C7 RID: 9927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_Harmonics_TargetItem> _Targets;

		// Token: 0x040026C8 RID: 9928
		internal static int __PropertyOffset_WaveSpeed;

		// Token: 0x040026C9 RID: 9929
		internal static int __PropertyOffset_WaveFrequency;

		// Token: 0x040026CA RID: 9930
		internal static int __PropertyOffset_WaveAmplitude;

		// Token: 0x040026CB RID: 9931
		internal static int __PropertyOffset_WaveOffset;

		// Token: 0x040026CC RID: 9932
		internal static int __PropertyOffset_WaveNoise;

		// Token: 0x040026CD RID: 9933
		internal static int __PropertyOffset_WaveEase;

		// Token: 0x040026CE RID: 9934
		internal static int __PropertyOffset_WaveMinimum;

		// Token: 0x040026CF RID: 9935
		internal static int __PropertyOffset_WaveMaximum;

		// Token: 0x040026D0 RID: 9936
		internal static int __PropertyOffset_RotationOrder;

		// Token: 0x040026D1 RID: 9937
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040026D2 RID: 9938
		[Nullable(2)]
		private FRigUnit_BoneHarmonics_WorkData _WorkData;
	}
}
