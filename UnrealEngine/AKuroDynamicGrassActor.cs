using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE6 RID: 6886
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroDynamicGrassActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019AEA RID: 105194 RVA: 0x0025F2AD File Offset: 0x0025D4AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDynamicGrassActor._ClassPtr;
		}

		// Token: 0x06019AEB RID: 105195 RVA: 0x0025F2BC File Offset: 0x0025D4BC
		public AKuroDynamicGrassActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDynamicGrassActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019AEC RID: 105196 RVA: 0x0025F2E4 File Offset: 0x0025D4E4
		public AKuroDynamicGrassActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDynamicGrassActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x06019AED RID: 105197 RVA: 0x0025F317 File Offset: 0x0025D517
		// (set) Token: 0x06019AEE RID: 105198 RVA: 0x0025F327 File Offset: 0x0025D527
		public unsafe int GrassID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroDynamicGrassActor.__PropertyOffset_GrassID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroDynamicGrassActor.__PropertyOffset_GrassID) = value;
			}
		}

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x06019AEF RID: 105199 RVA: 0x0025F338 File Offset: 0x0025D538
		// (set) Token: 0x06019AF0 RID: 105200 RVA: 0x0025F371 File Offset: 0x0025D571
		public TArray<UHierarchicalInstancedStaticMeshComponent> GrassMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHierarchicalInstancedStaticMeshComponent> result;
				if ((result = this._GrassMeshComponents) == null)
				{
					result = (this._GrassMeshComponents = new TArray<UHierarchicalInstancedStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroDynamicGrassActor.__PropertyOffset_GrassMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.GrassMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x06019AF1 RID: 105201 RVA: 0x0025F37F File Offset: 0x0025D57F
		static AKuroDynamicGrassActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassActor");
		}

		// Token: 0x06019AF2 RID: 105202 RVA: 0x0025F38D File Offset: 0x0025D58D
		protected AKuroDynamicGrassActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF89 RID: 57225
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassActor";

		// Token: 0x0400DF8A RID: 57226
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF8B RID: 57227
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF8C RID: 57228
		internal static int __PropertyOffset_GrassID;

		// Token: 0x0400DF8D RID: 57229
		internal static int __PropertyOffset_GrassMeshComponents;

		// Token: 0x0400DF8E RID: 57230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHierarchicalInstancedStaticMeshComponent> _GrassMeshComponents;
	}
}
