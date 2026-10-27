using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EDA RID: 3802
	[UnrealObjectPath("/Script/Engine.NavigationLink")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNavigationLink : FNavigationLinkBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CDD9 RID: 52697 RVA: 0x0012C1A0 File Offset: 0x0012A3A0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationLink._ScriptStructPtr != 0) ? FNavigationLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavigationLink", ref FNavigationLink._ScriptStructPtr);
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x0012C1C4 File Offset: 0x0012A3C4
		// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x0012C1D8 File Offset: 0x0012A3D8
		public unsafe FVector Left
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLink.__PropertyOffset_Left);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLink.__PropertyOffset_Left) = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x0012C1ED File Offset: 0x0012A3ED
		// (set) Token: 0x0600CDDD RID: 52701 RVA: 0x0012C201 File Offset: 0x0012A401
		public unsafe FVector Right
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLink.__PropertyOffset_Right);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLink.__PropertyOffset_Right) = value;
			}
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x0012C216 File Offset: 0x0012A416
		public FNavigationLink()
		{
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x0012C220 File Offset: 0x0012A420
		[NullableContext(1)]
		public FNavigationLink(FVector Left, FVector Right, float LeftProjectHeight, float MaxFallDownLength, float SnapRadius, float SnapHeight, FNavAgentSelector SupportedAgents, bool bSupportsAgent0, bool bSupportsAgent1, bool bSupportsAgent2, bool bSupportsAgent3, bool bSupportsAgent4, bool bSupportsAgent5, bool bSupportsAgent6, bool bSupportsAgent7, bool bSupportsAgent8, bool bSupportsAgent9, bool bSupportsAgent10, bool bSupportsAgent11, bool bSupportsAgent12, bool bSupportsAgent13, bool bSupportsAgent14, bool bSupportsAgent15, string Description, [Nullable(0)] TEnumAsByte<ENavLinkDirection> Direction, bool bUseSnapHeight, bool bSnapToCheapestArea, bool bCustomFlag0, bool bCustomFlag1, bool bCustomFlag2, bool bCustomFlag3, bool bCustomFlag4, bool bCustomFlag5, bool bCustomFlag6, bool bCustomFlag7, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavAreaBase> AreaClass)
		{
			this.Left = Left;
			this.Right = Right;
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

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x0012C348 File Offset: 0x0012A548
		protected override IntPtr GetUStructPtr()
		{
			return FNavigationLink.StaticStruct();
		}

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x0012C354 File Offset: 0x0012A554
		[NullableContext(2)]
		public FNavigationLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x0012C35E File Offset: 0x0012A55E
		public FNavigationLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x0012C369 File Offset: 0x0012A569
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavigationLink(Pointer, false, true);
		}

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x0012C373 File Offset: 0x0012A573
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavigationLink(Pointer, MemoryOwner);
		}

		// Token: 0x04006EE9 RID: 28393
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationLink";

		// Token: 0x04006EEA RID: 28394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006EEB RID: 28395
		internal static int __PropertyOffset_Left;

		// Token: 0x04006EEC RID: 28396
		internal static int __PropertyOffset_Right;
	}
}
