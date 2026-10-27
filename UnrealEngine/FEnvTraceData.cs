using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001B6 RID: 438
	[UnrealObjectPath("/Script/AIModule.EnvTraceData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FEnvTraceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001A9F RID: 6815 RVA: 0x00027A3D File Offset: 0x00025C3D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvTraceData._ScriptStructPtr != 0) ? FEnvTraceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvTraceData", ref FEnvTraceData._ScriptStructPtr);
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00027A61 File Offset: 0x00025C61
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x00027A71 File Offset: 0x00025C71
		public unsafe int VersionNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_VersionNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_VersionNum) = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00027A82 File Offset: 0x00025C82
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x00027A96 File Offset: 0x00025C96
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> NavigationFilter
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_NavigationFilter);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_NavigationFilter) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00027AAB File Offset: 0x00025CAB
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00027ABB File Offset: 0x00025CBB
		public unsafe float ProjectDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ProjectDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ProjectDown) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00027ACC File Offset: 0x00025CCC
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x00027ADC File Offset: 0x00025CDC
		public unsafe float ProjectUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ProjectUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ProjectUp) = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00027AED File Offset: 0x00025CED
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x00027AFD File Offset: 0x00025CFD
		public unsafe float ExtentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentX) = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00027B0E File Offset: 0x00025D0E
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00027B1E File Offset: 0x00025D1E
		public unsafe float ExtentY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentY) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00027B2F File Offset: 0x00025D2F
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x00027B3F File Offset: 0x00025D3F
		public unsafe float ExtentZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_ExtentZ) = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00027B50 File Offset: 0x00025D50
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x00027B60 File Offset: 0x00025D60
		public unsafe float PostProjectionVerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_PostProjectionVerticalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_PostProjectionVerticalOffset) = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00027B71 File Offset: 0x00025D71
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00027B85 File Offset: 0x00025D85
		public unsafe TEnumAsByte<ETraceTypeQuery> TraceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00027B9A File Offset: 0x00025D9A
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00027BAE File Offset: 0x00025DAE
		public unsafe TEnumAsByte<ECollisionChannel> SerializedChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_SerializedChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_SerializedChannel) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00027BC3 File Offset: 0x00025DC3
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x00027BD7 File Offset: 0x00025DD7
		public unsafe TEnumAsByte<EEnvTraceShape> TraceShape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceShape);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceShape) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00027BEC File Offset: 0x00025DEC
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00027C00 File Offset: 0x00025E00
		public unsafe TEnumAsByte<EEnvQueryTrace> TraceMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_TraceMode) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00027C15 File Offset: 0x00025E15
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00027C2E File Offset: 0x00025E2E
		public unsafe bool bTraceComplex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bTraceComplex) & FEnvTraceData.__PropertyMask_bTraceComplex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bTraceComplex) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bTraceComplex) & ~FEnvTraceData.__PropertyMask_bTraceComplex) | (value ? FEnvTraceData.__PropertyMask_bTraceComplex : 0));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00027C5E File Offset: 0x00025E5E
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00027C77 File Offset: 0x00025E77
		public unsafe bool bOnlyBlockingHits
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bOnlyBlockingHits) & FEnvTraceData.__PropertyMask_bOnlyBlockingHits) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bOnlyBlockingHits) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bOnlyBlockingHits) & ~FEnvTraceData.__PropertyMask_bOnlyBlockingHits) | (value ? FEnvTraceData.__PropertyMask_bOnlyBlockingHits : 0));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00027CA7 File Offset: 0x00025EA7
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00027CC0 File Offset: 0x00025EC0
		public unsafe bool bCanTraceOnNavMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnNavMesh) & FEnvTraceData.__PropertyMask_bCanTraceOnNavMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnNavMesh) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnNavMesh) & ~FEnvTraceData.__PropertyMask_bCanTraceOnNavMesh) | (value ? FEnvTraceData.__PropertyMask_bCanTraceOnNavMesh : 0));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00027CF0 File Offset: 0x00025EF0
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x00027D09 File Offset: 0x00025F09
		public unsafe bool bCanTraceOnGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnGeometry) & FEnvTraceData.__PropertyMask_bCanTraceOnGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnGeometry) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanTraceOnGeometry) & ~FEnvTraceData.__PropertyMask_bCanTraceOnGeometry) | (value ? FEnvTraceData.__PropertyMask_bCanTraceOnGeometry : 0));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00027D39 File Offset: 0x00025F39
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x00027D52 File Offset: 0x00025F52
		public unsafe bool bCanDisableTrace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanDisableTrace) & FEnvTraceData.__PropertyMask_bCanDisableTrace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanDisableTrace) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanDisableTrace) & ~FEnvTraceData.__PropertyMask_bCanDisableTrace) | (value ? FEnvTraceData.__PropertyMask_bCanDisableTrace : 0));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00027D82 File Offset: 0x00025F82
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x00027D9B File Offset: 0x00025F9B
		public unsafe bool bCanProjectDown
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanProjectDown) & FEnvTraceData.__PropertyMask_bCanProjectDown) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanProjectDown) = ((*(base.NativePtr + (IntPtr)FEnvTraceData.__PropertyOffset_bCanProjectDown) & ~FEnvTraceData.__PropertyMask_bCanProjectDown) | (value ? FEnvTraceData.__PropertyMask_bCanProjectDown : 0));
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00027DCB File Offset: 0x00025FCB
		public FEnvTraceData()
		{
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00027DD4 File Offset: 0x00025FD4
		public FEnvTraceData(int VersionNum, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> NavigationFilter, float ProjectDown, float ProjectUp, float ExtentX, float ExtentY, float ExtentZ, float PostProjectionVerticalOffset, TEnumAsByte<ETraceTypeQuery> TraceChannel, TEnumAsByte<ECollisionChannel> SerializedChannel, TEnumAsByte<EEnvTraceShape> TraceShape, TEnumAsByte<EEnvQueryTrace> TraceMode, bool bTraceComplex, bool bOnlyBlockingHits, bool bCanTraceOnNavMesh, bool bCanTraceOnGeometry, bool bCanDisableTrace, bool bCanProjectDown)
		{
			this.VersionNum = VersionNum;
			this.NavigationFilter = NavigationFilter;
			this.ProjectDown = ProjectDown;
			this.ProjectUp = ProjectUp;
			this.ExtentX = ExtentX;
			this.ExtentY = ExtentY;
			this.ExtentZ = ExtentZ;
			this.PostProjectionVerticalOffset = PostProjectionVerticalOffset;
			this.TraceChannel = TraceChannel;
			this.SerializedChannel = SerializedChannel;
			this.TraceShape = TraceShape;
			this.TraceMode = TraceMode;
			this.bTraceComplex = bTraceComplex;
			this.bOnlyBlockingHits = bOnlyBlockingHits;
			this.bCanTraceOnNavMesh = bCanTraceOnNavMesh;
			this.bCanTraceOnGeometry = bCanTraceOnGeometry;
			this.bCanDisableTrace = bCanDisableTrace;
			this.bCanProjectDown = bCanProjectDown;
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00027E74 File Offset: 0x00026074
		protected override IntPtr GetUStructPtr()
		{
			return FEnvTraceData.StaticStruct();
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00027E80 File Offset: 0x00026080
		[NullableContext(2)]
		public FEnvTraceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00027E8A File Offset: 0x0002608A
		public FEnvTraceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00027E95 File Offset: 0x00026095
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvTraceData(Pointer, false, true);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00027E9F File Offset: 0x0002609F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvTraceData(Pointer, MemoryOwner);
		}

		// Token: 0x04000822 RID: 2082
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvTraceData";

		// Token: 0x04000823 RID: 2083
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000824 RID: 2084
		internal static int __PropertyOffset_VersionNum;

		// Token: 0x04000825 RID: 2085
		internal static int __PropertyOffset_NavigationFilter;

		// Token: 0x04000826 RID: 2086
		internal static int __PropertyOffset_ProjectDown;

		// Token: 0x04000827 RID: 2087
		internal static int __PropertyOffset_ProjectUp;

		// Token: 0x04000828 RID: 2088
		internal static int __PropertyOffset_ExtentX;

		// Token: 0x04000829 RID: 2089
		internal static int __PropertyOffset_ExtentY;

		// Token: 0x0400082A RID: 2090
		internal static int __PropertyOffset_ExtentZ;

		// Token: 0x0400082B RID: 2091
		internal static int __PropertyOffset_PostProjectionVerticalOffset;

		// Token: 0x0400082C RID: 2092
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x0400082D RID: 2093
		internal static int __PropertyOffset_SerializedChannel;

		// Token: 0x0400082E RID: 2094
		internal static int __PropertyOffset_TraceShape;

		// Token: 0x0400082F RID: 2095
		internal static int __PropertyOffset_TraceMode;

		// Token: 0x04000830 RID: 2096
		internal static int __PropertyOffset_bTraceComplex;

		// Token: 0x04000831 RID: 2097
		internal static byte __PropertyMask_bTraceComplex;

		// Token: 0x04000832 RID: 2098
		internal static int __PropertyOffset_bOnlyBlockingHits;

		// Token: 0x04000833 RID: 2099
		internal static byte __PropertyMask_bOnlyBlockingHits;

		// Token: 0x04000834 RID: 2100
		internal static int __PropertyOffset_bCanTraceOnNavMesh;

		// Token: 0x04000835 RID: 2101
		internal static byte __PropertyMask_bCanTraceOnNavMesh;

		// Token: 0x04000836 RID: 2102
		internal static int __PropertyOffset_bCanTraceOnGeometry;

		// Token: 0x04000837 RID: 2103
		internal static byte __PropertyMask_bCanTraceOnGeometry;

		// Token: 0x04000838 RID: 2104
		internal static int __PropertyOffset_bCanDisableTrace;

		// Token: 0x04000839 RID: 2105
		internal static byte __PropertyMask_bCanDisableTrace;

		// Token: 0x0400083A RID: 2106
		internal static int __PropertyOffset_bCanProjectDown;

		// Token: 0x0400083B RID: 2107
		internal static byte __PropertyMask_bCanProjectDown;
	}
}
