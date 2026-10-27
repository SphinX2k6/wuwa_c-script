using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001068 RID: 4200
	[UnrealObjectPath("/Script/Engine.RawDistributionVector")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRawDistributionVector : FRawDistribution, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EEF6 RID: 61174 RVA: 0x0016270F File Offset: 0x0016090F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawDistributionVector._ScriptStructPtr != 0) ? FRawDistributionVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RawDistributionVector", ref FRawDistributionVector._ScriptStructPtr);
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600EEF7 RID: 61175 RVA: 0x00162733 File Offset: 0x00160933
		// (set) Token: 0x0600EEF8 RID: 61176 RVA: 0x00162743 File Offset: 0x00160943
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x00162754 File Offset: 0x00160954
		// (set) Token: 0x0600EEFA RID: 61178 RVA: 0x00162764 File Offset: 0x00160964
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600EEFB RID: 61179 RVA: 0x00162775 File Offset: 0x00160975
		// (set) Token: 0x0600EEFC RID: 61180 RVA: 0x00162789 File Offset: 0x00160989
		public unsafe FVector MinValueVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MinValueVec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MinValueVec) = value;
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600EEFD RID: 61181 RVA: 0x0016279E File Offset: 0x0016099E
		// (set) Token: 0x0600EEFE RID: 61182 RVA: 0x001627B2 File Offset: 0x001609B2
		public unsafe FVector MaxValueVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MaxValueVec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionVector.__PropertyOffset_MaxValueVec) = value;
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600EEFF RID: 61183 RVA: 0x001627C7 File Offset: 0x001609C7
		// (set) Token: 0x0600EF00 RID: 61184 RVA: 0x001627DB File Offset: 0x001609DB
		[Nullable(2)]
		public unsafe UDistributionVector Distribution
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionVector>(base.NativePtr / (IntPtr)sizeof(void*) + FRawDistributionVector.__PropertyOffset_Distribution);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRawDistributionVector.__PropertyOffset_Distribution, value);
			}
		}

		// Token: 0x0600EF01 RID: 61185 RVA: 0x001627F0 File Offset: 0x001609F0
		public FRawDistributionVector()
		{
		}

		// Token: 0x0600EF02 RID: 61186 RVA: 0x001627F8 File Offset: 0x001609F8
		[NullableContext(1)]
		public FRawDistributionVector(float MinValue, float MaxValue, FVector MinValueVec, FVector MaxValueVec, UDistributionVector Distribution, FDistributionLookupTable Table)
		{
			this.MinValue = MinValue;
			this.MaxValue = MaxValue;
			this.MinValueVec = MinValueVec;
			this.MaxValueVec = MaxValueVec;
			this.Distribution = Distribution;
			base.Table = Table;
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x0016282D File Offset: 0x00160A2D
		protected override IntPtr GetUStructPtr()
		{
			return FRawDistributionVector.StaticStruct();
		}

		// Token: 0x0600EF04 RID: 61188 RVA: 0x00162839 File Offset: 0x00160A39
		[NullableContext(2)]
		public FRawDistributionVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF05 RID: 61189 RVA: 0x00162843 File Offset: 0x00160A43
		public FRawDistributionVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF06 RID: 61190 RVA: 0x0016284E File Offset: 0x00160A4E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawDistributionVector(Pointer, false, true);
		}

		// Token: 0x0600EF07 RID: 61191 RVA: 0x00162858 File Offset: 0x00160A58
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawDistributionVector(Pointer, MemoryOwner);
		}

		// Token: 0x04008152 RID: 33106
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RawDistributionVector";

		// Token: 0x04008153 RID: 33107
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008154 RID: 33108
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04008155 RID: 33109
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04008156 RID: 33110
		internal static int __PropertyOffset_MinValueVec;

		// Token: 0x04008157 RID: 33111
		internal static int __PropertyOffset_MaxValueVec;

		// Token: 0x04008158 RID: 33112
		internal static int __PropertyOffset_Distribution;
	}
}
