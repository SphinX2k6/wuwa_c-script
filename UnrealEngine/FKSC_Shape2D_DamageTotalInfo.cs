using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000589 RID: 1417
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_Shape2D_DamageTotalInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008077 RID: 32887 RVA: 0x000BDCD7 File Offset: 0x000BBED7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr != 0) ? FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo", ref FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr);
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06008078 RID: 32888 RVA: 0x000BDCFB File Offset: 0x000BBEFB
		// (set) Token: 0x06008079 RID: 32889 RVA: 0x000BDD0B File Offset: 0x000BBF0B
		public unsafe int SourceEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_SourceEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_SourceEntityId) = value;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x000BDD1C File Offset: 0x000BBF1C
		// (set) Token: 0x0600807B RID: 32891 RVA: 0x000BDD2C File Offset: 0x000BBF2C
		public unsafe int TargetEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_TargetEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_TargetEntityId) = value;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x0600807C RID: 32892 RVA: 0x000BDD3D File Offset: 0x000BBF3D
		// (set) Token: 0x0600807D RID: 32893 RVA: 0x000BDD4D File Offset: 0x000BBF4D
		public unsafe int DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageId) = value;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x0600807E RID: 32894 RVA: 0x000BDD5E File Offset: 0x000BBF5E
		// (set) Token: 0x0600807F RID: 32895 RVA: 0x000BDD6E File Offset: 0x000BBF6E
		public unsafe int DamageValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageValue) = value;
			}
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x000BDD7F File Offset: 0x000BBF7F
		public FKSC_Shape2D_DamageTotalInfo()
		{
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x000BDD87 File Offset: 0x000BBF87
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Shape2D_DamageTotalInfo.StaticStruct();
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x000BDD93 File Offset: 0x000BBF93
		[NullableContext(2)]
		public FKSC_Shape2D_DamageTotalInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x000BDD9D File Offset: 0x000BBF9D
		public FKSC_Shape2D_DamageTotalInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x000BDDA8 File Offset: 0x000BBFA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Shape2D_DamageTotalInfo(Pointer, false, true);
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x000BDDB2 File Offset: 0x000BBFB2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Shape2D_DamageTotalInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003819 RID: 14361
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo";

		// Token: 0x0400381A RID: 14362
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400381B RID: 14363
		internal static int __PropertyOffset_SourceEntityId;

		// Token: 0x0400381C RID: 14364
		internal static int __PropertyOffset_TargetEntityId;

		// Token: 0x0400381D RID: 14365
		internal static int __PropertyOffset_DamageId;

		// Token: 0x0400381E RID: 14366
		internal static int __PropertyOffset_DamageValue;
	}
}
