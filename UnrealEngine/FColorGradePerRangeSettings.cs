using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000949 RID: 2377
	[UnrealObjectPath("/Script/Engine.ColorGradePerRangeSettings")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FColorGradePerRangeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008694 RID: 34452 RVA: 0x000BFCE2 File Offset: 0x000BDEE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColorGradePerRangeSettings._ScriptStructPtr != 0) ? FColorGradePerRangeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ColorGradePerRangeSettings", ref FColorGradePerRangeSettings._ScriptStructPtr);
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06008695 RID: 34453 RVA: 0x000BFD06 File Offset: 0x000BDF06
		// (set) Token: 0x06008696 RID: 34454 RVA: 0x000BFD1A File Offset: 0x000BDF1A
		public unsafe FVector4 Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Saturation) = value;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06008697 RID: 34455 RVA: 0x000BFD2F File Offset: 0x000BDF2F
		// (set) Token: 0x06008698 RID: 34456 RVA: 0x000BFD43 File Offset: 0x000BDF43
		public unsafe FVector4 Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Contrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Contrast) = value;
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06008699 RID: 34457 RVA: 0x000BFD58 File Offset: 0x000BDF58
		// (set) Token: 0x0600869A RID: 34458 RVA: 0x000BFD6C File Offset: 0x000BDF6C
		public unsafe FVector4 Gamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Gamma);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Gamma) = value;
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600869B RID: 34459 RVA: 0x000BFD81 File Offset: 0x000BDF81
		// (set) Token: 0x0600869C RID: 34460 RVA: 0x000BFD95 File Offset: 0x000BDF95
		public unsafe FVector4 Gain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Gain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Gain) = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600869D RID: 34461 RVA: 0x000BFDAA File Offset: 0x000BDFAA
		// (set) Token: 0x0600869E RID: 34462 RVA: 0x000BFDBE File Offset: 0x000BDFBE
		public unsafe FVector4 Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradePerRangeSettings.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x000BFDD3 File Offset: 0x000BDFD3
		public FColorGradePerRangeSettings()
		{
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x000BFDDB File Offset: 0x000BDFDB
		public FColorGradePerRangeSettings(FVector4 Saturation, FVector4 Contrast, FVector4 Gamma, FVector4 Gain, FVector4 Offset)
		{
			this.Saturation = Saturation;
			this.Contrast = Contrast;
			this.Gamma = Gamma;
			this.Gain = Gain;
			this.Offset = Offset;
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x000BFE08 File Offset: 0x000BE008
		protected override IntPtr GetUStructPtr()
		{
			return FColorGradePerRangeSettings.StaticStruct();
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x000BFE14 File Offset: 0x000BE014
		[NullableContext(2)]
		public FColorGradePerRangeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x000BFE1E File Offset: 0x000BE01E
		public FColorGradePerRangeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x000BFE29 File Offset: 0x000BE029
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FColorGradePerRangeSettings(Pointer, false, true);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x000BFE33 File Offset: 0x000BE033
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FColorGradePerRangeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04004006 RID: 16390
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ColorGradePerRangeSettings";

		// Token: 0x04004007 RID: 16391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004008 RID: 16392
		internal static int __PropertyOffset_Saturation;

		// Token: 0x04004009 RID: 16393
		internal static int __PropertyOffset_Contrast;

		// Token: 0x0400400A RID: 16394
		internal static int __PropertyOffset_Gamma;

		// Token: 0x0400400B RID: 16395
		internal static int __PropertyOffset_Gain;

		// Token: 0x0400400C RID: 16396
		internal static int __PropertyOffset_Offset;
	}
}
