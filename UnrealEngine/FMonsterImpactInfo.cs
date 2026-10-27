using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E62 RID: 7778
	[UnrealObjectPath("/Script/KuroSimpleCombat.MonsterImpactInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMonsterImpactInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DA4F RID: 121423 RVA: 0x002BC40C File Offset: 0x002BA60C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMonsterImpactInfo._ScriptStructPtr != 0) ? FMonsterImpactInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.MonsterImpactInfo", ref FMonsterImpactInfo._ScriptStructPtr);
		}

		// Token: 0x17007769 RID: 30569
		// (get) Token: 0x0601DA50 RID: 121424 RVA: 0x002BC430 File Offset: 0x002BA630
		// (set) Token: 0x0601DA51 RID: 121425 RVA: 0x002BC444 File Offset: 0x002BA644
		public unsafe FName EntityTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_EntityTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_EntityTypeName) = value;
			}
		}

		// Token: 0x1700776A RID: 30570
		// (get) Token: 0x0601DA52 RID: 121426 RVA: 0x002BC459 File Offset: 0x002BA659
		// (set) Token: 0x0601DA53 RID: 121427 RVA: 0x002BC469 File Offset: 0x002BA669
		public unsafe EKSC_EntityType EntityType
		{
			get
			{
				return (EKSC_EntityType)(*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_EntityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_EntityType) = (byte)value;
			}
		}

		// Token: 0x1700776B RID: 30571
		// (get) Token: 0x0601DA54 RID: 121428 RVA: 0x002BC47A File Offset: 0x002BA67A
		// (set) Token: 0x0601DA55 RID: 121429 RVA: 0x002BC48A File Offset: 0x002BA68A
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700776C RID: 30572
		// (get) Token: 0x0601DA56 RID: 121430 RVA: 0x002BC49B File Offset: 0x002BA69B
		// (set) Token: 0x0601DA57 RID: 121431 RVA: 0x002BC4AB File Offset: 0x002BA6AB
		public unsafe float Cooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_Cooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_Cooldown) = value;
			}
		}

		// Token: 0x1700776D RID: 30573
		// (get) Token: 0x0601DA58 RID: 121432 RVA: 0x002BC4BC File Offset: 0x002BA6BC
		// (set) Token: 0x0601DA59 RID: 121433 RVA: 0x002BC4CC File Offset: 0x002BA6CC
		public unsafe int DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMonsterImpactInfo.__PropertyOffset_DamageId) = value;
			}
		}

		// Token: 0x0601DA5A RID: 121434 RVA: 0x002BC4DD File Offset: 0x002BA6DD
		public FMonsterImpactInfo()
		{
		}

		// Token: 0x0601DA5B RID: 121435 RVA: 0x002BC4E5 File Offset: 0x002BA6E5
		public FMonsterImpactInfo(FName EntityTypeName, EKSC_EntityType EntityType, float Radius, float Cooldown, int DamageId)
		{
			this.EntityTypeName = EntityTypeName;
			this.EntityType = EntityType;
			this.Radius = Radius;
			this.Cooldown = Cooldown;
			this.DamageId = DamageId;
		}

		// Token: 0x0601DA5C RID: 121436 RVA: 0x002BC512 File Offset: 0x002BA712
		protected override IntPtr GetUStructPtr()
		{
			return FMonsterImpactInfo.StaticStruct();
		}

		// Token: 0x0601DA5D RID: 121437 RVA: 0x002BC51E File Offset: 0x002BA71E
		[NullableContext(2)]
		public FMonsterImpactInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA5E RID: 121438 RVA: 0x002BC528 File Offset: 0x002BA728
		public FMonsterImpactInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA5F RID: 121439 RVA: 0x002BC533 File Offset: 0x002BA733
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMonsterImpactInfo(Pointer, false, true);
		}

		// Token: 0x0601DA60 RID: 121440 RVA: 0x002BC53D File Offset: 0x002BA73D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMonsterImpactInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010105 RID: 65797
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.MonsterImpactInfo";

		// Token: 0x04010106 RID: 65798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010107 RID: 65799
		internal static int __PropertyOffset_EntityTypeName;

		// Token: 0x04010108 RID: 65800
		internal static int __PropertyOffset_EntityType;

		// Token: 0x04010109 RID: 65801
		internal static int __PropertyOffset_Radius;

		// Token: 0x0401010A RID: 65802
		internal static int __PropertyOffset_Cooldown;

		// Token: 0x0401010B RID: 65803
		internal static int __PropertyOffset_DamageId;
	}
}
