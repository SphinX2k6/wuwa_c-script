using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD9 RID: 6873
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureVolume")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UKuroCustomCaptureVolume : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060199BA RID: 104890 RVA: 0x0025D969 File Offset: 0x0025BB69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomCaptureVolume._ClassPtr;
		}

		// Token: 0x060199BB RID: 104891 RVA: 0x0025D978 File Offset: 0x0025BB78
		public UKuroCustomCaptureVolume() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomCaptureVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060199BC RID: 104892 RVA: 0x0025D9A0 File Offset: 0x0025BBA0
		[NullableContext(1)]
		public UKuroCustomCaptureVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCustomCaptureVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x060199BD RID: 104893 RVA: 0x0025D9D3 File Offset: 0x0025BBD3
		// (set) Token: 0x060199BE RID: 104894 RVA: 0x0025D9E7 File Offset: 0x0025BBE7
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D CaptureRT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomCaptureVolume.__PropertyOffset_CaptureRT);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomCaptureVolume.__PropertyOffset_CaptureRT, value);
			}
		}

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x060199BF RID: 104895 RVA: 0x0025D9FC File Offset: 0x0025BBFC
		// (set) Token: 0x060199C0 RID: 104896 RVA: 0x0025DA10 File Offset: 0x0025BC10
		public unsafe FVector CapturePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CapturePos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CapturePos) = value;
			}
		}

		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x060199C1 RID: 104897 RVA: 0x0025DA25 File Offset: 0x0025BC25
		// (set) Token: 0x060199C2 RID: 104898 RVA: 0x0025DA35 File Offset: 0x0025BC35
		public unsafe float CutDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CutDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CutDistance) = value;
			}
		}

		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x060199C3 RID: 104899 RVA: 0x0025DA46 File Offset: 0x0025BC46
		// (set) Token: 0x060199C4 RID: 104900 RVA: 0x0025DA56 File Offset: 0x0025BC56
		public unsafe float OrthSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_OrthSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_OrthSizeX) = value;
			}
		}

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x060199C5 RID: 104901 RVA: 0x0025DA67 File Offset: 0x0025BC67
		// (set) Token: 0x060199C6 RID: 104902 RVA: 0x0025DA77 File Offset: 0x0025BC77
		public unsafe float OrthSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_OrthSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_OrthSizeY) = value;
			}
		}

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x060199C7 RID: 104903 RVA: 0x0025DA88 File Offset: 0x0025BC88
		// (set) Token: 0x060199C8 RID: 104904 RVA: 0x0025DAA1 File Offset: 0x0025BCA1
		public unsafe bool bCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bCapture) & UKuroCustomCaptureVolume.__PropertyMask_bCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bCapture) = ((*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bCapture) & ~UKuroCustomCaptureVolume.__PropertyMask_bCapture) | (value ? UKuroCustomCaptureVolume.__PropertyMask_bCapture : 0));
			}
		}

		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x060199C9 RID: 104905 RVA: 0x0025DAD1 File Offset: 0x0025BCD1
		// (set) Token: 0x060199CA RID: 104906 RVA: 0x0025DAE5 File Offset: 0x0025BCE5
		public unsafe TEnumAsByte<ECaptureMode> CaptureMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CaptureMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_CaptureMode) = value;
			}
		}

		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x060199CB RID: 104907 RVA: 0x0025DAFA File Offset: 0x0025BCFA
		// (set) Token: 0x060199CC RID: 104908 RVA: 0x0025DB13 File Offset: 0x0025BD13
		public unsafe bool bRenderAllPrimitives
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bRenderAllPrimitives) & UKuroCustomCaptureVolume.__PropertyMask_bRenderAllPrimitives) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bRenderAllPrimitives) = ((*(base.NativePtr + (IntPtr)UKuroCustomCaptureVolume.__PropertyOffset_bRenderAllPrimitives) & ~UKuroCustomCaptureVolume.__PropertyMask_bRenderAllPrimitives) | (value ? UKuroCustomCaptureVolume.__PropertyMask_bRenderAllPrimitives : 0));
			}
		}

		// Token: 0x060199CD RID: 104909 RVA: 0x0025DB43 File Offset: 0x0025BD43
		static UKuroCustomCaptureVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureVolume");
		}

		// Token: 0x060199CE RID: 104910 RVA: 0x0025DB51 File Offset: 0x0025BD51
		protected UKuroCustomCaptureVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DEFA RID: 57082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureVolume";

		// Token: 0x0400DEFB RID: 57083
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEFC RID: 57084
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DEFD RID: 57085
		internal static int __PropertyOffset_CaptureRT;

		// Token: 0x0400DEFE RID: 57086
		internal static int __PropertyOffset_CapturePos;

		// Token: 0x0400DEFF RID: 57087
		internal static int __PropertyOffset_CutDistance;

		// Token: 0x0400DF00 RID: 57088
		internal static int __PropertyOffset_OrthSizeX;

		// Token: 0x0400DF01 RID: 57089
		internal static int __PropertyOffset_OrthSizeY;

		// Token: 0x0400DF02 RID: 57090
		internal static int __PropertyOffset_bCapture;

		// Token: 0x0400DF03 RID: 57091
		internal static byte __PropertyMask_bCapture;

		// Token: 0x0400DF04 RID: 57092
		internal static int __PropertyOffset_CaptureMode;

		// Token: 0x0400DF05 RID: 57093
		internal static int __PropertyOffset_bRenderAllPrimitives;

		// Token: 0x0400DF06 RID: 57094
		internal static byte __PropertyMask_bRenderAllPrimitives;
	}
}
