using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD7 RID: 6871
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawner")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroCurveTrailDecalSpawner : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601997E RID: 104830 RVA: 0x0025D52F File Offset: 0x0025B72F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCurveTrailDecalSpawner._ClassPtr;
		}

		// Token: 0x0601997F RID: 104831 RVA: 0x0025D53C File Offset: 0x0025B73C
		public AKuroCurveTrailDecalSpawner() : this(BuiltinUtils.AllocNativeUObject(AKuroCurveTrailDecalSpawner.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019980 RID: 104832 RVA: 0x0025D564 File Offset: 0x0025B764
		[NullableContext(1)]
		public AKuroCurveTrailDecalSpawner(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCurveTrailDecalSpawner.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x06019981 RID: 104833 RVA: 0x0025D597 File Offset: 0x0025B797
		// (set) Token: 0x06019982 RID: 104834 RVA: 0x0025D5AB File Offset: 0x0025B7AB
		public unsafe UKuroCurveTrailDecalSpawnerComponent CurveTrailDecalSpawnerComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCurveTrailDecalSpawnerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCurveTrailDecalSpawner.__PropertyOffset_CurveTrailDecalSpawnerComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCurveTrailDecalSpawner.__PropertyOffset_CurveTrailDecalSpawnerComponent, value);
			}
		}

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x06019983 RID: 104835 RVA: 0x0025D5C0 File Offset: 0x0025B7C0
		// (set) Token: 0x06019984 RID: 104836 RVA: 0x0025D5D0 File Offset: 0x0025B7D0
		public unsafe bool bAutoTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCurveTrailDecalSpawner.__PropertyOffset_bAutoTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCurveTrailDecalSpawner.__PropertyOffset_bAutoTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x06019985 RID: 104837 RVA: 0x0025D5E1 File Offset: 0x0025B7E1
		// (set) Token: 0x06019986 RID: 104838 RVA: 0x0025D5F1 File Offset: 0x0025B7F1
		public unsafe float MinRecycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCurveTrailDecalSpawner.__PropertyOffset_MinRecycleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCurveTrailDecalSpawner.__PropertyOffset_MinRecycleTime) = value;
			}
		}

		// Token: 0x06019987 RID: 104839 RVA: 0x0025D602 File Offset: 0x0025B802
		public void StopTrail()
		{
			AKuroCurveTrailDecalSpawner.__StopTrail_Internal(base.NativePtr);
		}

		// Token: 0x06019988 RID: 104840 RVA: 0x0025D60F File Offset: 0x0025B80F
		public void StartTrail()
		{
			AKuroCurveTrailDecalSpawner.__StartTrail_Internal(base.NativePtr);
		}

		// Token: 0x06019989 RID: 104841 RVA: 0x0025D61C File Offset: 0x0025B81C
		public static void EndSpawner(USceneComponent AttachmentComp, UKuroCurveTrailDecalConfig Config, FName AttachSocketName)
		{
			AKuroCurveTrailDecalSpawner.__EndSpawner_Internal((AttachmentComp != null) ? AttachmentComp.NativePtr : IntPtr.Zero, (Config != null) ? Config.NativePtr : IntPtr.Zero, AttachSocketName);
		}

		// Token: 0x0601998A RID: 104842 RVA: 0x0025D644 File Offset: 0x0025B844
		public unsafe static AKuroCurveTrailDecalSpawner BeginSpawner(USceneComponent AttachmentComp, UKuroCurveTrailDecalConfig Config, FName AttachSocketName, in FTransform AttachTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = AttachTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroCurveTrailDecalSpawner>(AKuroCurveTrailDecalSpawner.__BeginSpawner_Internal((AttachmentComp != null) ? AttachmentComp.NativePtr : IntPtr.Zero, (Config != null) ? Config.NativePtr : IntPtr.Zero, AttachSocketName, ptr));
		}

		// Token: 0x0601998B RID: 104843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopTrail_Internal(IntPtr @this);

		// Token: 0x0601998C RID: 104844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTrail_Internal(IntPtr @this);

		// Token: 0x0601998D RID: 104845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndSpawner_Internal(IntPtr AttachmentComp, IntPtr Config, FName AttachSocketName);

		// Token: 0x0601998E RID: 104846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginSpawner_Internal(IntPtr AttachmentComp, IntPtr Config, FName AttachSocketName, in FTransform AttachTransform);

		// Token: 0x0601998F RID: 104847 RVA: 0x0025D699 File Offset: 0x0025B899
		static AKuroCurveTrailDecalSpawner()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawner");
		}

		// Token: 0x06019990 RID: 104848 RVA: 0x0025D6A7 File Offset: 0x0025B8A7
		protected AKuroCurveTrailDecalSpawner(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DEE4 RID: 57060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalSpawner";

		// Token: 0x0400DEE5 RID: 57061
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEE6 RID: 57062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DEE7 RID: 57063
		internal static int __PropertyOffset_CurveTrailDecalSpawnerComponent;

		// Token: 0x0400DEE8 RID: 57064
		internal static int __PropertyOffset_bAutoTrace;

		// Token: 0x0400DEE9 RID: 57065
		internal static int __PropertyOffset_MinRecycleTime;
	}
}
