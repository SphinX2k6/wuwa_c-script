using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D5 RID: 4821
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageComponent")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UProceduralFoliageComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011AEB RID: 72427 RVA: 0x0019F6E5 File Offset: 0x0019D8E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProceduralFoliageComponent._ClassPtr;
		}

		// Token: 0x06011AEC RID: 72428 RVA: 0x0019F6F4 File Offset: 0x0019D8F4
		public UProceduralFoliageComponent() : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x0019F71C File Offset: 0x0019D91C
		[NullableContext(1)]
		public UProceduralFoliageComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x06011AEE RID: 72430 RVA: 0x0019F74F File Offset: 0x0019D94F
		// (set) Token: 0x06011AEF RID: 72431 RVA: 0x0019F763 File Offset: 0x0019D963
		public unsafe UProceduralFoliageSpawner FoliageSpawner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralFoliageSpawner>(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageComponent.__PropertyOffset_FoliageSpawner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageComponent.__PropertyOffset_FoliageSpawner, value);
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x06011AF0 RID: 72432 RVA: 0x0019F778 File Offset: 0x0019D978
		// (set) Token: 0x06011AF1 RID: 72433 RVA: 0x0019F788 File Offset: 0x0019D988
		public unsafe float TileOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageComponent.__PropertyOffset_TileOverlap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageComponent.__PropertyOffset_TileOverlap) = value;
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x06011AF2 RID: 72434 RVA: 0x0019F799 File Offset: 0x0019D999
		// (set) Token: 0x06011AF3 RID: 72435 RVA: 0x0019F7AD File Offset: 0x0019D9AD
		public unsafe AVolume SpawningVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AVolume>(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageComponent.__PropertyOffset_SpawningVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageComponent.__PropertyOffset_SpawningVolume, value);
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x06011AF4 RID: 72436 RVA: 0x0019F7C2 File Offset: 0x0019D9C2
		// (set) Token: 0x06011AF5 RID: 72437 RVA: 0x0019F7D6 File Offset: 0x0019D9D6
		public unsafe FGuid ProceduralGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageComponent.__PropertyOffset_ProceduralGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageComponent.__PropertyOffset_ProceduralGuid) = value;
			}
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x0019F7EB File Offset: 0x0019D9EB
		static UProceduralFoliageComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.ProceduralFoliageComponent");
		}

		// Token: 0x06011AF7 RID: 72439 RVA: 0x0019F7F9 File Offset: 0x0019D9F9
		protected UProceduralFoliageComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097C4 RID: 38852
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.ProceduralFoliageComponent";

		// Token: 0x040097C5 RID: 38853
		private static IntPtr _ClassPtr;

		// Token: 0x040097C6 RID: 38854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097C7 RID: 38855
		internal static int __PropertyOffset_FoliageSpawner;

		// Token: 0x040097C8 RID: 38856
		internal static int __PropertyOffset_TileOverlap;

		// Token: 0x040097C9 RID: 38857
		internal static int __PropertyOffset_SpawningVolume;

		// Token: 0x040097CA RID: 38858
		internal static int __PropertyOffset_ProceduralGuid;
	}
}
