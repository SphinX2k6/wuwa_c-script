using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000583 RID: 1411
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RemoveContext")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKSC_RemoveContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008009 RID: 32777 RVA: 0x000BD490 File Offset: 0x000BB690
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_RemoveContext._ScriptStructPtr != 0) ? FKSC_RemoveContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_RemoveContext", ref FKSC_RemoveContext._ScriptStructPtr);
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600800A RID: 32778 RVA: 0x000BD4B4 File Offset: 0x000BB6B4
		// (set) Token: 0x0600800B RID: 32779 RVA: 0x000BD4C4 File Offset: 0x000BB6C4
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x000BD4D5 File Offset: 0x000BB6D5
		// (set) Token: 0x0600800D RID: 32781 RVA: 0x000BD4E9 File Offset: 0x000BB6E9
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

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x000BD4FE File Offset: 0x000BB6FE
		// (set) Token: 0x0600800F RID: 32783 RVA: 0x000BD512 File Offset: 0x000BB712
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

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x000BD527 File Offset: 0x000BB727
		// (set) Token: 0x06008011 RID: 32785 RVA: 0x000BD53B File Offset: 0x000BB73B
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x000BD550 File Offset: 0x000BB750
		// (set) Token: 0x06008013 RID: 32787 RVA: 0x000BD560 File Offset: 0x000BB760
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

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06008014 RID: 32788 RVA: 0x000BD571 File Offset: 0x000BB771
		// (set) Token: 0x06008015 RID: 32789 RVA: 0x000BD581 File Offset: 0x000BB781
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

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06008016 RID: 32790 RVA: 0x000BD592 File Offset: 0x000BB792
		// (set) Token: 0x06008017 RID: 32791 RVA: 0x000BD5A6 File Offset: 0x000BB7A6
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

		// Token: 0x06008018 RID: 32792 RVA: 0x000BD5BB File Offset: 0x000BB7BB
		public FKSC_RemoveContext()
		{
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x000BD5C3 File Offset: 0x000BB7C3
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_RemoveContext.StaticStruct();
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x000BD5CF File Offset: 0x000BB7CF
		[NullableContext(2)]
		public FKSC_RemoveContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x000BD5D9 File Offset: 0x000BB7D9
		public FKSC_RemoveContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_RemoveContext(Pointer, false, true);
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x000BD5EE File Offset: 0x000BB7EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_RemoveContext(Pointer, MemoryOwner);
		}

		// Token: 0x040037E4 RID: 14308
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RemoveContext";

		// Token: 0x040037E5 RID: 14309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037E6 RID: 14310
		internal static int __PropertyOffset_EntityId;

		// Token: 0x040037E7 RID: 14311
		internal static int __PropertyOffset_EntityTypeName;

		// Token: 0x040037E8 RID: 14312
		internal static int __PropertyOffset_ReasonName;

		// Token: 0x040037E9 RID: 14313
		internal static int __PropertyOffset_Location;

		// Token: 0x040037EA RID: 14314
		internal static int __PropertyOffset_IsPreview;

		// Token: 0x040037EB RID: 14315
		internal static int __PropertyOffset_EntityIdKillBy;

		// Token: 0x040037EC RID: 14316
		internal static int __PropertyOffset_EntityTypeKillBy;
	}
}
