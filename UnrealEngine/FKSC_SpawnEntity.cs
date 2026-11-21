using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000593 RID: 1427
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SpawnEntity")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKSC_SpawnEntity : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008130 RID: 33072 RVA: 0x000BEB39 File Offset: 0x000BCD39
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SpawnEntity._ScriptStructPtr != 0) ? FKSC_SpawnEntity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_SpawnEntity", ref FKSC_SpawnEntity._ScriptStructPtr);
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x000BEB5D File Offset: 0x000BCD5D
		// (set) Token: 0x06008132 RID: 33074 RVA: 0x000BEB6D File Offset: 0x000BCD6D
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06008133 RID: 33075 RVA: 0x000BEB7E File Offset: 0x000BCD7E
		// (set) Token: 0x06008134 RID: 33076 RVA: 0x000BEB92 File Offset: 0x000BCD92
		public unsafe FTransformDouble EntityTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_EntityTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_EntityTrans) = value;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06008135 RID: 33077 RVA: 0x000BEBA7 File Offset: 0x000BCDA7
		// (set) Token: 0x06008136 RID: 33078 RVA: 0x000BEBB7 File Offset: 0x000BCDB7
		public unsafe bool IsUseAbsoluteTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_IsUseAbsoluteTrans) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpawnEntity.__PropertyOffset_IsUseAbsoluteTrans) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x000BEBC8 File Offset: 0x000BCDC8
		public FKSC_SpawnEntity()
		{
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x000BEBD0 File Offset: 0x000BCDD0
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_SpawnEntity.StaticStruct();
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x000BEBDC File Offset: 0x000BCDDC
		[NullableContext(2)]
		public FKSC_SpawnEntity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x000BEBE6 File Offset: 0x000BCDE6
		public FKSC_SpawnEntity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x000BEBF1 File Offset: 0x000BCDF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_SpawnEntity(Pointer, false, true);
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x000BEBFB File Offset: 0x000BCDFB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_SpawnEntity(Pointer, MemoryOwner);
		}

		// Token: 0x04003867 RID: 14439
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SpawnEntity";

		// Token: 0x04003868 RID: 14440
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003869 RID: 14441
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400386A RID: 14442
		internal static int __PropertyOffset_EntityTrans;

		// Token: 0x0400386B RID: 14443
		internal static int __PropertyOffset_IsUseAbsoluteTrans;
	}
}
