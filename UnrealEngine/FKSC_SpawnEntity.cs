using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E53 RID: 7763
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SpawnEntity")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKSC_SpawnEntity : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D8C9 RID: 121033 RVA: 0x002BA1DC File Offset: 0x002B83DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SpawnEntity._ScriptStructPtr != 0) ? FKSC_SpawnEntity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_SpawnEntity", ref FKSC_SpawnEntity._ScriptStructPtr);
		}

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x0601D8CA RID: 121034 RVA: 0x002BA200 File Offset: 0x002B8400
		// (set) Token: 0x0601D8CB RID: 121035 RVA: 0x002BA210 File Offset: 0x002B8410
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

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x0601D8CC RID: 121036 RVA: 0x002BA221 File Offset: 0x002B8421
		// (set) Token: 0x0601D8CD RID: 121037 RVA: 0x002BA235 File Offset: 0x002B8435
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

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x0601D8CE RID: 121038 RVA: 0x002BA24A File Offset: 0x002B844A
		// (set) Token: 0x0601D8CF RID: 121039 RVA: 0x002BA25A File Offset: 0x002B845A
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

		// Token: 0x0601D8D0 RID: 121040 RVA: 0x002BA26B File Offset: 0x002B846B
		public FKSC_SpawnEntity()
		{
		}

		// Token: 0x0601D8D1 RID: 121041 RVA: 0x002BA273 File Offset: 0x002B8473
		public FKSC_SpawnEntity(int EntityId, FTransformDouble EntityTrans, bool IsUseAbsoluteTrans)
		{
			this.EntityId = EntityId;
			this.EntityTrans = EntityTrans;
			this.IsUseAbsoluteTrans = IsUseAbsoluteTrans;
		}

		// Token: 0x0601D8D2 RID: 121042 RVA: 0x002BA290 File Offset: 0x002B8490
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_SpawnEntity.StaticStruct();
		}

		// Token: 0x0601D8D3 RID: 121043 RVA: 0x002BA29C File Offset: 0x002B849C
		[NullableContext(2)]
		public FKSC_SpawnEntity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D8D4 RID: 121044 RVA: 0x002BA2A6 File Offset: 0x002B84A6
		public FKSC_SpawnEntity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D8D5 RID: 121045 RVA: 0x002BA2B1 File Offset: 0x002B84B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_SpawnEntity(Pointer, false, true);
		}

		// Token: 0x0601D8D6 RID: 121046 RVA: 0x002BA2BB File Offset: 0x002B84BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_SpawnEntity(Pointer, MemoryOwner);
		}

		// Token: 0x0401004E RID: 65614
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SpawnEntity";

		// Token: 0x0401004F RID: 65615
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010050 RID: 65616
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04010051 RID: 65617
		internal static int __PropertyOffset_EntityTrans;

		// Token: 0x04010052 RID: 65618
		internal static int __PropertyOffset_IsUseAbsoluteTrans;
	}
}
