using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B9 RID: 697
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.ConstraintDescription")]
	[UnrealStructLayout(13, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 13)]
	public class FConstraintDescription : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026D0 RID: 9936 RVA: 0x0003A569 File Offset: 0x00038769
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintDescription._ScriptStructPtr != 0) ? FConstraintDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.ConstraintDescription", ref FConstraintDescription._ScriptStructPtr);
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x0003A58D File Offset: 0x0003878D
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x0003A59D File Offset: 0x0003879D
		public unsafe bool bTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x0003A5AE File Offset: 0x000387AE
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0003A5BE File Offset: 0x000387BE
		public unsafe bool bRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0003A5CF File Offset: 0x000387CF
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0003A5DF File Offset: 0x000387DF
		public unsafe bool bScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0003A5F0 File Offset: 0x000387F0
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0003A600 File Offset: 0x00038800
		public unsafe bool bParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bParent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_bParent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0003A614 File Offset: 0x00038814
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0003A657 File Offset: 0x00038857
		public FFilterOptionPerAxis TranslationAxes
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._TranslationAxes) == null)
				{
					result = (this._TranslationAxes = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_TranslationAxes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_TranslationAxes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x0003A678 File Offset: 0x00038878
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0003A6BB File Offset: 0x000388BB
		public FFilterOptionPerAxis RotationAxes
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._RotationAxes) == null)
				{
					result = (this._RotationAxes = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_RotationAxes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_RotationAxes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0003A6DC File Offset: 0x000388DC
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0003A71F File Offset: 0x0003891F
		public FFilterOptionPerAxis ScaleAxes
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._ScaleAxes) == null)
				{
					result = (this._ScaleAxes = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_ScaleAxes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FConstraintDescription.__PropertyOffset_ScaleAxes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0003A740 File Offset: 0x00038940
		public FConstraintDescription()
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0003A748 File Offset: 0x00038948
		public FConstraintDescription(bool bTranslation, bool bRotation, bool bScale, bool bParent, FFilterOptionPerAxis TranslationAxes, FFilterOptionPerAxis RotationAxes, FFilterOptionPerAxis ScaleAxes)
		{
			this.bTranslation = bTranslation;
			this.bRotation = bRotation;
			this.bScale = bScale;
			this.bParent = bParent;
			this.TranslationAxes = TranslationAxes;
			this.RotationAxes = RotationAxes;
			this.ScaleAxes = ScaleAxes;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0003A785 File Offset: 0x00038985
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintDescription.StaticStruct();
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0003A791 File Offset: 0x00038991
		[NullableContext(2)]
		public FConstraintDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0003A79B File Offset: 0x0003899B
		public FConstraintDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0003A7A6 File Offset: 0x000389A6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintDescription(Pointer, false, true);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0003A7B0 File Offset: 0x000389B0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04000F40 RID: 3904
		public const string __ObjectPath = "/Script/AnimationCore.ConstraintDescription";

		// Token: 0x04000F41 RID: 3905
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F42 RID: 3906
		internal static int __PropertyOffset_bTranslation;

		// Token: 0x04000F43 RID: 3907
		internal static int __PropertyOffset_bRotation;

		// Token: 0x04000F44 RID: 3908
		internal static int __PropertyOffset_bScale;

		// Token: 0x04000F45 RID: 3909
		internal static int __PropertyOffset_bParent;

		// Token: 0x04000F46 RID: 3910
		internal static int __PropertyOffset_TranslationAxes;

		// Token: 0x04000F47 RID: 3911
		[Nullable(2)]
		private FFilterOptionPerAxis _TranslationAxes;

		// Token: 0x04000F48 RID: 3912
		internal static int __PropertyOffset_RotationAxes;

		// Token: 0x04000F49 RID: 3913
		[Nullable(2)]
		private FFilterOptionPerAxis _RotationAxes;

		// Token: 0x04000F4A RID: 3914
		internal static int __PropertyOffset_ScaleAxes;

		// Token: 0x04000F4B RID: 3915
		[Nullable(2)]
		private FFilterOptionPerAxis _ScaleAxes;
	}
}
