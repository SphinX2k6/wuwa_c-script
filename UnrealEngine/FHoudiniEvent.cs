using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001514 RID: 5396
	[UnrealObjectPath("/Script/HoudiniNiagara.HoudiniEvent")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FHoudiniEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013A00 RID: 80384 RVA: 0x001CD38E File Offset: 0x001CB58E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniEvent._ScriptStructPtr != 0) ? FHoudiniEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniNiagara.HoudiniEvent", ref FHoudiniEvent._ScriptStructPtr);
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x06013A01 RID: 80385 RVA: 0x001CD3B2 File Offset: 0x001CB5B2
		// (set) Token: 0x06013A02 RID: 80386 RVA: 0x001CD3C6 File Offset: 0x001CB5C6
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x06013A03 RID: 80387 RVA: 0x001CD3DB File Offset: 0x001CB5DB
		// (set) Token: 0x06013A04 RID: 80388 RVA: 0x001CD3EF File Offset: 0x001CB5EF
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x06013A05 RID: 80389 RVA: 0x001CD404 File Offset: 0x001CB604
		// (set) Token: 0x06013A06 RID: 80390 RVA: 0x001CD414 File Offset: 0x001CB614
		public unsafe float Impulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Impulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Impulse) = value;
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x06013A07 RID: 80391 RVA: 0x001CD425 File Offset: 0x001CB625
		// (set) Token: 0x06013A08 RID: 80392 RVA: 0x001CD439 File Offset: 0x001CB639
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x06013A09 RID: 80393 RVA: 0x001CD44E File Offset: 0x001CB64E
		// (set) Token: 0x06013A0A RID: 80394 RVA: 0x001CD45E File Offset: 0x001CB65E
		public unsafe int PointID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_PointID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_PointID) = value;
			}
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06013A0B RID: 80395 RVA: 0x001CD46F File Offset: 0x001CB66F
		// (set) Token: 0x06013A0C RID: 80396 RVA: 0x001CD47F File Offset: 0x001CB67F
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06013A0D RID: 80397 RVA: 0x001CD490 File Offset: 0x001CB690
		// (set) Token: 0x06013A0E RID: 80398 RVA: 0x001CD4A0 File Offset: 0x001CB6A0
		public unsafe float Life
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Life);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Life) = value;
			}
		}

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x06013A0F RID: 80399 RVA: 0x001CD4B1 File Offset: 0x001CB6B1
		// (set) Token: 0x06013A10 RID: 80400 RVA: 0x001CD4C5 File Offset: 0x001CB6C5
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x06013A11 RID: 80401 RVA: 0x001CD4DA File Offset: 0x001CB6DA
		// (set) Token: 0x06013A12 RID: 80402 RVA: 0x001CD4EA File Offset: 0x001CB6EA
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniEvent.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x06013A13 RID: 80403 RVA: 0x001CD4FB File Offset: 0x001CB6FB
		public FHoudiniEvent()
		{
		}

		// Token: 0x06013A14 RID: 80404 RVA: 0x001CD504 File Offset: 0x001CB704
		public FHoudiniEvent(FVector Position, FVector Normal, float Impulse, FVector Velocity, int PointID, float Time, float Life, FLinearColor Color, int Type)
		{
			this.Position = Position;
			this.Normal = Normal;
			this.Impulse = Impulse;
			this.Velocity = Velocity;
			this.PointID = PointID;
			this.Time = Time;
			this.Life = Life;
			this.Color = Color;
			this.Type = Type;
		}

		// Token: 0x06013A15 RID: 80405 RVA: 0x001CD55C File Offset: 0x001CB75C
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniEvent.StaticStruct();
		}

		// Token: 0x06013A16 RID: 80406 RVA: 0x001CD568 File Offset: 0x001CB768
		[NullableContext(2)]
		public FHoudiniEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013A17 RID: 80407 RVA: 0x001CD572 File Offset: 0x001CB772
		public FHoudiniEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013A18 RID: 80408 RVA: 0x001CD57D File Offset: 0x001CB77D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniEvent(Pointer, false, true);
		}

		// Token: 0x06013A19 RID: 80409 RVA: 0x001CD587 File Offset: 0x001CB787
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400A9B2 RID: 43442
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniNiagara.HoudiniEvent";

		// Token: 0x0400A9B3 RID: 43443
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A9B4 RID: 43444
		internal static int __PropertyOffset_Position;

		// Token: 0x0400A9B5 RID: 43445
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400A9B6 RID: 43446
		internal static int __PropertyOffset_Impulse;

		// Token: 0x0400A9B7 RID: 43447
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400A9B8 RID: 43448
		internal static int __PropertyOffset_PointID;

		// Token: 0x0400A9B9 RID: 43449
		internal static int __PropertyOffset_Time;

		// Token: 0x0400A9BA RID: 43450
		internal static int __PropertyOffset_Life;

		// Token: 0x0400A9BB RID: 43451
		internal static int __PropertyOffset_Color;

		// Token: 0x0400A9BC RID: 43452
		internal static int __PropertyOffset_Type;
	}
}
