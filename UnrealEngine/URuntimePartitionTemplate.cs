using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C3 RID: 4291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimePartitionTemplate")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public abstract class URuntimePartitionTemplate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4D1 RID: 62673 RVA: 0x0016B014 File Offset: 0x00169214
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionTemplate._ClassPtr;
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x0600F4D2 RID: 62674 RVA: 0x0016B020 File Offset: 0x00169220
		// (set) Token: 0x0600F4D3 RID: 62675 RVA: 0x0016B034 File Offset: 0x00169234
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600F4D4 RID: 62676 RVA: 0x0016B049 File Offset: 0x00169249
		// (set) Token: 0x0600F4D5 RID: 62677 RVA: 0x0016B059 File Offset: 0x00169259
		public unsafe bool bBlockOnSlowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_bBlockOnSlowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_bBlockOnSlowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600F4D6 RID: 62678 RVA: 0x0016B06A File Offset: 0x0016926A
		// (set) Token: 0x0600F4D7 RID: 62679 RVA: 0x0016B07A File Offset: 0x0016927A
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600F4D8 RID: 62680 RVA: 0x0016B08B File Offset: 0x0016928B
		// (set) Token: 0x0600F4D9 RID: 62681 RVA: 0x0016B09B File Offset: 0x0016929B
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0600F4DA RID: 62682 RVA: 0x0016B0AC File Offset: 0x001692AC
		// (set) Token: 0x0600F4DB RID: 62683 RVA: 0x0016B0BC File Offset: 0x001692BC
		public unsafe ERuntimePartitionCellBoundsMethod BoundsMethod
		{
			get
			{
				return (ERuntimePartitionCellBoundsMethod)(*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_BoundsMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_BoundsMethod) = (byte)value;
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x0600F4DC RID: 62684 RVA: 0x0016B0CD File Offset: 0x001692CD
		// (set) Token: 0x0600F4DD RID: 62685 RVA: 0x0016B0DD File Offset: 0x001692DD
		public unsafe int MinLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_MinLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_MinLoadingRange) = value;
			}
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x0016B0EE File Offset: 0x001692EE
		// (set) Token: 0x0600F4DF RID: 62687 RVA: 0x0016B0FE File Offset: 0x001692FE
		public unsafe int MaxLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_MaxLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_MaxLoadingRange) = value;
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0600F4E0 RID: 62688 RVA: 0x0016B110 File Offset: 0x00169310
		// (set) Token: 0x0600F4E1 RID: 62689 RVA: 0x0016B149 File Offset: 0x00169349
		public FRuntimeFloatCurve ScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._ScaleCurve) == null)
				{
					result = (this._ScaleCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_ScaleCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_ScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0600F4E2 RID: 62690 RVA: 0x0016B16A File Offset: 0x0016936A
		// (set) Token: 0x0600F4E3 RID: 62691 RVA: 0x0016B17A File Offset: 0x0016937A
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600F4E4 RID: 62692 RVA: 0x0016B18B File Offset: 0x0016938B
		// (set) Token: 0x0600F4E5 RID: 62693 RVA: 0x0016B19F File Offset: 0x0016939F
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600F4E6 RID: 62694 RVA: 0x0016B1B4 File Offset: 0x001693B4
		// (set) Token: 0x0600F4E7 RID: 62695 RVA: 0x0016B1C4 File Offset: 0x001693C4
		public unsafe int HLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_HLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartitionTemplate.__PropertyOffset_HLODIndex) = value;
			}
		}

		// Token: 0x0600F4E8 RID: 62696 RVA: 0x0016B1D5 File Offset: 0x001693D5
		static URuntimePartitionTemplate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionTemplate");
		}

		// Token: 0x0600F4E9 RID: 62697 RVA: 0x0016B1E4 File Offset: 0x001693E4
		protected URuntimePartitionTemplate() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionTemplate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4EA RID: 62698 RVA: 0x0016B20C File Offset: 0x0016940C
		protected URuntimePartitionTemplate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084AC RID: 33964
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionTemplate";

		// Token: 0x040084AD RID: 33965
		private static IntPtr _ClassPtr;

		// Token: 0x040084AE RID: 33966
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040084AF RID: 33967
		internal static int __PropertyOffset_Name;

		// Token: 0x040084B0 RID: 33968
		internal static int __PropertyOffset_bBlockOnSlowStreaming;

		// Token: 0x040084B1 RID: 33969
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x040084B2 RID: 33970
		internal static int __PropertyOffset_Priority;

		// Token: 0x040084B3 RID: 33971
		internal static int __PropertyOffset_BoundsMethod;

		// Token: 0x040084B4 RID: 33972
		internal static int __PropertyOffset_MinLoadingRange;

		// Token: 0x040084B5 RID: 33973
		internal static int __PropertyOffset_MaxLoadingRange;

		// Token: 0x040084B6 RID: 33974
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x040084B7 RID: 33975
		[Nullable(2)]
		private FRuntimeFloatCurve _ScaleCurve;

		// Token: 0x040084B8 RID: 33976
		internal static int __PropertyOffset_ScaleMultiplier;

		// Token: 0x040084B9 RID: 33977
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x040084BA RID: 33978
		internal static int __PropertyOffset_HLODIndex;
	}
}
