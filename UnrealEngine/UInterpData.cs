using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C79 RID: 3193
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpData")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UInterpData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A227 RID: 41511 RVA: 0x000E63A7 File Offset: 0x000E45A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpData._ClassPtr;
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x000E63B4 File Offset: 0x000E45B4
		public UInterpData() : this(BuiltinUtils.AllocNativeUObject(UInterpData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x000E63DC File Offset: 0x000E45DC
		public UInterpData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600A22A RID: 41514 RVA: 0x000E640F File Offset: 0x000E460F
		// (set) Token: 0x0600A22B RID: 41515 RVA: 0x000E641F File Offset: 0x000E461F
		public unsafe float InterpLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_InterpLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_InterpLength) = value;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x000E6430 File Offset: 0x000E4630
		// (set) Token: 0x0600A22D RID: 41517 RVA: 0x000E6440 File Offset: 0x000E4640
		public unsafe float PathBuildTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_PathBuildTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_PathBuildTime) = value;
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600A22E RID: 41518 RVA: 0x000E6454 File Offset: 0x000E4654
		// (set) Token: 0x0600A22F RID: 41519 RVA: 0x000E648D File Offset: 0x000E468D
		public TArray<UInterpGroup> InterpGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UInterpGroup> result;
				if ((result = this._InterpGroups) == null)
				{
					result = (this._InterpGroups = new TArray<UInterpGroup>(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_InterpGroups, this));
				}
				return result;
			}
			set
			{
				this.InterpGroups.CopyAssign(value);
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600A230 RID: 41520 RVA: 0x000E649B File Offset: 0x000E469B
		// (set) Token: 0x0600A231 RID: 41521 RVA: 0x000E64AF File Offset: 0x000E46AF
		[Nullable(2)]
		public unsafe UInterpCurveEdSetup CurveEdSetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpCurveEdSetup>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpData.__PropertyOffset_CurveEdSetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpData.__PropertyOffset_CurveEdSetup, value);
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600A232 RID: 41522 RVA: 0x000E64C4 File Offset: 0x000E46C4
		// (set) Token: 0x0600A233 RID: 41523 RVA: 0x000E64D4 File Offset: 0x000E46D4
		public unsafe float EdSectionStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_EdSectionStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_EdSectionStart) = value;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600A234 RID: 41524 RVA: 0x000E64E5 File Offset: 0x000E46E5
		// (set) Token: 0x0600A235 RID: 41525 RVA: 0x000E64F5 File Offset: 0x000E46F5
		public unsafe float EdSectionEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_EdSectionEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_EdSectionEnd) = value;
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600A236 RID: 41526 RVA: 0x000E6506 File Offset: 0x000E4706
		// (set) Token: 0x0600A237 RID: 41527 RVA: 0x000E651F File Offset: 0x000E471F
		public unsafe bool bShouldBakeAndPrune
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_bShouldBakeAndPrune) & UInterpData.__PropertyMask_bShouldBakeAndPrune) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpData.__PropertyOffset_bShouldBakeAndPrune) = ((*(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_bShouldBakeAndPrune) & ~UInterpData.__PropertyMask_bShouldBakeAndPrune) | (value ? UInterpData.__PropertyMask_bShouldBakeAndPrune : 0));
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x000E654F File Offset: 0x000E474F
		// (set) Token: 0x0600A239 RID: 41529 RVA: 0x000E6563 File Offset: 0x000E4763
		[Nullable(2)]
		public unsafe UInterpGroupDirector CachedDirectorGroup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpGroupDirector>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpData.__PropertyOffset_CachedDirectorGroup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpData.__PropertyOffset_CachedDirectorGroup, value);
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600A23A RID: 41530 RVA: 0x000E6578 File Offset: 0x000E4778
		// (set) Token: 0x0600A23B RID: 41531 RVA: 0x000E65B1 File Offset: 0x000E47B1
		public TArray<FName> AllEventNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AllEventNames) == null)
				{
					result = (this._AllEventNames = new TArray<FName>(base.NativePtr + (IntPtr)UInterpData.__PropertyOffset_AllEventNames, this));
				}
				return result;
			}
			set
			{
				this.AllEventNames.CopyAssign(value);
			}
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x000E65BF File Offset: 0x000E47BF
		static UInterpData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpData");
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x000E65CD File Offset: 0x000E47CD
		protected UInterpData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040058F9 RID: 22777
		public new const string __ObjectPath = "/Script/Engine.InterpData";

		// Token: 0x040058FA RID: 22778
		private static IntPtr _ClassPtr;

		// Token: 0x040058FB RID: 22779
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040058FC RID: 22780
		internal static int __PropertyOffset_InterpLength;

		// Token: 0x040058FD RID: 22781
		internal static int __PropertyOffset_PathBuildTime;

		// Token: 0x040058FE RID: 22782
		internal static int __PropertyOffset_InterpGroups;

		// Token: 0x040058FF RID: 22783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInterpGroup> _InterpGroups;

		// Token: 0x04005900 RID: 22784
		internal static int __PropertyOffset_CurveEdSetup;

		// Token: 0x04005901 RID: 22785
		internal static int __PropertyOffset_EdSectionStart;

		// Token: 0x04005902 RID: 22786
		internal static int __PropertyOffset_EdSectionEnd;

		// Token: 0x04005903 RID: 22787
		internal static int __PropertyOffset_bShouldBakeAndPrune;

		// Token: 0x04005904 RID: 22788
		internal static byte __PropertyMask_bShouldBakeAndPrune;

		// Token: 0x04005905 RID: 22789
		internal static int __PropertyOffset_CachedDirectorGroup;

		// Token: 0x04005906 RID: 22790
		internal static int __PropertyOffset_AllEventNames;

		// Token: 0x04005907 RID: 22791
		[Nullable(2)]
		private TArray<FName> _AllEventNames;
	}
}
