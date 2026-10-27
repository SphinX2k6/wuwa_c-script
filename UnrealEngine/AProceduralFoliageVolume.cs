using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D9 RID: 4825
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageVolume")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class AProceduralFoliageVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011B26 RID: 72486 RVA: 0x0019FBC6 File Offset: 0x0019DDC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AProceduralFoliageVolume._ClassPtr;
		}

		// Token: 0x06011B27 RID: 72487 RVA: 0x0019FBD4 File Offset: 0x0019DDD4
		public AProceduralFoliageVolume() : this(BuiltinUtils.AllocNativeUObject(AProceduralFoliageVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011B28 RID: 72488 RVA: 0x0019FBFC File Offset: 0x0019DDFC
		[NullableContext(1)]
		public AProceduralFoliageVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AProceduralFoliageVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x06011B29 RID: 72489 RVA: 0x0019FC2F File Offset: 0x0019DE2F
		// (set) Token: 0x06011B2A RID: 72490 RVA: 0x0019FC43 File Offset: 0x0019DE43
		[Nullable(2)]
		public unsafe UProceduralFoliageComponent ProceduralComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralFoliageComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AProceduralFoliageVolume.__PropertyOffset_ProceduralComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AProceduralFoliageVolume.__PropertyOffset_ProceduralComponent, value);
			}
		}

		// Token: 0x06011B2B RID: 72491 RVA: 0x0019FC58 File Offset: 0x0019DE58
		static AProceduralFoliageVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.ProceduralFoliageVolume");
		}

		// Token: 0x06011B2C RID: 72492 RVA: 0x0019FC66 File Offset: 0x0019DE66
		protected AProceduralFoliageVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097E2 RID: 38882
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.ProceduralFoliageVolume";

		// Token: 0x040097E3 RID: 38883
		private static IntPtr _ClassPtr;

		// Token: 0x040097E4 RID: 38884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097E5 RID: 38885
		internal static int __PropertyOffset_ProceduralComponent;
	}
}
