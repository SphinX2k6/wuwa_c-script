using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E15 RID: 7701
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RemoveContext")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKSC_RemoveContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D621 RID: 120353 RVA: 0x002B5F74 File Offset: 0x002B4174
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_RemoveContext._ScriptStructPtr != 0) ? FKSC_RemoveContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_RemoveContext", ref FKSC_RemoveContext._ScriptStructPtr);
		}

		// Token: 0x17007684 RID: 30340
		// (get) Token: 0x0601D622 RID: 120354 RVA: 0x002B5F98 File Offset: 0x002B4198
		// (set) Token: 0x0601D623 RID: 120355 RVA: 0x002B5FA8 File Offset: 0x002B41A8
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x17007685 RID: 30341
		// (get) Token: 0x0601D624 RID: 120356 RVA: 0x002B5FB9 File Offset: 0x002B41B9
		// (set) Token: 0x0601D625 RID: 120357 RVA: 0x002B5FCD File Offset: 0x002B41CD
		public unsafe FName EntityTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityTypeName) = value;
			}
		}

		// Token: 0x17007686 RID: 30342
		// (get) Token: 0x0601D626 RID: 120358 RVA: 0x002B5FE2 File Offset: 0x002B41E2
		// (set) Token: 0x0601D627 RID: 120359 RVA: 0x002B5FF6 File Offset: 0x002B41F6
		public unsafe FName ReasonName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_ReasonName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_ReasonName) = value;
			}
		}

		// Token: 0x17007687 RID: 30343
		// (get) Token: 0x0601D628 RID: 120360 RVA: 0x002B600B File Offset: 0x002B420B
		// (set) Token: 0x0601D629 RID: 120361 RVA: 0x002B601F File Offset: 0x002B421F
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17007688 RID: 30344
		// (get) Token: 0x0601D62A RID: 120362 RVA: 0x002B6034 File Offset: 0x002B4234
		// (set) Token: 0x0601D62B RID: 120363 RVA: 0x002B6044 File Offset: 0x002B4244
		public unsafe bool IsPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_IsPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_IsPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007689 RID: 30345
		// (get) Token: 0x0601D62C RID: 120364 RVA: 0x002B6055 File Offset: 0x002B4255
		// (set) Token: 0x0601D62D RID: 120365 RVA: 0x002B6065 File Offset: 0x002B4265
		public unsafe int EntityIdKillBy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityIdKillBy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityIdKillBy) = value;
			}
		}

		// Token: 0x1700768A RID: 30346
		// (get) Token: 0x0601D62E RID: 120366 RVA: 0x002B6076 File Offset: 0x002B4276
		// (set) Token: 0x0601D62F RID: 120367 RVA: 0x002B608A File Offset: 0x002B428A
		public unsafe FName EntityTypeKillBy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityTypeKillBy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_RemoveContext.__PropertyOffset_EntityTypeKillBy) = value;
			}
		}

		// Token: 0x0601D630 RID: 120368 RVA: 0x002B609F File Offset: 0x002B429F
		public FKSC_RemoveContext()
		{
		}

		// Token: 0x0601D631 RID: 120369 RVA: 0x002B60A7 File Offset: 0x002B42A7
		public FKSC_RemoveContext(int EntityId, FName EntityTypeName, FName ReasonName, FVectorDouble Location, bool IsPreview, int EntityIdKillBy, FName EntityTypeKillBy)
		{
			this.EntityId = EntityId;
			this.EntityTypeName = EntityTypeName;
			this.ReasonName = ReasonName;
			this.Location = Location;
			this.IsPreview = IsPreview;
			this.EntityIdKillBy = EntityIdKillBy;
			this.EntityTypeKillBy = EntityTypeKillBy;
		}

		// Token: 0x0601D632 RID: 120370 RVA: 0x002B60E4 File Offset: 0x002B42E4
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_RemoveContext.StaticStruct();
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x002B60F0 File Offset: 0x002B42F0
		[NullableContext(2)]
		public FKSC_RemoveContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D634 RID: 120372 RVA: 0x002B60FA File Offset: 0x002B42FA
		public FKSC_RemoveContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D635 RID: 120373 RVA: 0x002B6105 File Offset: 0x002B4305
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_RemoveContext(Pointer, false, true);
		}

		// Token: 0x0601D636 RID: 120374 RVA: 0x002B610F File Offset: 0x002B430F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_RemoveContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FEFA RID: 65274
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RemoveContext";

		// Token: 0x0400FEFB RID: 65275
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FEFC RID: 65276
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400FEFD RID: 65277
		internal static int __PropertyOffset_EntityTypeName;

		// Token: 0x0400FEFE RID: 65278
		internal static int __PropertyOffset_ReasonName;

		// Token: 0x0400FEFF RID: 65279
		internal static int __PropertyOffset_Location;

		// Token: 0x0400FF00 RID: 65280
		internal static int __PropertyOffset_IsPreview;

		// Token: 0x0400FF01 RID: 65281
		internal static int __PropertyOffset_EntityIdKillBy;

		// Token: 0x0400FF02 RID: 65282
		internal static int __PropertyOffset_EntityTypeKillBy;
	}
}
