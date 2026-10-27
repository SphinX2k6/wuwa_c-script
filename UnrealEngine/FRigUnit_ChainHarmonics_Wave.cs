using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000562 RID: 1378
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonics_Wave")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_ChainHarmonics_Wave : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004937 RID: 18743 RVA: 0x0006C9AB File Offset: 0x0006ABAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonics_Wave._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonics_Wave._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonics_Wave", ref FRigUnit_ChainHarmonics_Wave._ScriptStructPtr);
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x0006C9CF File Offset: 0x0006ABCF
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x0006C9DF File Offset: 0x0006ABDF
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x0006C9F0 File Offset: 0x0006ABF0
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x0006CA04 File Offset: 0x0006AC04
		public unsafe FVector WaveFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveFrequency) = value;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x0006CA19 File Offset: 0x0006AC19
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x0006CA2D File Offset: 0x0006AC2D
		public unsafe FVector WaveAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveAmplitude) = value;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x0006CA42 File Offset: 0x0006AC42
		// (set) Token: 0x0600493F RID: 18751 RVA: 0x0006CA56 File Offset: 0x0006AC56
		public unsafe FVector WaveOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveOffset) = value;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x0006CA6B File Offset: 0x0006AC6B
		// (set) Token: 0x06004941 RID: 18753 RVA: 0x0006CA7F File Offset: 0x0006AC7F
		public unsafe FVector WaveNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveNoise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveNoise) = value;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x0006CA94 File Offset: 0x0006AC94
		// (set) Token: 0x06004943 RID: 18755 RVA: 0x0006CAA4 File Offset: 0x0006ACA4
		public unsafe float WaveMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveMinimum) = value;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x0006CAB5 File Offset: 0x0006ACB5
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x0006CAC5 File Offset: 0x0006ACC5
		public unsafe float WaveMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveMaximum) = value;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x0006CAD6 File Offset: 0x0006ACD6
		// (set) Token: 0x06004947 RID: 18759 RVA: 0x0006CAE6 File Offset: 0x0006ACE6
		public unsafe EControlRigAnimEasingType WaveEase
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Wave.__PropertyOffset_WaveEase) = (byte)value;
			}
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0006CAF7 File Offset: 0x0006ACF7
		public FRigUnit_ChainHarmonics_Wave()
		{
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x0006CB00 File Offset: 0x0006AD00
		public FRigUnit_ChainHarmonics_Wave(bool bEnabled, FVector WaveFrequency, FVector WaveAmplitude, FVector WaveOffset, FVector WaveNoise, float WaveMinimum, float WaveMaximum, EControlRigAnimEasingType WaveEase)
		{
			this.bEnabled = bEnabled;
			this.WaveFrequency = WaveFrequency;
			this.WaveAmplitude = WaveAmplitude;
			this.WaveOffset = WaveOffset;
			this.WaveNoise = WaveNoise;
			this.WaveMinimum = WaveMinimum;
			this.WaveMaximum = WaveMaximum;
			this.WaveEase = WaveEase;
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x0006CB50 File Offset: 0x0006AD50
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonics_Wave.StaticStruct();
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x0006CB5C File Offset: 0x0006AD5C
		[NullableContext(2)]
		public FRigUnit_ChainHarmonics_Wave(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x0006CB66 File Offset: 0x0006AD66
		public FRigUnit_ChainHarmonics_Wave(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x0006CB71 File Offset: 0x0006AD71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonics_Wave(Pointer, false, true);
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x0006CB7B File Offset: 0x0006AD7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonics_Wave(Pointer, MemoryOwner);
		}

		// Token: 0x04002389 RID: 9097
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonics_Wave";

		// Token: 0x0400238A RID: 9098
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400238B RID: 9099
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400238C RID: 9100
		internal static int __PropertyOffset_WaveFrequency;

		// Token: 0x0400238D RID: 9101
		internal static int __PropertyOffset_WaveAmplitude;

		// Token: 0x0400238E RID: 9102
		internal static int __PropertyOffset_WaveOffset;

		// Token: 0x0400238F RID: 9103
		internal static int __PropertyOffset_WaveNoise;

		// Token: 0x04002390 RID: 9104
		internal static int __PropertyOffset_WaveMinimum;

		// Token: 0x04002391 RID: 9105
		internal static int __PropertyOffset_WaveMaximum;

		// Token: 0x04002392 RID: 9106
		internal static int __PropertyOffset_WaveEase;
	}
}
