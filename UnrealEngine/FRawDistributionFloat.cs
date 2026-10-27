using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001067 RID: 4199
	[UnrealObjectPath("/Script/Engine.RawDistributionFloat")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRawDistributionFloat : FRawDistribution, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EEE8 RID: 61160 RVA: 0x0016261F File Offset: 0x0016081F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawDistributionFloat._ScriptStructPtr != 0) ? FRawDistributionFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RawDistributionFloat", ref FRawDistributionFloat._ScriptStructPtr);
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600EEE9 RID: 61161 RVA: 0x00162643 File Offset: 0x00160843
		// (set) Token: 0x0600EEEA RID: 61162 RVA: 0x00162653 File Offset: 0x00160853
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionFloat.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionFloat.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600EEEB RID: 61163 RVA: 0x00162664 File Offset: 0x00160864
		// (set) Token: 0x0600EEEC RID: 61164 RVA: 0x00162674 File Offset: 0x00160874
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawDistributionFloat.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawDistributionFloat.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600EEED RID: 61165 RVA: 0x00162685 File Offset: 0x00160885
		// (set) Token: 0x0600EEEE RID: 61166 RVA: 0x00162699 File Offset: 0x00160899
		[Nullable(2)]
		public unsafe UDistributionFloat Distribution
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRawDistributionFloat.__PropertyOffset_Distribution);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRawDistributionFloat.__PropertyOffset_Distribution, value);
			}
		}

		// Token: 0x0600EEEF RID: 61167 RVA: 0x001626AE File Offset: 0x001608AE
		public FRawDistributionFloat()
		{
		}

		// Token: 0x0600EEF0 RID: 61168 RVA: 0x001626B6 File Offset: 0x001608B6
		[NullableContext(1)]
		public FRawDistributionFloat(float MinValue, float MaxValue, UDistributionFloat Distribution, FDistributionLookupTable Table)
		{
			this.MinValue = MinValue;
			this.MaxValue = MaxValue;
			this.Distribution = Distribution;
			base.Table = Table;
		}

		// Token: 0x0600EEF1 RID: 61169 RVA: 0x001626DB File Offset: 0x001608DB
		protected override IntPtr GetUStructPtr()
		{
			return FRawDistributionFloat.StaticStruct();
		}

		// Token: 0x0600EEF2 RID: 61170 RVA: 0x001626E7 File Offset: 0x001608E7
		[NullableContext(2)]
		public FRawDistributionFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EEF3 RID: 61171 RVA: 0x001626F1 File Offset: 0x001608F1
		public FRawDistributionFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EEF4 RID: 61172 RVA: 0x001626FC File Offset: 0x001608FC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawDistributionFloat(Pointer, false, true);
		}

		// Token: 0x0600EEF5 RID: 61173 RVA: 0x00162706 File Offset: 0x00160906
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawDistributionFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400814D RID: 33101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RawDistributionFloat";

		// Token: 0x0400814E RID: 33102
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400814F RID: 33103
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04008150 RID: 33104
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04008151 RID: 33105
		internal static int __PropertyOffset_Distribution;
	}
}
