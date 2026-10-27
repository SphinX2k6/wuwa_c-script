using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD5 RID: 6869
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalComponent")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2336)]
	public class UKuroCurveTrailDecalComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019950 RID: 104784 RVA: 0x0025D244 File Offset: 0x0025B444
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCurveTrailDecalComponent._ClassPtr;
		}

		// Token: 0x06019951 RID: 104785 RVA: 0x0025D250 File Offset: 0x0025B450
		public UKuroCurveTrailDecalComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x0025D278 File Offset: 0x0025B478
		[NullableContext(1)]
		public UKuroCurveTrailDecalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700662D RID: 26157
		// (get) Token: 0x06019953 RID: 104787 RVA: 0x0025D2AB File Offset: 0x0025B4AB
		// (set) Token: 0x06019954 RID: 104788 RVA: 0x0025D2BF File Offset: 0x0025B4BF
		[Nullable(2)]
		public unsafe UStaticMesh DecalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalComponent.__PropertyOffset_DecalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalComponent.__PropertyOffset_DecalMesh, value);
			}
		}

		// Token: 0x1700662E RID: 26158
		// (get) Token: 0x06019955 RID: 104789 RVA: 0x0025D2D4 File Offset: 0x0025B4D4
		// (set) Token: 0x06019956 RID: 104790 RVA: 0x0025D2E4 File Offset: 0x0025B4E4
		public unsafe float TangentFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalComponent.__PropertyOffset_TangentFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalComponent.__PropertyOffset_TangentFactor) = value;
			}
		}

		// Token: 0x06019957 RID: 104791 RVA: 0x0025D2F5 File Offset: 0x0025B4F5
		public void RequireNewGroup()
		{
			UKuroCurveTrailDecalComponent.__RequireNewGroup_Internal(base.NativePtr);
		}

		// Token: 0x06019958 RID: 104792 RVA: 0x0025D302 File Offset: 0x0025B502
		public void RemoveFront()
		{
			UKuroCurveTrailDecalComponent.__RemoveFront_Internal(base.NativePtr);
		}

		// Token: 0x06019959 RID: 104793 RVA: 0x0025D30F File Offset: 0x0025B50F
		public void ManualUpdate(float DeltaTime)
		{
			UKuroCurveTrailDecalComponent.__ManualUpdate_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601995A RID: 104794 RVA: 0x0025D31D File Offset: 0x0025B51D
		public int GetNumPointsInActiveGroup()
		{
			return UKuroCurveTrailDecalComponent.__GetNumPointsInActiveGroup_Internal(base.NativePtr);
		}

		// Token: 0x0601995B RID: 104795 RVA: 0x0025D32A File Offset: 0x0025B52A
		public bool GetIsEmpty()
		{
			return UKuroCurveTrailDecalComponent.__GetIsEmpty_Internal(base.NativePtr);
		}

		// Token: 0x0601995C RID: 104796 RVA: 0x0025D337 File Offset: 0x0025B537
		public void ClearPoints()
		{
			UKuroCurveTrailDecalComponent.__ClearPoints_Internal(base.NativePtr);
		}

		// Token: 0x0601995D RID: 104797 RVA: 0x0025D344 File Offset: 0x0025B544
		public void AppendPoint(in FVector Position, in FVector Direction, in FVector UpVector, bool bFixFront = false, bool bUseAutoDirection = false)
		{
			UKuroCurveTrailDecalComponent.__AppendPoint_Internal(base.NativePtr, Position, Direction, UpVector, bFixFront, bUseAutoDirection);
		}

		// Token: 0x0601995E RID: 104798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequireNewGroup_Internal(IntPtr @this);

		// Token: 0x0601995F RID: 104799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFront_Internal(IntPtr @this);

		// Token: 0x06019960 RID: 104800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualUpdate_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06019961 RID: 104801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPointsInActiveGroup_Internal(IntPtr @this);

		// Token: 0x06019962 RID: 104802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsEmpty_Internal(IntPtr @this);

		// Token: 0x06019963 RID: 104803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearPoints_Internal(IntPtr @this);

		// Token: 0x06019964 RID: 104804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AppendPoint_Internal(IntPtr @this, in FVector Position, in FVector Direction, in FVector UpVector, bool bFixFront, bool bUseAutoDirection);

		// Token: 0x06019965 RID: 104805 RVA: 0x0025D358 File Offset: 0x0025B558
		static UKuroCurveTrailDecalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalComponent");
		}

		// Token: 0x06019966 RID: 104806 RVA: 0x0025D366 File Offset: 0x0025B566
		protected UKuroCurveTrailDecalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DED3 RID: 57043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalComponent";

		// Token: 0x0400DED4 RID: 57044
		private static IntPtr _ClassPtr;

		// Token: 0x0400DED5 RID: 57045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DED6 RID: 57046
		internal static int __PropertyOffset_DecalMesh;

		// Token: 0x0400DED7 RID: 57047
		internal static int __PropertyOffset_TangentFactor;
	}
}
