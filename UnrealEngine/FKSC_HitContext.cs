using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DEB RID: 7659
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_HitContext")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSC_HitContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D45A RID: 119898 RVA: 0x002B39CC File Offset: 0x002B1BCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_HitContext._ScriptStructPtr != 0) ? FKSC_HitContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_HitContext", ref FKSC_HitContext._ScriptStructPtr);
		}

		// Token: 0x17007636 RID: 30262
		// (get) Token: 0x0601D45B RID: 119899 RVA: 0x002B39F0 File Offset: 0x002B1BF0
		// (set) Token: 0x0601D45C RID: 119900 RVA: 0x002B3A00 File Offset: 0x002B1C00
		public unsafe int ElementType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_ElementType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_ElementType) = value;
			}
		}

		// Token: 0x17007637 RID: 30263
		// (get) Token: 0x0601D45D RID: 119901 RVA: 0x002B3A11 File Offset: 0x002B1C11
		// (set) Token: 0x0601D45E RID: 119902 RVA: 0x002B3A25 File Offset: 0x002B1C25
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17007638 RID: 30264
		// (get) Token: 0x0601D45F RID: 119903 RVA: 0x002B3A3A File Offset: 0x002B1C3A
		// (set) Token: 0x0601D460 RID: 119904 RVA: 0x002B3A4A File Offset: 0x002B1C4A
		public unsafe int Damage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_Damage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_Damage) = value;
			}
		}

		// Token: 0x17007639 RID: 30265
		// (get) Token: 0x0601D461 RID: 119905 RVA: 0x002B3A5B File Offset: 0x002B1C5B
		// (set) Token: 0x0601D462 RID: 119906 RVA: 0x002B3A6B File Offset: 0x002B1C6B
		public unsafe bool IsCrit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsCrit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsCrit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700763A RID: 30266
		// (get) Token: 0x0601D463 RID: 119907 RVA: 0x002B3A7C File Offset: 0x002B1C7C
		// (set) Token: 0x0601D464 RID: 119908 RVA: 0x002B3A8C File Offset: 0x002B1C8C
		public unsafe bool IsCure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsCure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsCure) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700763B RID: 30267
		// (get) Token: 0x0601D465 RID: 119909 RVA: 0x002B3A9D File Offset: 0x002B1C9D
		// (set) Token: 0x0601D466 RID: 119910 RVA: 0x002B3AAD File Offset: 0x002B1CAD
		public unsafe bool IsShield
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsShield) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_IsShield) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700763C RID: 30268
		// (get) Token: 0x0601D467 RID: 119911 RVA: 0x002B3ABE File Offset: 0x002B1CBE
		// (set) Token: 0x0601D468 RID: 119912 RVA: 0x002B3ACE File Offset: 0x002B1CCE
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContext.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x1700763D RID: 30269
		// (get) Token: 0x0601D469 RID: 119913 RVA: 0x002B3ADF File Offset: 0x002B1CDF
		// (set) Token: 0x0601D46A RID: 119914 RVA: 0x002B3AF3 File Offset: 0x002B1CF3
		public unsafe string DamageText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_HitContext.__PropertyOffset_DamageText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_HitContext.__PropertyOffset_DamageText)), value);
			}
		}

		// Token: 0x0601D46B RID: 119915 RVA: 0x002B3B08 File Offset: 0x002B1D08
		public FKSC_HitContext()
		{
		}

		// Token: 0x0601D46C RID: 119916 RVA: 0x002B3B10 File Offset: 0x002B1D10
		public FKSC_HitContext(int ElementType, FVectorDouble Location, int Damage, bool IsCrit, bool IsCure, bool IsShield, int EntityId, string DamageText)
		{
			this.ElementType = ElementType;
			this.Location = Location;
			this.Damage = Damage;
			this.IsCrit = IsCrit;
			this.IsCure = IsCure;
			this.IsShield = IsShield;
			this.EntityId = EntityId;
			this.DamageText = DamageText;
		}

		// Token: 0x0601D46D RID: 119917 RVA: 0x002B3B60 File Offset: 0x002B1D60
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_HitContext.StaticStruct();
		}

		// Token: 0x0601D46E RID: 119918 RVA: 0x002B3B6C File Offset: 0x002B1D6C
		[NullableContext(2)]
		public FKSC_HitContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D46F RID: 119919 RVA: 0x002B3B76 File Offset: 0x002B1D76
		public FKSC_HitContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D470 RID: 119920 RVA: 0x002B3B81 File Offset: 0x002B1D81
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_HitContext(Pointer, false, true);
		}

		// Token: 0x0601D471 RID: 119921 RVA: 0x002B3B8B File Offset: 0x002B1D8B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_HitContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE2A RID: 65066
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_HitContext";

		// Token: 0x0400FE2B RID: 65067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE2C RID: 65068
		internal static int __PropertyOffset_ElementType;

		// Token: 0x0400FE2D RID: 65069
		internal static int __PropertyOffset_Location;

		// Token: 0x0400FE2E RID: 65070
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400FE2F RID: 65071
		internal static int __PropertyOffset_IsCrit;

		// Token: 0x0400FE30 RID: 65072
		internal static int __PropertyOffset_IsCure;

		// Token: 0x0400FE31 RID: 65073
		internal static int __PropertyOffset_IsShield;

		// Token: 0x0400FE32 RID: 65074
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400FE33 RID: 65075
		internal static int __PropertyOffset_DamageText;
	}
}
