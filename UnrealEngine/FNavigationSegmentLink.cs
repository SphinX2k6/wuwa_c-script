using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EDE RID: 3806
	[UnrealObjectPath("/Script/Engine.NavigationSegmentLink")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FNavigationSegmentLink : FNavigationLinkBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CE40 RID: 52800 RVA: 0x0012CEFD File Offset: 0x0012B0FD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationSegmentLink._ScriptStructPtr != 0) ? FNavigationSegmentLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavigationSegmentLink", ref FNavigationSegmentLink._ScriptStructPtr);
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x0012CF21 File Offset: 0x0012B121
		// (set) Token: 0x0600CE42 RID: 52802 RVA: 0x0012CF35 File Offset: 0x0012B135
		public unsafe FVector LeftStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_LeftStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_LeftStart) = value;
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x0012CF4A File Offset: 0x0012B14A
		// (set) Token: 0x0600CE44 RID: 52804 RVA: 0x0012CF5E File Offset: 0x0012B15E
		public unsafe FVector LeftEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_LeftEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_LeftEnd) = value;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0012CF73 File Offset: 0x0012B173
		// (set) Token: 0x0600CE46 RID: 52806 RVA: 0x0012CF87 File Offset: 0x0012B187
		public unsafe FVector RightStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_RightStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_RightStart) = value;
			}
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x0012CF9C File Offset: 0x0012B19C
		// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x0012CFB0 File Offset: 0x0012B1B0
		public unsafe FVector RightEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_RightEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationSegmentLink.__PropertyOffset_RightEnd) = value;
			}
		}

		// Token: 0x0600CE49 RID: 52809 RVA: 0x0012CFC5 File Offset: 0x0012B1C5
		public FNavigationSegmentLink()
		{
		}

		// Token: 0x0600CE4A RID: 52810 RVA: 0x0012CFD0 File Offset: 0x0012B1D0
		[NullableContext(1)]
		public FNavigationSegmentLink(FVector LeftStart, FVector LeftEnd, FVector RightStart, FVector RightEnd, float LeftProjectHeight, float MaxFallDownLength, float SnapRadius, float SnapHeight, FNavAgentSelector SupportedAgents, bool bSupportsAgent0, bool bSupportsAgent1, bool bSupportsAgent2, bool bSupportsAgent3, bool bSupportsAgent4, bool bSupportsAgent5, bool bSupportsAgent6, bool bSupportsAgent7, bool bSupportsAgent8, bool bSupportsAgent9, bool bSupportsAgent10, bool bSupportsAgent11, bool bSupportsAgent12, bool bSupportsAgent13, bool bSupportsAgent14, bool bSupportsAgent15, string Description, [Nullable(0)] TEnumAsByte<ENavLinkDirection> Direction, bool bUseSnapHeight, bool bSnapToCheapestArea, bool bCustomFlag0, bool bCustomFlag1, bool bCustomFlag2, bool bCustomFlag3, bool bCustomFlag4, bool bCustomFlag5, bool bCustomFlag6, bool bCustomFlag7, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavAreaBase> AreaClass)
		{
			this.LeftStart = LeftStart;
			this.LeftEnd = LeftEnd;
			this.RightStart = RightStart;
			this.RightEnd = RightEnd;
			base.LeftProjectHeight = LeftProjectHeight;
			base.MaxFallDownLength = MaxFallDownLength;
			base.SnapRadius = SnapRadius;
			base.SnapHeight = SnapHeight;
			base.SupportedAgents = SupportedAgents;
			base.bSupportsAgent0 = bSupportsAgent0;
			base.bSupportsAgent1 = bSupportsAgent1;
			base.bSupportsAgent2 = bSupportsAgent2;
			base.bSupportsAgent3 = bSupportsAgent3;
			base.bSupportsAgent4 = bSupportsAgent4;
			base.bSupportsAgent5 = bSupportsAgent5;
			base.bSupportsAgent6 = bSupportsAgent6;
			base.bSupportsAgent7 = bSupportsAgent7;
			base.bSupportsAgent8 = bSupportsAgent8;
			base.bSupportsAgent9 = bSupportsAgent9;
			base.bSupportsAgent10 = bSupportsAgent10;
			base.bSupportsAgent11 = bSupportsAgent11;
			base.bSupportsAgent12 = bSupportsAgent12;
			base.bSupportsAgent13 = bSupportsAgent13;
			base.bSupportsAgent14 = bSupportsAgent14;
			base.bSupportsAgent15 = bSupportsAgent15;
			base.Direction = Direction;
			base.bUseSnapHeight = bUseSnapHeight;
			base.bSnapToCheapestArea = bSnapToCheapestArea;
			base.bCustomFlag0 = bCustomFlag0;
			base.bCustomFlag1 = bCustomFlag1;
			base.bCustomFlag2 = bCustomFlag2;
			base.bCustomFlag3 = bCustomFlag3;
			base.bCustomFlag4 = bCustomFlag4;
			base.bCustomFlag5 = bCustomFlag5;
			base.bCustomFlag6 = bCustomFlag6;
			base.bCustomFlag7 = bCustomFlag7;
			base.AreaClass = AreaClass;
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x0012D108 File Offset: 0x0012B308
		protected override IntPtr GetUStructPtr()
		{
			return FNavigationSegmentLink.StaticStruct();
		}

		// Token: 0x0600CE4C RID: 52812 RVA: 0x0012D114 File Offset: 0x0012B314
		[NullableContext(2)]
		public FNavigationSegmentLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x0012D11E File Offset: 0x0012B31E
		public FNavigationSegmentLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CE4E RID: 52814 RVA: 0x0012D129 File Offset: 0x0012B329
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavigationSegmentLink(Pointer, false, true);
		}

		// Token: 0x0600CE4F RID: 52815 RVA: 0x0012D133 File Offset: 0x0012B333
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavigationSegmentLink(Pointer, MemoryOwner);
		}

		// Token: 0x04006F37 RID: 28471
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationSegmentLink";

		// Token: 0x04006F38 RID: 28472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006F39 RID: 28473
		internal static int __PropertyOffset_LeftStart;

		// Token: 0x04006F3A RID: 28474
		internal static int __PropertyOffset_LeftEnd;

		// Token: 0x04006F3B RID: 28475
		internal static int __PropertyOffset_RightStart;

		// Token: 0x04006F3C RID: 28476
		internal static int __PropertyOffset_RightEnd;
	}
}
