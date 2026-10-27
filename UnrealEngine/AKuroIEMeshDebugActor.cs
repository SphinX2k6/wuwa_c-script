using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019A3 RID: 6563
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroIEMeshDebugActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AKuroIEMeshDebugActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060186AD RID: 100013 RVA: 0x0023FD84 File Offset: 0x0023DF84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroIEMeshDebugActor._ClassPtr;
		}

		// Token: 0x060186AE RID: 100014 RVA: 0x0023FD90 File Offset: 0x0023DF90
		public AKuroIEMeshDebugActor() : this(BuiltinUtils.AllocNativeUObject(AKuroIEMeshDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060186AF RID: 100015 RVA: 0x0023FDB8 File Offset: 0x0023DFB8
		[NullableContext(1)]
		public AKuroIEMeshDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroIEMeshDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x060186B0 RID: 100016 RVA: 0x0023FDEB File Offset: 0x0023DFEB
		// (set) Token: 0x060186B1 RID: 100017 RVA: 0x0023FDFF File Offset: 0x0023DFFF
		[Nullable(2)]
		public unsafe USceneComponent SceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroIEMeshDebugActor.__PropertyOffset_SceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroIEMeshDebugActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x060186B2 RID: 100018 RVA: 0x0023FE14 File Offset: 0x0023E014
		// (set) Token: 0x060186B3 RID: 100019 RVA: 0x0023FE24 File Offset: 0x0023E024
		public unsafe float LayoutPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_LayoutPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_LayoutPadding) = value;
			}
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x060186B4 RID: 100020 RVA: 0x0023FE35 File Offset: 0x0023E035
		// (set) Token: 0x060186B5 RID: 100021 RVA: 0x0023FE45 File Offset: 0x0023E045
		public unsafe float MaxRowWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_MaxRowWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_MaxRowWidth) = value;
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x060186B6 RID: 100022 RVA: 0x0023FE56 File Offset: 0x0023E056
		// (set) Token: 0x060186B7 RID: 100023 RVA: 0x0023FE6A File Offset: 0x0023E06A
		public unsafe FName GeneratedActorFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_GeneratedActorFolder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_GeneratedActorFolder) = value;
			}
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x060186B8 RID: 100024 RVA: 0x0023FE7F File Offset: 0x0023E07F
		// (set) Token: 0x060186B9 RID: 100025 RVA: 0x0023FE8F File Offset: 0x0023E08F
		public unsafe int CustomPrimitiveDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_CustomPrimitiveDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_CustomPrimitiveDataIndex) = value;
			}
		}

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x060186BA RID: 100026 RVA: 0x0023FEA0 File Offset: 0x0023E0A0
		// (set) Token: 0x060186BB RID: 100027 RVA: 0x0023FEB4 File Offset: 0x0023E0B4
		public unsafe FVector2D RandomCustomDataRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_RandomCustomDataRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroIEMeshDebugActor.__PropertyOffset_RandomCustomDataRange) = value;
			}
		}

		// Token: 0x060186BC RID: 100028 RVA: 0x0023FEC9 File Offset: 0x0023E0C9
		public void RebuildIEMeshDebugActors()
		{
			AKuroIEMeshDebugActor.__RebuildIEMeshDebugActors_Internal(base.NativePtr);
		}

		// Token: 0x060186BD RID: 100029 RVA: 0x0023FED6 File Offset: 0x0023E0D6
		public void ClearGeneratedIEMeshDebugActors()
		{
			AKuroIEMeshDebugActor.__ClearGeneratedIEMeshDebugActors_Internal(base.NativePtr);
		}

		// Token: 0x060186BE RID: 100030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildIEMeshDebugActors_Internal(IntPtr @this);

		// Token: 0x060186BF RID: 100031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearGeneratedIEMeshDebugActors_Internal(IntPtr @this);

		// Token: 0x060186C0 RID: 100032 RVA: 0x0023FEE3 File Offset: 0x0023E0E3
		static AKuroIEMeshDebugActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInteractionEffect.KuroIEMeshDebugActor");
		}

		// Token: 0x060186C1 RID: 100033 RVA: 0x0023FEF1 File Offset: 0x0023E0F1
		protected AKuroIEMeshDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D326 RID: 54054
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroIEMeshDebugActor";

		// Token: 0x0400D327 RID: 54055
		private static IntPtr _ClassPtr;

		// Token: 0x0400D328 RID: 54056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D329 RID: 54057
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400D32A RID: 54058
		internal static int __PropertyOffset_LayoutPadding;

		// Token: 0x0400D32B RID: 54059
		internal static int __PropertyOffset_MaxRowWidth;

		// Token: 0x0400D32C RID: 54060
		internal static int __PropertyOffset_GeneratedActorFolder;

		// Token: 0x0400D32D RID: 54061
		internal static int __PropertyOffset_CustomPrimitiveDataIndex;

		// Token: 0x0400D32E RID: 54062
		internal static int __PropertyOffset_RandomCustomDataRange;
	}
}
