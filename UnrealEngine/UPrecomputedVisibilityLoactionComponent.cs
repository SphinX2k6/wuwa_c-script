using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200102A RID: 4138
	[UnrealObjectPath("/Script/Engine.PrecomputedVisibilityLoactionComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UPrecomputedVisibilityLoactionComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E8DE RID: 59614 RVA: 0x00159F04 File Offset: 0x00158104
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrecomputedVisibilityLoactionComponent._ClassPtr;
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x00159F10 File Offset: 0x00158110
		public UPrecomputedVisibilityLoactionComponent() : this(BuiltinUtils.AllocNativeUObject(UPrecomputedVisibilityLoactionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x00159F38 File Offset: 0x00158138
		[NullableContext(1)]
		public UPrecomputedVisibilityLoactionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrecomputedVisibilityLoactionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600E8E1 RID: 59617 RVA: 0x00159F6B File Offset: 0x0015816B
		// (set) Token: 0x0600E8E2 RID: 59618 RVA: 0x00159F7F File Offset: 0x0015817F
		public unsafe FIntPoint Coord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrecomputedVisibilityLoactionComponent.__PropertyOffset_Coord);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrecomputedVisibilityLoactionComponent.__PropertyOffset_Coord) = value;
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600E8E3 RID: 59619 RVA: 0x00159F94 File Offset: 0x00158194
		// (set) Token: 0x0600E8E4 RID: 59620 RVA: 0x00159FA8 File Offset: 0x001581A8
		public unsafe FBox DataChunkActorBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrecomputedVisibilityLoactionComponent.__PropertyOffset_DataChunkActorBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrecomputedVisibilityLoactionComponent.__PropertyOffset_DataChunkActorBounds) = value;
			}
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00159FBD File Offset: 0x001581BD
		static UPrecomputedVisibilityLoactionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrecomputedVisibilityLoactionComponent");
		}

		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00159FCB File Offset: 0x001581CB
		protected UPrecomputedVisibilityLoactionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E6A RID: 32362
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrecomputedVisibilityLoactionComponent";

		// Token: 0x04007E6B RID: 32363
		private static IntPtr _ClassPtr;

		// Token: 0x04007E6C RID: 32364
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007E6D RID: 32365
		internal static int __PropertyOffset_Coord;

		// Token: 0x04007E6E RID: 32366
		internal static int __PropertyOffset_DataChunkActorBounds;
	}
}
