using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001D46 RID: 7494
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageTypeFilter")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKSC_DamageTypeFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601CB26 RID: 117542 RVA: 0x002A6BDC File Offset: 0x002A4DDC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_DamageTypeFilter._ScriptStructPtr != 0) ? FKSC_DamageTypeFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_DamageTypeFilter", ref FKSC_DamageTypeFilter._ScriptStructPtr);
		}

		// Token: 0x17007368 RID: 29544
		// (get) Token: 0x0601CB27 RID: 117543 RVA: 0x002A6C00 File Offset: 0x002A4E00
		// (set) Token: 0x0601CB28 RID: 117544 RVA: 0x002A6C10 File Offset: 0x002A4E10
		public unsafe EKSC_CalculateType CalculateType
		{
			get
			{
				return (EKSC_CalculateType)(*(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_CalculateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_CalculateType) = (byte)value;
			}
		}

		// Token: 0x17007369 RID: 29545
		// (get) Token: 0x0601CB29 RID: 117545 RVA: 0x002A6C24 File Offset: 0x002A4E24
		// (set) Token: 0x0601CB2A RID: 117546 RVA: 0x002A6C67 File Offset: 0x002A4E67
		public TArray<EKSC_CalculateType> CalculateTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_CalculateType> result;
				if ((result = this._CalculateTypes) == null)
				{
					result = (this._CalculateTypes = new TArray<EKSC_CalculateType>(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_CalculateTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalculateTypes.CopyAssign(value);
			}
		}

		// Token: 0x1700736A RID: 29546
		// (get) Token: 0x0601CB2B RID: 117547 RVA: 0x002A6C75 File Offset: 0x002A4E75
		// (set) Token: 0x0601CB2C RID: 117548 RVA: 0x002A6C85 File Offset: 0x002A4E85
		public unsafe bool IsNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_IsNot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_IsNot) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700736B RID: 29547
		// (get) Token: 0x0601CB2D RID: 117549 RVA: 0x002A6C98 File Offset: 0x002A4E98
		// (set) Token: 0x0601CB2E RID: 117550 RVA: 0x002A6CDB File Offset: 0x002A4EDB
		public TArray<EKSC_Element> ElementTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Element> result;
				if ((result = this._ElementTypes) == null)
				{
					result = (this._ElementTypes = new TArray<EKSC_Element>(base.NativePtr + (IntPtr)FKSC_DamageTypeFilter.__PropertyOffset_ElementTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ElementTypes.CopyAssign(value);
			}
		}

		// Token: 0x0601CB2F RID: 117551 RVA: 0x002A6CE9 File Offset: 0x002A4EE9
		public FKSC_DamageTypeFilter()
		{
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x002A6CF1 File Offset: 0x002A4EF1
		public FKSC_DamageTypeFilter(EKSC_CalculateType CalculateType, TArray<EKSC_CalculateType> CalculateTypes, bool IsNot, TArray<EKSC_Element> ElementTypes)
		{
			this.CalculateType = CalculateType;
			this.CalculateTypes = CalculateTypes;
			this.IsNot = IsNot;
			this.ElementTypes = ElementTypes;
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x002A6D16 File Offset: 0x002A4F16
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_DamageTypeFilter.StaticStruct();
		}

		// Token: 0x0601CB32 RID: 117554 RVA: 0x002A6D22 File Offset: 0x002A4F22
		[NullableContext(2)]
		public FKSC_DamageTypeFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601CB33 RID: 117555 RVA: 0x002A6D2C File Offset: 0x002A4F2C
		public FKSC_DamageTypeFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601CB34 RID: 117556 RVA: 0x002A6D37 File Offset: 0x002A4F37
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_DamageTypeFilter(Pointer, false, true);
		}

		// Token: 0x0601CB35 RID: 117557 RVA: 0x002A6D41 File Offset: 0x002A4F41
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_DamageTypeFilter(Pointer, MemoryOwner);
		}

		// Token: 0x0400F8EE RID: 63726
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageTypeFilter";

		// Token: 0x0400F8EF RID: 63727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F8F0 RID: 63728
		internal static int __PropertyOffset_CalculateType;

		// Token: 0x0400F8F1 RID: 63729
		internal static int __PropertyOffset_CalculateTypes;

		// Token: 0x0400F8F2 RID: 63730
		[Nullable(2)]
		private TArray<EKSC_CalculateType> _CalculateTypes;

		// Token: 0x0400F8F3 RID: 63731
		internal static int __PropertyOffset_IsNot;

		// Token: 0x0400F8F4 RID: 63732
		internal static int __PropertyOffset_ElementTypes;

		// Token: 0x0400F8F5 RID: 63733
		[Nullable(2)]
		private TArray<EKSC_Element> _ElementTypes;
	}
}
