using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD8 RID: 6872
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawnerComponent")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UKuroCurveTrailDecalSpawnerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019991 RID: 104849 RVA: 0x0025D6B0 File Offset: 0x0025B8B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCurveTrailDecalSpawnerComponent._ClassPtr;
		}

		// Token: 0x06019992 RID: 104850 RVA: 0x0025D6BC File Offset: 0x0025B8BC
		public UKuroCurveTrailDecalSpawnerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalSpawnerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019993 RID: 104851 RVA: 0x0025D6E4 File Offset: 0x0025B8E4
		[NullableContext(1)]
		public UKuroCurveTrailDecalSpawnerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalSpawnerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x06019994 RID: 104852 RVA: 0x0025D717 File Offset: 0x0025B917
		// (set) Token: 0x06019995 RID: 104853 RVA: 0x0025D72B File Offset: 0x0025B92B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKuroCurveTrailDecalComponent> CurveDecalBlueprint
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveDecalBlueprint);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveDecalBlueprint) = value;
			}
		}

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x06019996 RID: 104854 RVA: 0x0025D740 File Offset: 0x0025B940
		// (set) Token: 0x06019997 RID: 104855 RVA: 0x0025D754 File Offset: 0x0025B954
		public unsafe AActor CurveTrailDecalActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveTrailDecalActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveTrailDecalActor, value);
			}
		}

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x06019998 RID: 104856 RVA: 0x0025D769 File Offset: 0x0025B969
		// (set) Token: 0x06019999 RID: 104857 RVA: 0x0025D77D File Offset: 0x0025B97D
		public unsafe UKuroCurveTrailDecalComponent CurveTrailDecalComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCurveTrailDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveTrailDecalComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveTrailDecalComponent, value);
			}
		}

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0601999A RID: 104858 RVA: 0x0025D792 File Offset: 0x0025B992
		// (set) Token: 0x0601999B RID: 104859 RVA: 0x0025D7A6 File Offset: 0x0025B9A6
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0601999C RID: 104860 RVA: 0x0025D7BB File Offset: 0x0025B9BB
		// (set) Token: 0x0601999D RID: 104861 RVA: 0x0025D7CB File Offset: 0x0025B9CB
		public unsafe bool DoTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_DoTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_DoTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x0601999E RID: 104862 RVA: 0x0025D7DC File Offset: 0x0025B9DC
		// (set) Token: 0x0601999F RID: 104863 RVA: 0x0025D7F0 File Offset: 0x0025B9F0
		public unsafe FVector TraceStartLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceStartLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceStartLocal) = value;
			}
		}

		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x060199A0 RID: 104864 RVA: 0x0025D805 File Offset: 0x0025BA05
		// (set) Token: 0x060199A1 RID: 104865 RVA: 0x0025D819 File Offset: 0x0025BA19
		public unsafe FVector TraceEndLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceEndLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceEndLocal) = value;
			}
		}

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x060199A2 RID: 104866 RVA: 0x0025D82E File Offset: 0x0025BA2E
		// (set) Token: 0x060199A3 RID: 104867 RVA: 0x0025D83E File Offset: 0x0025BA3E
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceRadius) = value;
			}
		}

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x060199A4 RID: 104868 RVA: 0x0025D84F File Offset: 0x0025BA4F
		// (set) Token: 0x060199A5 RID: 104869 RVA: 0x0025D85F File Offset: 0x0025BA5F
		public unsafe float TraceCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceCorrect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceCorrect) = value;
			}
		}

		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x060199A6 RID: 104870 RVA: 0x0025D870 File Offset: 0x0025BA70
		// (set) Token: 0x060199A7 RID: 104871 RVA: 0x0025D880 File Offset: 0x0025BA80
		public unsafe float SpawnThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_SpawnThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_SpawnThreshold) = value;
			}
		}

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x060199A8 RID: 104872 RVA: 0x0025D891 File Offset: 0x0025BA91
		// (set) Token: 0x060199A9 RID: 104873 RVA: 0x0025D8A1 File Offset: 0x0025BAA1
		public unsafe float CurveLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_CurveLifeTime) = value;
			}
		}

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x060199AA RID: 104874 RVA: 0x0025D8B2 File Offset: 0x0025BAB2
		// (set) Token: 0x060199AB RID: 104875 RVA: 0x0025D8C2 File Offset: 0x0025BAC2
		public unsafe bool DebugTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_DebugTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_DebugTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x060199AC RID: 104876 RVA: 0x0025D8D3 File Offset: 0x0025BAD3
		// (set) Token: 0x060199AD RID: 104877 RVA: 0x0025D8E7 File Offset: 0x0025BAE7
		public unsafe UTraceSphereElement TraceElement
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceSphereElement>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceElement);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalSpawnerComponent.__PropertyOffset_TraceElement, value);
			}
		}

		// Token: 0x060199AE RID: 104878 RVA: 0x0025D8FC File Offset: 0x0025BAFC
		public void SpawnByTrace()
		{
			UKuroCurveTrailDecalSpawnerComponent.__SpawnByTrace_Internal(base.NativePtr);
		}

		// Token: 0x060199AF RID: 104879 RVA: 0x0025D909 File Offset: 0x0025BB09
		public void RequireNewGroup()
		{
			UKuroCurveTrailDecalSpawnerComponent.__RequireNewGroup_Internal(base.NativePtr);
		}

		// Token: 0x060199B0 RID: 104880 RVA: 0x0025D916 File Offset: 0x0025BB16
		public void ReceiveAsyncTrace(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			UKuroCurveTrailDecalSpawnerComponent.__ReceiveAsyncTrace_Internal(base.NativePtr, Result, (Element != null) ? Element.NativePtr : IntPtr.Zero, Frame, Index);
		}

		// Token: 0x060199B1 RID: 104881 RVA: 0x0025D937 File Offset: 0x0025BB37
		public void ManualUpdate(float DeltaTime)
		{
			UKuroCurveTrailDecalSpawnerComponent.__ManualUpdate_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x060199B2 RID: 104882 RVA: 0x0025D945 File Offset: 0x0025BB45
		public bool HasAnyTrail()
		{
			return UKuroCurveTrailDecalSpawnerComponent.__HasAnyTrail_Internal(base.NativePtr);
		}

		// Token: 0x060199B3 RID: 104883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnByTrace_Internal(IntPtr @this);

		// Token: 0x060199B4 RID: 104884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequireNewGroup_Internal(IntPtr @this);

		// Token: 0x060199B5 RID: 104885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAsyncTrace_Internal(IntPtr @this, bool Result, IntPtr Element, double Frame, double Index);

		// Token: 0x060199B6 RID: 104886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualUpdate_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x060199B7 RID: 104887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyTrail_Internal(IntPtr @this);

		// Token: 0x060199B8 RID: 104888 RVA: 0x0025D952 File Offset: 0x0025BB52
		static UKuroCurveTrailDecalSpawnerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawnerComponent");
		}

		// Token: 0x060199B9 RID: 104889 RVA: 0x0025D960 File Offset: 0x0025BB60
		protected UKuroCurveTrailDecalSpawnerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DEEA RID: 57066
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawnerComponent";

		// Token: 0x0400DEEB RID: 57067
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEEC RID: 57068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DEED RID: 57069
		internal static int __PropertyOffset_CurveDecalBlueprint;

		// Token: 0x0400DEEE RID: 57070
		internal static int __PropertyOffset_CurveTrailDecalActor;

		// Token: 0x0400DEEF RID: 57071
		internal static int __PropertyOffset_CurveTrailDecalComponent;

		// Token: 0x0400DEF0 RID: 57072
		internal static int __PropertyOffset_Material;

		// Token: 0x0400DEF1 RID: 57073
		internal static int __PropertyOffset_DoTrace;

		// Token: 0x0400DEF2 RID: 57074
		internal static int __PropertyOffset_TraceStartLocal;

		// Token: 0x0400DEF3 RID: 57075
		internal static int __PropertyOffset_TraceEndLocal;

		// Token: 0x0400DEF4 RID: 57076
		internal static int __PropertyOffset_TraceRadius;

		// Token: 0x0400DEF5 RID: 57077
		internal static int __PropertyOffset_TraceCorrect;

		// Token: 0x0400DEF6 RID: 57078
		internal static int __PropertyOffset_SpawnThreshold;

		// Token: 0x0400DEF7 RID: 57079
		internal static int __PropertyOffset_CurveLifeTime;

		// Token: 0x0400DEF8 RID: 57080
		internal static int __PropertyOffset_DebugTrace;

		// Token: 0x0400DEF9 RID: 57081
		internal static int __PropertyOffset_TraceElement;
	}
}
