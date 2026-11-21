using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032B RID: 811
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletPatternDataAsset")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroBulletPatternDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060054F4 RID: 21748 RVA: 0x00076DA6 File Offset: 0x00074FA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletPatternDataAsset._ClassPtr;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00076DB4 File Offset: 0x00074FB4
		public UKuroBulletPatternDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPatternDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00076DDC File Offset: 0x00074FDC
		[NullableContext(1)]
		public UKuroBulletPatternDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPatternDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00076E0F File Offset: 0x0007500F
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x00076E1F File Offset: 0x0007501F
		public unsafe float PatternDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_PatternDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_PatternDuration) = value;
			}
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00076E30 File Offset: 0x00075030
		static UKuroBulletPatternDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletPatternDataAsset");
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00076E3E File Offset: 0x0007503E
		protected UKuroBulletPatternDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022B5 RID: 8885
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletPatternDataAsset";

		// Token: 0x040022B6 RID: 8886
		private static IntPtr _ClassPtr;

		// Token: 0x040022B7 RID: 8887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022B8 RID: 8888
		internal static int __PropertyOffset_PatternDuration;
	}
}
