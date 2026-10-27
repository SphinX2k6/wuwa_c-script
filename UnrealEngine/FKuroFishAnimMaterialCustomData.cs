using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AF2 RID: 6898
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimMaterialCustomData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroFishAnimMaterialCustomData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019C0F RID: 105487 RVA: 0x00260D58 File Offset: 0x0025EF58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFishAnimMaterialCustomData._ScriptStructPtr != 0) ? FKuroFishAnimMaterialCustomData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimMaterialCustomData", ref FKuroFishAnimMaterialCustomData._ScriptStructPtr);
		}

		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x06019C10 RID: 105488 RVA: 0x00260D7C File Offset: 0x0025EF7C
		// (set) Token: 0x06019C11 RID: 105489 RVA: 0x00260D8C File Offset: 0x0025EF8C
		public unsafe float Wiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_Wiggle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_Wiggle) = value;
			}
		}

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x06019C12 RID: 105490 RVA: 0x00260D9D File Offset: 0x0025EF9D
		// (set) Token: 0x06019C13 RID: 105491 RVA: 0x00260DAD File Offset: 0x0025EFAD
		public unsafe float PreviousWiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousWiggle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousWiggle) = value;
			}
		}

		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x06019C14 RID: 105492 RVA: 0x00260DBE File Offset: 0x0025EFBE
		// (set) Token: 0x06019C15 RID: 105493 RVA: 0x00260DCE File Offset: 0x0025EFCE
		public unsafe float AnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_AnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_AnimTime) = value;
			}
		}

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x06019C16 RID: 105494 RVA: 0x00260DDF File Offset: 0x0025EFDF
		// (set) Token: 0x06019C17 RID: 105495 RVA: 0x00260DEF File Offset: 0x0025EFEF
		public unsafe float PreviousAnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousAnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousAnimTime) = value;
			}
		}

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x06019C18 RID: 105496 RVA: 0x00260E00 File Offset: 0x0025F000
		// (set) Token: 0x06019C19 RID: 105497 RVA: 0x00260E10 File Offset: 0x0025F010
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x06019C1A RID: 105498 RVA: 0x00260E21 File Offset: 0x0025F021
		// (set) Token: 0x06019C1B RID: 105499 RVA: 0x00260E31 File Offset: 0x0025F031
		public unsafe float PreviousAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_PreviousAngle) = value;
			}
		}

		// Token: 0x170066FE RID: 26366
		// (get) Token: 0x06019C1C RID: 105500 RVA: 0x00260E42 File Offset: 0x0025F042
		// (set) Token: 0x06019C1D RID: 105501 RVA: 0x00260E52 File Offset: 0x0025F052
		public unsafe float ScatterSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_ScatterSelected);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimMaterialCustomData.__PropertyOffset_ScatterSelected) = value;
			}
		}

		// Token: 0x06019C1E RID: 105502 RVA: 0x00260E63 File Offset: 0x0025F063
		public FKuroFishAnimMaterialCustomData()
		{
		}

		// Token: 0x06019C1F RID: 105503 RVA: 0x00260E6B File Offset: 0x0025F06B
		public FKuroFishAnimMaterialCustomData(float Wiggle, float PreviousWiggle, float AnimTime, float PreviousAnimTime, float Angle, float PreviousAngle, float ScatterSelected)
		{
			this.Wiggle = Wiggle;
			this.PreviousWiggle = PreviousWiggle;
			this.AnimTime = AnimTime;
			this.PreviousAnimTime = PreviousAnimTime;
			this.Angle = Angle;
			this.PreviousAngle = PreviousAngle;
			this.ScatterSelected = ScatterSelected;
		}

		// Token: 0x06019C20 RID: 105504 RVA: 0x00260EA8 File Offset: 0x0025F0A8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFishAnimMaterialCustomData.StaticStruct();
		}

		// Token: 0x06019C21 RID: 105505 RVA: 0x00260EB4 File Offset: 0x0025F0B4
		[NullableContext(2)]
		public FKuroFishAnimMaterialCustomData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019C22 RID: 105506 RVA: 0x00260EBE File Offset: 0x0025F0BE
		public FKuroFishAnimMaterialCustomData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019C23 RID: 105507 RVA: 0x00260EC9 File Offset: 0x0025F0C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFishAnimMaterialCustomData(Pointer, false, true);
		}

		// Token: 0x06019C24 RID: 105508 RVA: 0x00260ED3 File Offset: 0x0025F0D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFishAnimMaterialCustomData(Pointer, MemoryOwner);
		}

		// Token: 0x0400E026 RID: 57382
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimMaterialCustomData";

		// Token: 0x0400E027 RID: 57383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E028 RID: 57384
		internal static int __PropertyOffset_Wiggle;

		// Token: 0x0400E029 RID: 57385
		internal static int __PropertyOffset_PreviousWiggle;

		// Token: 0x0400E02A RID: 57386
		internal static int __PropertyOffset_AnimTime;

		// Token: 0x0400E02B RID: 57387
		internal static int __PropertyOffset_PreviousAnimTime;

		// Token: 0x0400E02C RID: 57388
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400E02D RID: 57389
		internal static int __PropertyOffset_PreviousAngle;

		// Token: 0x0400E02E RID: 57390
		internal static int __PropertyOffset_ScatterSelected;
	}
}
