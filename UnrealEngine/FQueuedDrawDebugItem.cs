using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200105F RID: 4191
	[UnrealObjectPath("/Script/Engine.QueuedDrawDebugItem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FQueuedDrawDebugItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE58 RID: 61016 RVA: 0x001619D2 File Offset: 0x0015FBD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQueuedDrawDebugItem._ScriptStructPtr != 0) ? FQueuedDrawDebugItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QueuedDrawDebugItem", ref FQueuedDrawDebugItem._ScriptStructPtr);
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600EE59 RID: 61017 RVA: 0x001619F6 File Offset: 0x0015FBF6
		// (set) Token: 0x0600EE5A RID: 61018 RVA: 0x00161A0A File Offset: 0x0015FC0A
		public unsafe TEnumAsByte<EDrawDebugItemType> ItemType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_ItemType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_ItemType) = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600EE5B RID: 61019 RVA: 0x00161A1F File Offset: 0x0015FC1F
		// (set) Token: 0x0600EE5C RID: 61020 RVA: 0x00161A33 File Offset: 0x0015FC33
		public unsafe FVector StartLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_StartLoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_StartLoc) = value;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600EE5D RID: 61021 RVA: 0x00161A48 File Offset: 0x0015FC48
		// (set) Token: 0x0600EE5E RID: 61022 RVA: 0x00161A5C File Offset: 0x0015FC5C
		public unsafe FVector EndLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_EndLoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_EndLoc) = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x00161A71 File Offset: 0x0015FC71
		// (set) Token: 0x0600EE60 RID: 61024 RVA: 0x00161A85 File Offset: 0x0015FC85
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600EE61 RID: 61025 RVA: 0x00161A9A File Offset: 0x0015FC9A
		// (set) Token: 0x0600EE62 RID: 61026 RVA: 0x00161AAE File Offset: 0x0015FCAE
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600EE63 RID: 61027 RVA: 0x00161AC3 File Offset: 0x0015FCC3
		// (set) Token: 0x0600EE64 RID: 61028 RVA: 0x00161AD3 File Offset: 0x0015FCD3
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600EE65 RID: 61029 RVA: 0x00161AE4 File Offset: 0x0015FCE4
		// (set) Token: 0x0600EE66 RID: 61030 RVA: 0x00161AF4 File Offset: 0x0015FCF4
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600EE67 RID: 61031 RVA: 0x00161B05 File Offset: 0x0015FD05
		// (set) Token: 0x0600EE68 RID: 61032 RVA: 0x00161B15 File Offset: 0x0015FD15
		public unsafe int Segments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Segments);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Segments) = value;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600EE69 RID: 61033 RVA: 0x00161B26 File Offset: 0x0015FD26
		// (set) Token: 0x0600EE6A RID: 61034 RVA: 0x00161B3A File Offset: 0x0015FD3A
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600EE6B RID: 61035 RVA: 0x00161B4F File Offset: 0x0015FD4F
		// (set) Token: 0x0600EE6C RID: 61036 RVA: 0x00161B5F File Offset: 0x0015FD5F
		public unsafe bool bPersistentLines
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_bPersistentLines) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_bPersistentLines) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x00161B70 File Offset: 0x0015FD70
		// (set) Token: 0x0600EE6E RID: 61038 RVA: 0x00161B80 File Offset: 0x0015FD80
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_LifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_LifeTime) = value;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600EE6F RID: 61039 RVA: 0x00161B91 File Offset: 0x0015FD91
		// (set) Token: 0x0600EE70 RID: 61040 RVA: 0x00161BA1 File Offset: 0x0015FDA1
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600EE71 RID: 61041 RVA: 0x00161BB2 File Offset: 0x0015FDB2
		// (set) Token: 0x0600EE72 RID: 61042 RVA: 0x00161BC6 File Offset: 0x0015FDC6
		[Nullable(1)]
		public unsafe string Message
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Message)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FQueuedDrawDebugItem.__PropertyOffset_Message)), value);
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600EE73 RID: 61043 RVA: 0x00161BDB File Offset: 0x0015FDDB
		// (set) Token: 0x0600EE74 RID: 61044 RVA: 0x00161BEF File Offset: 0x0015FDEF
		public unsafe FVector2D TextScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_TextScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQueuedDrawDebugItem.__PropertyOffset_TextScale) = value;
			}
		}

		// Token: 0x0600EE75 RID: 61045 RVA: 0x00161C04 File Offset: 0x0015FE04
		public FQueuedDrawDebugItem()
		{
		}

		// Token: 0x0600EE76 RID: 61046 RVA: 0x00161C0C File Offset: 0x0015FE0C
		public FQueuedDrawDebugItem(TEnumAsByte<EDrawDebugItemType> ItemType, FVector StartLoc, FVector EndLoc, FVector Center, FRotator Rotation, float Radius, float Size, int Segments, FColor Color, bool bPersistentLines, float LifeTime, float Thickness, [Nullable(1)] string Message, FVector2D TextScale)
		{
			this.ItemType = ItemType;
			this.StartLoc = StartLoc;
			this.EndLoc = EndLoc;
			this.Center = Center;
			this.Rotation = Rotation;
			this.Radius = Radius;
			this.Size = Size;
			this.Segments = Segments;
			this.Color = Color;
			this.bPersistentLines = bPersistentLines;
			this.LifeTime = LifeTime;
			this.Thickness = Thickness;
			this.Message = Message;
			this.TextScale = TextScale;
		}

		// Token: 0x0600EE77 RID: 61047 RVA: 0x00161C8C File Offset: 0x0015FE8C
		protected override IntPtr GetUStructPtr()
		{
			return FQueuedDrawDebugItem.StaticStruct();
		}

		// Token: 0x0600EE78 RID: 61048 RVA: 0x00161C98 File Offset: 0x0015FE98
		[NullableContext(2)]
		public FQueuedDrawDebugItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE79 RID: 61049 RVA: 0x00161CA2 File Offset: 0x0015FEA2
		public FQueuedDrawDebugItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE7A RID: 61050 RVA: 0x00161CAD File Offset: 0x0015FEAD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQueuedDrawDebugItem(Pointer, false, true);
		}

		// Token: 0x0600EE7B RID: 61051 RVA: 0x00161CB7 File Offset: 0x0015FEB7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQueuedDrawDebugItem(Pointer, MemoryOwner);
		}

		// Token: 0x04008106 RID: 33030
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.QueuedDrawDebugItem";

		// Token: 0x04008107 RID: 33031
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008108 RID: 33032
		internal static int __PropertyOffset_ItemType;

		// Token: 0x04008109 RID: 33033
		internal static int __PropertyOffset_StartLoc;

		// Token: 0x0400810A RID: 33034
		internal static int __PropertyOffset_EndLoc;

		// Token: 0x0400810B RID: 33035
		internal static int __PropertyOffset_Center;

		// Token: 0x0400810C RID: 33036
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400810D RID: 33037
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400810E RID: 33038
		internal static int __PropertyOffset_Size;

		// Token: 0x0400810F RID: 33039
		internal static int __PropertyOffset_Segments;

		// Token: 0x04008110 RID: 33040
		internal static int __PropertyOffset_Color;

		// Token: 0x04008111 RID: 33041
		internal static int __PropertyOffset_bPersistentLines;

		// Token: 0x04008112 RID: 33042
		internal static int __PropertyOffset_LifeTime;

		// Token: 0x04008113 RID: 33043
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04008114 RID: 33044
		internal static int __PropertyOffset_Message;

		// Token: 0x04008115 RID: 33045
		internal static int __PropertyOffset_TextScale;
	}
}
