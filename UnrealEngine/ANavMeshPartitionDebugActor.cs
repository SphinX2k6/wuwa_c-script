using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002635 RID: 9781
	[UnrealObjectPath("/Script/PathFindModule.NavMeshPartitionDebugActor")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class ANavMeshPartitionDebugActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245E2 RID: 148962 RVA: 0x0035D83F File Offset: 0x0035BA3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavMeshPartitionDebugActor._ClassPtr;
		}

		// Token: 0x060245E3 RID: 148963 RVA: 0x0035D84C File Offset: 0x0035BA4C
		public ANavMeshPartitionDebugActor() : this(BuiltinUtils.AllocNativeUObject(ANavMeshPartitionDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245E4 RID: 148964 RVA: 0x0035D874 File Offset: 0x0035BA74
		[NullableContext(1)]
		public ANavMeshPartitionDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavMeshPartitionDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C20 RID: 35872
		// (get) Token: 0x060245E5 RID: 148965 RVA: 0x0035D8A7 File Offset: 0x0035BAA7
		// (set) Token: 0x060245E6 RID: 148966 RVA: 0x0035D8C0 File Offset: 0x0035BAC0
		public unsafe bool bDrawTriangleEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTriangleEdges) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawTriangleEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTriangleEdges) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTriangleEdges) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawTriangleEdges) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawTriangleEdges : 0));
			}
		}

		// Token: 0x17008C21 RID: 35873
		// (get) Token: 0x060245E7 RID: 148967 RVA: 0x0035D8F0 File Offset: 0x0035BAF0
		// (set) Token: 0x060245E8 RID: 148968 RVA: 0x0035D909 File Offset: 0x0035BB09
		public unsafe bool bDrawPolyEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawPolyEdges) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawPolyEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawPolyEdges) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawPolyEdges) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawPolyEdges) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawPolyEdges : 0));
			}
		}

		// Token: 0x17008C22 RID: 35874
		// (get) Token: 0x060245E9 RID: 148969 RVA: 0x0035D939 File Offset: 0x0035BB39
		// (set) Token: 0x060245EA RID: 148970 RVA: 0x0035D952 File Offset: 0x0035BB52
		public unsafe bool bDrawFilledPolys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFilledPolys) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawFilledPolys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFilledPolys) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFilledPolys) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawFilledPolys) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawFilledPolys : 0));
			}
		}

		// Token: 0x17008C23 RID: 35875
		// (get) Token: 0x060245EB RID: 148971 RVA: 0x0035D982 File Offset: 0x0035BB82
		// (set) Token: 0x060245EC RID: 148972 RVA: 0x0035D99B File Offset: 0x0035BB9B
		public unsafe bool bDrawNavMeshEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavMeshEdges) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavMeshEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavMeshEdges) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavMeshEdges) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavMeshEdges) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavMeshEdges : 0));
			}
		}

		// Token: 0x17008C24 RID: 35876
		// (get) Token: 0x060245ED RID: 148973 RVA: 0x0035D9CB File Offset: 0x0035BBCB
		// (set) Token: 0x060245EE RID: 148974 RVA: 0x0035D9E4 File Offset: 0x0035BBE4
		public unsafe bool bDrawTileBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTileBounds) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawTileBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTileBounds) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawTileBounds) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawTileBounds) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawTileBounds : 0));
			}
		}

		// Token: 0x17008C25 RID: 35877
		// (get) Token: 0x060245EF RID: 148975 RVA: 0x0035DA14 File Offset: 0x0035BC14
		// (set) Token: 0x060245F0 RID: 148976 RVA: 0x0035DA2D File Offset: 0x0035BC2D
		public unsafe bool bDrawNavLinks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavLinks) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavLinks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavLinks) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawNavLinks) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavLinks) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawNavLinks : 0));
			}
		}

		// Token: 0x17008C26 RID: 35878
		// (get) Token: 0x060245F1 RID: 148977 RVA: 0x0035DA5D File Offset: 0x0035BC5D
		// (set) Token: 0x060245F2 RID: 148978 RVA: 0x0035DA76 File Offset: 0x0035BC76
		public unsafe bool bDrawFailedNavLinks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFailedNavLinks) & ANavMeshPartitionDebugActor.__PropertyMask_bDrawFailedNavLinks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFailedNavLinks) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bDrawFailedNavLinks) & ~ANavMeshPartitionDebugActor.__PropertyMask_bDrawFailedNavLinks) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bDrawFailedNavLinks : 0));
			}
		}

		// Token: 0x17008C27 RID: 35879
		// (get) Token: 0x060245F3 RID: 148979 RVA: 0x0035DAA6 File Offset: 0x0035BCA6
		// (set) Token: 0x060245F4 RID: 148980 RVA: 0x0035DABF File Offset: 0x0035BCBF
		public unsafe bool bEnableDraw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bEnableDraw) & ANavMeshPartitionDebugActor.__PropertyMask_bEnableDraw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bEnableDraw) = ((*(base.NativePtr + (IntPtr)ANavMeshPartitionDebugActor.__PropertyOffset_bEnableDraw) & ~ANavMeshPartitionDebugActor.__PropertyMask_bEnableDraw) | (value ? ANavMeshPartitionDebugActor.__PropertyMask_bEnableDraw : 0));
			}
		}

		// Token: 0x17008C28 RID: 35880
		// (get) Token: 0x060245F5 RID: 148981 RVA: 0x0035DAEF File Offset: 0x0035BCEF
		// (set) Token: 0x060245F6 RID: 148982 RVA: 0x0035DB03 File Offset: 0x0035BD03
		[Nullable(2)]
		public unsafe UNavMeshPartitionRenderingComponent RenderingComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavMeshPartitionRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavMeshPartitionDebugActor.__PropertyOffset_RenderingComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavMeshPartitionDebugActor.__PropertyOffset_RenderingComp, value);
			}
		}

		// Token: 0x060245F7 RID: 148983 RVA: 0x0035DB18 File Offset: 0x0035BD18
		public void OnDataLayerStateChanged(FName DataLayerLabel, EDataLayerState State)
		{
			ANavMeshPartitionDebugActor.__OnDataLayerStateChanged_Internal(base.NativePtr, DataLayerLabel, State);
		}

		// Token: 0x060245F8 RID: 148984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDataLayerStateChanged_Internal(IntPtr @this, FName DataLayerLabel, EDataLayerState State);

		// Token: 0x060245F9 RID: 148985 RVA: 0x0035DB27 File Offset: 0x0035BD27
		static ANavMeshPartitionDebugActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.NavMeshPartitionDebugActor");
		}

		// Token: 0x060245FA RID: 148986 RVA: 0x0035DB35 File Offset: 0x0035BD35
		protected ANavMeshPartitionDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013834 RID: 79924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PathFindModule.NavMeshPartitionDebugActor";

		// Token: 0x04013835 RID: 79925
		private static IntPtr _ClassPtr;

		// Token: 0x04013836 RID: 79926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013837 RID: 79927
		internal static int __PropertyOffset_bDrawTriangleEdges;

		// Token: 0x04013838 RID: 79928
		internal static byte __PropertyMask_bDrawTriangleEdges;

		// Token: 0x04013839 RID: 79929
		internal static int __PropertyOffset_bDrawPolyEdges;

		// Token: 0x0401383A RID: 79930
		internal static byte __PropertyMask_bDrawPolyEdges;

		// Token: 0x0401383B RID: 79931
		internal static int __PropertyOffset_bDrawFilledPolys;

		// Token: 0x0401383C RID: 79932
		internal static byte __PropertyMask_bDrawFilledPolys;

		// Token: 0x0401383D RID: 79933
		internal static int __PropertyOffset_bDrawNavMeshEdges;

		// Token: 0x0401383E RID: 79934
		internal static byte __PropertyMask_bDrawNavMeshEdges;

		// Token: 0x0401383F RID: 79935
		internal static int __PropertyOffset_bDrawTileBounds;

		// Token: 0x04013840 RID: 79936
		internal static byte __PropertyMask_bDrawTileBounds;

		// Token: 0x04013841 RID: 79937
		internal static int __PropertyOffset_bDrawNavLinks;

		// Token: 0x04013842 RID: 79938
		internal static byte __PropertyMask_bDrawNavLinks;

		// Token: 0x04013843 RID: 79939
		internal static int __PropertyOffset_bDrawFailedNavLinks;

		// Token: 0x04013844 RID: 79940
		internal static byte __PropertyMask_bDrawFailedNavLinks;

		// Token: 0x04013845 RID: 79941
		internal static int __PropertyOffset_bEnableDraw;

		// Token: 0x04013846 RID: 79942
		internal static byte __PropertyMask_bEnableDraw;

		// Token: 0x04013847 RID: 79943
		internal static int __PropertyOffset_RenderingComp;
	}
}
